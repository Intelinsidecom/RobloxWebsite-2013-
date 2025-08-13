namespace Roblox.Platform.Captcha;

public class ResetPasswordAction : Action
{
	public ResetPasswordAction(long browserTrackerId, Factories factories)
		: base(new Identifier
		{
			TargetType = IdentifierTargetType.BrowserTrackerID,
			Value = browserTrackerId.ToString()
		}, ActionType.ResetPassword, factories)
	{
	}
}
