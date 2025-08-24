using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Pipeline;

public interface IExecutionPlan<TInput, TOutput>
{
	IReadOnlyCollection<IPipelineHandler<TInput, TOutput>> Handlers { get; }

	void RemoveHandler(int index);

	void RemoveHandler<T>() where T : IPipelineHandler<TInput, TOutput>;

	void AppendHandler(IPipelineHandler<TInput, TOutput> handler);

	void PrependHandler(IPipelineHandler<TInput, TOutput> handler);

	void AddHandlerAfter<T>(IPipelineHandler<TInput, TOutput> handler) where T : IPipelineHandler<TInput, TOutput>;

	void AddHandlerBefore<T>(IPipelineHandler<TInput, TOutput> handler) where T : IPipelineHandler<TInput, TOutput>;

	void InsertHandler(int index, IPipelineHandler<TInput, TOutput> handler);

	void ClearHandlers();

	TOutput Execute(TInput input);

	Task<TOutput> ExecuteAsync(TInput input, CancellationToken cancellationToken);
}
