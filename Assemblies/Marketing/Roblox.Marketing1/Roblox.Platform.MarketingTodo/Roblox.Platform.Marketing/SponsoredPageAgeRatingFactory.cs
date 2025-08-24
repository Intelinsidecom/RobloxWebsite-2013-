using Roblox.Marketing;

namespace Roblox.Platform.Marketing;

public class SponsoredPageAgeRatingFactory : ISponsoredPageAgeRatingFactory
{
	public ISponsoredPageAgeRating GetBySponsoredPageId(int sponsoredPageId)
	{
		Roblox.Marketing.SponsoredPageAgeRating entity = Roblox.Marketing.SponsoredPageAgeRating.GetBySponsoredPageId(sponsoredPageId);
		if (entity == null)
		{
			return null;
		}
		return new SponsoredPageAgeRating(entity);
	}

	public ISponsoredPageAgeRating CreateSponsoredPageAgeRating(int sponsoredPageId, byte minAge = 0, byte maxAge = byte.MaxValue)
	{
		SponsoredPageAgeRating sponsoredPageAgeRating = new SponsoredPageAgeRating(sponsoredPageId, minAge, maxAge);
		sponsoredPageAgeRating.Save();
		return sponsoredPageAgeRating;
	}
}
