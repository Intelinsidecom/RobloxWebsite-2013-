namespace Roblox.Platform.Infrastructure;

public interface IServerGroup
{
	int Id { get; }

	int GroupTypeId { get; }

	string Name { get; }

	string Description { get; }
}
