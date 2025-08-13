using System;
using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

public class CurrencyTypeModel : ICurrencyTypeModel
{
	public byte ID { get; }

	public string Name { get; set; }

	public string Code { get; set; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public string Symbol { get; set; }

	public CurrencyTypeModel(byte id, string name, string code, DateTime created, DateTime updated, string symbol)
	{
		ID = id;
		Name = name;
		Code = code;
		Created = created;
		Updated = updated;
		Symbol = symbol;
	}
}
