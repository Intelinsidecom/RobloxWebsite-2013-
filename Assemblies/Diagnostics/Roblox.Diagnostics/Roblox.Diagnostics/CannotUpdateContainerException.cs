using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.Diagnostics;

/// <summary>
/// An exception thrown from <see cref="!:ICounterBuilder.SetContainer" />
/// when counters have already been added before calling.
/// </summary>
[ExcludeFromCodeCoverage]
public class CannotUpdateContainerException : Exception
{
}
