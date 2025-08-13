using System;
using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

public class ProductPaymentProviderTypeModel : IProductPaymentProviderTypeModel
{
	public int ID { get; }

	public int ProductID { get; }

	public byte PaymentProviderTypeID { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public ProductPaymentProviderTypeModel(int id, int productId, byte paymentProviderTypeId, DateTime created, DateTime updated)
	{
		ID = id;
		ProductID = productId;
		PaymentProviderTypeID = paymentProviderTypeId;
		Created = created;
		Updated = updated;
	}
}
