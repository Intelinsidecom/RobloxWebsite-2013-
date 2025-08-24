using System.Collections.Generic;

namespace Roblox.Platform.Avatar;

public interface IAccoutrementFactory
{
	IAccoutrement GetByUserAssetID(long userAssetId);

	IEnumerable<IAccoutrement> GetUserAccoutrementsNoFilter(long userId);
}
