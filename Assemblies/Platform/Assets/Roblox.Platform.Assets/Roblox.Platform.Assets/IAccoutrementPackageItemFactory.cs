using System.Collections.Generic;

namespace Roblox.Platform.Assets;

public interface IAccoutrementPackageItemFactory
{
	IReadOnlyCollection<IAccoutrementPackageItem> GetPackageItems(IPackage package);
}
