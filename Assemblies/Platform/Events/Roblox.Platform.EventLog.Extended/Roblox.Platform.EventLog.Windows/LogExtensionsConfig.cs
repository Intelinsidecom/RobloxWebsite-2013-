using System;
using System.Collections.Generic;

namespace Roblox.EventLog.Windows;

/// <summary>
/// Basic implementaion of ILogExtensionsConfig interface. Receives all configs and etc. in constructor
/// </summary>
public class LogExtensionsConfig : ILogExtensionsConfig
{
	public IEnumerable<Func<string>> ErrorMessagePrefixDataProviders { get; }

	public LogExtensionsConfig(IEnumerable<Func<string>> errorMessagePrefixDataProviders)
	{
		ErrorMessagePrefixDataProviders = errorMessagePrefixDataProviders;
	}
}
