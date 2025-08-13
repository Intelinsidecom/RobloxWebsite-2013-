namespace Roblox.Thumbs;

public interface IStaticImages
{
	ThumbnailDomainFactories DomainFactories { get; }

	ThumbResult GetUnavailableThumbResult(int width, int height, string format);

	ThumbResult GetBrokenThumbResult(int width, int height, string format);

	ThumbResult GetUnapprovedThumbResult(int width, int height, string format);

	ThumbResult GetUnreviewedThumbResult(int width, int height, string format);

	ThumbResult GetUnknownThumbResult(int width, int height, string format);

	/// <summary>
	/// Gets game icon thumbnail result by given size, format and index.
	/// </summary>
	/// <param name="width">The width of the thumbnail.</param>
	/// <param name="height">The height of the thumbnail.</param>
	/// <param name="format">The format of the thumbnail.</param>
	/// <param name="index">The index of the game icon. Minimum value is 1 and maximum value is 12.</param>
	/// <returns>Returns the game icon thumbnail result by given size, format and index.</returns>
	ThumbResult GetGameIconThumbResult(int width, int height, string format, int index);

	/// <summary>
	/// Gets game media item thumbnail result by given size, format and index.
	/// </summary>
	/// <param name="width">The width of the thumbnail.</param>
	/// <param name="height">The height of the thumbnail.</param>
	/// <param name="format">The format of the thumbnail.</param>
	/// <param name="index">The index of the game media item. Minimum value is 1 and maximum value is 12.</param>
	/// <returns>Returns the game media item thumbanil result by given size, format and index.</returns>
	ThumbResult GetGameMediaItemThumbResult(int width, int height, string format, int index);
}
