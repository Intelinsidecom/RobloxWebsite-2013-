using System.Collections.Generic;
using Roblox.Marketing;

namespace Roblox.Platform.Marketing;

/// <summary>
/// An interface for a SponsoredPage provider.
/// </summary>
public interface ISponsoredPageProvider
{
	/// <summary>
	/// Determines whether or not the sponsored page is authorized in the given country.
	/// </summary>
	/// <param name="sponsoredPage">A <see cref="T:Roblox.Marketing.SponsoredPage" />.</param>
	/// <param name="countryId">The country id.</param>
	/// <returns>Whether or not the sponsored page is authorized in the given country.</returns>
	bool IsSponsoredPageAuthorizedForCountry(SponsoredPage sponsoredPage, int countryId);

	/// <summary>
	/// Gets all available sponsored pages for the given ip and user agent.
	/// </summary>
	/// <param name="ip">The ip address.</param>
	/// <param name="userAgent">The user agent.</param>
	/// <returns>All available <see cref="T:Roblox.Platform.Marketing.ISponsoredPageNavigation" /> for the given ip and user agent.</returns>
	ICollection<ISponsoredPageNavigation> GetAllAvailableSponsoredPagesForUser(string ip, string userAgent);

	/// <summary>
	/// Gets the sponsored page with the given override url.
	/// </summary>
	/// <param name="overrideUrl">The navigation override url.</param>
	/// <returns>The <see cref="T:Roblox.Marketing.SponsoredPage" /> with the given override url.</returns>
	SponsoredPage GetSponsoredPageByOverrideUrl(string overrideUrl);
}
