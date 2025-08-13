using Roblox.Ownership.Client;

namespace Roblox.Platform.AssetOwnership;

internal interface IClientGetter
{
	IOwnershipAuthority Client { get; }
}
