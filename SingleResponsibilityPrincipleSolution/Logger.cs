using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleSolution
{
    public class Logger : ILogger
    {
        public Logger()
        {
            // here we need to write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }
        public void Info(string info)
        {
            // here we need to write the Code for info information into the ErrorLog text file
            System.IO.File.AppendAllText(@"c:\InfoLog.txt", "\n" + info);
        }
        public void Debug(string info)
        {
            // here we need to write the Code for Debug information into the ErrorLog text file
            System.IO.File.AppendAllText(@"c:\DebugLog.txt", info);
        }
        public void Error(string message, Exception ex)
        {
            // here we need to write the Code for Error information into the ErrorLog text file
            System.IO.File.AppendAllText(@"c:\ErrorLog.txt", ex.ToString());
        }
    }
}
