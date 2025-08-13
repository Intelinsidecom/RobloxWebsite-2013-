using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Http.Client;

public class HttpRequestSender : IHttpRequestSender
{
	private readonly IHttpClient _HttpClient;

	private readonly IHttpRequestBuilder _HttpRequestBuilder;

	public HttpRequestSender(IHttpClient httpClient, IHttpRequestBuilder httpRequestBuilder)
	{
		_HttpClient = httpClient ?? throw new ArgumentNullException("httpClient");
		_HttpRequestBuilder = httpRequestBuilder ?? throw new ArgumentNullException("httpRequestBuilder");
	}

	public void SendRequest(HttpMethod httpMethod, string path, IEnumerable<(string Key, string Value)> queryStringParameters = null)
	{
		ValidatePath(path);
		IHttpRequest request = _HttpRequestBuilder.BuildRequest(httpMethod, path, queryStringParameters);
		_HttpClient.Send(request);
	}

	public Task SendRequestAsync(HttpMethod httpMethod, string path, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null)
	{
		ValidatePath(path);
		IHttpRequest request = _HttpRequestBuilder.BuildRequest(httpMethod, path, queryStringParameters);
		return _HttpClient.SendAsync(request, cancellationToken);
	}

	public TResponse SendRequest<TResponse>(HttpMethod httpMethod, string path, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class
	{
		ValidatePath(path);
		IHttpRequest request = _HttpRequestBuilder.BuildRequest(httpMethod, path, queryStringParameters);
		return _HttpClient.Send(request).GetJsonBody<TResponse>();
	}

	public async Task<TResponse> SendRequestAsync<TResponse>(HttpMethod httpMethod, string path, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class
	{
		ValidatePath(path);
		IHttpRequest request = _HttpRequestBuilder.BuildRequest(httpMethod, path, queryStringParameters);
		return (await _HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).GetJsonBody<TResponse>();
	}

	public void SendRequestWithJsonBody<TRequest>(HttpMethod httpMethod, string path, TRequest requestData, IEnumerable<(string Key, string Value)> queryStringParameters = null)
	{
		ValidatePath(path);
		ValidateRequestData(requestData);
		IHttpRequest request = _HttpRequestBuilder.BuildRequestWithJsonBody(httpMethod, path, requestData, queryStringParameters);
		_HttpClient.Send(request);
	}

	public Task SendRequestWithJsonBodyAsync<TRequest>(HttpMethod httpMethod, string path, TRequest requestData, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null)
	{
		ValidatePath(path);
		ValidateRequestData(requestData);
		IHttpRequest request = _HttpRequestBuilder.BuildRequestWithJsonBody(httpMethod, path, requestData, queryStringParameters);
		return _HttpClient.SendAsync(request, cancellationToken);
	}

	public TResponse SendRequestWithJsonBody<TRequest, TResponse>(HttpMethod httpMethod, string path, TRequest requestData, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class
	{
		ValidatePath(path);
		ValidateRequestData(requestData);
		IHttpRequest request = _HttpRequestBuilder.BuildRequestWithJsonBody(httpMethod, path, requestData, queryStringParameters);
		return _HttpClient.Send(request).GetJsonBody<TResponse>();
	}

	public async Task<TResponse> SendRequestWithJsonBodyAsync<TRequest, TResponse>(HttpMethod httpMethod, string path, TRequest requestData, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class
	{
		ValidatePath(path);
		ValidateRequestData(requestData);
		IHttpRequest request = _HttpRequestBuilder.BuildRequestWithJsonBody(httpMethod, path, requestData, queryStringParameters);
		return (await _HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).GetJsonBody<TResponse>();
	}

	private void ValidatePath(string path)
	{
		if (string.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "path");
		}
	}

	private void ValidateRequestData<TRequest>(TRequest requestData)
	{
		if (requestData == null)
		{
			throw new ArgumentNullException("requestData");
		}
	}
}
