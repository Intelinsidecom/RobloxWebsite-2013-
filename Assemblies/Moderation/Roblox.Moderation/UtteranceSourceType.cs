using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class UtteranceSourceType : IRobloxEntity<byte, UtteranceSourceTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private UtteranceSourceTypeDAL _EntityDAL;

	/// <remarks>
	/// Changes here should be mirrored in all the following places:
	///  - Roblox.Platform.Moderation.AbuseReports.UtteranceSourceType
	///  - Roblox.Platform.Moderation.AbuseReports.Entities.UtteranceSourceTypeEntityFactory
	///  - Roblox.Platform.Moderation.ModeratorActions.UtteranceScrubberFactory
	///  - Roblox.Moderation.UtteranceSourceType
	///  - Roblox.Moderation.AbuseReports.UtteranceSourceFactory
	/// </remarks>
	public static readonly UtteranceSourceType AssetDescription;

	public static readonly UtteranceSourceType AssetHash;

	public static readonly UtteranceSourceType AssetName;

	public static readonly UtteranceSourceType AssetSetDescription;

	public static readonly UtteranceSourceType AssetSetName;

	public static readonly UtteranceSourceType AssetVersion;

	public static readonly UtteranceSourceType Avatar;

	public static readonly UtteranceSourceType BadgeDescription;

	public static readonly UtteranceSourceType BadgeName;

	public static readonly UtteranceSourceType Chat;

	public static readonly UtteranceSourceType Comment;

	public static readonly UtteranceSourceType Feed;

	public static readonly UtteranceSourceType ForumPost;

	public static readonly UtteranceSourceType GameUpdateBody;

	public static readonly UtteranceSourceType Generic;

	public static readonly UtteranceSourceType GroupDescription;

	public static readonly UtteranceSourceType GroupName;

	/// IMPORTANT: WHEN YOU ADD ONE TO THIS LIST, YOU MUST MODIFY ALL THE CLASSES LISTED ABOVE!!! *
	public static readonly UtteranceSourceType GroupRoleSetName;

	public static readonly UtteranceSourceType GroupRoleSetDescription;

	public static readonly UtteranceSourceType GroupStatus;

	public static readonly UtteranceSourceType GroupWallPost;

	public static readonly UtteranceSourceType UserOutfit;

	public static readonly UtteranceSourceType PlaceMedia;

	public static readonly UtteranceSourceType PrivateMessage;

	public static readonly UtteranceSourceType RobloxObject_Deprecated;

	public static readonly UtteranceSourceType RobloxObjectDescription_Deprecated;

	public static readonly UtteranceSourceType RobloxObjectName_Deprecated;

	public static readonly UtteranceSourceType UserBlurb;

	public static readonly UtteranceSourceType UserName;

	public static readonly UtteranceSourceType UserStatus;

	public static readonly UtteranceSourceType SocialNetworkLink;

	public static readonly UtteranceSourceType SocialNetworkLinkTitle;

	public static readonly UtteranceSourceType GamePassName;

	public static readonly UtteranceSourceType GamePassDescription;

	public static readonly UtteranceSourceType UniverseName;

	public static readonly UtteranceSourceType UniverseDescription;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	/// IMPORTANT: WHEN YOU ADD ONE TO THIS LIST, YOU MUST MODIFY ALL THE CLASSES LISTED ABOVE!!! *
	public UtteranceSourceType()
	{
		_EntityDAL = new UtteranceSourceTypeDAL();
	}

	static UtteranceSourceType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "UtteranceSourceType", isNullCacheable: true);
		AssetDescription = Get("AssetDescription");
		AssetHash = Get("AssetHash");
		AssetName = Get("AssetName");
		AssetSetDescription = Get("AssetSetDescription");
		AssetSetName = Get("AssetSetName");
		AssetVersion = Get("AssetVersion");
		Avatar = Get("Avatar");
		BadgeDescription = Get("BadgeDescription");
		BadgeName = Get("BadgeName");
		Chat = Get("Chat");
		Comment = Get("Comment");
		Feed = Get("Feed");
		ForumPost = Get("ForumPost");
		GameUpdateBody = Get("GameUpdateBody");
		Generic = Get("Generic");
		GroupDescription = Get("GroupDescription");
		GroupName = Get("GroupName");
		GroupRoleSetName = Get("GroupRoleSetName");
		GroupRoleSetDescription = Get("GroupRoleSetDescription");
		GroupWallPost = Get("GroupWallPost");
		GroupStatus = Get("GroupStatus");
		PlaceMedia = Get("PlaceMedia");
		PrivateMessage = Get("PrivateMessage");
		RobloxObject_Deprecated = Get("RobloxObject - DEPRECATED");
		RobloxObjectDescription_Deprecated = Get("RobloxObjectDescription - DEPRECATED");
		RobloxObjectName_Deprecated = Get("RobloxObjectName - DEPRECATED");
		UserBlurb = Get("UserBlurb");
		UserName = Get("UserName");
		UserOutfit = Get("UserOutfit");
		UserStatus = Get("UserStatus");
		SocialNetworkLink = Get("SocialNetworkLink");
		SocialNetworkLinkTitle = Get("SocialNetworkLinkTitle");
		GamePassName = Get("GamePassName");
		GamePassDescription = Get("GamePassDescription");
		UniverseName = Get("UniverseName");
		UniverseDescription = Get("UniverseDescription");
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	private static UtteranceSourceType DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, UtteranceSourceTypeDAL, UtteranceSourceType>(() => UtteranceSourceTypeDAL.Get(id), id);
	}

	private static UtteranceSourceType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, UtteranceSourceTypeDAL, UtteranceSourceType>(() => UtteranceSourceTypeDAL.Get(value), value);
	}

	public static UtteranceSourceType CreateNew(string value)
	{
		UtteranceSourceType utteranceSourceType = new UtteranceSourceType();
		utteranceSourceType.Value = value;
		utteranceSourceType.Save();
		return utteranceSourceType;
	}

	public static UtteranceSourceType Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static UtteranceSourceType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static UtteranceSourceType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, UtteranceSourceType>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static ICollection<UtteranceSourceType> GetUtteranceSourceTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUtteranceSourceTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => UtteranceSourceTypeDAL.GetUtteranceSourceTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfUtteranceSourceTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfUtteranceSourceTypes", UtteranceSourceTypeDAL.GetTotalNumberOfUtteranceSourceTypes);
	}

	public void Construct(UtteranceSourceTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add(Value);
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
