namespace Roblox.Platform.Chat;

public interface IParticipant
{
	int TypeId { get; }

	long TargetId { get; }
}
