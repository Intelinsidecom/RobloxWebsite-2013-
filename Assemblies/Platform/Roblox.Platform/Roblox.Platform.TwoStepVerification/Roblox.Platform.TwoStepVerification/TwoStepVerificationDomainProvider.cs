using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching.Shared;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Email.User;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Entities;
using Roblox.Platform.TwoStepVerification.Entities.Audit;
using Roblox.Platform.TwoStepVerification.Properties;
using Roblox.Sms.Client;

namespace Roblox.Platform.TwoStepVerification;

[ExcludeFromCodeCoverage]
public class TwoStepVerificationDomainProvider : DomainFactoriesBase
{
	internal virtual ITwoStepVerificationSettingEntityFactory SettingEntityFactory { get; }

	internal virtual ITwoStepVerificationSettingsAuditEntryEntityFactory SettingsAuditEntryEntityFactory { get; }

	internal virtual ITwoSVSettingsAuditMetadataEntityFactory SettingsAuditMetadataEntityFactory { get; }

	internal virtual ITwoStepVerificationMediaTypeEntityFactory MediaTypeEntityFactory { get; }

	internal virtual ITwoStepVerificationChallengeFactory TwoStepVerificationChallengeFactory { get; }

	internal virtual ITwoStepVerificationCodeVendorFactory TwoStepVerificationCodeVendorFactory { get; }

	internal virtual ITwoStepVerificationMediaTypeFactory TwoStepVerificationMediaTypeFactory { get; }

	internal virtual ITwoStepVerificationSettingFactory TwoStepVerificationSettingFactory { get; }

	public virtual ITwoStepVerificationConfigurationProvider TwoStepVerificationConfigurationProvider { get; }

	public virtual ITwoStepVerificationSessionFactory TwoStepVerificationSessionFactory { get; }

	public virtual ITwoStepVerificationSessionPurger TwoStepVerificationSessionPurger { get; }

	public virtual ITwoStepVerificationCodeSender TwoStepVerificationCodeSender { get; }

