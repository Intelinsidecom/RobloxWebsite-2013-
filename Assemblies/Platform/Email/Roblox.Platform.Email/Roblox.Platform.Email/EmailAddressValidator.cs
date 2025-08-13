using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using DnsClient;
using DnsClient.Protocol;
using Roblox.Configuration;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Entities;
using Roblox.Platform.Email.Properties;

namespace Roblox.Platform.Email;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Email.IEmailAddressValidator" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Email.IEmailAddressValidator" />
internal class EmailAddressValidator : IEmailAddressValidator
{
	private readonly IEmailAddressEntityFactory _EmailAddressEntityFactory;

	private readonly ISettings _Settings;

	private readonly ILookupClient _DnsLookupClient;

	internal HashSet<string> ShadyProviderDomains;

	private bool IsShadyEmailProviderCheckEnabled => _Settings.IsEmailValidationShadyEmailProviderCheckEnabled;

	private bool IsIgnorePeriodsInBlacklistCheckEnabled => _Settings.IsEmailValidationIgnorePeriodsInBlacklistCheckEnabled;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.EmailAddressValidator" /> class.
	/// </summary>
	internal EmailAddressValidator(ILookupClient dnsLookupClient, ISettings settings, IEmailAddressEntityFactory emailAddressEntityFactory)
	{
		_DnsLookupClient = dnsLookupClient ?? throw new PlatformArgumentNullException("dnsLookupClient");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_EmailAddressEntityFactory = emailAddressEntityFactory ?? throw new PlatformArgumentNullException("emailAddressEntityFactory");
		SettingsReadValueAndMonitorChanges();
	}

	private void SettingsReadValueAndMonitorChanges()
	{
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.EmailValidationShadyEmailProvidersCsv, delegate(string value)
		{
			string[] array = (from d in MultiValueSettingParser.ParseCommaDelimitedListString(value)
				select d.ToLower()).ToArray();
			ShadyProviderDomains = (array.Any() ? new HashSet<string>(array) : new HashSet<string>());
		});
	}

	/// <inheritdoc cref="M:Roblox.Platform.Email.IEmailAddressValidator.GetEmailRegex" />
	public string GetEmailRegex()
	{
		return _Settings.ValidEmailRegex;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Email.IEmailAddressValidator.IsValidEmail(System.String)" />
	public bool IsValidEmail(string emailAddress)
	{
		if (emailAddress == null)
		{
			throw new PlatformArgumentNullException("emailAddress");
		}
		if (emailAddress.Trim() == string.Empty)
		{
			return false;
		}
		return Regex.IsMatch(emailAddress, GetEmailRegex());
	}

	/// <inheritdoc cref="M:Roblox.Platform.Email.IEmailAddressValidator.IsShadyProvider(System.String)" />
	public bool IsShadyProvider(string emailAddress)
	{
		if (emailAddress == null)
		{
			throw new PlatformArgumentNullException("emailAddress");
		}
		if (!IsShadyEmailProviderCheckEnabled)
		{
			return false;
		}
		if (emailAddress.Trim() == string.Empty)
		{
			return false;
		}
		string domain = emailAddress.Split('@').Last();
		if (!string.IsNullOrWhiteSpace(domain))
		{
			return ShadyProviderDomains.Contains(domain.ToLower());
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Email.IEmailAddressValidator.IsBlacklisted(System.String)" />
	public bool IsBlacklisted(string emailAddress)
	{
		if (string.IsNullOrEmpty(emailAddress))
		{
			throw new PlatformArgumentNullException("emailAddress");
		}
		IEmailAddressEntity email = _EmailAddressEntityFactory.GetByEmailAddress(emailAddress);
		if (!IsIgnorePeriodsInBlacklistCheckEnabled)
		{
			return email?.IsBlacklisted ?? false;
		}
		string emailWithoutPeriods = IgnorePeriods(emailAddress);
		IEmailAddressEntity emailAddressWithoutPeriods = _EmailAddressEntityFactory.GetByEmailAddress(emailWithoutPeriods);
		if (email == null || !email.IsBlacklisted)
		{
			return emailAddressWithoutPeriods?.IsBlacklisted ?? false;
		}
		return true;
	}

	/// <summary>
	/// Ignore periods in email address to match Gmail's standard. 
	/// </summary>
	/// <param name="email">The string of email address</param>
	/// <returns>An email address that has no dot</returns>
	internal string IgnorePeriods(string email)
	{
		if (email == null)
		{
			return null;
		}
		string[] tokens = email.Split('@');
		for (int i = 0; i < tokens.Length - 1; i++)
		{
			tokens[i] = tokens[i].Replace(".", string.Empty);
		}
		return string.Join("@", tokens);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Email.IEmailAddressValidator.IsEmailDomainValid(System.String)" />
	public bool IsEmailDomainValid(string emailAddress)
	{
		if (string.IsNullOrEmpty(emailAddress))
		{
			throw new PlatformArgumentNullException("emailAddress");
		}
		if (!_Settings.IsEmailDomainValidationEnabled)
		{
			return true;
		}
		string host;
		try
		{
			host = new MailAddress(emailAddress).Host;
		}
		catch (FormatException)
		{
			return false;
		}
		IDnsQueryResponse dnsQuery = _DnsLookupClient.Query(host, QueryType.MX);
		if (dnsQuery?.Answers == null || dnsQuery.Answers.Count == 0)
		{
			return false;
		}
		if (dnsQuery.Answers.Count == 1)
		{
			MxRecord mxEntry = dnsQuery.Answers.MxRecords().First();
			return mxEntry.Preference != 0 || (!string.IsNullOrWhiteSpace(mxEntry.Exchange.Value) && !mxEntry.Exchange.Value.Equals("."));
		}
		return true;
	}
}
