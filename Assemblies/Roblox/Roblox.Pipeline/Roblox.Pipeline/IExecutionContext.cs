namespace Roblox.Pipeline;

public interface IExecutionContext<TInput, TOutput>
{
	TInput Input { get; set; }

	TOutput Output { get; set; }
}
