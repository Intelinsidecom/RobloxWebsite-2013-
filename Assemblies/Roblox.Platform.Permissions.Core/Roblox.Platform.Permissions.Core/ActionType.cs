namespace Roblox.Platform.Permissions.Core;

internal class ActionType : IActionType
{
	public string Value { get; }

	internal ActionType(string value)
	{
		Value = value;
	}
}
