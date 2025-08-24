using System;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities.GroupRoleSets;
using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <inheritdoc />
public class GroupRoleSetWriter : IGroupRoleSetWriter
{
	private readonly ITextFilter _TextFilter;

	private readonly IGroupRoleSetAccessor _GroupRoleSetAccessor;

	private readonly IGroupRoleSetEntityFactory _GroupRoleSetEntityFactory;

	/// <summary>
	/// Class for writing to <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /> objects
	/// </summary>
	/// <param name="textFilter"><see cref="T:Roblox.TextFilter.ITextFilter" /></param>
	/// <param name="groupRoleSetAccessor"><see cref="T:Roblox.Platform.Groups.IGroupRoleSetAccessor" /></param>
	/// <param name="groupRoleSetEntityFactory"><see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntityFactory" /></param>
	internal GroupRoleSetWriter(ITextFilter textFilter, IGroupRoleSetAccessor groupRoleSetAccessor, IGroupRoleSetEntityFactory groupRoleSetEntityFactory)
	{
		_TextFilter = textFilter ?? throw new PlatformArgumentNullException("textFilter");
		_GroupRoleSetAccessor = groupRoleSetAccessor ?? throw new PlatformArgumentNullException("groupRoleSetAccessor");
		_GroupRoleSetEntityFactory = groupRoleSetEntityFactory ?? throw new PlatformArgumentNullException("groupRoleSetEntityFactory");
	}

	public GroupRoleSetWriter(ITextFilter textFilter, IGroupRoleSetAccessor groupRoleSetAccessor)
		: this(textFilter, groupRoleSetAccessor, new GroupRoleSetEntityFactory())
	{
	}

	/// <inheritdoc />
	public void UpdateNameAndDescription(IGroupRoleSet groupRoleSet, string name, string description, ITextAuthor author)
	{
		if (groupRoleSet == null)
		{
			throw new ArgumentNullException("groupRoleSet");
		}
		if (string.IsNullOrWhiteSpace(name) || name.Length > _GroupRoleSetAccessor.RolesetNameMaxLength)
		{
			throw new PlatformArgumentException("name");
		}
		if (!string.IsNullOrEmpty(description) && description.Length > _GroupRoleSetAccessor.RolesetDescriptionMaxLength)
		{
			throw new PlatformArgumentException("description");
		}
		if (author == null)
		{
			throw new PlatformArgumentNullException("author");
		}
		ITextFilterRuleResult filteredNameResult = FilterText(groupRoleSet, name, author);
		if (filteredNameResult.ModerationLevel == ModerationLevel.FullyModerated)
		{
			throw new PlatformGroupTextFullyModeratedException("Cannot update GroupRoleSet with the name: " + name);
		}
		ITextFilterRuleResult filteredDescriptionResult = FilterText(groupRoleSet, description, author);
		if (filteredDescriptionResult.ModerationLevel == ModerationLevel.FullyModerated)
		{
			throw new PlatformGroupTextFullyModeratedException("Cannot update GroupRoleSet with the description: " + description);
		}
		groupRoleSet.Name = filteredNameResult.FilteredText;
		groupRoleSet.Description = filteredDescriptionResult.FilteredText;
		IGroupRoleSetEntity dbEntity = _GroupRoleSetEntityFactory.GetById(groupRoleSet.Id);
		if (dbEntity != null)
		{
			dbEntity.Name = filteredNameResult.FilteredText;
			dbEntity.Description = filteredDescriptionResult.FilteredText;
			dbEntity.Update();
		}
	}

	/// <inheritdoc />
	public void UpdateRank(IGroupRoleSet groupRoleSet, byte rank)
	{
		if (groupRoleSet == null)
		{
			throw new ArgumentNullException("groupRoleSet");
		}
		groupRoleSet.Rank = rank;
		IGroupRoleSetEntity dbEntity = _GroupRoleSetEntityFactory.GetById(groupRoleSet.Id);
		if (dbEntity != null)
		{
			dbEntity.Rank = rank;
			dbEntity.Update();
		}
	}

	/// <inheritdoc />
	public void UpdatePermission(IGroupRoleSet groupRoleSet, GroupRoleSetPermissionType permission, bool createPermission)
	{
		if (groupRoleSet == null)
		{
			throw new ArgumentNullException("groupRoleSet");
		}
		Roblox.GroupRoleSetPermissionType permissionType = Roblox.GroupRoleSetPermissionType.GetByName(permission.ToString());
		if (createPermission)
		{
			GroupRoleSetPermission.GetOrCreate(groupRoleSet.Id, permissionType.ID, (byte)permissionType.Category);
		}
		else
		{
			GroupRoleSetPermission.GetByRoleSetIDAndTypeID(groupRoleSet.Id, permissionType.ID)?.Delete();
		}
	}

	/// <inheritdoc />
	public void Delete(IGroupRoleSet groupRoleSet)
	{
		_GroupRoleSetEntityFactory.GetById(groupRoleSet.Id)?.Delete();
	}

	/// <summary>
	/// Filter Text 
	/// </summary>
	/// <param name="groupRoleSet"><see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /></param>
	/// <param name="text">the text to filter</param>
	/// <param name="author"><see cref="T:Roblox.TextFilter.ITextAuthor" /></param>
	/// <returns><see cref="T:Roblox.TextFilter.ITextFilterRuleResult" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException"></exception>
	private ITextFilterRuleResult FilterText(IGroupRoleSet groupRoleSet, string text, ITextAuthor author)
	{
		try
		{
			ModeratedTextRequest request = new ModeratedTextRequest(author, text, "GroupRoleSetText", groupRoleSet.GroupId.ToString());
			return _TextFilter.FilterText(request);
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("Cannot filter GroupRoleSetText", ex);
		}
	}
}
