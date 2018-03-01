using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialization
{
    class SerializationDemo
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
        }
    }
}
