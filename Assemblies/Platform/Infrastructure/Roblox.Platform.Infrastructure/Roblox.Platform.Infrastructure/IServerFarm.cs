namespace Roblox.Platform.Infrastructure;

public interface IServerFarm
{
	short Id { get; }

	string Name { get; }

	int ServerTypeId { get; }

	string Abbreviation { get; }
}
