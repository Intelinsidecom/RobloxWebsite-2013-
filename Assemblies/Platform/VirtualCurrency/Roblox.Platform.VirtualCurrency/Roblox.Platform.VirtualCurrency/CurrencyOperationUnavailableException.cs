using System;

namespace Roblox.Platform.VirtualCurrency;

public class CurrencyOperationUnavailableException : Exception
{
	public string PublicMessage { get; set; }

	public CurrencyOperationUnavailableException(string publicMessage, Exception innerException = null)
		: base(publicMessage, innerException)
	{
		PublicMessage = publicMessage;
	}
}
