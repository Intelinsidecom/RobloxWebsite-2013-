using System;
using Roblox.Platform.EventStream.WebEvents.EventArgs;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class ThumbnailHashRequestedEvent : BufferedEventBase
{
	private const string _Name = "thumbnailHashRequested";

	public ThumbnailHashRequestedEvent(BufferedEventStreamer streamer, Func<ThumbnailHashRequestedEventArgs> args)
		: base(streamer, "thumbnailHashRequested", args)
	{
		if (_Args is ThumbnailHashRequestedEventArgs)
		{
			ThumbnailHashRequestedEventArgs finalArgs = _Args as ThumbnailHashRequestedEventArgs;
			AddEventArg("entityType", finalArgs.EntityType);
			AddEventArg("fileFormat", finalArgs.FileFormat);
			AddEventArg("dimensions", finalArgs.DimensionsX + "x" + finalArgs.DimensionsY);
			if (finalArgs.RequesterPlaceId.HasValue)
			{
				AddEventArg("reqPid", finalArgs.RequesterPlaceId.Value.ToString());
			}
			if (finalArgs.RequesterType != null)
			{
				AddEventArg("req", finalArgs.RequesterType);
			}
		}
	}
}
