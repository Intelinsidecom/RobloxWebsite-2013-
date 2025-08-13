using System.ComponentModel;

namespace Roblox.Platform.Moderation;

public enum PunishmentType
{
	[Description("None")]
	None = 1,
	[Description("Remind")]
	Remind,
	[Description("Warn")]
	Warn,
	[Description("Ban 1 Day")]
	Ban1Day,
	[Description("Ban 3 Days")]
	Ban3Days,
	[Description("Ban 7 Days")]
	Ban7Days,
	[Description("Ban 14 Days")]
	Ban14Days,
	[Description("Delete")]
	Delete,
	[Description("Poison")]
	Poison
}
