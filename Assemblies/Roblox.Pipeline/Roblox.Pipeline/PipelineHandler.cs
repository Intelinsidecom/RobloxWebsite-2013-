using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Pipeline;

public abstract class PipelineHandler<TInput, TOutput> : IPipelineHandler<TInput, TOutput>
{
	[ExcludeFromCodeCoverage]
	public virtual IPipelineHandler<TInput, TOutput> NextHandler { get; set; }

	public virtual void Invoke(IExecutionContext<TInput, TOutput> context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		NextHandler?.Invoke(context);
	}

	public virtual Task InvokeAsync(IExecutionContext<TInput, TOutput> context, CancellationToken cancellationToken)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (NextHandler == null)
		{
			return Task.CompletedTask;
		}
		return NextHandler.InvokeAsync(context, cancellationToken);
	}
}
