using Roblox.Platform.TwoStepVerification;

namespace Roblox.Web.Authentication;

/// <summary>
/// A class to hold data for two step verification on login using longer secure blob tickets
/// </summary>
internal class LoginTwoStepVerificationDataV2 : ITwoStepVerificationDataV2
{
	/// <inheritdoc />
	public TwoStepVerificationMediaType MediaType { get; set; }

	/// <inheritdoc />
	public string Ticket { get; set; }
}
