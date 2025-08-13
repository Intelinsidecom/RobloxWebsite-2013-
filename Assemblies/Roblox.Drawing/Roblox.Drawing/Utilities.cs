using System;
using System.Drawing.Imaging;

namespace Roblox.Drawing;

public class Utilities
{
	/// <summary>
	/// parses string representation of format (such as Bmp, Jpeg, Png, etc...) into actual ImageFormat
	/// </summary>
	/// <param name="format">a string representation of format, such as: Bmp, Jpeg, Png, etc...</param>
	/// <returns>ImageFormat</returns>
	/// <see cref="T:System.Drawing.Imaging.ImageFormat" />
	public static ImageFormat ParseImageFormat(string format)
	{
		if (format == null)
		{
			throw new Exception("ImageFormat ParseImageFormat(format) -> Innalid command parameter.");
		}
		return format switch
		{
			"Bmp" => ImageFormat.Bmp, 
			"Emf" => ImageFormat.Emf, 
			"Exif" => ImageFormat.Exif, 
			"Gif" => ImageFormat.Gif, 
			"Icon" => ImageFormat.Icon, 
			"Jpeg" => ImageFormat.Jpeg, 
			"MemoryBmp" => ImageFormat.MemoryBmp, 
			"Png" => ImageFormat.Png, 
			"Tiff" => ImageFormat.Tiff, 
			"Wmf" => ImageFormat.Wmf, 
			_ => throw new Exception($"ImageFormat ParseImageFormat(format) -> Not Supported Image Format [{format}]"), 
		};
	}

	/// <summary>
	/// Tries to parse a string representation of format (such as Bmp, Jpeg, Png, etc...) into the actual ImageFormat
	/// </summary>
	/// <param name="format">A string representation of format, such as: Bmp, Jpeg, Png, etc...</param>
	/// <param name="parsedFormat">Parsed ImageFormat</param>
	/// <returns>bool representing whether the parsing was successful</returns>
	public static bool TryParseImageFormat(string format, out ImageFormat parsedFormat)
	{
		parsedFormat = null;
		if (format != null)
		{
			if (string.Compare(format, "Bmp", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Bmp;
			}
			else if (string.Compare(format, "Emf", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Emf;
			}
			else if (string.Compare(format, "Exif", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Exif;
			}
			else if (string.Compare(format, "Gif", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Gif;
			}
			else if (string.Compare(format, "Icon", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Icon;
			}
			else if (string.Compare(format, "Jpeg", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Jpeg;
			}
			else if (string.Compare(format, "MemoryBmp", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.MemoryBmp;
			}
			else if (string.Compare(format, "Png", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Png;
			}
			else if (string.Compare(format, "Tiff", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Tiff;
			}
			else if (string.Compare(format, "Wmf", ignoreCase: true) == 0)
			{
				parsedFormat = ImageFormat.Wmf;
			}
		}
		return parsedFormat != null;
	}
}
