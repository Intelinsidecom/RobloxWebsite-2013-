using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.AssetInstances.Client;
using Roblox.Configuration;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.OwnershipV2.Client;
using Roblox.OwnershipV2.Client.Models;
using Roblox.Platform.AssetOwnership.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.OwnershipV2;

namespace Roblox.Platform.AssetOwnership;

internal class UserAssetOwnershipAuthority : OwnershipV2AuthorityBase<IUserIdentifier, UserAssetModel>
{
	public static readonly Func<string> _Ov2ApiKeyGetter = () => Settings.Default.Ov2ApiKey;

	protected AssetInstancesClient AssetInstancesClient;

	private static readonly IReadOnlyCollection<UserAssetModel> _EmptyUserAssetModelCollection = (IReadOnlyCollection<UserAssetModel>)(object)new UserAssetModel[0];

	private static readonly string _UserOwnerType = OwnerType.User.ToString();

	private static readonly Func<string> _AssetInstancesApiKeyGetter = () => Settings.Default.AssetInstancesApiKey;

	private static readonly Func<string> _AssetInstancesEndpointGetter = () => RobloxEnvironment.GetApiEndpoint("assetinstances");

	private readonly Func<long, int> _AssetTypeGetter;

	private ILogger _Logger { get; }

	protected UserAssetOwnershipAuthority(Func<long, int> assetTypeGetter, ILogger logger)
		: base((IOwnershipV2Client)new OwnershipV2Client(_Ov2ApiKeyGetter))
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		AssetInstancesClient = new AssetInstancesClient(_AssetInstancesApiKeyGetter, _AssetInstancesEndpointGetter);
		_AssetTypeGetter = assetTypeGetter ?? throw new ArgumentNullException("assetTypeGetter");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	protected override Owner BuildOwner(IUserIdentifier user)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		return new Owner(_UserOwnerType, user.Id);
	}

	protected override Item BuildItem(UserAssetModel userAssetModel)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		if (userAssetModel == null)
		{
			throw new PlatformArgumentNullException("userAssetModel");
		}
		return new Item(GetInstanceItemType(userAssetModel.AssetId), userAssetModel.Id);
	}

	protected override string BuildSubtype(IUserIdentifier user, UserAssetModel userAssetModel)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (userAssetModel == null)
		{
			throw new PlatformArgumentNullException("userAssetModel");
		}
		return GetSubtype(userAssetModel.AssetId);
	}

	protected override DateTime? BuildExpiration(IUserIdentifier owner, UserAssetModel userAssetModel)
	{
		return null;
	}

	protected override IReadOnlyCollection<UserAssetModel> Translate(IReadOnlyCollection<OwnedItem> ownedItems)
	{
		if (ownedItems == null)
		{
			return _EmptyUserAssetModelCollection;
		}
		return (IReadOnlyCollection<UserAssetModel>)(object)ownedItems.Select((OwnedItem ownedItem) => Translate(ownedItem)).ToArray();
	}

	protected override UserAssetModel Translate(OwnedItem ownedItem)
	{
		long assetId = GetAssetIdFromSubtype(ownedItem.Subtype);
		DateTime created = ownedItem.Created ?? DateTime.UtcNow;
		return new UserAssetModel(ownedItem.Item.TargetId, assetId, created, ownedItem.Owner.TargetId);
	}

	protected IReadOnlyCollection<UserAssetModel> GetUserAssetsByUserAndAssetId(IUserIdentifier user, long assetId)
	{
		string subtype = GetSubtype(assetId);
		int count = 1;
		SortOrder sortOrder = SortOrder.Asc;
		string instanceItemType = GetInstanceItemType(assetId);
		return GetItemsByOwnerAndTypeAndSubtype(user, instanceItemType, subtype, count, null, sortOrder);
	}

	private string GetInstanceItemType(long assetId)
	{
		return GetInstanceItemType(_AssetTypeGetter(assetId));
	}

	private string GetInstanceItemType(int assetTypeId)
	{
		return $"AssetTypeId:{assetTypeId}";
	}

	private string GetSubtype(long assetId)
	{
		return $"Asset:{assetId}";
	}

	private long GetAssetIdFromSubtype(string subtype)
	{
		return long.Parse(subtype.Split(':').Last());
	}
}
