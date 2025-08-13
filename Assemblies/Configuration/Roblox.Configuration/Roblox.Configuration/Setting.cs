using System;

namespace Roblox.Configuration;

internal class Setting : ISetting
{
	public int Id { get; set; }

	public string GroupName { get; set; }

	public string Name { get; set; }

	public string Type { get; set; }

	public string Value { get; set; }

	public string Comment { get; set; }

	public bool IsEnvironmentSpecific { get; set; }

	public DateTime Updated { get; set; }

	public bool IsMasked { get; set; }
}
