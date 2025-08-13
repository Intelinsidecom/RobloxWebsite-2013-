using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Roblox.Drawing;

public class Transformations
{
	public static Bitmap CreateScaledBitmap(Bitmap bitmap, int width, int height, bool fillWithWhite = false)
	{
		Bitmap scaledBitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
		using Graphics graphics = Graphics.FromImage(scaledBitmap);
		if (fillWithWhite)
		{
			graphics.Clear(Color.White);
		}
		ImageAttributes attr = new ImageAttributes();
		attr.SetWrapMode(WrapMode.TileFlipXY);
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.CompositingQuality = CompositingQuality.HighQuality;
		graphics.DrawImage(bitmap, new Rectangle(0, 0, width, height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attr);
		return scaledBitmap;
	}
}
