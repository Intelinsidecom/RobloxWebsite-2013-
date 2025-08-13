using System;
using Newtonsoft.Json.Linq;
using Roblox.ApiClientBase;
using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Web.Code.Properties;

namespace Roblox.Web.Code.Itunes;

public class AppReviewGenerator
{
	private string _RedisLockKey = "GetItunesReviews";

	private ISharedCacheClient _CacheClient;

	private ILogger _Logger;

	private string _ItunesCacheKey => "FiveStarReviewGenV2_Itunes";

	public AppReviewGenerator(ISharedCacheClient cacheClient, ILogger logger)
	{
		_CacheClient = cacheClient;
		_Logger = logger;
	}

	public ItunesAppInfoModel GetItunesReviews()
	{
		if (_CacheClient.Query(_ItunesCacheKey, out ItunesAppInfoModel result))
		{
			return result;
		}
		result = new ItunesAppInfoModel
		{
			AverageUserRating = Settings.Default.ItunesAppRatingDefault,
			UserRatingCount = Settings.Default.ItunesAppRatingCountDefault
		};
		TimeSpan requestDuration = TimeSpan.FromSeconds(5.0);
		try
		{
			using IRedisLeasedLock leasedLock = CreateRedisLock(requestDuration);
			if (leasedLock.TryAcquire())
			{
				JObject obj = JObject.Parse(GetApiResponse(requestDuration));
				if (obj?.SelectToken("results")?.First != null)
				{
					result = obj.SelectToken("results").First.ToObject<ItunesAppInfoModel>();
				}
				if (result.AverageUserRating > 0.0 && result.UserRatingCount > 0)
				{
					_CacheClient.Set(_ItunesCacheKey, result, Settings.Default.ItunesAppRatingValidResultCacheExpiration);
				}
			}
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			_CacheClient.Set(_ItunesCacheKey, result, Settings.Default.ItunesAppRatingInvalidResultCacheExpiration);
		}
		return result;
	}

	internal virtual IRedisLeasedLock CreateRedisLock(TimeSpan duration)
	{
		return new RedisLeasedLock(_RedisLockKey, duration, _Logger.Error);
	}

	internal virtual string GetApiResponse(TimeSpan timeout)
	{
		using TimeoutWebClient wc = new TimeoutWebClient(timeout);
		return wc.DownloadString(Settings.Default.ItunesAppRatingApiEndpoint);
	}
}
