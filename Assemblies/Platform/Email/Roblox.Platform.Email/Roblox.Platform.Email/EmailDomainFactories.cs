using System;
using System.Diagnostics.CodeAnalysis;
using DnsClient;
using Roblox.BriteVerify;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Entities;
using Roblox.Platform.Email.Properties;

namespace Roblox.Platform.Email;

/// <summary>
/// A class holding the factories for the Platform.Email domain.
/// </summary>
[ExcludeFromCodeCoverage]
public class EmailDomainFactories : DomainFactoriesBase
{
	internal virtual IEmailAddressEntityFactory EmailAddressEntityFactory { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.IEmailAddressFactory" />
	/// </summary>
	public virtual IEmailAddressFactory EmailAddressFactory { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.IEmailAddressValidator" />
	/// </summary>
	/// <value><see cref="T:Roblox.Platform.Email.IEmailAddressValidator" /></value>
	public virtual IEmailAddressValidator EmailAddressValidator { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.BriteVerify.IBriteVerifyClient" />
	/// </summary>
	/// <value><see cref="T:Roblox.BriteVerify.IBriteVerifyClient" /></value>
	public virtual IBriteVerifyClient BriteVerifyEmailVerifier { get; }

	/// <see cref="T:Roblox.Platform.Email.IEmailAddressDeleter" />
	public virtual IEmailAddressDeleter EmailDeleter { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.EmailDomainFactories" /> class.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="dnsLookupClient">The DNS lookup client.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public EmailDomainFactories(ILogger logger, ILookupClient dnsLookupClient)
	{
		NullCheckArguments(logger, dnsLookupClient);
		EmailAddressEntityFactory emailAddressEntityFactory = (EmailAddressEntityFactory)(EmailAddressEntityFactory = new EmailAddressEntityFactory());
		EmailAddressFactory = new EmailAddressFactory(this);
		EmailAddressValidator emailAddressValidator = new EmailAddressValidator(dnsLookupClient, Settings.Default, emailAddressEntityFactory);
		EmailAddressValidator = emailAddressValidator;
		BriteVerifyEmailVerifier = new BriteVerifyClient();
		EmailDeleter = new EmailAddressDeleter(emailAddressEntityFactory);
	}

	private static void NullCheckArguments(ILogger logger, ILookupClient dnsLookupClient)
	{
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		if (dnsLookupClient == null)
		{
			throw new ArgumentNullException("dnsLookupClient");
		}
	}

	internal EmailDomainFactories()
	{
	}
}
