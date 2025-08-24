using System;
using Roblox.Billing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing.Entities;

internal class PaymentProviderTypeCachedMssqlEntity : IPaymentProviderTypeEntity
{
	public byte Id { get; set; }

	public string Value { get; set; }

	public bool SupportsRecurringCharges { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		Roblox.Billing.PaymentProviderType cal = Roblox.Billing.PaymentProviderType.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted update on unpersisted entity");
		}
		cal.Value = Value;
		cal.SupportsRecurringCharges = SupportsRecurringCharges;
		cal.Created = Created;
		cal.Updated = Updated;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		Roblox.Billing.PaymentProviderType.Get(Id)?.Delete();
	}
}
