using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// The exception thrown when an operation fails because an experiment was locked on.
/// </summary>
public class PlatformExperimentLockedOnException : PlatformException
{
	/// <summary>
	/// Gets the variation value that the experiment was locked onto.
	/// </summary>
	public byte VariationValue { get; private set; }

	public PlatformExperimentLockedOnException(byte variationValue)
	{
		VariationValue = variationValue;
	}

	public PlatformExperimentLockedOnException(byte variationValue, string message)
		: base(message)
	{
		VariationValue = variationValue;
	}

	public PlatformExperimentLockedOnException(byte variationValue, string message, Exception innerException)
		: base(message, innerException)
	{
		VariationValue = variationValue;
	}
}
