using System;

namespace Roblox.Billing.Interface;

/// <summary>
/// Interface for ProductPaymentProviderTypeModel
/// </summary>
public interface IProductPaymentProviderTypeModel
{
	int ID { get; }

	int ProductID { get; }

	byte PaymentProviderTypeID { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
