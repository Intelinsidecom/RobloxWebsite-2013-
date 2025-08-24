using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class MessagePersistenceException : PlatformException
{
	public MessagePersistenceException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
