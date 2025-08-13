using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Classification;

public class PlatformTypeDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	public byte ID { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte? DeviceTypeID { get; set; }

	public byte? OperatingSystemTypeID { get; set; }

	public byte? ApplicationTypeID { get; set; }

	private static PlatformTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		PlatformTypeDAL dal = new PlatformTypeDAL
		{
			ID = (byte)reader["ID"],
			Value = (string)reader["Value"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"],
			DeviceTypeID = (reader["DeviceTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["DeviceTypeID"])),
			OperatingSystemTypeID = (reader["OperatingSystemTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["OperatingSystemTypeID"])),
			ApplicationTypeID = (reader["ApplicationTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["ApplicationTypeID"]))
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static PlatformTypeDAL BuildDAL(SqlDataReader reader)
	{
		PlatformTypeDAL dal = new PlatformTypeDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static List<PlatformTypeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PlatformTypeDAL> dals = new List<PlatformTypeDAL>();
		while (reader.Read())
		{
			PlatformTypeDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		if (DeviceTypeID.HasValue)
		{
			queryParameters.Add(new SqlParameter("@DeviceTypeID", DeviceTypeID));
		}
		if (OperatingSystemTypeID.HasValue)
		{
			queryParameters.Add(new SqlParameter("@OperatingSystemTypeID", OperatingSystemTypeID));
		}
		if (ApplicationTypeID.HasValue)
		{
			queryParameters.Add(new SqlParameter("@ApplicationTypeID", ApplicationTypeID));
		}
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "PlatformTypes_InsertPlatformType", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		if (DeviceTypeID.HasValue)
		{
			queryParameters.Add(new SqlParameter("@DeviceTypeID", DeviceTypeID));
		}
		if (OperatingSystemTypeID.HasValue)
		{
			queryParameters.Add(new SqlParameter("@OperatingSystemTypeID", OperatingSystemTypeID));
		}
		if (ApplicationTypeID.HasValue)
		{
			queryParameters.Add(new SqlParameter("@ApplicationTypeID", ApplicationTypeID));
		}
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "PlatformTypes_UpdatePlatformTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "PlatformTypes_DeletePlatformTypeByID", queryParameters));
	}

	public static PlatformTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlatformTypes_GetPlatformTypeByID", queryParameters), BuildDAL);
	}

	public static PlatformTypeDAL Get(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlatformTypes_GetPlatformTypeByValue", queryParameters), BuildDAL);
	}

	public static ICollection<PlatformTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "[dbo].[PlatformTypes_GetPlatformTypesByIDs]"), ids, BuildDALCollection);
	}

	public static ICollection<byte> GetPlatformTypesPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<byte>();
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(ConnectionString, "PlatformTypes_GetPlatformTypes_Paged", queryParameters));
	}

	public static ICollection<byte> GetPlatformTypeIdsByDeviceTypeId_Paged(byte deviceTypeId, int startRowIndex, int maximumRows)
	{
		if (deviceTypeId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@DeviceTypeID", deviceTypeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(ConnectionString, "PlatformTypes_GetPlatformTypeIDsByDeviceTypeID_Paged", queryParameters));
	}
}
