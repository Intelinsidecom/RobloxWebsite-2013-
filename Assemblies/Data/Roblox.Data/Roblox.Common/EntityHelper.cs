using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Data;
using Roblox.Data.Interfaces;
using Roblox.Data.Properties;
using Roblox.EventLog;

namespace Roblox.Common;

/// <summary>
/// Contains helper methods for interacting with entities. These methods range from interacting with entities against the entity's data source (ie: database) to
/// getting entity data from a cache while falling back to a data source.
/// </summary>
/// <remarks>
/// <para>V1 entities typically interact with a caching layer (CAL or BLL, the latter being a misnomer as over the years our business logic layer has morphed to contain
/// only caching code) and a data access layer (DAL). Most entity read operations will first attempt to read data from the caching layer, and on a cache miss
/// the operation will read the data from the entity's data source and populate the cache with that data.</para>
///
/// <para>There are two layers of caching involved: local and remote. The local cache hosts the data in the memory of the process executing the operation.
/// The remote cache hosts the data on other servers.</para>
///
/// <para>The caches are also logically split into different buckets:</para>
/// <list type="bullet">
///     <item>The <b>Entity Cache</b> contains cache entries for an entity "row", keyed by the entity's ID.</item>
///     <item>The <b>Lookup Cache</b> contains cache entries linking a unique lookup to an entity's ID.</item>
///     <item>The <b>Collection Cache</b> contains cache entries linking a subset of a collection to the entity IDs in that collection subset.</item>
///     <item>The <b>Count Cache</b> contains cache entries indicating the number of entities satisfying a predicate/where clause. Unlike the other caches, this results in a count and not an ID.</item>
/// </list>
/// <para>For the local caching each logical cache is hosted by the same physical local cache. This is not the case for remote caching: For remote caching,
/// entity data is contained in Memcached; Lookup data is contained in Redis; Collection and count data is not cached remotely.</para>
/// <para>How EntityHelper (and, in actuality, CacheManager) knows where and how to cache data comes from disparate sources:
/// <list type="bullet">
///     <item>The BLL's <see cref="T:Roblox.Caching.CacheInfo" /> object dictates most of how an entity and its associated data is cached locally.</item>
///     <item>The presence of the <see cref="T:Roblox.Caching.Interfaces.IRemoteCacheableObject" /> interface on the entity's BLL dictates if the <b>entity</b> is remotely cached
///     (specifically the entity, not any other data). Additionally, the entity needs to be added to the <see cref="P:Roblox.Caching.Properties.Settings.RemoteCacheableEntities" />
///     setting.</item>
///     <item>The BLL's use of -WithRemoteCache EntityHelper methods dictates if the entity's lookups are remote cached.</item>
/// </list></para>
/// <para>The default generated behavior for an entity is that its operations will interact with all logical caches locally and only the remote entity cache. <b>Unless
/// specified otherwise, assume the individual method documentation refers to this configuration.</b></para>
/// <para>This documentation is intended to give a rough idea of EntityHelper and its associated systems' behavior. For additional information see the 
/// <a href="https://confluence.rbx.com/display/PLATFORM/Entity+Caching">Confluence</a> documents.</para>
/// </remarks>
public class EntityHelper
{
	/// <summary>
	/// Represents the result of a get or create operation against a data access layer.
	/// </summary>
	/// <typeparam name="T">The type of data access layer object.</typeparam>
	public class GetOrCreateDALWrapper<T>
	{
		/// <summary>
		/// Whether or not the entity was created as a result of the operation.
		/// </summary>
		public bool CreatedNewEntity;

		/// <summary>
		/// The <typeparamref name="T" /> that was retrieved or created.
		/// </summary>
		public T DAL;

		/// <summary>
		/// Initializes a new <see cref="T:Roblox.Common.EntityHelper.GetOrCreateDALWrapper`1" /> instance.
		/// </summary>
		/// <param name="createdNewEntity">Whether or not the entity was created as a result of the operation.</param>
		/// <param name="dal">The <typeparamref name="T" /> that was retrieved or created.</param>
		public GetOrCreateDALWrapper(bool createdNewEntity, T dal)
		{
			CreatedNewEntity = createdNewEntity;
			DAL = dal;
		}
	}

	public delegate void PostActionNonBlockingWork();

	public delegate T BuildDAL<T>(SqlDataReader dataReader);

	public delegate ICollection<T> BuildDALCollection<T>(SqlDataReader dataReader);

	public delegate void DeleteDAL();

	public delegate T Get<T>();

	public delegate TEntity GetByID<TEntity, TIndex>(TIndex id) where TIndex : struct, IComparable<TIndex>;

	public delegate ICollection<TEntity> GetCollectionByIDs<TEntity, TIndex>(ICollection<TIndex> ids) where TIndex : struct, IComparable<TIndex>;

	public delegate T GetCount<T>() where T : struct;

	public delegate ICollection<T> GetIDCollection<T>() where T : struct;

	public delegate T GetOrCreate<T>();

	public delegate GetOrCreateDALWrapper<T> GetOrCreateDAL<T>();

	public delegate void InsertDAL();

	public delegate void SetID<T>(T id) where T : struct;

	public delegate void UpdateDAL();

	/// <summary>
	/// Persists the deletion of an entity.
	/// </summary>
	/// <seealso cref="M:Roblox.Common.EntityHelper.DeleteEntityWithRemoteCache``1(Roblox.Caching.Interfaces.ICacheableObject{``0},Roblox.Common.EntityHelper.DeleteDAL)" />
	/// <remarks>
	/// <para>This method will delete an entity from cache and from its data source.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <typeparam name="T">The type of index of the <see cref="T:Roblox.Caching.Interfaces.ICacheableObject`1" />.</typeparam>
	/// <param name="entity">The cacheable entity to delete.</param>
	/// <param name="dalDeleter">The <see cref="T:Roblox.Common.EntityHelper.DeleteDAL" /> used to delete the entity from its data source.</param>
	public static void DeleteEntity<T>(ICacheableObject<T> entity, DeleteDAL dalDeleter)
	{
		dalDeleter();
		CacheManager.ProcessEntityChange(entity, StateChangeEventType.Deletion);
	}

	/// <summary>
	/// Persists the deletion of an entity, including any remotely cached lookups.
	/// </summary>
	/// <seealso cref="M:Roblox.Common.EntityHelper.DeleteEntity``1(Roblox.Caching.Interfaces.ICacheableObject{``0},Roblox.Common.EntityHelper.DeleteDAL)" />
	/// <remarks>
	/// The only difference between this method and <see cref="M:Roblox.Common.EntityHelper.DeleteEntity``1(Roblox.Caching.Interfaces.ICacheableObject{``0},Roblox.Common.EntityHelper.DeleteDAL)" /> is that this method will also delete the entity's lookups from the remote lookup cache.
	/// </remarks>
	/// <typeparam name="T">The type of index of the <see cref="T:Roblox.Caching.Interfaces.ICacheableObject`1" />.</typeparam>
	/// <param name="entity">The cacheable entity to delete.</param>
	/// <param name="dalDeleter">The <see cref="T:Roblox.Common.EntityHelper.DeleteDAL" /> used to delete the entity from its data source.</param>
	public static void DeleteEntityWithRemoteCache<T>(ICacheableObject<T> entity, DeleteDAL dalDeleter)
	{
		dalDeleter();
		CacheManager.ProcessEntityChange(entity, StateChangeEventType.Deletion);
		IEnumerable<string> enumerable = entity.BuildEntityIDLookups();
		ILookupCache remoteCache = LookupCacheFactory.GetInstance().GetLookupCache(entity.CacheInfo);
		foreach (string idLookup in enumerable)
		{
			remoteCache.RemoveEntityIDLookupCache(entity.CacheInfo, idLookup);
		}
	}

	/// <summary>
	/// Performs a data access layer action described by the given <see cref="T:Roblox.Data.DbInfo" />.
	/// </summary>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the DAL action.</param>
	/// <example>
	/// <code>
	///   EntityHelper.DoEntityDALAction(
	///       new DbInfo(
	///           DbConnectionString,
	///           "[dbo].[TicketsBalances_CreditTicketsBalanceByID]",
	///           new[]
	///           {
	///               new SqlParameter("@ID", ID),
	///           }
	///       )
	///   );
	/// </code>
	/// </example>
	public static void DoEntityDALAction(DbInfo dbInfo)
	{
		using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
		foreach (SqlParameter queryParameter in dbInfo.QueryParameters)
		{
			dbHelper.SQLParameters.Add(queryParameter);
		}
		dbHelper.ExecuteSQLNonQuery(dbInfo.StoredProcedure, (CommandType)4);
	}

