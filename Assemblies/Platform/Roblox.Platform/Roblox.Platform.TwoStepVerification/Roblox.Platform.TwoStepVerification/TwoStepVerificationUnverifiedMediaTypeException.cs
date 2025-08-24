using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Platform.Core;

namespace Roblox.Platform.TwoStepVerification;

[ExcludeFromCodeCoverage]
public class TwoStepVerificationUnverifiedMediaTypeException : PlatformException
{
	public TwoStepVerificationMediaType MediaType;

	public TwoStepVerificationUnverifiedMediaTypeException()
	{
	}

	public TwoStepVerificationUnverifiedMediaTypeException(TwoStepVerificationMediaType mediaType)
		: base(mediaType.ToDescription())
	{
		MediaType = mediaType;
	}

	public TwoStepVerificationUnverifiedMediaTypeException(TwoStepVerificationMediaType mediaType, Exception innerException)
		: base(mediaType.ToDescription(), innerException)
	{
		MediaType = mediaType;
	}
}
