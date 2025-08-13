using System;

namespace Roblox.Configuration.Client;

public interface ISetting
{
	string Comment { get; set; }

	string GroupName { get; set; }

	int Id { get; set; }

	bool IsEnvironmentSpecific { get; set; }

	bool IsMasked { get; set; }

	bool IsValueSameForAllTestEnvironments { get; set; }

	bool IsValueUniqueForProduction { get; set; }

	string Name { get; set; }

	string Type { get; set; }

	DateTime Updated { get; set; }

	string Value { get; set; }

	string ValueUri { get; set; }
}
