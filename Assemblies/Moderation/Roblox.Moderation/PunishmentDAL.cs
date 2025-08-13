using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class PunishmentDAL
{
	public long ID { get; set; }

	public long UserID { get; set; }

	public long ModeratorID { get; set; }

	public byte PunishmentTypeID { get; set; }

	public DateTime? BeginDate { get; set; }

	public DateTime? EndDate { get; set; }

	public long? InternalNoteExpressionID { get; set; }

	public long? MessageToUserExpressionID { get; set; }

	public bool UserHasAcknowledged { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte? PunishmentReasonTypeID { get; set; }

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_DeletePunishmentV2ByID]", queryParameters));
	}

	public void Insert()
	{
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (ModeratorID == 0L)
		{
			throw new ApplicationException("Required value not specified: ModeratorID.");
		}
		if (PunishmentTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: PunishmentTypeID.");
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
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID));
		queryParameters.Add(new SqlParameter("@PunishmentTypeID", PunishmentTypeID));
		queryParameters.Add(new SqlParameter("@BeginDate", BeginDate.HasValue ? ((object)BeginDate.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EndDate", EndDate.HasValue ? ((object)EndDate.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@InternalNoteExpressionID", InternalNoteExpressionID.HasValue ? ((object)InternalNoteExpressionID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MessageToUserExpressionID", MessageToUserExpressionID.HasValue ? ((object)MessageToUserExpressionID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@UserHasAcknowledged", UserHasAcknowledged));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@PunishmentReasonTypeID", PunishmentReasonTypeID.HasValue ? ((object)PunishmentReasonTypeID) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_InsertPunishmentV2]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (ModeratorID == 0L)
		{
			throw new ApplicationException("Required value not specified: ModeratorID.");
		}
		if (PunishmentTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: PunishmentTypeID.");
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
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID));
		queryParameters.Add(new SqlParameter("@PunishmentTypeID", PunishmentTypeID));
		queryParameters.Add(new SqlParameter("@BeginDate", BeginDate.HasValue ? ((object)BeginDate.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EndDate", EndDate.HasValue ? ((object)EndDate.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@InternalNoteExpressionID", InternalNoteExpressionID.HasValue ? ((object)InternalNoteExpressionID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MessageToUserExpressionID", MessageToUserExpressionID.HasValue ? ((object)MessageToUserExpressionID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@UserHasAcknowledged", UserHasAcknowledged));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@PunishmentReasonTypeID", PunishmentReasonTypeID.HasValue ? ((object)PunishmentReasonTypeID) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_UpdatePunishmentV2ByID]", queryParameters));
	}

	private static PunishmentDAL BuildDAL(SqlDataReader reader)
	{
		PunishmentDAL dal = new PunishmentDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.ModeratorID = (long)reader["ModeratorID"];
			dal.PunishmentTypeID = (byte)reader["PunishmentTypeID"];
			dal.BeginDate = (reader["BeginDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["BeginDate"]));
			dal.EndDate = (reader["EndDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["EndDate"]));
			dal.InternalNoteExpressionID = (reader["InternalNoteExpressionID"].Equals(DBNull.Value) ? null : ((long?)reader["InternalNoteExpressionID"]));
			dal.MessageToUserExpressionID = (reader["MessageToUserExpressionID"].Equals(DBNull.Value) ? null : ((long?)reader["MessageToUserExpressionID"]));
			dal.UserHasAcknowledged = (bool)reader["UserHasAcknowledged"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.PunishmentReasonTypeID = (reader["PunishmentReasonTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["PunishmentReasonTypeID"]));
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public static PunishmentDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_GetPunishmentV2ByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetActiveUserPunishmentIDsPaged(long userId, int startRowIndex, int maximumRows)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_GetActivePunishmentV2IDsByUserID_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfActiveUserPunishments(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_GetTotalNumberOfActivePunishmentsV2ByUserID]", queryParameters));
	}

	public static int GetTotalNumberOfUserPunishments(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_GetTotalNumberOfPunishmentsV2ByUserID]", queryParameters));
	}

	public static ICollection<long> GetUserPunishmentIDsPaged(long userId, int startRowIndex, int maximumRows)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentsV2_GetPunishmentV2IDsByUserID_Paged]", queryParameters));
	}
}
