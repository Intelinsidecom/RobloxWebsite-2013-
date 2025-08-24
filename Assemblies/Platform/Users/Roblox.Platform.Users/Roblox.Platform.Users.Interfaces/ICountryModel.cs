using System;

namespace Roblox.Users.Interfaces;

public interface ICountryModel
{
	byte ID { get; }

	string Value { get; }

	string Code { get; }

	bool Active { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
