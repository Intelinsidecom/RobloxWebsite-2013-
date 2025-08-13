namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// When user is upvoting/downvoting or removing his/her vote for an asset, we can publish this event to EventStream.
/// </summary>
public class VoteEvent : WebEventBase
{
	private const string _Name = "vote";

	/// <summary>
	/// The event that represents voting an asset.
	/// </summary>
	public VoteEvent(EventStreamer streamer, VoteEventArgs eventArgs)
		: base(streamer, "vote", eventArgs)
	{
		if (eventArgs.AssetId.HasValue)
		{
			AddEventArg("assetId", eventArgs.AssetId.ToString());
		}
		if (!string.IsNullOrWhiteSpace(eventArgs.AssetType))
		{
			AddEventArg("assetType", eventArgs.AssetType);
		}
		if (eventArgs.VoterId.HasValue)
		{
			AddEventArg("voterId", eventArgs.VoterId.ToString());
		}
		if (!string.IsNullOrWhiteSpace(eventArgs.VoterType))
		{
			AddEventArg("voterType", eventArgs.VoterType);
		}
		AddEventArg("vote", (!eventArgs.Vote.HasValue) ? "RemoveVote" : (eventArgs.Vote.Value ? "UpVote" : "DownVote"));
		if (eventArgs.IsPayingUser.HasValue)
		{
			AddEventArg("isPayingUser", eventArgs.IsPayingUser.ToString());
		}
		if (!string.IsNullOrWhiteSpace(eventArgs.DeviceType))
		{
			AddEventArg("deviceType", eventArgs.DeviceType);
		}
		if (eventArgs.CanVote.HasValue)
		{
			AddEventArg("canVote", eventArgs.CanVote.ToString());
		}
		if (!string.IsNullOrWhiteSpace(eventArgs.ReasonForNotVoteable))
		{
			AddEventArg("reasonForNotVoteable", eventArgs.ReasonForNotVoteable);
		}
		if (eventArgs.Success.HasValue)
		{
			AddEventArg("success", eventArgs.Success.ToString());
		}
		if (eventArgs.UpVoteCount.HasValue)
		{
			AddEventArg("upVoteCount", eventArgs.UpVoteCount.ToString());
		}
		if (eventArgs.DownVoteCount.HasValue)
		{
			AddEventArg("downVoteCount", eventArgs.DownVoteCount.ToString());
		}
	}
}
