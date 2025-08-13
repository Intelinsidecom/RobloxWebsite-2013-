using Roblox.Platform.TwoStepVerification;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents a container for two step verification data.
/// </summary>
public interface ITwoStepVerificationData
{
	/// <summary>
	/// The <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.MediaType" />.
	/// </summary>
	TwoStepVerificationMediaType MediaType { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Id" /> ticket.
	/// </summary>
	string Ticket { get; }
}
