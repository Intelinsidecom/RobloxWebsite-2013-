using System;
using Roblox.Platform.Core.Properties;

namespace Roblox.Platform.Core;

public class PlatformException : Exception
{
	[Obsolete("User facing messaging should be handled by the topmost consumer, not Platform code")]
	public readonly string UserFacingMessage;

	public virtual bool ShouldSkipLogging => Settings.Default.ShouldSkipLogging;

	public PlatformException()
	{
	}

	public PlatformException(string message, string userFacingMessage = null)
		: base(message)
	{
		UserFacingMessage = userFacingMessage;
	}

	public PlatformException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
