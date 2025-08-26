using System;
namespace Roblox.Localization.Accountspublic {
    class DuplicateKeyException : InvalidOperationException

{
	public DuplicateKeyException()
	{
	}

	public DuplicateKeyException(string message)
		: base(message)
	{
	}

	public DuplicateKeyException(string message, Exception exception)
		: base(message, exception)
	{
	}
}


}
