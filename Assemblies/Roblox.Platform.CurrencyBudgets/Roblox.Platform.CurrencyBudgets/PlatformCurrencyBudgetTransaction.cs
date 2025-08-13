using System;
using Roblox.Platform.CurrencyBudgets.Entities;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Tracks the amount and transactions of a currency for a given holder.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.ICurrencyBudgetTransaction" />
public class PlatformCurrencyBudgetTransaction : ICurrencyBudgetTransaction
{
	private static IPlatformCurrencyBudgetTransactionTypeFactory PlatformCurrencyBudgetTransactionTypeFactory { get; set; }

	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	public long Id { get; private set; }

	/// <summary>
	/// Gets the currency budget identifier.
	/// </summary>
	/// <value>
	/// The currency budget identifier.
	/// </value>
	public long CurrencyBudgetId { get; private set; }

	/// <summary>
	/// Gets the delta of the transaction.
	/// </summary>
	/// <value>
	/// The delta.
	/// </value>
	public long Delta { get; private set; }

	/// <summary>
	/// Gets the currency budget transaction type identifier.
	/// </summary>
	/// <value>
	/// The currency budget transaction type identifier.
	/// </value>
	public int CurrencyBudgetTransactionTypeId { get; private set; }

	/// <summary>
	/// Gets the type of the currency budget transaction.
	/// </summary>
	/// <value>
	/// The type of the currency budget transaction.
	/// </value>
	public string CurrencyBudgetTransactionType { get; private set; }

	/// <summary>
	/// Gets the currency budget transaction target identifier.
	/// </summary>
	/// <value>
	/// The currency budget transaction target identifier.
	/// </value>
	public long CurrencyBudgetTransactionTargetId { get; private set; }

	/// <summary>
	/// Gets the date and time this transaction happened.
	/// </summary>
	/// <value>
	/// The created.
	/// </value>
	public DateTime Created { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CurrencyBudgets.PlatformCurrencyBudgetTransaction" /> class.
	/// </summary>
	/// <param name="currencyBudgetTransactionEntity">The currency budget transaction entity.</param>
	/// <param name="platformCurrencyBudgetTransactionTypeFactory">The platform currency budget transaction type factory.</param>
	internal PlatformCurrencyBudgetTransaction(CurrencyBudgetTransaction currencyBudgetTransactionEntity, IPlatformCurrencyBudgetTransactionTypeFactory platformCurrencyBudgetTransactionTypeFactory = null)
	{
		PlatformCurrencyBudgetTransactionTypeFactory = platformCurrencyBudgetTransactionTypeFactory ?? PlatformCurrencyBudgetTransactionTypeFactory ?? new PlatformCurrencyBudgetTransactionTypeFactory();
		Id = currencyBudgetTransactionEntity.ID;
		CurrencyBudgetId = currencyBudgetTransactionEntity.CurrencyBudgetID;
		Delta = currencyBudgetTransactionEntity.Delta;
		CurrencyBudgetTransactionTypeId = currencyBudgetTransactionEntity.CurrencyBudgetTransactionTypeID;
		CurrencyBudgetTransactionTargetId = currencyBudgetTransactionEntity.CurrencyBudgetTransactionTargetID;
		Created = currencyBudgetTransactionEntity.Created;
		IPlatformCurrencyBudgetTransactionType currencyBudgetTransactionType = PlatformCurrencyBudgetTransactionTypeFactory.Get(CurrencyBudgetTransactionTypeId);
		CurrencyBudgetTransactionType = currencyBudgetTransactionType.Value;
	}

	/// <summary>
	/// Deletes this instance.
	/// </summary>
	public void Delete()
	{
		CurrencyBudgetTransaction.Get(Id)?.Delete();
	}
}
