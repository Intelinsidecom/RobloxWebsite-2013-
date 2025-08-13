namespace Roblox.Platform.Moderation;

/// <summary>
/// Used for determine which type of queue the moderation task belongs to.
/// </summary>
public enum ModerationTaskType : byte
{
	AbuseReport = 1,
	Punishment,
	ImageReview,
	VideoReview,
	AudioReview,
	MeshReview
}
