using System.Diagnostics.CodeAnalysis;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;
using Roblox.Platform.Demographics.Entities.Audit;
using Roblox.Platform.Demographics.Properties;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Platform.TranslationStorage;

namespace Roblox.Platform.Demographics;

/// <summary>
/// A class holding the factories for the (Platform) Demographics domain.
/// </summary>
[ExcludeFromCodeCoverage]
public class DemographicsDomainFactories : DomainFactoriesBase
{
	internal virtual IPhoneNumberEntityFactory PhoneNumberEntityFactory { get; }

	internal virtual IPhoneNumberInternationalPrefixEntityFactory PhoneNumberInternationalPrefixEntityFactory { get; }

	internal virtual IAccountPhoneNumberEntityFactory AccountPhoneNumberEntityFactory { get; }

	internal virtual IAccountPhoneNumbersAuditEntryEntityFactory AccountPhoneNumbersAuditEntryEntityFactory { get; }

	internal virtual IAccountPhoneNumbersAuditMetadataEntityFactory AccountPhoneNumbersAuditMetadataEntityFactory { get; }

	/// <summary>
	/// Gets the phone number factory.
	/// </summary>
	/// <value>The phone number factory.</value>
	public IPhoneNumberFactory PhoneNumberFactory => PhoneNumberFactory_Internal;

	internal virtual IPhoneNumberFactory_Internal PhoneNumberFactory_Internal { get; }

	/// <summary>
	/// Gets the phone number international prefix factory.
	/// </summary>
	/// <value>The phone number international prefix factory.</value>
	public virtual IPhoneNumberInternationalPrefixFactory PhoneNumberInternationalPrefixFactory { get; }

	/// <summary>
	/// Gets the country factory.
	/// </summary>
	/// <value>The country factory.</value>
	public virtual ICountryFactory CountryFactory { get; }

	/// <summary>
	/// Gets the country converter.
	/// </summary>
	/// <value>The country converter.</value>
	public virtual ICountryConverter CountryConverter { get; }

	/// <summary>
	/// Gets the address factory.
	/// </summary>
	/// <value>The address factory.</value>
	public virtual IAddressFactory AddressFactory { get; }

	/// <summary>
	/// Gets the account phone number factory.
	/// </summary>
	/// <value>The account phone number factory.</value>
	public virtual IAccountPhoneNumberFactory AccountPhoneNumberFactory { get; }

	/// <summary>
	/// Gets a phone number validator.
	/// </summary>
	public virtual IPhoneNumberValidator PhoneNumberValidator { get; }

	/// <summary>
	/// Gets a account phone number owner factory.
	/// </summary>
	public virtual IAccountPhoneNumberOwnerFactory AccountPhoneNumberOwnerFactory { get; }

	/// <see cref="T:Roblox.Platform.Demographics.IGeolocationFactory" />
	public virtual IGeolocationFactory GeolocationFactory { get; }

	internal virtual IAccountPhoneNumberDisconnectorSettings AccountPhoneNumberDisconnectorSettings { get; }

	public DemographicsDomainFactories(IAccountSecurityTicketsFactory accountSecurityTicketsFactory, IEmailSender emailSender, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		AccountPhoneNumberDisconnectorSettings = Settings.Default;
		PhoneNumberEntityFactory = new PhoneNumberEntityFactory(this);
		PhoneNumberInternationalPrefixEntityFactory = new PhoneNumberInternationalPrefixEntityFactory(this);
		AccountPhoneNumberEntityFactory = new AccountPhoneNumberEntityFactory(this);
		AccountPhoneNumbersAuditEntryEntityFactory = new AccountPhoneNumbersAuditEntryEntityFactory(this);
		AccountPhoneNumbersAuditMetadataEntityFactory = new AccountPhoneNumbersAuditMetadataEntityFactory(this);
		PhoneNumberInternationalPrefixFactory = new PhoneNumberInternationalPrefixFactory(this);
		ICountryFactory countryFactory = (CountryFactory = new CountryFactory());
		CountryConverter = new CountryConverter();
		AddressFactory = new AddressFactory(countryFactory);
		PhoneNumberValidator = new PhoneNumberValidator(this);
		AccountPhoneNumberFactory = new AccountPhoneNumberFactory(this, accountSecurityTicketsFactory, emailSender, ephemeralCounterFactory);
		PhoneNumberFactory_Internal = new PhoneNumberFactory(this);
		AccountPhoneNumberOwnerFactory = new AccountPhoneNumberOwnerFactory(this);
		GeolocationFactory = new GeolocationFactory("DemographicsDomainFactories");
	}

	public virtual IAccountPhoneNumberAuditCompositeEntryFactory GetAccountPhoneNumberAuditCompositeEntryFactory(IUserFactory userFactory)
	{
		return new AccountPhoneNumberAuditCompositeEntryFactory(this, userFactory);
	}

	/// <summary>
	/// Get an <see cref="T:Roblox.Platform.Demographics.ILocalizedCountryProvider" />
	/// </summary>
	/// <param name="translationStorageAccessor">The <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" /> to access translations</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" /> to log exceptions</param>
	/// <returns>An <see cref="T:Roblox.Platform.Demographics.ILocalizedCountryProvider" /></returns>
	public virtual ILocalizedCountryProvider GetLocalizedCountryProvider(ITranslationStorageAccessor translationStorageAccessor, ILogger logger)
	{
		return new LocalizedCountryProvider(translationStorageAccessor, logger);
	}
}
