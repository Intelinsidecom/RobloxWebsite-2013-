using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class VariationDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal int ID { get; set; }

	internal int ExperimentID { get; set; }

	internal int Value { get; set; }

	internal int PercentEnrollments { get; set; }

	internal byte Version { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static VariationDAL BuildDAL(IDictionary<string, object> record)
	{
		return new VariationDAL
		{
			ID = (int)record["ID"],
			ExperimentID = (int)record["ExperimentID"],
			Value = (int)record["Value"],
			PercentEnrollments = (int)record["PercentEnrollments"],
			Version = (byte)record["Version"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("Variations_DeleteVariationByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@PercentEnrollments", PercentEnrollments),
			new SqlParameter("@Version", Version),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<int>("Variations_InsertVariation", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@PercentEnrollments", PercentEnrollments),
			new SqlParameter("@Version", Version),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAbTesting.Update("Variations_UpdateVariationByID", queryParameters);
	}

	internal static VariationDAL Get(int id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("Variations_GetVariationByID", id, BuildDAL);
	}

	internal static ICollection<VariationDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("Variations_GetVariationsByIDs", ids, BuildDAL);
	}

	internal static ICollection<int> GetVariationIDsByExperimentIDAndVersionPaged(int experimentID, byte version, long startRowIndex, long maximumRows)
	{
		if (experimentID == 0)
		{
			throw new ArgumentException("Parameter 'experimentID' cannot be null, empty or the default value.");
		}
		if (version == 0)
		{
			throw new ArgumentException("Parameter 'version' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ExperimentID", experimentID),
			new SqlParameter("@Version", version),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAbTesting.GetIDCollection<int>("Variations_GetVariationIDsByExperimentIDAndVersion_Paged", queryParameters);
	}
}
