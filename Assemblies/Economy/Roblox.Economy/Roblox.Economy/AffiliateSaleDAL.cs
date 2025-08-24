using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Economy;

public class AffiliateSaleDAL
{
	public long AffiliateID;

	public long ProductCreatorID;

	public long SaleID;

	public long AffiliateFee;

	public int AffiliateFeeCurrencyTypeID;

	public long SourceID;

	public DateTime Created = DateTime.MinValue;

	public DateTime Updated = DateTime.MinValue;

	private static string ConnectionString => RobloxDatabase.RobloxEconomy.GetConnectionString();

	public long ID { get; set; }

	private static AffiliateSaleDAL BuildDAL(SqlDataReader reader)
	{
		AffiliateSaleDAL dal = new AffiliateSaleDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AffiliateID = Convert.ToInt64(reader["AffiliateID"]);
			dal.ProductCreatorID = Convert.ToInt64(reader["ProductCreatorID"]);
			dal.SaleID = (long)reader["SaleID"];
			dal.AffiliateFee = (long)reader["AffiliateFee"];
			dal.AffiliateFeeCurrencyTypeID = (int)reader["AffiliateFeeCurrencyTypeID"];
			dal.SourceID = (long)reader["SourceID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		if (AffiliateID == 0L)
		{
			throw new ApplicationException("Required value not specified: AffiliateID.");
		}
		if (ProductCreatorID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductCreatorID.");
		}
		if (SaleID == 0L)
		{
			throw new ApplicationException("Required value not specified: SaleID.");
		}
		if (AffiliateFee == 0L)
		{
			throw new ApplicationException("Required value not specified: AffiliateFee.");
		}
		if (AffiliateFeeCurrencyTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AffiliateFeeCurrencyTypeID.");
		}
		if (SourceID == 0L)
		{
			throw new ApplicationException("Required value not specified: SourceID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AffiliateID", AffiliateID));
		queryParameters.Add(new SqlParameter("@ProductCreatorID", ProductCreatorID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@AffiliateFee", AffiliateFee));
		queryParameters.Add(new SqlParameter("@AffiliateFeeCurrencyTypeID", AffiliateFeeCurrencyTypeID));
		queryParameters.Add(new SqlParameter("@SourceID", SourceID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "AffiliateSalesV2_InsertAffiliateSale", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (AffiliateID == 0L)
		{
			throw new ApplicationException("Required value not specified: AffiliateID.");
		}
		if (ProductCreatorID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductCreatorID.");
		}
		if (SaleID == 0L)
		{
			throw new ApplicationException("Required value not specified: SaleID.");
		}
		if (AffiliateFee == 0L)
		{
			throw new ApplicationException("Required value not specified: AffiliateFee.");
		}
		if (AffiliateFeeCurrencyTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AffiliateFeeCurrencyTypeID.");
		}
		if (SourceID == 0L)
		{
			throw new ApplicationException("Required value not specified: SourceID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@AffiliateID", AffiliateID));
		queryParameters.Add(new SqlParameter("@ProductCreatorID", ProductCreatorID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@AffiliateFee", AffiliateFee));
		queryParameters.Add(new SqlParameter("@AffiliateFeeCurrencyTypeID", AffiliateFeeCurrencyTypeID));
		queryParameters.Add(new SqlParameter("@SourceID", SourceID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AffiliateSalesV2_UpdateAffiliateSaleByID", queryParameters));
	}

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AffiliateSalesV2_DeleteAffiliateSaleByID", queryParameters));
	}

	public static AffiliateSaleDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AffiliateSalesV2_GetAffiliateSaleByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetAffiliateSaleIDsByAffiliateID_Paged(long affiliateId, int startRowIndex, int maxRows)
	{
		if (affiliateId == 0L)
		{
			throw new ApplicationException("Required value not specified: affiliateId.");
		}
		if (maxRows == 0L)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AffiliateID", affiliateId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "AffiliateSalesV2_GetAffiliateSaleIDsByAffiliateID_Paged", queryParameters));
	}

	public static long GetTotalNumberOfAffiliateSalesByAffiliateID(long affiliateId)
	{
		if (affiliateId == 0L)
		{
			throw new ApplicationException("Required value not specified: affiliateId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AffiliateID", affiliateId));
		return EntityHelper.GetDataCount<long>(new DbInfo(ConnectionString, "[dbo].[AffiliateSalesV2_GetTotalNumberOfAffiliateSalesByAffiliateID]", queryParameters));
	}

	public static ICollection<long> GetAffiliateSaleIDsByProductCreatorID_Paged(long productCreatorId, int startRowIndex, int maxRows)
	{
		if (productCreatorId == 0L)
		{
			throw new ApplicationException("Required value not specified: productCreatorId.");
		}
		if (maxRows == 0L)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductCreatorID", productCreatorId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "AffiliateSalesV2_GetAffiliateSaleIDsByProductCreatorID_Paged", queryParameters));
	}

	public static long GetTotalNumberOfAffiliateSalesByProductCreatorID(long productCreatorId)
	{
		if (productCreatorId == 0L)
		{
			throw new ApplicationException("Required value not specified: productCreatorId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductCreatorID", productCreatorId));
		return EntityHelper.GetDataCount<long>(new DbInfo(ConnectionString, "[dbo].[AffiliateSalesV2_GetTotalNumberOfAffiliateSalesByProductCreatorID]", queryParameters));
	}

	internal static AffiliateSaleDAL GetAffiliateSaleBySaleID(long saleID)
	{
		if (saleID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SaleID", saleID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AffiliateSalesV2_GetAffiliateSaleBySaleID", queryParameters), BuildDAL);
	}
}
