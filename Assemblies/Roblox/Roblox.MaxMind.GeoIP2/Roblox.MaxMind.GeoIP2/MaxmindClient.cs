using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Roblox.ApiClientBase;
using Roblox.MaxMind.GeoIP2.PerformanceCounters;
using Roblox.MaxMind.GeoIP2.Properties;
using Roblox.MaxMind.GeoIP2.Responses;

namespace Roblox.MaxMind.GeoIP2;

public class MaxmindClient : IMaxmindClient
{
	private const string _IPAddressNotFoundErrorCode = "IP_ADDRESS_NOT_FOUND";

	private readonly MaxMindCircuitBreaker _Sentinel = new MaxMindCircuitBreaker();

	private readonly IMaxMindPerformanceMonitor _PerformanceMonitor;

	private readonly IMaxMindSettings _Settings;

	private static readonly HashSet<WebExceptionStatus> _StatusesThatTripCircuitBreaker = new HashSet<WebExceptionStatus>
	{
		WebExceptionStatus.Timeout,
		WebExceptionStatus.NameResolutionFailure,
		WebExceptionStatus.ProxyNameResolutionFailure,
		WebExceptionStatus.RequestCanceled,
		WebExceptionStatus.ConnectionClosed,
		WebExceptionStatus.ConnectFailure
	};

	private static readonly IPLookupResult _OtherErrorResult = new IPLookupResult
	{
		IPLookupErrorType = IPLookupErrorType.Other
	};

	private static readonly IPLookupResult _BadRequestErrorResult = new IPLookupResult
	{
		IPLookupErrorType = IPLookupErrorType.BadRequest
	};

	private Response FetchResponse(IPLookupType ipLookupType, string ipAddress, out IPLookupErrorType? ipLookupErrorType)
	{
		using TimeoutWebClient wc = new TimeoutWebClient(_Settings.GeoIP2WebClientTimeout);
		if (_Settings.UseDirectHttpBasicAuthHeader)
		{
			string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_Settings.GeoIP2Username}:{_Settings.GeoIP2Password}"));
			wc.Headers[HttpRequestHeader.Authorization] = $"Basic {credentials}";
		}
		else
		{
			wc.Credentials = new NetworkCredential(_Settings.GeoIP2Username, _Settings.GeoIP2Password);
		}
		wc.Encoding = Encoding.UTF8;
		string url = _Settings.GeoIP2ServiceEndpoint + "/" + ipLookupType.ToString().ToLowerInvariant() + "/" + ipAddress;
		Stopwatch watch = new Stopwatch();
		watch.Start();
		try
		{
			string value = wc.DownloadString(url);
			watch.Stop();
			_PerformanceMonitor?.IncrementResponse(watch.Elapsed);
			Response response2 = JsonConvert.DeserializeObject<Response>(value);
			if (!string.IsNullOrEmpty(response2?.RepresentedCountry?.IsoCode))
			{
				_PerformanceMonitor?.IncrementResponseHasRepresentedCountry();
			}
			if (!string.IsNullOrEmpty(response2?.RegisteredCountry?.IsoCode))
			{
				_PerformanceMonitor?.IncrementResponseHasRegisteredCountry();
			}
			ipLookupErrorType = null;
			return response2;
		}
		catch (WebException e)
		{
			watch.Stop();
			_PerformanceMonitor?.IncrementException(wc, watch.Elapsed, e);
			HttpWebResponse response = (HttpWebResponse)e.Response;
			if (_StatusesThatTripCircuitBreaker.Contains(e.Status) || response.StatusCode == HttpStatusCode.ServiceUnavailable)
			{
				throw;
			}
			Stream responseStream = response.GetResponseStream();
			if (responseStream == null)
			{
				ipLookupErrorType = IPLookupErrorType.Other;
				return null;
			}
			Response errorResponse = JsonConvert.DeserializeObject<Response>(new StreamReader(responseStream).ReadToEnd());
			switch (response.StatusCode)
			{
			case HttpStatusCode.NotFound:
				ipLookupErrorType = ((!(errorResponse.Code == "IP_ADDRESS_NOT_FOUND")) ? IPLookupErrorType.Other : IPLookupErrorType.NotFound);
				break;
			case HttpStatusCode.BadRequest:
				ipLookupErrorType = IPLookupErrorType.BadRequest;
				break;
			default:
				ipLookupErrorType = IPLookupErrorType.Other;
				break;
			}
			return errorResponse;
		}
	}

	public MaxmindClient(IMaxMindPerformanceMonitor perfmon, IMaxMindSettings settings)
	{
		_PerformanceMonitor = perfmon;
		_Settings = settings;
	}

	public MaxmindClient(string apiName)
		: this(apiName, Settings.Default)
	{
	}

	private MaxmindClient(string apiName, IMaxMindSettings settings)
	{
		_Settings = settings;
		if (!string.IsNullOrEmpty(apiName))
		{
			_PerformanceMonitor = new MaxMindPerformanceMonitor(apiName, () => _Settings.EnableDetailedErrorLogging);
		}
	}

	public IIPLookupResult Lookup(string ip, IPLookupType ipLookupType)
	{
		if (string.IsNullOrWhiteSpace(ip))
		{
			return _BadRequestErrorResult;
		}
		if (!IPAddress.TryParse(ip, out var _))
		{
			return _BadRequestErrorResult;
		}
		IPLookupResult result = new IPLookupResult();
		try
		{
			_Sentinel.Execute(delegate
			{
				IPLookupErrorType? ipLookupErrorType;
				Response response = FetchResponse(ipLookupType, ip, out ipLookupErrorType);
				if (ipLookupErrorType.HasValue)
				{
					result.IPLookupErrorType = ipLookupErrorType;
				}
				else
				{
					if (response.RepresentedCountry != null && response.RepresentedCountry.IsoCode != null)
					{
						result.CountryCode = response.RepresentedCountry.IsoCode;
					}
					else if (response.Country != null && response.Country.IsoCode != null)
					{
						result.CountryCode = response.Country.IsoCode;
						if (response.Country.Names != null && response.Country.Names.ContainsKey("en"))
						{
							result.Country = response.Country.Names["en"];
						}
						else
						{
							result.Country = response.Country.IsoCode;
						}
					}
					else
					{
						result.IPLookupErrorType = IPLookupErrorType.Other;
					}
					if (response.Location != null)
					{
						result.Latitude = response.Location.Latitude;
						result.Longitude = response.Location.Longitude;
					}
					if (response.Subdivisions != null && response.Subdivisions.ElementAt(0).Names != null && response.Subdivisions.ElementAt(0).Names.ContainsKey("en"))
					{
						result.Subdivision = response.Subdivisions.ElementAt(0).Names["en"];
					}
					if (response.City != null)
					{
						result.City = response.City.Names["en"];
					}
					if (response.Traits != null)
					{
						result.Provider = response.Traits.AutonomousSystemOrganization;
					}
					if (response.Postal != null)
					{
						result.ZipCode = response.Postal.Code;
					}
				}
			});
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return _OtherErrorResult;
		}
		return result;
	}
}
