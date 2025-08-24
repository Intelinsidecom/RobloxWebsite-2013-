using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

/// <summary>
/// This is a wrapper for <see cref="T:Roblox.Billing.Business_Logic_Layer.CurrencyType" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public class CurrencyTypeFactory : ICurrencyTypeFactory
{
	public byte GetUSDCurrencyTypeID()
	{
		return CurrencyType.GetUSDCurrencyTypeID;
	}

	public ICurrencyTypeModel CreateNew(string name, string code, string symbol = null)
	{
		if (name == null)
		{
			throw new ArgumentNullException(name, "Currency name must not be null.");
		}
		if (code == null)
		{
			throw new ArgumentNullException(code, "Currency code must not be null.");
		}
		CurrencyType currencyType = CurrencyType.CreateNew(name, code, symbol);
		return EntityToModel(currencyType);
	}

	public ICurrencyTypeModel Get(byte id)
	{
		if (id == 0)
		{
			throw new ArgumentException("Invalid id");
		}
		CurrencyType currencyType = CurrencyType.Get(id);
		return EntityToModel(currencyType);
	}

	public ICurrencyTypeModel GetByCode(string code)
	{
		if (code == null)
		{
			throw new ArgumentNullException(code, "Currency code must not be null.");
		}
		CurrencyType currencyType = CurrencyType.GetByCode(code);
		return EntityToModel(currencyType);
	}

	public ICollection<ICurrencyTypeModel> GetAllCurrencyTypes()
	{
		return CurrencyType.GetAllCurrencyTypes().Select(EntityToModel).ToList();
	}

	public ICollection<ICurrencyTypeModel> GetCurrencyTypesPaged(byte startRowIndex, byte maximumRows)
	{
		return CurrencyType.GetCurrencyTypesPaged(startRowIndex, maximumRows).Select(EntityToModel).ToList();
	}

	private ICurrencyTypeModel EntityToModel(CurrencyType currencyType)
	{
		if (currencyType != null)
		{
			return new CurrencyTypeModel(currencyType.ID, currencyType.Name, currencyType.Code, currencyType.Created, currencyType.Updated, currencyType.Symbol);
		}
		return null;
	}
}
