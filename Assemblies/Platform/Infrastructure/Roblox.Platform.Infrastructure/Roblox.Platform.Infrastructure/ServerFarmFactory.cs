using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class ServerFarmFactory
{
	private class ServerFarmDefinition : IServerFarm
	{
		public short Id { get; internal set; }

		public string Name { get; internal set; }

		public int ServerTypeId { get; internal set; }

		public string Abbreviation { get; internal set; }
	}

	private static readonly TimeSpan _AllServerFarmsListCacheDuration = TimeSpan.FromMinutes(10.0);

	private static readonly TimeSpan _IndividualFarmCacheDuration = TimeSpan.FromDays(1.0);

	public IEnumerable<IServerFarm> GetAllServerFarms()
	{
		return InfrastructureCache.FetchItem("GetAllServerFarms:", _AllServerFarmsListCacheDuration, delegate
		{
			List<ServerFarmDefinition> list = new List<ServerFarmDefinition>();
			DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "[ServerFarms_GetAllServerFarms]");
			using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
			using SqlDataReader sqlDataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
			while (sqlDataReader.Read())
			{
				ServerFarmDefinition item = BuildServerDefinition(sqlDataReader);
				list.Add(item);
			}
			return list;
		});
	}

	public IServerFarm GetServerFarmById(short serverFarmId)
	{
		return InfrastructureCache.FetchItem("ServerFarmID:" + serverFarmId, _IndividualFarmCacheDuration, delegate
		{
			DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "[ServerFarms_GetByID]");
			using (DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString))
			{
				dbHelper.SQLParameters.Add(new SqlParameter("@ID", serverFarmId));
				using SqlDataReader sqlDataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
				if (sqlDataReader.Read())
				{
					return BuildServerDefinition(sqlDataReader);
				}
			}
			return null;
		});
	}

	private static ServerFarmDefinition BuildServerDefinition(IDataRecord reader)
	{
		return new ServerFarmDefinition
		{
			Id = (short)reader["ID"],
			Name = (string)reader["Name"],
			Abbreviation = (reader["Abbreviation"] as string),
			ServerTypeId = (int)reader["ServerTypeID"]
		};
	}
}
