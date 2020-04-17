using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    interface ILogger
    {
        //4. zadatak
        //void Log(string message);
        void Log(ILogable message);
    }
}
