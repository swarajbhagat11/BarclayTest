using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public static class ExceptionHandling
    {
        // this method is handling exception globally
        public static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            // we can handle error with advanced option eg. log error in files, DB
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
