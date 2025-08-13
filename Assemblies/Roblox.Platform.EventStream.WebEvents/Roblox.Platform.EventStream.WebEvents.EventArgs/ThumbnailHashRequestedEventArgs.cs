namespace Roblox.Platform.EventStream.WebEvents.EventArgs;

public class ThumbnailHashRequestedEventArgs : BasicEventArgs
{
	public string EntityType { get; set; }

	public string FileFormat { get; set; }

	public int DimensionsX { get; set; }

	public int DimensionsY { get; set; }

	public string RequesterType { get; set; }

	public long? RequesterPlaceId { get; set; }
}
