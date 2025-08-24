using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Outfits.Properties;

namespace Roblox.Outfits;

public class ColorDAL
{
	public int ID { get; set; }

	public byte R { get; set; }

	public byte G { get; set; }

	public byte B { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.RobloxOutfits;

	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "Colors_DeleteColorByID", queryParameters));
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@R", R),
			new SqlParameter("@G", G),
			new SqlParameter("@B", B),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "Colors_InsertColor", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@R", R),
			new SqlParameter("@G", G),
			new SqlParameter("@B", B),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "Colors_UpdateColorByID", queryParameters));
	}

	public static EntityHelper.GetOrCreateDALWrapper<ColorDAL> GetOrCreate(byte r, byte g, byte b)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@R", r),
			new SqlParameter("@G", g),
			new SqlParameter("@B", b)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "dbo.Colors_GetOrCreateColorByRGB", queryParameters), BuildDAL);
	}

	private static ColorDAL BuildDAL(SqlDataReader reader)
	{
		ColorDAL dal = new ColorDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.R = (byte)reader["R"];
			dal.G = (byte)reader["G"];
			dal.B = (byte)reader["B"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static ColorDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "Colors_GetColorByID", queryParameters), BuildDAL);
	}
}
