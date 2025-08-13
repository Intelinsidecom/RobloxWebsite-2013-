using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" /> for user email credentials.
/// </summary>
internal class RobloxEmailCredentials : UserCredentialsBase, IRobloxUnverifiedUserCredentials, IRobloxUserCredentials, IRobloxCredentials, ICredentials
{
	private readonly IAccountEmailAddressFactory _AccountEmailAddressFactory;

	public override CredentialsType CredentialsType => CredentialsType.Email;

	public override string CredentialValue => Email;

	internal virtual string Email { get; }

	internal virtual string Password { get; }

	[ExcludeFromCodeCoverage]
	internal virtual int AccountsByEmailAddressPageSize => Settings.Default.AccountsByEmailAddressPageSize;

	[ExcludeFromCodeCoverage]
	internal virtual int VerifiedAccountsPerEmailAddressesThreshold => Settings.Default.VerifiedAccountsPerEmailAddressesThreshold;

	[ExcludeFromCodeCoverage]
	internal virtual int UnverifiedAccountsPerEmailAddressesThreshold => Settings.Default.UnverifiedAccountsPerEmailAddressesThreshold;

	[ExcludeFromCodeCoverage]
	internal virtual int CheckEmailAccountsMaxDegreeOfParallelism => Settings.Default.CheckEmailAccountsMaxDegreeOfParallelism;

	internal RobloxEmailCredentials(string email, string password, IUserFactory userFactory, IAccountEmailAddressFactory accountEmailAddressFactory, IPasswordsClient passwordsClient, IAuthenticationSettings authenticationSettings)
		: base(userFactory, passwordsClient, authenticationSettings)
	{
		if (string.IsNullOrWhiteSpace(email))
		{
			throw new ArgumentException("email");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("password");
		}
		Email = email;
		Password = password;
		_AccountEmailAddressFactory = accountEmailAddressFactory ?? throw new ArgumentNullException("accountEmailAddressFactory");
	}

	public override IUser GetUser()
	{
		if (string.IsNullOrWhiteSpace(Email))
		{
			return null;
		}
		List<IAccountEmail> accountEmails = GetCurrentAccountEmailsByEmailAddressAndIsVerified(isVerified: true, VerifiedAccountsPerEmailAddressesThreshold).ToList();
		if (accountEmails.Count > VerifiedAccountsPerEmailAddressesThreshold)
		{
			throw new TooManyUsersLinkedToCredentialsException(CredentialsType.Email, Email);
		}
		ConcurrentBag<IUser> users = GetMatchingUsersByAccountEmailAddresses(accountEmails);
		if (users.Count == 1)
		{
			base.User = users.First();
			return base.User;
		}
		if (users.Count > 1)
		{
			throw new MultipleUsersPerCredentialException(CredentialsType.Email, Email);
		}
		List<IAccountEmail> unverifiedAccountEmails = GetCurrentAccountEmailsByEmailAddressAndIsVerified(isVerified: false, UnverifiedAccountsPerEmailAddressesThreshold).ToList();
		if (unverifiedAccountEmails.Count > UnverifiedAccountsPerEmailAddressesThreshold)
		{
			throw new TooManyUsersLinkedToCredentialsException(CredentialsType.Email, Email);
		}
		ConcurrentBag<IUser> unverifiedAccounts = GetMatchingUsersByAccountEmailAddresses(unverifiedAccountEmails);
		if (unverifiedAccounts.Count == 1)
		{
			throw new UnverifiedCredentialsException(CredentialsType.Email, Email, unverifiedAccounts.First());
		}
		if (unverifiedAccounts.Count > 1)
		{
			throw new UnverifiedCredentialsMultipleUsersException(CredentialsType.Email, Email);
		}
		if (accountEmails.Count + unverifiedAccountEmails.Count >= 1)
		{
			throw new InvalidCredentialsException(CredentialsType.Email, Email);
		}
		return null;
	}

	public override bool Verify()
	{
		IUser user = base.User ?? GetUser();
		if (user == null)
		{
			return false;
		}
		return IsValidPasswordForUser(user, Password);
	}

	/// <inheritdoc />
	public IUser GetUserFromUnverifiedCredentials()
	{
		if (string.IsNullOrWhiteSpace(Email))
		{
			return null;
		}
		List<IAccountEmail> unverifiedAccountEmails = GetCurrentAccountEmailsByEmailAddressAndIsVerified(isVerified: false, UnverifiedAccountsPerEmailAddressesThreshold).ToList();
		if (unverifiedAccountEmails.Count > UnverifiedAccountsPerEmailAddressesThreshold)
		{
			throw new TooManyUsersLinkedToCredentialsException(CredentialsType.Email, Email);
		}
		ConcurrentBag<IUser> unverifiedAccounts = GetMatchingUsersByAccountEmailAddresses(unverifiedAccountEmails);
		if (unverifiedAccounts.Count == 1)
		{
			return unverifiedAccounts.First();
		}
		if (unverifiedAccounts.Count > 1)
		{
			throw new MultipleUsersPerCredentialException(CredentialsType.Email, Email);
		}
		return null;
	}

	private ConcurrentBag<IUser> GetMatchingUsersByAccountEmailAddresses(IEnumerable<IAccountEmail> accountEmails)
	{
		ConcurrentBag<IUser> users = new ConcurrentBag<IUser>();
		Parallel.ForEach(accountEmails, new ParallelOptions
		{
			MaxDegreeOfParallelism = CheckEmailAccountsMaxDegreeOfParallelism
		}, delegate(IAccountEmail accountEmail)
		{
			IUser userByAccountId = base.UserFactory.GetUserByAccountId(accountEmail.AccountId);
			if (userByAccountId != null && IsValidPasswordForUser(userByAccountId, Password))
			{
				users.Add(userByAccountId);
			}
		});
		return users;
	}

	private IEnumerable<IAccountEmail> GetCurrentAccountEmailsByEmailAddressAndIsVerified(bool isVerified, int accountsPerEmailAddressThreshold)
	{
		int maxAccountPerEmailAddress = accountsPerEmailAddressThreshold + 1;
		List<IAccountEmail> currentAccountEmails = new List<IAccountEmail>();
		int currentAccountEmailsCount = 0;
		int? exclusiveStartId = null;
		do
		{
			currentAccountEmailsCount = currentAccountEmails.Count;
			int count = Math.Min(AccountsByEmailAddressPageSize, maxAccountPerEmailAddress - currentAccountEmailsCount);
			ICollection<IAccountEmail> page = _AccountEmailAddressFactory.GetCurrentEmailAccountsByEmailAddressIsVerified(Email, isVerified, count, exclusiveStartId);
			IAccountEmail lastItem = page?.LastOrDefault();
			if (page != null && lastItem != null)
			{
				currentAccountEmails.AddRange(page);
				exclusiveStartId = lastItem.Id;
				if (page.Count < count)
				{
					break;
				}
			}
		}
		while (currentAccountEmails.Count > currentAccountEmailsCount && currentAccountEmails.Count < maxAccountPerEmailAddress);
		return currentAccountEmails;
	}
}
