namespace Roblox;

public interface IParallelWorkTask
{
	string UniqueId { get; }

	void ProcessTaskAndMarkComplete();
}
