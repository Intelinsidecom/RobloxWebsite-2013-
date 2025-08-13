using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

internal class RobloxPhoneNumberCredentials : UserCredentialsBase
{
	private readonly IPhoneNumberFactory _PhoneNumberFactory;

	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	private readonly IPhoneNumberValidator _PhoneNumberValidator;

	public override CredentialsType CredentialsType => CredentialsType.PhoneNumber;

	public override string CredentialValue => PhoneNumber;

	internal virtual string PhoneNumber { get; }

	internal virtual string Password { get; }

	[ExcludeFromCodeCoverage]
	internal virtual int GetAccountPhoneNumbersByPhoneNumberPageSize => Settings.Default.GetAccountPhoneNumbersByPhoneNumberPageSize;

	[ExcludeFromCodeCoverage]
	internal virtual int GetPhoneNumbersByNationalPhoneNumberPageSize => Settings.Default.GetPhoneNumbersByNationalPhoneNumberPageSize;

	[ExcludeFromCodeCoverage]
	internal virtual int NationalPhoneNumbersThreshold => Settings.Default.NationalPhoneNumbersThreshold;

	[ExcludeFromCodeCoverage]
	internal virtual int CheckAccountPhoneNumbersMaxDegreeOfParallelism => Settings.Default.CheckAccountPhoneNumbersMaxDegreeOfParallelism;

	[ExcludeFromCodeCoverage]
	internal virtual int AccountsPerPhoneNumberThreshold => Settings.Default.AccountsPerPhoneNumberThreshold;

	internal RobloxPhoneNumberCredentials(string phoneNumber, string password, IUserFactory userFactory, IPhoneNumberFactory phoneNumberFactory, IAccountPhoneNumberFactory accountPhoneNumberFactory, IPhoneNumberValidator phoneNumberValidator, IPasswordsClient passwordsClient, IAuthenticationSettings authenticationSettings)
		: base(userFactory, passwordsClient, authenticationSettings)
	{
		if (string.IsNullOrWhiteSpace(phoneNumber))
		{
			throw new ArgumentException("The phone number can not be null or whitespace", "phoneNumber");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("The password can not be null or empty", "password");
		}
		PhoneNumber = phoneNumber;
		Password = password;
		_PhoneNumberFactory = phoneNumberFactory ?? throw new ArgumentNullException("phoneNumberFactory");
		_AccountPhoneNumberFactory = accountPhoneNumberFactory ?? throw new ArgumentNullException("accountPhoneNumberFactory");
		_PhoneNumberValidator = phoneNumberValidator ?? throw new ArgumentNullException("phoneNumberValidator");
	}

