namespace TeamZero.Core.Logging
{
    public class LogFilter : ILogFilter
    {
        private readonly bool _logInfo;
        private readonly bool _logWarning;
        private readonly bool _logError;
        private readonly bool _logException; 

        public LogFilter(bool info, bool warning, bool error, bool exception)
        {
            _logInfo = info;
            _logWarning = warning;
            _logError = error;
            _logException = exception;
        }

        public bool IsInfo() => _logInfo;

        public bool IsWarning() => _logWarning;

        public bool IsError() => _logError;
        public bool IsException() => _logException;
    }
}