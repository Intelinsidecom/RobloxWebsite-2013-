using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Throttling.Properties;

namespace Roblox.Platform.Throttling.Entities;

internal class RateLimitDAL
{
	internal long ID { get; set; }

	internal long NamespaceID { get; set; }

	internal long ActionTypeID { get; set; }

	internal long NumberOfRequests { get; set; }

	internal long IntervalInTicks { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.DbConnectionString_RobloxThrottling;

	private static RateLimitDAL BuildDAL(SqlDataReader reader)
	{
		RateLimitDAL dal = new RateLimitDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.NamespaceID = (long)reader["NamespaceID"];
			dal.ActionTypeID = (long)reader["ActionTypeID"];
			dal.NumberOfRequests = (long)reader["NumberOfRequests"];
			dal.IntervalInTicks = (long)reader["IntervalInTicks"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "RateLimits_DeleteRateLimitByID", queryParameters));
	}

	internal static RateLimitDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "RateLimits_GetRateLimitByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@NamespaceID", NamespaceID),
			new SqlParameter("@ActionTypeID", ActionTypeID),
			new SqlParameter("@NumberOfRequests", NumberOfRequests),
			new SqlParameter("@IntervalInTicks", IntervalInTicks),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "RateLimits_InsertRateLimit", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@NamespaceID", NamespaceID),
			new SqlParameter("@ActionTypeID", ActionTypeID),
			new SqlParameter("@NumberOfRequests", NumberOfRequests),
			new SqlParameter("@IntervalInTicks", IntervalInTicks),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "RateLimits_UpdateRateLimitByID", queryParameters));
	}

	internal static RateLimitDAL GetRateLimitByNamespaceIDActionTypeID(long namespaceID, long actionTypeID)
	{
		if (namespaceID == 0L)
		{
			return null;
		}
		if (actionTypeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@NamespaceID", namespaceID),
			new SqlParameter("@ActionTypeID", actionTypeID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "RateLimits_GetRateLimitByNamespaceIDActionTypeID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetRateLimitIdsPaged(long startRowIndex, long maximumRows)
	{
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "RateLimits_GetRateLimitIDs_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfRateLimits()
	{
		return EntityHelper.GetDataCount<long>(new DbInfo(_DbConnectionString, "RateLimits_GetTotalNumberOfRateLimits"));
	}
}
