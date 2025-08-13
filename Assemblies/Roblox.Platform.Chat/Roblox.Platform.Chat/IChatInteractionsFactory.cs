using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface IChatInteractionsFactory
{
	/// <summary>
	/// get paged result for unique non friend chat participants for a user
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="startIndex">start index for paged result</param>
	/// <param name="maxRows">maximum number of users in response</param>
	/// <returns>list of user Ids</returns>
	IReadOnlyCollection<long> GetUniqueChatParticipantIdsForUser(IUser user, int startIndex, int maxRows);

	/// <summary>
	/// get total number of unique non-friend chat participants for a user
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns>total count</returns>
	long GetUniqueChatParticipantsCountForUser(IUser user);
}
