using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <summary>
/// A factory for getting <see cref="T:Roblox.Platform.Games.IGameAttributes" />
/// </summary>
public interface IGameAttributesFactory
{
	/// <summary>
	/// Gets <see cref="T:Roblox.Platform.Games.IGameAttributes" /> by it's <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Games.IGameAttributes" /></returns>
	IGameAttributes GetGameAttributes(IUniverse universe);

	/// <summary>
	/// Gets or creates <see cref="T:Roblox.Platform.Games.IGameAttributes" /> by it's <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Games.IGameAttributes" /></returns>
	IGameAttributes GetOrCreateGameAttributes(IUniverse universe);

	/// <summary>
	/// Gets a list of <see cref="T:Roblox.Platform.Universes.IUniverse" />s where the <see cref="T:Roblox.Platform.Games.IGameAttributes" />
	/// IsTrusted state for that <see cref="T:Roblox.Platform.Universes.IUniverse" /> is set to <c>true</c>.
	/// </summary>
	/// <param name="exclusiveStartDetails">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" /> of <see cref="T:Roblox.Platform.Universes.IUniverse" />s.</returns>
	IPlatformPageResponse<long, IUniverse> GetTrustedGames(IExclusiveStartKeyInfo<long> exclusiveStartDetails);
}
