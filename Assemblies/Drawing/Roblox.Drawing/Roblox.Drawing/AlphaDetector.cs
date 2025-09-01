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
	private const int MaxImageSizeBytes = 10 * 1024 * 1024; // 10MB
	private const int MaxImageDimension = 8192; // Max width/height in pixels
	private readonly ILogger _Logger;

	public AlphaDetector(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	private static void ValidateImageInput(byte[] inputImageData)
	{
		if (inputImageData == null)
			throw new ArgumentNullException(nameof(inputImageData));
		
		if (inputImageData.Length > MaxImageSizeBytes)
			throw new ArgumentException($"Image size exceeds maximum allowed size of {MaxImageSizeBytes} bytes");
	}

	private static void ValidateImageInput(Stream inputImageStream)
	{
		if (inputImageStream == null)
			throw new ArgumentNullException(nameof(inputImageStream));
		
		if (inputImageStream.Length > MaxImageSizeBytes)
			throw new ArgumentException($"Image size exceeds maximum allowed size of {MaxImageSizeBytes} bytes");
	}

	private static void ValidateImageInput(string inputImagePath)
	{
		if (string.IsNullOrEmpty(inputImagePath))
			throw new ArgumentNullException(nameof(inputImagePath));
		
		var fileInfo = new FileInfo(inputImagePath);
		if (!fileInfo.Exists)
			throw new FileNotFoundException("Image file not found", inputImagePath);
		
		if (fileInfo.Length > MaxImageSizeBytes)
			throw new ArgumentException($"Image size exceeds maximum allowed size of {MaxImageSizeBytes} bytes");
	}

	private static void ValidateImageDimensions(MagickImage img)
	{
		if (img.Width > MaxImageDimension || img.Height > MaxImageDimension)
			throw new ArgumentException($"Image dimensions exceed maximum allowed size of {MaxImageDimension}x{MaxImageDimension} pixels");
	}

	/// <summary>
	/// Returns true if an image has an alpha channel actually in use.  
	/// Returns false if the image either does not have an alpha channel, 
	/// or if it was saved with an alpha channel but is opaque everywhere.
	/// </summary>
	public bool HasAlpha(byte[] inputImageData, bool useImageMagick = true)
	{
		ValidateImageInput(inputImageData);
		
		if (useImageMagick)
		{
			MagickImage img = new MagickImage(inputImageData);
			try
			{
				ValidateImageDimensions(img);
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
		ValidateImageInput(inputImageStream);
		
		if (useImageMagick)
		{
			MagickImage img = new MagickImage(inputImageStream);
			try
			{
				ValidateImageDimensions(img);
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
		ValidateImageInput(inputImagePath);
		
		if (useImageMagick)
		{
			MagickImage img = new MagickImage(inputImagePath);
			try
			{
				ValidateImageDimensions(img);
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
			IPixelCollection<byte> pc = img.GetPixels();
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
