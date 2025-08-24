using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DnsClient;
using DnsClient.Protocol;
using Roblox.Instrumentation;
using Roblox.Kickbox.PerformanceCounters;
using Roblox.Kickbox.Properties;
using Roblox.Redis;
using Roblox.Redis.Lru;
using Roblox.RestClientBase;
using StackExchange.Redis;

namespace Roblox.Kickbox;

/// <summary>
/// Kickbox Client
/// </summary>
public class KickboxClient : IKickboxClient
{
	private readonly IKickboxRestClient _RestClient;

	private readonly IKickboxVerifyDomainPerformanceMonitor _VerifyDomainPerformanceMonitor;

	private readonly Lazy<IKickboxVerifyEmailPerformanceMonitor> _VerifyEmailPerformanceMonitor;

	private readonly IKickboxSettings _Settings;

	private readonly IRedisClient _RedisClient;

	private readonly ILookupClient _DnsLookupClient;

	private string DisposableDomainCachePrefix => _Settings.DisposableDomainCachePrefix;

	private string SafeDomainCachePrefix => _Settings.SafeDomainCachePrefix;

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="counterRegistry">CounterRegistry Injected.</param>
	/// <param name="apiName">Name of the parent service making these called. Used for logging.</param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	public KickboxClient(ICounterRegistry counterRegistry, string apiName = "Kickbox API")
	{
		KickboxClient kickboxClient = this;
		_RestClient = new KickboxRestClient();
		_Settings = Settings.Default;
		_VerifyDomainPerformanceMonitor = new KickboxVerifyDomainPerformanceMonitor(counterRegistry, apiName, _Settings);
		_VerifyEmailPerformanceMonitor = new Lazy<IKickboxVerifyEmailPerformanceMonitor>(() => new KickboxVerifyEmailPerformanceMonitor(counterRegistry, apiName, kickboxClient._Settings));
		_RedisClient = RedisLruClient.GetInstance();
		_DnsLookupClient = new LookupClient
		{
			UseCache = true
		};
	}

	/// <summary>
	/// Internal test constructor allows us to fake the restClient, performanceMonitor, and settings.
	/// </summary>
	/// <param name="restClient"></param>
	/// <param name="verifyDomainPerformanceMonitor"></param>
	/// <param name="verifyEmailPerformanceMonitor"></param>
	/// <param name="lookupClient">DNS Lookup client</param>
	/// <param name="settings">Settings for the Client</param>
	internal KickboxClient(IKickboxRestClient restClient, IKickboxVerifyDomainPerformanceMonitor verifyDomainPerformanceMonitor, IKickboxVerifyEmailPerformanceMonitor verifyEmailPerformanceMonitor, ILookupClient lookupClient, IKickboxSettings settings)
	{
		_RestClient = restClient ?? throw new ArgumentNullException("restClient");
		_VerifyDomainPerformanceMonitor = verifyDomainPerformanceMonitor ?? throw new ArgumentNullException("verifyDomainPerformanceMonitor");
		if (verifyEmailPerformanceMonitor == null)
		{
			throw new ArgumentNullException("verifyEmailPerformanceMonitor");
		}
		_VerifyEmailPerformanceMonitor = new Lazy<IKickboxVerifyEmailPerformanceMonitor>(() => verifyEmailPerformanceMonitor);
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_DnsLookupClient = lookupClient;
		_RedisClient = RedisLruClient.GetInstance();
	}

	/// <summary>
	/// Checks the domain against Kickbox's Free Domain Checker 
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public IKickboxVerifyDomainResult VerifyDomain(IKickboxVerifyDomainRequest request)
	{
		bool isDisposable = false;
		string validDomainKey = GetSafeDomainKey(request.Domain);
		if (!_RedisClient.Execute(validDomainKey, (IDatabase r) => r.KeyExists(validDomainKey)))
		{
			string disposableDomainKey = GetDisposableDomainKey(request.Domain);
			if (_RedisClient.Execute(disposableDomainKey, (IDatabase r) => r.KeyExists(disposableDomainKey)))
			{
				isDisposable = true;
			}
			else if (!IsEmailDomainValid(request.Domain))
			{
				_RedisClient.Execute(disposableDomainKey, (IDatabase r) => r.StringSet(disposableDomainKey, true));
				isDisposable = true;
			}
			else
			{
				bool? isDisposableDomain = IsDisposableDomainImpl(request);
				if (isDisposableDomain.HasValue)
				{
					if (isDisposableDomain.Value)
					{
						_RedisClient.Execute(disposableDomainKey, (IDatabase r) => r.StringSet(disposableDomainKey, true));
						isDisposable = true;
					}
					else
					{
						_RedisClient.Execute(validDomainKey, (IDatabase r) => r.StringSet(validDomainKey, true));
					}
				}
			}
		}
		return new KickboxVerifyDomainResult
		{
			Disposable = isDisposable
		};
	}

