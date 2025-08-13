using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Properties;

namespace Roblox.Platform.Social.Messages;

internal class MessagePrivacyAuthority : IMessagePrivacyAuthority
{
	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly IUserFactory _UserFactory;

	private readonly IMessagePrivacySettingFactory _SettingAccessor;

	public MessagePrivacyAuthority(IFriendshipFactory friendshipFactory, IUserFactory userFactory, IMessagePrivacySettingFactory privacySettingFactory)
	{
		_FriendshipFactory = friendshipFactory;
		_UserFactory = userFactory;
		_SettingAccessor = privacySettingFactory;
	}

	/// <summary>
	/// Determines whether or not a user is friends with another user.
	/// </summary>
	/// <param name="user">The first user.</param>
	/// <param name="friend">The user to check for friendship with.</param>
	/// <returns>Whether or not the UserMessagePrivacySetting's User is
	/// friends with the given user.</returns>
	protected virtual bool IsFriendsWith(IUser user, IUser friend)
	{
		return _FriendshipFactory.AreFriends(user.Id, friend.Id);
	}

	/// <summary>
	/// Determines whether or not a user is being followed another user.
	/// </summary>
	/// <param name="user">The first user.</param>
	/// <param name="followerUser">The user to check if they are following.</param>
	/// <returns>Whether or not the UserMessagePrivacySetting's User is
	/// being followed by the given user.</returns>
	protected virtual bool HasFollower(IUser user, IUser followerUser)
	{
		return _FriendshipFactory.HasFollower(user.Id, followerUser.Id);
	}

	public PrivacySettingsCheckResult CanSendMessage(IUser sender, IUser recipient)
	{
		if (sender == null)
		{
			return PrivacySettingsCheckResult.BadSender;
		}
		if (recipient == null)
		{
			return PrivacySettingsCheckResult.BadRecipient;
		}
		if (sender.Id == recipient.Id)
		{
			return PrivacySettingsCheckResult.SentToSelf;
		}
		if (sender.Id == Settings.Default.RobloxUserId)
		{
			return PrivacySettingsCheckResult.Passed;
		}
		try
		{
			switch (_SettingAccessor.GetOrCreate(recipient).MessagePrivacyType)
			{
			case MessagePrivacyType.Friends:
				if (!IsFriendsWith(sender, recipient))
				{
					return PrivacySettingsCheckResult.RecipientPrivacySettingsTooHigh;
				}
				break;
			case MessagePrivacyType.Following:
				if (!IsFriendsWith(sender, recipient) && !HasFollower(sender, recipient))
				{
					return PrivacySettingsCheckResult.RecipientPrivacySettingsTooHigh;
				}
				break;
			case MessagePrivacyType.Followers:
				if (!IsFriendsWith(sender, recipient) && !HasFollower(sender, recipient) && !HasFollower(recipient, sender))
				{
					return PrivacySettingsCheckResult.RecipientPrivacySettingsTooHigh;
				}
				break;
			case MessagePrivacyType.TopFriends:
				if (!IsFriendsWith(sender, recipient))
				{
					return PrivacySettingsCheckResult.RecipientPrivacySettingsTooHigh;
				}
				break;
			default:
				return PrivacySettingsCheckResult.RecipientPrivacySettingsTooHigh;
			case MessagePrivacyType.All:
				break;
			}
			switch (_SettingAccessor.GetOrCreate(sender).MessagePrivacyType)
			{
			case MessagePrivacyType.Friends:
				if (!IsFriendsWith(sender, recipient))
				{
					return PrivacySettingsCheckResult.SenderPrivacySettingsTooHigh;
				}
				break;
			case MessagePrivacyType.Following:
				if (!IsFriendsWith(sender, recipient) && !HasFollower(recipient, sender))
				{
					return PrivacySettingsCheckResult.SenderPrivacySettingsTooHigh;
				}
				break;
			case MessagePrivacyType.Followers:
				if (!IsFriendsWith(sender, recipient) && !HasFollower(sender, recipient) && !HasFollower(recipient, sender))
				{
					return PrivacySettingsCheckResult.SenderPrivacySettingsTooHigh;
				}
				break;
			case MessagePrivacyType.TopFriends:
				if (!IsFriendsWith(sender, recipient))
				{
					return PrivacySettingsCheckResult.SenderPrivacySettingsTooHigh;
				}
				break;
			default:
				return PrivacySettingsCheckResult.SenderPrivacySettingsTooHigh;
			case MessagePrivacyType.All:
				break;
			}
		}
		catch (FriendshipOperationUnavailableException ex)
		{
			ExceptionHandler.LogException(ex);
			return PrivacySettingsCheckResult.FriendsServiceUnavailable;
		}
		return PrivacySettingsCheckResult.Passed;
	}
}
