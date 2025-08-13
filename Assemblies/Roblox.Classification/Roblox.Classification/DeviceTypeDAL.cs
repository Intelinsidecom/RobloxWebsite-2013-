using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Classification;

public class DeviceTypeDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal byte BitOrdinal { get; set; }

	internal long BitMask { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static DeviceTypeDAL BuildDAL(SqlDataReader reader)
	{
		DeviceTypeDAL dal = new DeviceTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.BitOrdinal = (byte)reader["BitOrdinal"];
			dal.BitMask = (long)reader["BitMask"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "DeviceTypes_DeleteDeviceTypeByID", queryParameters));
	}

	public static DeviceTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "DeviceTypes_GetDeviceTypeByID", queryParameters), BuildDAL);
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@BitOrdinal", BitOrdinal),
			new SqlParameter("@BitMask", BitMask),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "DeviceTypes_InsertDeviceType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	public void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@BitOrdinal", BitOrdinal),
			new SqlParameter("@BitMask", BitMask),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "DeviceTypes_UpdateDeviceTypeByID", queryParameters));
	}

	public static DeviceTypeDAL GetDeviceTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "DeviceTypes_GetDeviceTypeByValue", queryParameters), BuildDAL);
	}

	public static DeviceTypeDAL GetDeviceTypeByBitOrdinal(byte bitOrdinal)
	{
		if (bitOrdinal == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@BitOrdinal", bitOrdinal)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "DeviceTypes_GetDeviceTypeByBitOrdinal", queryParameters), BuildDAL);
	}
}
