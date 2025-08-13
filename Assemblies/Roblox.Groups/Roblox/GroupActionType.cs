using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupActionType : IRobloxEntity<int, GroupActionTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private GroupActionTypeDAL _EntityDAL;

	private static ICollection<GroupActionType> _ActionTypes;

	public static GroupActionType DeletePost;

	public static GroupActionType RemoveMember;

	public static GroupActionType AcceptJoinRequest;

	public static GroupActionType DeclineJoinRequest;

	public static GroupActionType PostStatus;

	public static GroupActionType ChangeRank;

	public static GroupActionType BuyAd;

	public static GroupActionType SendAllyRequest;

	public static GroupActionType CreateEnemy;

	public static GroupActionType AcceptAllyRequest;

	public static GroupActionType DeclineAllyRequest;

	public static GroupActionType DeleteAlly;

	public static GroupActionType DeleteEnemy;

	public static GroupActionType AddGroupPlace;

	public static GroupActionType DeleteGroupPlace;

	public static GroupActionType CreateItems;

	public static GroupActionType ConfigureItems;

	public static GroupActionType SpendGroupFunds;

	public static GroupActionType ChangeOwner;

	public static GroupActionType Delete;

	public static GroupActionType Rename;

	public static GroupActionType AdjustCurrencyAmounts;

	public static GroupActionType Abandon;

	public static GroupActionType Claim;

	public static GroupActionType ChangeDescription;

	public static GroupActionType InviteToClan;

	public static GroupActionType KickFromClan;

	public static GroupActionType CancelClanInvite;

	public static GroupActionType BuyClan;

	public static GroupActionType CreateAsset;

	public static GroupActionType UpdateAsset;

	public static GroupActionType ConfigureAsset;

	public static GroupActionType RevertAsset;

	public static GroupActionType CreateDeveloperProduct;

	public static GroupActionType ConfigureGame;

	public static GroupActionType Lock;

	public static GroupActionType Unlock;

	public static GroupActionType CreateGamePass;

	public static GroupActionType CreateBadge;

	public static GroupActionType ConfigureBadge;

	public static GroupActionType SavePlace;

	public static GroupActionType PublishPlace;

	public static CacheInfo EntityCacheInfo;

	public int ID => _EntityDAL.ID;

	public int PermissionTypeID
	{
		get
		{
			return _EntityDAL.PermissionTypeID;
		}
		set
		{
			_EntityDAL.PermissionTypeID = value;
		}
	}

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GroupActionType()
	{
		_EntityDAL = new GroupActionTypeDAL();
	}

	static GroupActionType()
	{
		_ActionTypes = new List<GroupActionType>();
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupActionType", isNullCacheable: true);
		DeletePost = GetByName("Delete Post");
		_ActionTypes.Add(DeletePost);
		RemoveMember = GetByName("Remove Member");
		_ActionTypes.Add(RemoveMember);
		AcceptJoinRequest = GetByName("Accept Join Request");
		_ActionTypes.Add(AcceptJoinRequest);
		DeclineJoinRequest = GetByName("Decline Join Request");
		_ActionTypes.Add(DeclineJoinRequest);
		PostStatus = GetByName("Post Status");
		_ActionTypes.Add(PostStatus);
		ChangeRank = GetByName("Change Rank");
		_ActionTypes.Add(ChangeRank);
		BuyAd = GetByName("Buy Ad");
		_ActionTypes.Add(BuyAd);
		SendAllyRequest = GetByName("Send Ally Request");
		_ActionTypes.Add(SendAllyRequest);
		CreateEnemy = GetByName("Create Enemy");
		_ActionTypes.Add(CreateEnemy);
		AcceptAllyRequest = GetByName("Accept Ally Request");
		_ActionTypes.Add(AcceptAllyRequest);
		DeclineAllyRequest = GetByName("Decline Ally Request");
		_ActionTypes.Add(DeclineAllyRequest);
		DeleteAlly = GetByName("Delete Ally");
		_ActionTypes.Add(DeleteAlly);
		DeleteEnemy = GetByName("Delete Enemy");
		_ActionTypes.Add(DeleteEnemy);
		AddGroupPlace = GetByName("Add Group Place");
		_ActionTypes.Add(AddGroupPlace);
		DeleteGroupPlace = GetByName("Remove Group Place");
		_ActionTypes.Add(DeleteGroupPlace);
		CreateItems = GetByName("Create Items");
		_ActionTypes.Add(CreateItems);
		ConfigureItems = GetByName("Configure Items");
		_ActionTypes.Add(ConfigureItems);
		SpendGroupFunds = GetByName("Spend Group Funds");
		_ActionTypes.Add(SpendGroupFunds);
		ChangeOwner = GetByName("Change Owner");
		_ActionTypes.Add(ChangeOwner);
		Delete = GetByName("Delete");
		_ActionTypes.Add(Delete);
		Rename = GetByName("Rename");
		_ActionTypes.Add(Rename);
		Abandon = GetByName("Abandon");
		_ActionTypes.Add(Abandon);
		Claim = GetByName("Claim");
		_ActionTypes.Add(Claim);
		ChangeDescription = GetByName("Change Description");
		_ActionTypes.Add(ChangeDescription);
		AdjustCurrencyAmounts = GetByName("AdjustCurrencyAmounts");
		_ActionTypes.Add(AdjustCurrencyAmounts);
		InviteToClan = GetByName("Invite to Clan");
		_ActionTypes.Add(InviteToClan);
		KickFromClan = GetByName("Kick from Clan");
		_ActionTypes.Add(KickFromClan);
		CancelClanInvite = GetByName("Cancel Clan Invite");
		_ActionTypes.Add(CancelClanInvite);
		BuyClan = GetByName("Buy Clan");
		_ActionTypes.Add(BuyClan);
		CreateAsset = GetByName("Create Group Asset");
		_ActionTypes.Add(CreateAsset);
		UpdateAsset = GetByName("Update Group Asset");
		_ActionTypes.Add(UpdateAsset);
		ConfigureAsset = GetByName("Configure Group Asset");
		_ActionTypes.Add(ConfigureAsset);
		RevertAsset = GetByName("Revert Group Asset");
		_ActionTypes.Add(RevertAsset);
		CreateDeveloperProduct = GetByName("Create Group Developer Product");
		_ActionTypes.Add(CreateDeveloperProduct);
		ConfigureGame = GetByName("Configure Group Game");
		_ActionTypes.Add(ConfigureGame);
		Lock = GetByName("Lock");
		_ActionTypes.Add(Lock);
		Unlock = GetByName("Unlock");
		_ActionTypes.Add(Unlock);
		CreateGamePass = GetByName("Create Game Pass");
		_ActionTypes.Add(CreateGamePass);
		CreateBadge = GetByName("Create Badge");
		_ActionTypes.Add(CreateBadge);
		ConfigureBadge = GetByName("Configure Badge");
		_ActionTypes.Add(ConfigureBadge);
		SavePlace = GetByName("Save Place");
		_ActionTypes.Add(SavePlace);
		PublishPlace = GetByName("Publish Place");
		_ActionTypes.Add(PublishPlace);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static GroupActionType CreateNew(int permissiontypeid, string name)
	{
		GroupActionType groupActionType = new GroupActionType();
		groupActionType.PermissionTypeID = permissiontypeid;
		groupActionType.Name = name;
		groupActionType.Save();
		return groupActionType;
	}

	public static GroupActionType Get(int id)
	{
		return EntityHelper.GetEntity<int, GroupActionTypeDAL, GroupActionType>(EntityCacheInfo, id, () => GroupActionTypeDAL.Get(id));
	}

	public static GroupActionType GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, GroupActionTypeDAL, GroupActionType>(EntityCacheInfo, $"Name:{name}", () => GroupActionTypeDAL.GetByName(name));
	}

	public static ICollection<GroupActionType> GetGroupActionTypes()
	{
		return _ActionTypes;
	}

	public void Construct(GroupActionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PermissionTypeID:{PermissionTypeID}");
	}
}
