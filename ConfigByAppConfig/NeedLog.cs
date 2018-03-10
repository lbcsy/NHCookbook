using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using log4net;

namespace ConfigByAppConfig
{
    class NeedLog
    {
        private ILog log = LogManager.GetLogger(typeof(NeedLog));

        public string DoSomething()
        {
            log.Debug("We're doing something.");
            try
            {
                return File.ReadAllText("cheese.txt");
            }
            catch(FileNotFoundException ex)
            {
                log.Error("Somebody moved my cheese.txt");
                throw;
            }
        }
    }
}
