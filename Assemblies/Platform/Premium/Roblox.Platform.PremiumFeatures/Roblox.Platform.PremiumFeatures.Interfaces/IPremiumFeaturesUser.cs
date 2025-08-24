using Roblox.PremiumFeatures.Models.Requests;
using Roblox.PremiumFeatures.Models.Responses;

namespace Roblox.Platform.PremiumFeatures.Interfaces;

/// <summary>
/// Interface for Premium Feature User Logic Layer
/// </summary>
public interface IPremiumFeaturesUser
{
	/// <summary>
	/// Get a user's subscription product
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	SubscriptionProductResponse GetSubscriptionProductForUser(long userId);

	/// <summary>
	/// Checks if user has a subscription
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	bool IsPremiumUser(long userId);

	/// <summary>
	/// Get Builders Club Cancellation
	/// </summary>
	/// <param name="GetBuildersClubCancellationForUserRequest"></param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Models.Responses.BuildersClubCancellationForUserResponse" /></returns>
	BuildersClubCancellationForUserResponse GetBuildersClubCancellationForUser(BuildersClubCancellationForUserRequest GetBuildersClubCancellationForUserRequest);

	/// <summary>
	/// Execute Builders Club Cancellation
	/// </summary>
	/// <param name="executeBuildersClubCancellationForUserRequest"></param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Models.Responses.BuildersClubCancellationForUserResponse" /></returns>
	BuildersClubCancellationForUserResponse ExecuteBuildersClubCancellationForUser(ExecuteBuildersClubCancellationForUserRequest executeBuildersClubCancellationForUserRequest);

	/// <summary>
	/// Updates a user's subscription product
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="productId"></param>
	/// <returns></returns>
	SubscriptionProductResponse UpdateSubscriptionProductForUser(long userId, int productId);
}
