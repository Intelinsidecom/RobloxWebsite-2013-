using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Economy;
using Roblox.Properties;

namespace Roblox;

public static class GroupManagementProperties
{
	public static readonly int maximumNumberOfPlacesPerGroup = 1;

	public static int UserGroupJoinLimit => Settings.Default.UserGroupJoinLimit;

	public static int BCUserGroupJoinLimit => Settings.Default.BCUserGroupJoinLimit;

	public static int TBCUserGroupJoinLimit => Settings.Default.TBCUserGroupJoinLimit;

	public static int OBCUserGroupJoinLimit => Settings.Default.OBCUserGroupJoinLimit;

	public static int PremiumUserGroupJoinLimit => Settings.Default.PremiumUserGroupJoinLimit;

	public static int UserGroupCreateLimit => Settings.Default.UserGroupCreateLimit;

	public static int BCUserGroupCreateLimit => Settings.Default.BCUserGroupCreateLimit;

	public static int TBCUserGroupCreateLimit => Settings.Default.TBCUserGroupCreateLimit;

	public static int OBCUserGroupCreateLimit => Settings.Default.OBCUserGroupCreateLimit;

	public static int PremiumUserGroupCreateLimit => Settings.Default.PremiumUserGroupCreateLimit;

	public static int CostToCreateGroupInRobux => Settings.Default.CostToCreateGroupInRobux;

	public static bool BuildInstanceInfoOnGroupPage
	{
		get
		{
			return Settings.Default.BuildInstanceInfoOnGroupPage;
		}
		set
		{
			if (Settings.Default.BuildInstanceInfoOnGroupPage != value)
			{
				Settings.Default["BuildInstanceInfoOnGroupPage"] = value;
				Settings.Default.Save();
			}
		}
	}

	public static bool BCOnlyGroupBuilding
	{
		get
		{
			return Settings.Default.BCOnlyGroupBuilding;
		}
		set
		{
			if (Settings.Default.BCOnlyGroupBuilding != value)
			{
				Settings.Default["BCOnlyGroupBuilding"] = value;
				Settings.Default.Save();
			}
		}
	}

	public static bool GroupBuildingEnabled
	{
		get
		{
			return Settings.Default.GroupBuildingEnabled;
		}
		set
		{
			if (Settings.Default.GroupBuildingEnabled != value)
			{
				Settings.Default["GroupBuildingEnabled"] = value;
				Settings.Default.Save();
			}
		}
	}

	public static string BuildToolAssetList
	{
		get
		{
			return Settings.Default.BuildToolAssetList;
		}
		set
		{
			if (Settings.Default.BuildToolAssetList != value)
			{
				Settings.Default["BuildToolAssetList"] = value;
				Settings.Default.Save();
			}
		}
	}

	public static long CostToCreateRoleSetInRobux
	{
		get
		{
			return (Product.GroupRoleSet ?? throw new ApplicationException("No groupRoleSetProduct exists")).PriceInRobux.Value;
		}
		set
		{
			Product groupRoleSetProduct = Product.GroupRoleSet;
			if (groupRoleSetProduct == null)
			{
				throw new ApplicationException("No groupRoleSetProduct exists");
			}
			if (groupRoleSetProduct.PriceInRobux.Value != value)
			{
				groupRoleSetProduct.PriceInRobux = value;
				groupRoleSetProduct.Save();
			}
		}
	}

	public static List<long> BuildingWithFriendsStartingEnvironmentAssetIDs
	{
		get
		{
			string[] array = Settings.Default.BuildingWithFriendsStartingEnvironmentAssetIDs.Split(',');
			List<long> ids = new List<long>();
			string[] array2 = array;
			foreach (string str in array2)
			{
				ids.Add(long.Parse(str));
			}
			return ids;
		}
		set
		{
			string newString = value.Cast<string>().Aggregate((string a, string b) => a + "," + b);
			if (Settings.Default.BuildingWithFriendsStartingEnvironmentAssetIDs != newString)
			{
				Settings.Default["BuildingWithFriendsStartingEnvironmentAssetIDs"] = newString;
				Settings.Default.Save();
			}
		}
	}

	public static int MaximumNumberOfGroupRoleSets
	{
		get
		{
			return Settings.Default.MaximumNumberOfGroupRoleSets;
		}
		set
		{
			if (Settings.Default.MaximumNumberOfGroupRoleSets != value)
			{
				Settings.Default["MaximumNumberOfGroupRoleSets"] = value;
				Settings.Default.Save();
			}
		}
	}
}
