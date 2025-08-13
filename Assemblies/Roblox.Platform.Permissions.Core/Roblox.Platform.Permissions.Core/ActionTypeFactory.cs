namespace Roblox.Platform.Permissions.Core;

public class ActionTypeFactory
{
	public static IActionType GetActionType(string value)
	{
		return new ActionType(value);
	}
}
