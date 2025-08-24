namespace Roblox.Platform.Captcha;

public class GamecardRedemptionAction : Action
{
	public GamecardRedemptionAction(long userId, Factories factories)
		: base(new Identifier
		{
			TargetType = IdentifierTargetType.UserId,
			Value = userId.ToString()
		}, ActionType.GamecardRedemption, factories)
	{
	}
}
