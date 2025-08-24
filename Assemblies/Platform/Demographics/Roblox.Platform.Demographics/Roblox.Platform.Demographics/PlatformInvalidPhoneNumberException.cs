using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

public class PlatformInvalidPhoneNumberException : PlatformArgumentException
{
	public PlatformInvalidPhoneNumberException(string message)
		: base(message)
	{
	}

	public PlatformInvalidPhoneNumberException()
	{
	}

	public PlatformInvalidPhoneNumberException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
