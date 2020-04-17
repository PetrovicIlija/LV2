using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    //4. zadatak
    //class ConsoleLogger : ILogger
    //{
    //    public void Log(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}
    
    //5.zadatak
    class ConsoleLogger : ILogger
    {
        public void Log(ILogable message)
        {
            Console.WriteLine(message.GetStringRepresentation());
        }
    }
}
