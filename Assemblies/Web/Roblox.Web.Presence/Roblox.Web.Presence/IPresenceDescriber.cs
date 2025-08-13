using System.Collections.Generic;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Presence;
using Roblox.Platform.Universes;

namespace Roblox.Web.Presence;

/// <summary>
/// Converts <see cref="T:Roblox.Platform.Presence.IPresence" />s to human-readable strings.
/// </summary>
public interface IPresenceDescriber
{
	/// <summary>
	/// Describes a <see cref="T:Roblox.Platform.Presence.IPresence" /> to an human.
	/// </summary>
	/// <param name="presence">The <see cref="T:Roblox.Platform.Presence.IPresence" /></param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></param>
	/// <returns>A human readable description of the <paramref name="presence" /></returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="presence" />
	/// - <paramref name="supportedLocale" />
	/// </exception>
	string Describe(IPresence presence, ISupportedLocale supportedLocale);

	/// <summary>
	/// Describes a list of <see cref="T:Roblox.Platform.Presence.IPresence" />s to an human.
	/// </summary>
	/// <param name="presences"></param>
	/// <param name="supportedLocale"></param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="presences" />
	/// - <paramref name="supportedLocale" />
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="presences" /> is empty.
	/// - <paramref name="presences" /> has more than 50 members.
	/// </exception>
	IEnumerable<string> Describe(IReadOnlyCollection<IPresence> presences, ISupportedLocale supportedLocale);

	/// <summary>
	/// Describes a list of <see cref="T:Roblox.Platform.Presence.IPresence" />s to an human.
	/// This method provides support to pass a dictionary lookup for <see cref="T:Roblox.Platform.Universes.IUniverse" /> given a placeId, as input, so that it isn't evaluated in the method itself
	/// </summary>
	/// <param name="presences"></param>
	/// <param name="supportedLocale"></param>
	/// <param name="placeUniverseLookup"><see cref="T:Roblox.Platform.Universes.IUniverse" /> lookup given a placeId. If Null, this is evaluated for all valid placeIds in list of presences input</param>
	/// <returns>dictionary of localized universe name, given a place Id</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="presences" />
	/// - <paramref name="supportedLocale" />
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="presences" /> is empty.
	/// </exception>
	IReadOnlyDictionary<long, string> Describe(IReadOnlyCollection<IPresence> presences, ISupportedLocale supportedLocale, IDictionary<long, IUniverse> placeUniverseLookup);

	/// <summary>
	/// Get localized universe display names for a given list of Universes.
	/// </summary>
	/// <param name="universes">list of <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <param name="supportedLocale"><see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></param>
	/// <returns>dictionary of display name for a given <see cref="T:Roblox.Platform.Universes.IUniverse" /></returns>
	IDictionary<IUniverse, string> GetUniverseDisplayName(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale);
}
