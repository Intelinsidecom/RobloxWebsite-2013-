using System.Collections.Generic;

namespace Roblox.Platform.UniverseDisplayInformation;

internal interface IUniverseDisplayThumbnailsUtil
{
	string Serialize(IReadOnlyList<long> thumbnailIds);

	IReadOnlyList<long> Deserialize(string tssUniverseThumbnailValue);

	string AppendImageId(string imageIds, long id);

	string DeleteImageId(string imageIds, long id);
}
