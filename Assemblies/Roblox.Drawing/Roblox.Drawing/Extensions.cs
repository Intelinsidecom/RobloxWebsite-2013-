using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Roblox.Drawing;

public static class Extensions
{
	public static void SaveCompressed(this Image image, Stream stream, ImageFormat imageFormat)
	{
		Compression.SaveCompressed(image, stream, imageFormat);
	}

	public static byte[] SaveCompressedToByteArray(this Image image, ImageFormat imageFormat)
	{
		using MemoryStream memoryStream = new MemoryStream();
		SaveCompressed(image, memoryStream, imageFormat);
		return memoryStream.ToArray();
	}
}
