using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class PhoneNumberDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxDemographics;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal short? PhoneNumberInternationalPrefixID { get; set; }

	internal string NationalPhoneNumber { get; set; }

	internal bool? IsBlacklisted { get; set; }

	private static PhoneNumberDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PhoneNumberDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			PhoneNumberInternationalPrefixID = (short?)record["PhoneNumberInternationalPrefixID"],
			NationalPhoneNumber = (string)record["NationalPhoneNumber"],
			IsBlacklisted = (bool?)record["IsBlacklisted"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxDemographics.Delete("PhoneNumbers_DeletePhoneNumberByID", ID);
	}

	internal static PhoneNumberDAL Get(int id)
	{
		return RobloxDatabase.RobloxDemographics.Get("PhoneNumbers_GetPhoneNumberByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@PhoneNumberInternationalPrefixID", PhoneNumberInternationalPrefixID.HasValue ? ((object)PhoneNumberInternationalPrefixID) : DBNull.Value),
			new SqlParameter("@NationalPhoneNumber", string.IsNullOrEmpty(NationalPhoneNumber) ? ((IConvertible)DBNull.Value) : ((IConvertible)NationalPhoneNumber)),
			new SqlParameter("@IsBlacklisted", IsBlacklisted.HasValue ? ((object)IsBlacklisted) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxDemographics.Insert<int>("PhoneNumbers_InsertPhoneNumber", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@PhoneNumberInternationalPrefixID", PhoneNumberInternationalPrefixID.HasValue ? ((object)PhoneNumberInternationalPrefixID) : DBNull.Value),
			new SqlParameter("@NationalPhoneNumber", string.IsNullOrEmpty(NationalPhoneNumber) ? ((IConvertible)DBNull.Value) : ((IConvertible)NationalPhoneNumber)),
			new SqlParameter("@IsBlacklisted", IsBlacklisted.HasValue ? ((object)IsBlacklisted) : DBNull.Value)
		};
		RobloxDatabase.RobloxDemographics.Update("PhoneNumbers_UpdatePhoneNumberByID", queryParameters);
	}

	internal static ICollection<PhoneNumberDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxDemographics.MultiGet("PhoneNumbers_GetPhoneNumbersByIDs", ids, BuildDAL);
	}

	internal static PhoneNumberDAL GetPhoneNumberByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxDemographics.Lookup("PhoneNumbers_GetPhoneNumberByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PhoneNumberDAL> GetOrCreatePhoneNumber(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxDemographics.GetOrCreate("PhoneNumbers_GetOrCreatePhoneNumber", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetPhoneNumberIDsByNationalPhoneNumber(string nationalPhoneNumber, int count, int? exclusiveStartId)
	{
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		if (string.IsNullOrWhiteSpace(nationalPhoneNumber))
		{
			throw new ApplicationException("Parameter 'nationalPhoneNumber' cannot be null or whitespace.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@NationalPhoneNumber", string.IsNullOrEmpty(nationalPhoneNumber) ? ((IConvertible)DBNull.Value) : ((IConvertible)nationalPhoneNumber)),
			new SqlParameter("@Count", count),
			null
		};
		int? num = exclusiveStartId;
		obj[2] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxDemographics.GetIDCollection<int>("PhoneNumbers_GetPhoneNumberIDsByNationalPhoneNumber", queryParameters);
	}
}
