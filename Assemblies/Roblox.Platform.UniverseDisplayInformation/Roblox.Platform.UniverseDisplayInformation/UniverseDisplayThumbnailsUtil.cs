using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class UniverseDisplayThumbnailsUtil : IUniverseDisplayThumbnailsUtil
{
	private const char _Delimiter = ',';

	public string Serialize(IReadOnlyList<long> thumbnailIds)
	{
		if (thumbnailIds != null && thumbnailIds.Any())
		{
			return string.Join(','.ToString(), thumbnailIds.Select((long x) => x.ToString().Trim()).ToArray());
		}
		return null;
	}

	public IReadOnlyList<long> Deserialize(string tssUniverseThumbnailValue)
	{
		List<long> result = new List<long>();
		if (string.IsNullOrEmpty(tssUniverseThumbnailValue))
		{
			return result;
		}
		string[] array = tssUniverseThumbnailValue.Split(',');
		foreach (string thumbnailId in array)
		{
			result.Add(long.Parse(thumbnailId.Trim()));
		}
		return result;
	}

	public string AppendImageId(string imageIds, long id)
	{
		if (string.IsNullOrEmpty(imageIds))
		{
			return id.ToString();
		}
		return imageIds.Trim() + "," + id;
	}

	public string DeleteImageId(string imageIds, long id)
	{
		return Serialize((from x in Deserialize(imageIds)
			where x != id
			select x).ToList());
	}
}
