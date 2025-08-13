using System;

namespace Roblox.FloodCheckers.Core;

public class GlobalFloodCheckerEventLogger : IGlobalFloodCheckerEventLogger
{
	public static event Action<string> OnFlooded;

	internal static void RecordFloodCheckerIsFloodedStatic(string category)
	{
		GlobalFloodCheckerEventLogger.OnFlooded?.Invoke(category);
	}

	public void RecordFloodCheckerIsFlooded(string category)
	{
		GlobalFloodCheckerEventLogger.OnFlooded?.Invoke(category);
	}
}
