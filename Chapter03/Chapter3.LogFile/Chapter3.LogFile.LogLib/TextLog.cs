using System;
using System.IO;

namespace Chapter3.LogFile.LogLib
{
    public class TextLog
    {
        private string logFileName = "server_log.txt";
        private StreamWriter logFile;

        public TextLog()
        {
            if (!File.Exists(logFileName))
            {
                logFile = File.CreateText(logFileName);
            }
            else
            {
                logFile = File.AppendText(logFileName);
            } 
        }

        public void WriteLog(string message)
        {
            logFile.WriteLine($"{DateTime.Now} Log Message: {message} ");
        }

        public void CloseLog()
        {
            logFile.Close();
        }
    }
}