using System;
using Roblox.Marketing;

namespace Roblox.Platform.Marketing;

internal class SponsoredPageAgeRating : ISponsoredPageAgeRating
{
	public int Id { get; private set; }

	public byte MinAge { get; set; }

	public byte MaxAge { get; set; }

	public int SponsoredPageId { get; set; }

	internal SponsoredPageAgeRating(int sponsoredPageId, byte minAge, byte maxAge)
	{
		Id = 0;
		SponsoredPageId = sponsoredPageId;
		MinAge = minAge;
		MaxAge = maxAge;
	}

	internal SponsoredPageAgeRating(Roblox.Marketing.SponsoredPageAgeRating entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		Id = entity.ID;
		SponsoredPageId = entity.SponsoredPageID;
		MinAge = entity.MinAge;
		MaxAge = entity.MaxAge;
	}

	public void Save()
	{
		Roblox.Marketing.SponsoredPageAgeRating entity = Roblox.Marketing.SponsoredPageAgeRating.Get(Id) ?? new Roblox.Marketing.SponsoredPageAgeRating();
		entity.SponsoredPageID = SponsoredPageId;
		entity.MinAge = MinAge;
		entity.MaxAge = MaxAge;
		entity.Save();
		Id = entity.ID;
	}

	public void Delete()
	{
		Roblox.Marketing.SponsoredPageAgeRating.Get(Id)?.Delete();
	}
}
