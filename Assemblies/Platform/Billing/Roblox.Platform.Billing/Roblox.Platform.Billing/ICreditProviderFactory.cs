namespace Roblox.Platform.Billing;

/// <summary>
/// Interface for factoryCreates a <see cref="T:Roblox.Platform.Billing.ICreditProvider" />
/// </summary>
public interface ICreditProviderFactory
{
	/// <summary>
	/// Gets the credit provider based on the provided pincode
	/// </summary>
	/// <param name="pinCode">the pincode to used to infer credit provider</param>
	/// <returns>The credit provider <see cref="T:Roblox.Platform.Billing.ICreditProvider" /></returns>
	ICreditProvider GetFromPinCode(string pinCode);
}
