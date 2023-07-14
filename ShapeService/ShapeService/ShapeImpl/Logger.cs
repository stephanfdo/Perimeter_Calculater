using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ShapeService.ShapeImpl
{
    public class Logger
    {
        //singelton pattern for logger
        private Logger() { }
        private static Logger uniqueinstance;

        public static Logger getInstance()
        {

            if (uniqueinstance == null)
                uniqueinstance = new Logger();

            return uniqueinstance;
        }

        //writing data on a textfile
        public void writingLog(string type, double perimeter)
        {

            string st = AppDomain.CurrentDomain.BaseDirectory;
            var path = st + "\\temp\\log.txt";
            try
            {
                StreamWriter sw = new StreamWriter(path, true);
                string str = "Input: " + type + " Output(perimeter): " + perimeter + "    Date & Time: " + DateTime.Now.ToString();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}