	public override IUser GetUser()
	{
		if (base.User != null)
		{
			return base.User;
		}
		if (string.IsNullOrWhiteSpace(Password))
		{
			return null;
		}
		if (base.UserFactory.GetUserByName(PhoneNumber) != null)
		{
			throw new CredentialsCollisionException(CredentialsType, PhoneNumber, CredentialsType.Username);
		}
		if (!_PhoneNumberValidator.TryGetSanitizedPhoneNumberFromPhoneNumber(PhoneNumber, out var sanitizedPhoneNumber) || string.IsNullOrWhiteSpace(sanitizedPhoneNumber.NationalNumber))
		{
			return null;
		}
		List<IPhoneNumber> phoneNumbers = GetByNationalPhoneNumber(sanitizedPhoneNumber.NationalNumber).ToList();
		if (sanitizedPhoneNumber.FullNumber != sanitizedPhoneNumber.NationalNumber)
		{
			phoneNumbers.AddRange(GetByNationalPhoneNumber(sanitizedPhoneNumber.FullNumber));
		}
		string strippedPhoneNumber = _PhoneNumberValidator.StripInvalidCharacters(PhoneNumber);
		if (sanitizedPhoneNumber.NationalNumber != strippedPhoneNumber && sanitizedPhoneNumber.FullNumber != strippedPhoneNumber)
		{
			phoneNumbers.AddRange(GetByNationalPhoneNumber(strippedPhoneNumber));
		}
		if (phoneNumbers.Count == 0)
		{
			return null;
		}
		if (phoneNumbers.Count > NationalPhoneNumbersThreshold)
		{
			throw new TooManyUsersLinkedToCredentialsException(CredentialsType.PhoneNumber, PhoneNumber);
		}
		Dictionary<long, IAccountPhoneNumber> accountPhoneNumberMap = new Dictionary<long, IAccountPhoneNumber>();
		foreach (IPhoneNumber phoneNumber in phoneNumbers)
		{
			List<IAccountPhoneNumber> accountPhoneNumbersFromPhone = GetAccountPhoneNumbersFromPhone(phoneNumber);
			if (accountPhoneNumbersFromPhone.Count > AccountsPerPhoneNumberThreshold)
			{
				throw new TooManyUsersLinkedToCredentialsException(CredentialsType.PhoneNumber, PhoneNumber);
			}
			foreach (IAccountPhoneNumber accountPhoneNumber in accountPhoneNumbersFromPhone)
			{
				if (!accountPhoneNumberMap.ContainsKey(accountPhoneNumber.AccountId))
				{
					accountPhoneNumberMap.Add(accountPhoneNumber.AccountId, accountPhoneNumber);
				}
			}
		}
		ConcurrentBag<IUser> users = new ConcurrentBag<IUser>();
		Parallel.ForEach(accountPhoneNumberMap.Values.ToList(), new ParallelOptions
		{
			MaxDegreeOfParallelism = CheckAccountPhoneNumbersMaxDegreeOfParallelism
		}, delegate(IAccountPhoneNumber accountPhone)
		{
			IUser userByAccountId = base.UserFactory.GetUserByAccountId(accountPhone.AccountId);
			if (userByAccountId != null && IsValidPasswordForUser(userByAccountId, Password))
			{
				users.Add(userByAccountId);
			}
		});
		if (users.IsEmpty)
		{
			if (accountPhoneNumberMap.Count >= 1)
			{
				throw new InvalidCredentialsException(CredentialsType.PhoneNumber, PhoneNumber);
			}
			return null;
		}
		if (users.Count > 1)
		{
			throw new MultipleUsersPerCredentialException(CredentialsType.PhoneNumber, PhoneNumber);
		}
		base.User = users.First();
		return base.User;
	}

	public override bool Verify()
	{
		IUser user = GetUser();
		if (user == null)
		{
			return false;
		}
		return IsValidPasswordForUser(user, Password);
	}

	private List<IAccountPhoneNumber> GetAccountPhoneNumbersFromPhone(IPhoneNumberIdentifier phoneNumber)
	{
		List<IAccountPhoneNumber> accountPhoneNumbers = new List<IAccountPhoneNumber>();
		int? exclusiveStartId = null;
		do
		{
			int count = Math.Min(GetAccountPhoneNumbersByPhoneNumberPageSize, AccountsPerPhoneNumberThreshold + 1 - accountPhoneNumbers.Count);
			ICollection<IAccountPhoneNumber> accountPhoneNumbersPage = _AccountPhoneNumberFactory.GetByPhoneNumberIsVerifiedAndIsActive(phoneNumber, isVerified: true, isActive: true, count, exclusiveStartId);
			if (accountPhoneNumbersPage?.FirstOrDefault() == null)
			{
				break;
			}
			accountPhoneNumbers.AddRange(accountPhoneNumbersPage);
			exclusiveStartId = accountPhoneNumbersPage.Last().Id;
		}
		while (accountPhoneNumbers.Count <= AccountsPerPhoneNumberThreshold);
		return accountPhoneNumbers;
	}

	private IEnumerable<IPhoneNumber> GetByNationalPhoneNumber(string nationalPhoneNumber)
	{
		List<IPhoneNumber> currentPhoneNumbers = new List<IPhoneNumber>();
		int? exclusiveStartId = null;
		do
		{
			int count = Math.Min(GetPhoneNumbersByNationalPhoneNumberPageSize, NationalPhoneNumbersThreshold + 1 - currentPhoneNumbers.Count);
			ICollection<IPhoneNumber> phoneNumbersPage = _PhoneNumberFactory.GetByNationalPhoneNumber(nationalPhoneNumber, count, exclusiveStartId);
			if (phoneNumbersPage?.FirstOrDefault() == null)
			{
				break;
			}
			currentPhoneNumbers.AddRange(phoneNumbersPage);
			exclusiveStartId = phoneNumbersPage.Last().Id;
		}
		while (currentPhoneNumbers.Count <= NationalPhoneNumbersThreshold);
		return currentPhoneNumbers;
	}
}
