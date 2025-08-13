using System.Collections.Generic;

namespace Roblox.Platform.Membership;

/// <summary>
/// A factory handling the instantiation of <see cref="T:Roblox.Platform.Membership.IUser" /> objects.
/// Also handles the creation of new users.
/// </summary>
public interface IUserFactory
{
	/// <summary>
	/// Gets a user by the provided id.
	/// This method takes long as input even though Id of <see cref="T:Roblox.Platform.Membership.IUser" /> is only an Int, because userId / targetId are generally long in other objects.
	/// Eventually <see cref="T:Roblox.Platform.Membership.IUser" />.Id should one day be changed to long as well.
	/// This method will by default return null when the user is in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state, unless shouldReturnForgottenUser is set to True.
	/// </summary>
	///             <exception cref="T:System.OverflowException"><paramref name="id" /> cannot be cast to the data type used by the underlying data storage. </exception>
	IUser GetUser(long id, bool shouldReturnForgottenUser = false);

	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Membership.IUser">IUser</see>, guaranteed to be not null
	/// </summary>
	/// <param name="id"><see cref="M:Roblox.Platform.Membership.IUserFactory.GetUser(System.Int64,System.Boolean)" /></param>
	/// <param name="shouldReturnForgottenUser"><see cref="M:Roblox.Platform.Membership.IUserFactory.GetUser(System.Int64,System.Boolean)" /></param>
	/// <exception cref="T:Roblox.Platform.Membership.UnknownUserException">The user is null</exception>
	IUser MustGetUser(long id, bool shouldReturnForgottenUser = false);

	/// <summary>
	/// Gets a user by current username
	/// This method will by default return null when the user is in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state, unless shouldReturnForgottenUser is set to True.
	/// </summary>
	/// <param name="name">Username of user to load.</param>
	/// <param name="shouldReturnForgottenUser">When false, user in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state will not be returned.</param>
	/// <returns><see cref="T:Roblox.Platform.Membership.IUser" /></returns>
	IUser GetUserByName(string name, bool shouldReturnForgottenUser = false);

	/// <summary>
	/// Gets a user by user's accountId
	/// This method takes long as input even though Account's id is Int.
	/// We are future proofing because we know that Accounts will need to be bigint. 
	/// As such this method accepts bigints for the purposes of other connected tables that already leverage bigint.
	/// This method will by default return null when the user is in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state, unless shouldReturnForgottenUser is set to True.
	/// </summary>
	/// <param name="accountId">accountId of user to load.</param>
	/// <param name="shouldReturnForgottenUser">When false, user in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state will not be returned.</param>
	/// <returns><see cref="T:Roblox.Platform.Membership.IUser" /></returns>
	/// <exception cref="T:System.OverflowException">
	///     <paramref name="accountId" /> cannot be cast to the data type used by the underlying data storage. 
	/// </exception>
	IUser GetUserByAccountId(long accountId, bool shouldReturnForgottenUser = false);

	/// <summary>
	/// Gets a user by current, or previous username
	/// This method will by default return null when the user is in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state, unless shouldReturnForgottenUser is set to True.
	/// </summary>
	/// <param name="name">Current, or previous username of user to load.</param>
	/// <param name="shouldReturnForgottenUser">When false, user in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state will not be returned.</param>
	/// <returns><see cref="T:Roblox.Platform.Membership.IUser" /></returns>
	IUser GetUserByAnyName(string name, bool shouldReturnForgottenUser = false);

	/// <summary>
	/// Gets a collection of users by their ids.
	/// This method will by default not return users that are in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state, unless shouldReturnForgottenUser is set to True.
	/// </summary>
	/// <param name="ids">Ids of users to get.</param>
	/// <param name="shouldReturnForgottenUser">When false, user in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state will not be returned.</param>
	///             <exception cref="T:System.OverflowException">At least one of the <paramref name="ids" /> cannot be cast to the data type used by the underlying data storage.</exception>
	ICollection<IUser> GetUsers(ICollection<long> ids, bool shouldReturnForgottenUser = false);

	/// <summary>
	/// Gets a dictionary mapping each input id to a <see cref="T:Roblox.Platform.Membership.IUser" />, or null if the user does not exist.
	/// </summary>
	/// <remarks>
	/// Each input id is guaranteed to have a corresponding entry in the returned dictionary.
	/// Duplicate ids will be consolidated into one entry.
	/// </remarks>
	/// <param name="ids">Ids of users to get.</param>
	/// <param name="shouldReturnForgottenUsers">When false, user in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state will not be returned.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" /> containing each id and the corresponding user, or null if the user does not exist or is forgotten.</returns>
	IReadOnlyDictionary<long, IUser> MultiGetUsers(ICollection<long> ids, bool shouldReturnForgottenUsers = false);

	/// <summary>
	/// Gets a dictionary mapping each input name to a <see cref="T:Roblox.Platform.Membership.IUser" />, or <c>null</c> if the user does not exist.
	/// </summary>
	/// <remarks>
	/// - Each input name is guaranteed to have a corresponding entry in the returned dictionary.
	/// - Returned dictionary is case in-sensitive.
	/// - Duplicate names will be consolidated into one entry.
	///
	/// If <paramref name="includePreviousUsernames" /> is <c>true</c> users may be returned even if the username is not the current one.
	/// When <c>false</c> name entries that are not the current username for the user will be <c>null</c>.
	/// </remarks>
	/// <param name="names">Names of users to get.</param>
	/// <param name="includePreviousUsernames">Whether or not users should be returned if their username has changed.</param>
	/// <param name="shouldReturnForgottenUsers">When false, user in <see cref="F:Roblox.Platform.Membership.AccountStatus.Forgotten" /> state will not be returned.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" /> containing each name and the corresponding <see cref="T:Roblox.Platform.Membership.IUser" />, or <c>null</c> if the user does not exist or is forgotten.</returns>
	IReadOnlyDictionary<string, IUser> MultiGetUsersByNames(ISet<string> names, bool includePreviousUsernames, bool shouldReturnForgottenUsers);

	/// <summary>
	/// Creates a new user along with a new account, with necessary age-based privacy settings and some optional additional information.
	///
	/// WARNING - Do not use this outside of SignupHelper.  A lot of additional business logic and validation associated with new users/accounts
	/// still lives there.
	///
	/// </summary>
	IUser CreateNewUser(string username, string password);

	/// <summary>
	/// Gets the default user id for the Roblox System account.
	/// </summary>
	/// <returns></returns>
	long GetRobloxSystemUserId();

	/// <summary>
	/// Gets the default user representing the Roblox System account.
	/// </summary>
	/// <returns></returns>
	IUser GetRobloxSystemUser();
    IUser GetCurrentUser();
}
