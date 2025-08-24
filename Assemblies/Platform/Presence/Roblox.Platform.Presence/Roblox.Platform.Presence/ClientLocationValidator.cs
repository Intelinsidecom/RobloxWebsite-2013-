using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Roblox.Configuration;
using Roblox.Platform.Presence.Properties;

namespace Roblox.Platform.Presence;

/// <summary>
/// Helper class to validate location for Registering App Presence.
/// Valid locations are configured as Enums, new client location can be added as a setting but should
/// be moved to an Enum later.
/// </summary>
public static class ClientLocationValidator
{
	private enum BaseLocationType
	{
		About,
		Agreement,
		Avatar,
		Chat,
		Challenge,
		ChinaCatalog,
		ChinaBundleModal,
		Events,
		GenericWebPage,
		Games,
		Home,
		Logout,
		More,
		MyFeed,
		None,
		Notifications,
		PurchaseRobux,
		Search,
		SimplifiedMore,
		Settings,
		ShareGameToChat,
		Startup,
		WeChatLogin,
		YouTubePlayer
	}

	private enum SubLocationType
	{
		Detail,
		List,
		Editor
	}

	private static HashSet<string> _LocationsWhiteListedForRegisterAppPresence;

	public static event Action<Exception> OnError;

	static ClientLocationValidator()
	{
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.ValidLocationsForRegisterAppPresenceCsv, UpdateLocationsWhiteListedForRegisterAppPresence);
	}

	public static bool IsClientLocationValid(string location, out bool enumExistsForLocation)
	{
		enumExistsForLocation = false;
		if (string.IsNullOrEmpty(location))
		{
			return false;
		}
		try
		{
			string[] locations = location.Split('_');
			string rootLocation = locations[0];
			if (Enum.IsDefined(typeof(BaseLocationType), rootLocation))
			{
				if (locations.Length == 1)
				{
					enumExistsForLocation = true;
					return true;
				}
				if (locations.Length == 2 && !string.IsNullOrEmpty(locations[1]) && Enum.IsDefined(typeof(BaseLocationType), locations[1]))
				{
					enumExistsForLocation = true;
					return true;
				}
			}
			return _LocationsWhiteListedForRegisterAppPresence != null && _LocationsWhiteListedForRegisterAppPresence.Contains(location);
		}
		catch (Exception e)
		{
			ClientLocationValidator.OnError?.Invoke(e);
			return false;
		}
	}

	private static void UpdateLocationsWhiteListedForRegisterAppPresence(string whitelistedLocationsCsv)
	{
		HashSet<string> validLocations = new HashSet<string>();
		try
		{
			if (!string.IsNullOrEmpty(whitelistedLocationsCsv))
			{
				foreach (string location2 in from location in whitelistedLocationsCsv.Split(',')
					where !string.IsNullOrEmpty(location)
					select location)
				{
					validLocations.Add(location2.Trim());
				}
			}
			if (validLocations != null && validLocations.Count > 0)
			{
				Interlocked.Exchange(ref _LocationsWhiteListedForRegisterAppPresence, validLocations);
			}
		}
		catch (Exception e)
		{
			ClientLocationValidator.OnError?.Invoke(e);
		}
	}
}
