using System;
namespace Roblox.Platform.Thumbnails.RequestValidation {
    public class InvalidThumbnailSizeException : Exception

{
	public InvalidThumbnailSizeException(string message)
		: base(message)
	{
	}
}


}
