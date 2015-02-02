namespace Stealer.Targets
{
    abstract class AbstractFile
    {
        public byte[] DoJob()
        {
            return IsExist() ? GetFile() : null;
        }

        public abstract bool IsExist();
        public abstract byte[] GetFile();
    }
}
