using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public  class LogManager
    {

        private static LogManager _instance;

     public static LogManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new LogManager();
                   
                }
                return _instance;
            }
        }
        private LogManager() // Constructor as Private
        {
            string log = "log info";
             WriteLog(log);
        }

        public void WriteLog(string message)
        {
            Console.WriteLine(message);

        }
        
    }
}
