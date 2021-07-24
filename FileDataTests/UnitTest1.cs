using FileData.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileDataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void show_error_in_console_if_args_length_less_than_2()
        {
            object res = new FileInformation().showFileInfo(new string[] { "c:/text.txt" });
            Assert.AreEqual(res, "Please pass appropriate arguments.");
        }

        [TestMethod]
        public void show_error_in_console_if_args_are_not_proper()
        {
            object res = new FileInformation().showFileInfo(new string[] { "--k", "c:/text.txt" });
            Assert.AreEqual(res, "Arguments are not proper.");
        }

        [TestMethod]
        public void get_version_if_passed_v()
        {
            object res = new FileInformation().showFileInfo(new string[] { "-v", "c:/text.txt" });
            Assert.IsInstanceOfType(res, typeof(string));
        }

        [TestMethod]
        public void get_version_if_passed_s()
        {
            object res = new FileInformation().showFileInfo(new string[] { "-s", "c:/text.txt" });
            Assert.IsInstanceOfType(res, typeof(int));
        }

        [TestMethod]
        public void get_version_if_passed_diff_s()
        {
            object res = new FileInformation().showFileInfo(new string[] { "--s", "c:/text.txt" });
            Assert.IsInstanceOfType(res, typeof(int));
        }
    }
}
