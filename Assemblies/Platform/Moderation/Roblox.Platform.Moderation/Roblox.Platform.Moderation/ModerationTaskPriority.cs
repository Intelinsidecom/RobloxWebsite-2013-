namespace Roblox.Platform.Moderation;

/// <summary>
/// Used for determine which priority queue the moderation task should be enqueued.
/// </summary>
public enum ModerationTaskPriority : byte
{
	Low = 1,
	Medium,
	High
}
