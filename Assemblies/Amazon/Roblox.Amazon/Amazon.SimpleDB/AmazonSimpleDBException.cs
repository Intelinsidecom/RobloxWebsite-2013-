using System;
using System.Net;

namespace Amazon.SimpleDB;

/// <summary>
/// Amazon Simple DB  Exception provides details of errors 
/// returned by Amazon Simple DB  service
/// </summary>
public class AmazonSimpleDBException : Exception
{
	private string message;

	private HttpStatusCode statusCode;

	private string errorCode;

	private string errorType;

	private string boxUsage;

	private string requestId;

	private string xml;

	/// <summary>
	/// Gets and sets of the ErrorCode property.
	/// </summary>
	public string ErrorCode => errorCode;

	/// <summary>
	/// Gets and sets of the ErrorType property.
	/// </summary>
	public string ErrorType => errorType;

	/// <summary>
	/// Gets error message
	/// </summary>
	public override string Message => message;

	/// <summary>
	/// Gets status code returned by the service if available. If status
	/// code is set to -1, it means that status code was unavailable at the
	/// time exception was thrown
	/// </summary>
	public HttpStatusCode StatusCode => statusCode;

	/// <summary>
	/// Gets measure of machine utilization for this request
	/// </summary>
	public string BoxUsage => boxUsage;

	/// <summary>
	/// Gets XML returned by the service if available.
	/// </summary>
	public string XML => xml;

	/// <summary>
	/// Gets Request ID returned by the service if available.
	/// </summary>
	public string RequestId => requestId;

	/// <summary>
	/// Constructs AmazonSimpleDBException with message
	/// </summary>
	/// <param name="message">Overview of error</param>
	public AmazonSimpleDBException(string message)
	{
		this.message = message;
	}

	/// <summary>
	/// Constructs AmazonSimpleDBException with message and status code
	/// </summary>
	/// <param name="message">Overview of error</param>
	/// <param name="statusCode">HTTP status code for error response</param>
	public AmazonSimpleDBException(string message, HttpStatusCode statusCode)
		: this(message)
	{
		this.statusCode = statusCode;
	}

	/// <summary>
	/// Constructs AmazonSimpleDBException with wrapped exception
	/// </summary>
	/// <param name="t">Wrapped exception</param>
	public AmazonSimpleDBException(Exception t)
		: this(t.Message, t)
	{
	}

	/// <summary>
	/// Constructs AmazonSimpleDBException with message and wrapped exception
	/// </summary>
	/// <param name="message">Overview of error</param>
	/// <param name="t">Wrapped exception</param>
	public AmazonSimpleDBException(string message, Exception t)
		: base(message, t)
	{
		this.message = message;
		if (t is AmazonSimpleDBException)
		{
			AmazonSimpleDBException ex = (AmazonSimpleDBException)t;
			statusCode = ex.StatusCode;
			errorCode = ex.ErrorCode;
			errorType = ex.ErrorType;
			boxUsage = ex.BoxUsage;
			requestId = ex.RequestId;
			xml = ex.XML;
		}
	}

	/// <summary>
	/// Constructs AmazonSimpleDBException with information available from service
	/// </summary>
	/// <param name="message">Overview of error</param>
	/// <param name="statusCode">HTTP status code for error response</param>
	/// <param name="errorCode">Error Code returned by the service</param>
	/// <param name="errorType">Error type. Possible types:  Sender, Receiver or Unknown</param>
	/// <param name="boxUsage">Measure of machine utilization for this request</param>
	/// <param name="requestId">Request ID returned by the service</param>
	/// <param name="xml">Compete xml found in response</param>
	public AmazonSimpleDBException(string message, HttpStatusCode statusCode, string errorCode, string errorType, string boxUsage, string requestId, string xml)
		: this(message, statusCode)
	{
		this.errorCode = errorCode;
		this.errorType = errorType;
		this.boxUsage = boxUsage;
		this.requestId = requestId;
		this.xml = xml;
	}
}
