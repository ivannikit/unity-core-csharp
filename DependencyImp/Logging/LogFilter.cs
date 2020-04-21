namespace TeamZero.Core.Logging
{
    public class LogFilter : ILogFilter
    {
        private readonly bool _logInfo;
        private readonly bool _logWarning;
        private readonly bool _logError;

        public LogFilter(bool info, bool warning, bool error)
        {
            _logInfo = info;
            _logWarning = warning;
            _logError = error;
        }

        public bool IsInfo() => _logInfo;

        public bool IsWarning() => _logWarning;

        public bool IsError() => _logError;
    }
}