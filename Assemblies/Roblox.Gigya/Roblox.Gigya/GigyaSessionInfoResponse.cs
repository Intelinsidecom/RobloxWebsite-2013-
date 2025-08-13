using Gigya.Socialize.SDK;

namespace Roblox.Gigya;

internal class GigyaSessionInfoResponse : GigyaResponseBase, IGigyaSessionInfoResponse, IGigyaResponse
{
	public override bool IsValid { get; internal set; }

	public string AuthToken { get; private set; }

	public string ProviderUid { get; private set; }

	internal GigyaSessionInfoResponse(GSResponse response)
		: base(response)
	{
		AuthToken = response.GetData().GetString("authToken", string.Empty);
		ProviderUid = response.GetData().GetString("providerUID", string.Empty);
		IsValid = true;
		if (string.IsNullOrEmpty(ProviderUid))
		{
			IsValid = false;
			base.ErrorMessage = "No providerUID returned";
		}
	}
}
