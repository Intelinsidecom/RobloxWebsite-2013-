using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Data;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Properties;

namespace Roblox.Platform.Social.Messages;

internal class MessagePrivacySetting : IMessagePrivacySetting
{
	internal IMessagePrivacySettingEntityFactory _EntityFactory { get; }

	[ExcludeFromCodeCoverage]
	internal virtual byte _13MinusDefaultPrivacy => Settings.Default.DefaultUnder13MessagePrivacySetting;

	public IUser User { get; }

	public MessagePrivacyType MessagePrivacyType { get; private set; }

	public MessagePrivacySetting(IMessagePrivacySettingEntityFactory entityFactory, IUser user, MessagePrivacyType privacyType)
	{
		_EntityFactory = entityFactory ?? throw new ArgumentNullException("entityFactory");
		User = user ?? throw new ArgumentNullException("user");
		MessagePrivacyType = privacyType;
	}

	public virtual void UpdatePrivacyType(MessagePrivacyType newPrivacyType)
	{
		if (IsValid(newPrivacyType) && newPrivacyType != MessagePrivacyType)
		{
			IMessagePrivacySettingEntity obj = _EntityFactory.GetOrCreate(User) ?? throw new DataIntegrityException($"Attempting to save null entity for user {User.Id}!");
			obj.PrivacyType = newPrivacyType;
			obj.Save();
			MessagePrivacyType = newPrivacyType;
		}
	}

	public void Sanitize()
	{
		if (!IsValid(MessagePrivacyType))
		{
			UpdatePrivacyType(GetDefaultPrivacyType());
		}
	}

	internal virtual bool IsValid(MessagePrivacyType newPrivacyType)
	{
		if (User.IsUnder13())
		{
			if ((uint)(newPrivacyType - 1) <= 2u)
			{
				return true;
			}
			return false;
		}
		if ((uint)newPrivacyType <= 3u || (uint)(newPrivacyType - 5) <= 1u)
		{
			return true;
		}
		return false;
	}

	private MessagePrivacyType GetDefaultPrivacyType()
	{
		if (User.IsUnder13())
		{
			return (MessagePrivacyType)_13MinusDefaultPrivacy;
		}
		return MessagePrivacyType.All;
	}
}
