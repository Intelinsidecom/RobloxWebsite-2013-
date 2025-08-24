using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Interfaces;
using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <inheritdoc />
public class WallWriter : IWallWriter
{
	private readonly IWallPostEntityFactory _WallPostEntityFactory;

	private readonly ITextFilter _TextFilter;

	public WallWriter(ITextFilter textFilter)
		: this(new WallPostEntityFactory(), textFilter)
	{
	}

	internal WallWriter(IWallPostEntityFactory wallPostEntityFactory, ITextFilter textFilter)
	{
		_TextFilter = textFilter ?? throw new PlatformArgumentNullException("textFilter");
		_WallPostEntityFactory = wallPostEntityFactory ?? throw new PlatformArgumentNullException("wallPostEntityFactory");
	}

	/// <inheritdoc />
	public IWallPost Post(IWall wall, IUser user, string message)
	{
		if (wall == null)
		{
			throw new ArgumentNullException("wall");
		}
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (string.IsNullOrWhiteSpace(message))
		{
			throw new ArgumentException(string.Format("{0} may not be null or whitespace.", "message"), "message");
		}
		IGroup group = wall.Group;
		message = message.Trim();
		if (message.Length > wall.MaxWallPostLength)
		{
			message = message.Substring(0, wall.MaxWallPostLength).Trim();
		}
		IFloodChecker groupWallPostFloodChecker = GetGroupWallPostFloodChecker(user);
		if (groupWallPostFloodChecker.IsFlooded())
		{
			throw new PlatformFloodedException("GroupWallPostFloodChecker");
		}
		if (!group.GetGroupRoleSetByUserId(user).HasPermission(GroupRoleSetPermissionType.CanPostToWall))
		{
			throw new ApplicationException($"User: {user.Id} is not allowed to post to group {group.Id}'s wall!");
		}
		string filteredMessage = FilterWallPost(user, group, message);
		IWallPostEntity entity = _WallPostEntityFactory.Create(group.Id, user.Id, filteredMessage);
		groupWallPostFloodChecker.UpdateCount();
		return new WallPost(entity);
	}

	/// <inheritdoc />
	public void DeletePost(IWallPost wallPost, IGroup group, IUser actorUser)
	{
		if (group == null)
		{
			throw new PlatformArgumentNullException("group");
		}
		if (actorUser == null)
		{
			throw new PlatformArgumentNullException("actorUser");
		}
		if (wallPost?.GroupId == group.Id)
		{
			bool canDelete = false;
			if (actorUser.Id == wallPost.UserId)
			{
				canDelete = true;
			}
			else if (group.GetGroupRoleSetByUserId(actorUser).HasPermission(GroupRoleSetPermissionType.CanDeletePosts))
			{
				canDelete = true;
			}
			if (canDelete)
			{
				GroupManagement.DeletePostJson json = GetJsonToLog(wallPost);
				_WallPostEntityFactory.Get(wallPost.Id)?.Delete();
				LogDeletePostAction(actorUser.Id, group.Id, json);
			}
		}
	}

	/// <inheritdoc cref="!:IWall.DeleteAllPostsByUser" />
	/// <remarks>
	/// Imported from Groups.aspx on RobloxWebsite, do not follow pattern for new work.
	/// We should have a processor for deleting all posts by a user, it's an unbounded number.
	/// </remarks>
	public void DeleteAllPostsByUser(IUser user, IUser actorUser, IGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (actorUser == null)
		{
			throw new ArgumentNullException("actorUser");
		}
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			ICollection<IWallPost> topPostsByGroupMember = GetTopPostsByGroupMember(user, group, Settings.Default.GroupWallPostsToDeletePerPage);
			while (topPostsByGroupMember.Count() != 0)
			{
				foreach (IWallPost current in topPostsByGroupMember)
				{
					DeletePost(current, group, actorUser);
				}
				topPostsByGroupMember = GetTopPostsByGroupMember(user, group, Settings.Default.GroupWallPostsToDeletePerPage);
			}
		});
	}

	[ExcludeFromCodeCoverage]
	internal virtual IFloodChecker GetGroupWallPostFloodChecker(IUser user)
	{
		return new GroupWallPostFloodChecker(user.Id);
	}

	internal string FilterWallPost(IUser authorUser, IGroup group, string message)
	{
		try
		{
			ModeratedTextRequest filterRequest = new ModeratedTextRequest(authorUser.ToTextAuthor(), message, "GroupWallPost", group.Id.ToString());
			return _TextFilter.FilterText(filterRequest).FilteredText;
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("Cannot filter wall post message", ex);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual GroupManagement.DeletePostJson GetJsonToLog(IWallPost wallPost)
	{
		return new GroupManagement.DeletePostJson
		{
			PostDesc = wallPost.Value,
			TargetId = wallPost.UserId
		};
	}

	[ExcludeFromCodeCoverage]
	internal virtual void LogDeletePostAction(long userId, long groupId, object json)
	{
		GroupManagement.LogGroupAction(userId, groupId, GroupActionType.DeletePost.ID, json);
	}

	internal ICollection<IWallPost> GetTopPostsByGroupMember(IUser user, IGroup group, int pageSize)
	{
		return (from e in _WallPostEntityFactory.GetTopPostsByGroupIdPaged(user.Id, @group.Id, pageSize)
			select new WallPost(e)).ToArray();
	}
}
