namespace Roblox.Caching;

internal interface IEntityRampUpAuthority
{
	void TouchRampUp();

	void TouchRampUp(string entityType);

	bool IsEntityTypeInRampUp(string entityType);

	bool IsRemoteCacheable(string entityType);
}
