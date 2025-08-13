using System;

namespace Roblox.Thumbnails.RequestValidation;

public class InvalidThumbnailSizeException : Exception
{
	public InvalidThumbnailSizeException(string message)
		: base(message)
	{
	}
}
