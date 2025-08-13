using System;

namespace Roblox.Billing;

public class BlockedPurchaseException : ApplicationException
{
	private byte _paymentStatusChangeReasonTypeID;

	public byte PaymentStatusChangeReasonTypeID => _paymentStatusChangeReasonTypeID;

	public BlockedPurchaseException(byte paymentStatusChangeReasonTypeID, string msg)
		: base(msg)
	{
		_paymentStatusChangeReasonTypeID = paymentStatusChangeReasonTypeID;
	}
}
