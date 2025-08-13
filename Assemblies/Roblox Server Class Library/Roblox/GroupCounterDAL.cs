using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class GroupCounterDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupCounters;

	public long ID { get; set; }

	public long GroupID { get; set; }

	public byte GroupCounterTypeID { get; set; }

	public long Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Increment(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Amount", amount),
			outputValue,
			outputUpdated
		};
		RobloxDatabase.RobloxGroupCounters.Update("GroupCounters_IncrementGroupCounterByID", queryParameters);
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxGroupCounters.Delete("GroupCounters_DeleteGroupCounterByID", ID);
	}

	public void Insert()
	{
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (GroupCounterTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: GroupCounterTypeID");
		}
		if (Value == 0L)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@GroupCounterTypeID", GroupCounterTypeID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupCounters.Insert<long>("GroupCounters_InsertGroupCounter", queryParameters);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (GroupCounterTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: GroupCounterTypeID");
		}
		if (Value == 0L)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@GroupCounterTypeID", GroupCounterTypeID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupCounters.Update("GroupCounters_UpdateGroupCounterByID", queryParameters);
	}

	public void TryDecrement(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputIsSuccess = new SqlParameter("@IsSuccess", SqlDbType.Bit)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Amount", amount),
			outputValue,
			outputUpdated,
			outputIsSuccess
		};
		RobloxDatabase.RobloxGroupCounters.Update("GroupCounters_TryDecrementGroupCounterByID", queryParameters);
		if ((bool)outputIsSuccess.Value)
		{
			Value = (long)outputValue.Value;
			Updated = (DateTime)outputUpdated.Value;
		}
	}

	public static GroupCounterDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return RobloxDatabase.RobloxGroupCounters.Get("GroupCounters_GetGroupCounterByID", id, BuildDAL);
	}

	private static GroupCounterDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupCounterDAL
		{
			ID = (long)record["ID"],
			GroupID = Convert.ToInt64(record["GroupID"]),
			GroupCounterTypeID = (byte)record["GroupCounterTypeID"],
			Value = (long)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public static EntityHelper.GetOrCreateDALWrapper<GroupCounterDAL> GetOrCreate(long groupId, byte groupCounterTypeId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (groupCounterTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: GroupCounterTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@GroupCounterTypeID", groupCounterTypeId),
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			}
		};
		return RobloxDatabase.RobloxGroupCounters.GetOrCreate("GroupCounters_GetOrCreateGroupCounter", BuildDAL, queryParameters);
	}
}
