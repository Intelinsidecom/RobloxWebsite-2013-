using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Prometheus;

namespace Roblox.LightUtils
{
    public class CircuitBreakerBuilder<T> : DispatchProxy
    {
        public static T Create(T decorated, ITelemetry telemetry, Func<Exception, bool> onShouldCircuitBreakException = null)
        {
            var result = Create<T, CircuitBreakerBuilder<T>>();
            ((CircuitBreakerBuilder<T>)(object)result).SetParams(decorated, telemetry, onShouldCircuitBreakException);
            return (T)(object)result;
        }
        public static T CreateEnhanceAllPublic(T decorated, string appName, ITelemetry telemetry, Func<Exception, bool> onShouldCircuitBreakException = null)
        {
            var result = Create<T, CircuitBreakerBuilder<T>>();
            ((CircuitBreakerBuilder<T>)(object)result).SetParams(decorated, telemetry, onShouldCircuitBreakException, true);
            return (T)(object)result;
        }
        private void SetParams(T decorated, ITelemetry telemetry, Func<Exception, bool> onShouldCircuitBreakException = null, bool assumeAllAttributesSet = false)
        {
            _Decorated = decorated;
            _DecoratedName = decorated.GetType().Name;
            _Telemetry = telemetry ?? throw new ArgumentNullException(nameof(telemetry));
            _RobloxCommands = new Dictionary<string, RobloxCommand>();
            _OnShouldCircuitBreakException = onShouldCircuitBreakException;
            ProcessAttributes(assumeAllAttributesSet);
        }
        private void ProcessAttributes(bool assumeAllAttributesSet = false)
        {
            _EnableCircuitBreakerAttribute = (EnableCircuitBreaker)_Decorated.GetType().GetCustomAttribute(typeof(EnableCircuitBreaker));
            if (assumeAllAttributesSet) _EnableCircuitBreakerAttribute = _DefaultEnableCircuitBreakerAttribute;
            if (_EnableCircuitBreakerAttribute == null) throw new ArgumentException($"[EnableCircuitBreaker] Attribute is missing on a class {_Decorated.GetType().Name}. Please add it.");
            foreach (var info in _Decorated.GetType().GetMethods())
            {
                RobloxCommand command = null;
                if (assumeAllAttributesSet)
                {
                    if (info.IsPublic && !info.IsAbstract && info.MemberType == MemberTypes.Method)
                    {
                        command = _DefaultRobloxCommand;
                    }
                }
                else
                {
                    command = (RobloxCommand)info.GetCustomAttribute(typeof(RobloxCommand));
                }
                if (command != null)
                {
                    SimpleLogger.Trace($"Enhancing {_DecoratedName}.{info.Name}");
                    if (!_RobloxCommands.ContainsKey(info.Name))
                    {
                        _RobloxCommands.Add(info.Name, command);
                        ProcessFallbackMethod(info, command);
                    }
                }
            }
        }
        private void ProcessFallbackMethod(MethodInfo method, RobloxCommand robloxCommand)
        {
            if (string.IsNullOrWhiteSpace(robloxCommand.FallbackMethod)) return;
            var fallback = _Decorated.GetType().GetMethod(robloxCommand.FallbackMethod);
            if (fallback.ReturnType != method.ReturnType) throw new CustomAttributeFormatException($"Fallback method {fallback.Name} does not have the same return type as {method.Name} in {_DecoratedName}");
            var methodParameters = method.GetParameters();
            var fallbackParameters = fallback.GetParameters();
            if (methodParameters.Length != fallbackParameters.Length) SimpleLogger.Warning($"Fallback method for {_DecoratedName}.{method.Name} does not have the same number of parameters.", null);
            else
            {
                for (int i = 0; i < methodParameters.Length; i++)
                    if (methodParameters[i].ParameterType != fallbackParameters[i].ParameterType)
                        SimpleLogger.Warning($"Fallback method for {_DecoratedName}.{method.Name} does not have same [{i}] parameter", null);
            }
            robloxCommand.FallbackMethodInfo = fallback;
        }
        private CircuitBreakerState CreateBreakerState()
        {
            string type = TelemetryType.circuit_breaker.ToString().ToLower() ?? "";
            return new CircuitBreakerState
            {
                CallerName = _DecoratedName,
                State = 1,
                TimeWindowsEnds = (default(DateTime) + TimeSpan.FromSeconds(_EnableCircuitBreakerAttribute.CheckTimeWindowSeconds)).Ticks,
                CircuitOpenCounter = Metrics.CreateCounter($"{type}_open_circuit_total", "Total number of times circuit has been opened", "CallerName"),
                CurrentStateGauge = Metrics.CreateGauge($"{type}_state", "Current state of circuit breakers for application", "CallerName")
            };
        }
        private void UpdateState()
        {
            if (_CircuitBreakerState.State == 1)
            {
                if (DateTime.UtcNow > new DateTime(_CircuitBreakerState.TimeWindowsEnds))
                {
                    Interlocked.Exchange(ref _CircuitBreakerState.FailCounter, 0L);
                    Interlocked.Exchange(ref _CircuitBreakerState.SuccessCounter, 0L);
                    Interlocked.Exchange(ref _CircuitBreakerState.TimeWindowsEnds, (DateTime.UtcNow + TimeSpan.FromSeconds(_EnableCircuitBreakerAttribute.CheckTimeWindowSeconds)).Ticks);
                }
                return;
            }
            if (_CircuitBreakerState.State == 2 && DateTime.UtcNow > new DateTime(_CircuitBreakerState.OpenTimestampExpires)) HalfOpenCircuit(_CircuitBreakerState);
        }

