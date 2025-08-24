using System;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class ChatEventMessageSourceWrapper : IChatEventMessageSource
{
	private readonly Func<ChatMessageSourceType> _SourceTypeGetter;

	private readonly Func<long> _SourceUserIdGetter;

	public ChatMessageSourceType SourceType => _SourceTypeGetter();

	public long SourceUserId => _SourceUserIdGetter();

	public ChatEventMessageSourceWrapper(Func<ChatMessageSourceType> sourceTypeGetter, Func<long> sourceUserIdGetter)
	{
		_SourceTypeGetter = sourceTypeGetter ?? throw new PlatformArgumentNullException("sourceTypeGetter");
		_SourceUserIdGetter = sourceUserIdGetter ?? throw new PlatformArgumentNullException("sourceUserIdGetter");
	}
}
