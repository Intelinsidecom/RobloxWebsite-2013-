using System.Collections.Generic;
using Roblox.Currency.Client;
using Roblox.Platform.Core;

namespace Roblox.Platform.VirtualCurrency;

/// <inheritdoc />
public class CurrencyBudgetAuthorityFactory : ICurrencyBudgetAuthorityFactory
{
	private readonly Dictionary<byte, ICurrencyBudgetAuthority> _PlatformToCurrencyBudgetAuthorityMap;

	private readonly ICurrencyBudgetAuthority _DefaultCurrencyBudgetAuthority;

	/// <summary>
	/// A constructor to initialize the <see cref="T:Roblox.Platform.VirtualCurrency.CurrencyBudgetAuthorityFactory" />.
	/// </summary>
	/// <param name="defaultCurrencyAuthority">The default <see cref="T:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority" /> to return when the platformTypeId is not registered with the factory.</param>
	public CurrencyBudgetAuthorityFactory(ICurrencyAuthority defaultCurrencyAuthority)
	{
		_PlatformToCurrencyBudgetAuthorityMap = new Dictionary<byte, ICurrencyBudgetAuthority>();
		if (defaultCurrencyAuthority == null)
		{
			throw new PlatformArgumentNullException("defaultCurrencyAuthority");
		}
		_DefaultCurrencyBudgetAuthority = new CurrencyOperations(defaultCurrencyAuthority);
	}

	/// <inheritdoc />
	public void Register(byte platformTypeId, ICurrencyBudgetAuthority currencyBudgetAuthority)
	{
		if (currencyBudgetAuthority == null)
		{
			throw new PlatformArgumentNullException("currencyBudgetAuthority");
		}
		_PlatformToCurrencyBudgetAuthorityMap.Add(platformTypeId, currencyBudgetAuthority);
	}

	/// <inheritdoc />
	public ICurrencyBudgetAuthority GetCurrencyBudgetAuthority(byte platformTypeId)
	{
		if (_PlatformToCurrencyBudgetAuthorityMap.TryGetValue(platformTypeId, out var currencyBudgetAuthority))
		{
			return currencyBudgetAuthority;
		}
		return _DefaultCurrencyBudgetAuthority;
	}
}
