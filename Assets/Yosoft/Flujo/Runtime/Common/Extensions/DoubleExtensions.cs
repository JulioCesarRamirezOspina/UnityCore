using System;

namespace Yosoft.Flujo.Runtime.Common.Extensions
{
	/// <summary> Extension methods for the double struct </summary>
	public static class DoubleExtensions
	{
		/// <summary> Round number with the given number of decimals </summary>
		/// <param name="target"> Target number </param>
		/// <param name="decimals"> Number of decimals </param>
		/// <returns> Rounded value </returns>
		public static double Round(this double target, int decimals = 1) =>
			Math.Round(target, decimals);
	}
}