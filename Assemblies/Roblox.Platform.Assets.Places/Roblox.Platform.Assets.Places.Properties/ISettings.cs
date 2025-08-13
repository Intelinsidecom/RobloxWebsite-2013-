namespace Roblox.Platform.Assets.Places.Properties;

public interface ISettings
{
	int MaxPlayersPerBetaTesterPlace { get; }

	bool IsEntityImplementationUsingLegacyBLL { get; }

	int MaxPlayersDefault { get; }

	int MaxPlayersPerPlace { get; }

	int MinPlayersPerPlace { get; }

	int SocialSlotsDefault { get; }

	bool IsSocialSlotTypesEnabledForSoothsayers { get; }

	bool IsSocialSlotTypesEnabledForBetaTesters { get; }

	int SocialSlotTypesRolloutPercentage { get; }
}
