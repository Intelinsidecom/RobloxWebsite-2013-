using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Badges.Client;
using Roblox.Platform.AssetPermissions;
using Roblox.Platform.Assets;
using Roblox.Platform.Badges.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Badges;

/// <summary>
/// Contains factories of Badges Domain
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.DomainFactoriesBase" />
[ExcludeFromCodeCoverage]
public class BadgesDomainFactories : DomainFactoriesBase
{
	/// <summary>
	/// Gets the badges factory.
	/// </summary>
	public IBadgesAwardsAuthority BadgesAwardsAuthority { get; }

	/// <summary>
	/// Gets the badge identifier factory.
	/// </summary>
	public IBadgeIdentifierFactory BadgeIdentifierFactory { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Badges.IBadgeAwardAssetsReader" />.
	/// </summary>
	public IBadgeAwardAssetsReader BadgeAwardAssetsReader { get; }

	/// <summary>
	/// Gets the exclusive start key factory.
	/// </summary>
	public IExclusiveStartKeyFactory ExclusiveStartKeyFactory { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Badges.IBadgePermissionsVerifier" />
	/// </summary>
	public IBadgePermissionsVerifier BadgePermissionsVerifier { get; }

	/// <summary>
	/// The badge <see cref="T:Roblox.Platform.Badges.Properties.ISettings" />.
	/// </summary>
	public ISettings Settings => Roblox.Platform.Badges.Properties.Settings.Default;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Badges.BadgesDomainFactories" /> class.
	/// </summary>
	/// <param name="badgesClient">The badges client <see cref="T:Roblox.Badges.Client.IBadgesClient" />.</param>
	/// <param name="universePermissionsVerifier">An <see cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />.</param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" />.</param>
	/// <param name="groupMembershipFactory">An <see cref="T:Roblox.Platform.Groups.IGroupMembershipFactory" />.</param>
	/// <param name="placeFactory">An <see cref="T:Roblox.Platform.Assets.IPlaceFactory" /></param>
	/// <param name="assetPermissionsVerifier">An <see cref="T:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier" /></param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public BadgesDomainFactories(IBadgesClient badgesClient, IUniversePermissionsVerifier universePermissionsVerifier, IGroupFactory groupFactory, IGroupMembershipFactory groupMembershipFactory, IPlaceFactory placeFactory, IAssetPermissionsVerifier assetPermissionsVerifier, IUniverseFactory universeFactory)
	{
		if (badgesClient == null)
		{
			throw new ArgumentNullException("badgesClient");
		}
		if (universePermissionsVerifier == null)
		{
			throw new ArgumentNullException("universePermissionsVerifier");
		}
		if (groupFactory == null)
		{
			throw new ArgumentNullException("groupFactory");
		}
		if (groupMembershipFactory == null)
		{
			throw new ArgumentNullException("groupMembershipFactory");
		}
		if (placeFactory == null)
		{
			throw new ArgumentNullException("placeFactory");
		}
		if (assetPermissionsVerifier == null)
		{
			throw new ArgumentNullException("assetPermissionsVerifier");
		}
		if (universeFactory == null)
		{
			throw new ArgumentNullException("universeFactory");
		}
		RecipientFactory recipientFactory = new RecipientFactory();
		BadgeIdentifierFactory badgeIdentifierFactory = new BadgeIdentifierFactory();
		BadgeAwardAssetsReader badgeAwardAssetsReader = new BadgeAwardAssetsReader(badgeIdentifierFactory);
		BadgesAwardsAuthority badgesAwardsAuthority = new BadgesAwardsAuthority(recipientFactory, badgesClient);
		BadgeIdentifierFactory = badgeIdentifierFactory;
		BadgesAwardsAuthority = badgesAwardsAuthority;
		BadgeAwardAssetsReader = badgeAwardAssetsReader;
		ExclusiveStartKeyFactory = new ExclusiveStartKeyFactory();
		BadgePermissionsVerifier = new BadgePermissionsVerifier(universePermissionsVerifier, groupFactory, groupMembershipFactory, placeFactory, assetPermissionsVerifier, universeFactory);
	}
}
