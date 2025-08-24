using System;
using Roblox.Platform.Core;
using Roblox.Platform.IpAddresses.Properties;

namespace Roblox.Platform.IpAddresses;

public class SuspiciousIpChecker : ISuspiciousIpChecker
{
	private IAccountIpAddressCardinalityDetector _AccountIpAddressCardinalityDetector;

	private Func<int> _SuspiciousIpAddressCardinalityThreshold;

	public SuspiciousIpChecker(IpAddressDomainFactories factories)
		: this(new AccountIpAddressCardinalityDetector(factories), () => Settings.Default.SuspiciousIpAddressCardinalityThreshold)
	{
	}

	internal SuspiciousIpChecker(IAccountIpAddressCardinalityDetector detector, Func<int> suspiciousIpAddressCardinalityThreshold)
	{
		_AccountIpAddressCardinalityDetector = detector.AssignOrThrowIfNull("detector");
		_SuspiciousIpAddressCardinalityThreshold = suspiciousIpAddressCardinalityThreshold.AssignOrThrowIfNull("suspiciousIpAddressCardinalityThreshold");
	}

	public bool IsSuspicious(string ipAddress)
	{
		return _AccountIpAddressCardinalityDetector.IsCardinalityGreaterThanThreshold(ipAddress, _SuspiciousIpAddressCardinalityThreshold());
	}
}
