namespace Roblox.Platform.Membership.Events;

/// <summary>
/// A platform object used to publish account age change events.
/// </summary>
public interface IAccountAgeChangeEventPublisher
{
	/// <summary>
	/// Publishes an account age change event with the given user and previous AgeBracket.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="previousAge">The previous <see cref="T:Roblox.Platform.Membership.AgeBracket" />.</param>
	void Publish(IUser user, AgeBracket previousAge);

	/// <summary>
	/// Publishes an account age change event with the given user and age brackets.
	/// </summary>
	/// <remarks>
	/// <paramref name="automaticAgeUp" /> should be <c>false</c> if the age bracket was changed manually (by a human).
	/// </remarks>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="previousAgeBracket">The previous <see cref="T:Roblox.Platform.Membership.AgeBracket" />.</param>
	/// <param name="newAgeBracket">The new <see cref="T:Roblox.Platform.Membership.AgeBracket" />.</param>
	/// <param name="automaticAgeUp">Whether or not the age up was automatic.</param>
	void Publish(IUser user, AgeBracket previousAgeBracket, AgeBracket newAgeBracket, bool automaticAgeUp);
}
