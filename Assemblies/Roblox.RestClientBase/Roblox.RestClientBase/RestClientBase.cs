using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Roblox.RestClientBase.Properties;

namespace Roblox.RestClientBase;

public abstract class RestClientBase
{
	public enum HttpMethod
	{
		Get,
		Post,
		Put,
		Delete
	}

	private static readonly TimeSpan _DefaultTimeout = Settings.Default.DefaultWebClientTimeoutInterval;

	private static readonly Encoding _Utf8Encoder = Encoding.GetEncoding("UTF-8", new EncoderReplacementFallback(string.Empty), new DecoderExceptionFallback());

	private long _RequestCounter;

	/// <summary>
	/// Property for setting up base service end point.
	/// </summary>
	protected abstract string Endpoint { get; }

	/// <summary>
	/// Property for setting up default time out.
	/// </summary>
	protected virtual TimeSpan Timeout => _DefaultTimeout;

	/// <summary>
	/// Property for setting up client name.
	/// </summary>
	public abstract string Name { get; }

	public virtual event Action<long, string, HttpStatusCode?, string> RequestFailed;

	public virtual event Action<long, string> RequestFinished;

	public virtual event Action<long, string> RequestStarted;

	public virtual event Action<long, string> RequestSucceeded;

	/// <summary>
	/// UTF8 encodes and escapes the given string.
	///
	/// This is to ensure that only encodable text (by UTF8) will be parsed. 
	/// If the text contains unpaired surrogates (i.e. invalid UTF16), 
	/// it will throw a TextEncoderFallbackException but this solution should handle it.
	/// </summary>
	/// <param name="stringToProcess">The string to process.</param>
	/// <returns>Escaped and UTF8 encoded string.</returns>
	protected static string EncodeAndEscape(string stringToProcess)
	{
		return Uri.EscapeDataString(_Utf8Encoder.GetString(_Utf8Encoder.GetBytes(stringToProcess)));
	}

	/// <summary>
	/// Appends the escaped URI data string.
	/// </summary>
	/// <param name="sb">The sb.</param>
	/// <param name="stringToEscape">The string to escape.</param>
	protected static void AppendEscapedUriDataString(StringBuilder sb, string stringToEscape)
	{
		if (stringToEscape.Length < 32000)
		{
			string escapeDataString = EncodeAndEscape(stringToEscape);
			sb.Append(escapeDataString);
			return;
		}
		int loops = stringToEscape.Length / 32000;
		for (int i = 0; i <= loops; i++)
		{
			if (i < loops)
			{
				sb.Append(EncodeAndEscape(stringToEscape.Substring(32000 * i, 32000)));
			}
			else
			{
				sb.Append(EncodeAndEscape(stringToEscape.Substring(32000 * i)));
			}
		}
	}

