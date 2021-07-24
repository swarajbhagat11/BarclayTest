using System;
using System.Linq;

namespace FileData.BLL
{
    public class FileInformation
    {
        public dynamic showFileInfo(string[] args)
        {
            string[] versionChecks = new string[] { "-v", "--v", "/v", "--version" };
            string[] sizeChecks = new string[] { "-s", "--s", "/s", "--size" };

            if (args.Length < 2)
            {
                return "Please pass appropriate arguments.";
            }

            // here based on 1st args, appropriate object will get created (injecting object) 
            // we can do it this using interface with DI container
            if (versionChecks.Contains(args[0]))
            {
                return new FileVersion().getVersion(args[1]);
            }
            else if (sizeChecks.Contains(args[0]))
            {
                return new FileSize().getSize(args[1]);
            }

            return "Arguments are not proper.";
        }
    }
}
