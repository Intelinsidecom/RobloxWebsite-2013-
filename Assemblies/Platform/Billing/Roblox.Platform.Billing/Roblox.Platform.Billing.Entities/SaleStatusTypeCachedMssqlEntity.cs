using System;
using Roblox.Billing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing.Entities;

internal class SaleStatusTypeCachedMssqlEntity : ISaleStatusTypeEntity
{
	public byte Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		Roblox.Billing.SaleStatusType cal = Roblox.Billing.SaleStatusType.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted update on unpersisted entity");
		}
		cal.Value = Value;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		Roblox.Billing.SaleStatusType.Get(Id)?.Delete();
	}
}
