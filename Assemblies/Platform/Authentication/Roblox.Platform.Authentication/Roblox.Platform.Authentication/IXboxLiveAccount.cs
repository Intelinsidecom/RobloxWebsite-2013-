namespace Roblox.Platform.Authentication;

public interface IXboxLiveAccount
{
	int Id { get; }

	long AccountId { get; }

	string XboxLivePairwiseId { get; }

	string XboxLiveGamerTagHash { get; set; }
}
