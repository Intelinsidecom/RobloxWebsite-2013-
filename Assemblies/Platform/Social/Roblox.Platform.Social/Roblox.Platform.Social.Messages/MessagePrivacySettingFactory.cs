using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Messages;

internal class MessagePrivacySettingFactory : IMessagePrivacySettingFactory
{
	private readonly IMessagePrivacySettingEntityFactory _EntityFactory;

	public MessagePrivacySettingFactory(IMessagePrivacySettingEntityFactory entityFactory)
	{
		_EntityFactory = entityFactory ?? throw new ArgumentNullException("entityFactory");
	}

	public IMessagePrivacySetting GetOrCreate(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		IMessagePrivacySettingEntity entity = _EntityFactory.GetOrCreate(user);
		return Translate(entity, user);
	}

	internal virtual IMessagePrivacySetting Translate(IMessagePrivacySettingEntity entity, IUser user)
	{
		return new MessagePrivacySetting(_EntityFactory, user, entity.PrivacyType);
	}
}
