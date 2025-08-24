using System;

namespace Roblox.Billing.AmazonStoreExceptions;

public class InvalidAmazonProductException : ApplicationException
{
	/// <summary>
	/// Gets the product ID that was invalid.
	/// </summary>
	public string ProductId { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Billing.AmazonStoreExceptions.InvalidAmazonProductException" /> class with the given product ID.
	/// </summary>
	/// <param name="productId">The product ID that was invalid.</param>
	public InvalidAmazonProductException(string productId)
		: base("Invalid Amazon Store product: " + productId)
	{
		ProductId = productId;
	}
}