        private void OpenCircuit(CircuitBreakerState breakerState)
        {
            SimpleLogger.Warning($"{_DecoratedName} circuit is OPEN");
            breakerState.CircuitOpenCounter.WithLabels(_DecoratedName).Inc(1.0);
            breakerState.CurrentStateGauge.WithLabels(_DecoratedName).Set(2.0);
            Interlocked.Exchange(ref breakerState.State, 2);
            Interlocked.Exchange(ref breakerState.OpenTimestampExpires, (DateTime.UtcNow + TimeSpan.FromSeconds(_EnableCircuitBreakerAttribute.OpenTimeoutSeconds)).Ticks);
        }

        private void CloseCircuit(CircuitBreakerState breakerState)
        {
            SimpleLogger.Warning($"{_DecoratedName} circuit is CLOSED");
            breakerState.CurrentStateGauge.WithLabels(_DecoratedName).Set(1.0);
            Interlocked.Exchange(ref breakerState.State, 1);
            Interlocked.Exchange(ref breakerState.FailCounter, 0L);
            Interlocked.Exchange(ref breakerState.SuccessCounter, 0L);
        }

        private void HalfOpenCircuit(CircuitBreakerState breakerState)
        {
            SimpleLogger.Warning($"{_DecoratedName} circuit is HALF-OPEN");
            breakerState.CurrentStateGauge.WithLabels(_DecoratedName).Set(3.0);
            Interlocked.Exchange(ref breakerState.State, 3);
            Interlocked.Exchange(ref breakerState.FailCounter, 0L);
            Interlocked.Exchange(ref breakerState.SuccessCounter, 0L);
        }

