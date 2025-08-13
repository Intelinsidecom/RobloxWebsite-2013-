using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Moderation;

public class MACAddressDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxMacAddresses.GetConnectionString();

	public long ID { get; set; }

	public string MACAddress { get; set; }

	public byte State { get; set; }

	public DateTime? Expiration { get; set; }

	public DateTime Created { get; set; } = DateTime.MinValue;


	public DateTime Updated { get; set; } = DateTime.MinValue;


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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[MACAddresses_DeleteMACAddressByID]", queryParameters));
	}

	public void Insert()
	{
		if (string.IsNullOrEmpty(MACAddress))
		{
			throw new ApplicationException("Required value not specified: Address.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@MACAddress", MACAddress),
			new SqlParameter("@State", State),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration.Value) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "[dbo].[MACAddresses_InsertMACAddress]", queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (string.IsNullOrEmpty(MACAddress))
		{
			throw new ApplicationException("Required value not specified: Address.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@MACAddress", MACAddress),
			new SqlParameter("@State", State),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration.Value) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[MACAddresses_UpdateMACAddressByID]", queryParameters));
	}

	private static MACAddressDAL BuildDAL(SqlDataReader reader)
	{
		MACAddressDAL dal = new MACAddressDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.MACAddress = (string)reader["MACAddress"];
			dal.State = (byte)reader["State"];
			dal.Expiration = reader["Expiration"] as DateTime?;
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static MACAddressDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[MACAddresses_GetMACAddressByID]", queryParameters), BuildDAL);
	}

	public static MACAddressDAL GetByAddress(string macAddress)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@MACAddress", macAddress)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[MACAddresses_GetMACAddressByMACAddress]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<MACAddressDAL> GetOrCreate(string macAddress)
	{
		SqlParameter addressParam = new SqlParameter("@MACAddress", macAddress);
		addressParam.DbType = DbType.String;
		List<SqlParameter> queryParameters = new List<SqlParameter> { addressParam };
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[MACAddresses_GetOrCreateMACAddress]", queryParameters), BuildDAL);
	}
}
