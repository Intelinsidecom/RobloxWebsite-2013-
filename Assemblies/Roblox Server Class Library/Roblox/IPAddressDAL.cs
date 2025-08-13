using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class IPAddressDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxIPAddresses;

	internal int ID { get; set; }

	internal int Address { get; set; }

	internal string Value { get; set; }

	internal byte State { get; set; }

	internal DateTime? Expiration { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static IPAddressDAL BuildDAL(IDictionary<string, object> record)
	{
		string value = null;
		if (record["Value"] != null && !record["Value"].Equals(DBNull.Value))
		{
			value = (string)record["Value"];
		}
		return new IPAddressDAL
		{
			ID = (int)record["ID"],
			Address = (((int?)record["Address"]) ?? 0),
			Value = value,
			State = (byte)record["State"],
			Expiration = (DateTime?)record["Expiration"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxIPAddresses.Delete("IPAddresses_DeleteIPAddressByID", ID);
	}

	internal static IPAddressDAL Get(int id)
	{
		return RobloxDatabase.RobloxIPAddresses.Get("IPAddresses_GetIPAddressByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Address", Address),
			new SqlParameter("@Value", string.IsNullOrEmpty(Value) ? ((IConvertible)DBNull.Value) : ((IConvertible)Value)),
			new SqlParameter("@State", State),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxIPAddresses.Insert<int>("IPAddresses_InsertIPAddress", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Address", Address),
			new SqlParameter("@Value", string.IsNullOrEmpty(Value) ? ((IConvertible)DBNull.Value) : ((IConvertible)Value)),
			new SqlParameter("@State", State),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxIPAddresses.Update("IPAddresses_UpdateIPAddressByID", queryParameters);
	}

	internal static ICollection<IPAddressDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxIPAddresses.MultiGet("IPAddresses_GetIPAddressesByIDs", ids, BuildDAL);
	}

	internal static IPAddressDAL GetIPAddressByAddress(int address)
	{
		if (address == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Address", address)
		};
		return RobloxDatabase.RobloxIPAddresses.Lookup("IPAddresses_GetIPAddressByAddress", BuildDAL, queryParameters);
	}

	internal static IPAddressDAL GetIPAddressByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxIPAddresses.Lookup("IPAddresses_GetIPAddressByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<IPAddressDAL> GetOrCreateIPAddress(int address, string value = null)
	{
		bool readWriteOnlyAsString = IPAddress.ReadWriteOnlyAsString(address);
		if (!readWriteOnlyAsString && address == 0)
		{
			return null;
		}
		if (readWriteOnlyAsString && string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Address", address)
		};
		if (readWriteOnlyAsString)
		{
			queryParameters.Add(new SqlParameter("@Value", value));
			return RobloxDatabase.RobloxIPAddresses.GetOrCreate("IPAddresses_GetOrCreateIPAddressByValue", BuildDAL, queryParameters.ToArray());
		}
		queryParameters.Add(new SqlParameter("@Value", string.IsNullOrEmpty(value) ? ((IConvertible)DBNull.Value) : ((IConvertible)value)));
		return RobloxDatabase.RobloxIPAddresses.GetOrCreate("IPAddresses_GetOrCreateIPAddress", BuildDAL, queryParameters.ToArray());
	}
}
