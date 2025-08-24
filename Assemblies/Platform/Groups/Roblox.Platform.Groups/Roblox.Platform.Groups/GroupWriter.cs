using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Events;
using Roblox.Platform.Groups.Properties;
using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <inheritdoc />
public class GroupWriter : IGroupWriter
{
	private readonly ITextFilter _TextFilter;

	private int GroupDescriptionMaxCharacterCount => Settings.Default.GroupDescriptionMaxCharacterCount;

	private void VerifyGroupNotNull(IGroup group)
	{
		if (group == null)
		{
			throw new PlatformArgumentNullException("group");
		}
	}

	public GroupWriter(ITextFilter textFilter)
	{
		_TextFilter = textFilter ?? throw new PlatformArgumentNullException("textFilter");
	}

	/// <inheritdoc />
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">thrown if arguments are null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">thrown if we can't find a the group's entity or if the name can't be filtered</exception>
	public void UpdateName(IGroup group, string newName, ITextAuthor textAuthor)
	{
		VerifyGroupNotNull(group);
		if (string.IsNullOrWhiteSpace(newName))
		{
			throw new PlatformArgumentNullException("newName");
		}
		if (textAuthor == null)
		{
			throw new PlatformArgumentNullException("textAuthor");
		}
		try
		{
			ModeratedTextRequest filterRequest = new ModeratedTextRequest(textAuthor, newName, "GroupName", group.Id.ToString());
			string filteredName = (group.Name = _TextFilter.FilterText(filterRequest).FilteredText);
			IGroupEntity obj = group.DomainFactories.GroupEntityFactory.GetById(group.Id) ?? throw new PlatformOperationUnavailableException("Can't find Group Entity");
			obj.Name = filteredName;
			obj.Update();
			group.DomainFactories.GroupEventPublisher.Publish(group.Id, GroupEventType.Updated, null);
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("Cannot filter the name", ex);
		}
	}

	/// <inheritdoc />
	/// <param name="textAuthor"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">thrown if arguments are null</exception>
	/// <exception cref="T:Roblox.Platform.Core.LongDescriptionException">thrown if description is greater than GroupDescriptionMaxCharacterCount</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if you can't find group or the description can't be filtered</exception>
	public void UpdateDescription(IGroup group, string newDescription, ITextAuthor textAuthor)
	{
		VerifyGroupNotNull(group);
		if (newDescription == null)
		{
			throw new PlatformArgumentNullException("newDescription");
		}
		if (textAuthor == null)
		{
			throw new PlatformArgumentNullException("textAuthor");
		}
		if (newDescription.Length > GroupDescriptionMaxCharacterCount)
		{
			throw new LongDescriptionException($"The description is {newDescription.Length} characters long but the max is {GroupDescriptionMaxCharacterCount}.");
		}
		try
		{
			ModeratedTextRequest filterRequest = new ModeratedTextRequest(textAuthor, newDescription, "GroupName", group.Id.ToString());
			string filteredDescription = (group.Description = _TextFilter.FilterText(filterRequest).FilteredText);
			IGroupEntity obj = group.DomainFactories.GroupEntityFactory.GetById(group.Id) ?? throw new PlatformOperationUnavailableException("Can't find Group Entity");
			obj.Description = filteredDescription;
			obj.Update();
			group.DomainFactories.GroupEventPublisher.Publish(group.Id, GroupEventType.Updated, null);
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("Cannot filter the name", ex);
		}
	}

	/// <inheritdoc />
	public void UpdateEmblem(IGroup group, long emblemId)
	{
		VerifyGroupNotNull(group);
		IGroupEntity byId = group.DomainFactories.GroupEntityFactory.GetById(group.Id);
		byId.EmblemId = emblemId;
		byId.Update();
		group.DomainFactories.GroupEventPublisher.Publish(group.Id, GroupEventType.Updated, null);
	}

	/// <inheritdoc />
	public void UpdateSettings(IGroup group, bool? bcOnly, bool? publicEntryAllowed)
	{
		VerifyGroupNotNull(group);
		IGroupEntity dbEntity = group.DomainFactories.GroupEntityFactory.GetById(group.Id);
		if (dbEntity == null)
		{
			throw new PlatformOperationUnavailableException("Can't find Group Entity");
		}
		if (bcOnly.HasValue)
		{
			dbEntity.BCOnly = bcOnly.Value;
		}
		if (publicEntryAllowed.HasValue)
		{
			dbEntity.PublicEntryAllowed = publicEntryAllowed.Value;
		}
		dbEntity.Update();
		group.DomainFactories.GroupEventPublisher.Publish(group.Id, GroupEventType.Updated, null);
	}
}
