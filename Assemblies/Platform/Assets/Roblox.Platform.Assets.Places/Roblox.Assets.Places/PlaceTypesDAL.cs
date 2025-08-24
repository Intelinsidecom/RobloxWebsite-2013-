using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Roblox.Assets.Places.Properties;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Assets.Places;

public sealed class PlaceTypesDAL
{
	private static string DBConnectionString_PlaceAttributeDAL => Settings.Default.DefaultConnectionString;

	public byte ID { get; private set; }

	public string PlaceType { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Assets.Places.PlaceTypesDAL" /> class.
	/// </summary>
	public PlaceTypesDAL()
	{
		ID = 0;
		Created = default(DateTime);
		Updated = default(DateTime);
		PlaceType = string.Empty;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Assets.Places.PlaceTypesDAL" /> class.
	/// </summary>
	/// <param name="id">The id.</param>
	public PlaceTypesDAL(byte id)
		: this()
	{
		ID = id;
	}

	private static PlaceTypesDAL BuildDAL(SqlDataReader reader)
	{
		PlaceTypesDAL dal = new PlaceTypesDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.PlaceType = reader["Type"].ToString();
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static PlaceTypesDAL Get(string placeType)
	{
		if (string.IsNullOrEmpty(placeType))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Type", placeType));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString_PlaceAttributeDAL, "PlaceTypes_GetPlaceTypeByType", queryParameters), BuildDAL);
	}
}
