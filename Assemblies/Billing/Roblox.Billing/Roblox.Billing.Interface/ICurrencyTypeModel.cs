using System;

namespace Roblox.Billing.Interface;

/// <summary>
/// Interface for CurrencyTypeModel
/// </summary>
public interface ICurrencyTypeModel
{
	byte ID { get; }

	string Name { get; set; }

	string Code { get; set; }

	DateTime Created { get; }

	DateTime Updated { get; }

	string Symbol { get; set; }
}
