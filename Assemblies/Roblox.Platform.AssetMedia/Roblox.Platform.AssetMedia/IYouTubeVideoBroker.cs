using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Handles video asset transactions on behalf of a user.
/// </summary>
public interface IYouTubeVideoBroker
{
	/// <summary>
	/// Purchases a YouTube place video on behalf of a user.
	/// </summary>
	/// <param name="actingUser">User purchasing a video.</param>
	/// <param name="initiatingPlatformType">Type of the platform from which the action was initiated.</param>
	/// <param name="videoCostInRobux">Cost to add YouTube video, in Robux</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="actingUser" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.VirtualCurrency.InsufficientFundsException">If the user does not have enough funds to purchase the video</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">If the sale could not be completed.</exception>
	void PurchaseVideo(IUser actingUser, PlatformType initiatingPlatformType, long videoCostInRobux, out long? saleId);

	/// <summary>
	/// Refunds the cost of a YouTube video to the user.
	/// </summary>
	/// <param name="actingUser"></param>
	/// <param name="videoCost"></param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="actingUser" />
	/// </exception>
	void RefundVideo(IUser actingUser, long videoCost, long? saleId);
}
