using System.IO;
using Roblox.Drawing;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class ImageUtilWrapper : IImageUtilWrapper
{
	Stream IImageUtilWrapper.ResampleTextureEnforceDesiredSizeWithPadding(Stream texture, int width, int height)
	{
		return ImageUtil.ResampleTextureEnforceDesiredSizeWithPadding(texture, width, height);
	}
}
