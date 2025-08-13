using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Roblox.LightUtils
{
	public interface ITelemetry
	{
		Task<T> Wrap<T>(string caller, string methodName, Func<Task<T>> method, object context = null);
		Task<T> Wrap<T>(TelemetryType telemetryType, string caller, string methodName, Func<Task<T>> method, object context = null);
		Task Wrap(string caller, string methodName, Func<Task> action, object context = null);
		Task Wrap(TelemetryType telemetryType, string caller, string methodName, Func<Task> action, object context = null);
		void WrapSync(string caller, string methodName, Action action, object context = null);
		void WrapSync(TelemetryType telemetryType, string caller, string methodName, Action action, object context = null);
		T WrapSync<T>(string caller, string methodName, Func<T> action, object context = null);
		T WrapSync<T>(TelemetryType telemetryType, string caller, string methodName, Func<T> action, object context = null);
		Stopwatch PreInvoke(string caller, string methodName, object context = null);
		void PostInvokeSuccess(Stopwatch watch, string caller, string methodName, object context = null);
		void PostInvokeFailure(Stopwatch watch, string caller, string methodName, Exception ex, object context = null);
		Stopwatch PreInvoke(TelemetryType telemetryType, string caller, string methodName, object context = null);
		void PostInvokeSuccess(TelemetryType telemetryType, Stopwatch watch, string caller, string methodName, object context = null);
		void PostInvokeFailure(TelemetryType telemetryType, Stopwatch watch, string caller, string methodName, Exception ex, object context = null);
	}
}
