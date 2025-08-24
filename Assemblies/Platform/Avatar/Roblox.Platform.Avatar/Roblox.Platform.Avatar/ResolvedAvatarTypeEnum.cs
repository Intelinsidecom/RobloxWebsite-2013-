namespace Roblox.Platform.Avatar;

/// <summary>
/// This is the combination of universeAvatarType and playerAvatarType that is returned along with avatar-fetch.
/// It is used by the game server to build the character.
/// </summary>
public enum ResolvedAvatarTypeEnum : byte
{
	R6 = 1,
	R15 = 3
}
