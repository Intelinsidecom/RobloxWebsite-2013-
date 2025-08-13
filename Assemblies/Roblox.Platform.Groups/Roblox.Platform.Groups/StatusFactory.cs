using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <inheritdoc />
public class StatusFactory : IStatusFactory
{
	private readonly IStatusEntityFactory _StatusEntityFactory;

	private readonly ITextFilter _TextFilter;

	public StatusFactory(ITextFilter textFilter)
		: this(textFilter, new StatusEntityFactory())
	{
	}

	internal StatusFactory(ITextFilter textFilter, IStatusEntityFactory statusEntityFactory)
	{
		_TextFilter = textFilter ?? throw new PlatformArgumentNullException("textFilter");
		_StatusEntityFactory = statusEntityFactory ?? throw new PlatformArgumentNullException("statusEntityFactory");
	}

	/// <inheritdoc />
	public IStatus PostStatus(IGroup group, IUser user, string message)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (!group.GetGroupRoleSetByUserId(user).HasPermission(GroupRoleSetPermissionType.CanPostToStatus))
		{
			throw new PostStatusPermissionException($"The user {user.Id} does not have permission to post status to group {group.Id}");
		}
		message = message.Trim();
		string filteredMessage = FilterGroupStatus(user, group, message);
		filteredMessage = ((filteredMessage.Length > 255) ? filteredMessage.Substring(0, 255) : filteredMessage);
		IStatusEntity statusEntity = _StatusEntityFactory.UpdateOrCreate(group.Id, user.Id, filteredMessage);
		LogPostStatusAction(user.Id, group.Id, new GroupManagement.TextJson
		{
			Text = statusEntity.Message
		});
		return new Status(statusEntity);
	}

	internal string FilterGroupStatus(IUser authorUser, IGroup group, string message)
	{
		try
		{
			ModeratedTextRequest filterRequest = new ModeratedTextRequest(authorUser.ToTextAuthor(), message, "GroupStatusPost", group.Id.ToString());
			return _TextFilter.FilterText(filterRequest).FilteredText;
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("Cannot filter group status shout", ex);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual void LogPostStatusAction(long userId, long groupId, object json)
	{
		GroupManagement.LogGroupAction(userId, groupId, GroupActionType.PostStatus.ID, json);
	}
}
