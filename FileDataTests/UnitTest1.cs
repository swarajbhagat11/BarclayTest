using FileData.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileDataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void get_version_if_passed_filepath()
        {
            new FileInformation().showFileInfo("-v", "c:/text.txt");
        }
    }
}
