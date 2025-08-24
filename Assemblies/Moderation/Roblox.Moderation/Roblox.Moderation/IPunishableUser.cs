namespace Roblox.Moderation;

public interface IPunishableUser
{
	long ID { get; }

	void SetAccountStatus(IAccountStatus accountStatus, bool overrideProgression);
}
