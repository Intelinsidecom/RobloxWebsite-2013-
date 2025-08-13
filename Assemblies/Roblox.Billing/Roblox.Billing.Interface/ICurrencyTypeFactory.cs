using System.Collections.Generic;

namespace Roblox.Billing.Interface;

/// <summary>
/// This is the interface for a factory for <see cref="T:Roblox.Billing.Interface.ICurrencyTypeModel" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public interface ICurrencyTypeFactory
{
	byte GetUSDCurrencyTypeID();

	ICurrencyTypeModel CreateNew(string name, string code, string symbol = null);

	ICurrencyTypeModel Get(byte id);

	ICurrencyTypeModel GetByCode(string code);

	ICollection<ICurrencyTypeModel> GetAllCurrencyTypes();

	ICollection<ICurrencyTypeModel> GetCurrencyTypesPaged(byte startRowIndex, byte maximumRows);
}
