using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

internal class PlatformSaleDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxBilling;

	internal int ID { get; set; }

	internal int SaleID { get; set; }

	internal byte PlatformTypeID { get; set; }

	internal DateTime Created { get; set; }

	private static PlatformSaleDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PlatformSaleDAL
		{
			ID = (int)record["ID"],
			SaleID = (int)record["SaleID"],
			PlatformTypeID = (byte)record["PlatformTypeID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxBilling.Delete("PlatformSales_DeletePlatformSaleByID", ID);
	}

	internal static PlatformSaleDAL Get(int id)
	{
		return RobloxDatabase.RobloxBilling.Get("PlatformSales_GetPlatformSaleByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@PlatformTypeID", PlatformTypeID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxBilling.Insert<int>("PlatformSales_InsertPlatformSale", queryParameters);
	}
}
