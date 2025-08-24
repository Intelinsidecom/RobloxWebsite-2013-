namespace Roblox.TextFilter;

/// <summary>
/// How much redaction was applied?
/// </summary>
public enum ModerationLevel
{
	/// <summary>
	/// Text was processed with no redaction.
	/// </summary>
	FullyAcceptable = 1,
	/// <summary>
	/// Text was processed with partial redaction.
	/// </summary>
	PartiallyModerated,
	/// <summary>
	/// Text was completely redacted.
	/// </summary>
	FullyModerated
}