	/// <summary>
	/// Performs a data access layer deletion described by the given <see cref="T:Roblox.Data.DbInfo" />.
	/// </summary>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the DAL deletion.</param>
	[Obsolete("Use the generic DoEntityDALAction instead")]
	public static void DoEntityDALDelete(DbInfo dbInfo)
	{
		DoEntityDALAction(dbInfo);
	}

	/// <summary>
	/// Performs a data access layer insertion described by the given <see cref="T:Roblox.Data.DbInfo" />.
	/// </summary>
	/// <typeparam name="T">The type of the DAL's ID.</typeparam>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the DAL insertion.</param>
	/// <returns>The ID of the inserted DAL.</returns>
	public static T DoEntityDALInsert<T>(DbInfo dbInfo) where T : struct
	{
		using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
		dbHelper.SQLParameters.Add(dbInfo.OutputParameter);
		foreach (SqlParameter queryParameter in dbInfo.QueryParameters)
		{
			dbHelper.SQLParameters.Add(queryParameter);
		}
		dbHelper.ExecuteSQLNonQuery(dbInfo.StoredProcedure, (CommandType)4);
		try
		{
			return (T)((DbParameter)dbInfo.OutputParameter).Value;
		}
		catch (InvalidCastException ex)
		{
			SqlParameter outputParameter = dbInfo.OutputParameter;
			object outputParamValue = ((outputParameter != null) ? ((DbParameter)outputParameter).Value : null);
			bool outputParamHasValue = outputParamValue != null;
			StaticLoggerRegistry.Instance.Error(string.Format("Type to cast to = {0}, Type found: {1} and paramValue = {2} Exception {3}", typeof(T).FullName, outputParamHasValue ? outputParamValue.GetType().FullName : "outputParam was null!", outputParamValue, ex));
			return outputParamHasValue ? ((T)Convert.ChangeType(outputParamValue, typeof(T))) : default(T);
		}
	}

	/// <summary>
	/// Performs a data access layer update described by the given <see cref="T:Roblox.Data.DbInfo" />.
	/// </summary>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the DAL update.</param>
	public static void DoEntityDALUpdate(DbInfo dbInfo)
	{
		DoEntityDALAction(dbInfo);
	}

	/// <summary>
	/// Gets an entity from its data source by its ID and adds the result to the cache.
	/// </summary>
	/// <remarks>
	/// This method is intended to be used as a helper method for the <see cref="M:Roblox.Common.EntityHelper.GetEntity``3(Roblox.Caching.CacheInfo,``0,System.Func{``1})" /> method, not as a standalone method.
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entity's index.</typeparam>
	/// <typeparam name="TDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="dalGetter">The <see cref="T:System.Func`1" /> used to get the entity's DAL from its data source.</param>
	/// <param name="index">The index of the entity.</param>
	/// <returns>The entity, or <c>null</c> if the entity didn't exist.</returns>
	public static TEntity DoGet<TIndex, TDal, TEntity>(Func<TDal> dalGetter, TIndex index) where TIndex : struct, IComparable<TIndex> where TDal : class where TEntity : IRobloxEntity<TIndex, TDal>, new()
	{
		TEntity entity = new TEntity();
		TDal dal = dalGetter();
		if (dal != null)
		{
			entity.Construct(dal);
			CacheManager.AddEntityToCache(entity);
			foreach (string idLookup in entity.BuildEntityIDLookups())
			{
				CacheManager.AddEntityIDToLookupCache(entity.CacheInfo, idLookup, entity.ID);
			}
		}
		else
		{
			CacheManager.AddNullEntityToCache(entity.CacheInfo, index);
			entity = default(TEntity);
		}
		return entity;
	}

	/// <summary>
	/// Gets an entity from its data source by its ID and adds both the entity and its lookups to the cache.
	/// If the resulting entity doesn't exist then instead only a null lookup result for the given ID lookup is added
	/// to the cache.
	/// </summary>
	/// <typeparam name="TIndex">The type of the entity's index.</typeparam>
	/// <typeparam name="TDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="dalGetter">The <see cref="T:System.Func`1" /> used to get the entity's DAL from its data source.</param>
	/// <param name="entityIdLookup">The entity ID lookup to add a <c>null</c> cache entry for if the DAL did not exist.</param>
	/// <returns>The entity returned by <paramref name="dalGetter" />, or <c>null</c> if <paramref name="dalGetter" /> returned null.</returns>
	public static TEntity DoGetByLookup<TIndex, TDal, TEntity>(Func<TDal> dalGetter, string entityIdLookup) where TEntity : IRobloxEntity<TIndex, TDal>, new()
	{
		TEntity entity = new TEntity();
		TDal dal = dalGetter();
		if (dal != null)
		{
			entity.Construct(dal);
			AddEntityAndIdLookupsToCache(entity);
		}
		else
		{
			AddNullEntityIDToLookupCache(entityIdLookup, entity.CacheInfo);
			entity = default(TEntity);
		}
		return entity;
	}

