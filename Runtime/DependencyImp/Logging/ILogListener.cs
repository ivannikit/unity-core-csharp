using System;

namespace TeamZero.Core.Logging
{
    public interface ILogListener
    {
        void Info(string message);

        void Warning(string message);

        void Error(string message);
        
        void Exception(Exception e);
    }
}
