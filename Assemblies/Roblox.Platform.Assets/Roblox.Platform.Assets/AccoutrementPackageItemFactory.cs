using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class AccoutrementPackageItemFactory : IAccoutrementPackageItemFactory
{
	public IReadOnlyCollection<IAccoutrementPackageItem> GetPackageItems(IPackage package)
	{
		if (package == null)
		{
			throw new PlatformArgumentNullException("package");
		}
		return Roblox.AccoutrementPackageItem.GetAccoutrementPackageItems(package.Id).Select(Translate).ToList();
	}

	private IAccoutrementPackageItem Translate(Roblox.AccoutrementPackageItem accoutrementPackageItem)
	{
		return new AccoutrementPackageItem
		{
			Id = accoutrementPackageItem.ID,
			AssetId = accoutrementPackageItem.AssetID,
			AssetTypeId = accoutrementPackageItem.AssetTypeID,
			Created = accoutrementPackageItem.Created,
			Updated = accoutrementPackageItem.Updated
		};
	}
}
