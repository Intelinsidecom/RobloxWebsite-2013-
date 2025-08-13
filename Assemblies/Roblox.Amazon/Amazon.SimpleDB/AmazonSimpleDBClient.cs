using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Xml.Serialization;
using Amazon.SimpleDB.Model;
using Roblox.Amazon.Properties;

namespace Amazon.SimpleDB;

/// *
/// * AmazonSimpleDBClient is an implementation of AmazonSimpleDB
/// *
internal class AmazonSimpleDBClient : AmazonSimpleDB
{
	private static readonly string awsAccessKeyId = Settings.Default.accessKeyId;

	private static readonly string awsSecretAccessKey = Settings.Default.secretAccessKey;

	private AmazonSimpleDBConfig config;

	private static readonly TimeSpan timout = TimeSpan.FromMinutes(2.0);

	/// <summary>
	/// Constructs AmazonSimpleDBClient
	/// </summary>
	public AmazonSimpleDBClient()
	{
		config = new AmazonSimpleDBConfig();
	}

	/// <summary>
	/// Constructs AmazonSimpleDBClient
	/// </summary>
	/// <param name="config">configuration</param>
	public AmazonSimpleDBClient(AmazonSimpleDBConfig config)
	{
		this.config = config;
	}

	/// <summary>
	/// Create Domain 
	/// </summary>
	/// <param name="request">Create Domain  Action</param>
	/// <returns>Create Domain  Response from the service</returns>
	/// <remarks>
	/// The CreateDomain operation creates a new domain. The domain name must be unique
	/// among the domains associated with the Access Key ID provided in the request. The CreateDomain
	/// operation may take 10 or more seconds to complete.
	///
	/// </remarks>
	public CreateDomainResponse CreateDomain(CreateDomain request)
	{
		return Invoke<CreateDomainResponse>(request.ToMap());
	}

	/// <summary>
	/// List Domains 
	/// </summary>
	/// <param name="request">List Domains  Action</param>
	/// <returns>List Domains  Response from the service</returns>
	/// <remarks>
	/// The ListDomains operaton lists all domains associated with the Access Key ID. It returns
	/// domain names up to the limit set by MaxNumberOfDomains. A NextToken is returned if there are more
	/// than MaxNumberOfDomains domains. Calling ListDomains successive times with the
	/// NextToken returns up to MaxNumberOfDomains more domain names each time.
	///
	/// </remarks>
	public ListDomainsResponse ListDomains(ListDomains request)
	{
		return Invoke<ListDomainsResponse>(request.ToMap());
	}

	/// <summary>
	/// Delete Domain 
	/// </summary>
	/// <param name="request">Delete Domain  Action</param>
	/// <returns>Delete Domain  Response from the service</returns>
	/// <remarks>
	/// The DeleteDomain operation deletes a domain. Any items (and their attributes) in the domain
	/// are deleted as well. The DeleteDomain operation may take 10 or more seconds to complete.
	///
	/// </remarks>
	public DeleteDomainResponse DeleteDomain(DeleteDomain request)
	{
		return Invoke<DeleteDomainResponse>(request.ToMap());
	}

	/// <summary>
	/// Put Attributes 
	/// </summary>
	/// <param name="request">Put Attributes  Action</param>
	/// <returns>Put Attributes  Response from the service</returns>
	/// <remarks>
	/// The PutAttributes operation creates or replaces attributes within an item. You specify new attributes
	/// using a combination of the Attribute.X.Name and Attribute.X.Value parameters. You specify
	/// the first attribute by the parameters Attribute.0.Name and Attribute.0.Value, the second
	/// attribute by the parameters Attribute.1.Name and Attribute.1.Value, and so on.
	///
	/// Attributes are uniquely identified within an item by their name/value combination. For example, a single
	/// item can have the attributes { "first_name", "first_value" } and { "first_name",
	/// second_value" }. However, it cannot have two attribute instances where both the Attribute.X.Name and
	/// Attribute.X.Value are the same.
	/// Optionally, the requestor can supply the Replace parameter for each individual value. Setting this value
	/// to true will cause the new attribute value to replace the existing attribute value(s). For example, if an
	/// item has the attributes { 'a', '1' }, { 'b', '2'} and { 'b', '3' } and the requestor does a
	/// PutAttributes of { 'b', '4' } with the Replace parameter set to true, the final attributes of the
	/// item will be { 'a', '1' } and { 'b', '4' }, replacing the previous values of the 'b' attribute
	/// with the new value.
	///
	/// </remarks>
	public PutAttributesResponse PutAttributes(PutAttributes request)
	{
		return Invoke<PutAttributesResponse>(request.ToMap());
	}

