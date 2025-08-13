using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Roblox.Common;

namespace Roblox.PremiumFeatures;

public static class MembershipMigrationStateExtensions
{
	private static readonly Dictionary<MembershipMigrationState, string> mapping;

	static MembershipMigrationStateExtensions()
	{
		mapping = ((MembershipMigrationState[])Enum.GetValues(typeof(MembershipMigrationState))).ToDictionary((MembershipMigrationState v) => v, (MembershipMigrationState v) => v.GetAttribute<DescriptionAttribute>().Description);
	}

	public static string GetValue(this MembershipMigrationState state)
	{
		return mapping[state];
	}
}