	/// <summary>
	/// Converts Body Post data into a string that can be sent in an HTTP request.
	/// This base method turns the given data into a JSON string.
	/// Override this if you have some other type of data needs
	/// </summary>
	/// <param name="bodyData">The body data to convert.</param>
	/// <returns></returns>
	protected virtual string SerializeSendData(object bodyData)
	{
		return JsonConvert.SerializeObject(bodyData, Formatting.None, new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		});
	}

	/// <summary>
	/// Converts the response data into whatever type the calling code desires.
	/// This base method assumes the return data is in JSON format and deserialize it.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="responseString">The response string.</param>
	/// <returns></returns>
	protected virtual T DeserializeResponseData<T>(string responseString)
	{
		return JsonConvert.DeserializeObject<T>(responseString);
	}

	/// <summary>
	/// Builds and returns full uri including query string parameters.
	/// </summary>
	/// <param name="actionPath">Action name to be executed</param>
	/// <param name="queryStringParameters">Query string parameter</param>
	/// <returns>Complete URI with action name and query string parameters.</returns>
	protected virtual string BuildUri(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters)
	{
		string uri = Endpoint + actionPath;
		if (queryStringParameters == null)
		{
			return uri;
		}
		StringBuilder queryStringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, object> kvp in queryStringParameters)
		{
			object parameterValue = kvp.Value;
			string parameterKey = kvp.Key;
			string encodedValue = ((parameterValue != null) ? HttpUtility.UrlEncode(parameterValue.ToString()) : string.Empty);
			queryStringBuilder.Append(parameterKey);
			queryStringBuilder.Append('=');
			queryStringBuilder.Append(encodedValue);
			queryStringBuilder.Append("&");
		}
		string queryString = queryStringBuilder.ToString().TrimEnd(new char[1] { '&' });
		return uri + "?" + queryString;
	}

	/// <summary>
	/// Adds the given header key/value pairs into the WebCleint.
	/// </summary>
	/// <param name="method">The method being used (POST/GET/PUT/DELTE). Not used by this base method.</param>
	/// <param name="webClient">The web client.</param>
	/// <param name="headers">The headers.</param>
	protected virtual void BuildHeaders(HttpMethod method, WebClient webClient, IEnumerable<KeyValuePair<string, string>> headers)
	{
		if (headers == null)
		{
			return;
		}
		foreach (KeyValuePair<string, string> pair in headers)
		{
			webClient.Headers[pair.Key] = pair.Value;
		}
	}

	private void OnRequestFinished(long requestId, string actionPath)
	{
		if (this.RequestFinished != null)
		{
			this.RequestFinished(requestId, actionPath);
		}
	}

	private void OnRequestStarted(long requestId, string actionPath)
	{
		if (this.RequestStarted != null)
		{
			this.RequestStarted(requestId, actionPath);
		}
	}

	private void OnRequestSucceeded(long requestId, string actionPath)
	{
		if (this.RequestSucceeded != null)
		{
			this.RequestSucceeded(requestId, actionPath);
		}
	}

	private static string DoDelete(WebClient webClient, string requestUrl)
	{
		return webClient.UploadString(requestUrl, "DELETE", string.Empty);
	}

	private static async Task<string> DoDeleteAsync(WebClient webClient, string requestUrl, CancellationToken cancellationToken)
	{
		cancellationToken.Register(webClient.CancelAsync);
		return await webClient.UploadStringTaskAsync(requestUrl, "DELETE", string.Empty).ConfigureAwait(continueOnCapturedContext: false);
	}

	private static string DoGet(WebClient webClient, string requestUrl)
	{
		byte[] bytes = webClient.DownloadData(requestUrl);
		return Encoding.UTF8.GetString(bytes);
	}

	private static async Task<string> DoGetAsync(WebClient webClient, string requestUrl, CancellationToken cancellationToken)
	{
		cancellationToken.Register(webClient.CancelAsync);
		byte[] bytes = await webClient.DownloadDataTaskAsync(requestUrl).ConfigureAwait(continueOnCapturedContext: false);
		return Encoding.UTF8.GetString(bytes);
	}

	private static string DoPostOrPut(WebClient webClient, string httpMethod, string requestUrl, string bodyContent)
	{
		byte[] bytesToUpload = webClient.Encoding.GetBytes(bodyContent);
		byte[] bytesReceived = webClient.UploadData(requestUrl, httpMethod, bytesToUpload);
		return Encoding.UTF8.GetString(bytesReceived);
	}

	private static async Task<string> DoPostOrPutAsync(WebClient webClient, string httpMethod, string requestUrl, string bodyContent, CancellationToken cancellationToken)
	{
		byte[] bytesToUpload = webClient.Encoding.GetBytes(bodyContent);
		cancellationToken.Register(webClient.CancelAsync);
		byte[] bytesReceived = await webClient.UploadDataTaskAsync(requestUrl, httpMethod, bytesToUpload).ConfigureAwait(continueOnCapturedContext: false);
		return Encoding.UTF8.GetString(bytesReceived);
	}

	protected void HandleRequestFailedEvent(long requestId, string actionPath, HttpStatusCode? statusCode, string statusDescription)
	{
		if (this.RequestFailed != null)
		{
			this.RequestFailed(requestId, actionPath, statusCode, statusDescription);
		}
	}

	protected virtual void OnRequestStarting()
	{
	}

	protected virtual void OnRequestFailed(WebException ex, long requestId, string actionPath, HttpStatusCode? statusCode, string statusDescription)
	{
		HandleRequestFailedEvent(requestId, actionPath, statusCode, statusDescription);
		ThrowConvertedException(ex, actionPath, statusCode, statusDescription);
	}

	protected void ThrowConvertedException(WebException ex, string actionPath, HttpStatusCode? statusCode, string statusDescription)
	{
		string message = string.Format("ApiClient {0} exception:\r\nUrl = {1}\r\nStatusCode = {2}\r\nStatusDescription = {3}\r\n", Name, Endpoint + actionPath, statusCode.HasValue ? statusCode.Value.ToString() : "StatusCodeNotAvailable", statusDescription);
		if ((statusCode.HasValue && statusCode.Value == HttpStatusCode.TooManyRequests) || ex.Message.Contains("ProvisionedThroughputExceeded"))
		{
			throw new RequestThrottledException(Name, message, ex, statusCode, statusDescription);
		}
		throw new ApiClientException(Name, message, ex, statusCode, statusDescription);
	}

	protected static void GetHttpStatusCodeAndStatusDescription(WebException ex, out HttpStatusCode? httpStatusCode, out string statusDescription)
	{
		if (ex.Response is HttpWebResponse httpResponse)
		{
			httpStatusCode = httpResponse.StatusCode;
			statusDescription = httpResponse.StatusDescription;
		}
		else
		{
			httpStatusCode = null;
			statusDescription = ex.Status.ToString();
		}
	}

	/// <summary>
	/// Executes the HTTP request.
	/// </summary>
	/// <param name="actionPath">The uri.</param>
	/// <param name="method">The method (POST/GET/PUT/DELETE).</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="bodyString">The body string.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="specificEncoding">The <see cref="T:System.Text.Encoding" /> to be used for this request.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns>response string</returns>
	/// <exception cref="T:Roblox.RestClientBase.ApiClientException">Invalid HttpMethod:  + method</exception>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual string ExecuteHttpRequest(string actionPath, HttpMethod method, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, string bodyString = null, IEnumerable<KeyValuePair<string, string>> headers = null, Encoding specificEncoding = null, string recordActionPathAs = null)
	{
		string requestUrl = BuildUri(actionPath, queryStringParameters);
		string actionPerfmonInstanceName = recordActionPathAs ?? actionPath;
		using TimeoutWebClient webClient = new TimeoutWebClient(Timeout);
		if (specificEncoding != null)
		{
			webClient.Encoding = specificEncoding;
		}
		string responseString = string.Empty;
		long requestId = Interlocked.Increment(ref _RequestCounter);
		BuildHeaders(method, webClient, headers);
		try
		{
			OnRequestStarting();
			OnRequestStarted(requestId, actionPerfmonInstanceName);
			responseString = method switch
			{
				HttpMethod.Delete => DoDelete(webClient, requestUrl), 
				HttpMethod.Get => DoGet(webClient, requestUrl), 
				HttpMethod.Post => DoPostOrPut(webClient, "POST", requestUrl, bodyString), 
				HttpMethod.Put => DoPostOrPut(webClient, "PUT", requestUrl, bodyString), 
				_ => throw new ApiClientException(Name, "Invalid HttpMethod: " + method), 
			};
			OnRequestSucceeded(requestId, actionPerfmonInstanceName);
		}
		catch (WebException ex)
		{
			GetHttpStatusCodeAndStatusDescription(ex, out var httpStatusCode, out var statusDescription);
			OnRequestFailed(ex, requestId, actionPerfmonInstanceName, httpStatusCode, statusDescription);
		}
		finally
		{
			OnRequestFinished(requestId, actionPerfmonInstanceName);
		}
		return responseString;
	}

	/// <summary>
	/// Executes the HTTP request asynchronous.
	/// </summary>
	/// <param name="actionPath">The uri.</param>
	/// <param name="method">The method (POST/GET/PUT/DELETE).</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="bodyString">The body string.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="specificEncoding">The <see cref="T:System.Text.Encoding" /> to be used for this request.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns>response string</returns>
	/// <exception cref="T:Roblox.RestClientBase.ApiClientException">Invalid HttpMethod:  + method</exception>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual async Task<string> ExecuteHttpRequestAsync(string actionPath, HttpMethod method, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, string bodyString = null, IEnumerable<KeyValuePair<string, string>> headers = null, Encoding specificEncoding = null, string recordActionPathAs = null)
	{
		string requestUrl = BuildUri(actionPath, queryStringParameters);
		string actionPerfmonInstanceName = recordActionPathAs ?? actionPath;
		using WebClient webClient = new WebClient();
		if (specificEncoding != null)
		{
			webClient.Encoding = specificEncoding;
		}
		string responseString = string.Empty;
		long requestId = Interlocked.Increment(ref _RequestCounter);
		BuildHeaders(method, webClient, headers);
		try
		{
			OnRequestStarting();
			OnRequestStarted(requestId, actionPerfmonInstanceName);
			responseString = method switch
			{
				HttpMethod.Delete => await DoDeleteAsync(webClient, requestUrl, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), 
				HttpMethod.Get => await DoGetAsync(webClient, requestUrl, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), 
				HttpMethod.Post => await DoPostOrPutAsync(webClient, "POST", requestUrl, bodyString, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), 
				HttpMethod.Put => await DoPostOrPutAsync(webClient, "PUT", requestUrl, bodyString, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), 
				_ => throw new ApiClientException(Name, "Invalid HttpMethod: " + method), 
			};
			OnRequestSucceeded(requestId, actionPerfmonInstanceName);
		}
		catch (WebException ex)
		{
			GetHttpStatusCodeAndStatusDescription(ex, out var httpStatusCode, out var statusDescription);
			OnRequestFailed(ex, requestId, actionPerfmonInstanceName, httpStatusCode, statusDescription);
		}
		finally
		{
			OnRequestFinished(requestId, actionPerfmonInstanceName);
		}
		return responseString;
	}

	/// <summary>
	/// Do an HTTP GET request, throw away the response.
	/// </summary>
	/// <param name="actionPath">The uri.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual void Get(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		ExecuteHttpRequest(actionPath, HttpMethod.Get, queryStringParameters, null, headers, null, recordActionPathAs);
	}

	/// <summary>
	/// Do an async HTTP GET request, throw away the response
	/// </summary>
	/// <param name="actionPath">The action path.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual async Task GetAsync(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		await ExecuteHttpRequestAsync(actionPath, HttpMethod.Get, cancellationToken, queryStringParameters, null, headers, null, recordActionPathAs).ConfigureAwait(continueOnCapturedContext: false);
	}

	/// <summary>
	/// Do a HTTP GET request, return the response in the desired type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="actionPath">The action path.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns>the response, deserialized into a <typeparamref name="T" /></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual T Get<T>(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		string responseString = ExecuteHttpRequest(actionPath, HttpMethod.Get, queryStringParameters, null, headers, null, recordActionPathAs);
		return DeserializeResponseData<T>(responseString);
	}

	/// <summary>
	/// Do an async HTTP GET request, return the response in the desired type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="actionPath">The uri.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns>the response, deserialized into a <typeparamref name="T" /></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual async Task<T> GetAsync<T>(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		return DeserializeResponseData<T>(await ExecuteHttpRequestAsync(actionPath, HttpMethod.Get, cancellationToken, queryStringParameters, null, headers, null, recordActionPathAs).ConfigureAwait(continueOnCapturedContext: false));
	}

	/// <summary>
	/// Do a HTTP POST request, throw away the response.
	/// </summary>
	/// <typeparam name="T">The type of the data to post.</typeparam>
	/// <param name="actionPath">The uri.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="bodyData">The body data.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual void Post<T>(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters, T bodyData, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		string bodyString = SerializeSendData(bodyData);
		ExecuteHttpRequest(actionPath, HttpMethod.Post, queryStringParameters, bodyString, headers, null, recordActionPathAs);
	}

	/// <summary>
	/// Do an async HTTP POST request, throw away the response.
	/// </summary>
	/// <typeparam name="T">The type of data to post.</typeparam>
	/// <param name="actionPath">The uri.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="bodyData">The body data.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual async Task PostAsync<T>(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters, T bodyData, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		string bodyString = SerializeSendData(bodyData);
		await ExecuteHttpRequestAsync(actionPath, HttpMethod.Post, cancellationToken, queryStringParameters, bodyString, headers, null, recordActionPathAs).ConfigureAwait(continueOnCapturedContext: false);
	}

	/// <summary>
	/// Do a HTTP POST request, return the response in the desired type
	/// </summary>
	/// <typeparam name="T">The type of data expected to be returned.</typeparam>
	/// <typeparam name="TU">The type of data to post.</typeparam>
	/// <param name="actionPath">The uri.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="bodyData">The body data.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns>the response, deserialized into a <typeparamref name="T" /></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual T Post<T>(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters, object bodyData, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		string bodyString = SerializeSendData(bodyData);
		string responseString = ExecuteHttpRequest(actionPath, HttpMethod.Post, queryStringParameters, bodyString, headers, null, recordActionPathAs);
		return DeserializeResponseData<T>(responseString);
	}

	/// <summary>
	/// Do an async HTTP POST request, return the response in the desired type
	/// </summary>
	/// <typeparam name="T">The type of data expected to be returned.</typeparam>
	/// <typeparam name="TU">The type of data to post.</typeparam>
	/// <param name="actionPath">The uri.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="queryStringParameters">The query string parameters.</param>
	/// <param name="bodyData">The body data.</param>
	/// <param name="headers">The headers.</param>
	/// <param name="recordActionPathAs">The perfmon instance name to record requests for this action.</param>
	/// <returns>the response, deserialized into a <typeparamref name="T" /></returns>
	/// <remarks>
	///     USE <paramref name="recordActionPathAs" /> IF YOUR PATH HAS PARAMETERS IN IT! and pass in the template string for the path.
	///     If you do not, you will create a set of perfmon counters for each path and blow up the memory
	/// </remarks>
	protected virtual async Task<T> PostAsync<T>(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters, object bodyData, IEnumerable<KeyValuePair<string, string>> headers = null, string recordActionPathAs = null)
	{
		string bodyString = SerializeSendData(bodyData);
		return DeserializeResponseData<T>(await ExecuteHttpRequestAsync(actionPath, HttpMethod.Post, cancellationToken, queryStringParameters, bodyString, headers, null, recordActionPathAs).ConfigureAwait(continueOnCapturedContext: false));
	}
}
