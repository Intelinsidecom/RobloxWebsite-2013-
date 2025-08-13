using System;

namespace Roblox.Configuration;

public interface ISetting
{
	int Id { get; }

	string GroupName { get; }

	string Name { get; }

	string Type { get; }

	string Value { get; }

	string Comment { get; }

	bool IsEnvironmentSpecific { get; }

	DateTime Updated { get; }

	bool IsMasked { get; }
}
