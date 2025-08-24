using System;
using System.Collections.Generic;
using Roblox.Common.Properties;
using Roblox.Configuration;

namespace Roblox.Platform.Games.Implementation;

public class RobloxBetaPlaceAuthority : IRobloxBetaPlaceAuthority
{
	private HashSet<long> _BetaFeaturePlaceIds;

	public RobloxBetaPlaceAuthority()
	{
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.BetaFeaturePlaceIds, delegate(string val)
		{
			try
			{
				_BetaFeaturePlaceIds = MultiValueSettingParser.ParseCommaDelimitedListString(val, (string str) => Convert.ToInt64(str));
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
				_BetaFeaturePlaceIds = new HashSet<long>();
			}
		});
	}

	public bool IsRobloxPlace(long placeId)
	{
		return _BetaFeaturePlaceIds.Contains(placeId);
	}
}