        private object ActuallyInvoke(MethodInfo targetMethod, object[] args, Action onDone = null, Action<Exception> onFail = null)
        {
            var targetMethodResult = targetMethod.Invoke(_Decorated, args);
            if (targetMethodResult is Task taskedTargetResult)
            {
                taskedTargetResult.ContinueWith((task) => onDone?.Invoke(), TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled | TaskContinuationOptions.ExecuteSynchronously);
                taskedTargetResult.ContinueWith((task) => onFail?.Invoke(task.Exception.InnerException), TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnCanceled | TaskContinuationOptions.ExecuteSynchronously);
                return targetMethodResult;
            }
            onDone?.Invoke();
            return targetMethodResult;
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
                if (breakerState.FailCounter >= _EnableCircuitBreakerAttribute.FailureThreshold)
                {
                    OpenCircuit(breakerState);
                    return;
                }
                else if (breakerState.State == 3) OpenCircuit(breakerState);
        }

        private object GetContext(MethodInfo targetInfo, object[] args)
        {
            var context = new Dictionary<string, object>();
            var parameters = targetInfo.GetParameters();
            int num = 0;
            foreach (var arg in args)
            {
                if (arg.GetType().IsPrimitive) context.Add(parameters[num].Name, arg);
                num++;
            }
            return context;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            if (targetMethod == null) throw new ArgumentException(null, nameof(targetMethod));
            if (!_RobloxCommands.ContainsKey(targetMethod.Name)) return ActuallyInvoke(targetMethod, args);
            var command = _RobloxCommands[targetMethod.Name];
            if (command.UseCircuitBreaking)
            {
                if (_CircuitBreakerState == null) _CircuitBreakerState = CreateBreakerState();
                UpdateState();
                if (_CircuitBreakerState.State == 2)
                {
                    if (command.FallbackMethodInfo != null)
                    {
                        var fallbackLatency = command.UseTelementry ? _Telemetry.PreInvoke(_DecoratedName, command.FallbackMethodInfo.Name, null) : Stopwatch.StartNew();
                        return ActuallyInvoke(command.FallbackMethodInfo, args, () =>
                        {
                            if (command.UseTelementry) _Telemetry.PostInvokeSuccess(fallbackLatency, _DecoratedName, command.FallbackMethodInfo.Name, null); 
                        }, delegate (Exception ex)
                        {
                            if (command.UseTelementry) _Telemetry.PostInvokeFailure(fallbackLatency, _DecoratedName, command.FallbackMethodInfo.Name, ex, null);
                        });
                    }
                    throw new CircuitOpenException($"{_DecoratedName} CircuitBreaker - Opened");
                }
            }
            var latency = command.UseTelementry ? _Telemetry.PreInvoke(_DecoratedName, targetMethod.Name) : Stopwatch.StartNew();
            return ActuallyInvoke(targetMethod, args, () =>
            {
                if (command.UseCircuitBreaking) HandleSuccess(_CircuitBreakerState); 
                if (command.UseTelementry) _Telemetry.PostInvokeSuccess(latency, _DecoratedName, targetMethod.Name); 
            }, delegate (Exception ex)
            {
                if (command.UseCircuitBreaking)
                {
                    var shouldCircuitBreakException = true;
                    if (_OnShouldCircuitBreakException != null) shouldCircuitBreakException = _OnShouldCircuitBreakException(ex);
                    if (shouldCircuitBreakException) HandleFailure(_CircuitBreakerState);
                }
                if (command.UseTelementry)
                {
                    var context = GetContext(targetMethod, args);
                    _Telemetry.PostInvokeFailure(latency, _DecoratedName, targetMethod.Name, ex, context);
                }
            });
        }

        private static readonly RobloxCommand _DefaultRobloxCommand = new RobloxCommand(true, null, true);
        private static readonly EnableCircuitBreaker _DefaultEnableCircuitBreakerAttribute = new EnableCircuitBreaker(3, 60, 60);
        private CircuitBreakerState _CircuitBreakerState;
        private T _Decorated;
        private string _DecoratedName;
        private ITelemetry _Telemetry;
        private EnableCircuitBreaker _EnableCircuitBreakerAttribute;
        private Dictionary<string, RobloxCommand> _RobloxCommands;
        private Func<Exception, bool> _OnShouldCircuitBreakException;
    }
}
