using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Agents;
using Roblox.CatalogItemChangePublisher;
using Roblox.Games.Client;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Games;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Moderation;
using Roblox.Platform.Universes;
using Roblox.Platform.UniverseSettings.Properties;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseAccessChanger : IUniverseAccessChanger
{
	private const string _PublicPrivacyType = "Public";

	private const string _PrivatePrivacyType = "Private";

	private readonly IAgentFactory _AgentFactory;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IGamesAuthority _GamesAuthority;

	private readonly IMatchmakingContextFactory _MatchmakingContextFactory;

	private readonly Func<IUser> _GetAuditingUser;

	private readonly UniverseAccessDomainFactories _UniverseAccessDomainFactories;

	private readonly IUniversePublicizer _UniversePublicizer;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsGameShutdownByDeveloperEnabled => Settings.Default.IsGameShutdownByDeveloperEnabled;

	public UniverseAccessChanger(IAgentFactory agentFactory, IPlaceFactory placeFactory, IGamesAuthority gamesAuthority, IMatchmakingContextFactory matchmakingContextFactory, Func<IUser> getAuditingUser, IUniversePublicizer universePublicizer, UniverseAccessDomainFactories universeAccessDomainFactories)
	{
		_AgentFactory = agentFactory ?? throw new PlatformArgumentNullException("agentFactory");
		_PlaceFactory = placeFactory ?? throw new PlatformArgumentNullException("placeFactory");
		_GamesAuthority = gamesAuthority ?? throw new PlatformArgumentNullException("gamesAuthority");
		_MatchmakingContextFactory = matchmakingContextFactory ?? throw new PlatformArgumentNullException("matchmakingContextFactory");
		_GetAuditingUser = getAuditingUser ?? throw new PlatformArgumentNullException("getAuditingUser");
		_UniverseAccessDomainFactories = universeAccessDomainFactories ?? throw new PlatformArgumentNullException("universeAccessDomainFactories");
		_UniversePublicizer = universePublicizer ?? throw new PlatformArgumentNullException("universePublicizer");
	}

	public void ActivateUniverse(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (universe.PrivacyType == "Public")
		{
			return;
		}
		IPlace rootPlace = (universe.RootPlaceId.HasValue ? _PlaceFactory.Get(universe.RootPlaceId.Value) : null);
		if (rootPlace == null)
		{
			throw new PlatformArgumentException("Universe missing root place.");
		}
		IAgent byAgentTypeAndAgentTargetId = _AgentFactory.GetByAgentTypeAndAgentTargetId(rootPlace.CreatorType.ToAgentType(), rootPlace.CreatorTargetId);
		AssetModerationStatus moderationStatus = GetPlaceModerationStatus(rootPlace);
		if (moderationStatus.Equals(AssetModerationStatus.Orange) || moderationStatus.Equals(AssetModerationStatus.Red))
		{
			throw new ModeratedOperationException($"Moderation status prevents activation ({moderationStatus})");
		}
		_UniversePublicizer.SetUniverseToPublic(universe);
		_UniverseAccessDomainFactories.UniverseSettingsChangeReporter.EntityChanged(universe.Id);
		PublishAsset(rootPlace.Id);
		if (byAgentTypeAndAgentTargetId.AgentType.Equals(AgentType.Group))
		{
			IUser auditingUser = _GetAuditingUser();
			if (auditingUser != null)
			{
				LogGroupAction(rootPlace, auditingUser, GroupManagement.ConfigureGroupAssetAction.ActivatePlace);
			}
		}
	}

	public void DeactivateUniverse(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (!(universe.PrivacyType == "Private"))
		{
			IPlace rootPlace = (universe.RootPlaceId.HasValue ? _PlaceFactory.Get(universe.RootPlaceId.Value) : null);
			if (rootPlace == null)
			{
				throw new PlatformArgumentException("Universe missing root place.");
			}
			IAgent agent = _AgentFactory.GetByAgentTypeAndAgentTargetId(rootPlace.CreatorType.ToAgentType(), rootPlace.CreatorTargetId);
			_UniversePublicizer.SetUniverseToPrivate(universe);
			_UniverseAccessDomainFactories.UniverseSettingsChangeReporter.EntityChanged(universe.Id);
			PublishAsset(rootPlace.Id);
			if (IsGameShutdownByDeveloperEnabled)
			{
				_GamesAuthority.Close(rootPlace.Id, CloseGameReasonType.Developer, _MatchmakingContextFactory.GetGameShutdownExcludedMatchmakingContextIds());
			}
			IUser auditingUser = _GetAuditingUser();
			if (auditingUser != null && agent.AgentType.Equals(AgentType.Group))
			{
				LogGroupAction(rootPlace, auditingUser, GroupManagement.ConfigureGroupAssetAction.DeactivatePlace);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual AssetModerationStatus GetPlaceModerationStatus(IPlace place)
	{
		return place.GetModerationStatus();
	}

	[ExcludeFromCodeCoverage]
	internal virtual void LogGroupAction(IPlace place, IUser actor, GroupManagement.ConfigureGroupAssetAction action)
	{
		GroupManagement.ConfigureGroupAssetJson configureGroupAssetJson = new GroupManagement.ConfigureGroupAssetJson();
		configureGroupAssetJson.AssetId = place.Id;
		configureGroupAssetJson.Actions = new GroupManagement.ConfigureGroupAssetAction[1] { action };
		GroupManagement.ConfigureGroupAssetJson audit = configureGroupAssetJson;
		GroupManagement.LogGroupAction(actor.Id, place.CreatorTargetId, GroupActionType.ConfigureAsset.ID, audit);
	}

	private static void PublishAsset(long assetId)
	{
		if (Settings.Default.IsPublishToPlaceActiveDeactiveEnabled)
		{
			Roblox.CatalogItemChangePublisher.CatalogItemChangePublisher.Singleton.Publish(assetId);
		}
	}
}
