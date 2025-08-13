using System.Linq;
using System.Text;
using PhoneNumbers;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Demographics.IPhoneNumberValidator" />.
/// </summary>
public class PhoneNumberValidator : IPhoneNumberValidator
{
	protected const int MaxValidPhoneNumberLength = 20;

	protected const int MinValidPhoneNumberLength = 5;

	private readonly DemographicsDomainFactories _DomainFactories;

	private const string _UnknownRegion = "ZZ";

	private const char _InternationalPhoneNumberPrefixSymbol = '+';

	public PhoneNumberValidator(DemographicsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
	}

	public bool IsValid(string phone)
	{
		if (string.IsNullOrEmpty(phone))
		{
			throw new PlatformArgumentException("phone");
		}
		return CheckLength(phone);
	}

	public bool IsValid(string internationalPrefix, string nationalPhoneNumber, string twoLetterCountryCode)
	{
		if (string.IsNullOrEmpty(nationalPhoneNumber))
		{
			throw new PlatformArgumentNullException("nationalPhoneNumber");
		}
		if (string.IsNullOrEmpty(internationalPrefix))
		{
			throw new PlatformArgumentNullException("internationalPrefix");
		}
		if (string.IsNullOrEmpty(twoLetterCountryCode))
		{
			throw new PlatformArgumentNullException("twoLetterCountryCode");
		}
		if (!CheckLength(nationalPhoneNumber))
		{
			return false;
		}
		PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
		PhoneNumber phoneNumber;
		try
		{
			phoneNumber = phoneNumberUtil.Parse(nationalPhoneNumber, twoLetterCountryCode);
		}
		catch
		{
			return false;
		}
		if (phoneNumberUtil.IsValidNumber(phoneNumber))
		{
			return phoneNumberUtil.GetNationalSignificantNumber(phoneNumber) != null;
		}
		return false;
	}

	public ISanitizedPhoneNumber GetSanitizedPhoneNumber(string internationalPrefixNumber, string nationalPhoneNumber, string twoLetterCountryCode)
	{
		if (internationalPrefixNumber == null)
		{
			throw new PlatformArgumentNullException("internationalPrefixNumber");
		}
		string sanitizedNationalPhoneNumber = GetSignificantNumber(nationalPhoneNumber, twoLetterCountryCode);
		if (sanitizedNationalPhoneNumber == null)
		{
			throw new PlatformInvalidPhoneNumberException("tried to parse an invalid phone");
		}
		IPhoneNumberInternationalPrefix internationalPrefix = _DomainFactories.PhoneNumberInternationalPrefixFactory.GetByCountryAndPrefix(twoLetterCountryCode, internationalPrefixNumber);
		if (internationalPrefix == null)
		{
			throw new PlatformInvalidPhoneNumberException("Unrecognized country code.");
		}
		return new SanitizedPhoneNumber
		{
			InternationalPrefix = internationalPrefix,
			NationalNumber = sanitizedNationalPhoneNumber,
			FullNumber = internationalPrefix.Value + sanitizedNationalPhoneNumber
		};
	}

	/// <inheritdoc />
	public bool TryGetSanitizedPhoneNumberFromPhoneNumber(string phoneNumber, out ISanitizedPhoneNumber sanitizedPhoneNumber, string twoLetterCountryCode = null)
	{
		sanitizedPhoneNumber = null;
		if (string.IsNullOrWhiteSpace(phoneNumber))
		{
			return false;
		}
		if (!IsValid(phoneNumber))
		{
			return false;
		}
		phoneNumber = StripInvalidCharacters(phoneNumber);
		if (TryParsePhoneNumber(phoneNumber, twoLetterCountryCode, out var parsedPhoneNumber))
		{
			IPhoneNumberInternationalPrefix internationalPrefix = null;
			if (!string.IsNullOrWhiteSpace(twoLetterCountryCode))
			{
				internationalPrefix = _DomainFactories.PhoneNumberInternationalPrefixFactory.GetByCountryAndPrefix(twoLetterCountryCode, parsedPhoneNumber.CountryCode.ToString());
			}
			sanitizedPhoneNumber = BuildFromParsedPhone(parsedPhoneNumber, internationalPrefix);
			return true;
		}
		sanitizedPhoneNumber = new SanitizedPhoneNumber
		{
			NationalNumber = phoneNumber,
			FullNumber = phoneNumber,
			InternationalPrefix = null
		};
		return true;
	}

