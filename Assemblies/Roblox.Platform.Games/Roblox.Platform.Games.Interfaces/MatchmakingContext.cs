namespace Roblox.Platform.Games.Interfaces;

internal class MatchmakingContext : IMatchmakingContext
{
	public int Id { get; private set; }

	public string Name { get; private set; }

	public MatchmakingContext(int id, string name)
	{
		Id = id;
		Name = name;
	}
}
