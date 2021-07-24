using FileData.BLL;
using System;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // UnhandledExceptionTrapper method to handle exception globally 
            AppDomain.CurrentDomain.UnhandledException += ExceptionHandling.UnhandledExceptionTrapper;

            Console.WriteLine(new FileInformation().showFileInfo(args));
        }
    }
}
