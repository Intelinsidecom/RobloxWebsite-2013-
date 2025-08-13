using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roblox.Configuration;

namespace Roblox.ApiClientBase;

public abstract class ApiClientBase
{
	public enum HttpMethod
	{
		Get,
		Post,
		Put,
		Delete
	}

	private static readonly string _MultipartBoundary = $"-------{Guid.NewGuid()}";

	private static readonly string _MultipartFormDataContentType = $"multipart/form-data; boundary={_MultipartBoundary}";

	private static readonly string _MultipartFooter = $"\r\n--{_MultipartBoundary}--\r\n";

	private readonly string _ConnectionGroupName = $"ApiClientConnectionGroup_{Guid.NewGuid()}";

	private const string _UploadValuesContentType = "application/x-www-form-urlencoded";

	private static readonly Encoding _Utf8Encoder = Encoding.GetEncoding("UTF-8", new EncoderReplacementFallback(string.Empty), new DecoderExceptionFallback());

	private long _RequestCounter;

	protected abstract string ApiKey { get; }

	protected abstract string Endpoint { get; }

	protected abstract TimeSpan Timeout { get; }

	public abstract string Name { get; }

	public virtual Encoding Encoding => Encoding.UTF8;

	protected virtual ISingleSetting<byte> CloseConnectionTrigger => null;

	public event Action<long, string, HttpStatusCode?, string> RequestFailed;

	public event Action<long, string> RequestFinished;

	public event Action<long, string> RequestStarted;

	public event Action<long, string> RequestSucceeded;

	protected ApiClientBase()
	{
		WireUpCloseConnectionTriggerIfSet(CloseConnectionTrigger);
	}

	private static void AppendEscapedUriDataString(StringBuilder sb, string stringToEscape)
	{
		if (stringToEscape.Length < 32000)
		{
			string value = EncodeAndEscape(stringToEscape);
			sb.Append(value);
			return;
		}
		int num = stringToEscape.Length / 32000;
		for (int i = 0; i <= num; i++)
		{
			if (i < num)
			{
				sb.Append(EncodeAndEscape(stringToEscape.Substring(32000 * i, 32000)));
			}
			else
			{
				sb.Append(EncodeAndEscape(stringToEscape.Substring(32000 * i)));
			}
		}
	}

	private static string EncodeAndEscape(string stringToProcess)
	{
		return Uri.EscapeDataString(_Utf8Encoder.GetString(_Utf8Encoder.GetBytes(stringToProcess)));
	}

	private static IEnumerable<KeyValuePair<string, string>> AddJsonContentTypeToHeaders(IEnumerable<KeyValuePair<string, string>> headers)
	{
		List<KeyValuePair<string, string>> obj = ((headers != null) ? new List<KeyValuePair<string, string>>(headers) : new List<KeyValuePair<string, string>>());
		obj.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
		return obj;
	}

	private IEnumerable<KeyValuePair<string, object>> BuildApiKeyParameter()
	{
		yield return new KeyValuePair<string, object>("apiKey", ApiKey);
	}

