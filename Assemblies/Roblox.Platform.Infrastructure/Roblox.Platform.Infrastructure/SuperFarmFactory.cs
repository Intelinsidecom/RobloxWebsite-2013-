using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class SuperFarmFactory
{
	private class SuperFarmDefinition : ISuperFarm
	{
		public int Id { get; internal set; }

		public string Name { get; internal set; }
	}

	private static readonly TimeSpan _AllSuperFarmsListCacheDuration = TimeSpan.FromMinutes(15.0);

	private static readonly TimeSpan _IndividualSuperFarmCacheDuration = TimeSpan.FromDays(1.0);

	public IEnumerable<ISuperFarm> GetAllServerFarms()
	{
		return InfrastructureCache.FetchItem("GetAllSuperFarms:", _AllSuperFarmsListCacheDuration, delegate
		{
			List<SuperFarmDefinition> list = new List<SuperFarmDefinition>();
			DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "[SuperFarms_GetAll]");
			using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
			using SqlDataReader sqlDataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
			while (sqlDataReader.Read())
			{
				SuperFarmDefinition item = BuildSuperFarmDefinition(sqlDataReader);
				list.Add(item);
			}
			return list;
		});
	}

	public ISuperFarm GetServerFarmById(int superFarmId)
	{
		return InfrastructureCache.FetchItem("SuperFarmID:" + superFarmId, _IndividualSuperFarmCacheDuration, delegate
		{
			DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "[SuperFarms_GetByID]");
			using (DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString))
			{
				dbHelper.SQLParameters.Add(new SqlParameter("@ID", superFarmId));
				using SqlDataReader sqlDataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
				if (sqlDataReader.Read())
				{
					return BuildSuperFarmDefinition(sqlDataReader);
				}
			}
			return null;
		});
	}

	private static SuperFarmDefinition BuildSuperFarmDefinition(IDataRecord reader)
	{
		return new SuperFarmDefinition
		{
			Id = (int)reader["ID"],
			Name = (string)reader["Name"]
		};
	}
}
