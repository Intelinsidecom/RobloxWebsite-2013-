using System;

namespace Roblox.Web.Code.Itunes;

[Serializable]
public class ItunesAppInfoModel
{
	public double AverageUserRating { get; set; }

	public long UserRatingCount { get; set; }
}
