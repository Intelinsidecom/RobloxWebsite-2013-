using System.Diagnostics.CodeAnalysis;

namespace Roblox.CommunitySift;

/// <summary>
/// Default implementation of <see cref="T:Roblox.CommunitySift.ICommunitySiftUserNameRequest" />.
/// </summary>
[ExcludeFromCodeCoverage]
public class CommunitySiftUserNameRequest : ICommunitySiftUserNameRequest
{
	/// <inheritdoc cref="P:Roblox.CommunitySift.ICommunitySiftUserNameRequest.Text" />
	public string Text { get; }

	/// <inheritdoc cref="P:Roblox.CommunitySift.ICommunitySiftUserNameRequest.UserId" />
	public string UserId { get; }

	/// <inheritdoc cref="P:Roblox.CommunitySift.ICommunitySiftUserNameRequest.IsUnder13" />
	public bool IsUnder13 { get; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="text"></param>
	/// <param name="userId"></param>
	/// <param name="isUnder13"></param>
	public CommunitySiftUserNameRequest(string text, string userId, bool isUnder13)
	{
		Text = text;
		UserId = userId;
		IsUnder13 = isUnder13;
	}
}
