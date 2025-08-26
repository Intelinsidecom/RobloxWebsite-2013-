using System;
namespace Roblox.Moderationpublic {
    class BadMessageException : Exception

{
	public BadMessageException(string message)
		: base(message)
	{
	}

	public BadMessageException(string message, Exception e)
		: base(message, e)
	{
	}
}


}
