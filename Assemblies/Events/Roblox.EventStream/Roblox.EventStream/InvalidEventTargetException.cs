using System;
namespace Roblox.EventStream {
    class InvalidEventTargetException : Exception

{
	private string _Message;

	public InvalidEventTargetException(string message)
	{
		_Message = message;
	}
}


}
