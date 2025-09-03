namespace Roblox.Platform.TextFilter {
    /// <summary>

/// Default implementation of <see cref="T:Roblox.Platform.TextFilter.ITextAuthor" /> specifically for an unknown user.
/// By default this user will be under 13 and with a distinct ID.
/// </summary>
public class UnknownTextAuthor : ITextAuthor
{
	/// <summary>
	/// See <see cref="T:Roblox.Platform.TextFilter.ITextAuthor" />. 
	/// Default value of -1.
	/// </summary>
	public long Id => -1L;

	/// <summary>
	/// See <see cref="T:Roblox.Platform.TextFilter.ITextAuthor" />. 
	/// Default value of "unknown".
	/// </summary>
	public string Name => "unknown";

	/// <summary>
	/// See <see cref="T:Roblox.Platform.TextFilter.ITextAuthor" />. 
	/// Defaults to true, unknown people are assumed to be children.
	/// </summary>
	public bool IsUnder13 => true;
}


}
