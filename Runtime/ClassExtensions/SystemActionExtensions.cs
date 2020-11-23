using System;

namespace TeamZero.Core
{
    public static class SystemActionExtensions
    {
#if NET_4_6
        [Obsolete("This method is obsolete (on .NET 4.x). Use <?.Invoke> instead.")]
#endif
        public static bool TryInvoke(this Action action, bool exception = false)
        {
            if (action != null)
            {
                action.Invoke();
                return true;
            }
            else
            {
                if (exception)
                    throw new NullReferenceException();
                return false;
            }
        }

#if NET_4_6
        [Obsolete("This method is obsolete (on .NET 4.x). Use <?.Invoke> instead.")]
#endif
        public static bool TryInvoke<T>(this Action<T> action, T parameter, bool exception = false)
        {
            if (action != null)
            {
                action.Invoke(parameter);
                return true;
            }
            else
            {
                if (exception)
                    throw new NullReferenceException();
                return false;
            }
        }

#if NET_4_6
        [Obsolete("This method is obsolete (on .NET 4.x). Use <?.Invoke> instead.")]
#endif
        public static bool TryInvoke<T1, T2>(this Action<T1, T2> action, T1 parameter1, T2 parameter2, bool exception = false)
        {
            if (action != null)
            {
                action.Invoke(parameter1, parameter2);
                return true;
            }
            else
            {
                if (exception)
                    throw new NullReferenceException();
                return false;
            }
        }
    }
}