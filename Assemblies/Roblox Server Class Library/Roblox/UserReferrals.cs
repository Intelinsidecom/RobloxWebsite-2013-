using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Properties;

namespace Roblox;

[Serializable]
public class UserReferrals : IEquatable<UserReferrals>, IRobloxEntity<int, UserReferralsDAL>, ICacheableObject<int>, ICacheableObject
{
	private UserReferralsDAL _EntityDAL;

	public static string BCAward = "BCAward";

	public static string FriendAward = "FriendAward";

	public int ID => _EntityDAL.ID;

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	public long ReferrerID
	{
		get
		{
			return _EntityDAL.ReferrerID;
		}
		set
		{
			_EntityDAL.ReferrerID = value;
		}
	}

	public string Type
	{
		get
		{
			return _EntityDAL.Type;
		}
		set
		{
			_EntityDAL.Type = value;
		}
	}

	public DateTime Time => _EntityDAL.Time;

	public bool Awarded
	{
		get
		{
			return _EntityDAL.Awarded;
		}
		set
		{
			_EntityDAL.Awarded = value;
		}
	}

	public static int BCReferralRewardinRobux => Settings.Default.BCReferralRewardinRobux;

	public static bool BCReferralRewardsEnabled => Settings.Default.BCReferralRewardsEnabled;

	public static bool FriendReferralRewardsEnabled => Settings.Default.FriendReferralRewardsEnabled;

	public static string BCReferralRewardDescription => Settings.Default.BCReferralRewardDescription;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static CacheInfo EntityCacheInfo => new CacheInfo("UserReferrals");

	public UserReferrals()
	{
		_EntityDAL = new UserReferralsDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Time = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Time = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static UserReferrals DoGetByUserIDAndType(long userID, string type)
	{
		return EntityHelper.DoGetByLookup<int, UserReferralsDAL, UserReferrals>(() => UserReferralsDAL.GetByUserIDAndType(userID, type), $"UserID:{userID}_Type:{type}");
	}

	public static UserReferrals GetByUserIDAndType(long userID, string type)
	{
		return EntityHelper.GetEntityByLookupOld<int, UserReferrals>(EntityCacheInfo, $"UserID:{userID}_Type:{type}", () => DoGetByUserIDAndType(userID, type));
	}

	public static string GetReferralCode(long userID)
	{
		char[] referralCodeNumbers = (userID * 17 + 1337).ToString().ToCharArray();
		int codeLength = referralCodeNumbers.Length;
		string referralCode = "";
		for (int i = 0; i < codeLength; i++)
		{
			if ((i + 1) % 3 == 0)
			{
				referralCode += "-";
			}
			referralCode += referralCodeNumbers[i];
		}
		return referralCode;
	}

	public static long GetUserIDByReferralCode(string referralCode)
	{
		return (Convert.ToInt64(referralCode.Replace("-", "")) - 1337) / 17;
	}

	public bool Equals(UserReferrals other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(UserReferralsDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add($"UserID:{UserID}_Type:{Type}");
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
