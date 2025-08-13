using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Agents;
using Roblox.Badges.Client;
using Roblox.Currency.Client;
using Roblox.Economy.Common;
using Roblox.EventLog;
using Roblox.Marketplace.Client;
using Roblox.Platform.AssetPermissions;
using Roblox.Platform.Assets;
using Roblox.Platform.Badges.Exceptions;
using Roblox.Platform.Badges.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Groups;
using Roblox.Platform.Groups.Counters;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.Universes;
using Roblox.Platform.VirtualCurrency;
using Roblox.TransactionEvents;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeCreator" />
public class BadgeCreator : IBadgeCreator
{
	private readonly IBadgeTextFilter _BadgeTextFilter;

	private readonly IBadgeConverter _BadgeConverter;

	private readonly ISettings _Settings;

	private readonly IBadgePermissionsVerifier _BadgePermissionsVerifier;

	private readonly IAssetPermissionsVerifier _AssetPermissionsVerifier;

	private readonly IBadgesAwardsAuthority _BadgeAwardsAuthority;

	private readonly IMarketplaceAuthority _MarketplaceClient;

	private readonly ICurrencyAuthority _CurrencyClient;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IGroupFactory _GroupFactory;

	private readonly IGroupCounter _GroupCounter;

	private readonly IAgentFactory _AgentFactory;

	private readonly IBadgesClient _BadgesClient;

	private readonly ILogger _Logger;

	private readonly ITransactionStreamer _TransactionStreamer;

	private const long _RobloxUserId = 1L;

	private const string _RefundBadgePurchase = "refundBadgePurchase";

	[ExcludeFromCodeCoverage]
	internal virtual byte RobuxCurrencyId => CurrencyType.RobuxID;

	/// <inheritdoc />
	public event Action<Badge> BadgeCreated;

