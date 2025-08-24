using System;

namespace Roblox.Billing.XboxStoreExceptions;

/// <summary>
/// The exception thrown when an invalid XboxLive product ID is given.
/// </summary>
public class InvalidXboxProductException : ApplicationException
{
	/// <summary>
	/// Gets the product ID that was invalid.
	/// </summary>
	public string ProductId { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Billing.XboxStoreExceptions.InvalidXboxProductException" /> class with the given product ID.
	/// </summary>
	/// <param name="productId">The product ID that was invalid.</param>
	public InvalidXboxProductException(string productId)
		: base("Invalid Xbox Store product: " + productId)
	{
		ProductId = productId;
	}
}
