using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.ContentRatings.Properties;
using Roblox.Data;

namespace Roblox.ContentRatings;

public class ContentRatingTypeDAL
{
	private byte _ID;

	public string Value;

	public DateTime Created;

	public DateTime Updated;

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

	private static string dbConnectionString_ContentRatingTypeDAL => Settings.Default.ContentRatingsConnectionString;

	private static ContentRatingTypeDAL BuildDAL(SqlDataReader reader)
	{
		ContentRatingTypeDAL dal = new ContentRatingTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(dbConnectionString_ContentRatingTypeDAL, "ContentRatingTypes_InsertContentRatingType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_ContentRatingTypeDAL, "ContentRatingTypes_UpdateContentRatingTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_ContentRatingTypeDAL, "ContentRatingTypes_DeleteContentRatingTypeByID", queryParameters));
	}

	public static ContentRatingTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ContentRatingTypeDAL, "ContentRatingTypes_GetContentRatingTypeByID", queryParameters), BuildDAL);
	}

	public static ContentRatingTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ContentRatingTypeDAL, "ContentRatingTypes_GetContentRatingTypeByValue", queryParameters), BuildDAL);
	}
}
