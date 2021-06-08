using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5paisaAPI
{
    public class LogRunner
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public void LogInformation(string StrFrame)
        {
            //if (Program.logit == "1")
            if (true)
            {
                Logger.Info("\r\n" + StrFrame + "\r\n#*****************#");
            }

        }
    }
}
