using System;

namespace Roblox.Platform.VirtualCurrency;

public interface IRecurringTransactionProfile
{
	string Id { get; set; }

	byte CurrencyTypeId { get; set; }

	DateTime RecurrenceStartDate { get; set; }

	DateTime RecurrenceEndDate { get; set; }

	int CurrencyHolderTypeId { get; set; }

	long CurrencyHolderTargetId { get; set; }

	byte TransactionTypeId { get; set; }

	long Amount { get; set; }

	bool IsRecurrenceActive { get; set; }
}
