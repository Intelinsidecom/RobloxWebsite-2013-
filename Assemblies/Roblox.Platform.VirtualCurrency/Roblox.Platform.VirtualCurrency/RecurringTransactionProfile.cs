using System;

namespace Roblox.Platform.VirtualCurrency;

public class RecurringTransactionProfile : IRecurringTransactionProfile
{
	public string Id { get; set; }

	public byte CurrencyTypeId { get; set; }

	public DateTime RecurrenceStartDate { get; set; }

	public DateTime RecurrenceEndDate { get; set; }

	public int CurrencyHolderTypeId { get; set; }

	public long CurrencyHolderTargetId { get; set; }

	public byte TransactionTypeId { get; set; }

	public long Amount { get; set; }

	public bool IsRecurrenceActive { get; set; }
}
