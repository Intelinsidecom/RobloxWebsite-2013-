namespace Roblox.Platform.Permissions.Core;

internal class Action : IAction
{
	public string ActionType { get; }

	public long? ActionTargetId { get; }

	internal Action(string actionType, long? actionTargetId)
	{
		ActionType = actionType;
		ActionTargetId = actionTargetId;
	}
}
