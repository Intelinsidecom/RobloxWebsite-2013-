using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;
using Prometheus;

namespace Roblox.LightUtils
{
	public class Telemetry : ITelemetry
	{
		public Telemetry()
		{
			_DurationHistograms = new ConcurrentDictionary<string, Histogram>();
			_AttemptCounters = new ConcurrentDictionary<string, Counter>();
			_SuccessCounters = new ConcurrentDictionary<string, Counter>();
			_FailCounters = new ConcurrentDictionary<string, Counter>();
			_Gauges = new ConcurrentDictionary<string, Gauge>();
		}

		public T WrapSync<T>(string caller, string methodName, Func<T> method, object context = null)
		{
			var watch = PreInvoke(caller, methodName, context);
			try
			{
				var data = method();
				PostInvokeSuccess(watch, caller, methodName, context);
				return data;
			}
			catch (Exception ex)
			{
				PostInvokeFailure(watch, caller, methodName, ex, context);
				throw;
			}
		}
		public T WrapSync<T>(TelemetryType telemetryType, string caller, string methodName, Func<T> method, object context = null)
		{
			var watch = PreInvoke(telemetryType, caller, methodName, context);
			try
			{
				var data = method();
				PostInvokeSuccess(telemetryType, watch, caller, methodName, context);
				return data;
			}
			catch (Exception ex)
			{
				PostInvokeFailure(telemetryType, watch, caller, methodName, ex, context);
				throw;
			}
		}
		public void WrapSync(string caller, string methodName, Action action, object context = null)
		{
			var watch = PreInvoke(caller, methodName, context);
			try
			{
				action();
				PostInvokeSuccess(watch, caller, methodName, context);
			}
			catch (Exception ex)
			{
				PostInvokeFailure(watch, caller, methodName, ex, context);
				throw;
			}
		}
		public void WrapSync(TelemetryType telemetryType, string caller, string methodName, Action action, object context = null)
		{
			var watch = PreInvoke(telemetryType, caller, methodName, context);
			try
			{
				action();
				PostInvokeSuccess(telemetryType, watch, caller, methodName, context);
			}
			catch (Exception ex)
			{
				PostInvokeFailure(telemetryType, watch, caller, methodName, ex, context);
				throw;
			}
		}
		public async Task Wrap(string caller, string methodName, Func<Task> action, object context = null)
		{
			var latency = PreInvoke(caller, methodName, context);
			try
			{
				await action();
				PostInvokeSuccess(latency, caller, methodName, context);
			}
			catch (Exception ex)
			{
				PostInvokeFailure(latency, caller, methodName, ex, context);
				throw;
			}
		}
		public async Task Wrap(TelemetryType telemetryType, string caller, string methodName, Func<Task> action, object context = null)
		{
			var latency = PreInvoke(telemetryType, caller, methodName, context);
			try
			{
				await action();
				PostInvokeSuccess(telemetryType, latency, caller, methodName, context);
			}
			catch (Exception ex)
			{
				PostInvokeFailure(telemetryType, latency, caller, methodName, ex, context);
				throw;
			}
		}
		public async Task<T> Wrap<T>(string caller, string methodName, Func<Task<T>> method, object context = null)
		{
			var latency = PreInvoke(caller, methodName, context);
			try
			{
				var data = await method();
				PostInvokeSuccess(latency, caller, methodName, context);
				return data;
			}
			catch (Exception ex)
			{
				PostInvokeFailure(latency, caller, methodName, ex, context);
				throw;
			}
		}
		public async Task<T> Wrap<T>(TelemetryType telemetryType, string caller, string methodName, Func<Task<T>> method, object context = null)
		{
			var latency = PreInvoke(telemetryType, caller, methodName, context);
			try
			{
				var data = await method();
				PostInvokeSuccess(telemetryType, latency, caller, methodName, context);
				return data;
			}
			catch (Exception ex)
			{
				PostInvokeFailure(telemetryType, latency, caller, methodName, ex, context);
				throw;
			}
		}
		public Stopwatch PreInvoke(string caller, string methodName, object context = null)
		{
			return PreInvoke(TelemetryType.all, caller, methodName, context);
		}
		public Stopwatch PreInvoke(TelemetryType telemetryType, string caller, string methodName, object context = null)
		{
            AssertParams(caller, methodName);
			SimpleLogger.Trace($"\"{caller}.{methodName}\" called", context);
			GetAttemptCounter(telemetryType).WithLabels(caller, methodName).Inc(1.0);
			GetConcurrentExecutionsGauge(telemetryType).WithLabels(caller, methodName).Inc(1.0);
			return Stopwatch.StartNew();
		}
		public void PostInvokeSuccess(Stopwatch watch, string caller, string methodName, object context = null)
		{
			PostInvokeSuccess(TelemetryType.all, watch, caller, methodName, context);
		}
		public void PostInvokeSuccess(TelemetryType telemetryType, Stopwatch watch, string caller, string methodName, object context = null)
		{
			GetConcurrentExecutionsGauge(telemetryType).WithLabels(caller, methodName).Dec(1.0);
			GetSuccessCounter(telemetryType).WithLabels(caller, methodName).Inc(1.0);
			GetDurationHistogram(telemetryType).WithLabels(caller, methodName).Observe(watch.Elapsed.TotalSeconds);
			SimpleLogger.Trace($"\"{caller}.{methodName}\" completed in {watch.ElapsedMilliseconds} ms", context);
		}
		public void PostInvokeFailure(Stopwatch watch, string caller, string methodName, Exception ex, object context = null)
		{
			PostInvokeFailure(TelemetryType.all, watch, caller, methodName, ex, context);
		}
		public void PostInvokeFailure(TelemetryType telemetryType, Stopwatch watch, string caller, string methodName, Exception ex, object context = null)
		{
			GetConcurrentExecutionsGauge(telemetryType).WithLabels(caller, methodName).Dec(1.0);
			GetFailureCounter(telemetryType).WithLabels(caller, methodName).Inc(1.0);
			SimpleLogger.Error($"\"{caller}.{methodName}\" failed", ex, context);
		}
		public static Telemetry Default()
		{
			if (_Instance != null) return _Instance;
			_Instance = new Telemetry();
			return _Instance;
		}
		private static void AssertParams(string caller, string methodName)
		{
			if (string.IsNullOrWhiteSpace(caller))
			{
				throw new ArgumentException("caller is not specified");
			}
			if (string.IsNullOrWhiteSpace(methodName))
			{
				throw new ArgumentException("methodName is not specified");
			}
		}
		private Histogram GetDurationHistogram(TelemetryType telemetryType)
		{
			string type = telemetryType.ToString().ToLower() ?? "";
			if (_DurationHistograms.ContainsKey(type))
			{
				return _DurationHistograms[type];
			}
			var histogram = Metrics.CreateHistogram($"{type}_duration_seconds", $"Duration historgram for the {telemetryType}", "Caller", "MethodName");
			_DurationHistograms.GetOrAdd(type, histogram);
			return histogram;
		}
		private static Counter GetCounter(TelemetryType telemetryType, string status, ConcurrentDictionary<string, Counter> counters)
		{
			var type = $"{telemetryType.ToString().ToLower()}_{status}";
			if (counters.ContainsKey(type))
			{
				return counters[type];
			}
			var counter = Metrics.CreateCounter($"{type}_total", $"Total number of times on {type} happened.", "Caller", "MethodName");
			counters.GetOrAdd(type, counter);
			return counter;
		}
		private Counter GetAttemptCounter(TelemetryType telemetryType)
		{
			return GetCounter(telemetryType, "attempt", _AttemptCounters);
		}
		private Counter GetSuccessCounter(TelemetryType telemetryType)
		{
			return GetCounter(telemetryType, "success", _SuccessCounters);
		}
		private Counter GetFailureCounter(TelemetryType telemetryType)
		{
			return GetCounter(telemetryType, "fail", _FailCounters);
		}
		private Gauge GetConcurrentExecutionsGauge(TelemetryType telemetryType)
		{
			var type = telemetryType.ToString().ToLower() ?? "";
			if (_Gauges.ContainsKey(type)) return _Gauges[type];
			var gauge = Metrics.CreateGauge($"{type}_concurrent_executions", $"Concurrent executions of {type}.", "Caller", "MethodName");
			_Gauges.GetOrAdd(type, gauge);
			return gauge;
		}

		private static Telemetry _Instance;
		private readonly ConcurrentDictionary<string, Counter> _AttemptCounters;
		private readonly ConcurrentDictionary<string, Histogram> _DurationHistograms;
		private readonly ConcurrentDictionary<string, Counter> _FailCounters;
		private readonly ConcurrentDictionary<string, Counter> _SuccessCounters;
		private readonly ConcurrentDictionary<string, Gauge> _Gauges;
	}
}
