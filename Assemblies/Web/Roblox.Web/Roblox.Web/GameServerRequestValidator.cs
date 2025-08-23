using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Web;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Infrastructure;
using Roblox.Web.Properties;
using Roblox.Web.RequestValidator;

namespace Roblox.Web;

public class GameServerRequestValidator : IGameServerRequestValidator
{
	private readonly ILogger _Logger;

	private readonly Roblox.Common.Properties.ISettings _CommonSettings;

	private readonly Roblox.Web.Properties.ISettings _WebSettings;

	private readonly IServerValidator _ServerValidator;

	private readonly IGameServerRequestValidationPerformanceCounters _PerformanceCounters;

	internal const string AccessKeyHeaderName = "accesskey";

	internal const string PlaceIdHeaderName = "Roblox-Place-Id";

	internal const string GameIdHeaderName = "Roblox-Game-Id";

	internal const string JobSignatureHeaderName = "Roblox-Job-Signature";

	internal const string PlayerCountHeaderName = "PlayerCount";

	internal const string RequestValidationKey = "ValidatedGameServerRequest";

	private const string _CookieHeaderName = "Cookie";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.GameServerRequestValidator" /> class.
	/// </summary>
	/// <param name="counterRegistry">An <see cref="T:Roblox.Instrumentation.ICounterRegistry" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	[ExcludeFromCodeCoverage]
	public GameServerRequestValidator(ICounterRegistry counterRegistry, ILogger logger)
		: this(logger, new GameServerRequestValidationPerformanceCounter(counterRegistry), Roblox.Common.Properties.Settings.Default, Roblox.Web.Properties.Settings.Default, ServerValidator.RobloxServerValidator)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.GameServerRequestValidator" /> class.
	/// </summary>
	/// <remarks>
	/// This constructor is intended for tests only! Do not make public.
	/// </remarks>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="performanceCounters">The <see cref="T:Roblox.Web.GameServerRequestValidationPerformanceCounter" />.</param>
	/// <param name="commonSettings">A <see cref="T:Roblox.Common.Properties.ISettings" />.</param>
	/// <param name="webSettings">A <see cref="T:Roblox.Web.Properties.ISettings" />.</param>
	/// <param name="serverValidator">An <see cref="T:Roblox.Platform.Infrastructure.IServerValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	internal GameServerRequestValidator(ILogger logger, IGameServerRequestValidationPerformanceCounters performanceCounters, Roblox.Common.Properties.ISettings commonSettings, Roblox.Web.Properties.ISettings webSettings, IServerValidator serverValidator)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_PerformanceCounters = performanceCounters ?? throw new ArgumentNullException("performanceCounters");
		_CommonSettings = commonSettings ?? throw new ArgumentNullException("commonSettings");
		_WebSettings = webSettings ?? throw new ArgumentNullException("webSettings");
		_ServerValidator = serverValidator ?? throw new ArgumentNullException("serverValidator");
	}

	/// <inheritdoc cref="M:Roblox.Web.IGameServerRequestValidator.IsValidGameServerRequest(System.Web.HttpContext)" />
	/// <remarks>
	/// HttpContext is not fakeable. Tests done on HttpContextBase method below.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public bool IsPotentialGameServer(HttpContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return IsPotentialGameServer(context.Request.Headers);
	}

	/// <inheritdoc cref="M:Roblox.Web.IGameServerRequestValidator.IsValidGameServerRequest(System.Web.HttpContextBase)" />
	public bool IsPotentialGameServer(HttpContextBase context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return IsPotentialGameServer(context.Request.Headers);
	}

	public bool IsPotentialGameServer(NameValueCollection headers)
	{
		return !string.IsNullOrWhiteSpace(headers.Get("accesskey"));
	}

	/// <inheritdoc cref="M:Roblox.Web.IGameServerRequestValidator.IsValidGameServerRequest(System.Web.HttpContext)" />
	/// <remarks>
	/// HttpContext is not fakeable. Tests done on HttpContextBase method below.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public bool IsValidGameServerRequest(HttpContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return IsValidGameServerRequest(context.GetOriginIP(), context.Request.Headers, context.Items);
	}

	/// <inheritdoc cref="M:Roblox.Web.IGameServerRequestValidator.IsValidGameServerRequest(System.Web.HttpContextBase)" />
	public bool IsValidGameServerRequest(HttpContextBase context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		string ipAddress = GetIpAddress(context);
		return IsValidGameServerRequest(ipAddress, context.Request.Headers, context.Items);
	}

	public bool IsValidGameServerRequest(string ipAddress, NameValueCollection headers, IDictionary requestItems)
	{
		if (string.IsNullOrEmpty(ipAddress))
		{
			throw new ArgumentNullException("ipAddress");
		}
		if (headers == null)
		{
			throw new ArgumentNullException("headers");
		}
		if (requestItems == null)
		{
			throw new ArgumentNullException("requestItems");
		}
		if (requestItems.Contains("ValidatedGameServerRequest"))
		{
			return (bool)requestItems["ValidatedGameServerRequest"];
		}
		bool isValid = VerifyIpAddress(headers, ipAddress) && VerifyAccessKey(headers, ipAddress) && VerifyJobSignature(headers, ipAddress);
		if (isValid)
		{
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.ValidRequest);
		}
		requestItems.Add("ValidatedGameServerRequest", isValid);
		return isValid;
	}

	internal bool VerifyIpAddress(NameValueCollection requestHeaders, string ipAddress)
	{
		if (!_CommonSettings.VerifyBothGameServerIpAndAccessKey || VerifyIpAccess(ipAddress))
		{
			return true;
		}
		_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.InvalidIpAddress);
		_Logger.Warning(() => BuildLoggerMessage("ip address not allowed", requestHeaders, ipAddress));
		return false;
	}

	internal bool VerifyAccessKey(NameValueCollection requestHeaders, string ipAddress)
	{
		string accessKey = requestHeaders.Get("accesskey");
		if (string.IsNullOrWhiteSpace(accessKey))
		{
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.MissingAccessKey);
			_Logger.Warning(() => BuildLoggerMessage("no access key", requestHeaders, ipAddress));
			return false;
		}
		bool isPrimaryAccessKey = accessKey == _CommonSettings.AccessKey;
		bool isAlternateAccessKey = accessKey == _CommonSettings.AlternateAccessKey;
		if (!isPrimaryAccessKey && !isAlternateAccessKey)
		{
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.InvalidAccessKey);
			_Logger.Warning(() => BuildLoggerMessage($"invalid access key\n\tAccess Key: {accessKey}", requestHeaders, ipAddress));
			return false;
		}
		if (isAlternateAccessKey && !isPrimaryAccessKey)
		{
			_Logger.Warning(() => BuildLoggerMessage("alternate access key in use", requestHeaders, ipAddress));
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.AlternateAccessKeyUsed);
		}
		return true;
	}

	internal bool VerifyJobSignature(NameValueCollection headers, string ipAddress)
	{
		if (!_WebSettings.IsGameServerJobSignatureCheckEnabled || !IsGamesRelayIpAddress(ipAddress))
		{
			return true;
		}
		string placeIdHeader = headers.Get("Roblox-Place-Id");
		if (!long.TryParse(placeIdHeader, out var placeId))
		{
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.InvalidPlaceId);
			_Logger.Warning(() => BuildLoggerMessage("invalid place id", headers, ipAddress, placeIdHeader));
			return false;
		}
		string gameIdHeader = headers.Get("Roblox-Game-Id");
		if (!Guid.TryParse(gameIdHeader, out var gameId))
		{
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.InvalidGameId);
			_Logger.Warning(() => BuildLoggerMessage("invalid game id", headers, ipAddress, placeId.ToString(), gameIdHeader));
			return false;
		}
		string jobSignatureHeader = headers.Get("Roblox-Job-Signature");
		if (string.IsNullOrWhiteSpace(jobSignatureHeader))
		{
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.JobSignatureInvalid);
			_Logger.Warning(() => BuildLoggerMessage("no job signature", headers, ipAddress, placeId.ToString(), gameId.ToString(), jobSignatureHeader));
			return false;
		}
		string expectedJobSignature = BuildJobSignature(placeId, gameId, ipAddress, useAlternateSalt: false);
		if (jobSignatureHeader != expectedJobSignature)
		{
			string alternateJobSignature = BuildJobSignature(placeId, gameId, ipAddress, useAlternateSalt: true);
			if (!(jobSignatureHeader == alternateJobSignature))
			{
				_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.JobSignatureInvalid);
				_Logger.Warning(() => BuildLoggerMessage("invalid job signature", headers, ipAddress, placeId.ToString(), gameId.ToString(), jobSignatureHeader));
				return false;
			}
			_PerformanceCounters.IncrementCounter(GameServerRequestValidationMetricsCounter.AlternateJobSignatureSaltUsed);
			_Logger.Warning(() => BuildLoggerMessage("alternate job signature in use", headers, ipAddress, placeId.ToString(), gameId.ToString(), jobSignatureHeader));
		}
		return true;
	}

	[ExcludeFromCodeCoverage]
	internal virtual string BuildJobSignature(long placeId, Guid gameId, string ipAddress, bool useAlternateSalt)
	{
		return GameServerValidator.BuildJobSignature(placeId, gameId, ipAddress, useAlternateSalt);
	}

	public bool VerifyIpAccess(string ipAddress)
	{
		return _ServerValidator.VerifyAccess(ipAddress);
	}

	[ExcludeFromCodeCoverage]
	internal virtual bool IsGamesRelayIpAddress(string ipAddress)
	{
		return GameServerValidator.IsValidGamesRelayIp(ipAddress);
	}

	[ExcludeFromCodeCoverage]
	internal virtual string GetIpAddress(HttpContextBase context)
	{
		return context.GetOriginIP();
	}

	[ExcludeFromCodeCoverage]
	internal virtual string GetRequestUrl()
	{
		if (HttpContext.Current != null)
		{
			return HttpContext.Current.Request.Url.AbsoluteUri;
		}
		return string.Empty;
	}

	internal string BuildLoggerMessage(string message, NameValueCollection requestHeaders, string ipAddress, string placeId = null, string gameId = null, string jobSignature = null)
	{
		string requestUrl = GetRequestUrl();
		string value = string.Format("{0}: {1}\n\tRequest Url: {2}\n\tIP Address: {3}", "GameServerRequestValidator", message, requestUrl, ipAddress);
		ServerType? serverType = _ServerValidator.GetServerTypeByIpAddress(ipAddress);
		int? serverTypeId = _ServerValidator.GetServerTypeIdByIpAddress(ipAddress);
		value += $"\n\tServer Type: {serverType} ({serverTypeId})";
		ServerStatus? serverStatus = _ServerValidator.GetServerStatusByIpAddress(ipAddress);
		int? serverStatusId = _ServerValidator.GetServerStatusIdByIpAddress(ipAddress);
		value += $"\n\tServer Status: {serverStatus} ({serverStatusId})";
		if (placeId != null)
		{
			value += $"\n\tPlace ID: {placeId}";
		}
		if (gameId != null)
		{
			value += $"\n\tGame ID: {gameId}";
		}
		if (jobSignature != null)
		{
			value += $"\n\tJob Signature: {jobSignature}";
		}
		value += "\n\nRequest Headers";
		if (requestHeaders.AllKeys.Contains("Cookie"))
		{
			value += " (has cookie)";
		}
		foreach (string name in requestHeaders)
		{
			if (name != "Cookie")
			{
				value += $"\n\t{name}: {requestHeaders[name]}";
			}
		}
		return value;
	}

	public int GetCurrentNumberOfPlayers(HttpRequestMessage request)
	{
		if (request.Headers.TryGetValues("PlayerCount", out var values) && values != null)
		{
			foreach (string item in values)
			{
				if (int.TryParse(item, out var result))
				{
					return result;
				}
			}
		}
		return 0;
	}

	public int GetCurrentNumberOfPlayers(NameValueCollection requestHeaders)
	{
		int.TryParse(requestHeaders.Get("PlayerCount"), out var playerCount);
		return playerCount;
	}

	public Guid GetGameInstanceId(HttpRequestMessage request)
	{
		if (request.Headers.TryGetValues("Roblox-Game-Id", out var values) && values != null)
		{
			foreach (string item in values)
			{
				if (Guid.TryParse(item, out var result))
				{
					return result;
				}
			}
		}
		return Guid.Empty;
	}

	public Guid GetGameInstanceId(NameValueCollection requestHeaders)
	{
		Guid.TryParse(requestHeaders.Get("Roblox-Game-Id"), out var gameId);
		return gameId;
	}

	public long GetPlaceId(HttpRequestMessage request)
	{
		if (request.Headers.TryGetValues("Roblox-Place-Id", out var values) && values != null)
		{
			foreach (string item in values)
			{
				if (long.TryParse(item, out var result))
				{
					return result;
				}
			}
		}
		return 0L;
	}

	public long GetPlaceId(NameValueCollection requestHeaders)
	{
		long.TryParse(requestHeaders.Get("Roblox-Place-Id"), out var placeId);
		return placeId;
	}
}
