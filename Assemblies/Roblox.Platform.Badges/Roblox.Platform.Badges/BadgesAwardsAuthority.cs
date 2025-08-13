using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.Badges.Client;
using Roblox.DataV2.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Badges;

/// <summary>
/// Implementation of IBadgesAwardsAuthority which is using Badges service as a datasource <see cref="T:Roblox.Badges.Client.IBadgesClient" />
/// </summary>
/// <seealso cref="T:Roblox.Platform.Badges.IBadgesAwardsAuthority" />
public class BadgesAwardsAuthority : IBadgesAwardsAuthority
{
	private readonly IRecipientFactory _RecipientFactory;

	private readonly IBadgesClient _BadgesClient;

	private static readonly ReadOnlyCollection<int> _AllowedPageSizes = new ReadOnlyCollection<int>(new List<int> { 10, 25, 50, 100 });

	private readonly Func<IAwardedBadgeIdentifier, IAwardedBadgeIdentifier> _GetExclusiveStartKeyFunc = (IAwardedBadgeIdentifier abi) => abi;

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgesAwardsAuthority.AllowedPageSizes" />
	public IReadOnlyCollection<int> AllowedPageSizes => _AllowedPageSizes;

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgesAwardsAuthority.MaxPageSize" />
	public int MaxPageSize => _AllowedPageSizes.Last();

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgesAwardsAuthority.MinPageSize" />
	public int MinPageSize => _AllowedPageSizes.First();

