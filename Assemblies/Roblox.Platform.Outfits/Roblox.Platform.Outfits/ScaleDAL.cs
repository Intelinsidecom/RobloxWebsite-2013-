using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Outfits;

[Serializable]
internal class ScaleDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal int ID { get; set; }

	internal decimal Height { get; set; }

	internal decimal Width { get; set; }

	internal decimal Head { get; set; }

	internal DateTime Created { get; set; }

	internal decimal? Proportion { get; set; }

	internal decimal? BodyType { get; set; }

	private static ScaleDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ScaleDAL
		{
			ID = (int)record["ID"],
			Height = (decimal)record["Height"],
			Width = (decimal)record["Width"],
			Head = (decimal)record["Head"],
			Created = (DateTime)record["Created"],
			Proportion = (decimal?)record["Proportion"],
			BodyType = (decimal?)record["BodyType"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("Scales_DeleteScaleByID", ID);
	}

	internal static ScaleDAL Get(int id)
	{
		return RobloxDatabase.RobloxAvatars.Get("Scales_GetScaleByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Height", Height),
			new SqlParameter("@Width", Width),
			new SqlParameter("@Head", Head),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Proportion", Proportion),
			new SqlParameter("@BodyType", BodyType)
		};
		ID = RobloxDatabase.RobloxAvatars.Insert<int>("Scales_InsertScale", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Height", Height),
			new SqlParameter("@Width", Width),
			new SqlParameter("@Head", Head),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Proportion", Proportion),
			new SqlParameter("@BodyType", BodyType)
		};
		RobloxDatabase.RobloxAvatars.Update("Scales_UpdateScaleByID", queryParameters);
	}

	internal static ICollection<ScaleDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("Scales_GetScalesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ScaleDAL> GetOrCreateScale(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		if (height == 0m || width == 0m || head == 0m)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Height", height),
			new SqlParameter("@Width", width),
			new SqlParameter("@Head", head),
			new SqlParameter("@Proportion", proportion),
			new SqlParameter("@BodyType", bodyType)
		};
		return RobloxDatabase.RobloxAvatars.GetOrCreate("Scales_GetOrCreateScale_V2", BuildDAL, queryParameters);
	}
}
