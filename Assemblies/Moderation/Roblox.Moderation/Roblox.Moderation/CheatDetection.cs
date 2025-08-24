using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class CheatDetection : IRobloxEntity<long, CheatDetectionDAL>, ICacheableObject<long>, ICacheableObject
{
	public enum CheatType
	{
		[Description("Replication Honeypot")]
		ReplicationHoneypot = 2,
		[Description("Cheat Engine Detected")]
		CheatEngineDetected,
		[Description("Fiddler Process Detected")]
		FiddlerProcessDetected,
		[Description("Cheat Engine Process Detected")]
		CheatEngineProcessDetected,
		[Description("Bad Signature Detected")]
		BadSignatureDetected,
		[Description("Bad Hash Detected")]
		BadHashDetected,
		[Description("Script Memory Edited")]
		ScriptMemoryEdited,
		[Description("Script cmd bar hacked")]
		ScriptCmdBarHacked,
		SpeedHacked,
		DebuggerDetected,
		WrongPlayer,
		BadScriptReplicated
	}

	public enum ActionType
	{
		[Description("KICK")]
		Kick = 1,
		[Description("CHEAT")]
		Cheat
	}

	public const string CheatString = "CHEAT";

	public const string KickString = "KICK";

	private CheatDetectionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Moderation.CheatDetection", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public int CheatTypeDetected
	{
		get
		{
			return _EntityDAL.CheatTypeDetected;
		}
		set
		{
			_EntityDAL.CheatTypeDetected = value;
		}
	}

	public ActionType ActionTypePerformed
	{
		get
		{
			return (ActionType)_EntityDAL.ActionTypePerformed;
		}
		set
		{
			_EntityDAL.ActionTypePerformed = (int)value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string CheatTypeString()
	{
		foreach (CheatType type in Enum.GetValues(typeof(CheatType)))
		{
			if (type == (CheatType)CheatTypeDetected)
			{
				return type.ToDescription();
			}
		}
		return "Cheat " + CheatTypeDetected;
	}

	public string ActionTypeString()
	{
		foreach (ActionType type in Enum.GetValues(typeof(ActionType)))
		{
			if (type == ActionTypePerformed)
			{
				return type.ToDescription();
			}
		}
		return "ERROR: Bad Value_ActionTypePerformed: " + ActionTypePerformed;
	}

	public CheatDetection()
	{
		_EntityDAL = new CheatDetectionDAL();
	}

	private static CheatDetection CreateNew(long userId, int cheattypedetected, int actiontypeperformed)
	{
		CheatDetection cheatDetection = new CheatDetection();
		cheatDetection.UserID = userId;
		cheatDetection.CheatTypeDetected = cheattypedetected;
		cheatDetection.ActionTypePerformed = (ActionType)actiontypeperformed;
		cheatDetection.Save();
		return cheatDetection;
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static void LogAction(int cheatType, ActionType action, long userId)
	{
		CreateNew(userId, cheatType, (int)action);
	}

	public static void LogAction(CheatType cheat, ActionType action, long userId)
	{
		CreateNew(userId, (int)cheat, (int)action);
	}

	public static CheatDetection Get(long id)
	{
		return EntityHelper.GetEntity<long, CheatDetectionDAL, CheatDetection>(EntityCacheInfo, id, () => CheatDetectionDAL.Get(id));
	}

	public static ICollection<CheatDetection> GetCheatDetectionsByUserID_Paged(long userId, int startRowIndex, int maxRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), $"GetCheatDetections_UserID:{userId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}", () => CheatDetectionDAL.GetCheatDetectionIDsByUserID_Paged(userId, startRowIndex + 1, maxRows), Get);
	}

	public void Construct(CheatDetectionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}");
	}
}
