namespace Roblox.Billing;

internal interface IAsyncPaymentProvider : IPaymentProvider
{
	string BeginCheckOut(ShoppingCart shoppingCart, string userName, byte platformTypeId, string sessionId = null);
}
