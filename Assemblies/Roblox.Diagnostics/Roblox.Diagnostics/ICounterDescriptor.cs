using System.Diagnostics;

namespace Roblox.Diagnostics;

internal interface ICounterDescriptor
{
	CounterCreationData CounterCreationData { get; }
}
