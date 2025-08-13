namespace Roblox;

/// <summary>
/// Currently implementing: User, Group
/// </summary>
public interface ICreator
{
	long ID { get; }

	string Name { get; }

	CreatorType CreatorType { get; }

	long GetAgentID();
}
