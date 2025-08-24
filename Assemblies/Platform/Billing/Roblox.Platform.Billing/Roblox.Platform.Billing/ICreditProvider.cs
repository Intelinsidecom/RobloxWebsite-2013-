using System.Threading.Tasks;
using Roblox.Platform.Billing.Interface;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

/// <summary>
/// Credit Provider Interface. Enables redemption and adding of prepaid/gamecard credit 
/// </summary>
public interface ICreditProvider
{
	/// <summary>
	/// Redeem a gameCard for credit
	/// </summary>
	/// <param name="user">the <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="ip">ip address of the user</param>
	/// <param name="pinCode">pinCode of the gamecard</param>
	/// <returns>The result</returns>
	ICreditRedemptionResult Redeem(IUser user, string ip, string pinCode);

	/// <summary>
	/// Redeem a gameCard for credit
	/// </summary>
	/// <param name="user">the <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="ip">ip address of the user</param>
	/// <param name="pinCode">pinCode of the gamecard</param>
	/// <returns>The result</returns>
	Task<ICreditRedemptionResult> RedeemAsync(IUser user, string ip, string pinCode);

	/// <summary>
	/// Perform status lookup for the given game card using pin code
	/// </summary>
	/// <param name="user">User who wants to perform status lookup</param>
	/// <param name="pinCode">The identifying pinCode</param>
	ICreditStatusResult StatusLookup(IUser user, string pinCode);

	/// <summary>
	/// Perform status lookup for the given game card using pin code
	/// </summary>
	/// <param name="user">User who wants to perform status lookup</param>
	/// <param name="pinCode">The identifying pinCode</param>
	Task<ICreditStatusResult> StatusLookupAsync(IUser user, string pinCode);

	/// <summary>
	/// Reverse the redemption of the gamecard identified by the provided pincode
	/// </summary>
	/// <param name="user">User who redeemed the card</param>
	/// <param name="pinCode">The identifying pinCode</param>
	ICreditReversalResult ReverseRedemption(IUser user, string pinCode);

	/// <summary>
	/// Reverse the redemption of the gamecard identified by the provided pincode
	/// </summary>
	/// <param name="user">User who redeemed the card</param>
	/// <param name="pinCode">The identifying pinCode</param>
	Task<ICreditReversalResult> ReverseRedemptionAsync(IUser user, string pinCode);

	/// <summary>
	/// Add credit to the user's account after a redemption
	/// </summary>
	/// <param name="user">the <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="creditAmount">amount to credit to the user</param>
	/// <param name="refNumber">a redemption number. such as a transaction id. May vary based on provider</param>
	/// <param name="pinCode">pincode of the gamecard</param>
	/// <param name="merchantId">id of merchant of card</param>
	/// <returns></returns>
	IAddPrepaidCreditResult AddPrepaidCredit(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId);

	/// <summary>
	/// Add credit to the user's account after a redemption
	/// </summary>
	/// <param name="user">the <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="creditAmount">amount to credit to the user</param>
	/// <param name="refNumber">a redemption number. such as a transaction id. May vary based on provider</param>
	/// <param name="pinCode">pincode of the gameCard</param>
	/// <param name="merchantId">id of merchant of card</param>
	/// <returns></returns>
	Task<IAddPrepaidCreditResult> AddPrepaidCreditAsync(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId);

	/// <summary>
	/// Grant assets for redemption of card from a particular merchant
	/// </summary>
	/// <param name="user">the <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="merchantId">id of merchant of card</param>
	/// <param name="creditAmount">amount credited due to redemption</param>
	/// <returns>the result</returns>
	IGrantMerchantAssetsResult GrantMerchantAssets(IUser user, byte merchantId, decimal creditAmount);

	/// <summary>
	/// Grant assets for redemption of card from a particular merchant
	/// </summary>
	/// <param name="user">the <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="merchantId">id of merchant of card</param>
	/// <param name="creditAmount">amount credited due to redemption</param>
	/// <returns>the result</returns>
	Task<IGrantMerchantAssetsResult> GrantMerchantAssetsAsync(IUser user, byte merchantId, decimal creditAmount);
}
