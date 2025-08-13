using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Studio.Entities;

internal class ToolboxSearchAlgorithmDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxStudio;

	internal int ID { get; set; }

	internal string Name { get; set; }

	internal string Desciption { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ToolboxSearchAlgorithmDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ToolboxSearchAlgorithmDAL
		{
			ID = (int)record["ID"],
			Name = (string)record["Name"],
			Desciption = (string)record["Desciption"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxStudio.Delete("ToolboxSearchAlgorithms_DeleteAlgorithmByID", ID);
	}

	internal static ToolboxSearchAlgorithmDAL Get(long id)
	{
		return RobloxDatabase.RobloxStudio.Get("ToolboxSearchAlgorithms_GetAlgorithmByID", id, BuildDAL);
	}

	internal static ToolboxSearchAlgorithmDAL GetToolboxSearchAlgorithmByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxStudio.Lookup("ToolboxSearchAlgorithms_GetToolboxSearchAlgorithmByName", BuildDAL, queryParameters);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@Desciption", string.IsNullOrEmpty(Desciption) ? ((IConvertible)DBNull.Value) : ((IConvertible)Desciption)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxStudio.Insert<int>("ToolboxSearchAlgorithms_InsertAlgorithm", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Desciption", string.IsNullOrEmpty(Desciption) ? ((IConvertible)DBNull.Value) : ((IConvertible)Desciption)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxStudio.Update("ToolboxSearchAlgorithms_UpdateAlgorithmByID", queryParameters);
	}

	internal static ICollection<ToolboxSearchAlgorithmDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxStudio.MultiGet("ToolboxSearchAlgorithms_GetAlgorithmsByIDs", ids, BuildDAL);
	}

	internal static ICollection<int> GetToolboxSearchAlgorithmIDsPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxStudio.GetIDCollection<int>("ToolboxSearchAlgorithms_GetToolboxSearchAlgorithmIDs_Paged", queryParameters);
	}
}
