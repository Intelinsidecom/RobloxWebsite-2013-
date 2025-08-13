using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Prometheus;

namespace Roblox.LightUtils
{
    public class CircuitBreaker : ICircuitBreaker
    {
        public CircuitBreaker(ITelemetry telemetry, int failureFailureThreshold = 3, TimeSpan? openTimeout = null, TimeSpan? checkTimeWindow = null)
        {
            _Telemetry = telemetry ?? throw new ArgumentNullException(nameof(telemetry));
            if (openTimeout == null)
            {
                openTimeout = new TimeSpan?(TimeSpan.FromSeconds(60.0));
            }
            if (checkTimeWindow == null)
            {
                checkTimeWindow = new TimeSpan?(TimeSpan.FromSeconds(60.0));
            }
            _CheckTimeWindow = checkTimeWindow.Value;
            _FailureThreshold = failureFailureThreshold;
            _OpenTimeout = openTimeout.Value;
        }

        public bool IsOpen(string callerName)
        {
            return GetBreakerState(callerName).State == 2;
        }
        public bool IsHalfOpen(string callerName)
        {
            return GetBreakerState(callerName).State == 3;
        }
        public bool IsClosed(string callerName)
        {
            return GetBreakerState(callerName).State == 1;
        }
        public T ExecuteSync<T>(string callerName, string methodName, Func<T> funcToInvoke, object context = null, Func<T> fallbackMethodToInvoke = null)
        {
            var breakerState = GetBreakerState(callerName);
            UpdateState(breakerState);
            var result = default(T);
            if (breakerState.State != 2)
            {
                try
                {
                    result = _Telemetry.WrapSync(callerName, methodName, () => funcToInvoke(), context);
                    HandleSuccess(breakerState);
                }
                catch
                {
                    HandleFailure(breakerState);
                    throw;
                }
                return result;
            }
            if (fallbackMethodToInvoke != null)
            {
                return _Telemetry.WrapSync(callerName, $"{methodName}_fallback", () => fallbackMethodToInvoke(), context);
            }
            throw new CircuitOpenException($"{callerName}.{methodName} CircuitBreaker - Opened");
        }
        public async Task<T> Execute<T>(string callerName, string methodName, Func<Task<T>> funcToInvoke, object context = null, Func<Task<T>> fallbackMethodToInvoke = null)
        {
            var breaker = GetBreakerState(callerName);
            UpdateState(breaker);
            if (breaker.State == 2)
            {
                if (fallbackMethodToInvoke == null)
                {
                    throw new CircuitOpenException($"{callerName}.{methodName} CircuitBreaker - Opened");
                }
                return await _Telemetry.Wrap(callerName, $"{methodName}_fallback", () => fallbackMethodToInvoke(), context);
            }
            else
            {
                var result = default(T);
                try
                {
                    result = await _Telemetry.Wrap(callerName, methodName, () => funcToInvoke(), context);
                    HandleSuccess(breaker);
                }
                catch
                {
                    HandleFailure(breaker);
                    throw;
                }
                return result;
            }
        }
        public async Task Execute(string callerName, string methodName, Func<Task> funcToInvoke, object context = null, Func<Task> fallbackMethodToInvoke = null)
        {
            var breaker = GetBreakerState(callerName);
            UpdateState(breaker);
            if (breaker.State == 2)
            {
                if (fallbackMethodToInvoke == null)
                {
                    throw new CircuitOpenException($"{callerName}.{methodName} CircuitBreaker - Opened");
                }
                await _Telemetry.Wrap(callerName, $"{methodName}_fallback", () => fallbackMethodToInvoke(), context);
            }
            else
            {
                try
                {
                    await _Telemetry.Wrap(callerName, methodName, () => funcToInvoke(), context);
                    HandleSuccess(breaker);
                }
                catch
                {
                    HandleFailure(breaker);
                    throw;
                }
            }
        }
        private CircuitBreakerState GetBreakerState(string callerName)
        {
            var type = TelemetryType.circuit_breaker.ToString().ToLower() ?? "";
            return _CircuitBreakerStates.GetOrAdd(callerName, 
                new CircuitBreakerState
                {
                    State = 1,
                    TimeWindowsEnds = (default(DateTime) + _CheckTimeWindow).Ticks,
                    CallerName = callerName,
                    CircuitOpenCounter = Metrics.CreateCounter($"{type}_open_circuit_total", "Total number of times circuit has been opened", "CallerName"),
                    CurrentStateGauge = Metrics.CreateGauge($"{type}_state", "Current state of circuit breakers for application", "CallerName")
                }
            );
        }
        private void HandleSuccess(CircuitBreakerState breakerState)
        {
            Interlocked.Increment(ref breakerState.SuccessCounter);
            if (breakerState.State == 3) CloseCircuit(breakerState);
        }
        private void HandleFailure(CircuitBreakerState breakerState)
        {
            Interlocked.Increment(ref breakerState.FailCounter);
            if (breakerState.State == 1)
            {
                if (breakerState.FailCounter >= _FailureThreshold)
                {
                    OpenCircuit(breakerState);
                    return;
                }
            }
            else if (breakerState.State == 3) OpenCircuit(breakerState);
        }
        private void OpenCircuit(CircuitBreakerState breakerState)
        {
            SimpleLogger.Warning($"{breakerState.CallerName} circuit is OPEN");
            breakerState.CircuitOpenCounter.WithLabels(breakerState.CallerName).Inc(1.0);
            breakerState.CurrentStateGauge.WithLabels(breakerState.CallerName).Set(2.0);
            Interlocked.Exchange(ref breakerState.State, 2);
            Interlocked.Exchange(ref breakerState.OpenTimestampExpires, (DateTime.UtcNow + _OpenTimeout).Ticks);
        }
        private void CloseCircuit(CircuitBreakerState breakerState)
        {
            SimpleLogger.Warning($"{breakerState.CallerName} circuit is CLOSED");
            breakerState.CurrentStateGauge.WithLabels(breakerState.CallerName).Set(1.0);
            Interlocked.Exchange(ref breakerState.State, 1);
            Interlocked.Exchange(ref breakerState.FailCounter, 0L);
            Interlocked.Exchange(ref breakerState.SuccessCounter, 0L);
        }
        private void HalfOpenCircuit(CircuitBreakerState breakerState)
        {
            SimpleLogger.Warning($"{breakerState.CallerName} circuit is HALF-OPEN");
            breakerState.CurrentStateGauge.WithLabels(breakerState.CallerName).Set(3.0);
            Interlocked.Exchange(ref breakerState.State, 3);
            Interlocked.Exchange(ref breakerState.FailCounter, 0L);
            Interlocked.Exchange(ref breakerState.SuccessCounter, 0L);
        }
        private void UpdateState(CircuitBreakerState breakerState)
        {
            if (breakerState.State == 1)
            {
                if (DateTime.UtcNow > new DateTime(breakerState.TimeWindowsEnds))
                {
                    Interlocked.Exchange(ref breakerState.FailCounter, 0L);
                    Interlocked.Exchange(ref breakerState.SuccessCounter, 0L);
                    Interlocked.Exchange(ref breakerState.TimeWindowsEnds, (DateTime.UtcNow + _CheckTimeWindow).Ticks);
                }
                return;
            }
            if (breakerState.State == 2 && DateTime.UtcNow > new DateTime(breakerState.OpenTimestampExpires)) HalfOpenCircuit(breakerState);
        }

        private static readonly ConcurrentDictionary<string, CircuitBreakerState> _CircuitBreakerStates = new ConcurrentDictionary<string, CircuitBreakerState>();
        private readonly TimeSpan _CheckTimeWindow;
        private readonly int _FailureThreshold;
        private readonly TimeSpan _OpenTimeout;
        private readonly ITelemetry _Telemetry;
    }
}
