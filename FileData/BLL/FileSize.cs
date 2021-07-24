using FileData.Interfaces;
using ThirdPartyTools;

namespace FileData.BLL
{
    class FileSize: IFileSize
    {
        public int getSize(string filePath)
        {
            return new FileDetails().Size(filePath);
        }
    }
}
