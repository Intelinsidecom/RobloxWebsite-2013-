using Roblox.Platform.TwoStepVerification;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents a container for two step verification data using more secure tickets
/// </summary>
public interface ITwoStepVerificationDataV2
{
	/// <summary>
	/// The <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.MediaType" />.
	/// </summary>
	TwoStepVerificationMediaType MediaType { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Id" /> ticket as a secure blob
	/// </summary>
	string Ticket { get; }
}
