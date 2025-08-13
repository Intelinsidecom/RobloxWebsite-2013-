using Roblox.Platform.TwoStepVerification;

namespace Roblox.Web.Authentication;

/// <summary>
/// A class to hold data for two step verification on login.
/// </summary>
internal class LoginTwoStepVerificationData : ITwoStepVerificationData
{
	/// <inheritdoc />
	public TwoStepVerificationMediaType MediaType { get; set; }

	/// <inheritdoc />
	public string Ticket { get; set; }
}
