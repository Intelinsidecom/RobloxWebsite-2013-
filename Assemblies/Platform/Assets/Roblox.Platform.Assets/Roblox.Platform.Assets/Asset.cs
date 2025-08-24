using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Agents;
using Roblox.Platform.Assets.Entities;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Assets.Events;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.AssetsCore;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.TextFilter;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Assets;

public abstract class Asset : DomainObjectBase<AssetDomainFactories, long>, IAsset, IAssetIdentifier
{
	internal virtual bool IsAuditingEnabled => Settings.Default.IsAssetsTableAuditingEnabled;

	private int AssetDescriptionMaxCharacterCount => Settings.Default.AssetDescriptionMaxCharacterCount;

	public int TypeId { get; }

	public string Name { get; private set; }

	public string Description { get; private set; }

	public CreatorType CreatorType { get; private set; }

	public long CreatorTargetId { get; private set; }

	public ulong AssetGenres { get; private set; }

	public bool? IsArchived { get; private set; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	protected Asset(AssetDomainFactories domainFactories, IAsset asset)
		: this(domainFactories, asset.Id, asset.TypeId, asset.Name, asset.Description, asset.CreatorType, asset.CreatorTargetId, asset.AssetGenres, asset.IsArchived, asset.Created, asset.Updated)
	{
	}

	protected Asset(AssetDomainFactories domainFactories, long id, int typeId, string name, string description, CreatorType creatorType, long creatorTargetId, ulong assetGenres, bool? isArchived, DateTime created, DateTime updated)
		: base(domainFactories)
	{
		base.Id = id;
		TypeId = typeId;
		Name = name;
		Description = description;
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
		AssetGenres = assetGenres;
		IsArchived = isArchived;
		Created = created;
		Updated = updated;
	}

	protected Asset(AssetDomainFactories domainFactories, long id, int typeId, string name, string description, CreatorType creatorType, long creatorTargetId, ulong assetGenres, bool isArchived, DateTime created, DateTime updated)
		: base(domainFactories)
	{
		base.Id = id;
		TypeId = typeId;
		Name = name;
		Description = description;
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
		AssetGenres = assetGenres;
		Created = created;
		Updated = updated;
		IsArchived = isArchived;
	}

	public void UpdateNameAndDescription(IAssetNameAndDescription textInfo, IUserIdentifier actorUserIdentity)
	{
		if (textInfo == null)
		{
			throw new ArgumentNullException("textInfo");
		}
		if (!string.IsNullOrEmpty(textInfo.Description) && textInfo.Description.Length > AssetDescriptionMaxCharacterCount)
		{
			throw new LongDescriptionException($"The description is {textInfo.Description.Length} characters long but the max is {AssetDescriptionMaxCharacterCount}.");
		}
		AssetTextFilterRequestV2 filterRequest = new AssetTextFilterRequestV2(textInfo, (AssetType)TypeId);
		IAssetTextFilterResult filteredText = base.DomainFactories.AssetTextFilter.FilterAssetText(filterRequest);
		AssetChangeType[] changeTypesToAudit = new AssetChangeType[1] { AssetChangeType.TextSaved };
		UpdateText(filteredText, changeTypesToAudit, actorUserIdentity);
	}

	public void UpdateNameAndDescriptionTrusted(ITrustedAssetTextInfo textInfo, IUserIdentifier actorUserIdentity)
	{
		AssetChangeType[] changeTypesToAudit = new AssetChangeType[1] { AssetChangeType.TextSaved };
		UpdateText(textInfo, changeTypesToAudit, actorUserIdentity);
	}

	public void DelayedReleaseUpdateNameAndDescription(IAssetNameAndDescription textInfo, IUser actorUser)
	{
		AssetChangeType[] changeTypesToAudit = new AssetChangeType[1] { AssetChangeType.TextSaved };
		UpdateText(textInfo, changeTypesToAudit, actorUser, isDelayedRelease: true);
	}

	public bool Sanitize(ITextAuthor textAuthor)
	{
		if (textAuthor == null)
		{
			throw new ArgumentNullException("textAuthor");
		}
		string name = Name;
		string description = Description;
		AssetTextFilterRequestV2 filterRequest = new AssetTextFilterRequestV2(new AssetNameAndDescription(textAuthor, name, description), (AssetType)TypeId);
		IAssetTextFilterResult filteredTextResult = base.DomainFactories.AssetTextFilter.FilterAssetText(filterRequest);
		AssetChangeType[] changeTypesToAudit = new AssetChangeType[1] { AssetChangeType.TextSaved };
		return UpdateText(filteredTextResult, changeTypesToAudit, null);
	}

	public bool Sanitize(IClientTextAuthor clientTextAuthor)
	{
		if (clientTextAuthor == null)
		{
			throw new ArgumentNullException("clientTextAuthor");
		}
		string name = Name;
		string description = Description;
		AssetTextFilterRequestV2 filterRequest = new AssetTextFilterRequestV2(new AssetNameAndDescription(clientTextAuthor, name, description), (AssetType)TypeId);
		IAssetTextFilterResult filteredText = base.DomainFactories.AssetTextFilter.FilterAssetText(filterRequest);
		AssetChangeType[] changeTypesToAudit = new AssetChangeType[1] { AssetChangeType.TextSaved };
		return UpdateText(filteredText, changeTypesToAudit, null);
	}

	/// <summary>
	/// Public method for saving non-public-facing properties.
	/// </summary>
	public void UpdateGenres(Roblox.AssetGenre genre, bool isForceUpdate = false)
	{
		if (genre == null)
		{
			throw new PlatformArgumentException("genre");
		}
		UpdateGenres(genre.BitMask, isForceUpdate);
	}

	public void UpdateGenres(ulong genres, bool isForceUpdate = false)
	{
		if (base.Id < 1)
		{
			throw new ApplicationException("Failed to save because Asset has not been created.  Use a factory method to create an Asset before attempting to modify it.");
		}
		IAssetEntity assetEntity = base.DomainFactories.AssetEntityFactory.MustGet(base.Id);
		if (assetEntity.AssetGenres != genres || isForceUpdate)
		{
			assetEntity.AssetGenres = genres;
			assetEntity.Update();
		}
	}

	public void UpdateCategories(ulong bitfield, bool isForceUpdate = false)
	{
		if (base.Id < 1)
		{
			throw new ApplicationException("Failed to save because Asset has not been created.  Use a factory method to create an Asset before attempting to modify it.");
		}
		IAssetEntity assetEntity = base.DomainFactories.AssetEntityFactory.MustGet(base.Id);
		if (assetEntity.AssetCategories != bitfield || isForceUpdate)
		{
			assetEntity.AssetCategories = bitfield;
			assetEntity.Update();
		}
	}

	public void UpdateCreatorAgentId(IAgent newCreatorAgent)
	{
		if (newCreatorAgent == null)
		{
			throw new ArgumentNullException("newCreatorAgent");
		}
		if (base.Id < 1)
		{
			throw new ApplicationException("Failed to save because Asset has not been created.  Use a factory method to create an Asset before attempting to modify it.");
		}
		IAssetEntity assetEntity = base.DomainFactories.AssetEntityFactory.MustGet(base.Id);
		assetEntity.CreatorId = newCreatorAgent.Id;
		assetEntity.Update();
		if (base.DomainFactories.AgentFactory.Get(assetEntity.CreatorId)?.AgentType != newCreatorAgent.AgentType)
		{
			CreatorType = ((newCreatorAgent.AgentType == AgentType.User) ? CreatorType.User : CreatorType.Group);
		}
		CreatorTargetId = newCreatorAgent.AgentTargetId;
		OnAssetChanged(Roblox.Platform.Assets.Events.AssetChangeType.CreatorChanged);
	}

	public void UpdateUpdated()
	{
		if (base.Id < 1)
		{
			throw new ApplicationException("Failed to save because Asset has not been created.  Use a factory method to create an Asset before attempting to modify it.");
		}
		base.DomainFactories.AssetEntityFactory.Get(base.Id).Update();
	}

	public void Archive(IUserIdentifier actorUserIdentity)
	{
		if (base.Id < 1)
		{
			throw new ApplicationException("Failed to save because Asset has not been created.  Use a factory method to create an Asset before attempting to modify it.");
		}
		IAssetEntity assetEntity = base.DomainFactories.AssetEntityFactory.MustGet(base.Id);
		if (assetEntity.IsArchived == true)
		{
			throw new ApplicationException("Failed to save because asset is already archived.");
		}
		assetEntity.IsArchived = true;
		OnArchived(actorUserIdentity, assetEntity.Update().AuditEntryEntity);
	}

	public void Restore(IUserIdentifier actorUserIdentity)
	{
		if (base.Id < 1)
		{
			throw new ApplicationException("Failed to save because Asset has not been created.  Use a factory method to create an Asset before attempting to modify it.");
		}
		IAssetEntity assetEntity = base.DomainFactories.AssetEntityFactory.MustGet(base.Id);
		if (assetEntity.IsArchived == false)
		{
			throw new ApplicationException("Failed to save because asset is not archived.");
		}
		assetEntity.IsArchived = false;
		OnUnarchived(actorUserIdentity, assetEntity.Update().AuditEntryEntity);
	}

	/// <summary>
	/// All changes to asset text should pass through here to ensure consistent data auditing.  
	/// Any text moderation should be performed before passing text into this function.
	/// </summary>
	/// <param name="textInfo">The container object holding the name and description to be updated to.</param>
	/// <param name="changeTypesToAudit">
	///   An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that should at least contain AssetChangeType.TextSaved.
	///   There may be business cases where certain text changes should have its own categorized auditing, which adds to the enumerable.
	/// </param>
	/// <param name="actorUserIdentity">
	///     The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the agent performing the update, which may be different from the text author. 
	///     For migrators and sanitization processes, pass null for the actorUserIdentity.
	/// </param>
	/// <param name="isDelayedRelease">Whether this update is for a delayed release</param>
	/// <returns>Returns whether any of the text is changed.</returns>
	internal bool UpdateText(INameAndDescription textInfo, IEnumerable<AssetChangeType> changeTypesToAudit, IUserIdentifier actorUserIdentity, bool isDelayedRelease = false)
	{
		if (base.Id < 1)
		{
			throw new ApplicationException("Failed to save because Asset has not been created.  Use a factory method to create an Asset before attempting to modify it.");
		}
		if (Name == textInfo.Name && Description == textInfo.Description)
		{
			return false;
		}
		OnPreChange();
		Name = textInfo.Name;
		Description = textInfo.Description;
		IAssetEntity assetEntity = base.DomainFactories.AssetEntityFactory.MustGet(base.Id);
		assetEntity.Name = Name;
		assetEntity.Description = Description;
		OnTextUpdated(changeTypesToAudit, actorUserIdentity, assetEntity.Update(isDelayedRelease).AuditEntryEntity);
		return true;
	}

	internal virtual void OnPreChange()
	{
		try
		{
			BackfillUnauditedPastData();
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error(e);
		}
	}

	internal virtual void OnTextUpdated(IEnumerable<AssetChangeType> changeTypesToAudit, IUserIdentifier actorUserIdentity, IAssetsAuditEntryEntity auditEntry)
	{
		if (auditEntry == null)
		{
			return;
		}
		try
		{
			foreach (AssetChangeType changeType in changeTypesToAudit)
			{
				base.DomainFactories.AssetsAuditMetadataEntityFactory.CreateNew(auditEntry, changeType, actorUserIdentity);
			}
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error(e);
		}
		OnAssetChanged(Roblox.Platform.Assets.Events.AssetChangeType.TextChanged);
	}

	internal virtual void OnArchived(IUserIdentifier actorUserIdentity, IAssetsAuditEntryEntity auditEntry)
	{
		if (auditEntry != null)
		{
			try
			{
				base.DomainFactories.AssetsAuditMetadataEntityFactory.CreateNew(auditEntry, AssetChangeType.Archived, actorUserIdentity);
			}
			catch (Exception e)
			{
				base.DomainFactories.Logger.Error(e);
			}
			OnAssetChanged(Roblox.Platform.Assets.Events.AssetChangeType.Archived, actorUserIdentity?.Id);
		}
	}

	internal virtual void OnUnarchived(IUserIdentifier actorUserIdentity, IAssetsAuditEntryEntity auditEntry)
	{
		if (auditEntry != null)
		{
			try
			{
				base.DomainFactories.AssetsAuditMetadataEntityFactory.CreateNew(auditEntry, AssetChangeType.Unarchived, actorUserIdentity);
			}
			catch (Exception e)
			{
				base.DomainFactories.Logger.Error(e);
			}
			OnAssetChanged(Roblox.Platform.Assets.Events.AssetChangeType.Unarchived, actorUserIdentity?.Id);
		}
	}

	internal virtual void BackfillUnauditedPastData()
	{
		if (!IsAuditingEnabled)
		{
			return;
		}
		try
		{
			bool hasUnauditedText = CheckHasUnauditedText();
			if (hasUnauditedText)
			{
				IAssetEntity assetEntity = base.DomainFactories.AssetEntityFactory.MustGet(base.Id);
				IAssetsAuditEntryEntity auditEntity = base.DomainFactories.AssetsAuditEntriesEntityFactory.Create(assetEntity._EntityDAL);
				if (hasUnauditedText)
				{
					base.DomainFactories.AssetsAuditMetadataEntityFactory.CreateLegacyAudit(auditEntity, AssetChangeType.TextSaved);
				}
			}
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error(e);
		}
	}

	/// <summary>
	/// If there are text updates (or creations) when auditing is off, it would not be audited at the timie the update happens.
	/// </summary>
	/// <returns></returns>
	internal virtual bool CheckHasUnauditedText()
	{
		byte changeTypeId = base.DomainFactories.AssetChangeTypesEntityFactory.GetIdByEnum(AssetChangeType.TextSaved);
		IAssetsAuditMetadataEntity mostRececntTextChange = base.DomainFactories.AssetsAuditMetadataEntityFactory.GetByAssetIdAndAssetChangeTypeIdEnumerative(base.Id, changeTypeId, 1).FirstOrDefault();
		if (mostRececntTextChange == null)
		{
			return true;
		}
		IAssetsAuditEntryEntity auditEntry = base.DomainFactories.AssetsAuditEntriesEntityFactory.GetByPublicId(mostRececntTextChange.AssetsAuditEntryPublicId);
		if (auditEntry == null)
		{
			base.DomainFactories.Logger.Error($"DataIntegrity Error - Unable to locate asset audit entry based on public id from metadata: {mostRececntTextChange.AssetsAuditEntryPublicId}");
			return true;
		}
		if (auditEntry.Audit_Name != Name || (auditEntry.Audit_Description ?? string.Empty) != Description)
		{
			return true;
		}
		return false;
	}

	internal void OnAssetChanged(Roblox.Platform.Assets.Events.AssetChangeType changeType, long? authorUserId = null)
	{
		base.DomainFactories.AssetChangeReporter.EntityChanged(base.Id, TypeId, changeType, authorUserId);
	}
}
