using System;
using System.Collections.Generic;
using System.Text;

namespace Roblox.Http.Client;

public class HttpRequestBuilder : IHttpRequestBuilder
{
	private readonly IHttpRequestBuilderSettings _HttpRequestBuilderSettings;

	public HttpRequestBuilder(string endpoint)
		: this(new HttpRequestBuilderSettings(endpoint))
	{
	}

	public HttpRequestBuilder(IHttpRequestBuilderSettings httpRequestBuilderSettings)
	{
		_HttpRequestBuilderSettings = httpRequestBuilderSettings ?? throw new ArgumentNullException("httpRequestBuilderSettings");
	}

	public IHttpRequest BuildRequest(HttpMethod httpMethod, string path, IEnumerable<(string Key, string Value)> queryStringParameters = null)
	{
		ValidatePath(path);
		return CreateRequest(httpMethod, path, queryStringParameters);
	}

	public IHttpRequest BuildRequestWithJsonBody<TRequest>(HttpMethod httpMethod, string path, TRequest requestData, IEnumerable<(string Key, string Value)> queryStringParameters = null)
	{
		ValidatePath(path);
		ValidateRequestData(requestData);
		IHttpRequest httpRequest = CreateRequest(httpMethod, path, queryStringParameters);
		httpRequest.SetJsonRequestBody(requestData);
		return httpRequest;
	}

	private IHttpRequest CreateRequest(HttpMethod httpMethod, string path, IEnumerable<(string Key, string Value)> queryStringParameters)
	{
		UriBuilder uriBuilder = CreateUriBuilder(path, queryStringParameters);
		return new HttpRequest(httpMethod, uriBuilder.Uri);
	}

	private UriBuilder CreateUriBuilder(string path, IEnumerable<(string Key, string Value)> queryStringParameters)
	{
		UriBuilder uriBuilder = new UriBuilder(_HttpRequestBuilderSettings.Endpoint)
		{
			Path = path
		};
		if (queryStringParameters != null)
		{
			uriBuilder.Query = BuildQueryString(queryStringParameters);
		}
		return uriBuilder;
	}

	private string BuildQueryString(IEnumerable<(string Key, string Value)> queryStringParameters)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (var queryStringParameter in queryStringParameters)
		{
			if (string.IsNullOrWhiteSpace(queryStringParameter.Key))
			{
				throw new ArgumentException("Query string parameter key cannot be null or whitespace", "queryStringParameters");
			}
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append("&");
			}
			string text = queryStringParameter.Value ?? string.Empty;
			if (_HttpRequestBuilderSettings.EncodeQueryParametersEnabled)
			{
				stringBuilder.Append(Uri.EscapeDataString(queryStringParameter.Key));
				stringBuilder.Append("=");
				stringBuilder.Append(Uri.EscapeDataString(text));
			}
			else
			{
				stringBuilder.Append(queryStringParameter.Key);
				stringBuilder.Append("=");
				stringBuilder.Append(text);
			}
		}
		return stringBuilder.ToString();
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