	public string GetFormattedPhoneNumber(string phoneNumber, string twoLetterCountryCode = null)
	{
		if (string.IsNullOrWhiteSpace(phoneNumber))
		{
			throw new PlatformArgumentException("phoneNumber");
		}
		PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
		PhoneNumber pNumber;
		try
		{
			pNumber = phoneNumberUtil.Parse(phoneNumber, twoLetterCountryCode ?? "ZZ");
		}
		catch
		{
			throw new PlatformInvalidPhoneNumberException("Tried to parse an invalid phone");
		}
		if (!phoneNumberUtil.IsValidNumber(pNumber))
		{
			throw new PlatformInvalidPhoneNumberException("Invalid phone number.");
		}
		string nationalSignificantNumber = phoneNumberUtil.GetNationalSignificantNumber(pNumber);
		if (!pNumber.HasCountryCode || nationalSignificantNumber == null)
		{
			throw new PlatformInvalidPhoneNumberException("No country code or invalid national number.");
		}
		return $"{pNumber.CountryCode}{nationalSignificantNumber}";
	}

	public string StripInvalidCharacters(string phoneNumber)
	{
		if (string.IsNullOrEmpty(phoneNumber))
		{
			return phoneNumber;
		}
		phoneNumber = phoneNumber.Trim();
		StringBuilder sb = new StringBuilder();
		if (phoneNumber[0] == '+')
		{
			sb.Append('+');
		}
		foreach (char digit in phoneNumber.Where(char.IsNumber))
		{
			sb.Append(digit);
		}
		return sb.ToString();
	}

	private ISanitizedPhoneNumber BuildFromParsedPhone(PhoneNumber phoneNumber, IPhoneNumberInternationalPrefix phoneNumberInternationalPrefix = null)
	{
		string nationalNumber = PhoneNumberUtil.GetInstance().GetNationalSignificantNumber(phoneNumber);
		string fullNumber = (phoneNumber.HasCountryCode ? $"{phoneNumber.CountryCode}{nationalNumber}" : nationalNumber);
		return new SanitizedPhoneNumber
		{
			NationalNumber = nationalNumber,
			FullNumber = fullNumber,
			InternationalPrefix = phoneNumberInternationalPrefix
		};
	}

	private bool TryParsePhoneNumber(string phoneNumber, string twoLetterCountryCode, out PhoneNumber parsedPhoneNumber)
	{
		parsedPhoneNumber = null;
		if (string.IsNullOrEmpty(phoneNumber))
		{
			return false;
		}
		if (string.IsNullOrWhiteSpace(twoLetterCountryCode))
		{
			twoLetterCountryCode = "ZZ";
		}
		StringBuilder sb = new StringBuilder(phoneNumber);
		if (phoneNumber[0] != '+' && twoLetterCountryCode == "ZZ")
		{
			sb.Insert(0, '+');
		}
		PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
		try
		{
			parsedPhoneNumber = phoneNumberUtil.Parse(sb.ToString(), twoLetterCountryCode);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static bool CheckLength(string phone)
	{
		char[] numbers = phone.Where(char.IsNumber).ToArray();
		if (numbers.Length >= 5)
		{
			return numbers.Length <= 20;
		}
		return false;
	}

	internal virtual string GetSignificantNumber(string nationalNumber, string twoLetterCountryCode)
	{
		PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
		PhoneNumber phoneNumber;
		try
		{
			phoneNumber = phoneNumberUtil.Parse(nationalNumber, twoLetterCountryCode);
		}
		catch
		{
			return null;
		}
		return phoneNumberUtil.GetNationalSignificantNumber(phoneNumber);
	}
}
