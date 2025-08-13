using System;

namespace Roblox.Configuration.Client;

[Flags]
public enum SettingFlags
{
	None = 0,
	Masked = 1,
	EnvironmentSpecific = 2,
	ProductionUnique = 4,
	TestEnvironmentsMatch = 8
}
