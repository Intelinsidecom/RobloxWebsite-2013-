using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Roblox.YouTube.Properties;

namespace Roblox.YouTube;

internal static class VideoParser
{
	public static VideoItem GetVideoItem(string videoId)
	{
		return _GetVideoItem(videoId);
	}

	private static VideoItem _GetVideoItem(string videoId)
	{
		Uri uri = new Uri($"https://www.googleapis.com/youtube/v3/videos?part=snippet%2CcontentDetails%2Cstatus&id={videoId}&key={Settings.Default.DeveloperKey}");
		using WebClient wc = new WebClient();
		VideoListResponse response = JsonConvert.DeserializeObject<VideoListResponse>(wc.DownloadString(uri));
		return (response == null || response.Items == null) ? null : response.Items.FirstOrDefault();
	}
}
