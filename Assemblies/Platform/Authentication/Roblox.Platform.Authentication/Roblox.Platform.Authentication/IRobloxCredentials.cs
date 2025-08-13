namespace Roblox.Platform.Authentication;

public interface IRobloxCredentials : ICredentials
{
	bool Verify();
}
