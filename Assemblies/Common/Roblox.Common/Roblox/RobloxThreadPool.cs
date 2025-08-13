using System;
using Roblox.Common.NetStandard;

namespace Roblox;

public static class RobloxThreadPool
{
	public static int QueueLength => Roblox.Common.NetStandard.RobloxThreadPool.QueueLength;

	public static bool QueueUserWorkItem(Action callback)
	{
		return Roblox.Common.NetStandard.RobloxThreadPool.QueueUserWorkItem(callback);
	}

	public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
	{
		Roblox.Common.NetStandard.RobloxThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
	}
}
