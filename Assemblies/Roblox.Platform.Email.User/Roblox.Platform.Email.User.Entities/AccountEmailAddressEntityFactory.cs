using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Roblox.Platform.Email.User.Entities;

[ExcludeFromCodeCoverage]
internal class AccountEmailAddressEntityFactory : IAccountEmailAddressEntityFactory
{
	public IAccountEmailAddressEntity GetById(int id)
	{
		return MapBllToEntity(AccountEmailAddress.Get(id));
	}

	public IAccountEmailAddressEntity GetCurrentByAccountId(long accountId)
	{
		return MapBllToEntity(AccountEmailAddress.GetCurrent(accountId));
	}

	public ICollection<IAccountEmailAddressEntity> GetByAccountIdPaged(long accountId, int startIndex, int maxRows)
	{
		return AccountEmailAddress.GetAccountEmailAddressesPaged(accountId, startIndex, maxRows).Select(MapBllToEntity).ToList();
	}

	public ICollection<IAccountEmailAddressEntity> GetByEmailAddressId(int emailAddressId, int count, int exclusiveStartId)
	{
		return AccountEmailAddress.GetAccountEmailAddressesByEmailAddressID(emailAddressId, count, exclusiveStartId).Select(MapBllToEntity).ToList();
	}

	public ICollection<IAccountEmailAddressEntity> GetByEmailAddressIdByAndIsValid(int emailAddressId, bool isValid, int count, int exclusiveStartId)
	{
		return AccountEmailAddress.GetAccountEmailAddressesByEmailAddressIDAndIsValid(emailAddressId, isValid, count, exclusiveStartId).Select(MapBllToEntity).ToList();
	}

	public ICollection<IAccountEmailAddressEntity> GetByEmailAddressIdIsVerifiedAndIsValid(int emailAddressId, bool isVerified, bool isValid, int count, int? exclusiveStartId)
	{
		return AccountEmailAddress.GetAccountEmailAddressesByEmailAddressIDIsVerifiedAndIsValid(emailAddressId, isVerified, isValid, count, exclusiveStartId).Select(MapBllToEntity).ToList();
	}

	private static IAccountEmailAddressEntity MapBllToEntity(AccountEmailAddress bll)
	{
		if (bll != null)
		{
			return new AccountEmailAddressEntity
			{
				Id = bll.ID,
				Created = bll.Created,
				Updated = bll.Updated,
				AccountId = bll.AccountID,
				EmailAddressId = bll.EmailAddressID,
				IsVerified = bll.IsVerified,
				IsValid = bll.IsValid,
				NewsLetter = bll.Newsletter
			};
		}
		return null;
	}
}
