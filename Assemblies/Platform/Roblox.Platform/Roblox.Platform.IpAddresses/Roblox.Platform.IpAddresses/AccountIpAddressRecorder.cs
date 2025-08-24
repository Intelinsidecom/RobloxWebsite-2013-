using System;

namespace Roblox.Platform.IpAddresses;

public class AccountIpAddressRecorder : IAccountIpAddressRecorder
{
	private readonly IpAddressDomainFactories _IpAddressDomainFactories;

	public AccountIpAddressRecorder(IpAddressDomainFactories ipAddressDomainFactories)
	{
		_IpAddressDomainFactories = ipAddressDomainFactories ?? throw new ArgumentNullException("ipAddressDomainFactories");
	}

	public void RecordAccountIpAddressEntity(long accountId, string userHostAddress)
	{
		if (accountId != 0L && !string.IsNullOrEmpty(userHostAddress))
		{
			IIpAddressEntity ipAddressEntity = _IpAddressDomainFactories.IpAddressEntityFactory.GetOrCreate(userHostAddress);
			_IpAddressDomainFactories.AccountIpAddressEntityFactory.GetOrCreate(accountId, ipAddressEntity.Id).RecordSeen();
		}
	}

	public void RecordHostAddressInBackground(long accountId, string userHostAddress)
	{
		if (accountId != 0L && !string.IsNullOrEmpty(userHostAddress))
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				RecordAccountIpAddressEntity(accountId, userHostAddress);
			});
		}
	}
}
