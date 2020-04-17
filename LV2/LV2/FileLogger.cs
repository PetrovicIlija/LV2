using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LV2
{
    //4.zadatak
    //class FileLogger : ILogger
    //{
    //    private string path;

    //    public FileLogger(string path)
    //    {
    //        this.path = path;
    //    }

    //    public void Log(string message)
    //    {
    //        File.WriteAllText(path, message);
    //    }
    //}
    
    
        //5.zadatak
    class FileLogger : ILogger
    {
        private string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void Log(ILogable message)
        {
            File.WriteAllText(path, message.GetStringRepresentation());
        }
    }
}