	private static string BuildFormDataString(IEnumerable<KeyValuePair<string, object>> formParameters)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		if (formParameters != null)
		{
			foreach (KeyValuePair<string, object> formParameter in formParameters)
			{
				if (flag)
				{
					stringBuilder.Append('&');
				}
				stringBuilder.Append(formParameter.Key);
				stringBuilder.Append("=");
				if (formParameter.Value != null)
				{
					AppendEscapedUriDataString(stringBuilder, formParameter.Value.ToString());
				}
				flag = true;
			}
		}
		return stringBuilder.ToString();
	}

	private byte[] BuildMultipartData(IEnumerable<KeyValuePair<string, byte[]>> parts)
	{
		MemoryStream memoryStream = new MemoryStream();
		bool flag = false;
		foreach (KeyValuePair<string, byte[]> part in parts)
		{
			if (flag)
			{
				memoryStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));
			}
			flag = true;
			string s = $"--{_MultipartBoundary}\r\nContent-Disposition: form-data; name=\"{part.Key}\"\r\n\r\n";
			memoryStream.Write(Encoding.UTF8.GetBytes(s), 0, Encoding.UTF8.GetByteCount(s));
			memoryStream.Write(part.Value, 0, part.Value.Length);
		}
		memoryStream.Write(Encoding.UTF8.GetBytes(_MultipartFooter), 0, Encoding.UTF8.GetByteCount(_MultipartFooter));
		return memoryStream.ToArray();
	}

	private string BuildUrl(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters)
	{
		string baseUrl = Endpoint + actionPath;
		if (queryStringParameters == null)
		{
			queryStringParameters = new List<KeyValuePair<string, object>>();
		}
		if (ApiKey != null)
		{
			queryStringParameters = queryStringParameters.Concat(BuildApiKeyParameter());
		}
		return new UrlBuilder(baseUrl, () => queryStringParameters).ToString();
	}

	private void BuildHeaders(WebClient webClient, IEnumerable<KeyValuePair<string, string>> headers)
	{
		if (headers == null)
		{
			return;
		}
		foreach (KeyValuePair<string, string> header in headers)
		{
			webClient.Headers[header.Key] = header.Value;
		}
	}

	private static T GetPayloadData<T>(string responseString)
	{
		return JsonConvert.DeserializeObject<Payload<T>>(responseString).Data;
	}

	private void OnRequestFinished(long requestId, string actionName)
	{
		this.RequestFinished?.Invoke(requestId, actionName);
	}

	private void OnRequestStarted(long requestId, string actionName)
	{
		this.RequestStarted?.Invoke(requestId, actionName);
	}

	private void OnRequestSucceeded(long requestId, string actionName)
	{
		this.RequestSucceeded?.Invoke(requestId, actionName);
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

	private byte[] DetermineBytesToUpload(string rawPostData, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData, IEnumerable<KeyValuePair<string, object>> formParameters)
	{
		if (rawPostData != null)
		{
			return Encoding.UTF8.GetBytes(rawPostData);
		}
		if (multipartFormData != null)
		{
			return BuildMultipartData(multipartFormData);
		}
		return Encoding.UTF8.GetBytes(BuildFormDataString(formParameters));
	}

	private string DoPostOrPut(WebClient webClient, string httpMethod, string requestUrl, IEnumerable<KeyValuePair<string, object>> formParameters, string rawPostData, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null)
	{
		byte[] data = DetermineBytesToUpload(rawPostData, multipartFormData, formParameters);
		if (string.IsNullOrEmpty(webClient.Headers[HttpRequestHeader.ContentType]))
		{
			bool flag = rawPostData == null && multipartFormData != null;
			webClient.Headers[HttpRequestHeader.ContentType] = (flag ? _MultipartFormDataContentType : "application/x-www-form-urlencoded");
		}
		byte[] bytes = webClient.UploadData(requestUrl, httpMethod, data);
		return Encoding.UTF8.GetString(bytes);
	}

	private async Task<string> DoPostOrPutAsync(WebClient webClient, string httpMethod, string requestUrl, IEnumerable<KeyValuePair<string, object>> formParameters, CancellationToken cancellationToken, string rawPostData, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null)
	{
		cancellationToken.Register(webClient.CancelAsync);
		byte[] data = DetermineBytesToUpload(rawPostData, multipartFormData, formParameters);
		if (string.IsNullOrEmpty(webClient.Headers[HttpRequestHeader.ContentType]))
		{
			bool flag = rawPostData == null && multipartFormData != null;
			webClient.Headers[HttpRequestHeader.ContentType] = (flag ? _MultipartFormDataContentType : "application/x-www-form-urlencoded");
		}
		cancellationToken.Register(webClient.CancelAsync);
		byte[] bytes = await webClient.UploadDataTaskAsync(requestUrl, httpMethod, data).ConfigureAwait(continueOnCapturedContext: false);
		return Encoding.UTF8.GetString(bytes);
	}

	protected void HandleRequestFailedEvent(long requestId, string actionName, HttpStatusCode? statusCode, string statusDescription)
	{
		this.RequestFailed?.Invoke(requestId, actionName, statusCode, statusDescription);
	}

	protected abstract void OnRequestStarting();

	protected virtual void OnRequestFailed(WebException ex, long requestId, string actionName, HttpStatusCode? statusCode, string statusDescription)
	{
		HandleRequestFailedEvent(requestId, actionName, statusCode, statusDescription);
		ThrowConvertedException(ex, actionName, statusCode, statusDescription);
	}

	protected void ThrowConvertedException(WebException ex, string actionName, HttpStatusCode? statusCode, string statusDescription)
	{
		Stream stream = ex?.Response?.GetResponseStream();
		string text;
		if (stream != null && stream.CanRead && stream.Length > 0)
		{
			text = new StreamReader(stream, Encoding.UTF8).ReadToEnd();
			stream.Seek(0L, SeekOrigin.Begin);
		}
		else
		{
			text = "can't read from response (no responseText)";
		}
		string message = string.Format("ApiClient {0} exception:\r\nUrl = {1}\r\nStatusCode = {2}\r\nStatusDescription = {3}\r\nResponseText = {4}\r\n", Name, Endpoint + actionName, statusCode?.ToString() ?? "StatusCodeNotAvailable", statusDescription, text);
		if ((statusCode.HasValue && statusCode.Value == HttpStatusCode.TooManyRequests) || ex.Message.Contains("ProvisionedThroughputExceeded"))
		{
			throw new RequestThrottledException(Name, message, ex, statusCode, statusDescription);
		}
		throw new ApiClientException(Name, message, ex, statusCode, statusDescription);
	}

	protected static void GetHttpStatusCodeAndStatusDescription(WebException ex, out HttpStatusCode? httpStatusCode, out string statusDescription)
	{
		if (ex.Response is HttpWebResponse httpWebResponse)
		{
			httpStatusCode = httpWebResponse.StatusCode;
			statusDescription = httpWebResponse.StatusDescription;
		}
		else
		{
			httpStatusCode = null;
			statusDescription = ex.Status.ToString();
		}
	}

	protected virtual string ExecuteHttpRequest(string actionPath, HttpMethod method, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null, string actionName = null)
	{
		if (actionName == null)
		{
			actionName = actionPath;
		}
		string requestUrl = BuildUrl(actionPath, queryStringParameters);
		using TimeoutWebClient timeoutWebClient = new TimeoutWebClient(Timeout, _ConnectionGroupName);
		if (Encoding != null)
		{
			timeoutWebClient.Encoding = Encoding;
		}
		string result = string.Empty;
		long requestId = Interlocked.Increment(ref _RequestCounter);
		BuildHeaders(timeoutWebClient, headers);
		try
		{
			OnRequestStarting();
			OnRequestStarted(requestId, actionName);
			result = method switch
			{
				HttpMethod.Delete => DoDelete(timeoutWebClient, requestUrl), 
				HttpMethod.Get => DoGet(timeoutWebClient, requestUrl), 
				HttpMethod.Post => DoPostOrPut(timeoutWebClient, "POST", requestUrl, formParameters, rawPostData, multipartFormData), 
				HttpMethod.Put => DoPostOrPut(timeoutWebClient, "PUT", requestUrl, formParameters, rawPostData, multipartFormData), 
				_ => throw new ApiClientException(Name, "Invalid HttpMethod: " + method), 
			};
			OnRequestSucceeded(requestId, actionName);
		}
		catch (WebException ex)
		{
			GetHttpStatusCodeAndStatusDescription(ex, out var httpStatusCode, out var statusDescription);
			OnRequestFailed(ex, requestId, actionName, httpStatusCode, statusDescription);
		}
		finally
		{
			OnRequestFinished(requestId, actionName);
		}
		return result;
	}

	protected virtual async Task<string> ExecuteHttpRequestAsync(string actionPath, HttpMethod method, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null, string actionName = null)
	{
		if (actionName == null)
		{
			actionName = actionPath;
		}
		string requestUrl = BuildUrl(actionPath, queryStringParameters);
		using TimeoutWebClient webClient = new TimeoutWebClient(Timeout, _ConnectionGroupName);
		string responseString = string.Empty;
		long requestId = Interlocked.Increment(ref _RequestCounter);
		BuildHeaders(webClient, headers);
		try
		{
			OnRequestStarting();
			OnRequestStarted(requestId, actionName);
			responseString = method switch
			{
				HttpMethod.Delete => await DoDeleteAsync(webClient, requestUrl, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), 
				HttpMethod.Get => await DoGetAsync(webClient, requestUrl, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), 
				HttpMethod.Post => await DoPostOrPutAsync(webClient, "POST", requestUrl, formParameters, cancellationToken, rawPostData, multipartFormData).ConfigureAwait(continueOnCapturedContext: false), 
				HttpMethod.Put => await DoPostOrPutAsync(webClient, "PUT", requestUrl, formParameters, cancellationToken, rawPostData, multipartFormData).ConfigureAwait(continueOnCapturedContext: false), 
				_ => throw new ApiClientException(Name, "Invalid HttpMethod: " + method), 
			};
			OnRequestSucceeded(requestId, actionName);
		}
		catch (WebException ex)
		{
			GetHttpStatusCodeAndStatusDescription(ex, out var httpStatusCode, out var statusDescription);
			OnRequestFailed(ex, requestId, actionName, httpStatusCode, statusDescription);
		}
		finally
		{
			OnRequestFinished(requestId, actionName);
		}
		return responseString;
	}

	private void WireUpCloseConnectionTriggerIfSet(ISingleSetting<byte> closeConnectionTriggerSetting)
	{
		if (closeConnectionTriggerSetting != null)
		{
			closeConnectionTriggerSetting.PropertyChanged += delegate
			{
				RefreshConnections();
			};
		}
	}

	protected void RefreshConnections()
	{
		ServicePointManager.FindServicePoint(new Uri(Endpoint)).CloseConnectionGroup(_ConnectionGroupName);
	}

	protected string Get(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		return ExecuteHttpRequest(actionPath, HttpMethod.Get, queryStringParameters, null, headers, null, null, actionName);
	}

	protected async Task<string> GetAsync(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		return await ExecuteHttpRequestAsync(actionPath, HttpMethod.Get, cancellationToken, queryStringParameters, null, headers, null, null, actionName).ConfigureAwait(continueOnCapturedContext: false);
	}

	protected T Get<T>(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		return GetPayloadData<T>(ExecuteHttpRequest(actionPath, HttpMethod.Get, queryStringParameters, null, headers, null, null, actionName));
	}

	protected async Task<T> GetAsync<T>(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		return GetPayloadData<T>(await ExecuteHttpRequestAsync(actionPath, HttpMethod.Get, cancellationToken, queryStringParameters, null, headers, null, null, actionName).ConfigureAwait(continueOnCapturedContext: false));
	}

	protected string Post(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, string actionName = null)
	{
		return ExecuteHttpRequest(actionPath, HttpMethod.Post, queryStringParameters, formParameters, headers, rawPostData, null, actionName);
	}

	protected async Task<string> PostAsync(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, string actionName = null)
	{
		return await ExecuteHttpRequestAsync(actionPath, HttpMethod.Post, cancellationToken, queryStringParameters, formParameters, headers, rawPostData, null, actionName).ConfigureAwait(continueOnCapturedContext: false);
	}

	protected void PostJson(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string jsonPostData = null, string actionName = null)
	{
		IEnumerable<KeyValuePair<string, string>> headers2 = AddJsonContentTypeToHeaders(headers);
		Post(actionPath, queryStringParameters, null, headers2, jsonPostData, actionName);
	}

	protected async Task PostJsonAsync(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string jsonPostData = null, string actionName = null)
	{
		IEnumerable<KeyValuePair<string, string>> headers2 = AddJsonContentTypeToHeaders(headers);
		await PostAsync(actionPath, cancellationToken, queryStringParameters, null, headers2, jsonPostData, actionName);
	}

	protected T Post<T>(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null, string actionName = null)
	{
		return GetPayloadData<T>(ExecuteHttpRequest(actionPath, HttpMethod.Post, queryStringParameters, formParameters, headers, rawPostData, multipartFormData, actionName));
	}

	protected async Task<T> PostAsync<T>(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null, string actionName = null)
	{
		return GetPayloadData<T>(await ExecuteHttpRequestAsync(actionPath, HttpMethod.Post, cancellationToken, queryStringParameters, formParameters, headers, rawPostData, multipartFormData, actionName).ConfigureAwait(continueOnCapturedContext: false));
	}

	protected T PostJson<T>(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string jsonPostData = null, string actionName = null)
	{
		IEnumerable<KeyValuePair<string, string>> headers2 = AddJsonContentTypeToHeaders(headers);
		return Post<T>(actionPath, queryStringParameters, null, headers2, jsonPostData, null, actionName);
	}

	protected async Task<T> PostJsonAsync<T>(string actionPath, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string jsonPostData = null, string actionName = null)
	{
		IEnumerable<KeyValuePair<string, string>> headers2 = AddJsonContentTypeToHeaders(headers);
		return await PostAsync<T>(actionPath, cancellationToken, queryStringParameters, null, headers2, jsonPostData, null, actionName).ConfigureAwait(continueOnCapturedContext: false);
	}

	protected T PostObjectJson<T>(string actionPath, object postObject, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		string jsonPostData = JsonConvert.SerializeObject(postObject, new IsoDateTimeConverter());
		return PostJson<T>(actionPath, queryStringParameters, headers, jsonPostData, actionName);
	}

	protected async Task<T> PostObjectJsonAsync<T>(string actionPath, object postObject, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		string jsonPostData = JsonConvert.SerializeObject(postObject, new IsoDateTimeConverter());
		return await PostJsonAsync<T>(actionPath, cancellationToken, queryStringParameters, headers, jsonPostData, actionName).ConfigureAwait(continueOnCapturedContext: false);
	}

	protected void PostObjectJson(string actionPath, object postObject, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		string jsonPostData = JsonConvert.SerializeObject(postObject, new IsoDateTimeConverter());
		PostJson(actionPath, queryStringParameters, headers, jsonPostData, actionName);
	}

	protected async Task PostObjectJsonAsync(string actionPath, object postObject, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string actionName = null)
	{
		string jsonPostData = JsonConvert.SerializeObject(postObject, new IsoDateTimeConverter());
		await PostJsonAsync(actionPath, cancellationToken, queryStringParameters, headers, jsonPostData, actionName).ConfigureAwait(continueOnCapturedContext: false);
	}
}
