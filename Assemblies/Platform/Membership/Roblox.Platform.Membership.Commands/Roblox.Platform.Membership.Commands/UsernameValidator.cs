using System;
using System.Linq;
using System.Text.RegularExpressions;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Entities;
using Roblox.Platform.Membership.Properties;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidator" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Membership.Commands.IUsernameValidator" />
public class UsernameValidator : IUsernameValidator
{
	internal const string ValidUsernamePattern = "^[a-zA-Z0-9_ ]*$";

	private readonly ILogger _Logger;

	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly IUserFactory _UserFactory;

	private readonly IAccountNameHistoryEntityFactory _AccountNameHistoryEntityFactory;

	private readonly IAccountEntityFactory _AccountEntityFactory;

	private readonly Regex _ValidUsernameRegex;

	internal virtual int MaxAllowedUsernameLength => Settings.Default.MaxAllowedUsernameLength;

	internal virtual int MinAllowedUsernameLength => Settings.Default.MinAllowedUsernameLength;

	internal virtual bool IsCheckAccountsForUsernameEnabled => Settings.Default.IsCheckAccountsForUsernameEnabled;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Membership.Commands.UsernameValidator" /> class.
	/// </summary>
	/// <param name="textFilterClientV2">The <see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="accountNameHistoryEntityFactory">The <see cref="T:Roblox.Platform.Membership.Entities.IAccountNameHistoryEntityFactory" />.</param>
	/// <param name="accountEntityFactory">The <see cref="T:Roblox.Platform.Membership.Entities.IAccountEntityFactory" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">membershipDomainFactories
	/// or
	/// textFilter
	/// or
	/// logger</exception>
	public UsernameValidator(ITextFilterClientV2 textFilterClientV2, ILogger logger, IUserFactory userFactory, IAccountNameHistoryEntityFactory accountNameHistoryEntityFactory, IAccountEntityFactory accountEntityFactory)
	{
		_TextFilterClientV2 = textFilterClientV2 ?? throw new PlatformArgumentNullException("textFilterClientV2");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		_AccountNameHistoryEntityFactory = accountNameHistoryEntityFactory ?? throw new PlatformArgumentNullException("accountNameHistoryEntityFactory");
		_AccountEntityFactory = accountEntityFactory ?? throw new PlatformArgumentNullException("accountEntityFactory");
		_ValidUsernameRegex = new Regex("^[a-zA-Z0-9_ ]*$", RegexOptions.Compiled);
	}

	public IUsernameValidationResult ValidateUsername(string username, AgeBracket ageBracket, bool mustUsePiiFiltersForU13Usernames, bool canBypassReservedUsername = false)
	{
		UsernameLegalityCheckResult usernameLegality = CheckUsernameLegality(username);
		if (!usernameLegality.IsLegal)
		{
			return new UsernameValidationResult(isValid: false, usernameLegality.ValidatorErrorCode.Value);
		}
		UsernameTextFilterCheckResult usernameTextFilterResult = CheckWithTextFilterService(username, ageBracket, mustUsePiiFiltersForU13Usernames, canBypassReservedUsername);
		if (!usernameTextFilterResult.IsClean)
		{
			return new UsernameValidationResult(isValid: false, usernameTextFilterResult.ValidatorErrorCode.Value);
		}
		if (!IsUsernameAvailable(username, null))
		{
			return new UsernameValidationResult(isValid: false, UsernameValidatorResultCode.UserNameAlreadyInUseErrorCode);
		}
		return ValidationSuccessResult();
	}

