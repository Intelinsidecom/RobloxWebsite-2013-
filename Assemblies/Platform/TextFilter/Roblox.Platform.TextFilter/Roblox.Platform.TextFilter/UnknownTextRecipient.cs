namespace Roblox.Platform.TextFilter {
    /// <summary>

/// Default implementation of <see cref="T:Roblox.Platform.TextFilter.ITextRecipient" /> specifically for the case of an unkown user.
/// By default this user will be under 13.
/// </summary>
public class UnknownTextRecipient : ITextRecipient
{
	public bool IsUnder13 => true;
}


}
