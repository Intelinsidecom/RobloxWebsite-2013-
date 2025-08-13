using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence.Properties;
using Roblox.Presence.Client;

namespace Roblox.Platform.Presence;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.Presence.IPresenceReader" />.
/// </summary>
public class PresenceReader : IPresenceReader
{
	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly IPresenceClient _PresenceClient;

	private readonly IComparer<IPresence> _PresencePriorityComparer;

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Presence.PresenceReader" />.
	/// </summary>
	/// <param name="logger" cref="T:Roblox.EventLog.ILogger">The logger to use.</param>
	/// <param name="presenceClient" cref="T:Roblox.Presence.Client.IPresenceClient">The client to connect to the presence service.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="logger" />
	/// - <paramref name="presenceClient" />
	/// </exception>
	public PresenceReader(ILogger logger, IPresenceClient presenceClient)
		: this(Settings.Default, logger, presenceClient, new PresencePriorityComparer())
	{
	}

	internal PresenceReader(ISettings settings, ILogger logger, IPresenceClient presenceClient, IComparer<IPresence> presencePriorityComparer)
	{
		_Settings = settings.AssignOrThrowIfNull("settings");
		_Logger = logger.AssignOrThrowIfNull("logger");
		_PresenceClient = presenceClient.AssignOrThrowIfNull<IPresenceClient>("presenceClient");
		_PresencePriorityComparer = presencePriorityComparer.AssignOrThrowIfNull("presencePriorityComparer");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Presence.IPresenceReader.GetAllActivePresences(Roblox.Platform.Membership.IUser)" />
	public IEnumerable<IPresence> GetAllActivePresences(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		try
		{
			return (from p in _PresenceClient.GetAllActiveUserPresences(user.Id)
				select ConvertPresenceReportToPresenceInfo(user, p) into p
				where p.IsOnline
				select p).ToArray();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return Array.Empty<IPresence>();
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Presence.IPresenceReader.MultiGetPresence(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Membership.IUser})" />
	public IPresence GetPresence(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		return MultiGetPresence((IReadOnlyCollection<IUser>)(object)new IUser[1] { user }).FirstOrDefault() ?? CreateEmptyPresence(user);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Presence.IPresenceReader.MultiGetPresence(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Membership.IUser})" />
	public IEnumerable<IPresence> MultiGetPresence(IReadOnlyCollection<IUser> users)
	{
		if (users == null)
		{
			throw new ArgumentNullException("users");
		}
		if (users.Count > _Settings.MultiGetPresenceLimit)
		{
			throw new ArgumentException(string.Format("{0} has {1}, maximum {2}.", "users", users.Count, _Settings.MultiGetPresenceLimit), "users");
		}
		if (users.Any((IUser u) => u == null))
		{
			throw new ArgumentException(string.Format("IUser in {0} is null.", "users"), "users");
		}
		if (!users.Any())
		{
			return Array.Empty<IPresence>();
		}
		try
		{
			return _PresenceClient.MultiGetUserPresence(users.Select((IUser u) => u.Id)).ToArray().Zip(users, (PresenceReport r, IUser u) => ConvertPresenceReportToPresenceInfo(u, r))
				.ToArray();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return Array.Empty<IPresence>();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Presence.IPresenceReader.GetPrioritizedPresence(Roblox.Platform.Membership.IUser)" />
	public IPresence GetPrioritizedPresence(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		return MultiGetPrioritizedPresence((IReadOnlyCollection<IUser>)(object)new IUser[1] { user }).FirstOrDefault() ?? CreateEmptyPresence(user);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Presence.IPresenceReader.MultiGetPrioritizedPresence(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Membership.IUser})" />
	public IEnumerable<IPresence> MultiGetPrioritizedPresence(IReadOnlyCollection<IUser> users)
	{
		if (users == null)
		{
			throw new ArgumentNullException("users");
		}
		if (users.Count > _Settings.MultiGetPresenceLimit)
		{
			throw new ArgumentException(string.Format("{0} has {1}, maximum {2}.", "users", users.Count, _Settings.MultiGetPresenceLimit), "users");
		}
		if (users.Any((IUser u) => u == null))
		{
			throw new ArgumentException(string.Format("IUser in {0} is null.", "users"), "users");
		}
		if (!users.Any())
		{
			return Array.Empty<IPresence>();
		}
		IUser[] uniqueUsers = users.Distinct().ToArray();
		long[] userIds = uniqueUsers.Select((IUser u) => u.Id).ToArray();
		Dictionary<long, IUser> userLookup = uniqueUsers.ToDictionary((IUser u) => u.Id);
		try
		{
			IEnumerable<IPresence> presenceInfos = _PresenceClient.MultiGetAllActivePresences((ICollection<long>)userIds).ToArray().Zip(users, (IReadOnlyCollection<PresenceReport> r, IUser u) => new
			{
				User = u,
				Reports = r
			})
				.SelectMany(t => t.Reports.Select((PresenceReport r) => ConvertPresenceReportToPresenceInfo(t.User, r)));
			IEnumerable<IPresence> groupedPresenceInfos = from u in presenceInfos
				group u by u.VisitorId into @group
				select @group.OrderBy((IPresence r) => r, _PresencePriorityComparer).FirstOrDefault() ?? CreateEmptyPresence(userLookup[@group.Key]);
			return uniqueUsers.Select((IUser u) => groupedPresenceInfos.FirstOrDefault((IPresence p) => p.VisitorId == u.Id) ?? CreateEmptyPresence(u)).ToArray();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return users.Select(CreateEmptyPresence).ToArray();
		}
	}

	private static Presence CreateEmptyPresence(IUser user)
	{
		return new Presence(user.Id, isOnline: false, user.Created, null, null, null, null);
	}

	private IPresence ConvertPresenceReportToPresenceInfo(IUser user, PresenceReport report)
	{
		DateTime lastObserved = (((PresenceReport)(ref report)).LastObserved.HasValue ? TimeZone.CurrentTimeZone.ToLocalTime(((PresenceReport)(ref report)).LastObserved.Value) : user.Created);
		LocationType? locationType = GetPlatformLocationType(((PresenceReport)(ref report)).LocationType);
		if (locationType == LocationType.Game || locationType == LocationType.CloudEdit)
		{
			string[] gameIdentifier = ((PresenceReport)(ref report)).LocationId.Split('|');
			long placeId = Convert.ToInt64(gameIdentifier[0]);
			Guid? presenceGameId = null;
			if (gameIdentifier.Length == 2 && Guid.TryParse(gameIdentifier[1], out var gameId))
			{
				presenceGameId = gameId;
			}
			return new Presence(user.Id, ((PresenceReport)(ref report)).IsOnline, lastObserved, placeId, presenceGameId, locationType, ((PresenceReport)(ref report)).UniverseId);
		}
		long? placeIdEditing = ((locationType == LocationType.Studio) ? new long?(Convert.ToInt64(((PresenceReport)(ref report)).LocationId)) : null);
		return new Presence(user.Id, ((PresenceReport)(ref report)).IsOnline, lastObserved, placeIdEditing, null, locationType, null);
	}

	private static LocationType? GetPlatformLocationType(string locationType)
	{
		if (string.IsNullOrEmpty(locationType))
		{
			return null;
		}
		if (!Enum.TryParse<LocationType>(locationType, out var platformLocationType))
		{
			throw new ArgumentOutOfRangeException("locationType");
		}
		return platformLocationType;
	}
}
