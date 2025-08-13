using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Outfits;

public class BodyColorSetDAL
{
	public long ID { get; set; }

	public int HeadColorID { get; set; }

	public int LeftArmColorID { get; set; }

	public int LeftLegColorID { get; set; }

	public int RightArmColorID { get; set; }

	public int RightLegColorID { get; set; }

	public int TorsoColorID { get; set; }

	public string BodyColorSetHash { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxAvatars.GetConnectionString();

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "BodyColorSets_DeleteBodyColorSetByID", queryParameters));
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@HeadColorID", HeadColorID),
			new SqlParameter("@LeftArmColorID", LeftArmColorID),
			new SqlParameter("@LeftLegColorID", LeftLegColorID),
			new SqlParameter("@RightArmColorID", RightArmColorID),
			new SqlParameter("@RightLegColorID", RightLegColorID),
			new SqlParameter("@TorsoColorID", TorsoColorID),
			new SqlParameter("@BodyColorSetHash", ((object)BodyColorSetHash) ?? ((object)DBNull.Value)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "BodyColorSets_InsertBodyColorSet", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@HeadColorID", HeadColorID),
			new SqlParameter("@LeftArmColorID", LeftArmColorID),
			new SqlParameter("@LeftLegColorID", LeftLegColorID),
			new SqlParameter("@RightArmColorID", RightArmColorID),
			new SqlParameter("@RightLegColorID", RightLegColorID),
			new SqlParameter("@TorsoColorID", TorsoColorID),
			new SqlParameter("@BodyColorSetHash", ((object)BodyColorSetHash) ?? ((object)DBNull.Value)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "BodyColorSets_UpdateBodyColorSetByID", queryParameters));
	}

	public static EntityHelper.GetOrCreateDALWrapper<BodyColorSetDAL> GetOrCreate(int head, int leftArm, int leftLeg, int rightArm, int rightLeg, int torso, string bodyColorSetHash)
	{
		if (head == 0 || leftArm == 0 || leftLeg == 0 || rightArm == 0 || rightLeg == 0 || torso == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@HeadColorID", head),
			new SqlParameter("@LeftArmColorID", leftArm),
			new SqlParameter("@LeftLegColorID", leftLeg),
			new SqlParameter("@RightArmColorID", rightArm),
			new SqlParameter("@RightLegColorID", rightLeg),
			new SqlParameter("@TorsoColorID", torso),
			new SqlParameter("@BodyColorSetHash", ((object)bodyColorSetHash) ?? ((object)DBNull.Value))
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "dbo.BodyColorSets_GetOrCreateBodyColorSet", queryParameters), BuildDAL);
	}

	private static BodyColorSetDAL BuildDAL(SqlDataReader reader)
	{
		BodyColorSetDAL dal = new BodyColorSetDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.HeadColorID = (int)reader["HeadColorID"];
			dal.LeftArmColorID = (int)reader["LeftArmColorID"];
			dal.LeftLegColorID = (int)reader["LeftLegColorID"];
			dal.RightArmColorID = (int)reader["RightArmColorID"];
			dal.RightLegColorID = (int)reader["RightLegColorID"];
			dal.TorsoColorID = (int)reader["TorsoColorID"];
			dal.BodyColorSetHash = (string)((reader["BodyColorSetHash"] == DBNull.Value) ? null : reader["BodyColorSetHash"]);
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static BodyColorSetDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "BodyColorSets_GetBodyColorSetByID", queryParameters), BuildDAL);
	}

	public static BodyColorSetDAL GetByHash(string hash)
	{
		if (string.IsNullOrWhiteSpace(hash))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@BodyColorSetHash", hash)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "BodyColorSets_GetBodyColorSetByBodyColorSetHash", queryParameters), BuildDAL);
	}
}
