using Roblox.FloodCheckers.Core;
using Roblox.Platform.IpAddresses;

namespace Roblox.Platform.Floodcheckers;

public class AccountCreationWithIpDiscretionFloodChecker : IFloodChecker, IBasicFloodChecker
{
	private IFloodChecker _AccountCreationFloodChecker;

	private IFloodChecker _AccountCreationFloodCheckerForSuspiciousIps;

	private ISuspiciousIpChecker _SuspiciousIpChecker;

	private string _IpAddress;

	public AccountCreationWithIpDiscretionFloodChecker(IFloodChecker accountCreationFloodChecker, IFloodChecker accountCreationFloodCheckerForSuspiciousIps, ISuspiciousIpChecker suspiciousIpChecker, string ipAddress)
	{
		_AccountCreationFloodChecker = accountCreationFloodChecker;
		_AccountCreationFloodCheckerForSuspiciousIps = accountCreationFloodCheckerForSuspiciousIps;
		_SuspiciousIpChecker = suspiciousIpChecker;
		_IpAddress = ipAddress;
	}

	public IFloodCheckerStatus Check()
	{
		IFloodCheckerStatus status = _AccountCreationFloodChecker.Check();
		if (status.IsFlooded)
		{
			return status;
		}
		IFloodCheckerStatus suspiciousIpStatus = _AccountCreationFloodCheckerForSuspiciousIps.Check();
		if (suspiciousIpStatus.Count > 0)
		{
			return suspiciousIpStatus;
		}
		return status;
	}

	public int GetCount()
	{
		return Check().Count;
	}

	public int GetCountOverLimit()
	{
		return Check().CountOverLimit;
	}

	public bool IsFlooded()
	{
		return Check().IsFlooded;
	}

	public void Reset()
	{
		if (_SuspiciousIpChecker.IsSuspicious(_IpAddress))
		{
			_AccountCreationFloodCheckerForSuspiciousIps.Reset();
		}
		else
		{
			_AccountCreationFloodChecker.Reset();
		}
	}

	public void UpdateCount()
	{
		if (_SuspiciousIpChecker.IsSuspicious(_IpAddress))
		{
			_AccountCreationFloodCheckerForSuspiciousIps.UpdateCount();
		}
		else
		{
			_AccountCreationFloodChecker.UpdateCount();
		}
	}
}
