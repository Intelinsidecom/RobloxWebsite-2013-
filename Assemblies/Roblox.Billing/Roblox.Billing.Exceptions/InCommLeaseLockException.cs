using System;

namespace Roblox.Billing.Exceptions;

public class InCommLeaseLockException : ApplicationException
{
	public InCommLeaseLockException(string message)
		: base(message)
	{
	}
}