	/// <summary>
	/// Get Attributes 
	/// </summary>
	/// <param name="request">Get Attributes  Action</param>
	/// <returns>Get Attributes  Response from the service</returns>
	/// <remarks>
	/// Returns all of the attributes associated with the item. Optionally, the attributes returned can be limited to
	/// the specified AttributeName parameter.
	/// If the item does not exist on the replica that was accessed for this operation, an empty attribute is
	/// returned. The system does not return an error as it cannot guarantee the item does not exist on other
	/// replicas.
	///
	/// </remarks>
	public GetAttributesResponse GetAttributes(GetAttributes request)
	{
		return Invoke<GetAttributesResponse>(request.ToMap());
	}

	/// <summary>
	/// Delete Attributes 
	/// </summary>
	/// <param name="request">Delete Attributes  Action</param>
	/// <returns>Delete Attributes  Response from the service</returns>
	/// <remarks>
	/// Deletes one or more attributes associated with the item. If all attributes of an item are deleted, the item is
	/// deleted.
	///
	/// </remarks>
	public DeleteAttributesResponse DeleteAttributes(DeleteAttributes request)
	{
		return Invoke<DeleteAttributesResponse>(request.ToMap());
	}

	/// <summary>
	/// Query 
	/// </summary>
	/// <param name="request">Query  Action</param>
	/// <returns>Query  Response from the service</returns>
	/// <remarks>
	/// The Query operation returns a set of ItemNames that match the query expression. Query operations that
	/// run longer than 5 seconds will likely time-out and return a time-out error response.
	/// A Query with no QueryExpression matches all items in the domain.
	///
	/// </remarks>
	public QueryResponse Query(Query request)
	{
		return Invoke<QueryResponse>(request.ToMap());
	}

