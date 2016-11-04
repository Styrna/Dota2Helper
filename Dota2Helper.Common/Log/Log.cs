using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Dota2Helper.Common.Log
{
    public interface ILog
    {
        void Trace(string message, Exception ex = null);
        void Debug(string message, Exception ex = null);
        void Info(string message, Exception ex = null);
        void Warn(string message, Exception ex = null);
        void Error(string message, Exception ex = null);
        void Fatal(string message, Exception ex = null);
    }
    public class Log : ILog
    {
        private readonly Logger _nLogger;

        public Log(Type type)
        {
            _nLogger = LogManager.GetLogger(type.FullName);
        }

        public void Trace(string message, Exception ex = null) => LogMessage(LogLevel.Trace, message, ex);
        public void Debug(string message, Exception ex = null) => LogMessage(LogLevel.Debug, message, ex);
        public void Info(string message, Exception ex = null) => LogMessage(LogLevel.Info, message, ex);
        public void Warn(string message, Exception ex = null) => LogMessage(LogLevel.Warn, message, ex);
        public void Error(string message, Exception ex = null) => LogMessage(LogLevel.Error, message, ex);
        public void Fatal(string message, Exception ex = null) => LogMessage(LogLevel.Fatal, message, ex);

        private void LogMessage(LogLevel logLevel, string message, Exception ex)
        {
            var logInfo = new LogEventInfo(logLevel, _nLogger.Name, message)
            {
                Exception = ex
            };
            _nLogger.Log(typeof(Log), logInfo);
        }
    }
}