	/// <inheritdoc />
	public event Action<BadgeCreationFailureReason> BadgeCreationFailed;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgeCreator" />.
	/// </summary>
	/// <param name="settings">The <see cref="T:Roblox.Platform.Badges.Properties.ISettings" />.</param>
	/// <param name="badgesClient">An <see cref="T:Roblox.Badges.Client.IBadgesClient" /></param>
	/// <param name="badgeTextFilter">An <see cref="T:Roblox.Platform.Badges.IBadgeTextFilter" />.</param>
	/// <param name="badgePermissionsVerifier">The <see cref="T:Roblox.Platform.Badges.IBadgePermissionsVerifier" />.</param>
	/// <param name="assetPermissionsVerifier">An <see cref="T:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier" />.</param>
	/// <param name="badgeAwardsAuthority">The <see cref="T:Roblox.Platform.Badges.IBadgesAwardsAuthority" />.</param>
	/// <param name="marketplaceClient">An <see cref="T:Roblox.Marketplace.Client.IMarketplaceAuthority" />.</param>
	/// <param name="currencyClient">An <see cref="T:Roblox.Currency.Client.ICurrencyAuthority" />.</param>
	/// <param name="placeFactory">An <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" />.</param>
	/// <param name="groupCounter">An <see cref="T:Roblox.Platform.Groups.Counters.IGroupCounter" />.</param>
	/// <param name="agentFactory">An <see cref="T:Roblox.Agents.IAgentFactory" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="settings" />
	/// - <paramref name="badgePermissionsVerifier" />
	/// - <paramref name="badgeAwardsAuthority" />
	/// - <paramref name="marketplaceClient" />
	/// - <paramref name="currencyClient" />
	/// - <paramref name="placeFactory" />
	/// - <paramref name="groupFactory" />
	/// - <paramref name="groupCounter" />
	/// - <paramref name="agentFactory" />
	/// - <paramref name="badgeTextFilter" />
	/// - <paramref name="badgesClient" />
	/// - <paramref name="logger" />
	/// </exception>
	public BadgeCreator(ISettings settings, IBadgesClient badgesClient, IBadgeTextFilter badgeTextFilter, IBadgePermissionsVerifier badgePermissionsVerifier, IAssetPermissionsVerifier assetPermissionsVerifier, IBadgesAwardsAuthority badgeAwardsAuthority, IMarketplaceAuthority marketplaceClient, ICurrencyAuthority currencyClient, IPlaceFactory placeFactory, IGroupFactory groupFactory, IGroupCounter groupCounter, IAgentFactory agentFactory, ILogger logger, ITransactionStreamer transactionStreamer)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_BadgesClient = badgesClient ?? throw new ArgumentNullException("badgesClient");
		_BadgeTextFilter = badgeTextFilter ?? throw new ArgumentNullException("badgeTextFilter");
		_BadgePermissionsVerifier = badgePermissionsVerifier ?? throw new ArgumentNullException("badgePermissionsVerifier");
		_AssetPermissionsVerifier = assetPermissionsVerifier ?? throw new ArgumentNullException("assetPermissionsVerifier");
		_BadgeAwardsAuthority = badgeAwardsAuthority ?? throw new ArgumentNullException("badgeAwardsAuthority");
		_MarketplaceClient = marketplaceClient ?? throw new ArgumentNullException("marketplaceClient");
		_CurrencyClient = currencyClient ?? throw new ArgumentNullException("currencyClient");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		_GroupFactory = groupFactory ?? throw new ArgumentNullException("groupFactory");
		_GroupCounter = groupCounter ?? throw new ArgumentNullException("groupCounter");
		_AgentFactory = agentFactory ?? throw new ArgumentNullException("agentFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_BadgeConverter = new BadgeConverter();
		_TransactionStreamer = transactionStreamer ?? throw new ArgumentNullException("transactionStreamer");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeCreator.CreateBadge(Roblox.Platform.Membership.IUser,System.String,System.String,Roblox.Platform.Universes.IUniverse,Roblox.Platform.Assets.IImage,Roblox.Platform.Devices.IPlatform)" />
	public Badge CreateBadge(IUser creatingUser, string name, string description, IUniverse awardingUniverse, IImage badgeIcon, IPlatform platform)
	{
		if (creatingUser == null)
		{
			throw new ArgumentNullException("creatingUser");
		}
		if (awardingUniverse == null)
		{
			throw new ArgumentNullException("awardingUniverse");
		}
		if (badgeIcon == null)
		{
			throw new ArgumentNullException("badgeIcon");
		}
		if (platform == null)
		{
			throw new ArgumentNullException("platform");
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException(string.Format("{0} cannot be null or whitespace.", "name"), "name");
		}
		if (name.Length > _Settings.MaxBadgeNameLength)
		{
			throw new ArgumentException(string.Format("{0} cannot be longer than {1} characters.", "name", _Settings.MaxBadgeNameLength), "name");
		}
		description = description ?? string.Empty;
		if (description.Length > _Settings.MaxBadgeDescriptionLength)
		{
			throw new ArgumentException(string.Format("{0} cannot be longer than {1} characters.", "description", _Settings.MaxBadgeDescriptionLength), "description");
		}
		IPlace rootPlace = (awardingUniverse.RootPlaceId.HasValue ? _PlaceFactory.Get(awardingUniverse.RootPlaceId.Value) : null);
		if (rootPlace == null)
		{
			throw new ArgumentException(string.Format("{0} must have valid root place.", "awardingUniverse"), "awardingUniverse");
		}
		if (!_BadgePermissionsVerifier.CanUserCreateBadgeForUniverse(creatingUser, awardingUniverse))
		{
			this.BadgeCreationFailed?.Invoke(BadgeCreationFailureReason.UnauthorizedBadgeCreation);
			throw new UnauthorizedBadgeCreationException(creatingUser, awardingUniverse);
		}
		if (!_AssetPermissionsVerifier.CanManage(creatingUser, badgeIcon))
		{
			this.BadgeCreationFailed?.Invoke(BadgeCreationFailureReason.UnauthorizedBadgeIconUsage);
			throw new UnauthorizedBadgeIconUsageException(creatingUser, badgeIcon);
		}
		BadgeTextFilterResult filteredText;
		try
		{
			filteredText = FilterText(creatingUser, name, description);
		}
		catch (PlatformBadgeTextFullyModeratedException)
		{
			this.BadgeCreationFailed?.Invoke(BadgeCreationFailureReason.TextFullyModerated);
			throw;
		}
		catch (Exception e2)
		{
			this.BadgeCreationFailed?.Invoke(BadgeCreationFailureReason.TextModerationFailed);
			throw new PlatformOperationUnavailableException("Failed to filter badge text.", e2);
		}
		IAgent purchaserAgent;
		long? saleId;
		EconomyHelper.TransactionStatus purchaseStatus = PurchaseBadge(rootPlace, platform, out purchaserAgent, out saleId);
		if (!purchaseStatus.Equals(EconomyHelper.TransactionStatus.Success))
		{
			this.BadgeCreationFailed?.Invoke(BadgeCreationFailureReason.PurchaseFailed);
			throw new PlatformOperationUnavailableException($"Failed to make purchase: {purchaseStatus}");
		}
		try
		{
			Badge badge = CreateBadgeInstance(rootPlace, filteredText, badgeIcon.Id);
			switch (rootPlace.CreatorType)
			{
			case Roblox.Platform.Assets.CreatorType.User:
				AwardBadge(creatingUser, badge);
				break;
			case Roblox.Platform.Assets.CreatorType.Group:
			{
				IGroup group = _GroupFactory.GetById(rootPlace.CreatorTargetId);
				_GroupCounter.IncrementAssetUploads(group, Roblox.Platform.Assets.AssetType.Badge.ToString(), DateTime.Now);
				break;
			}
			}
			return badge;
		}
		catch (Exception e)
		{
			this.BadgeCreationFailed?.Invoke(BadgeCreationFailureReason.BadgeInstanceCreationFailed);
			RefundBadgePurchase(purchaserAgent, saleId);
			throw new PlatformOperationUnavailableException("Failed to create badge: Unknown error.", e);
		}
	}

	/// <summary>
	/// Creates the actual badge instance.
	/// </summary>
	/// <param name="rootPlace">The <see cref="T:Roblox.Platform.Assets.IPlace" /> the badge is attached to.</param>
	/// <param name="filteredText">Text for the badge.</param>
	/// <param name="badgeImageId">The badge image identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Badges.Badge" /></returns>
	internal virtual Badge CreateBadgeInstance(IPlace rootPlace, BadgeTextFilterResult filteredText, long badgeImageId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		Badge clientBadge = new Badge
		{
			Awarder = new Awarder
			{
				Type = (AwarderType)1,
				TargetId = rootPlace.Id
			},
			Description = filteredText.Description,
			ImageId = badgeImageId,
			IsActive = true,
			Name = filteredText.Name
		};
		CreateBadgeResult createBadgeResult = _BadgesClient.Create(clientBadge);
		Badge createdBadge = _BadgeConverter.ConvertToPlatformBadge(createBadgeResult.Badge);
		this.BadgeCreated?.Invoke(createdBadge);
		return createdBadge;
	}

	/// <summary>
	/// FilterText filters name and description and returns moderated text.
	/// </summary>
	internal virtual BadgeTextFilterResult FilterText(IUser creatingUser, string name, string description)
	{
		BadgeTextFilterRequest filterRequest = new BadgeTextFilterRequest
		{
			Description = (description ?? ""),
			Name = (name ?? ""),
			TextAuthor = creatingUser.ToClientTextAuthor()
		};
		return _BadgeTextFilter.FilterBadgeText(filterRequest);
	}

	/// <summary>
	/// Makes the badge product purchase for the creator of an <see cref="T:Roblox.Platform.Assets.IPlace" />
	/// </summary>
	/// <remarks>
	/// Separated from <see cref="M:Roblox.Platform.Badges.BadgeCreator.CreateBadge(Roblox.Platform.Membership.IUser,System.String,System.String,Roblox.Platform.Universes.IUniverse,Roblox.Platform.Assets.IImage,Roblox.Platform.Devices.IPlatform)" /> for ease of testing.
	/// </remarks>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" />.</param>
	/// <param name="platform">The platform the badge is being purchased on.</param>
	/// <param name="purchaserAgent">The <see cref="T:Roblox.Agents.IAgent" /> that made the purchase.</param>
	/// <param name="saleId">The sale id for the purchase result</param>
	internal virtual EconomyHelper.TransactionStatus PurchaseBadge(IPlace place, IPlatform platform, out IAgent purchaserAgent, out long? saleId)
	{
		purchaserAgent = _AgentFactory.GetByAgentTypeAndAgentTargetId(place.CreatorType.ToAgentType(), place.CreatorTargetId);
		long availableFunds;
		try
		{
			availableFunds = _CurrencyClient.GetCurrencyBalances(purchaserAgent.Id).RobuxBalance;
		}
		catch (Exception e2)
		{
			throw new PlatformOperationUnavailableException("Failed to check Robux balance of creator.", e2);
		}
		if (availableFunds < _Settings.BadgePurchaseRobuxPrice)
		{
			throw new InsufficientFundsException($"Agent {purchaserAgent.Id} does not have sufficient funds.");
		}
		try
		{
			PurchaseProductResult purchaseResult = _MarketplaceClient.PurchaseProduct((long)Convert.ToInt32(purchaserAgent.Id), _Settings.BadgeMarketplaceProductId, (int)RobuxCurrencyId, _Settings.BadgePurchaseRobuxPrice, false, 0L, platform.PlatformTypeId, (SaleLocationType)0, (long?)null);
			saleId = purchaseResult.SaleId;
			return (EconomyHelper.TransactionStatus)purchaseResult.Status;
		}
		catch (Exception e)
		{
			throw new PlatformOperationUnavailableException("Failed to make purchase: Service unavailable.", e);
		}
	}

	/// <summary>
	/// Refunds the purchase of a badge product
	/// </summary>
	/// <remarks>
	/// Separated from <see cref="M:Roblox.Platform.Badges.BadgeCreator.CreateBadge(Roblox.Platform.Membership.IUser,System.String,System.String,Roblox.Platform.Universes.IUniverse,Roblox.Platform.Assets.IImage,Roblox.Platform.Devices.IPlatform)" /> so refund logic can be tested separately.
	/// </remarks>
	/// <param name="purchaserAgent">The <see cref="T:Roblox.Agents.IAgent" /> that purchased the badge.</param>
	/// <param name="saleId">The sale id for creating the badge.</param>
	internal virtual void RefundBadgePurchase(IAgent purchaserAgent, long? saleId)
	{
		int userId = Convert.ToInt32(purchaserAgent.Id);
		long balanceBefore = _CurrencyClient.GetRobuxBalance((long)userId);
		_CurrencyClient.CreditRobux((long)userId, _Settings.BadgePurchaseRobuxPrice);
		LogRefundTransaction(purchaserAgent, _Settings.BadgePurchaseRobuxPrice);
		try
		{
			_TransactionStreamer.StreamTransactionEvent("refundBadgePurchase", UserType.User, 1L.ToString(), (purchaserAgent.AgentType != AgentType.Group) ? UserType.User : UserType.Group, purchaserAgent.AgentTargetId.ToString(), ContentType.Asset, _Settings.BadgePurchaseRobuxPrice, balanceBefore, TransactionOriginType.MiscellaneousAdjustmentID, "Virtual Economy", DateTime.UtcNow, null, saleId);
		}
		catch (Exception e)
		{
			_Logger.Error($"Event refundBadgePurchase failed to stream. \n Exception: {e}");
		}
	}

	/// <summary>
	/// Awards an <see cref="T:Roblox.Platform.Badges.Badge" /> to an <see cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	/// <remarks>
	/// Separated from <see cref="M:Roblox.Platform.Badges.BadgeCreator.CreateBadge(Roblox.Platform.Membership.IUser,System.String,System.String,Roblox.Platform.Universes.IUniverse,Roblox.Platform.Assets.IImage,Roblox.Platform.Devices.IPlatform)" /> for log testing
	/// </remarks>
	/// <param name="userIdentifier">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />.</param>
	/// <param name="badgeIdentifier">The <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" />.</param>
	internal virtual void AwardBadge(IUserIdentifier userIdentifier, IBadgeIdentifier badgeIdentifier)
	{
		try
		{
			_BadgeAwardsAuthority.Award(userIdentifier, badgeIdentifier);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual void LogRefundTransaction(IAgent creatorAgent, long refundAmount)
	{
		TransactionHistory.Submit(creatorAgent.Id, TransactionType.AdjustmentID, TransactionOriginType.MiscellaneousAdjustmentID, RobuxCurrencyId, refundAmount);
	}
}
