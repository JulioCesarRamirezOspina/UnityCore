using UnityEngine;


namespace Yosoft.Flujo.Runtime.Common
{
	/// <summary> Interface used as an extra layer when sending debug logs </summary>
	public interface ILogger
	{
		
		/// <summary> Log a message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		void Log(object message);
		
		/// <summary> Log a message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		/// <param name="context"> Object to which the message applies </param>
		void Log(object message, Object context);
		
		/// <summary> Log a warning message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		void LogWarning(object message);
		
		/// <summary> Log a warning message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		/// <param name="context"> Object to which the message applies </param>
		void LogWarning(object message, Object context);
		
		/// <summary> Log an error message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		void LogError(object message);
		
		/// <summary> Log an error message to the console </summary>
		/// <param name="message"> String or object to be converted to string representation for display </param>
		/// <param name="context"> Object to which the message applies </param>
		void LogError(object message, Object context);
	}
}