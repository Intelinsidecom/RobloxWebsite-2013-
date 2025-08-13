using System;
using Roblox.EventLog;
using Roblox.Platform.Authentication;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Audit;
using Roblox.Platform.Membership.Commands.Audit;
using Roblox.Platform.Membership.Commands.Properties;
using Roblox.Platform.Membership.Entities;
using Roblox.Platform.Membership.Events;
using Roblox.Properties;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Domain factories for Roblox.Platform.Membership.Commands
/// </summary>
public class MembershipCommandsDomainFactories : DomainFactoriesBase
{
	internal virtual ILogger Logger { get; }

	internal virtual ITextFilterClient TextFilterClient { get; }

	internal virtual IUserEntityFactory UserEntityFactory { get; }

	internal virtual IServerClassLibrarySettings ServerClassLibrarySettings => Roblox.Properties.Settings.Default;

	internal virtual IUsersAuditEntryEntityFactory UsersAuditEntryEntityFactory { get; }

	internal virtual IUsersAuditEntriesMetaDataEntityFactory UsersAuditEntriesMetaDataEntityFactory { get; }

	internal virtual IUsersAuditCompositeEntryFactory UsersAuditCompositeEntryFactory { get; }

	internal virtual IAccountsAuditEntryEntityFactory AccountsAuditEntryEntityFactory { get; }

	internal virtual IAccountsAuditMetadataEntityFactory AccountsAuditMetadataEntityFactory { get; }

	internal virtual IUserFactory UserFactory { get; }

	internal virtual IAccountAgeChangeEventPublisher AccountAgeChangeEventPublisher { get; }

	internal virtual IAgeChecker AgeChecker { get; }

	internal virtual Func<DateTime> Now { get; }

	/// <summary>
	/// Provides an IBirthdateValidator
	/// </summary>
	public virtual IBirthdateValidator BirthdateValidator { get; }

	/// <summary>
	/// Provides an IBirthdateChangeValidator
	/// </summary>
	public virtual IBirthdateChangeValidator BirthdateChangeValidator { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Membership.Commands.IAccountsAuditFactory" />.
	/// </summary>
	public virtual IAccountsAuditFactory AccountsAuditFactory { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Membership.Commands.Properties.ISettings" />.
	/// </summary>
	public virtual ISettings Settings { get; }

	public virtual IAccountEntityFactory AccountEntityFactory { get; }

	public virtual IAccountNameHistoryEntityFactory AccountNameHistoryEntityFactory { get; }

	/// <summary> 
	/// Constructs the domain factories for Roblox.Platform.Membership.Commands
	/// </summary>
	/// <param name="membershipDomainFactories">The <see cref="T:Roblox.Platform.Membership.MembershipDomainFactories" />.</param>
	/// <param name="textFilterClient">The <see cref="P:Roblox.Platform.Membership.Commands.MembershipCommandsDomainFactories.TextFilterClient" />.</param>
	/// <param name="logger">The <see cref="P:Roblox.Platform.Membership.Commands.MembershipCommandsDomainFactories.Logger" />.</param>
	/// <param name="availableAuthenticationMethodMonitor">The <see cref="T:Roblox.Platform.Authentication.AvailableAuthenticationMethodMonitor" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Throws when membershipDomainFactories is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Throws when textFilter, textFilterV2, logger, availableAuthenticationMethodMonitor, or nowGetter is null.</exception>
	public MembershipCommandsDomainFactories(MembershipDomainFactories membershipDomainFactories, ITextFilterClient textFilterClient, ILogger logger, IAvailableAuthenticationMethodMonitor availableAuthenticationMethodMonitor, Func<DateTime> nowGetter)
	{
		if (membershipDomainFactories == null)
		{
			throw new ArgumentNullException("membershipDomainFactories");
		}
		if (availableAuthenticationMethodMonitor == null)
		{
			throw new ArgumentNullException("availableAuthenticationMethodMonitor");
		}
		Now = nowGetter ?? throw new ArgumentNullException("nowGetter");
		TextFilterClient = textFilterClient ?? throw new ArgumentNullException("textFilterClient");
		Logger = logger ?? throw new ArgumentNullException("logger");
		Settings = Roblox.Platform.Membership.Commands.Properties.Settings.Default;
		UserEntityFactory = membershipDomainFactories.UserEntityFactory;
		AccountEntityFactory = membershipDomainFactories.AccountEntityFactory;
		AccountAgeChangeEventPublisher = membershipDomainFactories.AccountAgeChangeEventPublisher;
		IUserFactory userFactory = (UserFactory = membershipDomainFactories.UserFactory);
		AccountNameHistoryEntityFactory = membershipDomainFactories.AccountNameHistoryEntityFactory;
		IAgeChecker ageChecker = (AgeChecker = membershipDomainFactories.AgeChecker);
		IUsersAuditEntryEntityFactory usersAuditEntryEntityFactory = (UsersAuditEntryEntityFactory = new UsersAuditEntryEntityFactory());
		IUsersAuditEntriesMetaDataEntityFactory usersAuditEntriesMetaDataEntityFactory = (UsersAuditEntriesMetaDataEntityFactory = new UsersAuditEntriesMetaDataEntityFactory());
		IAccountsAuditEntryEntityFactory accountsAuditEntryEntityFactory = (AccountsAuditEntryEntityFactory = new AccountsAuditEntryEntityFactory());
		IAccountsAuditMetadataEntityFactory accountsAuditMetadataEntityFactory = (AccountsAuditMetadataEntityFactory = new AccountsAuditMetadataEntityFactory());
		UsersAuditCompositeEntryFactory = new UsersAuditCompositeEntryFactory(userFactory, usersAuditEntriesMetaDataEntityFactory, usersAuditEntryEntityFactory);
		BirthdateChangeValidator = new BirthdateChangeValidator(BirthdateValidator = new BirthdateValidator(), ageChecker, availableAuthenticationMethodMonitor, Settings);
		AccountsAuditFactory = new AccountsAuditFactory(accountsAuditMetadataEntityFactory, accountsAuditEntryEntityFactory, userFactory);
	}

	protected MembershipCommandsDomainFactories()
	{
	}
}
