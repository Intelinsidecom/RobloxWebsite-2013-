using System;
using System.Collections.Generic;

namespace Roblox.EventLog.Windows;

/// <summary>
/// Base interface for containers which are using for transmiting extensions configuration to ExtendedLogger
/// </summary>
public interface ILogExtensionsConfig
{
	IEnumerable<Func<string>> ErrorMessagePrefixDataProviders { get; }
}
