using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Web.Caching;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.DataV2.Core;
using Roblox.Properties;
using Roblox.Resources;

namespace Roblox;

public class Comment : IRemoteCacheableObject, IRobloxEntity<long, CommentDAL>, ICacheableObject<long>, ICacheableObject
{
	private CommentDAL _EntityDAL;

	private static readonly string _JsonTemplate;

	private static int _JsonVersion;

	public static CacheInfo EntityCacheInfo;

	public long ID => _EntityDAL.ID;

	public long UserID => _EntityDAL.UserID;

	public User User => User.Get(UserID);

	public long AssetID => _EntityDAL.AssetID;

	public Asset Asset => Asset.Get(AssetID);

	public string Value => _EntityDAL.Value;

	public DateTime Created => _EntityDAL.Created;

	private static double _CommentsCounterVerificationPercentage => Settings.Default.CommentsCounterVerificationPercentage;

	private static bool _UseCommentsCounter => Settings.Default.UseCommentsCounter;

	public static bool GlobalCommentaryIsEnabled => Settings.Default.GlobalCommentaryIsEnabled;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Comment(CommentDAL dal)
	{
		_EntityDAL = dal;
	}

	private Comment(User user, Asset asset, string value)
	{
		_EntityDAL = new CommentDAL
		{
			UserID = user.ID,
			AssetID = asset.ID,
			Value = value
		};
	}

	public Comment()
	{
	}

	static Comment()
	{
		_JsonTemplate = string.Empty;
		_JsonVersion = 1;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: false), "Roblox.Comment", isNullCacheable: true);
		_JsonTemplate = new UTF8Encoding().GetString(Roblox.Resources.JSON.JSON_Comment);
	}

	private void DecrementCommentsCount()
	{
		if (_UseCommentsCounter)
		{
			AssetCounter.GetOrCreate(AssetID, AssetCounterType.CommentsID, SynchronizeCommentsCounter).Decrement();
		}
	}

	private void IncrementCommentsCount()
	{
		if (_UseCommentsCounter)
		{
			AssetCounter.GetOrCreate(AssetID, AssetCounterType.CommentsID, SynchronizeCommentsCounter).Increment();
		}
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		DecrementCommentsCount();
	}

	public string GetDocumentKey()
	{
		return HashFunctions.ComputeHashString(("rbx.Roblox.Comment[v=" + _JsonVersion + "]_" + ID).GetBytes());
	}

	public string GetJson()
	{
		return string.Format(_JsonTemplate, ID, UserID, AssetID, Value, Created);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	private static int DoGetTotalNumberOfAssetComments(long assetId, bool useCounter)
	{
		if (useCounter)
		{
			AssetCounter orCreate = AssetCounter.GetOrCreate(assetId, AssetCounterType.CommentsID, SynchronizeCommentsCounter);
			VerifyCommentsCounter(orCreate);
			return (int)orCreate.Value;
		}
		string countId = $"GetTotalNumberOfAssetComments_AssetID:{assetId}";
		string cachedStateQualifier = GetAssetIdCacheStateQualifier(assetId);
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => CommentDAL.GetTotalNumberOfAssetComments(assetId));
	}

	private static void SynchronizeCommentsCounter(AssetCounter counter)
	{
		int difference = DoGetTotalNumberOfAssetComments(counter.AssetID, useCounter: false) - (int)counter.Value;
		if (difference > 0)
		{
			counter.Increment(difference);
		}
		else if (difference < 0)
		{
			counter.Decrement(-1 * difference);
		}
	}

	private static void VerifyCommentsCounter(AssetCounter counter)
	{
		if (_CommentsCounterVerificationPercentage != 0.0 && !(new Random().NextDouble() >= _CommentsCounterVerificationPercentage))
		{
			SynchronizeCommentsCounter(counter);
		}
	}

	public static Comment CreateNew(User user, Asset asset, string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		string message = value.Trim();
		if (message.Length == 0)
		{
			return null;
		}
		message = message.Substring(0, Math.Min(message.Length, 200));
		message = message.TrimEnd();
		Comment comment = new Comment(user, asset, value);
		comment.Save();
		return comment;
	}

	public static Comment Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return EntityHelper.GetEntity<long, CommentDAL, Comment>(EntityCacheInfo, id, () => CommentDAL.Get(id));
	}

	public static ICollection<Comment> GetAssetCommentsPaged(long assetId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetCommentsPaged_AssetID:{assetId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = GetAssetIdCacheStateQualifier(assetId);
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => CommentDAL.GetAssetCommentIDsPaged(assetId, startRowIndex + 1, maximumRows), Get);
	}

	private static System.Data.SqlClient.SortOrder GetSqlClientSortOrder(Roblox.DataV2.Core.SortOrder sortOrder)
	{
		return sortOrder switch
		{
			Roblox.DataV2.Core.SortOrder.Asc => System.Data.SqlClient.SortOrder.Ascending, 
			Roblox.DataV2.Core.SortOrder.Desc => System.Data.SqlClient.SortOrder.Descending, 
			_ => throw new Exception($"Bad sortorder. {sortOrder}"), 
		};
	}

	public static ICollection<Comment> GetAssetCommentsByAssetId(long assetId, long? exclusiveStartId, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		string collectionId = $"GetAssetCommentsPaged_AssetID:{assetId}_ExclusiveStartID:{exclusiveStartId}_Count:{count}_SortOrder:{sortOrder}";
		string cachedStateQualifier = GetAssetIdCacheStateQualifier(assetId);
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => CommentDAL.GetAssetCommentIDsByAssetId(assetId, exclusiveStartId, count, GetSqlClientSortOrder(sortOrder)), Get);
	}

	public static int GetTotalNumberOfAssetComments(long assetId)
	{
		return DoGetTotalNumberOfAssetComments(assetId, _UseCommentsCounter);
	}

	public static bool TryFloodCheck(User authenticatedUser, Asset item)
	{
		if (!GlobalProperties.CommentPostingFloodCheckOn)
		{
			return true;
		}
		Cache cache = HttpRuntime.Cache;
		DateTime now = DateTime.Now;
		string key = "Comment:_" + authenticatedUser.ID + "_" + item.ID;
		object data = cache.Get(key);
		if (data != null)
		{
			DateTime lastPost = (DateTime)data;
			if (now.Subtract(lastPost).TotalSeconds < (double)GlobalProperties.CommentPostingIntervalInSeconds)
			{
				return false;
			}
		}
		HttpRuntime.Cache.Insert(key, now, null, now.AddSeconds(GlobalProperties.CommentPostingIntervalInSeconds + 5), Cache.NoSlidingExpiration);
		return true;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetAssetIdCacheStateQualifier(AssetID));
	}

	private static string GetAssetIdCacheStateQualifier(long assetId)
	{
		return $"AssetID:{assetId}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(CommentDAL dal)
	{
		_EntityDAL = dal;
	}
}