	public virtual ITwoStepVerificationCodeValidator TwoStepVerificationCodeValidator { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationFloodCheckerFactory" />
	/// </summary>
	/// <value><see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationFloodCheckerFactory" /></value>
	public virtual ITwoStepVerificationFloodCheckerFactory TwoStepVerificationFloodCheckerFactory { get; }

	public TwoStepVerificationDomainProvider(IAccountPhoneNumberFactory accountPhoneNumberFactory, IRoleSetValidator roleSetValidator, ISharedCacheClient sharedCacheClient, ILogger logger, IEmailSender emailSender, ISmsClient smsClient, IAccountEmailAddressFactory accountEmailAddressFactory, IUserFactory userFactory, string applicationName, Func<IUserIdentifier> getActorIdentifierCallback, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ILocalizationResourceProvider localizationResourceProvider, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (accountPhoneNumberFactory == null)
		{
			throw new ArgumentNullException("accountPhoneNumberFactory");
		}
		if (roleSetValidator == null)
		{
			throw new ArgumentNullException("roleSetValidator");
		}
		if (sharedCacheClient == null)
		{
			throw new ArgumentNullException("sharedCacheClient");
		}
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		if (emailSender == null)
		{
			throw new ArgumentNullException("emailSender");
		}
		if (accountEmailAddressFactory == null)
		{
			throw new ArgumentNullException("accountEmailAddressFactory");
		}
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		if (string.IsNullOrEmpty(applicationName))
		{
			throw new ArgumentNullException("applicationName");
		}
		if (getActorIdentifierCallback == null)
		{
			throw new ArgumentNullException("getActorIdentifierCallback");
		}
		if (localizationResourceProvider == null)
		{
			throw new ArgumentNullException("localizationResourceProvider");
		}
		if (ephemeralCounterFactory == null)
		{
			throw new ArgumentNullException("ephemeralCounterFactory");
		}
		if (smsClient == null)
		{
			throw new ArgumentNullException("smsClient");
		}
		ITwoStepVerificationSettingEntityFactory settingEntityFactory = (SettingEntityFactory = new TwoStepVerificationSettingEntityFactory());
		SettingsAuditEntryEntityFactory = new TwoStepVerificationSettingsAuditEntryEntityFactory(this);
		SettingsAuditMetadataEntityFactory = new TwoSVSettingsAuditMetadataEntityFactory(this);
		MediaTypeEntityFactory = new TwoStepVerificationMediaTypeEntityFactory();
		ITwoStepVerificationMediaTypeFactory mediaTypeFactory = (TwoStepVerificationMediaTypeFactory = new TwoStepVerificationMediaTypeFactory(MediaTypeEntityFactory = new TwoStepVerificationMediaTypeEntityFactory()));
		TwoStepVerificationEmailNotifier emailNotifier = new TwoStepVerificationEmailNotifier(emailSender, accountEmailAddressFactory, CodeSendorEmailAddress);
		TwoStepVerificationCodeVendorViaEmail twoStepVerificationCodeVendorViaEmail = new TwoStepVerificationCodeVendorViaEmail(emailNotifier, logger, applicationName, IsTwoStepVerificationLoggingEnabled, localizationResourceProvider);
		TwoStepVerificationCodeVendorViaSms twoStepVerificationCodeVendorViaSms = new TwoStepVerificationCodeVendorViaSms(accountPhoneNumberFactory, smsClient, logger, applicationName, () => Settings.Default.IsTwoStepVerificationLoggingEnabled);
		ITwoStepVerificationCodeVendorFactory twoStepVerificationCodeVendorFactory = (TwoStepVerificationCodeVendorFactory = new TwoStepVerificationCodeVendorFactory(twoStepVerificationCodeVendorViaEmail, twoStepVerificationCodeVendorViaSms));
		ITwoStepVerificationSessionPurger twoStepVerificationSessionPurger = (TwoStepVerificationSessionPurger = new TwoStepVerificationSessionPurger((ITwoStepVerificationSessionCollectionFactory)(TwoStepVerificationSessionFactory = new TwoStepVerificationSessionFactory(userFactory))));
		TwoStepVerificationChallengePersister twoStepVerificationChallengePersister = new TwoStepVerificationChallengePersister(sharedCacheClient);
		ITwoStepVerificationChallengeFactory twoStepVerificationChallengeFactory = (TwoStepVerificationChallengeFactory = new TwoStepVerificationChallengeFactory(twoStepVerificationChallengePersister));
		ITwoStepVerificationSettingFactory twoStepVerificationSettingFactory = (TwoStepVerificationSettingFactory = new TwoStepVerificationSettingFactory(mediaTypeFactory, settingEntityFactory));
		TwoStepVerificationFloodCheckerFactory twoStepVerificationFloodCheckerFactory = new TwoStepVerificationFloodCheckerFactory(floodCheckerFactory, logger, Settings.Default);
		TwoStepVerificationFloodCheckerFactory = twoStepVerificationFloodCheckerFactory;
		TwoStepVerificationConfigurationProvider twoStepVerificationConfigurationProvider = (TwoStepVerificationConfigurationProvider)(TwoStepVerificationConfigurationProvider = new TwoStepVerificationConfigurationProvider(twoStepVerificationSettingFactory, twoStepVerificationSessionPurger, accountEmailAddressFactory, accountPhoneNumberFactory, roleSetValidator));
		TwoStepVerificationSettingChangeEmailNotifier twoStepVerificationSettingChangeEmailNotifier = new TwoStepVerificationSettingChangeEmailNotifier(emailNotifier, logger, applicationName, IsTwoStepVerificationLoggingEnabled, localizationResourceProvider);
		twoStepVerificationConfigurationProvider.OnTwoStepConfigurationChanged += twoStepVerificationSettingChangeEmailNotifier.Send;
		new TwoStepVerificationSettingChangeAuditor(this, logger, getActorIdentifierCallback).RegisterEvents(twoStepVerificationSettingFactory);
		TwoStepVerificationCodeSender = new TwoStepVerificationCodeSender(twoStepVerificationChallengeFactory, twoStepVerificationCodeVendorFactory, twoStepVerificationConfigurationProvider, userFactory, logger);
		TwoStepVerificationCodeValidator = new TwoStepVerificationCodeValidator(twoStepVerificationChallengeFactory, ephemeralCounterFactory, logger);
		static string CodeSendorEmailAddress()
		{
			return Settings.Default.TwoStepVerificationCodeSenderEmailAddress;
		}
		static bool IsTwoStepVerificationLoggingEnabled()
		{
			return Settings.Default.IsTwoStepVerificationLoggingEnabled;
		}
	}

	public virtual ITwoStepVerificationSettingsAuditCompositeEntryFactory GetSettingsAuditCompositeEntryFactory(IUserFactory userFactory)
	{
		return new TwoStepVerificationSettingsAuditCompositeEntryFactory(this, userFactory);
	}
}
