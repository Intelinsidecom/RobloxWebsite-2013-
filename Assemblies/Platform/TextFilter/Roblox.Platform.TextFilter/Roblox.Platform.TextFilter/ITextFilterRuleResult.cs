namespace Roblox.TextFilter;

/// <summary>
/// An interface that contains details about the filtered text.
/// </summary>
/// <seealso cref="T:Roblox.TextFilter.ITextFilterResultModerationDetails" />
public interface ITextFilterRuleResult : ITextFilterResultModerationDetails
{
	/// <summary>
	/// Gets the filtered text.
	/// </summary>
	/// <value>
	/// The filtered text.
	/// </value>
	string FilteredText { get; }
}
