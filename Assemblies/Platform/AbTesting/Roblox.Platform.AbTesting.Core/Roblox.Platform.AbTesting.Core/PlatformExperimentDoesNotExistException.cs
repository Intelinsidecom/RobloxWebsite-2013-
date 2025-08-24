using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// The exception that is thrown when an enrollment failed because the experiment has not been created yet.
/// </summary>
public class PlatformExperimentDoesNotExistException : PlatformInvalidOperationException
{
	public PlatformExperimentDoesNotExistException()
	{
	}

	public PlatformExperimentDoesNotExistException(string message)
		: base(message)
	{
	}

	public PlatformExperimentDoesNotExistException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
