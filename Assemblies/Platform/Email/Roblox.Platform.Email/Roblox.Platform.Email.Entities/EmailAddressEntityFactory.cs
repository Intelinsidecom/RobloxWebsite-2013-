using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Email.Entities;

[ExcludeFromCodeCoverage]
internal class EmailAddressEntityFactory : IEmailAddressEntityFactory
{
	public IEmailAddressEntity GetById(int id)
	{
		return MapBllToEntity(Roblox.EmailAddress.Get(id));
	}

	public IEmailAddressEntity GetOrCreateByEmailAddress(string emailAddress)
	{
		return MapBllToEntity(Roblox.EmailAddress.GetOrCreate(emailAddress));
	}

	public IEmailAddressEntity GetByEmailAddress(string emailAddress)
	{
		return MapBllToEntity(Roblox.EmailAddress.Get(emailAddress));
	}

	private static IEmailAddressEntity MapBllToEntity(Roblox.EmailAddress bll)
	{
		if (bll != null)
		{
			return new EmailAddressEntity
			{
				Id = bll.ID,
				Created = bll.Created,
				Updated = bll.Updated,
				Address = bll.Address,
				IsBlacklisted = bll.IsBlacklisted
			};
		}
		return null;
	}
}
