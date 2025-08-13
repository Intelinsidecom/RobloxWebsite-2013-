using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.EventLog;

namespace Roblox;

public class ExceptionHandler
{
	public class PresentableException : ApplicationException
	{
		public string PresentationErrorCode { get; }

		public string PresentationErrorMessage { get; }

		public string PresentationErrorTitle { get; }

		public PresentableException(string msg, string title = "Error with your request", string code = "", Exception ex = null)
			: base(msg, ex)
		{
			PresentationErrorMessage = msg;
			PresentationErrorCode = code;
			PresentationErrorTitle = title;
		}
	}

	public class GoogleTrackingException : ApplicationException
	{
		public string ErrorType { get; }

		public string ErrorMessage { get; }

		public string Url { get; }

		public GoogleTrackingException(string errorType, string msg, string errorPageUrl)
		{
			ErrorType = errorType;
			ErrorMessage = msg;
			Url = errorPageUrl;
		}
	}

	public enum PresentableSQLErrors
	{
		[Description("Search Query is malformed, please check the search terms and try your search again.")]
		SearchQueryMalformed = 7630
	}

	private static Dictionary<int, PresentableSQLErrors> PresentableSQLErrorList;

	private static List<IExceptionHandlerListener> listeners;

	static ExceptionHandler()
	{
		listeners = new List<IExceptionHandlerListener>();
		if (PresentableSQLErrorList != null)
		{
			return;
		}
		PresentableSQLErrorList = new Dictionary<int, PresentableSQLErrors>();
		foreach (PresentableSQLErrors err in Converters.EnumToList<PresentableSQLErrors>())
		{
			PresentableSQLErrorList.Add((int)err, err);
		}
	}

	public static void AddListener(IExceptionHandlerListener listener)
	{
		lock (listeners)
		{
			listeners.Add(listener);
		}
	}

	public static void RemoveListener(IExceptionHandlerListener listener)
	{
		lock (listeners)
		{
			listeners.Remove(listener);
		}
	}

	public static void LogException(string errorMessage)
	{
		LogException(new ApplicationException(errorMessage));
	}

	public static void LogException(Exception ex)
	{
		LogException(ex, LogLevel.Error);
	}

	public static void LogException(string errorMessage, LogLevel logLevel)
	{
		LogException(new ApplicationException(errorMessage), logLevel);
	}

	public static void LogException(Exception ex, LogLevel logLevel)
	{
		if (ex is NotLoggedException)
		{
			return;
		}
		try
		{
			WriteUsingLogger(ex, logLevel);
		}
		catch (UninitializedLoggerException)
		{
			throw new ExceptionHandlerUnregisteredLoggerException("ExceptionHandler failed to log because StaticLoggerRegistry was uninitialized. Exception that was being logged: ", ex);
		}
		foreach (IExceptionHandlerListener listener in listeners)
		{
			listener.ExceptionLogged();
		}
	}

	public static void HandleSQLException(SqlException eSQL)
	{
		if (PresentableSQLErrorList.TryGetValue(eSQL.Number, out var result))
		{
			PresentableException ex = new PresentableException(result.ToString(), result.ToDescription(), eSQL.Message, eSQL);
			LogException(ex, LogLevel.Warning);
			throw ex;
		}
		throw eSQL;
	}

	private static string GetInnerText(Exception ex)
	{
		if (ex.InnerException != null)
		{
			return GetInnerText(ex.InnerException);
		}
		return ex.ToString();
	}

	private static string GetText(Exception ex)
	{
		if (ex.InnerException != null)
		{
			return $"{ex}\n\nCaused by:\n{GetText(ex.InnerException)}";
		}
		return ex.ToString();
	}

	/// <exception cref="T:Roblox.EventLog.UninitializedLoggerException">Thrown when StaticLoggerRegistry.Instance is not registered</exception>
	private static void WriteUsingLogger(Exception exception, LogLevel logLevel)
	{
		ILogger logger = StaticLoggerRegistry.Instance;
		switch (logLevel)
		{
		case LogLevel.Error:
			logger.Error(exception);
			break;
		case LogLevel.Warning:
			logger.Warning(() => exception.ToString());
			break;
		case LogLevel.Information:
			logger.Info(() => exception.ToString());
			break;
		default:
			logger.Verbose(() => exception.ToString());
			break;
		}
	}
}
