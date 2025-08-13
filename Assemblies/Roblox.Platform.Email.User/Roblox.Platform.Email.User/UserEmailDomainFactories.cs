using System;
using Roblox.BriteVerify;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Instrumentation;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Email.Properties;
using Roblox.Platform.Email.User.Entities;
using Roblox.Platform.EventStream;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

/// <summary>
/// A class holding the factories for the Platform.Email.User domain for user emails.
/// </summary>
public class UserEmailDomainFactories : DomainFactoriesBase
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.User.IAccountEmailAddressFactory" />
	/// </summary>
	/// <value><see cref="T:Roblox.Platform.Email.User.IAccountEmailAddressFactory" /></value>
	public virtual IAccountEmailAddressFactory AccountEmailAddressFactory { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.User.IUserEmailFloodCheckerFactory" />
	/// </summary>
	/// <value><see cref="T:Roblox.Platform.Email.User.IUserEmailFloodCheckerFactory" /></value>
	internal virtual IUserEmailFloodCheckerFactory UserEmailFloodCheckerFactory { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.User.IUserEmailChanger" />
	/// </summary>
	/// <value><see cref="T:Roblox.Platform.Email.User.IUserEmailChanger" /></value>
	public virtual IUserEmailChanger UserEmailChanger { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.User.IUserEmailVerifier" />
	/// </summary>
	/// <value><see cref="T:Roblox.Platform.Email.User.IUserEmailVerifier" /></value>
	public virtual IUserEmailVerifier UserEmailVerifier { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.IEmailAddressFactory" /> class.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public UserEmailDomainFactories(ICounterRegistry counterRegistry, ILogger logger, IEmailAddressFactory emailAddressFactory, IEmailAddressValidator emailAddressValidator, IEmailSender emailSender, IBriteVerifyClient briteVerifyEmailVerifier, IUserFactory userFactory, IEphemeralCounterFactory ephemeralCounterFactory, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, IAccountSecurityTicketsFactory accountSecurityTicketsFactory, IEventStreamer eventStreamer, IAssetOwnershipAuthority assetOwnershipAuthority, ILocalizationResourceProvider localizationResourceProvider, IEmailAddressDeleter emailDeleter)
	{
		NullCheckConstructorArguments(counterRegistry, logger, emailAddressFactory, emailAddressValidator, emailSender, briteVerifyEmailVerifier, userFactory, ephemeralCounterFactory, floodCheckerFactory, accountSecurityTicketsFactory, eventStreamer, assetOwnershipAuthority, localizationResourceProvider);
		AccountEmailAddressEntityFactory accountEmailAddressEntityFactory = new AccountEmailAddressEntityFactory();
		UserEmailVerifier = new UserEmailVerifier(userEmailChanger: UserEmailChanger = new UserEmailChanger(counterRegistry, emailAddressFactory, AccountEmailAddressFactory = new AccountEmailAddressFactory(emailAddressFactory, accountEmailAddressEntityFactory), emailAddressValidator, ephemeralCounterFactory, accountSecurityTicketsFactory, emailSender, briteVerifyEmailVerifier, accountEmailAddressEntityFactory, emailDeleter, localizationResourceProvider), emailSender: emailSender, emailAddressValidator: emailAddressValidator, userEmailFloodCheckerFactory: UserEmailFloodCheckerFactory = new UserEmailFloodCheckerFactory(floodCheckerFactory, logger, Settings.Default), userFactory: userFactory, ephemeralCounterFactory: ephemeralCounterFactory, assetOwnershipAuthority: assetOwnershipAuthority, eventStreamer: eventStreamer, localizationResourceProvider: localizationResourceProvider);
	}

	private void NullCheckConstructorArguments(ICounterRegistry counterRegistry, ILogger logger, IEmailAddressFactory emailAddressFactory, IEmailAddressValidator emailAddressValidator, IEmailSender emailSender, IBriteVerifyClient briteVerifyEmailVerifier, IUserFactory userFactory, IEphemeralCounterFactory ephemeralCounterFactory, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, IAccountSecurityTicketsFactory accountSecurityTicketsFactory, IEventStreamer eventStreamer, IAssetOwnershipAuthority assetOwnershipAuthority, ILocalizationResourceProvider localizationResourceProvider)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		if (emailAddressFactory == null)
		{
			throw new ArgumentNullException("emailAddressFactory");
		}
		if (emailAddressValidator == null)
		{
			throw new ArgumentNullException("emailAddressValidator");
		}
		if (emailSender == null)
		{
			throw new ArgumentNullException("emailSender");
		}
		if (briteVerifyEmailVerifier == null)
		{
			throw new ArgumentNullException("briteVerifyEmailVerifier");
		}
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		if (ephemeralCounterFactory == null)
		{
			throw new ArgumentNullException("ephemeralCounterFactory");
		}
		if (floodCheckerFactory == null)
		{
			throw new ArgumentNullException("floodCheckerFactory");
		}
		if (accountSecurityTicketsFactory == null)
		{
			throw new ArgumentNullException("accountSecurityTicketsFactory");
		}
		if (eventStreamer == null)
		{
			throw new ArgumentNullException("eventStreamer");
		}
		if (assetOwnershipAuthority == null)
		{
			throw new ArgumentNullException("assetOwnershipAuthority");
		}
		if (localizationResourceProvider == null)
		{
			throw new ArgumentNullException("localizationResourceProvider");
		}
	}
}
