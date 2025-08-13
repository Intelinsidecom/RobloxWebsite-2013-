using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Social.Entities;

namespace Roblox.Platform.Social.Messages;

[ExcludeFromCodeCoverage]
internal class MessagePrivacySettingEntity : IMessagePrivacySettingEntity
{
	public long Id { get; }

	public long UserId { get; }

	public MessagePrivacyType PrivacyType { get; set; }

	public MessagePrivacySettingEntity(long id, long userId, MessagePrivacyType privacyType)
	{
		Id = id;
		UserId = userId;
		PrivacyType = privacyType;
	}

	public void Save()
	{
		UserMessagePrivacySetting orCreate = UserMessagePrivacySetting.GetOrCreate(UserId);
		orCreate.MessagePrivacyTypeID = (UserMessagePrivacySetting.MessagePrivacyType)PrivacyType;
		orCreate.Save();
	}
}