	public IUsernameValidationResult ValidateUsername(string username, IUser user, bool mustUsePiiFiltersForU13Usernames)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		UsernameLegalityCheckResult usernameLegality = CheckUsernameLegality(username);
		if (!usernameLegality.IsLegal)
		{
			return new UsernameValidationResult(isValid: false, usernameLegality.ValidatorErrorCode.Value);
		}
		UsernameTextFilterCheckResult usernameTextFilterResult = CheckWithTextFilterService(username, user.AgeBracket, mustUsePiiFiltersForU13Usernames, canBypassReservedUsername: false, user);
		if (!usernameTextFilterResult.IsClean)
		{
			return new UsernameValidationResult(isValid: false, usernameTextFilterResult.ValidatorErrorCode.Value);
		}
		if (!IsUsernameAvailable(username, user))
		{
			return new UsernameValidationResult(isValid: false, UsernameValidatorResultCode.UserNameAlreadyInUseErrorCode);
		}
		return ValidationSuccessResult();
	}

	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidationResult" /> if the username does not satisify the fixed rules on name requirements.
	/// Returns null if the username passed the legality check with no issues.
	/// </summary>
	public IUsernameValidationResult IsUserNameLegal(string username)
	{
		UsernameLegalityCheckResult usernameLegality = CheckUsernameLegality(username);
		if (!usernameLegality.IsLegal)
		{
			return new UsernameValidationResult(isValid: false, usernameLegality.ValidatorErrorCode.Value);
		}
		return ValidationSuccessResult();
	}

	internal virtual UsernameLegalityCheckResult CheckUsernameLegality(string username)
	{
		if (username == null || username.Length < MinAllowedUsernameLength || username.Length > MaxAllowedUsernameLength)
		{
			return new UsernameLegalityCheckResult(UsernameValidatorResultCode.UserNameLengthErrorCode);
		}
		if (username.TrimStart().StartsWith("_") || username.TrimEnd().EndsWith("_"))
		{
			return new UsernameLegalityCheckResult(UsernameValidatorResultCode.UserNameStartEndUnderscoreErrorCode);
		}
		if (username.IndexesOf('_').Length > 1)
		{
			return new UsernameLegalityCheckResult(UsernameValidatorResultCode.UserNameAtMostUnderscoreErrorCode);
		}
		if (!_ValidUsernameRegex.Match(username).Success || username != username.Trim())
		{
			return new UsernameLegalityCheckResult(UsernameValidatorResultCode.UserNameAllowedCharErrorCode);
		}
		if (username.Contains(' '))
		{
			return new UsernameLegalityCheckResult(UsernameValidatorResultCode.UserNameNoSpaceErrorCode);
		}
		return new UsernameLegalityCheckResult(isLegal: true);
	}

	/// <summary> Checks the given username against the Text Filter Service </summary>
	/// <returns> Returns an <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidationResult" /> if the username is invalid or there is otherwise an issue communicating with the text filter.
	/// Returns null if the username passed the text filter with no issues.
	/// </returns>
	internal virtual UsernameTextFilterCheckResult CheckWithTextFilterService(string username, AgeBracket ageBracket, bool mustUsePiiFiltersForU13Usernames, bool canBypassReservedUsername, IUser user = null)
	{
		bool under13 = mustUsePiiFiltersForU13Usernames && ageBracket == AgeBracket.AgeUnder13;
		try
		{
			FilterUsernameResult evaluatorResult = _TextFilterClientV2.FilterUsername(username, new TextAuthor
			{
				Id = (user?.Id ?? 0),
				IsUnder13 = under13,
				Name = (user?.Name ?? string.Empty)
			}, canBypassReservedUsername);
			if (!evaluatorResult.IsValid)
			{
				if (evaluatorResult.TriggeredModerationCategories.Contains(4))
				{
					return new UsernameTextFilterCheckResult(UsernameValidatorResultCode.UsernameContainsPii);
				}
				if (evaluatorResult.TriggeredModerationCategories.Contains(21))
				{
					return new UsernameTextFilterCheckResult(UsernameValidatorResultCode.UsernameContainsReservedUsername);
				}
				return new UsernameTextFilterCheckResult(UsernameValidatorResultCode.UserNameModerationErrorCode);
			}
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return new UsernameTextFilterCheckResult(UsernameValidatorResultCode.UnknownErrorCode);
		}
		return new UsernameTextFilterCheckResult(isClean: true);
	}

	public virtual bool IsUsernameAvailable(string username, IUser user)
	{
		if (user != null && user.Name.Equals(username, StringComparison.OrdinalIgnoreCase) && !user.Name.Equals(username, StringComparison.Ordinal))
		{
			return true;
		}
		if (IsCheckAccountsForUsernameEnabled)
		{
			if (_AccountEntityFactory.GetAccount(username) != null)
			{
				return false;
			}
		}
		else if (_UserFactory.GetUserByName(username) != null)
		{
			return false;
		}
		if (!_AccountNameHistoryEntityFactory.IsUsernameTaken(username))
		{
			return true;
		}
		if (user != null)
		{
			return DoesNameHistoryForUserContainUsername(username, user);
		}
		return false;
	}

	internal virtual bool DoesNameHistoryForUserContainUsername(string username, IUser user)
	{
		return user.GetNameHistory().ToList().ConvertAll((string name) => name.ToLower())
			.Contains(username.ToLower());
	}

	private IUsernameValidationResult ValidationSuccessResult()
	{
		return new UsernameValidationResult(isValid: true, UsernameValidatorResultCode.UserNameValid);
	}
}
