using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.AssetOwnership.Properties;

namespace Roblox.Platform.AssetOwnership;

public class LegacyUserAssetOptionAuthority
{
	private readonly OwnershipV1UserAssetFactory _OwnershipV1UserAssetFactory;

	public LegacyUserAssetOptionAuthority()
	{
		ClientGetter clientGetter = new ClientGetter((ISettings s) => s.UserAssetShimClientApiKey, NoOpLogger.Instance, null);
		_OwnershipV1UserAssetFactory = new OwnershipV1UserAssetFactory(clientGetter, NoOpLogger.Instance);
	}

	public IUserAssetOption SaveUserAssetOption(long userAssetId, long productId, long? serialNumber, long? priceInRobux, long id)
	{
		return _OwnershipV1UserAssetFactory.SaveUserAssetOption(userAssetId, productId, serialNumber, priceInRobux, id);
	}

	public IUserAssetOption GetUserAssetOptionById(long id)
	{
		Helpers.ThrowIfDefault(id, "id");
		return _OwnershipV1UserAssetFactory.GetUserAssetOptionById(id);
	}

	public IUserAssetOption SaveUserAssetOption(IUserAssetOption uao)
	{
		return _OwnershipV1UserAssetFactory.SaveUserAssetOption(uao);
	}

	public IUserAssetOption GetUserAssetOptionByUserAssetId(long userAssetId)
	{
		Helpers.ThrowIfDefault(userAssetId, "userAssetId");
		return _OwnershipV1UserAssetFactory.GetUserAssetOptionByUserAssetId(userAssetId);
	}

	public void DeleteUserAssetOption(IUserAssetOption uao)
	{
		Helpers.ThrowIfDefault(uao.Id, "Id");
		_OwnershipV1UserAssetFactory.DeleteUserAssetOption(uao);
	}

	public IUserAssetOption CreateNewUserAssetOption(long userAssetId, long productId, long? serialNumber, long? priceInRobux)
	{
		return _OwnershipV1UserAssetFactory.CreateNewUserAssetOption(userAssetId, productId, serialNumber, priceInRobux);
	}

	public IReadOnlyCollection<IUserAssetOption> GetCopiesForSaleByProductIDSorted(long productId, long startRowIndex, long maximumRows)
	{
		return _OwnershipV1UserAssetFactory.GetCopiesForSaleByProductIDSorted(productId, startRowIndex, maximumRows);
	}

	public int GetTotalNumberForSaleByProductID(long productId)
	{
		Helpers.ThrowIfDefault(productId, "productId");
		return _OwnershipV1UserAssetFactory.GetTotalNumberForSaleByProductID(productId);
	}
}
