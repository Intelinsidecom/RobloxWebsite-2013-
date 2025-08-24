using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

public class DuplicateAccoutrementInsertException : PlatformException
{
	internal DuplicateAccoutrementInsertException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
