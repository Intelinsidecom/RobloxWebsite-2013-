using Roblox.Common;
using Roblox.EventLog;

namespace Roblox.Platform.Membership;

/// <remarks>
/// This is not how factories work... This seems like mostly a proxy class.
/// Consider deprecating in favor of directly using PasswordValidator.
/// </remarks>
public class PasswordValidatorFactory : IPasswordValidatorFactory
{
	private readonly PasswordValidator _PasswordValidator;

	public PasswordValidatorFactory()
	{
		_PasswordValidator = new PasswordValidator(StaticLoggerRegistry.Instance, AccountPasswordHash.PasswordsClient);
	}

	public bool CheckPasswordRulesAndPasswordIsNotCurrent(Account account, string password, out string errorMessage)
	{
		return _PasswordValidator.CheckPasswordRulesAndPasswordIsNotCurrent(account, password, out errorMessage);
	}

	public bool CheckPasswordRulesAndPasswordIsNotCurrent(IUser user, string password, out string errorMessage)
	{
		return _PasswordValidator.CheckPasswordRulesAndPasswordIsNotCurrent(user, password, out errorMessage);
	}

	public bool CheckPasswordRules(string accountName, string password)
	{
		return _PasswordValidator.ValidatePasswordRules(accountName, password).Result == PasswordValidationResult.ValidPassword;
	}

	public bool CheckPasswordRules(string accountName, string password, out string errorMessage)
	{
		IPasswordValidationResponse passwordValidationResponse = _PasswordValidator.ValidatePasswordRules(accountName, password);
		errorMessage = passwordValidationResponse.Result.ToDescription();
		return passwordValidationResponse.Result == PasswordValidationResult.ValidPassword;
	}

	public bool ValidateAccountPassword(string accountName, string password)
	{
		return _PasswordValidator.ValidateAccountPassword(accountName, password);
	}

	public PasswordRule GetPasswordRuleByAccount(Account account)
	{
		string accountName = account?.Name;
		return _PasswordValidator.GetPasswordRule(accountName);
	}

	public PasswordRule GetPasswordRule(string accountName = null)
	{
		return _PasswordValidator.GetPasswordRule(accountName);
	}

	public IPasswordValidationResponse ValidatePasswordRules(string accountName, string password)
	{
		return _PasswordValidator.ValidatePasswordRules(accountName, password);
	}
}
