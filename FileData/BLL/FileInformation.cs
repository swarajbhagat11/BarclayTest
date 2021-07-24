using System;
using System.Linq;

namespace FileData.BLL
{
    public class FileInformation
    {
        public void showFileInfo(string queryType, string filePath)
        {
            string[] versionChecks = new string[] { "-v", "--v", "/v", "--version" };
            string[] sizeChecks = new string[] { "-s", "--s", "/s", "--size" };

            // here based on 1st args, appropriate object will get created (injecting object) 
            // we can do it this using interface with DI container
            if (versionChecks.Contains(queryType))
            {
                Console.WriteLine(new FileVersion().getVersion(filePath));
            }
            else if (sizeChecks.Contains(queryType))
            {
                Console.WriteLine(new FileSize().getSize(filePath));
            }
        }
    }
}
