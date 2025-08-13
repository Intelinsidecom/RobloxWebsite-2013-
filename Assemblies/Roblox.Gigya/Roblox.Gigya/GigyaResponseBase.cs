using System;
using Gigya.Socialize.SDK;

namespace Roblox.Gigya;

internal abstract class GigyaResponseBase : IGigyaResponse
{
	public string ErrorMessage { get; internal set; }

	public bool IsSuccess { get; private set; }

	public abstract bool IsValid { get; internal set; }

	/// <summary>
	/// The raw data in the response.
	/// </summary>
	protected GSObject ResponseData { get; private set; }

	internal GigyaResponseBase(GSResponse response)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		ResponseData = response.GetData();
		int errorCode = response.GetErrorCode();
		IsSuccess = errorCode == 0;
		if (!IsSuccess)
		{
			ErrorMessage = $"Call failed with error code {errorCode}: {response.GetErrorMessage()}";
		}
	}
}