	/// <summary>
	/// Checks the domain against Kickbox's Free Domain Checker 
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	private bool? IsDisposableDomainImpl(IKickboxVerifyDomainRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Stopwatch watch = new Stopwatch();
		VerifyDomainResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<VerifyDomainResponseData>(_Settings.KickboxDisposableApiUri + request.Domain, Roblox.RestClientBase.RestClientBase.HttpMethod.Get);
			watch.Stop();
			_VerifyDomainPerformanceMonitor.Increment(watch.Elapsed);
		}
		catch (Exception ex)
		{
			watch.Stop();
			_VerifyDomainPerformanceMonitor.IncrementException(request, watch.Elapsed, ex);
			if (ex is ApiClientException)
			{
				throw new KickboxException("Kickbox is unavailable: " + (ex as ApiClientException).StatusDescription, ex);
			}
			throw new KickboxException("Kickbox is unavailable: " + ex.Message, ex);
		}
		return responseData?.Disposable;
	}

	/// <summary>
	/// Check the validatity of an email address.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Kickbox.IKickboxVerifyEmailRequest" /> containing the required parameters for Kickbox</param>
	/// <returns>An <see cref="T:Roblox.Kickbox.IKickboxVerifyEmailResult" /> containing the results for both age categories</returns>
	/// <exception cref="T:Roblox.Kickbox.KickboxException"></exception>
	public IKickboxVerifyEmailResult VerifyEmail(IKickboxVerifyEmailRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Email))
		{
			return new KickboxVerifyEmailResult
			{
				Success = false,
				Status = "invalid"
			};
		}
		Dictionary<string, object> kvps = new Dictionary<string, object>
		{
			{ "email", request.Email },
			{ "apikey", _Settings.KickboxApiKey }
		};
		string errorDescription = "";
		Stopwatch watch = new Stopwatch();
		VerifyEmailResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<VerifyEmailResponseData>(_Settings.KickboxUri, Roblox.RestClientBase.RestClientBase.HttpMethod.Get, kvps);
			watch.Stop();
			_VerifyEmailPerformanceMonitor.Value.Increment(watch.Elapsed);
			if (responseData.Success)
			{
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsSuccess();
			}
			if (responseData.AcceptAll)
			{
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsAcceptAllEmail();
			}
			if (responseData.Role)
			{
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsRoleAddressEmail();
				errorDescription = "This kind of email cannot be used. Please choose another.";
			}
			if (responseData.Disposable)
			{
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsDisposableEmail();
				errorDescription = "The email domain cannot be used. Please choose another.";
			}
			switch (responseData.Result)
			{
			case "invalid_email":
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsInvalidEmailFormat();
				errorDescription = "The email is not valid. Please choose another.";
				break;
			case "invalid_domain":
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsInvalidEmailDomain();
				errorDescription = "The email domain is not valid. Please choose another.";
				break;
			case "low_quality":
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsLowQualityEmail();
				break;
			case "rejected_email":
				_VerifyEmailPerformanceMonitor.Value.IncrementResponseIsRejectedEmail();
				errorDescription = "The email could not be found. Please choose another.";
				break;
			}
		}
		catch (ApiClientException ex)
		{
			watch.Stop();
			_VerifyEmailPerformanceMonitor.Value.IncrementException(request, watch.Elapsed, ex);
			throw new KickboxException("Kickbox is unavailable: " + ex.StatusDescription, ex);
		}
		bool success = responseData.Success && responseData.Result != "undeliverable" && !responseData.Disposable && !responseData.Role;
		if (success && !request.AcceptAll && responseData.AcceptAll)
		{
			success = false;
		}
		return new KickboxVerifyEmailResult
		{
			Status = (success ? "valid" : "invalid"),
			Error = errorDescription,
			Result = responseData.Result,
			Reason = responseData.Reason,
			Role = responseData.Role,
			Free = responseData.Free,
			Disposable = responseData.Disposable,
			AcceptAll = responseData.AcceptAll,
			DidYouMean = responseData.DidYouMean,
			Sendex = responseData.Sendex,
			Email = responseData.Email,
			User = responseData.User,
			Domain = responseData.Domain,
			Success = responseData.Success,
			Message = responseData.Message
		};
	}

	private bool IsEmailDomainValid(string host)
	{
		if (string.IsNullOrEmpty(host))
		{
			return false;
		}
		IDnsQueryResponse dnsQuery = _DnsLookupClient.Query(host, QueryType.MX);
		if (dnsQuery?.Answers == null || dnsQuery.Answers.Count == 0)
		{
			return false;
		}
		if (dnsQuery.Answers.Count == 1)
		{
			MxRecord mxEntry = dnsQuery.Answers.MxRecords().First();
			return mxEntry.Preference != 0 || (!string.IsNullOrWhiteSpace(mxEntry.Exchange.Value) && !mxEntry.Exchange.Value.Equals("."));
		}
		return true;
	}

	private string GetSafeDomainKey(string domain)
	{
		return $"{SafeDomainCachePrefix}:{domain}";
	}

	private string GetDisposableDomainKey(string domain)
	{
		return $"{DisposableDomainCachePrefix}:{domain}";
	}
}
