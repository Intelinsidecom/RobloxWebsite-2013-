using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

public class PlatformPhoneNotFoundException : PlatformException
{
	public PlatformPhoneNotFoundException(string message)
		: base(message)
	{
	}

	public PlatformPhoneNotFoundException()
	{
	}

	public PlatformPhoneNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
