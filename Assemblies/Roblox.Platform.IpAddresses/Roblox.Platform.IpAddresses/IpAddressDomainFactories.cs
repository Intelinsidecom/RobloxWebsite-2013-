using Roblox.Platform.Core;

namespace Roblox.Platform.IpAddresses;

public class IpAddressDomainFactories : DomainFactoriesBase
{
	public virtual IAccountIpAddressEntityFactory AccountIpAddressEntityFactory { get; }

	public virtual IIpAddressEntityFactory IpAddressEntityFactory { get; }

	public IpAddressDomainFactories()
	{
		AccountIpAddressEntityFactory = new AccountIpAddressEntityFactory(this);
		IpAddressEntityFactory = new IpAddressEntityFactory(this);
	}
}
