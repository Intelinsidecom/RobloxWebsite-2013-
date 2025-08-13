using System;
using System.Collections.Generic;
using Roblox.Collections;

namespace Roblox.Platform.Throttling;

internal class LocalActionExecutionLog : IActionExecutionLog
{
	private readonly ExpirableDictionary<string, LinkedList<DateTime>> _RequestExecutionLogs;

	private readonly object _LinkedListAccessLock = new object();

	public LocalActionExecutionLog(ExpirableDictionary<string, LinkedList<DateTime>> expirableDictionary, Action<Exception> exceptionHandler)
	{
		_RequestExecutionLogs = expirableDictionary;
		_RequestExecutionLogs.ExceptionOccurred += exceptionHandler;
	}

	public void AddEntry(string executionKey, DateTime executionDateTime, TimeSpan entryExpirationInterval)
	{
		LinkedList<DateTime> executionLogs = _RequestExecutionLogs.GetOrAdd(executionKey, (string s) => new LinkedList<DateTime>());
		lock (_LinkedListAccessLock)
		{
			executionLogs.AddLast(executionDateTime);
		}
	}

	public bool IsRequestAllowed(string executionKey, long allowedBudgetAmount, TimeSpan expirationInterval)
	{
		DateTime expirationDateTime = DateTime.UtcNow.Subtract(expirationInterval);
		LinkedList<DateTime> requestExecutionTimeStampList = _RequestExecutionLogs.Get(executionKey);
		if (requestExecutionTimeStampList == null)
		{
			return allowedBudgetAmount > 0;
		}
		if (requestExecutionTimeStampList.Count < allowedBudgetAmount)
		{
			return true;
		}
		lock (_LinkedListAccessLock)
		{
			LinkedListNode<DateTime> currentNode = requestExecutionTimeStampList.First;
			while (currentNode != null && currentNode.Value < expirationDateTime)
			{
				LinkedListNode<DateTime> next = currentNode.Next;
				requestExecutionTimeStampList.Remove(currentNode);
				currentNode = next;
			}
			return requestExecutionTimeStampList.Count < allowedBudgetAmount;
		}
	}
}
