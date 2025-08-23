using System;
using Roblox.Games.Client;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;

namespace Roblox.Web.Code;

/// <summary>
/// Process an account change event by kicking them from games.
/// </summary>
public class AccountStatusChangeListener
{
	private readonly GamesAuthority _GamesAuthority;

	private readonly IPresenceReader _PresenceReader;

	private readonly IUserFactory _UserFactory;

	public AccountStatusChangeListener(GamesAuthority gamesAuthority, IPresenceReader presenceReader, IUserFactory userFactory)
	{
		_GamesAuthority = gamesAuthority ?? throw new ArgumentNullException("gamesAuthority");
		_PresenceReader = presenceReader ?? throw new ArgumentNullException("presenceReader");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public void Register()
	{
		User.AccountStatusChanged += delegate(long userId, byte statusCode)
		{
			if (statusCode != AccountStatus.OkId)
			{
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					KickUser(_GamesAuthority, _PresenceReader, userId, _UserFactory);
				});
			}
		};
	}

	private static void KickUser(IGamesAuthority authority, IPresenceReader reader, long userId, IUserFactory userFactory)
	{
		IUser user = userFactory.GetUser(userId);
		foreach (IPresence presence in reader.GetAllActivePresences(user))
		{
			if (presence != null && presence.PlaceId.HasValue && presence.GameId.HasValue)
			{
				long placeId = presence.PlaceId.Value;
				Guid gameGuid = presence.GameId.Value;
				try
				{
					authority.Evict(placeId, gameGuid, userId);
				}
				catch (Exception ex)
				{
					ExceptionHandler.LogException($"KickUser failed - PlaceId: {placeId}, GameGUID: {gameGuid} " + ex);
				}
			}
		}
	}
}
