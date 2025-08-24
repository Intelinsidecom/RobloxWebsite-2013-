namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Tracks the amount and transactions of a currency for a given holder.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyBudget" />
internal class PlatformCurrencyBudget : IPlatformCurrencyBudget
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	public long Id { get; private set; }

	/// <summary>
	/// Gets the budget value.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	public long Value { get; private set; }

	/// <summary>
	/// Gets the type of the currency budget.
	/// </summary>
	/// <value>
	/// The type of the currency budget.
	/// </value>
	public string CurrencyBudgetType { get; private set; }

	/// <summary>
	/// Gets the currency type identifier.
	/// </summary>
	/// <value>
	/// The currency type identifier.
	/// </value>
	public byte CurrencyTypeId { get; private set; }

	/// <summary>
	/// Gets the type of the currency holder.
	/// </summary>
	/// <value>
	/// The type of the currency holder.
	/// </value>
	public string CurrencyHolderType { get; private set; }

	/// <summary>
	/// Gets the currency holder target identifier.
	/// </summary>
	/// <value>
	/// The currency holder target identifier.
	/// </value>
	public long CurrencyHolderTargetId { get; private set; }

	private static ICurrencyBudgetFactory CurrencyBudgetFactory { get; set; }

	private static IPlatformCurrencyBudgetTypeFactory CurrencyBudgetTypeFactory { get; set; }

	private static IPlatformCurrencyHolderTypeFactory CurrencyHolderTypeFactory { get; set; }

	internal static IPlatformCurrencyBudgetTransactionTypeFactory PlatformCurrencyBudgetTransactionTypeFactory { get; set; }

	internal static IPlatformCurrencyBudgetTransactionFactory PlatformCurrencyBudgetTransactionFactory { get; set; }

	private void Init(ICurrencyBudget currencyBudgetEntity, ICurrencyBudgetFactory currencyBudgetFactory, IPlatformCurrencyBudgetTypeFactory currencyBudgetTypeFactory, IPlatformCurrencyHolderTypeFactory currencyHolderTypeFactory, IPlatformCurrencyBudgetTransactionTypeFactory currencyBudgetTransactionTypeFactory, IPlatformCurrencyBudgetTransactionFactory currencyBudgetTransactionFactory)
	{
		Id = currencyBudgetEntity.ID;
		Value = currencyBudgetEntity.Value;
		CurrencyTypeId = currencyBudgetEntity.CurrencyTypeID;
		CurrencyHolderTargetId = currencyBudgetEntity.CurrencyHolderTargetID;
		CurrencyBudgetFactory = currencyBudgetFactory;
		CurrencyHolderTargetId = currencyBudgetEntity.CurrencyHolderTargetID;
		CurrencyBudgetType = currencyBudgetTypeFactory.Get(currencyBudgetEntity.CurrencyBudgetTypeID).Value;
		CurrencyHolderType = currencyHolderTypeFactory.Get(currencyBudgetEntity.CurrencyHolderTypeID).Value;
		PlatformCurrencyBudgetTransactionTypeFactory = currencyBudgetTransactionTypeFactory;
		PlatformCurrencyBudgetTransactionFactory = currencyBudgetTransactionFactory;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CurrencyBudgets.PlatformCurrencyBudget" /> class.
	/// </summary>
	/// <param name="currencyBudgetEntity">The currency budget entity.</param>
	/// <param name="currencyBudgetFactory">The currency budget factory.</param>
	/// <param name="currencyBudgetTypeFactory">The currency budget type factory.</param>
	/// <param name="currencyHolderTypeFactory">The currency holder type factory.</param>
	/// <param name="CurrencyBudgetTransactionTypeFactory">The currency budget transaction type factory.</param>
	/// <param name="currencyBudgetTransactionFactory">The currency budget transaction factory.</param>
	internal PlatformCurrencyBudget(ICurrencyBudget currencyBudgetEntity, ICurrencyBudgetFactory currencyBudgetFactory, IPlatformCurrencyBudgetTypeFactory currencyBudgetTypeFactory, IPlatformCurrencyHolderTypeFactory currencyHolderTypeFactory, IPlatformCurrencyBudgetTransactionTypeFactory CurrencyBudgetTransactionTypeFactory, IPlatformCurrencyBudgetTransactionFactory currencyBudgetTransactionFactory)
	{
		Init(currencyBudgetEntity, currencyBudgetFactory, currencyBudgetTypeFactory, currencyHolderTypeFactory, CurrencyBudgetTransactionTypeFactory, currencyBudgetTransactionFactory);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CurrencyBudgets.PlatformCurrencyBudget" /> class.
	/// </summary>
	/// <param name="currencyBudgetEntity">The currency budget entity.</param>
	internal PlatformCurrencyBudget(ICurrencyBudget currencyBudgetEntity)
	{
		ICurrencyBudgetFactory currencyBudgetFactory = CurrencyBudgetFactory ?? new CurrencyBudgetFactory();
		IPlatformCurrencyBudgetTypeFactory currencyBudgetTypeFactory = CurrencyBudgetTypeFactory ?? new CurrencyBudgetTypeFactory();
		IPlatformCurrencyHolderTypeFactory currencyHolderTypeFactory = CurrencyHolderTypeFactory ?? new CurrencyHolderTypeFactory();
		IPlatformCurrencyBudgetTransactionTypeFactory currencyBudgetTransactionTypeFactory = PlatformCurrencyBudgetTransactionTypeFactory ?? new PlatformCurrencyBudgetTransactionTypeFactory();
		IPlatformCurrencyBudgetTransactionFactory currencyBudgetTransactionFactory = PlatformCurrencyBudgetTransactionFactory ?? new PlatformCurrencyBudgetTransactionFactory();
		Init(currencyBudgetEntity, currencyBudgetFactory, currencyBudgetTypeFactory, currencyHolderTypeFactory, currencyBudgetTransactionTypeFactory, currencyBudgetTransactionFactory);
	}

	/// <summary>
	/// Credits the specified amount to the CurrencyBudget.
	/// </summary>
	/// <param name="amount">The amount.</param>
	/// <param name="transactionType">Type of the transaction.</param>
	/// <param name="transactionTargetId">The transaction target identifier.</param>
	public void Credit(long amount, string transactionType, long transactionTargetId)
	{
		ICurrencyBudget currencyBudgetEntity = CurrencyBudgetFactory.Get(Id);
		currencyBudgetEntity.Credit(amount);
		Value = currencyBudgetEntity.Value;
		IPlatformCurrencyBudgetTransactionType currencyBudgetTransactionType = PlatformCurrencyBudgetTransactionTypeFactory.GetOrCreate(transactionType);
		PlatformCurrencyBudgetTransactionFactory.CreateNew(currencyBudgetEntity.ID, amount, currencyBudgetTransactionType.ID, transactionTargetId);
	}

	/// <summary>
	/// Tries to debit from the CurrencyBudget. Returns true if the debit succeeded, 
	/// false if there was not enough money in the CurrencyBudget to cover the amount.
	/// </summary>
	/// <param name="amount">The amount to debit.</param>
	/// <param name="transactionType">Type of transaction.</param>
	/// <param name="transactionTargetId">The transaction target identifier.</param>
	/// <returns>true if the debit succeeded, 
	/// false if the amount was greater than the current credit.</returns>
	public bool Debit(long amount, string transactionType, long transactionTargetId)
	{
		if (amount == 0L)
		{
			return true;
		}
		ICurrencyBudget currencyBudgetEntity = CurrencyBudgetFactory.Get(Id);
		bool num = currencyBudgetEntity.TryDebit(amount);
		Value = currencyBudgetEntity.Value;
		if (num)
		{
			IPlatformCurrencyBudgetTransactionType currencyBudgetTransactionType = PlatformCurrencyBudgetTransactionTypeFactory.GetOrCreate(transactionType);
			long delta = -1 * amount;
			PlatformCurrencyBudgetTransactionFactory.CreateNew(currencyBudgetEntity.ID, delta, currencyBudgetTransactionType.ID, transactionTargetId);
		}
		return num;
	}
}
