using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Pipeline;

namespace Roblox.Http.Client;

public class SendHttpRequestHandler : PipelineHandler<IHttpRequest, IHttpResponse>, IDisposable
{
	private const string _UserAgentHeaderName = "User-Agent";

	private const string _UnexpectedErrorMessage = "An unexpected error occurred while processing the Http request. Check inner exception.";

	private const string _OperationTimeoutMessage = "The operation has timed out";

	private static readonly ByteArrayContent _EmptyContent = new ByteArrayContent(new byte[0]);

	private readonly CookieContainer _CookieContainer;

	private readonly IHttpClientSettings _HttpClientSettings;

	private System.Net.Http.HttpClient _HttpClient;

	internal bool IsDisposed;

	public SendHttpRequestHandler(CookieContainer cookieContainer, IHttpClientSettings httpClientSettings)
	{
		_CookieContainer = cookieContainer ?? throw new ArgumentNullException("cookieContainer");
		_HttpClientSettings = httpClientSettings ?? throw new ArgumentNullException("httpClientSettings");
		httpClientSettings.SettingChanged += RefreshHttpClient;
		RefreshHttpClient(null);
	}

	public override void Invoke(IExecutionContext<IHttpRequest, IHttpResponse> context)
	{
		try
		{
			using HttpWebResponse httpWebResponse = (HttpWebResponse)BuildHttpWebRequest(context.Input).GetResponse();
			context.Output = BuildHttpResponse(httpWebResponse);
		}
		catch (WebException ex)
		{
			if (!(ex.Response is HttpWebResponse httpWebResponse2))
			{
				throw new HttpException("An unexpected error occurred while processing the Http request. Check inner exception.", ex);
			}
			context.Output = BuildHttpResponse(httpWebResponse2);
		}
		base.Invoke(context);
	}

