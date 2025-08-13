using System;

namespace Roblox.Platform.Authentication;

internal class FacebookAccount : IFacebookAccount, IFacebookAccountIdentifier
{
	public int Id { get; set; }

	public long AccountId { get; set; }

	public ulong FacebookId { get; set; }

	public DateTime Created { get; set; }
}
