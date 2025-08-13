namespace Roblox.Billing;

/// <summary>
/// Represents a function that cancel existing active membership sale.
/// </summary>
/// <param name="currentSaleId">The current sale Id that is checkout.</param>
public delegate void CancelExistingActiveMembershipSaleHandler(int currentSaleId);
