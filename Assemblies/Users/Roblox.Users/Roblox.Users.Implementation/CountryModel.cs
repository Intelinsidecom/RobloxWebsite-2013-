using System;
using Roblox.Users.Interfaces;

namespace Roblox.Users.Implementation;

/// <summary>
/// This is the interface for CountryModel
/// </summary>
public class CountryModel : ICountryModel
{
	public byte ID { get; }

	public string Value { get; }

	public string Code { get; }

	public bool Active { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public CountryModel(byte id, string value, string code, bool active, DateTime created, DateTime updated)
	{
		ID = id;
		Value = value;
		Code = code;
		Active = active;
		Created = created;
		Updated = updated;
	}
}
