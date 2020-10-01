﻿using System;
using JetBrains.Annotations;

#if DISABLE_INFO_LOG || DISABLE_WARNING_LOG || DISABLE_ERROR_LOG
using System.Diagnostics;
#endif

namespace TeamZero.Core.Logging
{
	public sealed class Log
	{
		private readonly ILogTarget _target;
		private readonly ILogFilter _filter;

		public Log([NotNull] ILogTarget target, [NotNull] ILogFilter filter)
        {
         	_target = target ?? throw new ArgumentNullException(nameof(target));
         	_filter = filter ?? throw new ArgumentNullException(nameof(filter));
        }

#if DISABLE_INFO_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Info(string message)
		{
			if(_filter.IsLogInfo()) 
				_target.Info(message);
		}
		
		
#if DISABLE_WARNING_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Warning(string message)
		{
			if(_filter.IsLogWarning()) 
				_target.Warning(message);
		}		
 
		
#if DISABLE_ERROR_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Error(string message)
		{
			if(_filter.IsLogError()) 
				_target.Error(message);
		}

#if DISABLE_ERROR_LOG
		[Conditional("__NEVER_DEFINED__")]
#endif
		public void Error(Exception e)
		{
			if(_filter.IsLogError()) 
				_target.Error(e);
		}
		
		
		#region Default
		
		private static Log _main;
		public static Log Main
		{
			get
			{
				if (_main == null)
				{
					ILogTarget listener = DefaultTarget();
					ILogFilter filter = DefaultFilter();
					_main = new Log(listener, filter);
				}

				return _main;
			}
			set
			{
				if(_main != null)
					throw new Exception("Default value already used");
				
				_main = value;
			}
		}
		
		public static ILogTarget DefaultTarget()
		{
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_IOS || UNITY_ANDROID
			return new UnityConsoleTarget();
#else
			throw new NotImplementedException();
#endif
		}

		public static ILogFilter DefaultFilter(bool info = true, bool warning = true, bool error = true) => 
			new LogFilter(info, warning, error);
		
		#endregion
	}
}