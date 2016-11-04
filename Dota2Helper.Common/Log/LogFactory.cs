using System;

namespace Dota2Helper.Common.Log
{
    public static class LogFactory
    {
        public static ILog Create(Type type)
        {
            return new Log(type);
        }
    }
}
