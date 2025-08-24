using System;

namespace Roblox.Billing;

public interface IPayment
{
	long ID { get; }

	int SaleID { get; set; }

	byte PaymentProviderTypeID { get; set; }

	byte PaymentStatusTypeID { get; set; }

	DateTime PaymentDate { get; set; }

	decimal Amount { get; set; }

	byte? CurrencyTypeID { get; set; }

	DateTime Created { get; }

	DateTime Updated { get; }

	void Save();
}
