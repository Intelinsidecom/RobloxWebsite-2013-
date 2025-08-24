using System;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationConfigurationProvider" />
/// </summary>
internal class TwoStepVerificationConfigurationProvider : ITwoStepVerificationConfigurationProvider
{
	private readonly ITwoStepVerificationSettingFactory _TwoStepVerificationSettingFactory;

	private readonly ITwoStepVerificationSessionPurger _TwoStepVerificationSessionPurger;

	private readonly IAccountEmailAddressFactory _AccountEmailAddressFactory;

	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	private readonly IRoleSetValidator _RoleSetValidator;

	internal event Action<TwoStepEventArgs> OnTwoStepConfigurationChanged;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationConfigurationProvider" />
	/// </summary>
	/// <param name="settingFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSettingFactory" /></param>
	/// <param name="sessionPurger">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger" /></param>
	/// <param name="accountEmailAddressFactory">An <see cref="T:Roblox.Platform.Email.User.IAccountEmailAddressFactory" /></param>
	/// <param name="accountPhoneNumberFactory">An <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" /></param>
	/// <param name="roleSetValidator">An <see cref="T:Roblox.Platform.Membership.IRoleSetValidator" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="settingFactory" />, <paramref name="sessionPurger" />, <paramref name="accountEmailAddressFactory" />, <paramref name="accountPhoneNumberFactory" />, or <paramref name="roleSetValidator" /> is null.</exception>
	internal TwoStepVerificationConfigurationProvider(ITwoStepVerificationSettingFactory settingFactory, ITwoStepVerificationSessionPurger sessionPurger, IAccountEmailAddressFactory accountEmailAddressFactory, IAccountPhoneNumberFactory accountPhoneNumberFactory, IRoleSetValidator roleSetValidator)
	{
		_TwoStepVerificationSettingFactory = settingFactory.AssignOrThrowIfNull("settingFactory");
		_TwoStepVerificationSessionPurger = sessionPurger.AssignOrThrowIfNull("sessionPurger");
		_AccountEmailAddressFactory = accountEmailAddressFactory.AssignOrThrowIfNull("accountEmailAddressFactory");
		_AccountPhoneNumberFactory = accountPhoneNumberFactory.AssignOrThrowIfNull("accountPhoneNumberFactory");
		_RoleSetValidator = roleSetValidator.AssignOrThrowIfNull("roleSetValidator");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationConfigurationProvider.GetTwoStepSettingForUser(Roblox.Platform.Membership.IUser)" />
	public TwoStepVerificationSettingDTO GetTwoStepSettingForUser(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (_RoleSetValidator.IsPrivilegedUser(user))
		{
			return new TwoStepVerificationSettingDTO
			{
				UserIdentifier = user,
				IsEnabled = true,
				MediaType = TwoStepVerificationMediaType.Email
			};
		}
		TwoStepVerificationSettingDTO defaultSetting = new TwoStepVerificationSettingDTO
		{
			UserIdentifier = user,
			IsEnabled = false,
			MediaType = TwoStepVerificationMediaType.Email
		};
		IAccountEmail accountEmail = _AccountEmailAddressFactory.Get(user);
		if (string.IsNullOrWhiteSpace(accountEmail?.Email) || !accountEmail.IsVerified)
		{
			return defaultSetting;
		}
		ITwoStepVerificationSetting setting = _TwoStepVerificationSettingFactory.GetByUser(user);
		if (setting != null)
		{
			return setting.ToDTO();
		}
		return defaultSetting;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationConfigurationProvider.SetTwoStepSettingForUser(Roblox.Platform.Membership.IUser,System.Boolean,System.Nullable{Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType})" />
	public void SetTwoStepSettingForUser(IUser user, bool isEnabled, TwoStepVerificationMediaType? mediaType = null)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (_RoleSetValidator.IsPrivilegedUser(user) && !isEnabled)
		{
			throw new TwoStepVerificationSetNotAllowedException("User is privileged and may not turn off two step verification.");
		}
		IAccountEmail accountEmail = _AccountEmailAddressFactory.Get(user);
		if (accountEmail == null || (!accountEmail.IsVerified && isEnabled))
		{
			throw new TwoStepVerificationUnverifiedMediaTypeException(TwoStepVerificationMediaType.Email);
		}
		if (mediaType == TwoStepVerificationMediaType.SMS && isEnabled)
		{
			IAccountPhoneNumber accountPhoneNumber = _AccountPhoneNumberFactory.GetVerifiedForUser(user);
			if (accountPhoneNumber == null || !accountPhoneNumber.IsVerified)
			{
				throw new TwoStepVerificationUnverifiedMediaTypeException(TwoStepVerificationMediaType.SMS);
			}
		}
		ITwoStepVerificationSetting currentSavableSetting = _TwoStepVerificationSettingFactory.GetOrCreateByUser(user);
		bool mediaTypeChanged = mediaType.HasValue && currentSavableSetting.MediaType != mediaType.Value;
		bool isEnabledChanged = currentSavableSetting.IsEnabled != isEnabled;
		if (isEnabledChanged || mediaTypeChanged)
		{
			TwoStepEventArgs eventArgs = new TwoStepEventArgs
			{
				User = user,
				IsEnabledChanged = isEnabledChanged,
				IsEnabled = isEnabled,
				MediaTypeChanged = mediaTypeChanged
			};
			currentSavableSetting.IsEnabled = isEnabled;
			if (mediaType.HasValue)
			{
				currentSavableSetting.MediaType = mediaType.Value;
				eventArgs.MediaType = mediaType.Value;
			}
			currentSavableSetting.Save();
			this.OnTwoStepConfigurationChanged?.Invoke(eventArgs);
		}
		if (!isEnabled && isEnabledChanged)
		{
			_TwoStepVerificationSessionPurger.DeleteSessionsForUser(user);
		}
	}
}
