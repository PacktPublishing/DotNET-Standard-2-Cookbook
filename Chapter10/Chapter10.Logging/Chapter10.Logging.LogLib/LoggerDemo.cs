using System;
using System.IO;

namespace Chapter10.Logging.LogLib
{
    public class LoggerDemo
    {
        private string logFileName = "lib_log.txt";
        private StreamWriter logFile;

        public LoggerDemo()
        {

            WriteLog("Constructor Called");
           
        }

        private void WriteLog(string message)
        {
            try
            {
                if (!File.Exists(logFileName))
                {
                    logFile = File.CreateText(logFileName);
                }
                else
                {
                    logFile = File.AppendText(logFileName);
                }
                logFile.WriteLine($"{DateTime.Now} Log Message: {message} ");
                
            }
            catch (FileNotFoundException)
            {
                //Cannot find the file you are looking for
            }
            catch (Exception ex)
            {
                //Catch any exception 
            }
            finally
            {
                logFile.Close(); 
            }

            
        }

        public void CallMethod1()
        {
            WriteLog("Method 1 Called");
        }

        public void CallMethod2()
        {
            WriteLog("Method 2 Called");
        }

        public void CallMethod3()
        {
            WriteLog("Method 3 Called");
        }

        
    }
}
