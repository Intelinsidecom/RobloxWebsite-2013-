using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Moderation;

/// <summary>
/// The exception thrown when the system failed to load the Sqs config settings 
/// for a specific moderation task queue.
/// </summary>
public class InvalidModerationQueueSettingsException : PlatformException
{
	public InvalidModerationQueueSettingsException(string message)
		: base(message)
	{
	}

	public InvalidModerationQueueSettingsException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