	/// Configure HttpClient with set of defaults as well as configuration
	/// from AmazonSimpleDBConfig instance
	private HttpWebRequest ConfigureWebRequest(int contentLength)
	{
		HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;
		if (config.IsSetProxyHost())
		{
			request.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
		}
		request.UserAgent = config.UserAgent;
		request.Method = "POST";
		request.Timeout = 50000;
		request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
		request.ContentLength = contentLength;
		return request;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="ex"></param>
	/// <param name="retryAllowed">This function may chose not to throw if retryAllowed</param>
	private void HandleAsyncInvokeException(Exception ex, bool retryAllowed)
	{
		if (ex is WebException we)
		{
			HttpStatusCode statusCode;
			string responseBody;
			using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response)
			{
				if (httpErrorResponse == null)
				{
					throw new AmazonSimpleDBException(we);
				}
				statusCode = httpErrorResponse.StatusCode;
				using StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8);
				responseBody = reader.ReadToEnd();
			}
			if (retryAllowed && (statusCode == HttpStatusCode.InternalServerError || statusCode == HttpStatusCode.ServiceUnavailable))
			{
				return;
			}
			try
			{
				XmlSerializer serlizer = new XmlSerializer(typeof(ErrorResponse));
				ErrorResponse errorResponse;
				using (StringReader r = new StringReader(responseBody))
				{
					errorResponse = (ErrorResponse)serlizer.Deserialize(r);
				}
				Error error = errorResponse.Error[0];
				throw new AmazonSimpleDBException(error.Message, statusCode, error.Code, error.Type, null, errorResponse.RequestId, errorResponse.ToXML());
			}
			catch (Exception e)
			{
				if (e is AmazonSimpleDBException)
				{
					throw;
				}
				throw ReportAnyErrors(responseBody, statusCode, e);
			}
		}
		throw new AmazonSimpleDBException(ex);
	}

	private void Throw(Exception exception)
	{
		if (exception is WebException we)
		{
			HttpStatusCode statusCode;
			string responseBody;
			using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response)
			{
				if (httpErrorResponse == null)
				{
					throw new AmazonSimpleDBException(we);
				}
				statusCode = httpErrorResponse.StatusCode;
				using StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8);
				responseBody = reader.ReadToEnd();
			}
			try
			{
				XmlSerializer serlizer = new XmlSerializer(typeof(ErrorResponse));
				ErrorResponse errorResponse;
				using (StringReader r = new StringReader(responseBody))
				{
					errorResponse = (ErrorResponse)serlizer.Deserialize(r);
				}
				Error error = errorResponse.Error[0];
				throw new AmazonSimpleDBException(error.Message, statusCode, error.Code, error.Type, null, errorResponse.RequestId, errorResponse.ToXML());
			}
			catch (Exception e)
			{
				if (e is AmazonSimpleDBException)
				{
					Console.WriteLine(e.Message);
					throw;
				}
				AmazonSimpleDBException ex = ReportAnyErrors(responseBody, statusCode, e);
				Console.WriteLine(ex.Message);
				throw ex;
			}
		}
		Console.WriteLine(exception.Message);
		throw new AmazonSimpleDBException(exception);
	}

	/// Invoke request and return response
	private T Invoke<T>(IDictionary<string, string> parameters)
	{
		_ = parameters["Action"];
		T response = default(T);
		string responseBody = null;
		HttpStatusCode statusCode = (HttpStatusCode)0;
		AddRequiredParameters(parameters);
		string queryString = GetParametersAsString(parameters);
		byte[] requestData = new UTF8Encoding().GetBytes(queryString);
		bool shouldRetry = true;
		int retries = 0;
		do
		{
			HttpWebRequest request = ConfigureWebRequest(requestData.Length);
			try
			{
				using (Stream requestStream = request.GetRequestStream())
				{
					requestStream.Write(requestData, 0, requestData.Length);
				}
				using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
				{
					statusCode = httpResponse.StatusCode;
					using StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
					responseBody = streamReader.ReadToEnd();
				}
				XmlSerializer serlizer2 = new XmlSerializer(typeof(T));
				using (StringReader textReader = new StringReader(responseBody))
				{
					response = (T)serlizer2.Deserialize(textReader);
				}
				shouldRetry = false;
			}
			catch (WebException we)
			{
				shouldRetry = false;
				using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response)
				{
					if (httpErrorResponse == null)
					{
						throw new AmazonSimpleDBException(we);
					}
					statusCode = httpErrorResponse.StatusCode;
					using StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8);
					responseBody = reader.ReadToEnd();
				}
				if (statusCode == HttpStatusCode.InternalServerError || statusCode == HttpStatusCode.ServiceUnavailable)
				{
					shouldRetry = true;
					PauseOnRetry(++retries, statusCode);
					continue;
				}
				try
				{
					XmlSerializer serlizer = new XmlSerializer(typeof(ErrorResponse));
					ErrorResponse errorResponse;
					using (StringReader r = new StringReader(responseBody))
					{
						errorResponse = (ErrorResponse)serlizer.Deserialize(r);
					}
					Error error = errorResponse.Error[0];
					throw new AmazonSimpleDBException(error.Message, statusCode, error.Code, error.Type, null, errorResponse.RequestId, errorResponse.ToXML());
				}
				catch (Exception e)
				{
					if (e is AmazonSimpleDBException)
					{
						throw;
					}
					throw ReportAnyErrors(responseBody, statusCode, e);
				}
			}
			catch (Exception t)
			{
				throw new AmazonSimpleDBException(t);
			}
		}
		while (shouldRetry);
		return response;
	}

	/// Look for additional error strings in the response and return formatted exception
	private AmazonSimpleDBException ReportAnyErrors(string responseBody, HttpStatusCode status, Exception e)
	{
		AmazonSimpleDBException ex = null;
		if (responseBody != null && responseBody.StartsWith("<"))
		{
			Match errorMatcherOne = Regex.Match(responseBody, "<RequestId>(.*)</RequestId>.*<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?", RegexOptions.Multiline);
			Match errorMatcherTwo = Regex.Match(responseBody, "<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>", RegexOptions.Multiline);
			Match errorMatcherThree = Regex.Match(responseBody, "<Error><Code>(.*)</Code><Message>(.*)</Message><BoxUsage>(.*)</BoxUsage></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>", RegexOptions.Multiline);
			if (errorMatcherOne.Success)
			{
				string requestId3 = errorMatcherOne.Groups[1].Value;
				string code3 = errorMatcherOne.Groups[2].Value;
				return new AmazonSimpleDBException(errorMatcherOne.Groups[3].Value, status, code3, "Unknown", null, requestId3, responseBody);
			}
			if (errorMatcherTwo.Success)
			{
				string code2 = errorMatcherTwo.Groups[1].Value;
				string value = errorMatcherTwo.Groups[2].Value;
				string requestId2 = errorMatcherTwo.Groups[4].Value;
				return new AmazonSimpleDBException(value, status, code2, "Unknown", null, requestId2, responseBody);
			}
			if (errorMatcherThree.Success)
			{
				string code = errorMatcherThree.Groups[1].Value;
				string value2 = errorMatcherThree.Groups[2].Value;
				string boxUsage = errorMatcherThree.Groups[3].Value;
				string requestId = errorMatcherThree.Groups[5].Value;
				return new AmazonSimpleDBException(value2, status, code, "Unknown", boxUsage, requestId, responseBody);
			}
			return new AmazonSimpleDBException("Internal Error", status);
		}
		return new AmazonSimpleDBException("Internal Error", status);
	}

	/// Exponential sleep on failed request
	private void PauseOnRetry(int retries, HttpStatusCode status)
	{
		if (retries <= config.MaxErrorRetry)
		{
			Thread.Sleep((int)Math.Pow(4.0, retries) * 100);
			return;
		}
		throw new AmazonSimpleDBException("Maximum number of retry attempts reached : " + (retries - 1), status);
	}

	/// Add authentication related and version parameters
	private void AddRequiredParameters(IDictionary<string, string> parameters)
	{
		parameters.Add("AWSAccessKeyId", awsAccessKeyId);
		parameters.Add("Timestamp", GetFormattedTimestamp());
		parameters.Add("Version", config.ServiceVersion);
		parameters.Add("SignatureVersion", config.SignatureVersion);
		parameters.Add("Signature", SignParameters(parameters, awsSecretAccessKey));
	}

	/// Convert Disctionary of paremeters to Url encoded query string
	private string GetParametersAsString(IDictionary<string, string> parameters)
	{
		StringBuilder data = new StringBuilder();
		foreach (string key in parameters.Keys)
		{
			string value = parameters[key];
			if (value != null && value.Length > 0)
			{
				data.Append(key);
				data.Append('=');
				data.Append(HttpUtility.UrlEncode(value, Encoding.UTF8));
				data.Append('&');
			}
		}
		string stringData = data.ToString();
		if (stringData.EndsWith("&"))
		{
			stringData = stringData.Remove(stringData.Length - 1, 1);
		}
		return stringData;
	}

	/// Computes RFC 2104-compliant HMAC signature for request parameters
	/// Implements AWS Signature, as per following spec:
	///
	/// If Signature Version is 0, it signs concatenated Action and Timestamp
	///
	/// If Signature Version is 1, it performs the following:
	///
	/// Sorts all  parameters (including SignatureVersion and excluding Signature,
	/// the value of which is being created), ignoring case.
	///
	/// Iterate over the sorted list and append the parameter name (in original case)
	/// and then its value. It will not URL-encode the parameter values before
	/// constructing this string. There are no separators.
	private string SignParameters(IDictionary<string, string> parameters, string key)
	{
		string signatureVersion = parameters["SignatureVersion"];
		StringBuilder data = new StringBuilder();
		if ("0".Equals(signatureVersion))
		{
			data.Append(parameters["Action"]).Append(parameters["Timestamp"]);
		}
		else
		{
			if (!"1".Equals(signatureVersion))
			{
				throw new Exception("Invalid Signature Version specified");
			}
			SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>(parameters, StringComparer.InvariantCultureIgnoreCase);
			parameters.Remove("Signature");
			foreach (KeyValuePair<string, string> pair in (IEnumerable<KeyValuePair<string, string>>)sortedDictionary)
			{
				if (pair.Value != null && pair.Value.Length > 0)
				{
					data.Append(pair.Key);
					data.Append(pair.Value);
				}
			}
		}
		return Sign(data.ToString(), key);
	}

	/// Computes RFC 2104-compliant HMAC signature.
	private string Sign(string data, string key)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		Encoding encoding = new UTF8Encoding();
		return Convert.ToBase64String(((HashAlgorithm)new HMACSHA1(encoding.GetBytes(key))).ComputeHash(encoding.GetBytes(data.ToCharArray())));
	}

	/// Formats date as ISO 8601 timestamp
	private string GetFormattedTimestamp()
	{
		DateTime dateTime = DateTime.Now;
		return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond, DateTimeKind.Local).ToUniversalTime().ToString("yyyy-MM-dd\\THH:mm:ss.fff\\Z", CultureInfo.InvariantCulture);
	}
}
