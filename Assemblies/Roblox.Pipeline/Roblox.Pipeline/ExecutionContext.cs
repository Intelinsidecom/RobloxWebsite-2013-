namespace Roblox.Pipeline;

internal class ExecutionContext<TInput, TOutput> : IExecutionContext<TInput, TOutput>
{
	public TInput Input { get; set; }

	public TOutput Output { get; set; }

	public ExecutionContext(TInput input)
	{
		Input = input;
	}
}
