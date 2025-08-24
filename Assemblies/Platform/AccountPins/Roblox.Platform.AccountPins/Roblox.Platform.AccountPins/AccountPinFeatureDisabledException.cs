using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// The Pin Feature is disabled.
/// </summary>
public class AccountPinFeatureDisabledException : PlatformException
{
	public AccountPinFeatureDisabledException()
	{
	}

	public AccountPinFeatureDisabledException(string message)
		: base(message)
	{
	}

	public AccountPinFeatureDisabledException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
