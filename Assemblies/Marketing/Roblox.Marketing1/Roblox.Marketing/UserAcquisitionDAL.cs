using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class UserAcquisitionDAL
{
	private long _ID;

	public long UserID;

	public string AcquisitionMedium;

	public string AcquisitionSource;

	public string AcquisitionCampaign;

	public DateTime? AcquisitionTime;

	public string AcquisitionReferrer;

	public string AcquisitionAdGroup;

	public string AcquisitionKeyword;

	public string AcquisitionMatchType;

	public DateTime Created;

	public DateTime Updated;

	public byte? PlatformTypeID;

	public byte? WoMUserAcquisitionSourceTypeID;

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

	private static string ConnectionString => RobloxDatabase.RobloxMarketing.GetConnectionString();

	private static UserAcquisitionDAL BuildDAL(SqlDataReader reader)
	{
		UserAcquisitionDAL dal = new UserAcquisitionDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.AcquisitionTime = (reader["AcquisitionTime"].Equals(DBNull.Value) ? null : ((DateTime?)reader["AcquisitionTime"]));
			dal.AcquisitionMedium = (reader["AcquisitionMedium"].Equals(DBNull.Value) ? null : ((string)reader["AcquisitionMedium"]));
			dal.AcquisitionSource = (reader["AcquisitionSource"].Equals(DBNull.Value) ? null : ((string)reader["AcquisitionSource"]));
			dal.AcquisitionCampaign = (reader["AcquisitionCampaign"].Equals(DBNull.Value) ? null : ((string)reader["AcquisitionCampaign"]));
			dal.AcquisitionReferrer = (reader["AcquisitionReferrer"].Equals(DBNull.Value) ? null : ((string)reader["AcquisitionReferrer"]));
			dal.AcquisitionAdGroup = (reader["AcquisitionAdGroup"].Equals(DBNull.Value) ? null : ((string)reader["AcquisitionAdGroup"]));
			dal.AcquisitionKeyword = (reader["AcquisitionKeyword"].Equals(DBNull.Value) ? null : ((string)reader["AcquisitionKeyword"]));
			dal.AcquisitionMatchType = (reader["AcquisitionMatchType"].Equals(DBNull.Value) ? null : ((string)reader["AcquisitionMatchType"]));
			dal.PlatformTypeID = (reader["PlatformTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["PlatformTypeID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.WoMUserAcquisitionSourceTypeID = (reader["WoMUserAcquisitionSourceTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["WoMUserAcquisitionSourceTypeID"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@AcquisitionMedium", string.IsNullOrEmpty(AcquisitionMedium) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionMedium)));
		queryParameters.Add(new SqlParameter("@AcquisitionSource", string.IsNullOrEmpty(AcquisitionSource) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionSource)));
		queryParameters.Add(new SqlParameter("@AcquisitionCampaign", string.IsNullOrEmpty(AcquisitionCampaign) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionCampaign)));
		queryParameters.Add(new SqlParameter("@AcquisitionTime", AcquisitionTime.HasValue ? ((object)AcquisitionTime) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AcquisitionReferrer", string.IsNullOrEmpty(AcquisitionReferrer) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionReferrer)));
		queryParameters.Add(new SqlParameter("@AcquisitionAdGroup", string.IsNullOrEmpty(AcquisitionAdGroup) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionAdGroup)));
		queryParameters.Add(new SqlParameter("@AcquisitionKeyword", string.IsNullOrEmpty(AcquisitionKeyword) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionKeyword)));
		queryParameters.Add(new SqlParameter("@AcquisitionMatchType", string.IsNullOrEmpty(AcquisitionMatchType) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionMatchType)));
		queryParameters.Add(new SqlParameter("@PlatformTypeID", PlatformTypeID.HasValue ? ((object)PlatformTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@WoMUserAcquisitionSourceTypeID", WoMUserAcquisitionSourceTypeID.HasValue ? ((object)WoMUserAcquisitionSourceTypeID) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "UserAcquisitionsV2_InsertUserAcquisitionV2", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@AcquisitionMedium", string.IsNullOrEmpty(AcquisitionMedium) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionMedium)));
		queryParameters.Add(new SqlParameter("@AcquisitionSource", string.IsNullOrEmpty(AcquisitionSource) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionSource)));
		queryParameters.Add(new SqlParameter("@AcquisitionCampaign", string.IsNullOrEmpty(AcquisitionCampaign) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionCampaign)));
		queryParameters.Add(new SqlParameter("@AcquisitionTime", AcquisitionTime.HasValue ? ((object)AcquisitionTime) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AcquisitionReferrer", string.IsNullOrEmpty(AcquisitionReferrer) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionReferrer)));
		queryParameters.Add(new SqlParameter("@AcquisitionAdGroup", string.IsNullOrEmpty(AcquisitionAdGroup) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionAdGroup)));
		queryParameters.Add(new SqlParameter("@AcquisitionKeyword", string.IsNullOrEmpty(AcquisitionKeyword) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionKeyword)));
		queryParameters.Add(new SqlParameter("@AcquisitionMatchType", string.IsNullOrEmpty(AcquisitionMatchType) ? ((IConvertible)DBNull.Value) : ((IConvertible)AcquisitionMatchType)));
		queryParameters.Add(new SqlParameter("@PlatformTypeID", PlatformTypeID.HasValue ? ((object)PlatformTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@WoMUserAcquisitionSourceTypeID", WoMUserAcquisitionSourceTypeID.HasValue ? ((object)WoMUserAcquisitionSourceTypeID) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "UserAcquisitionsV2_UpdateUserAcquisitionV2ByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "UserAcquisitionsV2_DeleteUserAcquisitionV2ByID", queryParameters));
	}

	public static UserAcquisitionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UserAcquisitionsV2_GetUserAcquisitionV2ByID", queryParameters), BuildDAL);
	}

	public static UserAcquisitionDAL GetByUserID(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UserAcquisitionsV2_GetUserAcquisitionV2ByUserID", queryParameters), BuildDAL);
	}
}
