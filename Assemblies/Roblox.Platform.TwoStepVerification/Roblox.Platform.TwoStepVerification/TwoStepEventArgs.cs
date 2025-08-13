using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepEventArgs
{
	public IUser User { get; set; }

	public bool IsEnabledChanged { get; set; }

	public bool IsEnabled { get; set; }

	public bool MediaTypeChanged { get; set; }

	public TwoStepVerificationMediaType MediaType { get; set; }
}
