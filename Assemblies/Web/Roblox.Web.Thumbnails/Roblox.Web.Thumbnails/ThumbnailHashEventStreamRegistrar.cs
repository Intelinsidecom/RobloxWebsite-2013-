using System;
using System.Collections.Specialized;
using System.Web;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.EventStream.WebEvents.EventArgs;
using Roblox.Platform.EventStream.WebEvents.Events;
using Roblox.Thumbnails.Client;
using Roblox.Web.Thumbnails.Properties;

namespace Roblox.Web.Thumbnails;

public class ThumbnailHashEventStreamRegistrar
{
	private readonly BufferedEventStreamer _ThumbnailHashRequestedEventStreamer;

	private readonly ILogger _Logger;

	private readonly ThumbnailsClient _ThumbnailsClient;

	public ThumbnailHashEventStreamRegistrar(ICounterRegistry counterRegistry, ThumbnailsClient thumbnailsClient, ILogger logger)
	{
		_ThumbnailHashRequestedEventStreamer = new BufferedEventStreamer(new EventStreamer(counterRegistry, logger), () => Settings.Default.ThumbnailHashRequestedEventStreamBufferTime, logger, () => Settings.Default.ThumbnailHashRequestPercentRollout);
		_Logger = logger;
		_ThumbnailsClient = thumbnailsClient;
	}

	public void RegisterEvents()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		_ThumbnailsClient.OnThumbnailHashRequested += new OnThumbnailHashRequestedEvent(HandleThumbnailHashRequestedEvent);
	}

	private void HandleThumbnailHashRequestedEvent(int width, int height, string thumbnailTypeName, string formatType)
	{
		if (!Settings.Default.AreThumbnailHashRequestedEventsStreamed)
		{
			return;
		}
		try
		{
			Func<ThumbnailHashRequestedEventArgs> argsGetter = delegate
			{
				ThumbnailHashRequestedEventArgs thumbnailHashRequestedEventArgs = new ThumbnailHashRequestedEventArgs
				{
					DimensionsX = width,
					DimensionsY = height,
					EntityType = thumbnailTypeName,
					FileFormat = formatType,
					Target = EventTarget.Thumbnails
				};
				NameValueCollection nameValueCollection = HttpContext.Current?.Request?.Headers;
				if (nameValueCollection != null && nameValueCollection.Get("PlayerCount") != null && nameValueCollection.Get("Requester") != null && nameValueCollection.Get("Roblox-Place-Id") != null && nameValueCollection.Get("Roblox-Game-Id") != null)
				{
					thumbnailHashRequestedEventArgs.RequesterType = "Game";
					thumbnailHashRequestedEventArgs.RequesterPlaceId = long.Parse(nameValueCollection.Get("Roblox-Place-Id"));
				}
				return thumbnailHashRequestedEventArgs;
			};
			new ThumbnailHashRequestedEvent(_ThumbnailHashRequestedEventStreamer, argsGetter).Stream();
		}
		catch (Exception e)
		{
			_Logger.Error($"Could not stream thumbnail hash event: {e}");
		}
	}
}
