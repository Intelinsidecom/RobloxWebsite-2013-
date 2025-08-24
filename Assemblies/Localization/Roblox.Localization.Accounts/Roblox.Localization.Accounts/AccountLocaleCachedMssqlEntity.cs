using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountLocaleCachedMssqlEntity : IAccountLocaleEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AccountId { get; set; }

	public int ObservedLocaleId { get; set; }

	public int? SupportedLocaleId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AccountLocale cal = AccountLocale.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountID = AccountId;
		cal.ObservedLocaleID = ObservedLocaleId;
		cal.SupportedLocaleID = SupportedLocaleId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AccountLocale.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
