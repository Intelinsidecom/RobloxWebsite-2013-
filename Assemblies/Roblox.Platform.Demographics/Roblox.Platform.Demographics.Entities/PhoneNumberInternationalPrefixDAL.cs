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
internal class PhoneNumberInternationalPrefixDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxDemographics;

	internal short ID { get; set; }

	internal int CountryID { get; set; }

	internal string InternationalPrefix { get; set; }

	internal bool IsActive { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static PhoneNumberInternationalPrefixDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PhoneNumberInternationalPrefixDAL
		{
			ID = (short)record["ID"],
			CountryID = (int)record["CountryID"],
			InternationalPrefix = (string)record["InternationalPrefix"],
			IsActive = (bool)record["IsActive"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxDemographics.Delete("PhoneNumberInternationalPrefixes_DeletePhoneNumberInternationalPrefixByID", ID);
	}

	internal static PhoneNumberInternationalPrefixDAL Get(short id)
	{
		return RobloxDatabase.RobloxDemographics.Get("PhoneNumberInternationalPrefixes_GetPhoneNumberInternationalPrefixByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@InternationalPrefix", InternationalPrefix),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxDemographics.Insert<short>("PhoneNumberInternationalPrefixes_InsertPhoneNumberInternationalPrefix", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@InternationalPrefix", InternationalPrefix),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxDemographics.Update("PhoneNumberInternationalPrefixes_UpdatePhoneNumberInternationalPrefixByID", queryParameters);
	}

	internal static ICollection<PhoneNumberInternationalPrefixDAL> MultiGet(ICollection<short> ids)
	{
		return RobloxDatabase.RobloxDemographics.MultiGet("PhoneNumberInternationalPrefixes_GetPhoneNumberInternationalPrefixesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PhoneNumberInternationalPrefixDAL> GetOrCreatePhoneNumberInternationalPrefix(int countryId, string internationalPrefix)
	{
		if (countryId == 0)
		{
			return null;
		}
		if (string.IsNullOrEmpty(internationalPrefix))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@CountryID", countryId),
			new SqlParameter("@InternationalPrefix", internationalPrefix)
		};
		return RobloxDatabase.RobloxDemographics.GetOrCreate("PhoneNumberInternationalPrefixes_GetOrCreatePhoneNumberInternationalPrefix", BuildDAL, queryParameters);
	}

	internal static ICollection<short> GetPhoneNumberInternationalPrefixIDsByIsActive(bool isActive, int count, short? exclusiveStartPhoneNumberInternationalPrefixId)
	{
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartPhoneNumberInternationalPrefixId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartPhoneNumberInternationalPrefixID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@IsActive", isActive),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartPhoneNumberInternationalPrefixID", exclusiveStartPhoneNumberInternationalPrefixId)
		};
		return RobloxDatabase.RobloxDemographics.GetIDCollection<short>("PhoneNumberInternationalPrefixes_GetPhoneNumberInternationalPrefixIDsByIsActive", queryParameters);
	}

	internal static PhoneNumberInternationalPrefixDAL GetPhoneNumberInternationalPrefixByCountryIDAndInternationalPrefix(int countryId, string internationalPrefix)
	{
		if (countryId == 0)
		{
			return null;
		}
		if (string.IsNullOrEmpty(internationalPrefix))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CountryID", countryId),
			new SqlParameter("@InternationalPrefix", internationalPrefix)
		};
		return RobloxDatabase.RobloxDemographics.Lookup("PhoneNumberInternationalPrefixes_GetPhoneNumberInternationalPrefixByCountryIDAndInternationalPrefix", BuildDAL, queryParameters);
	}

	internal static ICollection<short> GetPhoneNumberInternationalPrefixIDsByCountryID(int countryId, int count, short? exclusiveStartPhoneNumberInternationalPrefixId)
	{
		if (countryId == 0)
		{
			throw new ArgumentException("Parameter 'countryId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartPhoneNumberInternationalPrefixId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartPhoneNumberInternationalPrefixID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CountryID", countryId),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartPhoneNumberInternationalPrefixID", exclusiveStartPhoneNumberInternationalPrefixId)
		};
		return RobloxDatabase.RobloxDemographics.GetIDCollection<short>("PhoneNumberInternationalPrefixes_GetPhoneNumberInternationalPrefixIDsByCountryID", queryParameters);
	}
}
