using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.Passwords.Client.Properties;
using Roblox.RequestContext;

namespace Roblox.Passwords.Client;

/// <summary>
/// Implementation for <see cref="T:Roblox.Passwords.Client.IPasswordsClient" />
/// </summary>
public class PasswordsClient : IPasswordsClient
{
	private readonly IServiceRequestSender _ServiceRequestSender;

	/// <summary>
	/// Construct a new instance of <see cref="T:Roblox.Passwords.Client.PasswordsClient" />
	/// </summary>
	/// <param name="counterRegistry">The <see cref="T:Roblox.Instrumentation.ICounterRegistry" /></param>
	/// <param name="apiKeyGetter">The api key getter/</param>
	/// <param name="requestContextLoader">The <see cref="T:Roblox.RequestContext.IRequestContextLoader" /></param>
	public PasswordsClient(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader = null)
		: this(CreateHttpClientBuilder(counterRegistry, apiKeyGetter, requestContextLoader), Settings.Default)
	{
	}

	/// <summary>
	/// Construct a new instance of <see cref="T:Roblox.Passwords.Client.PasswordsClient" />
	/// </summary>
	/// <param name="httpClientBuilder">The <see cref="T:Roblox.Http.Client.IHttpClientBuilder" /></param>
	/// <param name="serviceClientSettings">The <see cref="T:Roblox.Http.ServiceClient.IServiceClientSettings" /></param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="httpClientBuilder" /> cannot be null.
	/// - <paramref name="serviceClientSettings" /> cannot be null.
	/// </exception>
	public PasswordsClient(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings)
	{
		if (httpClientBuilder == null)
		{
			throw new ArgumentNullException("httpClientBuilder");
		}
		if (serviceClientSettings == null)
		{
			throw new ArgumentNullException("serviceClientSettings");
		}
		_ServiceRequestSender = new ServiceRequestSender(httpClientBuilder.Build(), new HttpRequestBuilder(serviceClientSettings.Endpoint));
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.SetPassword(Roblox.Passwords.Client.PasswordOwnerType,System.Int64,System.String)" />
	public SetPasswordResult SetPassword(PasswordOwnerType passwordOwner, long passwordOwnerId, string password)
	{
		SetPasswordRequest request = new SetPasswordRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId,
			Password = password
		};
		return _ServiceRequestSender.SendPostRequest<SetPasswordRequest, SetPasswordResult>("/v1/SetPassword", request);
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.SetPasswordAsync(Roblox.Passwords.Client.PasswordOwnerType,System.Int64,System.String,System.Threading.CancellationToken)" />
	public async Task<SetPasswordResult> SetPasswordAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, string password, CancellationToken cancellationToken)
	{
		SetPasswordRequest request = new SetPasswordRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId,
			Password = password
		};
		return await _ServiceRequestSender.SendPostRequestAsync<SetPasswordRequest, SetPasswordResult>("/v1/SetPassword", request, cancellationToken);
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.VerifyPassword(Roblox.Passwords.Client.PasswordOwnerType,System.Int64,System.String)" />
	public VerifyPasswordResult VerifyPassword(PasswordOwnerType passwordOwner, long passwordOwnerId, string password)
	{
		VerifyPasswordRequest request = new VerifyPasswordRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId,
			Password = password
		};
		return _ServiceRequestSender.SendPostRequest<VerifyPasswordRequest, VerifyPasswordResult>("/v1/VerifyPassword", request);
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.VerifyPasswordAsync(Roblox.Passwords.Client.PasswordOwnerType,System.Int64,System.String,System.Threading.CancellationToken)" />
	public async Task<VerifyPasswordResult> VerifyPasswordAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, string password, CancellationToken cancellationToken)
	{
		VerifyPasswordRequest request = new VerifyPasswordRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId,
			Password = password
		};
		return await _ServiceRequestSender.SendPostRequestAsync<VerifyPasswordRequest, VerifyPasswordResult>("/v1/VerifyPassword", request, cancellationToken);
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.GetPasswordStatus(Roblox.Passwords.Client.PasswordOwnerType,System.Int64)" />
	public PasswordStatusResult GetPasswordStatus(PasswordOwnerType passwordOwner, long passwordOwnerId)
	{
		GetPasswordStatusRequest request = new GetPasswordStatusRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId
		};
		return _ServiceRequestSender.SendPostRequest<GetPasswordStatusRequest, PasswordStatusResult>("/v1/GetPasswordStatus", request);
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.GetPasswordStatusAsync(Roblox.Passwords.Client.PasswordOwnerType,System.Int64,System.Threading.CancellationToken)" />
	public async Task<PasswordStatusResult> GetPasswordStatusAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, CancellationToken cancellationToken)
	{
		GetPasswordStatusRequest request = new GetPasswordStatusRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId
		};
		return await _ServiceRequestSender.SendPostRequestAsync<GetPasswordStatusRequest, PasswordStatusResult>("/v1/GetPasswordStatus", request, cancellationToken);
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.SetPasswordResetRequired(Roblox.Passwords.Client.PasswordOwnerType,System.Int64,System.Boolean)" />
	public SetPasswordResetRequiredResult SetPasswordResetRequired(PasswordOwnerType passwordOwner, long passwordOwnerId, bool needsReset)
	{
		SetPasswordResetRequiredRequest request = new SetPasswordResetRequiredRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId,
			NeedsReset = needsReset
		};
		return _ServiceRequestSender.SendPostRequest<SetPasswordResetRequiredRequest, SetPasswordResetRequiredResult>("/v1/SetPasswordResetRequired", request);
	}

	/// <inheritdoc cref="M:Roblox.Passwords.Client.IPasswordsClient.SetPasswordResetRequiredAsync(Roblox.Passwords.Client.PasswordOwnerType,System.Int64,System.Boolean,System.Threading.CancellationToken)" />
	public async Task<SetPasswordResetRequiredResult> SetPasswordResetRequiredAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, bool needsReset, CancellationToken cancellationToken)
	{
		SetPasswordResetRequiredRequest request = new SetPasswordResetRequiredRequest
		{
			PasswordOwnerType = passwordOwner,
			PasswordOwnerId = passwordOwnerId,
			NeedsReset = needsReset
		};
		return await _ServiceRequestSender.SendPostRequestAsync<SetPasswordResetRequiredRequest, SetPasswordResetRequiredResult>("/v1/SetPasswordResetRequired", request, cancellationToken);
	}

	private static ClientCircuitBreakerType GetClientCircuitBreakerType()
	{
		if (!Settings.Default.PerEndpointCircuitBreakerEnabled)
		{
			return (ClientCircuitBreakerType)1;
		}
		return (ClientCircuitBreakerType)2;
	}

	private static bool ApiKeyViaHeaderEnabled()
	{
		return Settings.Default.ApiKeyViaHeaderEnabled;
	}

	private static IHttpClientBuilder CreateHttpClientBuilder(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader)
	{
		return new Roblox.Http.ServiceClient.HttpClientBuilder((IServiceClientSettings)Settings.Default, counterRegistry, apiKeyGetter, (Func<bool>)null, (CookieContainer)null, requestContextLoader, (IHttpMessageHandlerBuilder)null)
		{
			ApiKeyViaHeaderEnabled = ApiKeyViaHeaderEnabled,
			GetClientCircuitBreakerType = GetClientCircuitBreakerType
		};
	}
}
