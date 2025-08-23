using System;
using System.Collections.Generic;
using System.Web;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.Random;
using Roblox.RequestContext;
using Roblox.Web.Code.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Code;

public class AccountLocaleInitializer : IAccountLocaleInitializer
{
	private const string _AcceptLanguageHeader = "Accept-Language";

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly ICoreLocalizationBuilder _CoreLocalizationBuilder;

	private readonly IAccountLocaleBuilder _AccountLocaleBuilder;

	private readonly IAccountLocaleAccessor _AccountLocaleAccessor;

	private readonly ILocalePermissionVerifier _LocalePermissionVerifier;

	private readonly IAccountLocaleInitializerSettings _Settings;

	private readonly IRequestContextLoader _RequestContextLoader;

	private readonly IAccountLocalesChangeAgentFactory _AccountLocalesChangeAgentFactory;

	private readonly IRandom _Random;

	private readonly ILogger _Logger;

	public AccountLocaleInitializer(ICoreLocalizationAccessor coreLocalizationAccessor, ICoreLocalizationBuilder coreLocalizationBuilder, IAccountLocaleBuilder accountLocaleBuilder, IAccountLocaleAccessor accountLocaleAccessor, IClientDeviceIdentifier clientDeviceIdentifier, IRoleSetValidator roleSetValidator, IRequestContextLoader requestContextLoader, ILogger logger)
		: this(coreLocalizationAccessor, coreLocalizationBuilder, accountLocaleBuilder, accountLocaleAccessor, new LocalePermissionVerifier(LocaleRolloutSettings.Default, new LocaleSettingsMapper(LocaleRolloutSettings.Default, UgcLocaleRolloutSettings.Default), clientDeviceIdentifier, roleSetValidator), Settings.Default, requestContextLoader, new AccountLocalesChangeAgentFactory(), new RandomFactory().GetDefaultRandom(), logger)
	{
	}

