using System.ComponentModel;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Represents a type of action that requires a verification code if two step verification is enabled.
/// </summary>
public enum TwoStepVerificationActionType
{
	/// <summary>
	/// The user is signing in.
	/// </summary>
	[Description("login")]
	Login = 1
}
