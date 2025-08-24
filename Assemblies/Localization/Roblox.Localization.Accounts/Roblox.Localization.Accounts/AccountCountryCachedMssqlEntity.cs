using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountCountryCachedMssqlEntity : IAccountCountryEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AccountId { get; set; }

	public int? CountryId { get; set; }

	public bool IsVerified { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AccountCountry cal = AccountCountry.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountId = AccountId;
		cal.CountryId = CountryId;
		cal.IsVerified = IsVerified;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AccountCountry.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
