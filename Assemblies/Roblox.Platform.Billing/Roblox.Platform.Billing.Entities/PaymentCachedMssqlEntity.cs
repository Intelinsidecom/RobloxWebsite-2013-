using System;
using Roblox.Billing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing.Entities;

internal class PaymentCachedMssqlEntity : IPaymentEntity
{
	public long Id { get; set; }

	public int SaleID { get; set; }

	public byte PaymentProviderTypeID { get; set; }

	public byte PaymentStatusTypeID { get; set; }

	public DateTime PaymentDate { get; set; }

	public decimal Amount { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte? CurrencyTypeID { get; set; }

	public void Update()
	{
		Payment cal = Payment.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted update on unpersisted entity");
		}
		cal.SaleID = SaleID;
		cal.PaymentProviderTypeID = PaymentProviderTypeID;
		cal.PaymentStatusTypeID = PaymentStatusTypeID;
		cal.PaymentDate = PaymentDate;
		cal.Amount = Amount;
		cal.CurrencyTypeID = CurrencyTypeID;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		Payment.Get(Id)?.Delete();
	}
}
