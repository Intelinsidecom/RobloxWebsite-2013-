namespace Roblox.Platform.Membership.Entities;

/// <summary>
/// An interface to generate or get AccountNameHistoryEntity.
/// </summary>
public interface IAccountNameHistoryEntityFactory
{
	bool IsUsernameTaken(string username);
}
