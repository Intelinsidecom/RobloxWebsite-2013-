using System.Runtime.Serialization;
using Roblox.PremiumFeatures.Models.Enums;

namespace Roblox.PremiumFeatures.Models.Core;

/// <summary>
/// Currency Model
/// </summary>
[DataContract]
public class Currency
{
	/// <summary>
	/// ID
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = true, IsRequired = true)]
	public byte Id { get; }

	/// <summary>
	/// Type of Currency
	/// </summary>
	[DataMember(Name = "currencyType", EmitDefaultValue = true, IsRequired = true)]
	public CurrencyType CurrencyType { get; }

	/// <summary>
	/// Full name of Currency Type
	/// </summary>
	[DataMember(Name = "currencyName", EmitDefaultValue = true, IsRequired = true)]
	public string CurrencyName { get; }

	/// <summary>
	/// Currency Symbol
	/// </summary>
	[DataMember(Name = "currencySymbol", EmitDefaultValue = true, IsRequired = true)]
	public string CurrencySymbol { get; }

	/// <summary>
	/// Creates a Currency Object
	/// </summary>
	/// <param name="id"></param>
	/// <param name="currencyName"></param>
	/// <param name="currencyType"></param>
	/// <param name="currencySymbol"></param>
	public Currency(byte id, string currencyName, CurrencyType currencyType, string currencySymbol)
	{
		Id = id;
		CurrencyName = currencyName;
		CurrencyType = currencyType;
		CurrencySymbol = currencySymbol;
	}
}
