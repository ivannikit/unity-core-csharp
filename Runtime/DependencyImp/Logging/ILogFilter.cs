namespace TeamZero.Core.Logging
{
    public interface ILogFilter
    {
        bool IsLogInfo();

        bool IsLogWarning();

        bool IsLogError();
    }
}
