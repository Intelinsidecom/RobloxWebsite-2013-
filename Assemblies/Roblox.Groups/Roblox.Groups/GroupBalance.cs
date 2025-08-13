using System;
using Roblox.Currency.Client;

namespace Roblox.Groups;

public class GroupBalance
{
	private static ICurrencyAuthority _Client;

	public static ICurrencyAuthority Client
	{
		get
		{
			return _Client ?? throw new ApplicationException("Client for GroupBalance has not been initialized");
		}
		set
		{
			_Client = value;
		}
	}

	public static long GetRobuxBalance(long groupId)
	{
		long agentId = Group.Get(groupId).AgentID.GetValueOrDefault();
		return Client.GetRobuxBalance((long)Convert.ToInt32(agentId));
	}

	public static long CreditRobux(long groupId, long amount)
	{
		long agentId = Group.Get(groupId).AgentID.GetValueOrDefault();
		return Client.CreditRobux((long)Convert.ToInt32(agentId), amount);
	}

	public static bool TryDebitRobux(long groupId, long amount)
	{
		long agentId = Group.Get(groupId).AgentID.GetValueOrDefault();
		return Client.TryDebitRobux((long)Convert.ToInt32(agentId), amount);
	}
}
