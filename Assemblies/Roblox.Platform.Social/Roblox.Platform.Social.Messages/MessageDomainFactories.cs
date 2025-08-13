using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Messages;

/// <summary>
/// Common factories necessary for interacting with the Messages system
/// </summary>
public class MessageDomainFactories
{
	public IMessagePrivacySettingFactory MessagePrivacySettingFactory { get; }

	public IMessagePrivacyAuthority MessagePrivacyAuthority { get; }

	public MessageDomainFactories(IFriendshipFactory friendshipFactory, IUserFactory userFactory)
	{
		if (friendshipFactory == null)
		{
			throw new ArgumentNullException("friendshipFactory");
		}
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		MessagePrivacySettingEntityFactory privacySettingEntityFactory = new MessagePrivacySettingEntityFactory();
		MessagePrivacyAuthority = new MessagePrivacyAuthority(friendshipFactory, userFactory, MessagePrivacySettingFactory = new MessagePrivacySettingFactory(privacySettingEntityFactory));
	}
}
