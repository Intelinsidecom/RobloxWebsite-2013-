using System;
using System.Collections.Generic;
using Roblox.Collections;

namespace Roblox.Platform.Throttling;

public class Throttler : IThrottler
{
	private static IActionExecutionLog _LocalActionExecutionLog;

	public Throttler(ExpirableDictionary<string, LinkedList<DateTime>> expirableDictionary, Action<Exception> exceptionHandler)
	{
		_LocalActionExecutionLog = new LocalActionExecutionLog(expirableDictionary, exceptionHandler);
	}

	public bool IsRequestAllowed(IRequest request)
	{
		long allowedBudgetAmount = request.GetBudget();
		string lookupKey = request.GetKey();
		TimeSpan expirationInterval = request.GetExpirationInterval();
		return _LocalActionExecutionLog.IsRequestAllowed(lookupKey, allowedBudgetAmount, expirationInterval);
	}

	public void RecordRequest(IRequest request, DateTime executionDateTimeInUtc)
	{
		string lookupKey = request.GetKey();
		TimeSpan expirationInterval = request.GetExpirationInterval();
		_LocalActionExecutionLog.AddEntry(lookupKey, executionDateTimeInUtc, expirationInterval);
	}
}
