using System;
using System.Threading.Tasks;

namespace Roblox.EphemeralCounters;

internal static class BackgroundWorker
{
	internal static void RunInBackground(Action action, Action<Exception> errorLogger = null)
	{
		Task.Factory.StartNew(delegate
		{
			try
			{
				action();
			}
			catch (Exception obj)
			{
				if (errorLogger != null)
				{
					try
					{
						errorLogger(obj);
						return;
					}
					catch
					{
						return;
					}
				}
			}
		});
	}
}
