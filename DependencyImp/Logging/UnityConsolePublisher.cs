#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_IOS || UNITY_ANDROID
using TeamZero.Core.Logging;

namespace TeamZero.Core.Unity.Logging
{
	public sealed class UnityConsolePublisher : ILogListener 
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
	}
}
#endif
