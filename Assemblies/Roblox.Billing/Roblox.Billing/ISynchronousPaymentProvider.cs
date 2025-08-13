using System;

namespace Roblox.Billing;

internal interface ISynchronousPaymentProvider : IPaymentProvider
{
	bool CheckOut(ShoppingCart shoppingCart, string userName, byte platformTypeId);

	bool CheckOut(ShoppingCart shoppingCart, DateTime renewalDate, string userName, byte platformTypeId);
}
