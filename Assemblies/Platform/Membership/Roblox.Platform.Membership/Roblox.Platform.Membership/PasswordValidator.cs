using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Passwords.Client;
using Roblox.Platform.Membership.Properties;

namespace Roblox.Platform.Membership;

internal class PasswordValidator
{
	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly IPasswordsClient _PasswordsClient;

	private static readonly HashSet<string> _DumbStringsToHaveInPasswords = new HashSet<string>
	{
		"roblox123", "password", "password1", "password12", "password123", "trustno1", "iloveyou", "princess", "abcd1234", "qwertyui",
		"qwerty", "football", "baseball", "michael", "jennifer", "michelle", "babygirl", "superman", "12345678", "123456789",
		"1234567890", "123123123", "69696969", "11111111", "22222222", "33333333", "44444444", "55555555", "66666666", "77777777",
		"88888888", "99999999", "00000000"
	};

	private const string _MemberPasswordRegexPattern = "^(?=.{8,}$).*";

	private const string _VipPasswordRegexPattern = "^((?=(.*\\d){2,})(?=(.*[a-zA-Z]){4,})(?=.*[~`!@#$%^&*()\\-_+=?{}\\[\\]\\\\|:;\"'<,>./]).{8,})$";

	private readonly ICollection<string> _ForbiddenPasswordHashes;

	internal readonly List<int> RoleSetIDs;

	private readonly PasswordRule _MemberRule;

	private readonly PasswordRule _VipRule;

	public PasswordValidator(ILogger logger, IPasswordsClient passwordsClient)
		: this(Settings.Default, logger, passwordsClient)
	{
	}

