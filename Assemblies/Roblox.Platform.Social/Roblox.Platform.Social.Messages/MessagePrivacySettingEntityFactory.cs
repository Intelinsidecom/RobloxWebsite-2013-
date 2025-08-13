using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Entities;

namespace Roblox.Platform.Social.Messages;

[ExcludeFromCodeCoverage]
internal class MessagePrivacySettingEntityFactory : IMessagePrivacySettingEntityFactory
{
	public IMessagePrivacySettingEntity GetOrCreate(IUser user)
	{
		UserMessagePrivacySetting entity = UserMessagePrivacySetting.GetOrCreate(user.Id);
		return new MessagePrivacySettingEntity(entity.ID, entity.UserID, (MessagePrivacyType)entity.MessagePrivacyTypeID);
	}
}
