using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Roblox.IpGeolocation.Client;

[GeneratedCode("NSwag", "13.1.6.0 (NJsonSchema v10.0.28.0 (Newtonsoft.Json v12.0.0.0))")]
public class IpLookupClient : IIpLookupClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private HttpClient _httpClient;

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public IpLookupClient(HttpClient httpClient)
	{
		_httpClient = httpClient;
		_settings = new Lazy<JsonSerializerSettings>(() => new JsonSerializerSettings());
	}

	/// <returns>Success</returns>
	/// <exception cref="T:Roblox.IpGeolocation.Client.SwaggerException">A server side error occurred.</exception>
	public Task<IpGeolocationResponse> LookupAsync(string ipAddress)
	{
		return LookupAsync(ipAddress, CancellationToken.None);
	}

	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>Success</returns>
	/// <exception cref="T:Roblox.IpGeolocation.Client.SwaggerException">A server side error occurred.</exception>
	public async Task<IpGeolocationResponse> LookupAsync(string ipAddress, CancellationToken cancellationToken)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("v1/ip-lookup?");
		if (ipAddress != null)
		{
			stringBuilder.Append(Uri.EscapeDataString("IpAddress") + "=").Append(Uri.EscapeDataString(ConvertToString(ipAddress, CultureInfo.InvariantCulture))).Append("&");
		}
		stringBuilder.Length--;
		HttpClient httpClient = _httpClient;
		using HttpRequestMessage request_ = new HttpRequestMessage();
		request_.Method = new HttpMethod("GET");
		request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
		string uriString = stringBuilder.ToString();
		request_.RequestUri = new Uri(uriString, UriKind.RelativeOrAbsolute);
		HttpResponseMessage response_ = await httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					headers_[header.Key] = header.Value;
				}
			}
			string text = ((int)response_.StatusCode).ToString();
			if (text == "200")
			{
				return (await ReadObjectResponseAsync<IpGeolocationResponse>(response_, headers_).ConfigureAwait(continueOnCapturedContext: false)).Object;
			}
			if (text != "200" && text != "204")
			{
				string text2 = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				string response = text2;
				throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, response, headers_, null);
			}
			return null;
		}
		finally
		{
			response_?.Dispose();
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException innerException)
			{
				throw new SwaggerException("Could not deserialize the response body string as " + typeof(T).FullName + ".", (int)response.StatusCode, text, headers, innerException);
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader reader = new StreamReader(stream);
			using JsonTextReader reader2 = new JsonTextReader(reader);
			T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>(reader2);
			return new ObjectResponseResult<T>(responseObject2, string.Empty);
		}
		catch (JsonException innerException2)
		{
			throw new SwaggerException("Could not deserialize the response body stream as " + typeof(T).FullName + ".", (int)response.StatusCode, string.Empty, headers, innerException2);
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null)
				{
					Attribute? customAttribute = declaredField.GetCustomAttribute(typeof(EnumMemberAttribute));
					EnumMemberAttribute val = (EnumMemberAttribute)(object)((customAttribute is EnumMemberAttribute) ? customAttribute : null);
					if (val != null)
					{
						if (val.Value == null)
						{
							return name;
						}
						return val.Value;
					}
				}
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString(value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value != null && value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		return Convert.ToString(value, cultureInfo);
	}
}
