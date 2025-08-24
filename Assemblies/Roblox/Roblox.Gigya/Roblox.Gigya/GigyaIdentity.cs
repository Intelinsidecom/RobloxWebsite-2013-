using System;
using Gigya.Socialize.SDK;

namespace Roblox.Gigya;

internal class GigyaIdentity : IGigyaIdentity
{
	public string Provider { get; private set; }

	public string ProviderUid { get; private set; }

	public string ProfileUrl { get; private set; }

	public GigyaIdentity(GSObject data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Provider = data.GetString("provider", string.Empty);
		ProfileUrl = data.GetString("profileURL", string.Empty);
		ProviderUid = data.GetString("providerUID", string.Empty);
	}
}
