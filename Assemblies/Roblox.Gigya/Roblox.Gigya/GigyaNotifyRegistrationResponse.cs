using Gigya.Socialize.SDK;

namespace Roblox.Gigya;

internal class GigyaNotifyRegistrationResponse : GigyaResponseBase, IGigyaNotifyRegistrationResponse, IGigyaResponse
{
	public override bool IsValid { get; internal set; }

	/// <remarks>
	/// This is allowed to be set internally because it is not actually part of the GSResponse
	/// that we receive from Gigya.
	/// </remarks>
	public string UID { get; internal set; }

	public GigyaNotifyRegistrationResponse(GSResponse response)
		: base(response)
	{
		IsValid = true;
	}
}
