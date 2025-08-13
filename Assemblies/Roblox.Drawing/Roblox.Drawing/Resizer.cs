using System;
using System.Drawing;
using System.IO;
using ImageMagick;
using Roblox.Drawing.Properties;

namespace Roblox.Drawing;

public static class Resizer
{
	public static bool IsTgaUploadEnabled => Settings.Default.IsTgaUploadEnabled;

	/// <summary>
	/// Determines the desired size of an image given it's current size and an edge size.
	/// </summary>
	/// <param name="sourceWidth">Width of the source.</param>
	/// <param name="sourceHeight">Height of the source.</param>
	/// <param name="maxEdgeSize">Maximum size of the edge.</param>
	/// <param name="desiredWidth">Width desired.</param>
	/// <param name="desiredHeight">Height desired.</param>
	public static void DetermineDesiredSize(int sourceWidth, int sourceHeight, int maxEdgeSize, out int desiredWidth, out int desiredHeight)
	{
		desiredHeight = sourceHeight;
		desiredWidth = sourceWidth;
		if (sourceHeight <= maxEdgeSize && sourceWidth <= maxEdgeSize)
		{
			return;
		}
		float sourceAspectRatio = (float)sourceWidth / (float)sourceHeight;
		desiredHeight = maxEdgeSize;
		desiredWidth = maxEdgeSize;
		if (sourceWidth >= sourceHeight)
		{
			desiredHeight = sourceHeight;
			if (sourceWidth != desiredWidth)
			{
				desiredHeight = (int)((float)desiredWidth / sourceAspectRatio);
			}
		}
		else
		{
			desiredWidth = sourceWidth;
			if (sourceHeight != desiredHeight)
			{
				desiredWidth = (int)((float)desiredHeight * sourceAspectRatio);
			}
		}
	}

	/// <summary>
	/// Gets the image dimensions from stream.
	/// </summary>
	/// <param name="imageStream">The image stream.</param>
	/// <param name="width">The width returned.</param>
	/// <param name="height">The height returned.</param>
	/// <exception cref="T:System.ArgumentNullException">imageStream</exception>
	public static void GetImageDimensionsFromStream(Stream imageStream, out int width, out int height)
	{
		if (imageStream == null)
		{
			throw new ArgumentNullException("imageStream");
		}
		using Stream pngStream = FormatConverter.ConvertIncompatibleFormatToPng(imageStream);
		using (Image img = Image.FromStream(pngStream ?? imageStream))
		{
			width = img.Width;
			height = img.Height;
		}
		imageStream.Position = 0L;
	}

	/// <summary>
	/// Enforces the maximum size of an edge.
	/// </summary>
	/// <param name="texture">The texture.</param>
	/// <param name="maxEdgeSize">Maximum size of the edge.</param>
	/// <returns>
	/// The edged image Stream
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">imageStream</exception>
	/// <exception cref="T:System.InvalidOperationException">Unrecognized image format</exception>
	public static Stream EnforceMaxEdgeSize(Stream texture, int maxEdgeSize)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00ab: Expected O, but got Unknown
		if (texture == null)
		{
			throw new ArgumentNullException("imageStream");
		}
		MagickReadSettings magickSettings = new MagickReadSettings();
		((MagickSettings)magickSettings).SetDefine((MagickFormat)163, "exclude-chunks", "date");
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			if (IsTgaUploadEnabled && FormatConverter.IsStreamTga(texture))
			{
				((MagickSettings)magickSettings).Format = (MagickFormat)208;
			}
			((MagickSettings)magickSettings).SetDefine((MagickFormat)163, "exclude-chunks", "date");
			MagickImage sourceImage = new MagickImage(texture, magickSettings);
			try
			{
				DetermineDesiredSize(sourceImage.Width, sourceImage.Height, maxEdgeSize, out var desiredWidth, out var desiredHeight);
				sourceImage.Resize(desiredWidth, desiredHeight);
				sourceImage.Write((Stream)memoryStream, (MagickFormat)163);
			}
			finally
			{
				((IDisposable)sourceImage)?.Dispose();
			}
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}
		catch (MagickException val)
		{
			MagickException me = val;
			if (me is MagickMissingDelegateErrorException || me is MagickCorruptImageErrorException)
			{
				throw new InvalidOperationException("Failure to parse image: " + ((Exception)(object)me).Message);
			}
			throw;
		}
	}
}
