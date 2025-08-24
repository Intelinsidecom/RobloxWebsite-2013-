namespace Roblox.Platform.Permissions.Core;

public interface IAction
{
	string ActionType { get; }

	long? ActionTargetId { get; }
}