	/// <inheritdoc cref="E:Roblox.Platform.Badges.IBadgesAwardsAuthority.BadgeAwarded" />
	public event Action<IBadgeIdentifier, IUserIdentifier> BadgeAwarded;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Badges.BadgesAwardsAuthority" /> class.
	/// </summary>
	/// <param name="badgesClient">The badges client <see cref="T:Roblox.Badges.Client.IBadgesClient" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="badgesClient" /></exception>
	public BadgesAwardsAuthority(IBadgesClient badgesClient)
		: this(new RecipientFactory(), badgesClient)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Badges.BadgesAwardsAuthority" /> class.
	/// </summary>
	/// <param name="badgesClient">The badges client <see cref="T:Roblox.Badges.Client.IBadgesClient" />.</param>
	/// <param name="recipientFactory">The see <see cref="T:Roblox.Platform.Badges.IRecipientFactory" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="recipientFactory" />, <paramref name="badgesClient" /></exception>
	internal BadgesAwardsAuthority(IRecipientFactory recipientFactory, IBadgesClient badgesClient)
	{
		_RecipientFactory = recipientFactory ?? throw new PlatformArgumentNullException("recipientFactory");
		_BadgesClient = badgesClient ?? throw new PlatformArgumentNullException("badgesClient");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgesAwardsAuthority.Award(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.Badges.IBadgeIdentifier)" />
	public bool Award(IUserIdentifier userIdentifier, IBadgeIdentifier badgeIdentifier)
	{
		IRecipient recipient = _RecipientFactory.Get(userIdentifier);
		bool num = Award(recipient, badgeIdentifier);
		if (num)
		{
			Action<IBadgeIdentifier, IUserIdentifier> badgeAwarded = this.BadgeAwarded;
			if (badgeAwarded == null)
			{
				return num;
			}
			badgeAwarded(badgeIdentifier, userIdentifier);
		}
		return num;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgesAwardsAuthority.IsAwarded(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.Badges.IBadgeIdentifier)" />
	public bool IsAwarded(IUserIdentifier userIdentifier, IBadgeIdentifier badgeIdentifier)
	{
		IRecipient recipient = _RecipientFactory.Get(userIdentifier);
		return IsAwarded(recipient, badgeIdentifier);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgesAwardsAuthority.GetBadgeAwardedDate(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.Badges.IBadgeIdentifier)" />
	public DateTime? GetBadgeAwardedDate(IUserIdentifier user, IBadgeIdentifier badge)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0062: Expected O, but got Unknown
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		IRecipient recipient = _RecipientFactory.Get(user);
		IsAwardedResult obj = _BadgesClient.IsAwarded(new Recipient
		{
			TargetId = recipient.TargetId,
			Type = recipient.TargetType
		}, new BadgeIdentifier
		{
			Id = badge.Id
		});
		if (obj == null)
		{
			return null;
		}
		return obj.AwardedDate;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgesAwardsAuthority.Revoke(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.Badges.IBadgeIdentifier)" />
	public bool Revoke(IUserIdentifier userIdentifier, IBadgeIdentifier badgeIdentifier)
	{
		IRecipient recipient = _RecipientFactory.Get(userIdentifier);
		return Revoke(recipient, badgeIdentifier);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgesAwardsAuthority.GetAwardedBadgesIdentifiersByRecipient(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo{Roblox.Platform.Badges.IAwardedBadgeIdentifier})" />
	public IPlatformPageResponse<IAwardedBadgeIdentifier, IAwardedBadgeIdentifier> GetAwardedBadgesIdentifiersByRecipient(IUserIdentifier userIdentifier, IExclusiveStartKeyInfo<IAwardedBadgeIdentifier> exclusiveStartKeyInfo)
	{
		IRecipient recipient = _RecipientFactory.Get(userIdentifier);
		return GetAwardedBadgesIdentifiersByRecipient(recipient, exclusiveStartKeyInfo);
	}

	private bool Award(IRecipient recipient, IBadgeIdentifier badgeIdentifier)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0072: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		if (badgeIdentifier == null)
		{
			throw new PlatformArgumentNullException("badgeIdentifier");
		}
		if (badgeIdentifier.Id <= 0)
		{
			throw new PlatformArgumentException("Badge Id has to be larger than zero");
		}
		if (recipient.TargetId <= 0)
		{
			throw new PlatformArgumentException("Recipient Id has to be larger than zero");
		}
		try
		{
			return (int)_BadgesClient.AwardBadge(new Recipient
			{
				TargetId = recipient.TargetId,
				Type = recipient.TargetType
			}, new BadgeIdentifier
			{
				Id = badgeIdentifier.Id
			}).OperationStatus == 0;
		}
		catch (ApiClientException apiClientEx)
		{
			throw new PlatformOperationUnavailableException("Error on IBadgesClient AwardBadge method call." + $" RecipientTypeName: {recipient.TargetId}, RecipientId: {recipient.TargetType}, badgeId: {badgeIdentifier.Id}", apiClientEx);
		}
	}

	private bool IsAwarded(IRecipient recipient, IBadgeIdentifier badgeIdentifier)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0069: Expected O, but got Unknown
		if (badgeIdentifier == null)
		{
			throw new PlatformArgumentNullException("badgeIdentifier");
		}
		if (badgeIdentifier.Id <= 0)
		{
			throw new PlatformArgumentException("Badge Id has to be larger than zero");
		}
		if (recipient.TargetId < 0)
		{
			return false;
		}
		IsAwardedResult result;
		try
		{
			result = _BadgesClient.IsAwarded(new Recipient
			{
				TargetId = recipient.TargetId,
				Type = recipient.TargetType
			}, new BadgeIdentifier
			{
				Id = badgeIdentifier.Id
			});
		}
		catch (ApiClientException apiClientEx)
		{
			throw new PlatformOperationUnavailableException("Error on IBadgesClient IsAwarded method call." + $" RecipientTypeName: {recipient.TargetType}, RecipientId: {recipient.TargetId}, badgeId: {badgeIdentifier.Id}", apiClientEx);
		}
		return result.IsAwarded;
	}

	private bool Revoke(IRecipient recipient, IBadgeIdentifier badgeIdentifier)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0072: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		if (badgeIdentifier == null)
		{
			throw new PlatformArgumentNullException("badgeIdentifier");
		}
		if (badgeIdentifier.Id <= 0)
		{
			throw new PlatformArgumentException("Badge Id has to be larger than zero");
		}
		if (recipient.TargetId <= 0)
		{
			throw new PlatformArgumentException("Recipient Id has to be larger than zero");
		}
		RevokeBadgeResult result;
		try
		{
			result = _BadgesClient.RevokeBadge(new Recipient
			{
				TargetId = recipient.TargetId,
				Type = recipient.TargetType
			}, new BadgeIdentifier
			{
				Id = badgeIdentifier.Id
			});
		}
		catch (ApiClientException apiClientEx)
		{
			throw new PlatformOperationUnavailableException("Error on IBadgesClient RevokeBadge method call." + $" RecipientTypeName: {recipient.TargetType}, RecipientId: {recipient.TargetId}, badgeId: {badgeIdentifier.Id}", apiClientEx);
		}
		return (int)result.OperationStatus == 0;
	}

	private IPlatformPageResponse<IAwardedBadgeIdentifier, IAwardedBadgeIdentifier> GetAwardedBadgesIdentifiersByRecipient(IRecipient recipient, IExclusiveStartKeyInfo<IAwardedBadgeIdentifier> exclusiveStartKeyInfo)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		if (recipient == null)
		{
			throw new PlatformArgumentNullException("recipient");
		}
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (!_AllowedPageSizes.Contains(exclusiveStartKeyInfo.Count))
		{
			throw new PlatformArgumentException($"{exclusiveStartKeyInfo.Count} can't be equal to {exclusiveStartKeyInfo.Count}." + string.Format(" Available options are: {0}", string.Join(", ", _AllowedPageSizes)));
		}
		if (recipient.TargetId < 0)
		{
			return new PlatformPageResponse<IAwardedBadgeIdentifier, IAwardedBadgeIdentifier>(new IAwardedBadgeIdentifier[0], exclusiveStartKeyInfo, _GetExclusiveStartKeyFunc);
		}
		Recipient recipientDto = new Recipient
		{
			TargetId = recipient.TargetId,
			Type = recipient.TargetType
		};
		AwardedBadge exclusiveStartAwardedBadge = null;
		if (exclusiveStartKeyInfo.TryGetExclusiveStartKey(out var exclusiveStartKey))
		{
			exclusiveStartAwardedBadge = new AwardedBadge
			{
				BadgeIdentifier = new BadgeIdentifier
				{
					Id = exclusiveStartKey.Id
				},
				Created = exclusiveStartKey.AwardDateTime,
				Recipient = recipientDto
			};
		}
		Roblox.ApiClientBase.SortOrder sortOrder = ConvertToApiClientSortOrder(exclusiveStartKeyInfo.SortOrder, exclusiveStartKeyInfo.PagingDirection);
		GetAwardedBadgesByRecipientResult result;
		try
		{
			result = _BadgesClient.GetAwardedBadgesByRecipient(recipientDto, exclusiveStartAwardedBadge, exclusiveStartKeyInfo.Count + 1, sortOrder);
		}
		catch (ApiClientException apiClientEx)
		{
			throw new PlatformOperationUnavailableException("Error on IBadgesClient GetAwardedBadgesByRecipient method call." + $" RecipientTypeName: {recipient.TargetType}, RecipientId: {recipient.TargetId}, Count: {exclusiveStartKeyInfo.Count}," + $" SortOrder: {exclusiveStartKeyInfo.SortOrder}, ExclusiveStartId: {exclusiveStartKey?.Id}", apiClientEx);
		}
		return new PlatformPageResponse<IAwardedBadgeIdentifier, IAwardedBadgeIdentifier>(((IEnumerable<AwardedBadge>)result.AwardedBadges).Select((Func<AwardedBadge, IAwardedBadgeIdentifier>)((AwardedBadge ab) => new AwardedBadgeIdentifier(ab.BadgeIdentifier.Id, ab.Created))).ToArray(), exclusiveStartKeyInfo, _GetExclusiveStartKeyFunc);
	}

	private static Roblox.ApiClientBase.SortOrder ConvertToApiClientSortOrder(Roblox.DataV2.Core.SortOrder sortOrder, PagingDirection pagingDirection)
	{
		if (pagingDirection == PagingDirection.Forward)
		{
			if (!sortOrder.Equals(Roblox.DataV2.Core.SortOrder.Asc))
			{
				return Roblox.ApiClientBase.SortOrder.Desc;
			}
			return Roblox.ApiClientBase.SortOrder.Asc;
		}
		if (!sortOrder.Equals(Roblox.DataV2.Core.SortOrder.Asc))
		{
			return Roblox.ApiClientBase.SortOrder.Asc;
		}
		return Roblox.ApiClientBase.SortOrder.Desc;
	}
}
