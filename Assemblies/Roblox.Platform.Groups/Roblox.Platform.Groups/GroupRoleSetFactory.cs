using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities.GroupRoleSets;
using Roblox.Platform.Groups.Interfaces;
using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <summary>
/// A platform implementation of <see cref="T:Roblox.Platform.Groups.IGroupRoleSetFactory" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Groups.IGroupRoleSetFactory" />
public class GroupRoleSetFactory : IGroupRoleSetFactory
{
	private readonly ITextFilter _TextFilter;

	private readonly IGroupRoleSetAccessorInternal _GroupRoleSetAccessor;

	private readonly IGroupRoleSetEntityFactory _GroupRoleSetEntityFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Groups.GroupRoleSetFactory" /> class.
	/// </summary>
	/// <param name="groupRoleSetAccessor"><see cref="T:Roblox.Platform.Groups.IGroupRoleSetAccessor" /></param>
	/// <param name="textFilter"><see cref="T:Roblox.TextFilter.ITextFilter" /></param>
	/// <param name="groupRoleSetEntityFactory"><see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	internal GroupRoleSetFactory(IGroupRoleSetAccessorInternal groupRoleSetAccessor, ITextFilter textFilter, IGroupRoleSetEntityFactory groupRoleSetEntityFactory)
	{
		_GroupRoleSetAccessor = groupRoleSetAccessor ?? throw new PlatformArgumentNullException("groupRoleSetAccessor");
		_TextFilter = textFilter ?? throw new PlatformArgumentNullException("textFilter");
		_GroupRoleSetEntityFactory = groupRoleSetEntityFactory ?? throw new PlatformArgumentNullException("groupRoleSetEntityFactory");
	}

	public GroupRoleSetFactory(IGroupRoleSetAccessor groupRoleSetAccessor, ITextFilter textFilter)
		: this((IGroupRoleSetAccessorInternal)groupRoleSetAccessor, textFilter, new GroupRoleSetEntityFactory())
	{
	}

	/// <inheritdoc />
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	/// <exception cref="T:Roblox.Platform.Groups.PlatformGroupTextFullyModeratedException"></exception>
	public IGroupRoleSet CreateNew(string name, string description, byte rank, IGroup group, ITextAuthor textAuthor)
	{
		if (string.IsNullOrWhiteSpace(name) || name.Length > _GroupRoleSetAccessor.RolesetNameMaxLength)
		{
			throw new PlatformArgumentException("name");
		}
		if (!string.IsNullOrEmpty(description) && description.Length > _GroupRoleSetAccessor.RolesetDescriptionMaxLength)
		{
			throw new PlatformArgumentException("description");
		}
		if (group == null)
		{
			throw new PlatformArgumentNullException("group");
		}
		if (textAuthor == null)
		{
			throw new PlatformArgumentNullException("textAuthor");
		}
		ITextFilterRuleResult filteredNameResult = FilterText(group, textAuthor, name);
		if (filteredNameResult.ModerationLevel == ModerationLevel.FullyModerated)
		{
			throw new PlatformGroupTextFullyModeratedException("name");
		}
		ITextFilterRuleResult filteredDescriptionResult = FilterText(group, textAuthor, description);
		if (filteredDescriptionResult.ModerationLevel == ModerationLevel.FullyModerated)
		{
			throw new PlatformGroupTextFullyModeratedException("description");
		}
		IGroupRoleSetEntity entity = _GroupRoleSetEntityFactory.CreateNew(group.Id, filteredNameResult.FilteredText, filteredDescriptionResult.FilteredText, rank);
		return _GroupRoleSetAccessor.GetByEntity(entity);
	}

	private ITextFilterRuleResult FilterText(IGroup group, ITextAuthor author, string textToFilter)
	{
		try
		{
			ModeratedTextRequest request = new ModeratedTextRequest(author, textToFilter, "GroupRoleSetText", group.Id.ToString());
			return _TextFilter.FilterText(request);
		}
		catch (TextFilterOperationUnavailableException e)
		{
			throw new PlatformOperationUnavailableException("Unable to filter text at this point", e);
		}
	}
}
