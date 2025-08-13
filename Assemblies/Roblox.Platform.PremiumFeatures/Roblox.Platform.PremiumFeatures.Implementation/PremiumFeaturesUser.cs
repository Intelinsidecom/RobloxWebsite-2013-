using Roblox.Billing.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.PremiumFeatures.Interfaces;
using Roblox.PremiumFeatures.Client.Interfaces;
using Roblox.PremiumFeatures.Models.Enums;
using Roblox.PremiumFeatures.Models.Requests;
using Roblox.PremiumFeatures.Models.Responses;

namespace Roblox.Platform.PremiumFeatures.Implementation;

/// <summary>
/// PremiumFeature User Logic Layer
/// </summary>
public class PremiumFeaturesUser : IPremiumFeaturesUser
{
	/// <summary>
	/// PremiumFeatures Client
	/// </summary>
	protected readonly IPremiumFeaturesClient PremiumFeaturesClient;

	protected readonly IBillingClient BillingClient;

	protected readonly IUserFactory UserFactory;

	/// <summary>
	/// Initialize PremiumFeaturesUser
	/// </summary>
	/// <param name="premiumFeaturesClient"></param>
	/// <param name="billingClient"></param>
	/// <param name="userFactory"></param>
	public PremiumFeaturesUser(IPremiumFeaturesClient premiumFeaturesClient, IBillingClient billingClient, IUserFactory userFactory)
	{
		PremiumFeaturesClient = premiumFeaturesClient.AssignOrThrowIfNull<IPremiumFeaturesClient>("premiumFeaturesClient");
		BillingClient = billingClient.AssignOrThrowIfNull<IBillingClient>("billingClient");
		UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
	}

	/// <inheritdoc />
	public SubscriptionProductResponse GetSubscriptionProductForUser(long userId)
	{
		IUser user = UserFactory.GetUser(userId);
		if (user == null)
		{
			return new SubscriptionProductErrorResponse
			{
				ErrorCode = PremiumFeaturesErrorCode.UserNotFound,
				ErrorMessage = "User not found"
			};
		}
		SubscriptionProductResponse subscriptionProductResponse = PremiumFeaturesClient.GetSubscriptionProductForUser(user.AccountId);
		if (!(subscriptionProductResponse.GetType() == typeof(SubscriptionProductErrorResponse)))
		{
			subscriptionProductResponse.subscriptionProductModel.PurchasePlatform = BillingClient.GetPurchasePlatformForSubscription(user.AccountId).PurchasePlatform;
		}
		return subscriptionProductResponse;
	}

	/// <inheritdoc />
	public bool IsPremiumUser(long userId)
	{
		try
		{
			IUser user = UserFactory.GetUser(userId);
			return user != null && PremiumFeaturesClient.IsPremiumAccount(user.AccountId);
		}
		catch
		{
			return false;
		}
	}

	/// <inheritdoc />
	public BuildersClubCancellationForUserResponse GetBuildersClubCancellationForUser(BuildersClubCancellationForUserRequest getBuildersClubCancellationForUserRequest)
	{
		return PremiumFeaturesClient.GetBuildersClubCancellationForUser(getBuildersClubCancellationForUserRequest);
	}

	/// <inheritdoc />
	public BuildersClubCancellationForUserResponse ExecuteBuildersClubCancellationForUser(ExecuteBuildersClubCancellationForUserRequest executeBuildersClubCancellationForUserRequest)
	{
		if (!executeBuildersClubCancellationForUserRequest.IsConfirmed)
		{
			return new BuildersClubCancellationForUserErrorResponse
			{
				ErrorCode = PremiumFeaturesErrorCode.NotConfirmed,
				ErrorMessage = "User has not confirmed cancellation"
			};
		}
		BuildersClubCancellationForUserRequest buildersClubCancellationForUserRequest = new BuildersClubCancellationForUserRequest
		{
			UserId = executeBuildersClubCancellationForUserRequest.UserId,
			AccountId = executeBuildersClubCancellationForUserRequest.AccountId
		};
		return PremiumFeaturesClient.ExecuteBuildersClubCancellationForUser(buildersClubCancellationForUserRequest);
	}

	/// <summary>
	/// Get a user's subscription product
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="productId"></param>
	/// <returns></returns>
	public SubscriptionProductResponse UpdateSubscriptionProductForUser(long userId, int productId)
	{
		IUser user = UserFactory.GetUser(userId);
		if (user == null)
		{
			return new SubscriptionProductErrorResponse
			{
				ErrorCode = PremiumFeaturesErrorCode.UserNotFound,
				ErrorMessage = "User not found"
			};
		}
		SubscriptionUpdateForUserRequest request = new SubscriptionUpdateForUserRequest
		{
			AccountId = user.AccountId,
			ProductId = productId
		};
		SubscriptionProductResponse subscription;
		SubscriptionProductErrorResponse error = (subscription = BillingClient.UpdateSubscriptionProductForUser(request)) as SubscriptionProductErrorResponse;
		if (subscription?.subscriptionProductModel == null || error != null)
		{
			subscription = new SubscriptionProductErrorResponse
			{
				ErrorCode = (error?.ErrorCode ?? PremiumFeaturesErrorCode.UnableToUpdateSubscription),
				ErrorMessage = (error?.ErrorMessage ?? "Unable to update user subscription")
			};
		}
		return subscription;
	}
}
