namespace TeamZero.Core.Logging
{
    public interface ILogFilter
    {
        bool IsInfo();

        bool IsWarning();

        bool IsError();
    }
}
