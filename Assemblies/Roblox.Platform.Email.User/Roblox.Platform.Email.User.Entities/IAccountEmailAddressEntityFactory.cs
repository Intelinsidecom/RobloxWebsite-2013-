using System.Collections.Generic;

namespace Roblox.Platform.Email.User.Entities;

internal interface IAccountEmailAddressEntityFactory
{
	IAccountEmailAddressEntity GetById(int id);

	IAccountEmailAddressEntity GetCurrentByAccountId(long accountId);

	ICollection<IAccountEmailAddressEntity> GetByAccountIdPaged(long accountId, int startIndex, int maxRows);

	ICollection<IAccountEmailAddressEntity> GetByEmailAddressId(int emailAddressId, int count, int exclusiveStartId);

	ICollection<IAccountEmailAddressEntity> GetByEmailAddressIdByAndIsValid(int emailAddressId, bool isValid, int count, int exclusiveStartId);

	ICollection<IAccountEmailAddressEntity> GetByEmailAddressIdIsVerifiedAndIsValid(int emailAddressId, bool isVerified, bool isValid, int count, int? exclusiveStartId);
}
