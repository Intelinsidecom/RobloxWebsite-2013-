using System;

namespace Roblox.LeasedLocks.Client.Properties;

internal interface ISettings
{
	TimeSpan RequestTimeout { get; }
}
