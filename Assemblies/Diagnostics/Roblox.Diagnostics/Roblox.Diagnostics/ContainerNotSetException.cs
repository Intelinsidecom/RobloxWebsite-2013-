using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.Diagnostics;

/// <summary>
/// An exception thrown when trying to add counters with <see cref="T:Roblox.Diagnostics.ICounterBuilder" />
/// when the container has not yet been set.
/// </summary>
[ExcludeFromCodeCoverage]
public class ContainerNotSetException : Exception
{
}
