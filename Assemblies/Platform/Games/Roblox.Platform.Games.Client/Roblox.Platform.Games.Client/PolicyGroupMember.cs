namespace Roblox.Games.Client;

public class PolicyGroupMember
{
	public long Id { get; set; }

	public PolicyGroup PolicyGroup { get; set; }

	public LocationGroup LocationGroup { get; set; }

	public int Rank { get; set; }

	public double? InclusionRatio { get; set; }
}
