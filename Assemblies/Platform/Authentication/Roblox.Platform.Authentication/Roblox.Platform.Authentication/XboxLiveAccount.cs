namespace Roblox.Platform.Authentication;

internal class XboxLiveAccount : IXboxLiveAccount
{
	public int Id { get; set; }

	public long AccountId { get; set; }

	public string XboxLivePairwiseId { get; set; }

	public string XboxLiveGamerTagHash { get; set; }
}
