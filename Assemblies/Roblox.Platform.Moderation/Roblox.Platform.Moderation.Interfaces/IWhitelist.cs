using System.Collections.Generic;
using Roblox.Platform.Moderation.Implementation;

namespace Roblox.Platform.Moderation.Interfaces;

/// <summary>
/// Provides a common interface for an object that defines a white list.
/// </summary>
public interface IWhitelist
{
	CategoryType CategoryType { get; }

	long CategoryTargetId { get; }

	IWhitelistEntry Add(string value);

	IWhitelistEntry Get(string value);

	bool Contains(string value);

	PagedResult<IWhitelistEntry> GetPaged(int page = 1);

	/// <summary>
	/// Gets all terms in the <see cref="T:Roblox.Platform.Moderation.Implementation.Whitelist" />.
	/// </summary>
	/// <returns>All terms in the <see cref="T:Roblox.Platform.Moderation.Implementation.Whitelist" /> </returns>
	IEnumerable<string> GetAllTerms();
}
