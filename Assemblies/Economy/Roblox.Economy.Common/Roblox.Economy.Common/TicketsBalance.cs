using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Data.Interfaces;

namespace Roblox.Economy.Common;

public class TicketsBalance : IRobloxEntity<int, TicketsBalanceDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	public int ID => 0;

	public long UserID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public long Value
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public DateTime Created => DateTime.Now;

	public DateTime Updated => DateTime.Now;

	public CacheInfo CacheInfo => null;

	public void Credit(long amount)
	{
	}

	public bool TryDebit(long amount)
	{
		return false;
	}

	private static TicketsBalance DoGetOrCreate(long userId)
	{
		return new TicketsBalance
		{
			Value = 0L
		};
	}

	public static TicketsBalance GetOrCreate(long userId)
	{
		return new TicketsBalance
		{
			Value = 0L
		};
	}

	public static TicketsBalance Get(int id)
	{
		return new TicketsBalance
		{
			Value = 0L
		};
	}

	public void Construct(TicketsBalanceDAL dal)
	{
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		return new List<string>();
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return null;
	}
}
