using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;

namespace Roblox.Platform.Social.Messages;

internal class SendMessageFloodChecker : IFloodChecker, IBasicFloodChecker
{
	private readonly IFloodChecker _ByIpFloodChecker;

	private readonly IFloodChecker _ByUserFloodChecker;

	public SendMessageFloodChecker(long userId, string ipAddress)
	{
		_ByIpFloodChecker = new SendMessageFloodCheckerByIp(ipAddress);
		_ByUserFloodChecker = new SendMessageFloodCheckerByUser(userId);
	}

	public IFloodCheckerStatus Check()
	{
		IFloodCheckerStatus byUserCheck = _ByUserFloodChecker.Check();
		if (byUserCheck.IsFlooded)
		{
			return byUserCheck;
		}
		IFloodCheckerStatus byIpCheck = _ByIpFloodChecker.Check();
		if (byIpCheck.IsFlooded)
		{
			return byIpCheck;
		}
		return byUserCheck;
	}

	public int GetCount()
	{
		IFloodCheckerStatus byUserCheck = _ByUserFloodChecker.Check();
		if (byUserCheck.Count > 0)
		{
			return byUserCheck.Count;
		}
		IFloodCheckerStatus byIpCheck = _ByIpFloodChecker.Check();
		if (byIpCheck.Count > 0)
		{
			return byIpCheck.Count;
		}
		return byUserCheck.Count;
	}

	public int GetCountOverLimit()
	{
		IFloodCheckerStatus byUserCheck = _ByUserFloodChecker.Check();
		if (byUserCheck.CountOverLimit > 0)
		{
			return byUserCheck.CountOverLimit;
		}
		IFloodCheckerStatus byIpCheck = _ByIpFloodChecker.Check();
		if (byIpCheck.CountOverLimit > 0)
		{
			return byIpCheck.CountOverLimit;
		}
		return byUserCheck.CountOverLimit;
	}

	public bool IsFlooded()
	{
		return Check().IsFlooded;
	}

	public void Reset()
	{
		_ByUserFloodChecker.Reset();
		_ByIpFloodChecker.Reset();
	}

	public void UpdateCount()
	{
		_ByUserFloodChecker.UpdateCount();
		_ByIpFloodChecker.UpdateCount();
	}
}
