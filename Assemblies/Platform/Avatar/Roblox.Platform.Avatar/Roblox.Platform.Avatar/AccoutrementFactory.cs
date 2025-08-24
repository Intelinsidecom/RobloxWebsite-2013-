using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Avatar;

internal class AccoutrementFactory : IAccoutrementFactory
{
	public IAccoutrement GetByUserAssetID(long userAssetId)
	{
		return Accoutrement.GetByUserAssetID(userAssetId);
	}

	public IEnumerable<IAccoutrement> GetUserAccoutrementsNoFilter(long userId)
	{
		return from acc in Accoutrement.GetUserAccoutrementsNoFilter(userId)
			where acc != null
			select acc;
	}
}
