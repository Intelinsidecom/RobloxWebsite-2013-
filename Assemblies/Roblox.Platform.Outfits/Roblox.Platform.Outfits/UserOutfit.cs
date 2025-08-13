using System;
using Roblox.Platform.Core;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Outfits;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />
/// </summary>
internal class UserOutfit : IUserOutfit
{
	private readonly OutfitDomainFactories _DomainFactories;

	public long Id { get; }

	public long OutfitId { get; private set; }

	public long UserId { get; }

	public string Name { get; private set; }

	public bool IsEditable { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Outfits.UserOutfit" /> class
	/// </summary>
	/// <param name="entity">The entity</param>
	/// <param name="domainFactories">The domain factories</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// </exception>
	internal UserOutfit(IUserOutfitEntity entity, OutfitDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.Id;
		OutfitId = entity.OutfitId;
		UserId = entity.UserId;
		Name = entity.Name;
		IsEditable = entity.IsEditable;
		Created = entity.Created;
		Updated = entity.Updated;
		_DomainFactories = domainFactories;
	}

	public void UpdateFromOutfit(IOutfit outfit, bool overrideIsEditable = false)
	{
		if (outfit == null)
		{
			throw new PlatformArgumentNullException("outfit");
		}
		if (outfit.ID != OutfitId)
		{
			IUserOutfitEntity entity = _DomainFactories.UserOutfitEntityFactory.Get(Id);
			if (entity == null)
			{
				throw new PlatformDataIntegrityException("Unable to retrive a non-persistent entity");
			}
			if (!((entity.IsEditable && !overrideIsEditable) || overrideIsEditable))
			{
				throw new PlatformPermissionDeniedException("Cannot update a user outfit created by Roblox.");
			}
			entity.OutfitId = outfit.ID;
			entity.Update();
			OutfitId = outfit.ID;
			_DomainFactories.UserOutfitEntityFactory.OnUpdated(this);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Outfits.IUserOutfit.Rename(System.String,Roblox.TextFilter.Client.IClientTextAuthor,Roblox.TextFilter.Client.ITextFilterClientV2)" />&gt;
	public void Rename(string name, IClientTextAuthor author, ITextFilterClientV2 textFilterClientV2)
	{
		if (!_DomainFactories.OutfitRulesManager.IsValidName(name))
		{
			throw new PlatformArgumentException($"Invalid outfit name supplied: {name}");
		}
		if (author == null)
		{
			throw new PlatformArgumentNullException("author");
		}
		FilterTextResult filteredResult;
		try
		{
			filteredResult = textFilterClientV2.FilterText(name, author, "OutfitName_Rename", "", false);
		}
		catch (Exception ex)
		{
			throw new PlatformOperationUnavailableException("Cannot filter the name", ex);
		}
		if (filteredResult.ModerationLevel == 3)
		{
			throw new PlatformOutfitTextFullyModeratedException("name");
		}
		SetName(filteredResult.FilteredText);
	}

	public void RenameNoValidation(string name)
	{
		SetName(name);
	}

	private void SetName(string name)
	{
		IUserOutfitEntity obj = _DomainFactories.UserOutfitEntityFactory.Get(Id) ?? throw new PlatformDataIntegrityException("Unable to retrive a non-persistent entity");
		obj.Name = name;
		obj.Update();
		Name = name;
	}

	public void Delete()
	{
		(_DomainFactories.UserOutfitEntityFactory.Get(Id) ?? throw new PlatformDataIntegrityException("Unable to retrive a non-persistent entity")).Delete();
		_DomainFactories.UserOutfitEntityFactory.OnDeleted(this);
	}
}
