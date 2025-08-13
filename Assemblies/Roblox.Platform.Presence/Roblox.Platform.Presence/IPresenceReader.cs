using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Presence;

/// <summary>
/// Provides methods to read presence-related data.
/// </summary>
/// <remarks>
/// It is notable that his interface has a rather unique approach to handle service failures:
/// If _any_ service-level failure occurs, then the failure is logged and the _default_ result
/// is returned. This means that the consumer can not differentiate between the "user has not been online recently"
/// and the "the presence service is down" case.
///
/// This behaviour was inherited from the IPresenceRegistrar implementation and changing it will
/// require auditing and updating all consumers to handle errors gracefully.
/// </remarks>
public interface IPresenceReader
{
	/// <summary>
	/// Gets the latest presence for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Presence.IPresence" /> for the <see cref="T:Roblox.Platform.Membership.IUser" />. Returns an empty <see cref="T:Roblox.Platform.Presence.IPresence" /> if none if available.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="user" />
	/// </exception>
	IPresence GetPresence(IUser user);

	/// <summary>
	/// Gets the latest <see cref="T:Roblox.Platform.Presence.IPresence" /> for a list of <see cref="T:Roblox.Platform.Membership.IUser" />s.
	/// You should evaluate whether the latest or a prioritized is required on a per-usecase basis.
	/// </summary>
	/// <param name="users" cref="T:System.Collections.Generic.IReadOnlyCollection`1">The<see cref="T:Roblox.Platform.Membership.IUser" />s to fetch the <see cref="T:Roblox.Platform.Presence.IPresence" />s for.</param>
	/// <returns>
	/// The <see cref="T:System.Collections.Generic.IEnumerable`1" />s, one for each user.
	/// Entries are ordered the same as the <paramref name="users" />.
	/// In the event of a service-level failure, an <see cref="T:System.Collections.Generic.IEnumerable`1" />
	/// consisting of empty, default <see cref="T:Roblox.Platform.Presence.IPresence" />s is returned. This looks the same
	/// as if none of the <see cref="T:Roblox.Platform.Membership.IUser" />s ever was online.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="users" />
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	/// - Any entry in <paramref name="users" /> is null.
	/// - <paramref name="users" /> has more entries than allowed.
	/// </exception>
	IEnumerable<IPresence> MultiGetPresence(IReadOnlyCollection<IUser> users);

	/// <summary>
	/// Gets the prioritized presence for a user based on all their active presences.
	/// Game &gt; Cloud Edit &gt; Studio &gt; All
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>
	/// <see cref="T:Roblox.Platform.Presence.IPresence" /> of the <see cref="T:Roblox.Platform.Membership.IUser" />'s presence.
	/// Or an empty, default <see cref="T:Roblox.Platform.Presence.IPresence" /> if any failure occured.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="user" />
	/// </exception>
	IPresence GetPrioritizedPresence(IUser user);

	/// <summary>
	/// Gets the prioritized presence for a list of <see cref="T:Roblox.Platform.Membership.IUser" />s.
	/// See <see cref="M:Roblox.Platform.Presence.IPresenceReader.GetPrioritizedPresence(Roblox.Platform.Membership.IUser)" /> for details.
	/// </summary>
	/// <param name="users" cref="T:Roblox.Platform.Membership.IUser">The <see cref="T:Roblox.Platform.Membership.IUser" />s.</param>
	/// <returns>
	/// The requested <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" />, one per user.
	/// The resulting list is ordered the same as the input list of users.
	/// If the presence service is not responding or if there has been any other failure,
	/// then an <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of empty, default <see cref="T:Roblox.Platform.Presence.IPresence" />s
	/// is returned.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">
	///  - <paramref name="users" />
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="users" /> had more than 200 users in it.
	/// - <paramref name="users" /> has a null entry.
	/// </exception>
	IEnumerable<IPresence> MultiGetPrioritizedPresence(IReadOnlyCollection<IUser> users);

	/// <summary>
	/// Gets the latest presences for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user" cref="T:Roblox.Platform.Membership.IUser">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>
	/// <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> for the <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// Or an empty <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> if the user has not been online
	/// or if the service request failed."/&gt;</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="user" />
	/// </exception>
	IEnumerable<IPresence> GetAllActivePresences(IUser user);
}
