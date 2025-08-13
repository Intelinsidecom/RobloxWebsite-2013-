using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class UtteranceDAL
{
	public long ID { get; set; }

	public Guid GUID { get; set; }

	public long ExpressionID { get; set; }

	public long UttererID { get; set; }

	public byte UtteranceSourceTypeID { get; set; }

	public long? UtteranceSourceObjectID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_DeleteUtteranceV2ByID]", queryParameters));
	}

	public void Insert()
	{
		if (GUID == Guid.Empty)
		{
			throw new ApplicationException("Required value not specified: GUID.");
		}
		if (ExpressionID == 0L)
		{
			throw new ApplicationException("Required value not specified: ExpressionID.");
		}
		if (UttererID == 0L)
		{
			throw new ApplicationException("Required value not specified: UttererID.");
		}
		if (UtteranceSourceTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: UtteranceSourceTypeID.");
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
		queryParameters.Add(new SqlParameter("@GUID", GUID));
		queryParameters.Add(new SqlParameter("@ExpressionID", ExpressionID));
		queryParameters.Add(new SqlParameter("@UttererID", UttererID));
		queryParameters.Add(new SqlParameter("@UtteranceSourceTypeID", UtteranceSourceTypeID));
		queryParameters.Add(new SqlParameter("@UtteranceSourceObjectID", UtteranceSourceObjectID.HasValue ? ((object)UtteranceSourceObjectID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_InsertUtteranceV2]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (GUID == Guid.Empty)
		{
			throw new ApplicationException("Required value not specified: GUID.");
		}
		if (ExpressionID == 0L)
		{
			throw new ApplicationException("Required value not specified: ExpressionID.");
		}
		if (UttererID == 0L)
		{
			throw new ApplicationException("Required value not specified: UttererID.");
		}
		if (UtteranceSourceTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: UtteranceSourceTypeID.");
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
		queryParameters.Add(new SqlParameter("@GUID", GUID));
		queryParameters.Add(new SqlParameter("@ExpressionID", ExpressionID));
		queryParameters.Add(new SqlParameter("@UttererID", UttererID));
		queryParameters.Add(new SqlParameter("@UtteranceSourceTypeID", UtteranceSourceTypeID));
		queryParameters.Add(new SqlParameter("@UtteranceSourceObjectID", UtteranceSourceObjectID.HasValue ? ((object)UtteranceSourceObjectID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_UpdateUtteranceV2ByID]", queryParameters));
	}

	private static UtteranceDAL BuildDAL(SqlDataReader reader)
	{
		UtteranceDAL dal = new UtteranceDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.GUID = (Guid)reader["GUID"];
			dal.ExpressionID = (long)reader["ExpressionID"];
			dal.UttererID = (long)reader["UttererID"];
			dal.UtteranceSourceTypeID = (byte)reader["UtteranceSourceTypeID"];
			dal.UtteranceSourceObjectID = (reader["UtteranceSourceObjectID"].Equals(DBNull.Value) ? null : ((long?)reader["UtteranceSourceObjectID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public static UtteranceDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_GetUtteranceV2ByID]", queryParameters), BuildDAL);
	}

	public static UtteranceDAL Get(Guid guid)
	{
		if (guid == Guid.Empty)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GUID", guid));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_GetUtteranceV2ByGUID]", queryParameters), BuildDAL);
	}

	public static UtteranceDAL Get(long expressionId, long uttererId, byte utteranceSourceTypeId, long? utteranceSourceObjectId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ExpressionID", expressionId));
		queryParameters.Add(new SqlParameter("@UttererID", uttererId));
		queryParameters.Add(new SqlParameter("@UtteranceSourceTypeID", utteranceSourceTypeId));
		if (utteranceSourceObjectId.HasValue)
		{
			queryParameters.Add(new SqlParameter("@UtteranceSourceObjectID", utteranceSourceObjectId.Value));
		}
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_GetUtteranceV2ByExpressionIDUttererIDUtteranceSourceTypeIDAndUtteranceSourceObjectID]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<UtteranceDAL> GetOrCreate(long expressionId, long uttererId, byte utteranceSourceTypeId, long? utteranceSourceObjectId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ExpressionID", expressionId));
		queryParameters.Add(new SqlParameter("@UttererID", uttererId));
		queryParameters.Add(new SqlParameter("@UtteranceSourceTypeID", utteranceSourceTypeId));
		if (utteranceSourceObjectId.HasValue)
		{
			queryParameters.Add(new SqlParameter("@UtteranceSourceObjectID", utteranceSourceObjectId.Value));
		}
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_GetOrCreateUtteranceV2ByExpressionIDUttererIDUtteranceSourceTypeIDAndUtteranceSourceObjectID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetUtteranceIDsBySourceObjectIDAndSourceTypeID(long sourceObjectId, byte sourceTypeId)
	{
		if (sourceObjectId == 0L)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SourceObjectId", sourceObjectId));
		queryParameters.Add(new SqlParameter("@SourceTypeId", sourceTypeId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[UtterancesV2_GetUtteranceV2IDsBySourceObjectIDAndSourceTypeID]", queryParameters));
	}
}
