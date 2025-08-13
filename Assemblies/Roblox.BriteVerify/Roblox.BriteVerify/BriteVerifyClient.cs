using System;
using System.Collections.Generic;
using System.Diagnostics;
using Roblox.BriteVerify.Properties;
using Roblox.RestClientBase;

namespace Roblox.BriteVerify;

/// <summary>
/// BriteVerify Client
/// </summary>
public class BriteVerifyClient : IBriteVerifyClient
{
	private readonly IBriteVerifyRestClient _RestClient;

	private readonly IBriteVerifyPerformanceMonitor _PerformanceMonitor;

	private readonly IBriteVerifySettings _Settings;

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="apiName">Name of the parent service making these called. Used for logging.</param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	public BriteVerifyClient(string apiName = "BriteVerify API")
	{
		_RestClient = new BriteVerifyRestClient();
		_PerformanceMonitor = new BriteVerifyPerformanceMonitor(apiName, Settings.Default);
		_Settings = Settings.Default;
	}

	/// <summary>
	/// Internal test constructor allows us to fake the restClient, performanceMonitor, and settings.
	/// </summary>
	/// <param name="restClient"></param>
	/// <param name="performanceMonitor"></param>
	/// <param name="settings">Settings for the Client</param>
	internal BriteVerifyClient(IBriteVerifyRestClient restClient, IBriteVerifyPerformanceMonitor performanceMonitor, IBriteVerifySettings settings)
	{
		_RestClient = restClient ?? throw new ArgumentNullException("restClient");
		_PerformanceMonitor = performanceMonitor ?? throw new ArgumentNullException("performanceMonitor");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <summary>
	/// Check the validatity of an email address.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.BriteVerify.IBriteVerifyEmailRequest" /> containing the required parameters for BriteVerify</param>
	/// <returns>An <see cref="T:Roblox.BriteVerify.IBriteVerifyEmailResult" /> containing the results for both age categories</returns>
	/// <exception cref="T:Roblox.BriteVerify.BriteVerifyException"></exception>
	public IBriteVerifyEmailResult VerifyEmail(IBriteVerifyEmailRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Email))
		{
			return new BriteVerifyEmailResult
			{
				ErrorCode = "email_account_invalid",
				Status = "invalid"
			};
		}
		Dictionary<string, object> kvps = new Dictionary<string, object>
		{
			{ "address", request.Email },
			{ "apikey", _Settings.BriteVerifyApiKey }
		};
		string status = "invalid";
		string errorDescription = "";
		Stopwatch watch = new Stopwatch();
		BriteVerifyEmailResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<BriteVerifyEmailResponseData>(_Settings.BriteVerifyUri, Roblox.RestClientBase.RestClientBase.HttpMethod.Get, kvps);
			watch.Stop();
			_PerformanceMonitor.Increment(watch.Elapsed);
			if (!string.IsNullOrEmpty(responseData?.Status))
			{
				status = responseData.Status.ToLowerInvariant();
			}
			if (!string.IsNullOrEmpty(responseData?.Error))
			{
				errorDescription = responseData.Error;
			}
			switch (status)
			{
			case "valid":
				_PerformanceMonitor.IncrementResponseIsValidEmail();
				break;
			case "invalid":
				errorDescription = "The email is not valid. Please choose another.";
				_PerformanceMonitor.IncrementResponseIsInvalidEmail();
				break;
			case "unknown":
				status = "invalid";
				_PerformanceMonitor.IncrementResponseIsUnknownEmail();
				break;
			case "accept_all":
				_PerformanceMonitor.IncrementResponseIsAcceptAllEmail();
				status = ((!request.AcceptAll) ? "invalid" : "valid");
				break;
			default:
				_PerformanceMonitor.IncrementResponseCannotValidate();
				break;
			}
			if (!string.IsNullOrEmpty(responseData?.ErrorCode))
			{
				switch (responseData.ErrorCode)
				{
				case "email_address_invalid":
					_PerformanceMonitor.IncrementResponseIsInvalidEmailFormat();
					break;
				case "email_domain_invalid":
					_PerformanceMonitor.IncrementResponseIsInvalidEmailDomain();
					break;
				case "email_account_invalid":
					_PerformanceMonitor.IncrementResponseIsInvalidEmailAccount();
					break;
				}
			}
			if (responseData.IsDisposable)
			{
				_PerformanceMonitor.IncrementResponseIsDisposableEmail();
				status = "invalid";
				errorDescription = "The email domain cannot be used. Please choose another.";
			}
			if (responseData.IsRoleAddress)
			{
				_PerformanceMonitor.IncrementResponseIsRoleAddressEmail();
				status = "invalid";
				errorDescription = "This kind of email cannot be used. Please choose another.";
			}
		}
		catch (ApiClientException ex)
		{
			watch.Stop();
			_PerformanceMonitor.IncrementException(request, watch.Elapsed, ex);
			throw new BriteVerifyException("BriteVerify is unavailable: " + ex.StatusDescription, ex);
		}
		return new BriteVerifyEmailResult
		{
			Address = responseData.Address,
			Account = responseData.Account,
			Domain = responseData.Domain,
			Status = status,
			Connected = responseData.Connected,
			IsDisposable = responseData.IsDisposable,
			IsRoleAddress = responseData.IsRoleAddress,
			ErrorCode = responseData.ErrorCode,
			Error = errorDescription,
			Duration = responseData.Duration
		};
	}
}
