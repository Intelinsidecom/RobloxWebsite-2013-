using System;
using System.Threading.Tasks;

namespace Roblox.LightUtils
{
	public interface ICircuitBreaker
	{
		Task<T> Execute<T>(string callerName, string methodName, Func<Task<T>> funcToInvoke, object context = null, Func<Task<T>> fallbackMethodToInvoke = null);
		T ExecuteSync<T>(string callerName, string methodName, Func<T> funcToInvoke, object context = null, Func<T> fallbackMethodToInvoke = null);
		bool IsOpen(string callerName);
		bool IsClosed(string callerName);
		bool IsHalfOpen(string callerName);
	}
}
