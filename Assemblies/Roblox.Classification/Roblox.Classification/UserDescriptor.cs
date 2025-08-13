using System;
using System.Collections.Generic;
using Roblox.Segmentation.Client;
using Roblox.Users;

namespace Roblox.Classification;

public class UserDescriptor
{
	private readonly DateTime? BirthDate;

	private readonly byte GenderTypeId;

	public UserDescriptor(DateTime? birthDate, byte? genderTypeId)
	{
		BirthDate = birthDate;
		if (genderTypeId.HasValue)
		{
			GenderTypeId = genderTypeId.Value;
		}
		else
		{
			GenderTypeId = GenderType.UnknownID;
		}
	}

	private int CalculateAge(DateTime birthday)
	{
		DateTime today = DateTime.Today;
		int age = today.Year - birthday.Year;
		if (birthday.AddYears(age) > today)
		{
			age--;
		}
		return age;
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:Roblox.ApiClientBase.ApiClientException"></exception>
	public ISegment GetAgeSegment()
	{
		if (BirthDate.HasValue)
		{
			int age = CalculateAge(BirthDate.Value);
			return AgeClassifier.Singleton.Classify(age);
		}
		return AgeClassifier.Singleton.UnknownSegment;
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:Roblox.ApiClientBase.ApiClientException"></exception>
	public ISegment GetGenderSegment()
	{
		GenderType genderType = GenderType.Get(GenderTypeId);
		if (genderType == null)
		{
			return GenderClassifier.Singleton.UnknownSegment;
		}
		return GenderClassifier.Singleton.Classify(genderType.Value);
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:Roblox.ApiClientBase.ApiClientException"></exception>
	public IEnumerable<ISegment> GetAgeAndGenderSegments()
	{
		yield return GetAgeSegment();
		yield return GetGenderSegment();
	}
}
