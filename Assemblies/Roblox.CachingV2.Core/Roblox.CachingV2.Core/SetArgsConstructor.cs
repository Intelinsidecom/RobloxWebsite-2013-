namespace Roblox.CachingV2.Core;

public delegate TSetArgs SetArgsConstructor<in TValue, out TSetArgs>(TValue value) where TSetArgs : BasicSetArgs;
