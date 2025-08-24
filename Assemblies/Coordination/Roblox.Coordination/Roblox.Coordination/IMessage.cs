namespace Roblox.Coordination;

public interface IMessage
{
	string Message { get; }

	void OnCompleted();
}
