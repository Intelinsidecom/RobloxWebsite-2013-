using System.Runtime.Serialization;

namespace Roblox.Platform.Membership.Events;

[DataContract]
public class AccountAgeChangeMessage
{
	/// <summary>
	/// UserId of the user whose age has changed.
	/// </summary>
	[DataMember(Name = "userId")]
	public long UserId { get; private set; }

	/// <summary>
	/// The user's new age bracket.
	/// </summary>
	[DataMember(Name = "newAge")]
	public AgeBracket NewAge { get; private set; }

	/// <summary>
	/// The user's previous age bracket.
	/// </summary>
	[DataMember(Name = "previousAge")]
	public AgeBracket PreviousAge { get; private set; }

	/// <summary>
	/// Whether or not the message is a result of automatically aging up from <see cref="F:Roblox.Platform.Membership.AgeBracket.AgeUnder13" /> -&gt; <see cref="F:Roblox.Platform.Membership.AgeBracket.Age13OrOver" />.
	/// </summary>
	[DataMember(Name = "automaticAgeUp")]
	public bool AutomaticAgeUp { get; private set; }

	public AccountAgeChangeMessage(long userId, AgeBracket newAge, AgeBracket previousAge, bool automaticAgeUp)
	{
		UserId = userId;
		NewAge = newAge;
		PreviousAge = previousAge;
		AutomaticAgeUp = automaticAgeUp;
	}
}
