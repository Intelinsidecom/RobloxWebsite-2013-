using System.Collections.Generic;

namespace Roblox.Platform.UniverseDisplayInformation;

internal interface IImageApprovalStatusGetter
{
	IDictionary<long, bool> GetApprovalStatusForImages(IReadOnlyCollection<long> imageIds);
}
