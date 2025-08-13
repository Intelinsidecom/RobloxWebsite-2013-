using System;
using Roblox.Agents;
using Roblox.ApiClientBase;
using Roblox.Economy;
using Roblox.Marketplace.Client;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.Games.Events;
using Roblox.Platform.Games.Exceptions;
using Roblox.Platform.Games.PrivateServer;
using Roblox.Platform.Games.Properties;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

public class UniversePrivateServersSettingsManager : IUniversePrivateServersSettingsManager
{
	private readonly IMarketplaceAuthority _MarketplaceAuthority;

	private readonly IAgentFactory _AgentFactory;

	private readonly IGroupFactory _GroupFactory;

	private readonly IUniversePermissionsVerifier _UniversePermissionsVerifier;

	private readonly IUserFactory _UserFactory;

	/// <summary>
	/// Constructor for UniversePrivateServersSettingsManager.
	/// </summary>
	/// <param name="marketplaceAuthority">An <see cref="T:Roblox.Marketplace.Client.IMarketplaceAuthority" /></param>
	/// <param name="agentFactory">An <see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <param name="universePermissionsVerifier">An <see cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" /></param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="marketplaceAuthority" /></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="agentFactory" /></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="groupFactory" /></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="universePermissionsVerifier" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="userFactory" /></exception>
	public UniversePrivateServersSettingsManager(IMarketplaceAuthority marketplaceAuthority, IAgentFactory agentFactory, IGroupFactory groupFactory, IUniversePermissionsVerifier universePermissionsVerifier, IUserFactory userFactory)
	{
		_MarketplaceAuthority = marketplaceAuthority.AssignOrThrowIfNull<IMarketplaceAuthority>("marketplaceAuthority");
		_AgentFactory = agentFactory.AssignOrThrowIfNull("agentFactory");
		_GroupFactory = groupFactory.AssignOrThrowIfNull("groupFactory");
		_UniversePermissionsVerifier = universePermissionsVerifier.AssignOrThrowIfNull("universePermissionsVerifier");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	/// <inheritdoc />
	public long GetTotalNumberOfPrivateServersByPrivateServerStatusType(IUniverse universe, Roblox.Platform.Games.PrivateServer.PrivateServerStatusType privateServerStatusType)
	{
		return Roblox.Platform.Games.Entities.PrivateServer.GetTotalNumberOfPrivateServersByUniverseIdAndPrivateServerStatusTypeId(universe.Id, (byte)privateServerStatusType);
	}

	/// <inheritdoc />
	public bool DoesUniverseAllowPrivateServers(IUniverse universe)
	{
		return UniversePrivateServerAttribute.GetByUniverseID(universe.Id)?.AllowPrivateServers ?? false;
	}

	/// <inheritdoc />
	public void SetUniverseDoesAllowPrivateServers(IUniverse universe, bool allowPrivateServers, long userPerformingChangeId, long? priceInRobux = null)
	{
		VerifyPermissionToMakeChange(universe, userPerformingChangeId);
		UniversePrivateServerAttribute universeAttributes = UniversePrivateServerAttribute.GetByUniverseID(universe.Id);
		if ((universeAttributes?.AllowPrivateServers ?? false) != allowPrivateServers)
		{
			if (universeAttributes == null)
			{
				universeAttributes = new UniversePrivateServerAttribute
				{
					UniverseID = universe.Id
				};
				long price = priceInRobux ?? Settings.Default.PrivateServerDefaultPrice;
				ValidateNewPrivateServerPrice(price);
				AgentType agentType = (CreatorType)Enum.Parse(typeof(CreatorType), universe.CreatorType) switch
				{
					CreatorType.Group => AgentType.Group, 
					CreatorType.User => AgentType.User, 
					_ => throw new NotSupportedException($"VIP server creation not supported for universes with a creator type of {universe.CreatorType}"), 
				};
				IAgent agent = _AgentFactory.GetByAgentTypeAndAgentTargetId(agentType, universe.CreatorTargetId);
				_MarketplaceAuthority.CreateProduct(ProductType.PrivateServerProductID, (long?)universe.Id, (long?)Convert.ToInt32(agent.Id), false, true, (long?)price, (long?)null, (int?)null, 0L, 0L, (float?)0f);
			}
			universeAttributes.AllowPrivateServers = allowPrivateServers;
			universeAttributes.Save();
			if (allowPrivateServers)
			{
				PrivateServerConfigureEventPublisher.PublishDeveloperAllowEvent(universe.Id);
			}
			else
			{
				PrivateServerConfigureEventPublisher.PublishDeveloperDisallowEvent(universe.Id);
			}
		}
	}

	/// <inheritdoc />
	public bool SetPrivateServerPriceForUniverse(IUniverse universe, long userPerformingChangeId, long newPriceInRobux)
	{
		VerifyPermissionToMakeChange(universe, userPerformingChangeId);
		ValidateNewPrivateServerPrice(newPriceInRobux);
		Product privateServerProduct = GetPrivateServerProduct(universe);
		if (privateServerProduct == null)
		{
			return false;
		}
		if (privateServerProduct.PriceInRobux == newPriceInRobux)
		{
			return false;
		}
		try
		{
			_MarketplaceAuthority.ChangeProductPrice(privateServerProduct.ID, (long?)newPriceInRobux);
		}
		catch (ApiClientException)
		{
			throw new PrivateServersPlatformException("There was a problem changing the price of VIP Servers for your game. Please try again in a few minutes.");
		}
		PrivateServerConfigureEventPublisher.PublishDeveloperChangePriceEvent(universe.Id);
		return true;
	}

	/// <inheritdoc />
	public Product GetPrivateServerProduct(IUniverse universe)
	{
		return Product.GetByTypeAndTargetID(ProductType.PrivateServerProductID, universe.Id);
	}

	/// <inheritdoc />
	public void VerifyPrivateServerConfigurePermissions(IUniverse universe)
	{
		if (!DoesUniverseAllowPrivateServers(universe))
		{
			throw new UniverseDisallowsPrivateServersException("The creator of this game has disabled VIP Servers for this game.");
		}
		if (!universe.RootPlaceId.HasValue)
		{
			throw new UniverseDisallowsPrivateServersException("The game must have a valid start place to allow VIP Servers.");
		}
		if (Roblox.Platform.Assets.Factories.PlaceFactory.Get(universe.RootPlaceId.Value).IsFriendsOnly())
		{
			throw new UniverseDisallowsPrivateServersException("The game must not be Friends Only to allow VIP Servers.");
		}
	}

	private void VerifyPermissionToMakeChange(IUniverse universe, long userPerformingChangeId)
	{
		IUser user = _UserFactory.GetUser(userPerformingChangeId);
		if (user == null || universe == null || !_UniversePermissionsVerifier.CanUserManageUniverse(user, universe))
		{
			throw new InvalidOwnerException(universe, userPerformingChangeId, "User does not have sufficient privileges to manage this game.");
		}
	}

	private void ValidateNewPrivateServerPrice(long newPriceInRobux)
	{
		if (newPriceInRobux < Settings.Default.PrivateServerMinPrice)
		{
			throw new PrivateServerArgumentException("You may not set the price of a VIP Server below " + Settings.Default.PrivateServerDefaultPrice + " Robux.");
		}
	}
}
