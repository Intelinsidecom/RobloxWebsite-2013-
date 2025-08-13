using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetGenresInfo : IRobloxEntity<byte, AssetGenresInfoDAL>, ICacheableObject<byte>, ICacheableObject
{
	private AssetGenresInfoDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AssetGenresInfo", isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	public byte AssetGenreID
	{
		get
		{
			return _EntityDAL.AssetGenreID;
		}
		set
		{
			_EntityDAL.AssetGenreID = value;
		}
	}

	public string IconPath
	{
		get
		{
			return _EntityDAL.IconPath;
		}
		set
		{
			_EntityDAL.IconPath = value;
		}
	}

	public string PageHeader
	{
		get
		{
			return _EntityDAL.PageHeader;
		}
		set
		{
			_EntityDAL.PageHeader = value;
		}
	}

	public string PageTitle
	{
		get
		{
			return _EntityDAL.PageTitle;
		}
		set
		{
			_EntityDAL.PageTitle = value;
		}
	}

	public string FriendlyURL
	{
		get
		{
			return _EntityDAL.FriendlyURL;
		}
		set
		{
			_EntityDAL.FriendlyURL = value;
		}
	}

	public string MetaDescription
	{
		get
		{
			return _EntityDAL.MetaDescription;
		}
		set
		{
			_EntityDAL.MetaDescription = value;
		}
	}

	public string MetaKeywords
	{
		get
		{
			return _EntityDAL.MetaKeywords;
		}
		set
		{
			_EntityDAL.MetaKeywords = value;
		}
	}

	public string FooterText
	{
		get
		{
			return _EntityDAL.FooterText;
		}
		set
		{
			_EntityDAL.FooterText = value;
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

	public static bool GameGenreSEOenabled
	{
		get
		{
			return Settings.Default.GameGenreSEOenabled;
		}
		set
		{
			Settings.Default["GameGenreSEOenabled"] = value;
			Settings.Default.Save();
		}
	}

	public static bool GameGenresListEnabled
	{
		get
		{
			return Settings.Default.GameGenresListEnabled;
		}
		set
		{
			Settings.Default["GameGenresListEnabled"] = value;
			Settings.Default.Save();
		}
	}

	public static bool GameGenreSEOIconPathEditingEnabled
	{
		get
		{
			return Settings.Default.GameGenreSEOIconPathEditingEnabled;
		}
		set
		{
			Settings.Default["GameGenreSEOIconPathEditingEnabled"] = value;
			Settings.Default.Save();
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetGenresInfo()
	{
		_EntityDAL = new AssetGenresInfoDAL();
	}

	public AssetGenre GetAssetGenre()
	{
		return AssetGenre.MustGet(AssetGenreID);
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

	public static AssetGenresInfo CreateNew(byte assetGenreId, string iconPath, string pageHeader, string pageTitle, string friendlyUrl, string metaDescription, string metaKeywords, string footerText)
	{
		AssetGenresInfo assetGenresInfo = new AssetGenresInfo();
		assetGenresInfo.AssetGenreID = assetGenreId;
		assetGenresInfo.IconPath = iconPath;
		assetGenresInfo.PageHeader = pageHeader;
		assetGenresInfo.PageTitle = pageTitle;
		assetGenresInfo.FriendlyURL = friendlyUrl;
		assetGenresInfo.MetaDescription = metaDescription;
		assetGenresInfo.MetaKeywords = metaKeywords;
		assetGenresInfo.FooterText = footerText;
		assetGenresInfo.Save();
		return assetGenresInfo;
	}

	public static AssetGenresInfo Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AssetGenresInfoDAL, AssetGenresInfo>(EntityCacheInfo, id, () => AssetGenresInfoDAL.Get(id));
	}

	public static AssetGenresInfo GetByAssetGenreID(byte assetGenreId)
	{
		return EntityHelper.GetEntityByLookup<byte, AssetGenresInfoDAL, AssetGenresInfo>(EntityCacheInfo, "AssetGenreID:" + assetGenreId, () => AssetGenresInfoDAL.GetByAssetGenreID(assetGenreId));
	}

	public static AssetGenresInfo GetByFriendlyURL(string friendlyUrl)
	{
		return EntityHelper.GetEntityByLookup<byte, AssetGenresInfoDAL, AssetGenresInfo>(EntityCacheInfo, "FriendlyUrl:" + friendlyUrl, () => AssetGenresInfoDAL.GetByFriendlyURL(friendlyUrl));
	}

	public void Construct(AssetGenresInfoDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "AssetGenreID:" + AssetGenreID;
			yield return "FriendlyUrl:" + FriendlyURL;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
