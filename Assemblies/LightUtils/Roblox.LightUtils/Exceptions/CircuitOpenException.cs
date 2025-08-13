using System;

namespace Roblox.LightUtils
{
	public class CircuitOpenException : Exception
	{
		public CircuitOpenException(string message) 
			: base(message)
		{
		}
	}
}