	/// <summary>
	/// Gets or creates an entity from/at its data source, adding the resulting entity to the cache.
	/// </summary>
	/// <typeparam name="TIndex">The type of the entity's index.</typeparam>
	/// <typeparam name="TDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="dalGetterOrCreater">The <see cref="T:Roblox.Common.EntityHelper.GetOrCreateDAL`1" /> used to get or create the entity from its data source.</param>
	/// <returns>The retrieved or created entity.</returns>
	public static TEntity DoGetOrCreate<TIndex, TDal, TEntity>(GetOrCreateDAL<TDal> dalGetterOrCreater) where TDal : class where TEntity : IRobloxEntity<TIndex, TDal>, ICacheableObject<TIndex>, new()
	{
		GetOrCreateDALWrapper<TDal> dalWrapper = dalGetterOrCreater();
		TDal dal = ((dalWrapper != null) ? dalWrapper.DAL : null);
		if (dal != null)
		{
			TEntity entity = new TEntity();
			entity.Construct(dal);
			if (dalWrapper.CreatedNewEntity)
			{
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Creation);
			}
			else
			{
				CacheManager.AddEntityToCache(entity);
			}
			{
				foreach (string idLookup in entity.BuildEntityIDLookups())
				{
					TIndex id = entity.ID;
					CacheManager.AddEntityIDToLookupCache(entity.CacheInfo, idLookup, id);
				}
				return entity;
			}
		}
		throw new ApplicationException($"GetOrCreate failure ({typeof(TDal).Name} is null).");
	}

	/// <summary>
	/// Executes an action described by the given <see cref="T:Roblox.Data.DbInfo" /> to get a count directly from a database.
	/// </summary>
	/// <typeparam name="T">The type of count (eg: <see cref="T:System.Int32" />, <see cref="T:System.Int64" />).</typeparam>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the database action.</param>
	/// <returns>The data count.</returns>
	public static T GetDataCount<T>(DbInfo dbInfo)
	{
		object count;
		using (DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString))
		{
			foreach (SqlParameter queryParameter in dbInfo.QueryParameters)
			{
				dbHelper.SQLParameters.Add(queryParameter);
			}
			count = dbHelper.ExecuteSQLScalar(dbInfo.StoredProcedure, (CommandType)4);
		}
		if (count == DBNull.Value)
		{
			return default(T);
		}
		return (T)count;
	}

	/// <summary>
	/// Executes an action described by the given <see cref="T:Roblox.Data.DbInfo" /> to get a ID collection directly from a database.
	/// </summary>
	/// <typeparam name="T">The type of ID.</typeparam>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the database action.</param>
	/// <returns>The collection of IDs.</returns>
	public static ICollection<T> GetDataEntityIDCollection<T>(DbInfo dbInfo) where T : struct
	{
		using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
		foreach (SqlParameter queryParameter in dbInfo.QueryParameters)
		{
			dbHelper.SQLParameters.Add(queryParameter);
		}
		SqlDataReader dataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, (CommandType)4);
		try
		{
			return DbHelper.BuildIDCollection<T>(dataReader);
		}
		finally
		{
			((IDisposable)dataReader)?.Dispose();
		}
	}

	/// <summary>
	/// Gets the <see cref="T:System.Data.SqlClient.SqlParameter" /> containing the given <see cref="T:System.Collections.Generic.IEnumerable`1" /> of IDs.
	/// </summary>
	/// <typeparam name="TIndex">The type of the IDs.</typeparam>
	/// <param name="indices">The IDs to build a <see cref="T:System.Data.SqlClient.SqlParameter" /> for.</param>
	/// <param name="parameterName">The name of the <see cref="T:System.Data.SqlClient.SqlParameter" />.</param>
	/// <returns>The <see cref="T:System.Data.SqlClient.SqlParameter" />.</returns>
	public static SqlParameter GetMultiGetIDsSqlParameter<TIndex>(IEnumerable<TIndex> indices, string parameterName = "IDs")
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		DataTable dataTable = new DataTable(GetTableTypeName<TIndex>());
		dataTable.Columns.Add("ID", typeof(TIndex));
		foreach (TIndex index in indices)
		{
			dataTable.Rows.Add(new object[1] { index });
		}
		return new SqlParameter
		{
			ParameterName = parameterName,
			SqlDbType = (SqlDbType)30,
			Value = dataTable
		};
	}

	/// <summary>
	/// Converts the given <see cref="T:System.Collections.Generic.IEnumerable`1" /> of IDs to an array of <see cref="T:System.Data.SqlClient.SqlParameter" />s.
	/// </summary>
	/// <typeparam name="TIndex">The type of the IDs.</typeparam>
	/// <param name="indices">The IDs to convert into <see cref="T:System.Data.SqlClient.SqlParameter" />s.</param>
	/// <returns>The IDs as <see cref="T:System.Data.SqlClient.SqlParameter" />s.</returns>
	public static SqlParameter[] GetMultiGetIDsSqlParameters<TIndex>(IEnumerable<TIndex> indices)
	{
		return (SqlParameter[])(object)new SqlParameter[1] { GetMultiGetIDsSqlParameter(indices) };
	}

	private static ICollection<TEntity> BuildDalCollection<TEntity, TIndex>(DbInfo dbInfo, BuildDALCollection<TEntity> dalCollectionBuilder, IEnumerable<TIndex> indices)
	{
		using DbHelper dbHelper = DBHelperFactory.GetDBHelper(dbInfo.ConnectionString);
		SqlParameter parameter = GetMultiGetIDsSqlParameter(indices);
		dbHelper.SQLParameters.Add(parameter);
		SqlDataReader dataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, (CommandType)4);
		try
		{
			ICollection<TEntity> dalCollection = dalCollectionBuilder(dataReader);
			return dalCollection ?? new List<TEntity>();
		}
		finally
		{
			((IDisposable)dataReader)?.Dispose();
		}
	}

	/// <summary>
	/// Executes an action described by the given <see cref="T:Roblox.Data.DbInfo" /> to get a collection of entities by their IDs directly from the database.
	/// </summary>
	/// <typeparam name="TEntity">The type of entities.</typeparam>
	/// <typeparam name="TIndex">The type of the entities' IDs.</typeparam>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the database action used to get the entities by their IDs.</param>
	/// <param name="indices">The IDs of the entities to get.</param>
	/// <param name="dalBuilderMultiple">The <see cref="T:Roblox.Common.EntityHelper.BuildDALCollection`1" /> used to convert the database results to a collection of entities.</param>
	/// <returns>The collection of entities.</returns>
	public static ICollection<TEntity> GetEntityDALCollection<TEntity, TIndex>(DbInfo dbInfo, ICollection<TIndex> indices, BuildDALCollection<TEntity> dalBuilderMultiple)
	{
		List<TEntity> dals = new List<TEntity>();
		int batchSize = Settings.Default.DatabaseBulkQueryLimit;
		int batchIndex = 0;
		IEnumerable<TIndex> batchedIds = indices.Skip(batchIndex * batchSize).Take(batchSize).ToList();
		while (batchedIds.Any())
		{
			ICollection<TEntity> dalCollection = BuildDalCollection(dbInfo, dalBuilderMultiple, batchedIds);
			dals.AddRange(dalCollection);
			batchIndex++;
			batchedIds = indices.Skip(batchIndex * batchSize).Take(batchSize).ToList();
		}
		return dals;
	}

	/// <summary>
	/// Gets an entity by its ID.
	/// </summary>
	/// <remarks>
	/// This method attempts to get an entity from cache, and if the entity is not in cache then it will use the given <see cref="T:System.Func`1" />
	/// to get the entity from its source. Crucially, no entity data is put into cache after it's retrieved from its source. This is the main difference
	/// from <see cref="M:Roblox.Common.EntityHelper.GetEntity``3(Roblox.Caching.CacheInfo,``0,System.Func{``1})" />.
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="identifier">The ID of the entity to get.</param>
	/// <param name="getter">The <see cref="T:System.Func`1" /> used to get the entity from its data source.</param>
	/// <returns>The entity, or <c>null</c> if no entity exists with the given ID.</returns>
	public static TEntity GetEntityOld<TIndex, TEntity>(CacheInfo cacheInfo, TIndex identifier, Func<TEntity> getter) where TEntity : class, ICacheableObject<TIndex>
	{
		return CacheManager.GetEntityFromCache(cacheInfo, identifier, getter);
	}

	/// <summary>
	/// Gets an entity from the cache without falling back to its data source on a cache miss.
	/// </summary>
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="identifier">The ID of the entity to get.</param>
	/// <param name="cacheHit">Whether or not an entry for the entity was found in cache.</param>
	/// <returns>The entity or <c>null</c>. <c>null</c> maybe mean a null entry was found in cache or that there was a cache miss,
	/// in which case one should refer to <paramref name="cacheHit" />.</returns>
	public static TEntity TryGetEntityFromCache<TIndex, TDal, TEntity>(CacheInfo cacheInfo, TIndex identifier, out bool cacheHit) where TIndex : struct, IComparable<TIndex> where TEntity : class, IRobloxEntity<TIndex, TDal>, new()
	{
		return CacheManager.TryGetEntityOnlyFromCache<TIndex, TEntity>(cacheInfo, identifier, out cacheHit);
	}

	/// <summary>
	/// Gets an entity by its ID.
	/// </summary>
	/// <remarks>
	/// This method attempts to get an entity from cache, and if the entity is not in cache then it will use the given <see cref="T:System.Func`1" />
	/// to get the entity from its source. The missing entity data is put into cache after it's retrieved from its source. This is the main difference
	/// from <see cref="M:Roblox.Common.EntityHelper.GetEntityOld``2(Roblox.Caching.CacheInfo,``0,System.Func{``1})" />.
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="identifier">The ID of the entity to get.</param>
	/// <param name="getter">The <see cref="T:System.Func`1" /> used to get the entity from its data source.</param>
	/// <returns>The entity, or <c>null</c> if no entity exists with the given ID.</returns>
	public static TEntity GetEntity<TIndex, TDal, TEntity>(CacheInfo cacheInfo, TIndex identifier, Func<TDal> getter) where TIndex : struct, IComparable<TIndex> where TDal : class where TEntity : class, IRobloxEntity<TIndex, TDal>, new()
	{
		return CacheManager.GetEntityFromCache(cacheInfo, identifier, () => DoGet<TIndex, TDal, TEntity>(getter, identifier));
	}

	/// <summary>
	/// Gets a collection of entities by their IDs directly from their data source, putting the results into cache.
	/// </summary>
	/// <remarks>
	/// This method is intended to be used as part of getting an entity collection, not as a standalone multi-get.
	/// <b>For a standalone multi-get, use <see cref="M:Roblox.Common.EntityHelper.GetEntitiesByIds``3(Roblox.Caching.CacheInfo,System.Collections.Generic.IReadOnlyCollection{``2},Roblox.Common.EntityHelper.GetCollectionByIDs{``1,``2})" />.</b>
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entities' IDs.</typeparam>
	/// <typeparam name="TDal">The type of the entities' DALs.</typeparam>
	/// <typeparam name="TEntity">The type of the entities.</typeparam>
	/// <param name="ids">The ID of the entities to get.</param>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entities are cached.</param>
	/// <param name="getterMultiple">
	///     The <see cref="T:System.Func`2" /> used to get the entities by their IDs from their data source. This collection should only contain
	///     <typeparamref name="TDal" /> instances (ie: null entries associated with IDs for which there was no entity should not be added.
	/// </param>
	/// <returns>The collection of entities with the given IDs.</returns>
	public static ICollection<TEntity> MultiGetEntity<TIndex, TDal, TEntity>(ICollection<TIndex> ids, CacheInfo cacheInfo, Func<ICollection<TIndex>, ICollection<TDal>> getterMultiple) where TIndex : struct, IComparable<TIndex> where TDal : class where TEntity : class, IRobloxEntity<TIndex, TDal>, new()
	{
		ICollection<TEntity> entities = new List<TEntity>();
		foreach (TDal dalEntity in getterMultiple(ids))
		{
			TEntity entity = new TEntity();
			entity.Construct(dalEntity);
			CacheManager.AddEntityToCache(entity);
			foreach (string idLookup in entity.BuildEntityIDLookups())
			{
				CacheManager.AddEntityIDToLookupCache(entity.CacheInfo, idLookup, entity.ID);
			}
			entities.Add(entity);
		}
		return entities;
	}

	/// <summary>
	/// Get an entity by a lookup.
	/// </summary>
	/// <remarks> 
	/// <para>This method attempts to get an entity from cache by a lookup. If the lookup is in not in cache, the method will use the given <see cref="T:Roblox.Common.EntityHelper.Get`1" />
	/// to get the entity by its lookup from its data source. If the lookup <i>is</i> in cache, then the method will also attempt to get the entity by its
	/// ID from cache. If the ID entry is missing then the method will again use the given <see cref="T:Roblox.Common.EntityHelper.Get`1" /> to get the entity from its data source.</para>
	///
	/// <para>On a cache miss, no data will be written to the cache.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <seealso cref="M:Roblox.Common.EntityHelper.GetEntityByLookup``3(Roblox.Caching.CacheInfo,System.String,System.Func{``1})" />
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="lookup">The lookup by which to get the entity.</param>
	/// <param name="getter">The <see cref="T:Roblox.Common.EntityHelper.Get`1" /> used to get the entity by the lookup from its data source.</param>
	/// <returns>The entity resulting from the lookup, or <c>null</c> if the lookup resulted in no entity.</returns>
	public static TEntity GetEntityByLookupOld<TIndex, TEntity>(CacheInfo cacheInfo, string lookup, Get<TEntity> getter) where TIndex : struct, IComparable<TIndex> where TEntity : class, ICacheableObject<TIndex>
	{
		return CacheManager.GetEntityFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, lookup, () => getter());
	}

	/// <summary>
	/// Gets an entity by a lookup.
	/// </summary>
	/// <remarks>
	/// <para>This method attempts to get an entity from cache by a lookup. If the lookup is in not in cache, the method will use the given <see cref="T:System.Func`1" />
	/// to get the entity by its lookup from its data source. If the lookup <i>is</i> in cache, then the method will also attempt to get the entity by its
	/// ID from cache. If the ID entry is missing then the method will again use the given <see cref="T:System.Func`1" /> to get the entity from its data source.</para>
	///
	/// <para>On a cache miss, entity data read from the data source will be written to both the entity cache and the lookup cache.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="lookup">The lookup by which to get the entity.</param>
	/// <param name="getter">The <see cref="T:System.Func`1" /> used to get the entity by the lookup from its data source.</param>
	/// <returns>The entity resulting from the lookup, or <c>null</c> if the lookup resulted in no entity.</returns>
	public static TEntity GetEntityByLookup<TIndex, TDal, TEntity>(CacheInfo cacheInfo, string lookup, Func<TDal> getter) where TIndex : struct, IComparable<TIndex> where TDal : class where TEntity : class, IRobloxEntity<TIndex, TDal>, new()
	{
		return CacheManager.GetEntityFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, lookup, () => DoGetByLookup<TIndex, TDal, TEntity>(getter, lookup));
	}

	/// <summary>
	/// Gets an entity by a lookup.
	/// </summary>
	/// <remarks>
	/// <para>This method attempts to get an entity from cache by a lookup. If the lookup is in not in cache, the method will use the given <see cref="T:System.Func`1" />
	/// to get the entity by its lookup from its data source. If the lookup <i>is</i> in cache, then the method will also attempt to get the entity by its
	/// ID from cache. If the ID entry is missing then the method will use the given <see cref="T:System.Func`2" /> to get the entity from its data source by its ID.</para>
	///
	/// <para>On a cache miss, entity data read from the data source will be written to both the entity cache and the lookup cache.</para>
	///
	/// <para>This method interacts with both the remote entity cache and the remote lookup cache.</para>
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="entityIdLookup">The lookup by which to get the entity.</param>
	/// <param name="dalGetter">The <see cref="T:System.Func`1" /> used to get the entity by the lookup from its data source.</param>
	/// <param name="entityGetterById">The <see cref="T:System.Func`2" /> used to get the entity by its ID from its data source.</param>
	/// <returns>The entity resulting from the lookup, or <c>null</c> if the lookup resulted in no entity.</returns>
	public static TEntity GetEntityByLookupWithRemoteCache<TIndex, TDal, TEntity>(CacheInfo cacheInfo, string entityIdLookup, Func<TDal> dalGetter, Func<TIndex, TEntity> entityGetterById) where TIndex : struct, IComparable<TIndex> where TDal : class where TEntity : class, IRobloxEntity<TIndex, TDal>, new()
	{
		return CacheManager.GetEntityFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, entityIdLookup, delegate
		{
			ILookupCache lookupCache = LookupCacheFactory.GetInstance().GetLookupCache(cacheInfo);
			var (flag, arg) = lookupCache.GetEntityIDFromLookupCache<TIndex>(cacheInfo, entityIdLookup);
			TEntity val;
			if (flag)
			{
				if (!arg.Equals(default(TIndex)))
				{
					val = entityGetterById(arg);
					if (val != null)
					{
						AddEntityAndIdLookupsToCache(val);
					}
					else
					{
						lookupCache.RemoveEntityIDLookupCache(cacheInfo, entityIdLookup);
					}
				}
				else
				{
					val = null;
					AddNullEntityIDToLookupCache(entityIdLookup, cacheInfo);
				}
			}
			else
			{
				val = DoGetByLookup<TIndex, TDal, TEntity>(dalGetter, entityIdLookup);
				lookupCache.AddEntityIDToLookupCache(cacheInfo, entityIdLookup, val?.ID);
			}
			return val;
		});
	}

	/// <summary>
	/// Gets a collection of entities.
	/// </summary>
	/// <remarks>
	/// This is a top level method that fully interacts with the cache and the data source. This occurs in two steps
	/// <list type="number">
	///     <item>The IDs of the items in the collection are fetched from cache, falling back to the data source using <paramref name="idCollectionGetter" /> on a cache miss.</item>
	///     <item>The entities are fetched from cache by their IDs, falling back to the data source using <paramref name="entityGetter" /> on a cache miss.</item>
	/// </list>
	///
	/// <para>This method interacts with the remote entity cache. There is no remote collection cache.</para>
	///
	/// <para>The difference between this method and <see cref="M:Roblox.Common.EntityHelper.GetEntityCollection``2(Roblox.Caching.CacheInfo,Roblox.Caching.CacheManager.CachePolicy,System.String,Roblox.Common.EntityHelper.GetIDCollection{``1},Roblox.Common.EntityHelper.GetCollectionByIDs{``0,``1})" />
	/// is that this method uses a singular get to get each entity by its ID individually, whereas <see cref="M:Roblox.Common.EntityHelper.GetEntityCollection``2(Roblox.Caching.CacheInfo,Roblox.Caching.CacheManager.CachePolicy,System.String,Roblox.Common.EntityHelper.GetIDCollection{``1},Roblox.Common.EntityHelper.GetCollectionByIDs{``0,``1})" />
	/// uses a multi get.</para>
	/// </remarks>
	/// <typeparam name="TEntity">The type of the entities.</typeparam>
	/// <typeparam name="TIndex">The type of the entities' IDs.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entities are cached.</param>
	/// <param name="cachePolicy">The <see cref="T:Roblox.Caching.CacheManager.CachePolicy" /> describing how the collection is cached.</param>
	/// <param name="collectionId">The collection ID.</param>
	/// <param name="idCollectionGetter">The <see cref="T:Roblox.Common.EntityHelper.GetIDCollection`1" /> used to get the ID collection from the data source.</param>
	/// <param name="entityGetter">The <see cref="T:Roblox.Common.EntityHelper.GetByID`2" /> used to get each cache-missed entity by its ID from the data source.</param>
	/// <returns>The entities in the collection.</returns>
	public static ICollection<TEntity> GetEntityCollection<TEntity, TIndex>(CacheInfo cacheInfo, CacheManager.CachePolicy cachePolicy, string collectionId, GetIDCollection<TIndex> idCollectionGetter, GetByID<TEntity, TIndex> entityGetter) where TIndex : struct, IComparable<TIndex>
	{
		ICollection<TEntity> entities = new List<TEntity>();
		foreach (TIndex id in GetEntityIDCollection(cacheInfo, cachePolicy, collectionId, idCollectionGetter))
		{
			TEntity entity = entityGetter(id);
			entities.Add(entity);
		}
		return entities;
	}

	/// <summary>
	/// Gets a collection of entities.
	/// </summary>
	/// <remarks>
	/// This is a top level method that fully interacts with the cache and the data source. This occurs in two steps:
	/// <list type="number">
	///     <item>The IDs of the items in the collection are fetched from cache, falling back to the data source using <paramref name="idCollectionGetter" /> on a cache miss.</item>
	///     <item>The entities are fetched from cache by their IDs, falling back to the data source using <paramref name="entityGetterMultiple" /> on a cache miss.</item>
	/// </list>
	///
	/// <para>This method interacts with the remote entity cache. There is no remote collection cache.</para>
	///
	/// <para>The difference between this method and <see cref="M:Roblox.Common.EntityHelper.GetEntityCollection``2(Roblox.Caching.CacheInfo,Roblox.Caching.CacheManager.CachePolicy,System.String,Roblox.Common.EntityHelper.GetIDCollection{``1},Roblox.Common.EntityHelper.GetByID{``0,``1})" />
	/// is that this method uses a multi get to get all cache-missed entities at once, whereas <see cref="M:Roblox.Common.EntityHelper.GetEntityCollection``2(Roblox.Caching.CacheInfo,Roblox.Caching.CacheManager.CachePolicy,System.String,Roblox.Common.EntityHelper.GetIDCollection{``1},Roblox.Common.EntityHelper.GetByID{``0,``1})" />
	/// uses a singular get to get each cache-missed entity individually.</para>
	/// </remarks>
	/// <typeparam name="TEntity">The type of the entities.</typeparam>
	/// <typeparam name="TIndex">The type of the entities' IDs.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entities are cached.</param>
	/// <param name="cachePolicy">The <see cref="T:Roblox.Caching.CacheManager.CachePolicy" /> describing how the collection is cached.</param>
	/// <param name="collectionId">The collection ID.</param>
	/// <param name="idCollectionGetter">The <see cref="T:Roblox.Common.EntityHelper.GetIDCollection`1" /> used to get the ID collection from the data source.</param>
	/// <param name="entityGetterMultiple">The <see cref="T:Roblox.Common.EntityHelper.GetCollectionByIDs`2" /> used to get the cache-missed entities by their IDs from the data source.</param>
	/// <returns>The entities in the collection.</returns>
	public static ICollection<TEntity> GetEntityCollection<TEntity, TIndex>(CacheInfo cacheInfo, CacheManager.CachePolicy cachePolicy, string collectionId, GetIDCollection<TIndex> idCollectionGetter, GetCollectionByIDs<TEntity, TIndex> entityGetterMultiple) where TEntity : class, ICacheableObject<TIndex> where TIndex : struct, IComparable<TIndex>
	{
		List<TIndex> entityIdCollection = GetEntityIDCollection(cacheInfo, cachePolicy, collectionId, idCollectionGetter).ToList();
		return GetEntitiesByIds(cacheInfo, entityIdCollection, entityGetterMultiple);
	}

	/// <summary>
	/// Gets an entity collection by a collection of lookup keys.
	/// </summary>
	/// <typeparam name="TEntity">The type of the entity on which the operation is being performed.</typeparam>
	/// <typeparam name="TIndex">The type of the primary key of the entity.</typeparam>
	/// <param name="cacheInfo"><see cref="T:Roblox.Caching.CacheInfo" /></param>
	/// <param name="cachePolicy"><see cref="T:Roblox.Caching.CacheManager.CachePolicy" /></param>
	/// <param name="idToCacheKeyLookupMap">A map of the lookup key to the cache key for lookup.</param>
	/// <param name="idCollectionGetter">The DAL method that accesses the data source to multiget ids by lookup keys.</param>
	/// <param name="entityGetterMultiple">Multiget for entity by primary key.</param>
	/// <returns></returns>
	public static ICollection<TEntity> GetEntityCollection<TEntity, TIndex>(CacheInfo cacheInfo, CacheManager.CachePolicy cachePolicy, SortedDictionary<TIndex, string> idToCacheKeyLookupMap, Func<ICollection<TIndex>, ICollection<TIndex>> idCollectionGetter, GetCollectionByIDs<TEntity, TIndex> entityGetterMultiple) where TEntity : class, ICacheableObject<TIndex> where TIndex : struct, IComparable<TIndex>
	{
		List<TIndex> entityIdCollection = GetEntityIDCollection(cacheInfo, cachePolicy, idToCacheKeyLookupMap, idCollectionGetter).ToList();
		return GetEntitiesByIds(cacheInfo, entityIdCollection, entityGetterMultiple);
	}

	/// <summary>
	/// Gets entities by their IDs.
	/// </summary>
	/// <remarks>
	/// <para>This method fully interacts with the entity cache. The method will attempt to get the entities from cache, falling back to the data source
	/// on a cache miss using <paramref name="entityDalGetterMultiple" />.</para>
	///
	/// <para>This method interacts with the remote entity cache.</para>
	///
	/// <para>This method is similar to <see cref="M:Roblox.Common.EntityHelper.GetEntitiesByIds``3(Roblox.Caching.CacheInfo,System.Collections.Generic.IReadOnlyCollection{``2},Roblox.Common.EntityHelper.GetCollectionByIDs{``1,``2})" />, but this method uses a <see cref="T:Roblox.Common.EntityHelper.GetCollectionByIDs`2" />
	/// to get get cacheable entities rather than having the method build the cacheable entities from a DAL.</para>
	/// </remarks>
	/// <typeparam name="TEntity"></typeparam>
	/// <typeparam name="TIndex"></typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entities are cached.</param>
	/// <param name="entityIdCollection">The IDs of the entities to get.</param>
	/// <param name="entityGetterMultiple">The <see cref="T:Roblox.Common.EntityHelper.GetCollectionByIDs`2" /> used to get the entities at their data source.</param>
	/// <returns>The entities with the given IDs, in order, and containing <c>null</c> elements in position where the ID was not associated with a non-existent entity.</returns>
	private static ICollection<TEntity> GetEntitiesByIds<TEntity, TIndex>(CacheInfo cacheInfo, IReadOnlyList<TIndex> entityIdCollection, GetCollectionByIDs<TEntity, TIndex> entityGetterMultiple) where TEntity : class, ICacheableObject<TIndex> where TIndex : struct, IComparable<TIndex>
	{
		List<TEntity> entities = new List<TEntity>();
		List<TIndex> uncachedEntityIds = new List<TIndex>();
		Dictionary<TIndex, int> idOrderDictionary = new Dictionary<TIndex, int>();
		foreach (var item in CacheManager.TryGetEntitiesOnlyFromCache<TIndex, TEntity>(cacheInfo, entityIdCollection))
		{
			var (id2, result2, _) = item;
			if (!item.CacheHit)
			{
				HandleCacheMiss(id2);
			}
			else
			{
				HandleCacheHit(result2);
			}
		}
		if (uncachedEntityIds.Count > 0)
		{
			foreach (TEntity entity in entityGetterMultiple(uncachedEntityIds))
			{
				int entityIndex = idOrderDictionary[entity.ID];
				entities[entityIndex] = entity;
			}
		}
		for (int i = 0; i < entities.Count; i++)
		{
			if (entities[i] == null)
			{
				CacheManager.AddNullEntityToCache(cacheInfo, entityIdCollection[i]);
			}
		}
		return entities;
		void HandleCacheHit(TEntity result)
		{
			entities.Add(result);
		}
		void HandleCacheMiss(TIndex id)
		{
			uncachedEntityIds.Add(id);
			entities.Add(null);
			idOrderDictionary.Add(id, entities.Count - 1);
		}
	}

	/// <summary>
	/// Gets entities by their IDs.
	/// </summary>
	/// <remarks>
	/// <para>This method fully interacts with the entity cache. The method will attempt to get the entities from cache, falling back to the data source
	/// on a cache miss using <paramref name="entityDalGetterMultiple" />.</para>
	///
	/// <para>This method interacts with the remote entity cache.</para>
	///
	/// <para><b>This method <i>is</i> a standalone multi-get.</b></para>
	/// </remarks>
	/// <typeparam name="TEntity">The type of the entities to get.</typeparam>
	/// <typeparam name="TEntityDal">The type of the entity's DAL.</typeparam>
	/// <typeparam name="TIndex">The type of the entities' IDs.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entities are cached.</param>
	/// <param name="ids">The IDs of the entities to get.</param>
	/// <param name="entityDalGetterMultiple">The <see cref="T:Roblox.Common.EntityHelper.GetCollectionByIDs`2" /> used to get the cache-missed entities from their data source.</param>
	/// <returns>The entities with the given IDs, in order, and containing <c>null</c> elements in position where the ID was not associated with a non-existent entity.</returns>
	public static IEnumerable<TEntity> GetEntitiesByIds<TEntity, TEntityDal, TIndex>(CacheInfo cacheInfo, IReadOnlyCollection<TIndex> ids, GetCollectionByIDs<TEntityDal, TIndex> entityDalGetterMultiple) where TEntity : class, IRobloxEntity<TIndex, TEntityDal>, new() where TEntityDal : class where TIndex : struct, IComparable<TIndex>
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		if (entityDalGetterMultiple == null)
		{
			throw new ArgumentNullException("entityDalGetterMultiple");
		}
		(TIndex Id, TEntity Result, bool CacheHit)[] source = CacheManager.TryGetEntitiesOnlyFromCache<TIndex, TEntity>(cacheInfo, ids).ToArray();
		Dictionary<TIndex, TEntity> entitiesByIds = source.ToDictionary(((TIndex Id, TEntity Result, bool CacheHit) cr) => cr.Id, ((TIndex Id, TEntity Result, bool CacheHit) cr) => cr.Result);
		List<TIndex> cacheMissIds = (from cr in source
			where !cr.CacheHit
			select cr.Id).Distinct().ToList();
		if (cacheMissIds.Any())
		{
			Dictionary<TIndex, TEntity> sourceEntitiesByIds = (from dal in entityDalGetterMultiple(cacheMissIds)
				where dal != null
				select dal).ToArray().Select(delegate(TEntityDal dal)
			{
				TEntity val = new TEntity();
				val.Construct(dal);
				return val;
			}).ToDictionary((TEntity entity) => entity.ID);
			foreach (TIndex id in cacheMissIds)
			{
				if (!sourceEntitiesByIds.TryGetValue(id, out var sourceEntity) || sourceEntity == null)
				{
					CacheManager.AddNullEntityToCache(cacheInfo, id);
				}
				else
				{
					CacheManager.AddEntityToCache(sourceEntity);
					foreach (string lookup in sourceEntity.BuildEntityIDLookups())
					{
						CacheManager.AddEntityIDToLookupCache(cacheInfo, lookup, sourceEntity.ID);
					}
				}
				entitiesByIds[id] = sourceEntity;
			}
		}
		return entitiesByIds.Values;
	}

	/// <summary>
	/// Gets a collection of entity IDs.
	/// </summary>
	/// <remarks>
	/// This method interacts with the local collection cache (there is no remote collection cache). On a cache miss, the method will populate the cache using the
	/// results from <paramref name="idCollectionGetter" />.
	/// </remarks>
	/// <typeparam name="TIndex">The type of entity IDs.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="cachePolicy">The <see cref="T:Roblox.Caching.CacheManager.CachePolicy" /> describing how the ID collection is cached.</param>
	/// <param name="collectionId">The collection ID.</param>
	/// <param name="idCollectionGetter">The <see cref="T:Roblox.Common.EntityHelper.GetIDCollection`1" /> used to get the ID collection from its data source.</param>&gt;
	/// <returns>The collection of IDs.</returns>
	public static IEnumerable<TIndex> GetEntityIDCollection<TIndex>(CacheInfo cacheInfo, CacheManager.CachePolicy cachePolicy, string collectionId, GetIDCollection<TIndex> idCollectionGetter) where TIndex : struct, IComparable<TIndex>
	{
		if (cachePolicy == null)
		{
			return idCollectionGetter();
		}
		return CacheManager.GetIDCollectionFromCache(cacheInfo, collectionId, delegate(ref CacheManager.CachePolicy policy)
		{
			policy = cachePolicy;
			return idCollectionGetter();
		});
	}

	/// <summary>
	/// Gets an entity Id collection using the cache or the getterByLookUps on cache misses.
	/// </summary>
	/// <typeparam name="TIndex">The type of the primary key of the entity.</typeparam>
	/// <param name="cacheInfo"><see cref="T:Roblox.Caching.CacheInfo" /></param>
	/// <param name="cachePolicy"><see cref="T:Roblox.Caching.CacheManager.CachePolicy" /></param>
	/// <param name="idToCacheKeyLookupMap">A map of the lookup key to the cache lookup key.</param>
	/// <param name="getterByLookUps">The DAL method that accesses the data source to multiget ids by lookup keys.</param>
	/// <returns></returns>
	public static IEnumerable<TIndex> GetEntityIDCollection<TIndex>(CacheInfo cacheInfo, CacheManager.CachePolicy cachePolicy, SortedDictionary<TIndex, string> idToCacheKeyLookupMap, Func<ICollection<TIndex>, ICollection<TIndex>> getterByLookUps) where TIndex : struct, IComparable<TIndex>
	{
		if (cachePolicy == null)
		{
			return getterByLookUps(idToCacheKeyLookupMap.Select((KeyValuePair<TIndex, string> x) => x.Key).ToList());
		}
		return CacheManager.GetIDCollectionFromCache(cacheInfo, idToCacheKeyLookupMap, getterByLookUps);
	}

	/// <summary>
	/// Gets a count of entities.
	/// </summary>
	/// <remarks>
	/// This method interacts fully with the local count cache (there is no remote count cache). On a cache miss, the count will be populated using the
	/// result from <paramref name="getter" />.
	/// </remarks>
	/// <typeparam name="T">The type of count (eg: <see cref="T:System.Int32" />, <see cref="T:System.Int64" />).</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="cachePolicy">The <see cref="T:Roblox.Caching.CacheManager.CachePolicy" /> describing how the count is cached.</param>
	/// <param name="countId">The ID of the count.</param>
	/// <param name="getter">The <see cref="T:Roblox.Common.EntityHelper.GetCount`1" /> used to get the count from its data source.</param>
	/// <returns>The count of entities.</returns>
	public static T GetEntityCount<T>(CacheInfo cacheInfo, CacheManager.CachePolicy cachePolicy, string countId, GetCount<T> getter) where T : struct
	{
		return CacheManager.GetCountFromCache(cacheInfo, countId, delegate(ref CacheManager.CachePolicy policy)
		{
			policy = cachePolicy;
			return getter();
		});
	}

	/// <summary>
	/// Gets an entity DAL from its data source.
	/// </summary>
	/// <remarks>
	/// This method does not interact with any cache.
	/// </remarks>
	/// <typeparam name="T">The type of the entity DAL.</typeparam>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the database action used to get the data.</param>
	/// <param name="dalBuilder">The <see cref="T:Roblox.Common.EntityHelper.BuildDAL`1" /> used to deserialize the data.</param>
	/// <returns>An entity DAL instance of type <typeparamref name="T" /> or <c>null</c>.</returns>
	public static T GetEntityDAL<T>(DbInfo dbInfo, BuildDAL<T> dalBuilder)
	{
		using DbHelper dbHelper = DBHelperFactory.GetDBHelper(dbInfo.ConnectionString);
		foreach (SqlParameter queryParameter in dbInfo.QueryParameters)
		{
			dbHelper.SQLParameters.Add(queryParameter);
		}
		SqlDataReader dataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, (CommandType)4);
		try
		{
			return dalBuilder(dataReader);
		}
		finally
		{
			((IDisposable)dataReader)?.Dispose();
		}
	}

	/// <summary>
	/// Gets an entity by a unique lookup, creating the entity if it did not exist.
	/// </summary>
	/// <remarks>
	/// <para>This method attempts to get a cached lookup. On a cache miss, or if the cache result indicated a non-existent entity, the operation will be executed against
	/// the data source using <paramref name="getterOrCreator" /> and the result will be cached.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <seealso cref="M:Roblox.Common.EntityHelper.GetOrCreateEntityWithRemoteCache``2(Roblox.Caching.CacheInfo,System.String,Roblox.Common.EntityHelper.GetOrCreate{``1},System.Func{``0,``1})" />
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="entityIdLookup">The ID of the lookup.</param>
	/// <param name="getterOrCreator">The <see cref="T:Roblox.Common.EntityHelper.GetOrCreate`1" /> used to get or create the entity at its data source.</param>
	/// <returns>The retrieved or created <typeparamref name="TEntity" />.</returns>
	public static TEntity GetOrCreateEntity<TIndex, TEntity>(CacheInfo cacheInfo, string entityIdLookup, GetOrCreate<TEntity> getterOrCreator) where TIndex : struct, IComparable<TIndex> where TEntity : class, ICacheableObject<TIndex>
	{
		return CacheManager.GetEntityFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, entityIdLookup, () => getterOrCreator()) ?? getterOrCreator();
	}

	/// <summary>
	/// Gets an entity by a unique lookup, creating the entity if it did not exist.
	/// </summary>
	/// <remarks>
	/// <para>This method attempts to get a cached lookup. On a cache miss, or if the cache result indicated a non-existent entity, the operation will be executed against
	/// the data source using <paramref name="getterOrCreator" /> and the result will be cached.</para>
	///
	/// <para>This method interacts with the remote entity cache and the remote lookup cache.</para>
	/// </remarks>
	/// <seealso cref="M:Roblox.Common.EntityHelper.GetOrCreateEntityWithRemoteCache``2(Roblox.Caching.CacheInfo,System.String,Roblox.Common.EntityHelper.GetOrCreate{``1},System.Func{``0,``1})" />
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="cacheInfo">The <see cref="T:Roblox.Caching.CacheInfo" /> describing how the entity is cached.</param>
	/// <param name="entityIdLookup">The ID of the lookup.</param>
	/// <param name="getterOrCreator">The <see cref="T:Roblox.Common.EntityHelper.GetOrCreate`1" /> used to get or create the entity at its data source.</param>
	/// <param name="getterById">The <see cref="T:System.Func`2" /> used to get the entity by its ID.</param>
	/// <returns>The retrieved or created <typeparamref name="TEntity" />.</returns>
	public static TEntity GetOrCreateEntityWithRemoteCache<TIndex, TEntity>(CacheInfo cacheInfo, string entityIdLookup, GetOrCreate<TEntity> getterOrCreator, Func<TIndex, TEntity> getterById) where TIndex : struct, IComparable<TIndex> where TEntity : class, ICacheableObject<TIndex>
	{
		TIndex zero = default(TIndex);
		LocalCache localCache = CacheManager.LocalCache;
		if (localCache.GetEntityIDFromLookupCache<TIndex>(cacheInfo, entityIdLookup, out var entityId) && !entityId.Equals(zero))
		{
			return getterById(entityId);
		}
		ILookupCache remoteCache = LookupCacheFactory.GetInstance().GetLookupCache(cacheInfo);
		bool idFound;
		(idFound, entityId) = remoteCache.GetEntityIDFromLookupCache<TIndex>(cacheInfo, entityIdLookup);
		TEntity entity;
		if (idFound && !entityId.Equals(zero))
		{
			entity = getterById(entityId);
			localCache.AddEntityIDToLookupCache(cacheInfo, entityIdLookup, entityId);
			return entity;
		}
		entity = getterOrCreator();
		remoteCache.AddEntityIDToLookupCache(cacheInfo, entityIdLookup, entity.ID);
		localCache.AddEntityIDToLookupCache(cacheInfo, entityIdLookup, entity.ID);
		return entity;
	}

	/// <summary>
	/// Gets or creates an entity by a lookup directly against its data source.
	/// </summary>
	/// <remarks>This method does not interact with any cache.</remarks>
	/// <typeparam name="T">The type of the entity DAL to get or create.</typeparam>
	/// <param name="dbInfo">The <see cref="T:Roblox.Data.DbInfo" /> describing the database action to get or create the entity.</param>
	/// <param name="dalBuilder">The <see cref="T:Roblox.Common.EntityHelper.BuildDAL`1" /> used to deserialize the entity data.</param>
	/// <returns>A <see cref="T:Roblox.Common.EntityHelper.GetOrCreateDALWrapper`1" /> containing the resulting entity.</returns>
	public static GetOrCreateDALWrapper<T> GetOrCreateEntityDAL<T>(DbInfo dbInfo, BuildDAL<T> dalBuilder) where T : class
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		SqlParameter createdNewEntityParameter = new SqlParameter("@CreatedNewEntity", (SqlDbType)2)
		{
			Direction = (ParameterDirection)2
		};
		T dal;
		using (DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString))
		{
			dbHelper.SQLParameters.Add(createdNewEntityParameter);
			foreach (SqlParameter queryParameter in dbInfo.QueryParameters)
			{
				dbHelper.SQLParameters.Add(queryParameter);
			}
			SqlDataReader dataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, (CommandType)4);
			try
			{
				dal = dalBuilder(dataReader);
			}
			finally
			{
				((IDisposable)dataReader)?.Dispose();
			}
		}
		if (dal == null)
		{
			throw new ApplicationException("GetOrCreate failure.");
		}
		return new GetOrCreateDALWrapper<T>((bool)((DbParameter)createdNewEntityParameter).Value, dal);
	}

	/// <summary>
	/// Saves (persists) an entity.
	/// </summary>
	/// <remarks>
	/// <para>If the entity does not exist in persistent storage (the in-memory entity has a default ID value), it will be created and assigned a new ID using
	/// <paramref name="dalInserter" />. Otherwise, it will be updated using <paramref name="dalUpdater" />. Any changes made to an old version of an existing
	/// entity will be overwritten (last write wins).</para>
	///
	/// <para>This method will update the entity and lookup caches, as well as invalidate any counts and lookups.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache. <b>If your entity uses remote lookups, use
	/// <see cref="M:Roblox.Common.EntityHelper.SaveEntityWithRemoteCache``1(Roblox.Caching.Interfaces.ICacheableObject{``0},Roblox.Common.EntityHelper.InsertDAL,Roblox.Common.EntityHelper.UpdateDAL)" /> to properly interact with the remote lookup cache.</b></para>
	/// </remarks>
	/// <seealso cref="M:Roblox.Common.EntityHelper.SaveEntityWithRemoteCache``1(Roblox.Caching.Interfaces.ICacheableObject{``0},Roblox.Common.EntityHelper.InsertDAL,Roblox.Common.EntityHelper.UpdateDAL)" />
	/// <typeparam name="T">The type of the saved entity's ID.</typeparam>
	/// <param name="entity">The entity to save.</param>
	/// <param name="dalInserter">The <see cref="T:Roblox.Common.EntityHelper.InsertDAL" /> used to create a new entity against its data source.</param>
	/// <param name="dalUpdater">The <see cref="T:Roblox.Common.EntityHelper.UpdateDAL" /> used to update an existing entity against its data source.</param>
	public static void SaveEntity<T>(ICacheableObject<T> entity, InsertDAL dalInserter, UpdateDAL dalUpdater) where T : IComparable
	{
		if (entity.ID.CompareTo(default(T)) == 0)
		{
			CreateEntity(entity, dalInserter);
		}
		else
		{
			UpdateEntity(entity, dalUpdater);
		}
	}

	/// <summary>
	/// Saves (persists) an entity.
	/// </summary>
	/// <remarks>
	/// <para>If the entity does not exist in persistent storage, it will be created and assigned a new ID using <paramref name="dalInserter" />. Otherwise, it will be
	/// updated using <paramref name="dalUpdater" />. Any changes made to an old version of an existing entity will be overwritten (last write wins).</para>
	///
	/// <para>This method will update the entity and lookup caches, as well as invalidate any counts and lookups.</para>
	///
	/// <para>This method interacts with the remote entity cache and the remote lookup cache.</para>
	/// </remarks>
	/// <seealso cref="M:Roblox.Common.EntityHelper.SaveEntity``1(Roblox.Caching.Interfaces.ICacheableObject{``0},Roblox.Common.EntityHelper.InsertDAL,Roblox.Common.EntityHelper.UpdateDAL)" />
	/// <typeparam name="T">The type of saved entity's ID.</typeparam>
	/// <param name="entity">The entity to save.</param>
	/// <param name="dalInserter">The <see cref="T:Roblox.Common.EntityHelper.InsertDAL" /> used to create a new entity against its data source.</param>
	/// <param name="dalUpdater">The <see cref="T:Roblox.Common.EntityHelper.UpdateDAL" /> used to update an existing entity against its data source.</param>
	public static void SaveEntityWithRemoteCache<T>(ICacheableObject<T> entity, InsertDAL dalInserter, UpdateDAL dalUpdater) where T : IComparable
	{
		if (entity.ID.CompareTo(default(T)) == 0)
		{
			CreateEntity(entity, dalInserter);
		}
		else
		{
			UpdateEntity(entity, dalUpdater);
		}
		IEnumerable<string> enumerable = entity.BuildEntityIDLookups();
		ILookupCache remoteCache = LookupCacheFactory.GetInstance().GetLookupCache(entity.CacheInfo);
		foreach (string idLookup in enumerable)
		{
			remoteCache.AddEntityIDToLookupCache(entity.CacheInfo, idLookup, entity.ID);
		}
	}

	/// <summary>
	/// Persists the creation of a new entity.
	/// </summary>
	/// <remarks>
	/// <para>This method will update the entity and lookup caches, as well as invalidate any counts and lookups.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <typeparam name="T">The type of the created entity's ID.</typeparam>
	/// <param name="entity">The entity to create.</param>
	/// <param name="dalInserter">The <see cref="T:Roblox.Common.EntityHelper.InsertDAL" /> used to persist the entity against its data source.</param>
	public static void CreateEntity<T>(ICacheableObject<T> entity, InsertDAL dalInserter)
	{
		dalInserter();
		CacheManager.ProcessEntityChange(entity, StateChangeEventType.Creation);
		AddEntityIdLookupsToCache(entity);
	}

	/// <summary>
	/// Persists the creation of a new entity.
	/// </summary>
	/// <remarks>
	/// <para>This method uses a <see cref="T:System.Func`1" /> to create the entity against its data source and produce an instance of the cacheable entity from the result.</para>
	///
	/// <para>This method will update the entity and lookup caches, as well as invalidate any counts and lookups.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <typeparam name="T">The type of the created entity's ID.</typeparam>
	/// <param name="creator">
	///     The <see cref="T:System.Func`1" /> that creates the entity against its data source and produces an instance of the cacheable entity from the result.
	/// </param>
	public static void CreateEntity<T>(Func<ICacheableObject<T>> creator)
	{
		ICacheableObject<T> entity = creator();
		CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
		AddEntityIdLookupsToCache(entity);
	}

	/// <summary>
	/// Persists an update to an existing entity.
	/// </summary>
	/// <remarks>
	/// <para>This method will update the entity and lookup caches, as well as invalidate any counts and lookups.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <typeparam name="T">The type of the updated entity's ID.</typeparam>
	/// <param name="entity">The entity whose updates will be persisted.</param>
	/// <param name="dalUpdater">The <see cref="T:Roblox.Common.EntityHelper.UpdateDAL" /> used to persist the updates against the entity's data source.</param>
	public static void UpdateEntity<T>(ICacheableObject<T> entity, UpdateDAL dalUpdater)
	{
		dalUpdater();
		CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
		AddEntityIdLookupsToCache(entity);
	}

	/// <summary>
	/// Persists an update to an existing entity.
	/// </summary>
	/// <remarks>
	/// <para>This method uses a <see cref="T:System.Func`1" /> to update the entity against its data source and produces an instance of the cacheable entity from the result.</para>
	///
	/// <para>This method will update the entity and lookup caches, as well as invalidate any counts and lookups.</para>
	///
	/// <para>This method interacts with the remote entity cache, but not the remote lookup cache.</para>
	/// </remarks>
	/// <typeparam name="T">The type of the updated entity's ID.</typeparam>
	/// <param name="updater">
	///     The <see cref="T:System.Func`1" /> that updates the entity against its data source and produces an instance of the cacheable entity from the result.
	/// </param>
	public static void UpdateEntity<T>(Func<ICacheableObject<T>> updater)
	{
		ICacheableObject<T> entity = updater();
		CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
		AddEntityIdLookupsToCache(entity);
	}

	/// <summary>
	/// Gets an entity by its ID, throwing a <see cref="T:Roblox.Data.DataIntegrityException" /> if the entity does not exist.
	/// </summary>
	/// <remarks>
	/// This method is just a wrapper around <paramref name="getter" />, thus how the entity is actually retrieved is up to <paramref name="getter" />.
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="id">The ID of the entity to get.</param>
	/// <param name="getter">The <see cref="T:System.Func`2" /> used to get the entity.</param>
	/// <returns>The entity with the given ID.</returns>
	public static TEntity MustGet<TIndex, TEntity>(TIndex id, Func<TIndex, TEntity> getter)
	{
		TEntity entity = getter(id);
		if (entity != null)
		{
			return entity;
		}
		throw new DataIntegrityException($"Could not retrieve {typeof(TEntity).FullName} with ID={id}");
	}

	/// <summary>
	/// Gets an entity by its ID, throwing a <see cref="T:Roblox.Data.DataIntegrityException" /> if the entity does not exist. If the given ID is <c>null</c>,
	/// the method will return a <c>default</c> <typeparamref name="TEntity" /> instead of throwing.
	/// </summary>
	/// <remarks>
	/// This method is just a wrapper around <paramref name="getter" />, thus how the entity is actually retrieved is up to <paramref name="getter" />.
	/// </remarks>
	/// <typeparam name="TIndex">The type of the entity's ID.</typeparam>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <param name="id">The ID of the entity to get.</param>
	/// <param name="getter">The <see cref="T:System.Func`2" /> used to get the entity.</param>
	/// <returns>The entity with the given ID, or a <c>default</c> <typeparamref name="TEntity" /> if <paramref name="id" /> was <c>null</c>.</returns>
	public static TEntity MustGet<TIndex, TEntity>(TIndex? id, Func<TIndex, TEntity> getter) where TIndex : struct
	{
		if (!id.HasValue)
		{
			return default(TEntity);
		}
		return MustGet(id.Value, getter);
	}

	private static void AddEntityIdLookupsToCache<T>(ICacheableObject<T> entity)
	{
		foreach (string idLookup in entity.BuildEntityIDLookups())
		{
			CacheManager.AddEntityIDToLookupCache(entity.CacheInfo, idLookup, entity.ID);
		}
	}

	private static void AddEntityAndIdLookupsToCache<T>(ICacheableObject<T> entity)
	{
		CacheManager.AddEntityToCache(entity);
		AddEntityIdLookupsToCache(entity);
	}

	private static void AddNullEntityIDToLookupCache(string entityIdLookup, CacheInfo cacheInfo)
	{
		if (!string.IsNullOrEmpty(entityIdLookup))
		{
			CacheManager.AddNullEntityIDToLookupCache(cacheInfo, entityIdLookup);
		}
	}

	/// <summary>
	/// Gets the name of the table type used for the given <typeparamref name="TIndex" />.
	/// </summary>
	/// <remarks>
	/// The type table returned is used to represent a collection of <typeparamref name="TIndex" />s.
	/// </remarks>
	/// <example>
	/// <code>
	///     Console.WriteLine(GetTableTypeName&lt;long&gt;()); // Writes "dbo.BigIntList"
	/// </code>
	/// </example>
	/// <typeparam name="TIndex">The type of index.</typeparam>
	/// <returns>The name of the table type.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if <typeparamref name="TIndex" /> is not a supported index type.</exception>
	private static string GetTableTypeName<TIndex>()
	{
		Type parameterType = typeof(TIndex);
		if (parameterType.IsValueType)
		{
			if (parameterType == typeof(long))
			{
				return "dbo.BigIntList";
			}
			if (parameterType == typeof(int))
			{
				return "dbo.IntList";
			}
			if (parameterType == typeof(short))
			{
				return "dbo.SmallIntList";
			}
			if (parameterType == typeof(byte))
			{
				return "dbo.TinyIntList";
			}
		}
		throw new ArgumentException("Invalid table type for Multi-Get: " + parameterType);
	}
}
