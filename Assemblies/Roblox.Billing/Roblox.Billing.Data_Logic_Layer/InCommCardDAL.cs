using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class InCommCardDAL
{
	private short _ID;

	public byte MerchantID;

	public byte CurrencyTypeID;

	public decimal Value;

	public DateTime Created;

	public DateTime Updated;

	public short ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	private static string dbConnectionString_InCommCardDAL => Settings.Default.BillingConnectionString;

	private static InCommCardDAL BuildDAL(SqlDataReader reader)
	{
		InCommCardDAL dal = new InCommCardDAL();
		while (reader.Read())
		{
			dal.ID = (short)reader["ID"];
			dal.MerchantID = (byte)reader["MerchantID"];
			dal.CurrencyTypeID = (byte)reader["CurrencyTypeID"];
			dal.Value = (decimal)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<short>(new DbInfo(dbConnectionString_InCommCardDAL, "InCommCards_InsertInCommCard", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_InCommCardDAL, "InCommCards_UpdateInCommCardByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_InCommCardDAL, "InCommCards_DeleteInCommCardByID", queryParameters));
	}

	public static InCommCardDAL Get(short id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_InCommCardDAL, "InCommCards_GetInCommCardByID", queryParameters), BuildDAL);
	}

	public static InCommCardDAL GetByMerchantIDAndValue(byte merchantID, decimal value)
	{
		if (merchantID == 0 || value == 0m)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", merchantID));
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_InCommCardDAL, "InCommCards_GetInCommCardByMerchantIDAndValue", queryParameters), BuildDAL);
	}

	public static InCommCardDAL GetByMerchantIDCurrencyTypeIDAndValue(byte merchantID, byte currencyTypeID, decimal value)
	{
		if (merchantID == 0 || currencyTypeID == 0 || value == 0m)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", merchantID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", currencyTypeID));
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_InCommCardDAL, "InCommCards_GetInCommCardByMerchantIDAndCurrencyTypeIDAndValue", queryParameters), BuildDAL);
	}

	public static ICollection<short> GetInCommCardIDsByMerchantID(byte MerchantID)
	{
		if (MerchantID == 0)
		{
			throw new ApplicationException("Required value not specified: MerchantID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		return EntityHelper.GetDataEntityIDCollection<short>(new DbInfo(dbConnectionString_InCommCardDAL, "InCommCards_GetInCommCardIDsByMerchantID", queryParameters));
	}

	public static ICollection<short> GetInCommCardIDsPaged(short startRowIndex, short maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<short>(new DbInfo(dbConnectionString_InCommCardDAL, "[dbo].[InCommCards_GetInCommCardIDs_Paged]", queryParameters));
	}
}
