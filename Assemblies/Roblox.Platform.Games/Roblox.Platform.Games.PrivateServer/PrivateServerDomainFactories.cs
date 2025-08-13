using System;
using Roblox.Platform.Privacy;

namespace Roblox.Platform.Games.PrivateServer;

/// <summary>
/// Domain factories for Private Servers
/// </summary>
public class PrivateServerDomainFactories
{
	public IPrivateServerPrivacySettingFactory PrivateServerPrivacySettingFactory { get; internal set; }

	public PrivateServerDomainFactories(IUserPrivacyAccessor userPrivacyAccessor)
	{
		if (userPrivacyAccessor == null)
		{
			throw new ArgumentNullException("userPrivacyAccessor");
		}
		PrivateServerPrivacySettingFactory = new PrivateServerPrivacySettingFactory(userPrivacyAccessor);
	}
}
