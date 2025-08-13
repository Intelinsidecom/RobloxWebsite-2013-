namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Arguments class for <see cref="T:Roblox.Platform.EventStream.WebEvents.VoteEvent" />
/// </summary>
public class VoteEventArgs : WebEventArgs
{
	/// <summary>
	/// Asset Id which is being voted.
	/// </summary>
	public long? AssetId { get; set; }

	/// <summary>
	/// Asset type.
	/// </summary>
	public string AssetType { get; set; }

	/// <summary>
	/// Voter's user Id.
	/// </summary>
	public long? VoterId { get; set; }

	/// <summary>
	/// Voter's type. It's User when the voter is a user.
	/// </summary>
	public string VoterType { get; set; }

	/// <summary>
	/// Vote action. It is null when user is removing his/her vote. It is true or false when user is upvoting or downvoting respectively.
	/// </summary>
	public bool? Vote { get; set; }

	/// <summary>
	/// Indicate whether the asset is voteable by the voter (user).
	/// </summary>
	public bool? CanVote { get; set; }

	/// <summary>
	/// Indicate the reason when user cannot vote.
	/// </summary>
	public string ReasonForNotVoteable { get; set; }

	/// <summary>
	/// Indicate whehter the user is a paid user.
	/// </summary>
	public bool? IsPayingUser { get; set; }

	/// <summary>
	/// The device type which is used by the user when voting.
	/// </summary>
	public string DeviceType { get; set; }

	/// <summary>
	/// Indicate whether the voting is successful.
	/// </summary>
	public bool? Success { get; set; }

	/// <summary>
	/// The upvote count after the user's vote.
	/// </summary>
	public long? UpVoteCount { get; set; }

	/// <summary>
	/// The downvote count after the user's vote.
	/// </summary>
	public long? DownVoteCount { get; set; }
}
