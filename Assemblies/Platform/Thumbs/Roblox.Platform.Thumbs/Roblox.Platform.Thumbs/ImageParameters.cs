using System;
using System.Drawing.Imaging;
using System.Web;
using System.Web.UI.WebControls;

namespace Roblox.Thumbs;

public class ImageParameters : IEquatable<ImageParameters>, IComparable<ImageParameters>
{
	private static readonly ImageParameters _ImageParameters110X110 = new ImageParameters(110, 110, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters420X420 = new ImageParameters(420, 420, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters75X75 = new ImageParameters(75, 75, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters48X48 = new ImageParameters(48, 48, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters100X100 = new ImageParameters(100, 100, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters150X200 = new ImageParameters(150, 200, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters352X352 = new ImageParameters(352, 352, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters160X100 = new ImageParameters(160, 100, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters420X230 = new ImageParameters(420, 230, ImageFormat.Png);

	private static readonly ImageParameters _ImageParameters140x140 = new ImageParameters(140, 140, ImageFormat.Png);

	public int Width { get; private set; }

	public int Height { get; private set; }

	public ImageFormat Format { get; private set; }

	public int ThumbnailFormatID { get; private set; }

	public string FileExtension => Format.ToString();

	public string MimeType
	{
		get
		{
			if (Format == ImageFormat.Jpeg)
			{
				return "image/jpg";
			}
			if (Format == ImageFormat.Png)
			{
				return "image/png";
			}
			if (Format == ImageFormat.Bmp)
			{
				return "image/bmp";
			}
			if (Format == ImageFormat.Gif)
			{
				return "image/gif";
			}
			if (Format == ImageFormat.Tiff)
			{
				return "image/tiff";
			}
			return "image";
		}
	}

	public ImageParameters(Unit width, Unit height, ImageFormat format)
		: this(width, height, format, 0)
	{
	}

	public ImageParameters(Unit width, Unit height, ImageFormat format, int thumbnailFormatId)
	{
		Width = (int)width.Value;
		Height = (int)height.Value;
		Format = format;
		ThumbnailFormatID = thumbnailFormatId;
		CheckArguments();
	}

	/// <summary>
	/// Make sure given width/height equals given thumbnailformat.width/height
	/// </summary>
	private bool CheckThumbnailFormatIntegrity(ref string failureMessage)
	{
		if (ThumbnailFormatID > 0)
		{
			ThumbnailFormat tf = ThumbnailFormat.Get(ThumbnailFormatID);
			if (tf == null)
			{
				failureMessage = $"ThumbnailFormatID: {ThumbnailFormatID} was not found";
				return false;
			}
			if (Width > 0 && tf.Width != Width)
			{
				failureMessage = $"ThumbnailFormat.Width({tf.Width}) does not equal Width given in Querystring({Width})";
				return false;
			}
			if (Height > 0 && tf.Height != Height)
			{
				failureMessage = $"ThumbnailFormat.Height({tf.Height}) does not equal Height given in Querystring({Height})";
				return false;
			}
		}
		return true;
	}

	private void CheckArguments(bool checkThumbnailFormatIntegrity = false)
	{
		if (Width <= 0)
		{
			throw new ArgumentOutOfRangeException("width", Width, "Must be > 0");
		}
		if (Height <= 0)
		{
			throw new ArgumentOutOfRangeException("height", Height, "Must be > 0");
		}
		if (Width > 2048)
		{
			throw new ArgumentOutOfRangeException("width", Width, "Must be <= 2048");
		}
		if (Height > 2048)
		{
			throw new ArgumentOutOfRangeException("height", Height, "Must be <= 2048");
		}
		string message = "";
		if (checkThumbnailFormatIntegrity && !CheckThumbnailFormatIntegrity(ref message))
		{
			throw new ArgumentException(message);
		}
	}

	public ImageParameters(int width, int height, ImageFormat format)
		: this(width, height, format, 0)
	{
	}

	public ImageParameters(int width, int height, ImageFormat format, int thumbnailFormatId)
	{
		Width = width;
		Height = height;
		Format = format;
		ThumbnailFormatID = thumbnailFormatId;
	}

	public ImageParameters(int width, int height, string format)
		: this(width, height, format, 0)
	{
	}

	public ImageParameters(int width, int height, string format, int thumbnailFormatId)
	{
		ThumbnailFormatID = thumbnailFormatId;
		if (ThumbnailFormatID != 0)
		{
			ThumbnailFormat f = ThumbnailFormat.Get(thumbnailFormatId);
			Width = f.Width;
			Height = f.Height;
			Format = f.ImageFormat;
		}
		else
		{
			Width = width;
			Height = height;
			Format = ThumbnailFormat.ParseImageFormat(format);
		}
		CheckArguments();
	}

	public ImageParameters(int width, int height)
	{
		Width = width;
		Height = height;
		Format = ImageFormat.Png;
		CheckArguments();
	}

	public override string ToString()
	{
		string result = $"x={Width}&y={Height}&format={Format}";
		if (ThumbnailFormatID != 0)
		{
			result = result + "&tfid=" + ThumbnailFormatID;
		}
		return result;
	}

	public ImageParameters(HttpRequest request)
	{
		if (request.QueryString["x"] != null)
		{
			try
			{
				Width = int.Parse(request.QueryString["x"]);
			}
			catch
			{
				throw new Exception(string.Format("Invalid thumbnail request querystring parameter: x={0}", request.QueryString["x"]));
			}
		}
		else if (request.QueryString["Width"] != null)
		{
			try
			{
				Width = int.Parse(request.QueryString["Width"]);
			}
			catch
			{
				throw new Exception(string.Format("Invalid thumbnail request querystring parameter: Width={0}", request.QueryString["Width"]));
			}
		}
		else
		{
			Width = 64;
		}
		if (request.QueryString["y"] != null)
		{
			try
			{
				Height = int.Parse(request.QueryString["y"]);
			}
			catch
			{
				throw new Exception(string.Format("Invalid thumbnail request querystring parameter: y={0}", request.QueryString["y"]));
			}
		}
		else if (request.QueryString["Height"] != null)
		{
			try
			{
				Height = int.Parse(request.QueryString["Height"]);
			}
			catch
			{
				throw new Exception(string.Format("Invalid thumbnail request querystring parameter: Height={0}", request.QueryString["Height"]));
			}
		}
		else
		{
			Height = 64;
		}
		bool checkThumbnailFormatIntegrity = false;
		if (request.QueryString["tfid"] != null)
		{
			try
			{
				ThumbnailFormatID = int.Parse(request.QueryString["tfid"]);
			}
			catch
			{
				throw new Exception(string.Format("Invalid thumbnail request querystring parameter: tfid={0}", request.QueryString["tfid"]));
			}
		}
		else if (request.QueryString["ThumbnailFormatID"] != null)
		{
			try
			{
				ThumbnailFormatID = int.Parse(request.QueryString["ThumbnailFormatID"]);
			}
			catch
			{
				throw new Exception(string.Format("Invalid thumbnail request querystring parameter: ThumbnailFormatID={0}", request.QueryString["ThumbnailFormatID"]));
			}
		}
		Format = ThumbnailFormat.ParseImageFormat(request.QueryString["Format"]);
		CheckArguments(checkThumbnailFormatIntegrity);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is ImageParameters other))
		{
			return false;
		}
		return CompareTo(other) == 0;
	}

	public override int GetHashCode()
	{
		return Width.GetHashCode() ^ Height.GetHashCode() ^ Format.GetHashCode();
	}

	public bool Equals(ImageParameters other)
	{
		return CompareTo(other) == 0;
	}

	public int CompareTo(ImageParameters other)
	{
		int result = other.Width.CompareTo(Width);
		if (result != 0)
		{
			return result;
		}
		result = other.Height.CompareTo(Height);
		if (result != 0)
		{
			return result;
		}
		return other.Format.Guid.CompareTo(Format.Guid);
	}

	public static ImageParameters GetByImageType(ImageType type)
	{
		return type switch
		{
			ImageType.ItemSmall => _ImageParameters110X110, 
			ImageType.ItemLarge => _ImageParameters420X420, 
			ImageType.GroupSmall => _ImageParameters75X75, 
			ImageType.AvatarTiny => _ImageParameters48X48, 
			ImageType.AvatarSmall => _ImageParameters100X100, 
			ImageType.AvatarMedium => _ImageParameters150X200, 
			ImageType.AvatarLarge => _ImageParameters352X352, 
			ImageType.PlaceSmall => _ImageParameters160X100, 
			ImageType.PlaceLarge => _ImageParameters420X230, 
			ImageType.GameIcon => _ImageParameters140x140, 
			_ => throw new ApplicationException($"Bad ImageType: {type}"), 
		};
	}
}
