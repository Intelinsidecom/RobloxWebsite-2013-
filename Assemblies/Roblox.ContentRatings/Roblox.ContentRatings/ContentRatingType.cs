using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data;
using Roblox.Data.Interfaces;

namespace Roblox.ContentRatings;

public class ContentRatingType : IRobloxEntity<byte, ContentRatingTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private static List<ContentRatingType> _ContentTypes;

	public static ContentRatingType ThirteenPlus;

	private ContentRatingTypeDAL _EntityDAL;

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

	static ContentRatingType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Assets.ContentRatingType", isNullCacheable: true);
		_ContentTypes = new List<ContentRatingType>();
		ThirteenPlus = MustGetByValue("13+");
		_ContentTypes.Add(ThirteenPlus);
	}

	public ContentRatingType()
	{
		_EntityDAL = new ContentRatingTypeDAL();
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

	public static ContentRatingType CreateNew(string value)
	{
		ContentRatingType contentRatingType = new ContentRatingType();
		contentRatingType.Value = value;
		contentRatingType.Save();
		return contentRatingType;
	}

	public static ContentRatingType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ContentRatingTypeDAL, ContentRatingType>(EntityCacheInfo, id, () => ContentRatingTypeDAL.Get(id));
	}

	public static ContentRatingType MustGetByValue(string contentRatingTypeValue)
	{
		ContentRatingType contentType = GetByValue(contentRatingTypeValue);
		if (contentType != null)
		{
			return contentType;
		}
		throw new DataIntegrityException($"Failed to load ContentRatingType {contentRatingTypeValue}.");
	}

	public static ContentRatingType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ContentRatingTypeDAL, ContentRatingType>(EntityCacheInfo, $"Value:{value}", () => ContentRatingTypeDAL.GetByValue(value));
	}

	public static List<ContentRatingType> GetAllContentTypes()
	{
		return _ContentTypes;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(ContentRatingTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
