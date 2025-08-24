using System;

namespace Roblox.Platform.Throttling;

internal interface IActionExecutionLog
{
	void AddEntry(string executionKey, DateTime executionDateTime, TimeSpan entryExpirationInterval);

	bool IsRequestAllowed(string executionKey, long allowedBudgetAmount, TimeSpan expirationInterval);
}