	internal AccountLocaleInitializer(ICoreLocalizationAccessor coreLocalizationAccessor, ICoreLocalizationBuilder coreLocalizationBuilder, IAccountLocaleBuilder accountLocaleBuilder, IAccountLocaleAccessor accountLocaleAccessor, ILocalePermissionVerifier localePermissionVerifier, IAccountLocaleInitializerSettings settings, IRequestContextLoader requestContextLoader, IAccountLocalesChangeAgentFactory accountLocalesChangeAgentFactory, IRandom random, ILogger logger)
	{
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new ArgumentNullException("coreLocalizationAccessor");
		_CoreLocalizationBuilder = coreLocalizationBuilder ?? throw new ArgumentNullException("coreLocalizationBuilder");
		_AccountLocaleBuilder = accountLocaleBuilder ?? throw new ArgumentNullException("accountLocaleBuilder");
		_AccountLocaleAccessor = accountLocaleAccessor ?? throw new ArgumentNullException("accountLocaleAccessor");
		_LocalePermissionVerifier = localePermissionVerifier ?? throw new ArgumentNullException("localePermissionVerifier");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_RequestContextLoader = requestContextLoader ?? throw new ArgumentNullException("requestContextLoader");
		_AccountLocalesChangeAgentFactory = accountLocalesChangeAgentFactory ?? throw new ArgumentNullException("accountLocalesChangeAgentFactory");
		_Random = random ?? throw new ArgumentNullException("random");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public AccountLocaleInitializerResponse SetOrCreateObservedLocaleForUser(IUser user, IAccountLocalesChangeAgent changeAgent)
	{
		if (user == null)
		{
			return AccountLocaleInitializerResponse.NullUser;
		}
		HttpRequestBase requestBase = GetRequestBaseInCurrentContext();
		IDeviceReportedLocaleIdentifier deviceReportedLocaleIdentifier = GetOrCreateDeviceReportedLocaleIdentifier(requestBase);
		if (_AccountLocaleAccessor.GetAccountLocale(user.AccountId) != null)
		{
			_AccountLocaleBuilder.SetObservedLocale(user.AccountId, deviceReportedLocaleIdentifier, changeAgent);
		}
		else
		{
			try
			{
				_AccountLocaleBuilder.CreateAccountLocale(user.AccountId, deviceReportedLocaleIdentifier, null, changeAgent);
			}
			catch (DuplicateKeyException)
			{
				_AccountLocaleBuilder.SetObservedLocale(user.AccountId, deviceReportedLocaleIdentifier, changeAgent);
			}
		}
		return AccountLocaleInitializerResponse.Success;
	}

	public AccountLocaleInitializerResponse SetOrCreateSupportedLocaleForUser(IUser user, SupportedLocaleEnum? supportedLocaleEnum, IAccountLocalesChangeAgent changeAgent)
	{
		if (user == null)
		{
			return AccountLocaleInitializerResponse.NullUser;
		}
		ISupportedLocale supportedLocale = null;
		SupportedLocaleEnum cjvSupportedLocaleEnum = SupportedLocaleEnum.zh_cjv;
		if (IsChinaJvUser())
		{
			if (supportedLocaleEnum != cjvSupportedLocaleEnum)
			{
				return AccountLocaleInitializerResponse.InvalidSupportedLocaleCode;
			}
			return AccountLocaleInitializerResponse.Success;
		}
		if (supportedLocaleEnum == cjvSupportedLocaleEnum)
		{
			return AccountLocaleInitializerResponse.InvalidSupportedLocaleCode;
		}
		if (!supportedLocaleEnum.HasValue)
		{
			if (!_LocalePermissionVerifier.IsResetOfSupportedLocaleAllowed())
			{
				return AccountLocaleInitializerResponse.InvalidSupportedLocaleCode;
			}
		}
		else
		{
			supportedLocale = _CoreLocalizationAccessor.GetSupportedLocaleBySupportedLocaleCode(supportedLocaleEnum.ToString());
			if (supportedLocale == null)
			{
				return AccountLocaleInitializerResponse.InvalidSupportedLocaleCode;
			}
		}
		HttpRequestBase requestBase = GetRequestBaseInCurrentContext();
		IDeviceReportedLocaleIdentifier deviceReportedLocaleIdentifier = GetOrCreateDeviceReportedLocaleIdentifier(requestBase);
		IAccountLocale accountLocale = _AccountLocaleAccessor.GetAccountLocale(user.AccountId);
		try
		{
			if (accountLocale != null)
			{
				_AccountLocaleBuilder.SetSupportedLocale(user.AccountId, supportedLocale, changeAgent);
			}
			else
			{
				try
				{
					_AccountLocaleBuilder.CreateAccountLocale(user.AccountId, deviceReportedLocaleIdentifier, supportedLocale, changeAgent);
				}
				catch (DuplicateKeyException)
				{
					_AccountLocaleBuilder.SetSupportedLocale(user.AccountId, supportedLocale, changeAgent);
				}
			}
		}
		catch (PlatformFloodedException)
		{
			return AccountLocaleInitializerResponse.FeatureThrottledForUser;
		}
		return AccountLocaleInitializerResponse.Success;
	}

	public IUserLocale GetOrCreateUserLocale(IUser user, bool returnsUgcLocale = false)
	{
		HttpRequestBase requestBase = GetRequestBaseInCurrentContext();
		ISupportedLocale defaultSupportedLocale = _CoreLocalizationAccessor.GetDefaultSupportedLocale();
		IDeviceReportedLocaleIdentifier deviceLocaleId = GetOrCreateDeviceReportedLocaleIdentifier(requestBase);
		bool isChinaJvUser = IsChinaJvUser();
		ISupportedLocale cjvSupportedLocale = null;
		if (isChinaJvUser)
		{
			cjvSupportedLocale = _CoreLocalizationAccessor.GetSupportedLocaleBySupportedLocaleCode(SupportedLocaleEnum.zh_cjv.ToString());
		}
		ISupportedLocale supportedLocale;
		if (user == null)
		{
			IDeviceReportedLocale deviceLocale = _CoreLocalizationAccessor.GetDeviceReportedLocale(deviceLocaleId);
			supportedLocale = ((isChinaJvUser && cjvSupportedLocale != null) ? cjvSupportedLocale : deviceLocale?.SupportedLocale);
			if (_LocalePermissionVerifier.IsUserLocaleEnabledForSignupAndLogin(supportedLocale, requestBase.UserAgent))
			{
				return new UserLocale(null, supportedLocale);
			}
		}
		else
		{
			IAccountLocale accountLocale = CreateOrGetAndUpdateAccountLocale(user, deviceLocaleId);
			supportedLocale = ((isChinaJvUser && cjvSupportedLocale != null) ? cjvSupportedLocale : accountLocale?.SupportedLocale);
			if (_LocalePermissionVerifier.IsUserLocaleEnabledForFullExperience(user, supportedLocale, requestBase.UserAgent))
			{
				return new UserLocale(user, supportedLocale);
			}
		}
		if (!returnsUgcLocale)
		{
			return new UserLocale(user, defaultSupportedLocale);
		}
		return GetLocaleForUgc(user, supportedLocale, defaultSupportedLocale);
	}

	public IReadOnlyCollection<ISupportedLocale> GetSupportedLocales(IUser user)
	{
		HttpRequestBase requestBase = GetRequestBaseInCurrentContext();
		bool isChinaJvUser = IsChinaJvUser();
		return _LocalePermissionVerifier.WhiteListSupportedLocalesForFullExperience(user, _CoreLocalizationAccessor.GetSupportedLocales(isChinaJvUser), requestBase.UserAgent);
	}

	public IReadOnlyCollection<ISupportedLocaleLocus> GetSupportedLocalesWithLocus(IUser user, bool isSortedByFullExperience = false)
	{
		HttpRequestBase requestBase = GetRequestBaseInCurrentContext();
		bool isChinaJvUser = IsChinaJvUser();
		return _LocalePermissionVerifier.ApplyLocusOnSupportedLocales(user, _CoreLocalizationAccessor.GetSupportedLocales(isChinaJvUser), requestBase.UserAgent, isSortedByFullExperience);
	}

	public ILocalizationLocusUserLocales GetLocalizationLocusUserSupportedLocales(IUser user)
	{
		bool isChinaJvUser = IsChinaJvUser();
		ISupportedLocale defaultSupportedLocale = _CoreLocalizationAccessor.GetDefaultSupportedLocale();
		HttpRequestBase requestBase = GetRequestBaseInCurrentContext();
		IDeviceReportedLocaleIdentifier deviceLocaleId = GetOrCreateDeviceReportedLocaleIdentifier(requestBase);
		ISupportedLocale cjvSupportedLocale = null;
		ISupportedLocale cjvUgcLocale = null;
		ISupportedLocale supportedLocale = null;
		if (isChinaJvUser)
		{
			cjvSupportedLocale = _CoreLocalizationAccessor.GetSupportedLocaleBySupportedLocaleCode(SupportedLocaleEnum.zh_cjv.ToString());
			cjvUgcLocale = _CoreLocalizationAccessor.GetSupportedLocaleBySupportedLocaleCode(SupportedLocaleEnum.zh_cn.ToString());
		}
		IAccountLocale accountLocale = CreateOrGetAndUpdateAccountLocale(user, deviceLocaleId);
		supportedLocale = ((!isChinaJvUser || cjvSupportedLocale == null) ? ((user != null) ? accountLocale?.SupportedLocale : _CoreLocalizationAccessor.GetDeviceReportedLocale(deviceLocaleId)?.SupportedLocale) : cjvSupportedLocale);
		IUserLocale localeForFullExperience = GetLocaleForFullExperience(user, supportedLocale, defaultSupportedLocale, requestBase);
		IUserLocale signupAndLoginLocale = GetLocaleForSignupAndLogin(user, supportedLocale, defaultSupportedLocale, requestBase);
		IUserLocale ugcLocale = GetLocaleForUgc(user, isChinaJvUser ? cjvUgcLocale : supportedLocale, defaultSupportedLocale);
		return new LocalizationLocusUserLocales(localeForFullExperience, signupAndLoginLocale, ugcLocale);
	}

	public ISupportedLocale GetSupportedLocaleBasedOnOverride(IUser user, SupportedLocaleEnum overrideLocale)
	{
		HttpRequestBase requestBase = GetRequestBaseInCurrentContext();
		ISupportedLocale defaultSupportedLocale = _CoreLocalizationAccessor.GetDefaultSupportedLocale();
		ISupportedLocale overrideSupportedLocale = _CoreLocalizationAccessor.GetSupportedLocaleBySupportedLocaleCode(overrideLocale.ToString());
		if (overrideSupportedLocale == null)
		{
			return defaultSupportedLocale;
		}
		if (user == null)
		{
			if (_LocalePermissionVerifier.IsUserLocaleEnabledForSignupAndLogin(overrideSupportedLocale, requestBase.UserAgent))
			{
				return overrideSupportedLocale;
			}
			return defaultSupportedLocale;
		}
		if (_LocalePermissionVerifier.IsUserLocaleEnabledForFullExperience(user, overrideSupportedLocale, requestBase.UserAgent))
		{
			return overrideSupportedLocale;
		}
		return defaultSupportedLocale;
	}

	internal virtual HttpRequestBase GetRequestBaseInCurrentContext()
	{
		return HttpContext.Current.Request.RequestContext.HttpContext.Request;
	}

	private bool IsChinaJvUser()
	{
		if (_Random.Next() % 100 < _Settings.AccessingRequestContextRolloutPercentage)
		{
			IRequestContext currentContext = _RequestContextLoader.GetCurrentContext();
			if (currentContext == null)
			{
				return false;
			}
			return currentContext.DistributorType == DistributorType.ChinaJointVenture;
		}
		return false;
	}

	private IDeviceReportedLocaleIdentifier GetOrCreateDeviceReportedLocaleIdentifier(HttpRequestBase requestBase)
	{
		string acceptLanguageHeaderValue = requestBase.Headers.Get("Accept-Language");
		return _CoreLocalizationBuilder.RecordDeviceReportedLocale(acceptLanguageHeaderValue);
	}

	private IUserLocale GetLocaleForSignupAndLogin(IUser user, ISupportedLocale supportedLocale, ISupportedLocale defaultSupportedLocale, HttpRequestBase requestBase)
	{
		if (_LocalePermissionVerifier.IsUserLocaleEnabledForSignupAndLogin(supportedLocale, requestBase.UserAgent))
		{
			return new UserLocale(user, supportedLocale);
		}
		return new UserLocale(user, defaultSupportedLocale);
	}

	private IUserLocale GetLocaleForUgc(IUser user, ISupportedLocale supportedLocale, ISupportedLocale defaultSupportedLocale)
	{
		if (supportedLocale != null)
		{
			return new UserLocale(user, supportedLocale);
		}
		return new UserLocale(user, defaultSupportedLocale);
	}

	private IUserLocale GetLocaleForFullExperience(IUser user, ISupportedLocale supportedLocale, ISupportedLocale defaultSupportedLocale, HttpRequestBase requestBase)
	{
		if (_LocalePermissionVerifier.IsUserLocaleEnabledForFullExperience(user, supportedLocale, requestBase.UserAgent))
		{
			return new UserLocale(user, supportedLocale);
		}
		return new UserLocale(user, defaultSupportedLocale);
	}

	private IAccountLocale CreateOrGetAndUpdateAccountLocale(IUser user, IDeviceReportedLocaleIdentifier deviceReportedLocale)
	{
		if (user == null)
		{
			return null;
		}
		IAccountLocale accountLocale;
		try
		{
			accountLocale = _AccountLocaleAccessor.GetAccountLocale(user.AccountId);
			if (accountLocale == null)
			{
				try
				{
					IAccountLocalesChangeAgent changeAgent2 = _AccountLocalesChangeAgentFactory.CreateChangeAgentForAutomation(AccountLocalesAutomationType.LocaleCreation);
					accountLocale = _AccountLocaleBuilder.CreateAccountLocale(user.AccountId, deviceReportedLocale, null, changeAgent2);
				}
				catch (DuplicateKeyException)
				{
					accountLocale = _AccountLocaleAccessor.GetAccountLocale(user.AccountId);
				}
			}
			else
			{
				IAccountLocalesChangeAgent changeAgent = _AccountLocalesChangeAgentFactory.CreateChangeAgentForAutomation(AccountLocalesAutomationType.DeviceLocaleUpdate);
				_AccountLocaleBuilder.SetObservedLocale(user.AccountId, deviceReportedLocale, changeAgent);
			}
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return null;
		}
		return accountLocale;
	}
}
