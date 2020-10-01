﻿#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_IOS || UNITY_ANDROID
using System;
namespace TeamZero.Core.Logging
{
	public sealed class UnityConsoleTarget : ILogTarget 
	{
		public void Info(string message)
		{
			UnityEngine.Debug.Log(message);
		}

		public void Warning(string message)
		{
			UnityEngine.Debug.LogWarning(message);
		}

		public void Error(string message)
		{
			UnityEngine.Debug.LogError(message);
		}

		public void Error(Exception e)
		{
			throw e;
		}
	}
}
#endif