	internal PasswordValidator(ISettings settings, ILogger logger, IPasswordsClient passwordsClient)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_PasswordsClient = passwordsClient ?? throw new ArgumentNullException("passwordsClient");
		try
		{
			RoleSetIDs = new List<int>
			{
				RoleSet.Member.ID,
				RoleSet.TrustedContributor.ID,
				RoleSet.ContentCreator.ID,
				RoleSet.Developer.ID,
				RoleSet.Moderator.ID,
				RoleSet.SuperModerator.ID,
				RoleSet.CustomerService.ID,
				RoleSet.EconomyManager.ID,
				RoleSet.CommunityManager.ID,
				RoleSet.ModeratorManager.ID,
				RoleSet.SuperAdministrator.ID,
				RoleSet.CommunityRepresentative.ID
			};
		}
		catch
		{
		}
		_ForbiddenPasswordHashes = new HashSet<string>(Settings.Default.BadPasswordHashes.Split(','));
		string[] array = Settings.Default.BadPasswords.Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			string badPasswordHash = HashGenerator.GetSHA1(array[i]);
			_ForbiddenPasswordHashes.Add(badPasswordHash);
		}
		_MemberRule = new PasswordRule
		{
			Regex = new Regex("^(?=.{8,}$).*", RegexOptions.Compiled),
			Description = PasswordValidationResult.MemberPasswordError.ToDescription(),
			PasswordValidationResult = PasswordValidationResult.MemberPasswordError
		};
		_VipRule = new PasswordRule
		{
			Regex = new Regex("^((?=(.*\\d){2,})(?=(.*[a-zA-Z]){4,})(?=.*[~`!@#$%^&*()\\-_+=?{}\\[\\]\\\\|:;\"'<,>./]).{8,})$", RegexOptions.Compiled),
			Description = PasswordValidationResult.VipPasswordError.ToDescription(),
			PasswordValidationResult = PasswordValidationResult.VipPasswordError
		};
	}

	public bool CheckPasswordRulesAndPasswordIsNotCurrent(Account account, string password, out string errMessage)
	{
		return CheckPasswordRulesAndPasswordIsNotCurrent(account.Name, password, out errMessage);
	}

	public bool CheckPasswordRulesAndPasswordIsNotCurrent(IUser user, string password, out string errMessage)
	{
		return CheckPasswordRulesAndPasswordIsNotCurrent(user.Name, password, out errMessage);
	}

	private bool CheckPasswordRulesAndPasswordIsNotCurrent(string accountName, string password, out string errMessage)
	{
		IPasswordValidationResponse passwordValidationResponse = ValidatePasswordRules(accountName, password);
		errMessage = passwordValidationResponse.Result.ToDescription();
		bool num = passwordValidationResponse.Result == PasswordValidationResult.ValidPassword;
		bool sameAsCurrentPassword = ValidateAccountPassword(accountName, password);
		if (num)
		{
			return !sameAsCurrentPassword;
		}
		return false;
	}

	/// <summary>Validates password against common password rules</summary>
	/// <param name="accountName">An account name, must not be blank</param>
	/// <param name="password">A password to validate, must not be blank </param>
	/// <returns></returns>
	public IPasswordValidationResponse ValidatePasswordRules(string accountName, string password)
	{
		PasswordValidationResult r = ValidateInputs(accountName, password);
		if (r != 0)
		{
			return new PasswordValidationResponse(r);
		}
		r = CheckForbiddenPassword(password);
		if (r != 0)
		{
			return new PasswordValidationResponse(r);
		}
		r = CheckDumbStrings(password);
		if (r != 0)
		{
			return new PasswordValidationResponse(r);
		}
		PasswordRule rule = GetPasswordRule(accountName);
		if (!rule.Regex.Match(password).Success)
		{
			return new PasswordValidationResponse(rule.PasswordValidationResult);
		}
		return new PasswordValidationResponse(PasswordValidationResult.ValidPassword);
	}

	/// <summary>Validates the user name and password to be valid strings. </summary>
	private PasswordValidationResult ValidateInputs(string accountName, string password)
	{
		if (accountName == null)
		{
			return PasswordValidationResult.InvalidAccountError;
		}
		if (string.IsNullOrEmpty(password))
		{
			return PasswordValidationResult.NullOrEmptyPasswordForAccountError;
		}
		if (string.Equals(password, accountName, StringComparison.CurrentCultureIgnoreCase))
		{
			return PasswordValidationResult.PasswordUserNameSameError;
		}
		return PasswordValidationResult.ValidPassword;
	}

	/// <summary> Validates that the given password is not a forbidden password. </summary>
	private PasswordValidationResult CheckForbiddenPassword(string password)
	{
		string passwordHash = HashGenerator.GetSHA1(password);
		if (_ForbiddenPasswordHashes.Contains(passwordHash))
		{
			return PasswordValidationResult.ForbiddenPasswordError;
		}
		return PasswordValidationResult.ValidPassword;
	}

	/// <summary> Validates that the user name and password are not dumb strings </summary>
	private PasswordValidationResult CheckDumbStrings(string password)
	{
		string lowercasePassword = password.ToLower();
		foreach (string s in _DumbStringsToHaveInPasswords)
		{
			if (lowercasePassword.Equals(s))
			{
				return PasswordValidationResult.DumbStringsError;
			}
		}
		if (Regex.IsMatch(password, "^[\\s]*$"))
		{
			return PasswordValidationResult.DumbStringsError;
		}
		return PasswordValidationResult.ValidPassword;
	}

	/// <summary> Validates User Credentials against the repository</summary>
	/// <param name="accountName"></param>
	/// <param name="password"></param>
	/// <returns></returns>
	public bool ValidateAccountPassword(string accountName, string password)
	{
		Account account = Account.Get(accountName);
		if (account == null)
		{
			return false;
		}
		VerifyPasswordResult verified = _PasswordsClient.VerifyPassword(PasswordOwnerType.Account, account.ID, password);
		if (verified != VerifyPasswordResult.PasswordNeedsReset)
		{
			return verified == VerifyPasswordResult.ValidPasswordHash;
		}
		return true;
	}

	internal virtual bool IsAccountVIP(string accountName)
	{
		if (string.IsNullOrEmpty(accountName))
		{
			return false;
		}
		Account account = Account.Get(accountName);
		if (account != null && RoleSetIDs.Contains(account.GetHighestRoleSet().ID))
		{
			return account.GetHighestRoleSet().ID != RoleSet.Member.ID;
		}
		return false;
	}

	public PasswordRule GetPasswordRule(string accountName = null)
	{
		if (!IsAccountVIP(accountName))
		{
			return _MemberRule;
		}
		return _VipRule;
	}
}
