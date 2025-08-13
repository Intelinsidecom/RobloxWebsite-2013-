using System;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

public static class UniverseExtensions
{
	/// <summary>
	/// Checks if a given universe is secure.
	/// </summary>
	/// <param name="universe">The universe being checked.</param>
	/// <param name="gameAttributesFactory">The dependency necessary to look up data.</param>
	/// <returns></returns>
	public static bool IsSecure(this IUniverse universe, IGameAttributesFactory gameAttributesFactory)
	{
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (gameAttributesFactory == null)
		{
			throw new ArgumentNullException("gameAttributesFactory");
		}
		return gameAttributesFactory.GetGameAttributes(universe)?.IsSecure ?? false;
	}
}
