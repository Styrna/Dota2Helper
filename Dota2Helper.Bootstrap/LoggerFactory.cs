using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Dota2Helper.Bootstrap
{
    public static class LoggerFactory
    {
        public static ILog CreateLogger(Type type)
        {
            return log4net.LogManager.GetLogger(type);
            return log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}
