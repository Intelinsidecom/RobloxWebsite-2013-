using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Agents;
using Roblox.EventLog;
using Roblox.Games.Client;
using Roblox.Instrumentation;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Games;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Platform.UniverseSettings.Events;

namespace Roblox.Platform.UniverseSettings;

/// <summary>
/// Domain interfaces container for classes that deal with universe access
/// </summary>
[ExcludeFromCodeCoverage]
public class UniverseAccessDomainFactories : DomainFactoriesBase
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAccessChanger" />
	/// </summary>
	public virtual IUniverseAccessChanger UniverseAccessChanger { get; internal set; }

	internal virtual UniverseSettingsChangeReporter UniverseSettingsChangeReporter { get; }

	/// <summary>
	/// Initialize a new instance of the <see cref="T:Roblox.Platform.UniverseSettings.UniverseAccessDomainFactories" /> class. This is the primary constructor. If you have special SNS requirements, see the other constructor.
	/// </summary>
	/// <param name="agentFactory"></param>
	/// <param name="placeFactory"></param>
	/// <param name="universeFactory"></param>
	/// <param name="gamesAuthority"></param>
	/// <param name="matchmakingContextFactory"></param>
	/// <param name="getAuditingUser"></param>
	/// <param name="logger"></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	public UniverseAccessDomainFactories(IAgentFactory agentFactory, IPlaceFactory placeFactory, IUniverseFactory universeFactory, IUniversePublicizer universePublicizer, IGamesAuthority gamesAuthority, IMatchmakingContextFactory matchmakingContextFactory, Func<IUser> getAuditingUser, ILogger logger, ICounterRegistry counterRegistry)
		: this(agentFactory, placeFactory, universeFactory, universePublicizer, gamesAuthority, matchmakingContextFactory, getAuditingUser, new UniverseSettingsEventsPublisher(logger, counterRegistry))
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.UniverseSettings.UniverseAccessDomainFactories" /> class. Use this constructor when you need to do some dependency injection
	/// to override normal behavior.
	/// </summary>
	/// <param name="agentFactory">The <see cref="T:Roblox.Agents.IAgentFactory" />.</param>
	/// <param name="placeFactory">The <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <param name="universeFactory">The <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <param name="gamesAuthority">The <see cref="T:Roblox.Games.Client.IGamesAuthority" />.</param>
	/// <param name="matchmakingContextFactory">The <see cref="T:Roblox.Platform.Games.IMatchmakingContextFactory" />.</param>
	/// <param name="getAuditingUser">Returns an <see cref="T:Roblox.Platform.Membership.IUser" /> used for things like group audit logging when activating, or deactivating a universe.</param>
	/// <param name="universeSettingsEventsObserver">Override to inject your own <see cref="T:Roblox.Platform.UniverseSettings.Events.IUniverseSettingsEventsObserver" />. You should have a very good reason
	/// (infinite change event loops) for example, when modifying this.</param>
	public UniverseAccessDomainFactories(IAgentFactory agentFactory, IPlaceFactory placeFactory, IUniverseFactory universeFactory, IUniversePublicizer universePublicizer, IGamesAuthority gamesAuthority, IMatchmakingContextFactory matchmakingContextFactory, Func<IUser> getAuditingUser, IUniverseSettingsEventsObserver universeSettingsEventsObserver)
	{
		if (universeSettingsEventsObserver == null)
		{
			throw new ArgumentNullException("universeSettingsEventsObserver");
		}
		universeSettingsEventsObserver.Subscribe(UniverseSettingsChangeReporter = new UniverseSettingsChangeReporter());
		UniverseAccessChanger universeAccessChanger = new UniverseAccessChanger(agentFactory, placeFactory, gamesAuthority, matchmakingContextFactory, getAuditingUser, universePublicizer, this);
		UniverseAccessChanger = universeAccessChanger;
	}
}
