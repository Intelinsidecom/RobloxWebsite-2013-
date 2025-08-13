using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Roblox.Drawing;

public static class ImageUtil
{
	public enum ResampleMode
	{
		MaxEdge,
		Pad
	}

	private static RectangleF BoxInside(Image srcImage, RectangleF destRect)
	{
		float height = destRect.Height;
		float width = destRect.Width;
		float destAspectRatio = width / height;
		float relativeAspectRatio = (float)srcImage.Width / (float)srcImage.Height / destAspectRatio;
		if ((double)relativeAspectRatio >= 1.0)
		{
			return new RectangleF(destRect.Left, destRect.Top + (float)((int)((double)height * (1.0 - (double)(1f / relativeAspectRatio))) / 2), width, height / relativeAspectRatio);
		}
		return new RectangleF(destRect.Left + (float)((int)((double)width * (1.0 - (double)relativeAspectRatio)) / 2), destRect.Top, width * relativeAspectRatio, height);
	}

	private static RectangleF DrawIntoHelper(Image srcImage, Bitmap destBitmap, RectangleF destRect, InterpolationMode interpolationMode, Color? fillColor = null)
	{
		RectangleF result = BoxInside(srcImage, destRect);
		using Graphics g = Graphics.FromImage(destBitmap);
		if (fillColor.HasValue)
		{
			g.Clear(fillColor.Value);
		}
		ImageAttributes attr = new ImageAttributes();
		attr.SetWrapMode(WrapMode.TileFlipXY);
		g.InterpolationMode = interpolationMode;
		g.DrawImage(srcImage, Rectangle.Round(result), 0, 0, srcImage.Width, srcImage.Height, GraphicsUnit.Pixel, attr);
		return result;
	}

	public static RectangleF DrawInto(Image srcImage, Bitmap destBitmap, RectangleF destRect, Color? fillColor = null)
	{
		return DrawIntoHelper(srcImage, destBitmap, destRect, InterpolationMode.HighQualityBicubic, fillColor);
	}

