using System.Diagnostics;

namespace Roblox.Diagnostics
{
    // Wrapper to avoid CS0618 at call sites while preserving existing perf counter behavior.
    public static class CounterInitializer
    {
        public static void InitializeMultiInstance(string categoryName, string instanceName, params CounterDescriptor[] counterDescriptors)
        {
#pragma warning disable 618 // CounterCreator is obsolete: 'Use Roblox.Instrumentation instead of Windows Perfmon counters'
            CounterCreator.InitializeMultiInstance(categoryName, instanceName, counterDescriptors);
#pragma warning restore 618
        }

        public static void InitializeSingleInstance(string categoryName, params CounterDescriptor[] counterDescriptors)
        {
#pragma warning disable 618 // CounterCreator is obsolete: 'Use Roblox.Instrumentation instead of Windows Perfmon counters'
            CounterCreator.InitializeSingleInstance(categoryName, counterDescriptors);
#pragma warning restore 618
        }
    }
}
