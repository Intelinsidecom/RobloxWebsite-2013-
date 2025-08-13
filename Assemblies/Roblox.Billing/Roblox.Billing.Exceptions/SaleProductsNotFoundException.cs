using System;

namespace Roblox.Billing.Exceptions;

public class SaleProductsNotFoundException : ApplicationException
{
	public SaleProductsNotFoundException(string message)
		: base(message)
	{
	}
}
