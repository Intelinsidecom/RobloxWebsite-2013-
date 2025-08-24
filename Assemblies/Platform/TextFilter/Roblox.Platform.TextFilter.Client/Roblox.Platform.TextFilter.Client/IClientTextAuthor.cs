namespace Roblox.TextFilter.Client;

public interface IClientTextAuthor
{
	long Id { get; }

	string Name { get; }

	bool IsUnder13 { get; }
}
