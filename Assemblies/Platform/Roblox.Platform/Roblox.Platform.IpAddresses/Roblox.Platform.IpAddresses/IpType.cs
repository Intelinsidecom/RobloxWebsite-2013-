namespace Roblox.Platform.IpAddresses;

/// <summary>
/// If Ip is valid, then it only has 3 types
/// NotFound means MaxMind API can not return any Geo Information
/// </summary>
public enum IpType
{
	Private,
	Public,
	NotFound
}