	public override async Task InvokeAsync(IExecutionContext<IHttpRequest, IHttpResponse> context, CancellationToken cancellationToken)
	{
		try
		{
			HttpRequestMessage requestMessage = BuildHttpRequestMessage(context.Input);
			context.Output = await BuildHttpResponseAsync(await SendAsync(_HttpClient, requestMessage, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (TaskCanceledException innerException)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				throw new HttpException("The operation has timed out", new WebException("The operation has timed out", innerException, WebExceptionStatus.Timeout, null));
			}
			throw;
		}
		catch (HttpRequestException innerException2)
		{
			throw new HttpException("An unexpected error occurred while processing the Http request. Check inner exception.", innerException2);
		}
		await base.InvokeAsync(context, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	internal HttpWebRequest BuildHttpWebRequest(IHttpRequest request)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(request.Url);
		httpWebRequest.Method = request.Method.ToString();
		httpWebRequest.CookieContainer = _CookieContainer;
		httpWebRequest.UserAgent = _HttpClientSettings.UserAgent;
		httpWebRequest.AllowAutoRedirect = _HttpClientSettings.MaxRedirects > 0;
		if (_HttpClientSettings.RequestTimeout > TimeSpan.Zero)
		{
			httpWebRequest.Timeout = (int)Math.Ceiling(_HttpClientSettings.RequestTimeout.TotalMilliseconds);
		}
		if (httpWebRequest.AllowAutoRedirect)
		{
			httpWebRequest.MaximumAutomaticRedirections = _HttpClientSettings.MaxRedirects;
		}
		foreach (string key in request.Headers.Keys)
		{
			foreach (string item in request.Headers.Get(key))
			{
				if (key == "Accept")
				{
					httpWebRequest.Accept = item;
				}
				else
				{
					httpWebRequest.Headers.Add(key, item);
				}
			}
		}
		HttpContent httpContent = null;
		if (request.Body != null)
		{
			httpWebRequest.ContentType = request.Headers.ContentType;
			httpContent = request.Body;
		}
		else if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put || request.Method == HttpMethod.Patch)
		{
			httpContent = _EmptyContent;
		}
		if (httpContent != null)
		{
			using Stream stream = httpWebRequest.GetRequestStream();
			httpContent.CopyToAsync(stream).Wait();
		}
		return httpWebRequest;
	}

	internal HttpRequestMessage BuildHttpRequestMessage(IHttpRequest request)
	{
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new System.Net.Http.HttpMethod(request.Method.ToString().ToUpper()), request.Url);
		if (request.Body != null)
		{
			httpRequestMessage.Content = request.Body;
			if (!string.IsNullOrWhiteSpace(request.Headers.ContentType))
			{
				httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue(request.Headers.ContentType);
			}
		}
		else if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put || request.Method == HttpMethod.Patch)
		{
			httpRequestMessage.Content = _EmptyContent;
		}
		foreach (string key in request.Headers.Keys)
		{
			httpRequestMessage.Headers.Add(key, request.Headers.Get(key));
		}
		if (!request.Headers.Keys.Contains("User-Agent") && !string.IsNullOrWhiteSpace(_HttpClientSettings.UserAgent))
		{
			httpRequestMessage.Headers.Add("User-Agent", _HttpClientSettings.UserAgent);
		}
		return httpRequestMessage;
	}

	internal async Task<IHttpResponse> BuildHttpResponseAsync(HttpResponseMessage responseMessage)
	{
		HttpResponse httpResponse = new HttpResponse
		{
			StatusCode = responseMessage.StatusCode,
			StatusText = responseMessage.ReasonPhrase,
			Headers = new HttpResponseHeaders(responseMessage),
			Url = responseMessage.RequestMessage.RequestUri
		};
		HttpResponse httpResponse2 = httpResponse;
		httpResponse2.Body = await responseMessage.Content.ReadAsByteArrayAsync().ConfigureAwait(continueOnCapturedContext: false);
		return httpResponse;
	}

	internal IHttpResponse BuildHttpResponse(HttpWebResponse httpWebResponse)
	{
		byte[] body = new byte[0];
		using (Stream stream = httpWebResponse.GetResponseStream())
		{
			if (stream != null)
			{
				using MemoryStream memoryStream = new MemoryStream();
				stream.CopyTo(memoryStream);
				body = memoryStream.ToArray();
			}
		}
		HttpResponseHeaders httpResponseHeaders = new HttpResponseHeaders();
		string[] allKeys = httpWebResponse.Headers.AllKeys;
		foreach (string name in allKeys)
		{
			string[] values = httpWebResponse.Headers.GetValues(name);
			if (values != null)
			{
				string[] array = values;
				foreach (string value in array)
				{
					httpResponseHeaders.Add(name, value);
				}
			}
		}
		httpResponseHeaders.ContentType = httpWebResponse.ContentType;
		return new HttpResponse
		{
			StatusCode = httpWebResponse.StatusCode,
			StatusText = httpWebResponse.StatusDescription,
			Headers = httpResponseHeaders,
			Url = httpWebResponse.ResponseUri,
			Body = body
		};
	}

	[ExcludeFromCodeCoverage]
	internal virtual async Task<HttpResponseMessage> SendAsync(System.Net.Http.HttpClient httpClient, HttpRequestMessage requestMessage, CancellationToken cancellationToken)
	{
		return await httpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	internal void RefreshHttpClient(string changedPropertyName)
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		httpClientHandler.CookieContainer = _CookieContainer;
		httpClientHandler.AllowAutoRedirect = _HttpClientSettings.MaxRedirects > 0;
		if (httpClientHandler.AllowAutoRedirect)
		{
			httpClientHandler.MaxAutomaticRedirections = _HttpClientSettings.MaxRedirects;
		}
		System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(httpClientHandler);
		if (_HttpClientSettings.RequestTimeout > TimeSpan.Zero)
		{
			httpClient.Timeout = _HttpClientSettings.RequestTimeout;
		}
		_HttpClient = httpClient;
	}

	[ExcludeFromCodeCoverage]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[ExcludeFromCodeCoverage]
	protected virtual void Dispose(bool disposing)
	{
		if (!IsDisposed)
		{
			if (disposing)
			{
				_HttpClient?.Dispose();
			}
			IsDisposed = true;
		}
	}
}
