using System;
using JetBrains.Annotations;

#if DISABLE_INFO_LOG || DISABLE_WARNING_LOG || DISABLE_ERROR_LOG
using System.Diagnostics;
#endif

namespace TeamZero.Core.Logging
{
	public sealed class Logger
	{
		public ILogListener Listener => _listener;
		private readonly ILogListener _listener;
		
		public ILogFilter Filter => _filter;
		private readonly ILogFilter _filter;

		public Logger([NotNull] ILogListener listener, [NotNull] ILogFilter filter)
        {
         	_listener = listener ?? throw new ArgumentNullException(nameof(listener));
         	_filter = filter ?? throw new ArgumentNullException(nameof(filter));
        }

#if DISABLE_INFO_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Info(string message)
		{
			if(_filter.IsInfo()) 
				_listener.Info(message);
		}
		
		
#if DISABLE_WARNING_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Warning(string message)
		{
			if(_filter.IsWarning()) 
				_listener.Warning(message);
		}		
 
		
#if DISABLE_ERROR_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Error(string message)
		{
			if(_filter.IsError()) 
				_listener.Error(message);
		}

#if DISABLE_EXCEPTION_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Exception(Exception e)
		{
			if(_filter.IsException()) 
				_listener.Exception(e);
		}
		
		#region Default
		
		private static Logger _default;
		public static Logger Default
		{
			get
			{
				if (_default == null)
				{
					ILogListener listener = GetDefaultListener();
					ILogFilter filter = GetDefaultFilter();
					_default = new Logger(listener, filter);
				}

				return _default;
			}
			set
			{
				if(_default != null)
					throw new Exception("Default value already used");
				
				_default = value;
			}
		}
		
		public static ILogListener GetDefaultListener()
		{
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_IOS || UNITY_ANDROID
			return new Unity.Logging.UnityConsolePublisher();
#else
			throw new NotImplementedException();
#endif
		}

		public static ILogFilter GetDefaultFilter(bool info = true, bool warning = true, bool error = true, bool exception = true) => 
			new LogFilter(info, warning, error, exception);
		
		#endregion
	}
}
