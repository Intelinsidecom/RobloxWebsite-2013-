using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using ImageMagick;

namespace Roblox.Drawing;

public static class FormatConverter
{
	private const int StreamBufferSize = 1024;

	private const int TgaFooterSize = 26;

	/// <summary>
	/// Determines whether a byte Stream constitutes TGA image data or not.
	///
	/// This works by paging to the end of the stream and looking for the TGA 2.0
	/// footer. If the TGA is 1.0 this method will not work, and there is no 100%
	/// foolproof way of determining if the data is TGA or not.
	/// </summary>
	/// <param name="texture">The Image stream.</param>
	/// <returns>True if the data stream contains the TGA footer tag.</returns>
	public static bool IsStreamTga(Stream imageStream)
	{
		if (imageStream == null)
		{
			throw new ArgumentNullException("imageStream");
		}
		byte[][] buffer = new byte[2][]
		{
			new byte[1024],
			new byte[1024]
		};
		int totalCount = 0;
		int index = 1;
		int lastCount;
		do
		{
			lastCount = imageStream.Read(buffer[index - 1], 0, 1024);
			index = 3 - index;
			totalCount++;
		}
		while (lastCount == 1024);
		imageStream.Seek(0L, SeekOrigin.Begin);
		if (totalCount == 1 && lastCount < 26)
		{
			return false;
		}
		byte[] sourceArray = buffer[index - 1].Concat(buffer[3 - index - 1]).ToArray();
		byte[] footerBuffer = new byte[26];
		int footerOffset = 1024 + lastCount - 26;
		Array.Copy(sourceArray, footerOffset, footerBuffer, 0, 26);
		if (Encoding.UTF8.GetString(footerBuffer).IndexOf("TRUEVISION-XFILE", StringComparison.Ordinal) > -1)
		{
			return true;
		}
		return false;
	}

	/// <summary>
	/// Converts the incompatible format (such as TGA) to a PNG the .Net library can use.
	/// </summary>
	/// <param name="imageStream">The image stream.</param>
	/// <returns>A new stream or null if the Stream is compatible</returns>
	/// <exception cref="T:System.ArgumentNullException">imageStream</exception>
	public static Stream ConvertIncompatibleFormatToPng(Stream imageStream)
	{
		if (imageStream == null)
		{
			throw new ArgumentNullException("imageStream");
		}
		Stream pngStream = null;
		if (Resizer.IsTgaUploadEnabled && IsStreamTga(imageStream))
		{
			pngStream = TgaToPng(imageStream);
		}
		return pngStream;
	}

	/// <summary>
	/// Converts a TGA data stream to a PNG data stream.
	/// </summary>
	/// <param name="imageStream">The image stream to convert.</param>
	/// <returns>
	/// A PNG data stream.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">imageStream</exception>
	/// <exception cref="T:System.InvalidOperationException">Unrecognized image format</exception>
	public static Stream TgaToPng(Stream imageStream)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_005d: Expected O, but got Unknown
		if (imageStream == null)
		{
			throw new ArgumentNullException("imageStream");
		}
		MemoryStream memoryStream = new MemoryStream();
		MagickReadSettings magickSettings = new MagickReadSettings
		{
			Format = (MagickFormat)208
		};
		((MagickSettings)magickSettings).SetDefine((MagickFormat)163, "exclude-chunks", "date");
		try
		{
			MagickImage sourceImage = new MagickImage(imageStream, magickSettings);
			try
			{
				sourceImage.Write((Stream)memoryStream, (MagickFormat)163);
			}
			finally
			{
				((IDisposable)sourceImage)?.Dispose();
			}
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
		memoryStream.Seek(0L, SeekOrigin.Begin);
		imageStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	/// <summary>
	/// Turns a stream into an image, making sure the stream is one .NET's image code can handle
	/// </summary>
	/// <param name="imageStream">The image stream.</param>
	/// <returns>An image derived from the stream.</returns>
	/// <exception cref="T:System.ArgumentNullException">imageStream</exception>
	public static Image ImageFromStream(Stream imageStream)
	{
		if (imageStream == null)
		{
			throw new ArgumentNullException("imageStream");
		}
		Image image = null;
		using Stream stream = ConvertIncompatibleFormatToPng(imageStream);
		return Image.FromStream(stream ?? imageStream);
	}
}
