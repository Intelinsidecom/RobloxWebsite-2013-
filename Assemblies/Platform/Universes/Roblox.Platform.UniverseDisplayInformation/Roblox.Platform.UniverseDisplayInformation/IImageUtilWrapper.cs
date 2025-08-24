using System.IO;

namespace Roblox.Platform.UniverseDisplayInformation;

internal interface IImageUtilWrapper
{
	Stream ResampleTextureEnforceDesiredSizeWithPadding(Stream texture, int width, int height);
}
