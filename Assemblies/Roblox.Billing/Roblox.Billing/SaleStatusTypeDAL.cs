using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class SaleStatusTypeDAL
{
	private byte _ID;

	private string _Value = "";

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public static readonly string DBConnectionString = Settings.Default.BillingConnectionString;

	public byte ID
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

	public string Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	public static SaleStatusTypeDAL BuildDAL(SqlDataReader reader)
	{
		SaleStatusTypeDAL dal = new SaleStatusTypeDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	internal static SaleStatusTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "SaleStatusTypes_GetSaleStatusTypeByID", queryParameters), BuildDAL);
	}

	internal void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(DBConnectionString, "SaleStatusTypes_DeleteSaleStatusTypeByID", queryParameters));
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(DBConnectionString, "SaleStatusTypes_InsertSaleStatusType", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(DBConnectionString, "SaleStatusTypes_UpdateSaleStatusTypeByID", queryParameters));
	}

	internal static ICollection<SaleStatusTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(DBConnectionString, "SaleStatusTypes_GetSaleStatusTypesByIDs"), ids, BuildDalCollection);
	}

	public static SaleStatusTypeDAL Get(string SaleStatusType)
	{
		if (SaleStatusType.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", SaleStatusType));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "[dbo].[SaleStatusTypes_GetSaleStatusTypeByValue]", queryParameters), BuildDAL);
	}

	private static List<SaleStatusTypeDAL> BuildDalCollection(SqlDataReader reader)
	{
		List<SaleStatusTypeDAL> dals = new List<SaleStatusTypeDAL>();
		while (reader.Read())
		{
			SaleStatusTypeDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	private static SaleStatusTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		SaleStatusTypeDAL dal = new SaleStatusTypeDAL
		{
			ID = (byte)reader["ID"],
			Value = (string)reader["Value"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}
}
