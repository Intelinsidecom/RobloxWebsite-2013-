using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using ImageMagick;
using Roblox.Drawing.Properties;
using Roblox.EventLog;

namespace Roblox.Drawing;

/// <summary>
/// Utility class for checking whether an image has an alpha channel in use.
/// </summary>
public class AlphaDetector
{
	private readonly ILogger _Logger;

	public AlphaDetector(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <summary>
	/// Returns true if an image has an alpha channel actually in use.  
	/// Returns false if the image either does not have an alpha channel, 
	/// or if it was saved with an alpha channel but is opaque everywhere.
	/// </summary>
	public bool HasAlpha(byte[] inputImageData, bool useImageMagick = true)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		if (useImageMagick)
		{
			MagickImage img = new MagickImage(inputImageData);
			try
			{
				return HasAlpha(img);
			}
			finally
			{
				((IDisposable)img)?.Dispose();
			}
		}
		using MemoryStream ms = new MemoryStream(inputImageData);
		using Image image = Image.FromStream(ms);
		return HasAlpha((Bitmap)image);
	}

	/// <summary>
	/// Returns true if an image has an alpha channel actually in use.  
	/// Returns false if the image either does not have an alpha channel, 
	/// or if it was saved with an alpha channel but is opaque everywhere.
	/// </summary>
	public bool HasAlpha(Stream inputImageStream, bool useImageMagick = true)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		if (useImageMagick)
		{
			MagickImage img = new MagickImage(inputImageStream);
			try
			{
				return HasAlpha(img);
			}
			finally
			{
				((IDisposable)img)?.Dispose();
			}
		}
		using Image image = Image.FromStream(inputImageStream);
		return HasAlpha((Bitmap)image);
	}

	/// <summary>
	/// Returns true if an image has an alpha channel actually in use.  
	/// Returns false if the image either does not have an alpha channel, 
	/// or if it was saved with an alpha channel but is opaque everywhere.
	/// </summary>
	public bool HasAlpha(string inputImagePath, bool useImageMagick = true)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		if (useImageMagick)
		{
			MagickImage img = new MagickImage(inputImagePath);
			try
			{
				return HasAlpha(img);
			}
			finally
			{
				((IDisposable)img)?.Dispose();
			}
		}
		using Image image = Image.FromFile(inputImagePath);
		return HasAlpha((Bitmap)image);
	}

	private bool HasAlpha(Bitmap img)
	{
		if ((img.PixelFormat & (PixelFormat)851968) == 0)
		{
			return false;
		}
		try
		{
			for (int y = 0; y < img.Height; y++)
			{
				for (int x = 0; x < img.Width; x++)
				{
					if (img.GetPixel(x, y).A != byte.MaxValue)
					{
						return true;
					}
				}
			}
		}
		catch (Exception e)
		{
			_Logger.Error($"Could not check for Alpha: Exception {e}");
		}
		return false;
	}

	private bool HasAlpha(MagickImage img)
	{
		try
		{
			int alphaChannelIndex = img.Channels.ToList().FindIndex((PixelChannel ch) => (int)ch == 4);
			if (alphaChannelIndex < 0)
			{
				return false;
			}
			if (Settings.Default.UseUpdatedTransparencyCheck)
			{
				return !img.IsOpaque;
			}
			IPixelCollection pc = img.GetPixels();
			for (int y = 0; y < img.Height; y++)
			{
				for (int x = 0; x < img.Width; x++)
				{
					if (pc.GetValue(x, y)[alphaChannelIndex] != byte.MaxValue)
					{
						return true;
					}
				}
			}
		}
		catch (Exception e)
		{
			_Logger.Error($"Could not check for Alpha: Exception {e}");
		}
		return false;
	}
}