	private static Bitmap CreateScaledBitmap(Image image, Size size)
	{
		if (image.Size != size)
		{
			Bitmap scaledBitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
			using Graphics g = Graphics.FromImage(scaledBitmap);
			ImageAttributes attr = new ImageAttributes();
			attr.SetWrapMode(WrapMode.TileFlipXY);
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			g.DrawImage(image, new Rectangle(0, 0, size.Width, size.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attr);
			return scaledBitmap;
		}
		return new Bitmap(image);
	}

	/// <summary>
	/// Draws the source image into the destination bitmap scaling it to fit.
	/// It preserves the source aspect ratio, rendering in the top-middle of the destination bitmap
	/// </summary>
	/// <param name="srcImage"></param>
	/// <param name="destBitmap"></param>
	/// <param name="fillColor"> </param>
	public static RectangleF DrawInto(Image srcImage, Bitmap destBitmap, Color? fillColor = null)
	{
		GraphicsUnit pixel = GraphicsUnit.Pixel;
		return DrawInto(srcImage, destBitmap, destBitmap.GetBounds(ref pixel), fillColor);
	}

	public static RectangleF DrawIntoPixelated(Image srcImage, Bitmap destBitmap, RectangleF destRect)
	{
		return DrawIntoHelper(srcImage, destBitmap, destRect, InterpolationMode.NearestNeighbor);
	}

	/// <summary>
	/// Interpreting the provided stream as an image file, check its height and width against
	/// the provided upper limits. Do this without actually allocating memory to render the
	/// image according to its claimed dimensions.
	/// </summary>
	/// <param name="texture">Stream representing an image</param>
	/// <param name="heightLimit">Max height allowed</param>
	/// <param name="widthLimit">Max width allowed</param>
	/// <returns>true IFF image file dimensions are within (less than or equal to) provided
	/// limits.</returns>
	public static bool AreTextureDimensionsValid(Stream texture, int heightLimit, int widthLimit)
	{
		using Image image = Image.FromStream(texture, useEmbeddedColorManagement: false, validateImageData: false);
		return image.Height <= heightLimit && image.Width <= widthLimit;
	}

	public static void ResampleTextureToStreamPixelated(Image image, ImageFormat desiredFormat, MemoryStream destination)
	{
		GraphicsUnit pixel = GraphicsUnit.Pixel;
		using Bitmap smallBitmap = new Bitmap(20, 20 * image.Height / image.Width, PixelFormat.Format32bppArgb);
		DrawIntoPixelated(image, smallBitmap, smallBitmap.GetBounds(ref pixel));
		using Bitmap bigBitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
		DrawIntoPixelated(smallBitmap, bigBitmap, bigBitmap.GetBounds(ref pixel));
		bigBitmap.Save(destination, desiredFormat);
	}

	public static Stream ResampleTextureEnforceMaxEdgeSize(Stream texture, int maxEdgeSize)
	{
		using Image sourceImage = FormatConverter.ImageFromStream(texture);
		int desiredHeight = sourceImage.Height;
		int desiredWidth = sourceImage.Width;
		if (sourceImage.Height > maxEdgeSize || sourceImage.Width > maxEdgeSize)
		{
			float sourceAspectRatio = (float)sourceImage.Width / (float)sourceImage.Height;
			desiredHeight = maxEdgeSize;
			desiredWidth = maxEdgeSize;
			if (sourceImage.Width >= sourceImage.Height)
			{
				desiredHeight = sourceImage.Height;
				if (sourceImage.Width != desiredWidth)
				{
					desiredHeight = (int)((float)desiredWidth / sourceAspectRatio);
				}
			}
			else
			{
				desiredWidth = sourceImage.Width;
				if (sourceImage.Height != desiredHeight)
				{
					desiredWidth = (int)((float)desiredHeight * sourceAspectRatio);
				}
			}
		}
		using Bitmap scaledBitmap = new Bitmap(desiredWidth, desiredHeight, PixelFormat.Format32bppArgb);
		using (Graphics g = Graphics.FromImage(scaledBitmap))
		{
			ImageAttributes attr = new ImageAttributes();
			attr.SetWrapMode(WrapMode.TileFlipXY);
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			g.DrawImage(sourceImage, new Rectangle(0, 0, desiredWidth, desiredHeight), 0, 0, sourceImage.Width, sourceImage.Height, GraphicsUnit.Pixel, attr);
		}
		MemoryStream memoryStream = new MemoryStream();
		scaledBitmap.Save(memoryStream, ImageFormat.Png);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	public static Stream ResampleTextureEnforceDesiredSizeWithPadding(Stream texture, int desiredWidth, int desiredHeight)
	{
		float destAspectRatio = (float)desiredWidth / (float)desiredHeight;
		using Bitmap scaledBitmap = new Bitmap(desiredWidth, desiredHeight, PixelFormat.Format32bppArgb);
		using (Graphics g = Graphics.FromImage(scaledBitmap))
		{
			ImageAttributes attr = new ImageAttributes();
			attr.SetWrapMode(WrapMode.TileFlipXY);
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			using Image sourceImage = FormatConverter.ImageFromStream(texture);
			float relativeAspectRatio = (float)sourceImage.Width / (float)sourceImage.Height / destAspectRatio;
			if ((double)relativeAspectRatio >= 1.0)
			{
				g.DrawImage(sourceImage, new Rectangle(0, 0, desiredWidth, (int)((float)desiredHeight / relativeAspectRatio)), 0, 0, sourceImage.Width, sourceImage.Height, GraphicsUnit.Pixel, attr);
			}
			else
			{
				g.DrawImage(sourceImage, new Rectangle((int)((double)desiredWidth * (1.0 - (double)relativeAspectRatio)) / 2, 0, (int)((float)desiredWidth * relativeAspectRatio), desiredHeight), 0, 0, sourceImage.Width, sourceImage.Height, GraphicsUnit.Pixel, attr);
			}
		}
		MemoryStream memoryStream = new MemoryStream();
		scaledBitmap.Save(memoryStream, ImageFormat.Png);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	public static Stream ReshapeToCircularImage(Stream texture, IEnumerable<Tuple<Point, byte>> transparentPixels, Size size)
	{
		using Image img = FormatConverter.ImageFromStream(texture);
		using Bitmap scaledBitmap = CreateScaledBitmap(img, size);
		foreach (Tuple<Point, byte> pixel in transparentPixels)
		{
			if (pixel.Item2 > 0)
			{
				Color color = scaledBitmap.GetPixel(pixel.Item1.X, pixel.Item1.Y);
				scaledBitmap.SetPixel(pixel.Item1.X, pixel.Item1.Y, Color.FromArgb(pixel.Item2 * color.A / 255, color.R, color.G, color.B));
			}
			else
			{
				scaledBitmap.SetPixel(pixel.Item1.X, pixel.Item1.Y, Color.FromArgb(0, 0, 0, 0));
			}
		}
		MemoryStream outStream = new MemoryStream();
		scaledBitmap.Save(outStream, ImageFormat.Png);
		outStream.Seek(0L, SeekOrigin.Begin);
		return outStream;
	}

	public static IEnumerable<Tuple<Point, byte>> GetTransparentPixelsForCircularCutout(int size)
	{
		double midPoint = (double)((float)size / 2f) - 0.5;
		List<Tuple<Point, byte>> blackPoints = new List<Tuple<Point, byte>>();
		for (int x = 0; x < size; x++)
		{
			for (int y = 0; y < size; y++)
			{
				double num = (double)x - midPoint;
				double ydif = (double)y - midPoint;
				double dist = Math.Sqrt(num * num + ydif * ydif);
				double overflow = dist - midPoint;
				double antiAliasWidth = 1.75;
				if (dist > midPoint)
				{
					blackPoints.Add(new Tuple<Point, byte>(new Point(x, y), 0));
				}
				else if (dist + antiAliasWidth > midPoint)
				{
					blackPoints.Add(new Tuple<Point, byte>(new Point(x, y), (byte)(Math.Abs(overflow / antiAliasWidth) * 255.0)));
				}
			}
		}
		return blackPoints;
	}
}
