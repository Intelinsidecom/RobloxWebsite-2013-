using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Configuration;
using Roblox.Platform.Membership;
using Roblox.Platform.XboxLive.Properties;

namespace Roblox.Platform.XboxLive;

internal class XboxSoothsayerVerifier : IXboxSoothsayerVerifier
{
	[ExcludeFromCodeCoverage]
	internal virtual string XboxSoothsayerUserIdCsv => Settings.Default.XboxSoothsayerUserIdCsv;

	internal ICollection<long> XboxSoothsayerUserIds { get; private set; }

	public XboxSoothsayerVerifier()
	{
		ReloadXboxSoothsayerUserIds();
		Settings.Default.MonitorChanges((Settings s) => s.XboxSoothsayerUserIdCsv, ReloadXboxSoothsayerUserIds);
	}

	public bool IsSoothsayer(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		return XboxSoothsayerUserIds.Contains(user.Id);
	}

	internal void ReloadXboxSoothsayerUserIds()
	{
		string[] array = XboxSoothsayerUserIdCsv.Split(',');
		List<long> userIds = new List<long>();
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			if (long.TryParse(array2[i].Trim(), out var userId))
			{
				userIds.Add(userId);
			}
		}
		XboxSoothsayerUserIds = userIds;
	}
}
