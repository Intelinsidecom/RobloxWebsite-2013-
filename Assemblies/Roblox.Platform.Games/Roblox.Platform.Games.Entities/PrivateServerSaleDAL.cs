using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerSaleDAL
{
	internal long ID { get; set; }

	internal long PrivateServerID { get; set; }

	internal long SaleID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	private static PrivateServerSaleDAL GetDALFromReader(SqlDataReader reader)
	{
		PrivateServerSaleDAL dal = new PrivateServerSaleDAL
		{
			ID = (long)reader["ID"],
			PrivateServerID = (long)reader["PrivateServerID"],
			SaleID = (long)reader["SaleID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PrivateServerSaleDAL BuildDAL(SqlDataReader reader)
	{
		PrivateServerSaleDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PrivateServerSaleDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PrivateServerSaleDAL> dals = new List<PrivateServerSaleDAL>();
		while (reader.Read())
		{
			PrivateServerSaleDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PrivateServerSales_DeletePrivateServerSaleByID", queryParameters));
	}

	internal static PrivateServerSaleDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerSales_GetPrivateServerSaleByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PrivateServerSales_InsertPrivateServerSale", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PrivateServerSales_UpdatePrivateServerSaleByID", queryParameters));
	}

	internal static ICollection<PrivateServerSaleDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PrivateServerSales_GetPrivateServerSalesByIDs"), ids, BuildDALCollection);
	}

	internal static PrivateServerSaleDAL GetPrivateServerSaleBySaleID(long saleID)
	{
		if (saleID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SaleID", saleID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerSales_GetPrivateServerSaleBySaleID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetPrivateServerSaleIDsByPrivateServerIDPaged(long privateServerID, long startRowIndex, long maximumRows)
	{
		if (privateServerID == 0L)
		{
			throw new ApplicationException("Required value not specified: privateServerID.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@PrivateServerID", privateServerID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServerSales_GetPrivateServerSaleIDsByPrivateServerID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServerSalesByPrivateServerID(long privateServerID)
	{
		if (privateServerID == 0L)
		{
			throw new ApplicationException("Required value not specified: privateServerID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PrivateServerID", privateServerID)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServerSales_GetTotalNumberOfPrivateServerSalesByPrivateServerID", queryParameters));
	}
}
