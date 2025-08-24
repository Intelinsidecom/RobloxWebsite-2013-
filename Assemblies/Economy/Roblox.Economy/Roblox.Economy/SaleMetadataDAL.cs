using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class SaleMetadataDAL
{
	private long _ID;

	public long SaleID;

	public byte PlatformTypeID;

	public byte SaleLocationTypeID;

	public long? SaleLocationID;

	public DateTime Created;

	public long ID
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

	public DateTime? Updated { get; set; }

	public string RecurringTransactionProfileID { get; set; }

	public bool? RecurringTransactionIsActive { get; set; }

	public long? RecurrenceEventCallbackLocationID { get; set; }

	public long? ProductInstanceTargetID { get; set; }

	private static string ConnectionString => Helper.DBConnectionString;

	private static SaleMetadataDAL GetDALFromReader(SqlDataReader reader)
	{
		SaleMetadataDAL dal = new SaleMetadataDAL
		{
			ID = (long)reader["ID"],
			SaleID = (long)reader["SaleID"],
			PlatformTypeID = (byte)reader["PlatformTypeID"],
			SaleLocationTypeID = (byte)reader["SaleLocationTypeID"],
			SaleLocationID = (reader["SaleLocationID"].Equals(DBNull.Value) ? null : ((long?)reader["SaleLocationID"])),
			Created = (DateTime)reader["Created"],
			Updated = (reader["Updated"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Updated"])),
			RecurringTransactionProfileID = (reader["RecurringTransactionProfileID"].Equals(DBNull.Value) ? null : ((string)reader["RecurringTransactionProfileID"])),
			RecurringTransactionIsActive = (reader["RecurringTransactionIsActive"].Equals(DBNull.Value) ? null : ((bool?)reader["RecurringTransactionIsActive"])),
			RecurrenceEventCallbackLocationID = (reader["RecurrenceEventCallbackLocationID"].Equals(DBNull.Value) ? null : ((long?)reader["RecurrenceEventCallbackLocationID"])),
			ProductInstanceTargetID = (reader["ProductInstanceTargetID"].Equals(DBNull.Value) ? null : ((long?)reader["ProductInstanceTargetID"]))
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static SaleMetadataDAL BuildDAL(SqlDataReader reader)
	{
		SaleMetadataDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<SaleMetadataDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<SaleMetadataDAL> dals = new List<SaleMetadataDAL>();
		while (reader.Read())
		{
			SaleMetadataDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	public void Insert()
	{
		SqlParameter[] obj = new SqlParameter[10]
		{
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@PlatformTypeID", PlatformTypeID),
			new SqlParameter("@SaleLocationTypeID", SaleLocationTypeID),
			new SqlParameter("@SaleLocationID", SaleLocationID.HasValue ? ((object)SaleLocationID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated.HasValue ? ((object)Updated) : DBNull.Value),
			new SqlParameter("@RecurringTransactionProfileID", string.IsNullOrEmpty(RecurringTransactionProfileID) ? ((IConvertible)DBNull.Value) : ((IConvertible)RecurringTransactionProfileID)),
			new SqlParameter("@RecurringTransactionIsActive", RecurringTransactionIsActive.HasValue ? ((object)RecurringTransactionIsActive) : DBNull.Value),
			new SqlParameter("@RecurrenceEventCallbackLocationID", RecurrenceEventCallbackLocationID.HasValue ? ((object)RecurrenceEventCallbackLocationID) : DBNull.Value),
			null
		};
		long? productInstanceTargetID = ProductInstanceTargetID;
		obj[9] = new SqlParameter("@ProductInstanceTargetID", productInstanceTargetID.HasValue ? ((object)productInstanceTargetID.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "SaleMetadata_InsertSaleMetadata", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		SqlParameter[] obj = new SqlParameter[11]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@PlatformTypeID", PlatformTypeID),
			new SqlParameter("@SaleLocationTypeID", SaleLocationTypeID),
			new SqlParameter("@SaleLocationID", SaleLocationID.HasValue ? ((object)SaleLocationID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated.HasValue ? ((object)Updated) : DBNull.Value),
			new SqlParameter("@RecurringTransactionProfileID", string.IsNullOrEmpty(RecurringTransactionProfileID) ? ((IConvertible)DBNull.Value) : ((IConvertible)RecurringTransactionProfileID)),
			new SqlParameter("@RecurringTransactionIsActive", RecurringTransactionIsActive.HasValue ? ((object)RecurringTransactionIsActive) : DBNull.Value),
			new SqlParameter("@RecurrenceEventCallbackLocationID", RecurrenceEventCallbackLocationID.HasValue ? ((object)RecurrenceEventCallbackLocationID) : DBNull.Value),
			null
		};
		long? productInstanceTargetID = ProductInstanceTargetID;
		obj[10] = new SqlParameter("@ProductInstanceTargetID", productInstanceTargetID.HasValue ? ((object)productInstanceTargetID.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "SaleMetadata_UpdateSaleMetadataByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "SaleMetadata_DeleteSaleMetadataByID", queryParameters));
	}

	public static SaleMetadataDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "SaleMetadata_GetSaleMetadataByID", queryParameters), BuildDAL);
	}

	internal static ICollection<SaleMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "SaleMetadata_GetSaleMetadataByIDs"), ids, BuildDALCollection);
	}

	internal static SaleMetadataDAL GetSaleMetadataBySaleID(long saleID)
	{
		if (saleID == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@SaleID", saleID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "SaleMetadata_GetSaleMetadataBySaleID", queryParameters), BuildDAL);
	}

	internal static SaleMetadataDAL GetSaleMetadataByRecurringTransactionProfileID(string recurringTransactionProfileID)
	{
		if (string.IsNullOrEmpty(recurringTransactionProfileID))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@RecurringTransactionProfileID", string.IsNullOrEmpty(recurringTransactionProfileID) ? ((IConvertible)DBNull.Value) : ((IConvertible)recurringTransactionProfileID))
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "SaleMetadata_GetSaleMetadataByRecurringTransactionProfileID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetSaleMetadataIDsByProductInstanceTargetIDPaged(long productInstanceTargetID, long startRowIndex, long maximumRows)
	{
		if (productInstanceTargetID <= 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ProductInstanceTargetID", productInstanceTargetID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[SaleMetadata_GetSaleMetadataIDsByProductInstanceTargetID_Paged]", queryParameters));
	}
}
