namespace Roblox.Kickbox;

public class KickboxVerifyDomainRequest : IKickboxVerifyDomainRequest
{
	public string Domain { get; }

	public KickboxVerifyDomainRequest(string domain)
	{
		Domain = domain;
	}
}
