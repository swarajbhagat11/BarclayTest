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

            if (args.Length < 2)
            {
                Console.WriteLine("Please pass arguments.");
            }
            else
            {
                new FileInformation().showFileInfo(args[0], args[1]);
            }
        }
    }
}
