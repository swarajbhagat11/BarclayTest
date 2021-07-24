using FileData.Interfaces;
using ThirdPartyTools;

namespace FileData.BLL
{
    class FileVersion: IFileVersion
    {
        public string getVersion(string filePath)
        {
            return new FileDetails().Version(filePath);
        }
    }
}
