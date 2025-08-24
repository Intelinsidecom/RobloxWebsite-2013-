namespace Amazon.SimpleDB;

/// <summary>
/// Configuration for accessing Amazon Simple DB  service
/// </summary>
public class AmazonSimpleDBConfig
{
	private string serviceVersion = "2007-11-07";

	private string serviceURL = "http://sdb.amazonaws.com";

	private string userAgent = "Roblox Amazon Simple DB CSharp Library";

	private string signatureVersion = "1";

	private string proxyHost;

	private int proxyPort = -1;

	private int maxErrorRetry = 3;

	/// <summary>
	/// Gets Service Version
	/// </summary>
	public string ServiceVersion => serviceVersion;

	/// <summary>
	/// Gets and sets of the SignatureVersion property.
	/// </summary>
	public string SignatureVersion
	{
		get
		{
			return signatureVersion;
		}
		set
		{
			signatureVersion = value;
		}
	}

	/// <summary>
	/// Gets and sets of the UserAgent property.
	/// </summary>
	public string UserAgent
	{
		get
		{
			return userAgent;
		}
		set
		{
			userAgent = value;
		}
	}

	/// <summary>
	/// Gets and sets of the ServiceURL property.
	/// </summary>
	public string ServiceURL
	{
		get
		{
			return serviceURL;
		}
		set
		{
			serviceURL = value;
		}
	}

	/// <summary>
	/// Gets and sets of the ProxyHost property.
	/// </summary>
	public string ProxyHost
	{
		get
		{
			return proxyHost;
		}
		set
		{
			proxyHost = value;
		}
	}

	/// <summary>
	/// Gets and sets of the ProxyPort property.
	/// </summary>
	public int ProxyPort
	{
		get
		{
			return proxyPort;
		}
		set
		{
			proxyPort = value;
		}
	}

	/// <summary>
	/// Gets and sets of the MaxErrorRetry property.
	/// </summary>
	public int MaxErrorRetry
	{
		get
		{
			return maxErrorRetry;
		}
		set
		{
			maxErrorRetry = value;
		}
	}

	/// <summary>
	/// Sets the SignatureVersion property
	/// </summary>
	/// <param name="signatureVersion">SignatureVersion property</param>
	/// <returns>this instance</returns>
	public AmazonSimpleDBConfig WithSignatureVersion(string signatureVersion)
	{
		this.signatureVersion = signatureVersion;
		return this;
	}

	/// <summary>
	/// Checks if SignatureVersion property is set
	/// </summary>
	/// <returns>true if SignatureVersion property is set</returns>
	public bool IsSetSignatureVersion()
	{
		return signatureVersion != null;
	}

	/// <summary>
	/// Sets the UserAgent property
	/// </summary>
	/// <param name="userAgent">UserAgent property</param>
	/// <returns>this instance</returns>
	public AmazonSimpleDBConfig WithUserAgent(string userAgent)
	{
		this.userAgent = userAgent;
		return this;
	}

	/// <summary>
	/// Checks if UserAgent property is set
	/// </summary>
	/// <returns>true if UserAgent property is set</returns>
	public bool IsSetUserAgent()
	{
		return userAgent != null;
	}

	/// <summary>
	/// Sets the ServiceURL property
	/// </summary>
	/// <param name="serviceURL">ServiceURL property</param>
	/// <returns>this instance</returns>
	public AmazonSimpleDBConfig WithServiceURL(string serviceURL)
	{
		this.serviceURL = serviceURL;
		return this;
	}

	/// <summary>
	/// Checks if ServiceURL property is set
	/// </summary>
	/// <returns>true if ServiceURL property is set</returns>
	public bool IsSetServiceURL()
	{
		return serviceURL != null;
	}

	/// <summary>
	/// Sets the ProxyHost property
	/// </summary>
	/// <param name="proxyHost">ProxyHost property</param>
	/// <returns>this instance</returns>
	public AmazonSimpleDBConfig WithProxyHost(string proxyHost)
	{
		this.proxyHost = proxyHost;
		return this;
	}

	/// <summary>
	/// Checks if ProxyHost property is set
	/// </summary>
	/// <returns>true if ProxyHost property is set</returns>
	public bool IsSetProxyHost()
	{
		return proxyHost != null;
	}

	/// <summary>
	/// Sets the ProxyPort property
	/// </summary>
	/// <param name="proxyPort">ProxyPort property</param>
	/// <returns>this instance</returns>
	public AmazonSimpleDBConfig WithProxyPort(int proxyPort)
	{
		this.proxyPort = proxyPort;
		return this;
	}

	/// <summary>
	/// Checks if ProxyPort property is set
	/// </summary>
	/// <returns>true if ProxyPort property is set</returns>
	public bool IsSetProxyPort()
	{
		return proxyPort != -1;
	}

	/// <summary>
	/// Sets the MaxErrorRetry property
	/// </summary>
	/// <param name="maxErrorRetry">MaxErrorRetry property</param>
	/// <returns>this instance</returns>
	public AmazonSimpleDBConfig WithMaxErrorRetry(int maxErrorRetry)
	{
		this.maxErrorRetry = maxErrorRetry;
		return this;
	}

	/// <summary>
	/// Checks if MaxErrorRetry property is set
	/// </summary>
	/// <returns>true if MaxErrorRetry property is set</returns>
	public bool IsSetMaxErrorRetry()
	{
		return maxErrorRetry != -1;
	}
}
