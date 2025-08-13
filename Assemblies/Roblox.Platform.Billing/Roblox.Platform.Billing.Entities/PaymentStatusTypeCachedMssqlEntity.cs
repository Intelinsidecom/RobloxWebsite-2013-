using System;
using Roblox.Billing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing.Entities;

internal class PaymentStatusTypeCachedMssqlEntity : IPaymentStatusTypeEntity
{
	public byte Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		Roblox.Billing.PaymentStatusType cal = Roblox.Billing.PaymentStatusType.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted update on unpersisted entity");
		}
		cal.Value = Value;
		cal.Created = Created;
		cal.Updated = Updated;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		Roblox.Billing.PaymentStatusType.Get(Id)?.Delete();
	}
}
