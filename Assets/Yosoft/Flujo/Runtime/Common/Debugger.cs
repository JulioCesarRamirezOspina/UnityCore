using System;
using Yosoft.Flujo.Runtime.Common.Utils;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Local

namespace Yosoft.Flujo.Runtime.Common
{
	/// <summary> Customized debug logger class containing methods to ease debugging </summary>
	public static class Debugger
	{
		private static ILogger loggingSolution => new UnityDebug();

		private static ILogger s_logger;
		private static ILogger logger => s_logger ??= loggingSolution;

		private const string ERROR_COLOR_CODE = "#D9534F";
		private const string INFO_COLOR_CODE = "#1C7CD5";
		private const string OK_COLOR_CODE = "#5CB85C";
		private const string WARNING_COLOR_CODE = "#EE9800";

		public enum LogType
		{
			Assert,
			Error,
			Warning,
			Log,
			Exception,
		}

		private static string DoozyPrefix(LogType logType)
		{
			string colorCode = "#121212";
			switch (logType)
			{
				case LogType.Log:
					colorCode = INFO_COLOR_CODE;
					break;
				case LogType.Warning:
					colorCode = WARNING_COLOR_CODE;
					break;
				case LogType.Error:
					colorCode = ERROR_COLOR_CODE;
					break;
				case LogType.Exception:
					colorCode = ERROR_COLOR_CODE;
					break;
				case LogType.Assert:
					colorCode = OK_COLOR_CODE;
					break;
				default: throw new ArgumentOutOfRangeException(nameof(logType), logType, null);
			}

			return $"<color={colorCode}><b>DOOZY ››› </b></color>";
		}

		/// <summary> Log a message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		/// <param name="context"> Object to which the message applies </param>
		public static void Log(object message, UnityEngine.Object context = null)
		{
			message = DoozyPrefix(LogType.Log) + message;
			logger.Log(message, context);
		}

		/// <summary> Log a warning message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		/// <param name="context"> Object to which the message applies </param>
		public static void LogWarning(object message, UnityEngine.Object context = null)
		{
			message = DoozyPrefix(LogType.Warning) + message;
			logger.LogWarning(message, context);
		}

		/// <summary> Log an error message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		/// <param name="context"> Object to which the message applies </param>
		public static void LogError(object message, UnityEngine.Object context = null)
		{
			message = DoozyPrefix(LogType.Error) + message;
			logger.LogError(message, context);
		}
	}
}