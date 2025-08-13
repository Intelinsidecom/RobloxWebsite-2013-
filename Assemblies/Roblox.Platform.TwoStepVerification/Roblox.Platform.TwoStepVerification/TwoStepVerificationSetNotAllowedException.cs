using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.TwoStepVerification;

[ExcludeFromCodeCoverage]
public class TwoStepVerificationSetNotAllowedException : PlatformException
{
	public TwoStepVerificationSetNotAllowedException()
	{
	}

	public TwoStepVerificationSetNotAllowedException(string description)
		: base(description)
	{
	}

	public TwoStepVerificationSetNotAllowedException(string description, Exception innerException)
		: base(description, innerException)
	{
	}
}
