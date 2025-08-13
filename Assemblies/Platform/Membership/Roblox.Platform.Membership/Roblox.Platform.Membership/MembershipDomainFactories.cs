using System;
using Roblox.Agents;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Entities;
using Roblox.Platform.Membership.Events;
using Roblox.Platform.Membership.Properties;
using Roblox.Users.Client;

namespace Roblox.Platform.Membership;

public class MembershipDomainFactories : DomainFactoriesBase
{
	internal virtual ILogger Logger { get; }

	internal virtual ICounterRegistry CounterRegistry { get; }

	internal virtual ISettings Settings { get; }

	internal virtual IUserEntityFactory UserEntityFactory { get; }

	internal virtual IAccountEntityFactory AccountEntityFactory { get; }

	internal virtual IRoleSetEntityFactory RoleSetEntityFactory { get; }

	internal virtual IAccountRoleSetEntityFactory AccountRoleSetEntityFactory { get; }

	public virtual IAccountNameHistoryEntityFactory AccountNameHistoryEntityFactory { get; }

	public virtual IAgentFactory AgentFactory { get; }

	public virtual IUserFactory UserFactory { get; }

	public virtual IRoleSetValidator RoleSetValidator { get; }

	public virtual IBirthdateValidator BirthdateValidator { get; }

	public virtual IAgeChecker AgeChecker { get; }

	public virtual IUsersClient UsersClient { get; }

	public virtual IAccountAgeChangeEventPublisher AccountAgeChangeEventPublisher { get; }

	public MembershipDomainFactories(ILogger logger, ICounterRegistry counterRegistry)
		: this(logger, counterRegistry, Roblox.User.UsersClient)
	{
	}

	public MembershipDomainFactories(ILogger logger, ICounterRegistry counterRegistry, IUsersClient usersClient)
	{
		Logger = logger ?? throw new PlatformArgumentNullException("logger");
		CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
		ISettings settings = (Settings = Roblox.Platform.Membership.Properties.Settings.Default);
		UserEntityFactory = new UserEntityFactory();
		IAccountEntityFactory accountEntityFactory = (AccountEntityFactory = new AccountEntityFactory());
		IRoleSetEntityFactory roleSetEntityFactory = (RoleSetEntityFactory = new RoleSetEntityFactory());
		AccountNameHistoryEntityFactory = new AccountNameHistoryEntityFactory(usersClient);
		AgentFactory = new AgentFactory(usersClient, logger, counterRegistry);
		UserFactory = new UserFactory(this);
		AccountRoleSetEntityFactory = new AccountRoleSetEntityFactory();
		RoleSetValidator = new RoleSetValidator(settings, accountEntityFactory, roleSetEntityFactory, AccountRoleSetEntityFactory);
		BirthdateValidator = new BirthdateValidator();
		AgeChecker = new AgeChecker();
		AccountAgeChangeEventPublisher = new AccountAgeChangeEventPublisher(counterRegistry);
	}

	protected MembershipDomainFactories()
	{
	}
}
