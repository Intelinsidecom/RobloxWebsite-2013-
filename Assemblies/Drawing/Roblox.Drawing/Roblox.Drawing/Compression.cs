using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace Roblox.Drawing;

internal static class Compression
{
	private const long _JpegQuality = 98L;

	private static readonly ImageCodecInfo _JpegCodeInfo;

	static Compression()
	{
		_JpegCodeInfo = ImageCodecInfo.GetImageEncoders().FirstOrDefault((ImageCodecInfo t) => t.FormatDescription.Equals("JPEG"));
	}

	internal static void SaveCompressed(this Image image, Stream stream, ImageFormat format)
	{
		using Stream pngStream = FormatConverter.ConvertIncompatibleFormatToPng(stream);
		stream = pngStream ?? stream;
		if (format.Equals(ImageFormat.Jpeg) && _JpegCodeInfo != null)
		{
			using (Bitmap b = new Bitmap(image.Width, image.Height))
			{
				b.SetResolution(image.HorizontalResolution, image.VerticalResolution);
				using (Graphics g = Graphics.FromImage(b))
				{
					g.Clear(Color.White);
					g.DrawImageUnscaled(image, 0, 0);
				}
				EncoderParameters encoderParams = new EncoderParameters(1);
				encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, 98L);
				b.Save(stream, _JpegCodeInfo, encoderParams);
				return;
			}
		}
		image.Save(stream, format);
	}
}
