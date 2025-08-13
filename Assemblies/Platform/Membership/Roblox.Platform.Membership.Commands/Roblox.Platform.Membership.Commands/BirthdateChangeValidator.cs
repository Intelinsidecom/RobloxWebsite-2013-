using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Authentication;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Commands.Properties;

namespace Roblox.Platform.Membership.Commands;

internal class BirthdateChangeValidator : IBirthdateChangeValidator
{
	private readonly IBirthdateValidator _BirthdateValidator;

	private readonly IAgeChecker _AgeChecker;

	private readonly IAvailableAuthenticationMethodMonitor _AvailableAuthenticationMethodMonitor;

	private readonly ISettings _Settings;

	public BirthdateChangeValidator(IBirthdateValidator birthdateValidator, IAgeChecker ageChecker, IAvailableAuthenticationMethodMonitor availableAuthenticationMethodMonitor, ISettings settings)
	{
		_BirthdateValidator = birthdateValidator.AssignOrThrowIfNull("birthdateValidator");
		_AgeChecker = ageChecker.AssignOrThrowIfNull("ageChecker");
		_AvailableAuthenticationMethodMonitor = availableAuthenticationMethodMonitor.AssignOrThrowIfNull("availableAuthenticationMethodMonitor");
		_Settings = settings.AssignOrThrowIfNull("settings");
	}

	public bool Is13OrOverToUnder13Change(IUser user, DateTime nowDate, DateTime newBirthdate)
	{
		if (user.AgeBracket == AgeBracket.Age13OrOver)
		{
			return IsUnder13(nowDate, newBirthdate);
		}
		return false;
	}

	public void ValidateBirthdateChange(IUser user, DateTime nowDate, DateTime newBirthdate, bool checkAge = true)
	{
		if (user == null)
		{
			throw new PlatformArgumentException("user");
		}
		if (!_BirthdateValidator.IsBirthdateValid(nowDate, newBirthdate))
		{
			throw new InvalidBirthdateException(newBirthdate);
		}
		if (checkAge && user.Birthdate.HasValue && IsUnder13(nowDate, user.Birthdate.Value))
		{
			throw new UnauthorizedUserOperationException(user.Id);
		}
		if (Is13OrOverToUnder13Change(user, nowDate, newBirthdate))
		{
			if (!_Settings.AgeDownEnabled)
			{
				throw new UnauthorizedUserOperationException(user.Id);
			}
			if (CannotSocialDisconnect(user.AccountId))
			{
				throw new InsufficientAuthenticationMethodsException(user.Id);
			}
		}
	}

	private bool CannotSocialDisconnect(long accountId)
	{
		IEnumerable<AuthenticationMethod> availableAuthenticationMethods = _AvailableAuthenticationMethodMonitor.GetAvailableAuthenticationMethods(accountId);
		if (availableAuthenticationMethods.Count() == 1)
		{
			return availableAuthenticationMethods.Contains(AuthenticationMethod.Facebook);
		}
		return false;
	}

	private bool IsUnder13(DateTime nowDate, DateTime birthdate)
	{
		return _AgeChecker.GetNumberOfWholeYearsBetweenTwoDates(birthdate, nowDate) < 13;
	}
}
