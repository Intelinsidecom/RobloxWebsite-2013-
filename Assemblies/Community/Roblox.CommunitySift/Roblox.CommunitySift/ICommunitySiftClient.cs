namespace Roblox.CommunitySift;

/// <summary>
/// Defines methods for CommunitySift API calls
/// </summary>
public interface ICommunitySiftClient
{
	/// <summary>
	/// Post a short piece of text to CommunitySift.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.CommunitySift.ICommunitySiftChatRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftChatFilterResult" /> containing the filter result.</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	ICommunitySiftChatFilterResult PostChat(ICommunitySiftChatRequest request);

	/// <summary>
	/// Post a long piece of text to CommunitySift.
	/// Generally 1000+ characters or 2000 bytes.
	/// This text will not be added to the user context which means that it won't have vertical filtering applied.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.CommunitySift.ICommunitySiftLongTextRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftChatFilterResult" /> containing the filter result.</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	ICommunitySiftLongTextFilterResult PostLongText(ICommunitySiftLongTextRequest request);

	/// <summary>
	/// Post a short piece of text to CommunitySift.
	/// This text will not be added to the user context which means that it won't have vertical filtering applied.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.CommunitySift.ICommunitySiftChatRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftChatFilterResult" /> containing the filter result.</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	ICommunitySiftChatFilterNoContextResult PostChatNoContext(ICommunitySiftChatNoContextRequest request);

	/// <summary>
	/// Post a piece of chat as both under and over 13 in a single call.
	/// </summary>
	/// <param name="request">An <see cref="T:Roblox.CommunitySift.ICommunitySiftDoubleChatRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftDoubleChatFilterResult" /> containing the results for both age categories.</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	ICommunitySiftDoubleChatFilterResult PostDoubleChat(ICommunitySiftDoubleChatRequest request);

	/// <summary>
	/// Post a the given UserName and check its validity for both over and under 13.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.CommunitySift.ICommunitySiftUserNameRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftUserNameRequest" /> containing the results for both age categories</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	ICommunitySiftUserNameFilterResult PostUserName(ICommunitySiftUserNameRequest request);
}
