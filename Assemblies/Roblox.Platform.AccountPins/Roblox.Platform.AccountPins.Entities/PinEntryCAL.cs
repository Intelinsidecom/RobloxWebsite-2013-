using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching.Shared;
using Roblox.Platform.AccountPins.Properties;

namespace Roblox.Platform.AccountPins.Entities;

[ExcludeFromCodeCoverage]
internal class PinEntryCAL
{
	private PinEntryRecord _EntityRecord;

	private readonly ISharedCacheClient _SharedCacheClient;

	private readonly TimeSpan _DefaultExpiration;

	private string _CacheKey => ConstructKey(AccountID, SessionString);

	public long PinHashID
	{
		get
		{
			return _EntityRecord.PinHashID;
		}
		set
		{
			_EntityRecord.PinHashID = value;
		}
	}

	public long AccountID
	{
		get
		{
			return _EntityRecord.AccountID;
		}
		set
		{
			_EntityRecord.AccountID = value;
		}
	}

	public string SessionString
	{
		get
		{
			return _EntityRecord.SessionString;
		}
		set
		{
			_EntityRecord.SessionString = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityRecord.Created;
		}
		set
		{
			_EntityRecord.Created = value;
		}
	}

	public PinEntryCAL(ISharedCacheClient cacheClient)
		: this(new PinEntryRecord(), cacheClient)
	{
	}

	public PinEntryCAL(PinEntryRecord entityRecord, ISharedCacheClient cacheClient)
	{
		_SharedCacheClient = cacheClient;
		_EntityRecord = entityRecord;
		_DefaultExpiration = Settings.Default.PinEntryExpiration;
	}

	internal void Save()
	{
		_SharedCacheClient.Set(_CacheKey, _EntityRecord, _DefaultExpiration);
	}

	internal void Delete()
	{
		_SharedCacheClient.Delete(_CacheKey);
	}

	public void Construct(PinEntryRecord dal)
	{
		_EntityRecord = dal;
	}

	public static PinEntryCAL Get(long accountId, string sessionString, ISharedCacheClient sharedCacheClient)
	{
		string cacheKey = ConstructKey(accountId, sessionString);
		if (!sharedCacheClient.Query(cacheKey, out PinEntryRecord entityDal))
		{
			return null;
		}
		return new PinEntryCAL(entityDal, sharedCacheClient);
	}

	private static string GetLookupCacheKeysByUserID(long accountId, string sessionString)
	{
		return $"AccountID:{accountId}_Session:{sessionString}";
	}

	private static string ConstructKey(long accountId, string sessionString)
	{
		return "AccountPinEntry_" + GetLookupCacheKeysByUserID(accountId, sessionString);
	}
}
