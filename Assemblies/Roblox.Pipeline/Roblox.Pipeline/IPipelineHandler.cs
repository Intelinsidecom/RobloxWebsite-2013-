using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Pipeline;

public interface IPipelineHandler<TInput, TOutput>
{
	IPipelineHandler<TInput, TOutput> NextHandler { get; set; }

	void Invoke(IExecutionContext<TInput, TOutput> context);

	Task InvokeAsync(IExecutionContext<TInput, TOutput> context, CancellationToken cancellationToken);
}
