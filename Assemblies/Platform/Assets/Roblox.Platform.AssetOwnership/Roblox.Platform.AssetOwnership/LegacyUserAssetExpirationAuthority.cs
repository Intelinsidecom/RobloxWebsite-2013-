using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.AssetOwnership.Properties;

namespace Roblox.Platform.AssetOwnership;

public class LegacyUserAssetExpirationAuthority
{
	private readonly OwnershipV1UserAssetFactory _OwnershipV1UserAssetFactory;

	public LegacyUserAssetExpirationAuthority()
	{
		ClientGetter clientGetter = new ClientGetter((ISettings s) => s.UserAssetShimClientApiKey, NoOpLogger.Instance, null);
		_OwnershipV1UserAssetFactory = new OwnershipV1UserAssetFactory(clientGetter, NoOpLogger.Instance);
	}

	public IUserAssetExpiration GetUserAssetExpirationById(long id)
	{
		Helpers.ThrowIfDefault(id, "id");
		return _OwnershipV1UserAssetFactory.GetUserAssetExpirationById(id);
	}

	public IUserAssetExpiration GetUserAssetExpirationByUserAssetId(long userAssetId)
	{
		Helpers.ThrowIfDefault(userAssetId, "userAssetId");
		return _OwnershipV1UserAssetFactory.GetUserAssetExpirationByUserAssetId(userAssetId);
	}

	public IReadOnlyCollection<long> GetUserAssetExpirationItemIdsToExpire(int maxResults)
	{
		return _OwnershipV1UserAssetFactory.GetUserAssetExpirationItemIdsToExpire(maxResults);
	}

	public void SaveUserAssetExpirationObsolete(IUserAssetExpiration userAssetExpiration)
	{
		_OwnershipV1UserAssetFactory.SaveUserAssetExpiration(userAssetExpiration);
	}

	/// <summary>
	/// Previously this checked whether the asset is expireable.  If yes, it then checked if the userasset is expired.
	/// Now it only checks if the userasset is expired.  You must check if the asset is expireable yourself using AssetOption.IsExpireable.
	/// </summary>
	public TimeSpan? GetUserAssetExpireTimeSpan(IUserAsset ua)
	{
		return _OwnershipV1UserAssetFactory.GetUserAssetExpireTimeSpan(ua);
	}

	public TimeSpan? GetUserAssetExpireTimeSpan(Lazy<IUserAssetExpiration> userAssetExpiration)
	{
		return _OwnershipV1UserAssetFactory.GetUserAssetExpireTimeSpan(userAssetExpiration);
	}

	/// <summary>
	/// Previously this checked whether the asset is expireable.  If yes, it then checked if the userasset is expired.
	/// Now it only checks if the userasset is expired.  You must check if the asset is expireable yourself using AssetOption.IsExpireable.
	/// </summary>
	public bool UserAssetIsExpired(IUserAsset ua)
	{
		return _OwnershipV1UserAssetFactory.UserAssetIsExpired(ua);
	}

	public bool UserAssetIsExpired(Lazy<IUserAssetExpiration> userAssetExpiration)
	{
		return _OwnershipV1UserAssetFactory.UserAssetIsExpired(userAssetExpiration);
	}
}
