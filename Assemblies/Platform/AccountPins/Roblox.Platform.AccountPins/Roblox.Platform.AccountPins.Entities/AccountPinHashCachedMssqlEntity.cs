using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.AccountPins.Entities.Audit;

namespace Roblox.Platform.AccountPins.Entities;

[ExcludeFromCodeCoverage]
internal class AccountPinHashCachedMssqlEntity : IAccountPinHashEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AccountId { get; set; }

	public string PinHash { get; set; }

	public bool IsValid { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AccountPinHashCAL cal = AccountPinHashCAL.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountID = AccountId;
		cal.PinHash = PinHash;
		cal.IsValid = IsValid;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AccountPinHashCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}

	public IAccountPinHashesAuditEntity BuildAuditEntity(AccountPinsDomainFactories domainFactories)
	{
		return domainFactories.AccountPinHashesAuditEntityFactory.CreateNew(this);
	}
}
