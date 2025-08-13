namespace Roblox.Platform.Marketing;

/// <summary>
/// Creates and Gets SponsoredPageAgeRating which are used to target sponsored page based on user age.  
/// </summary>
public interface ISponsoredPageAgeRatingFactory
{
	/// <summary>
	/// Gets instance of <see cref="T:Roblox.Platform.Marketing.SponsoredPageAgeRating" /> by sponsoredPageId.
	/// </summary>
	/// <param name="sponsoredPageId">The sponsored page Id.</param>
	ISponsoredPageAgeRating GetBySponsoredPageId(int sponsoredPageId);

	/// <summary>
	/// Creates or update <see cref="T:Roblox.Platform.Marketing.SponsoredPageAgeRating" />.
	/// </summary>
	/// <param name="sponsoredPageId">The sponsored page id.</param>
	/// <param name="minAge">Minimum age.</param>
	/// <param name="maxAge">Maximum age.</param>
	ISponsoredPageAgeRating CreateSponsoredPageAgeRating(int sponsoredPageId, byte minAge, byte maxAge);
}
