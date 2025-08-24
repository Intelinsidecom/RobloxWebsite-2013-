using System;

namespace Roblox.Platform.Billing;

public class FraudDetectedException : ApplicationException
{
	public FraudDetectedException(string message)
		: base(message)
	{
	}
}
