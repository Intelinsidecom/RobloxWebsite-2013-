using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Pipeline;

public class ExecutionPlan<TInput, TOutput> : IExecutionPlan<TInput, TOutput>
{
	private readonly IList<IPipelineHandler<TInput, TOutput>> _Handlers = new List<IPipelineHandler<TInput, TOutput>>();

	public IReadOnlyCollection<IPipelineHandler<TInput, TOutput>> Handlers => (IReadOnlyCollection<IPipelineHandler<TInput, TOutput>>)(object)_Handlers.ToArray();

	public void RemoveHandler(int index)
	{
		if (index >= _Handlers.Count || index < 0)
		{
			throw new ArgumentException(string.Format("{0} does not exist in handlers.", "index"), "index");
		}
		IPipelineHandler<TInput, TOutput> pipelineHandler = _Handlers[index];
		if (index > 0)
		{
			_Handlers[index - 1].NextHandler = pipelineHandler.NextHandler;
		}
		_Handlers.Remove(pipelineHandler);
	}

	public void RemoveHandler<T>() where T : IPipelineHandler<TInput, TOutput>
	{
		int handlerIndex = GetHandlerIndex<T>();
		if (handlerIndex < 0)
		{
			throw new ArgumentException($"No handler of type {typeof(T)} was found.", "T");
		}
		RemoveHandler(handlerIndex);
	}

	public void InsertHandler(int index, IPipelineHandler<TInput, TOutput> handler)
	{
		if (index < 0 || index > _Handlers.Count)
		{
			throw new ArgumentException(string.Format("{0} is not valid to add to in handlers. Index must be between 0, and the current handlers count.", "index"), "index");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (_Handlers.Contains(handler))
		{
			throw new ArgumentException(string.Format("{0} is already part of the execution plan. The same instance may only be used in one execution plan once at a time.", "handler"), "handler");
		}
		if (index > 0)
		{
			_Handlers[index - 1].NextHandler = handler;
		}
		if (index < _Handlers.Count)
		{
			handler.NextHandler = _Handlers[index];
		}
		_Handlers.Insert(index, handler);
	}

	public void AppendHandler(IPipelineHandler<TInput, TOutput> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		InsertHandler(_Handlers.Count, handler);
	}

	public void PrependHandler(IPipelineHandler<TInput, TOutput> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		InsertHandler(0, handler);
	}

	public void AddHandlerAfter<T>(IPipelineHandler<TInput, TOutput> handler) where T : IPipelineHandler<TInput, TOutput>
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		int handlerIndex = GetHandlerIndex<T>();
		if (handlerIndex < 0)
		{
			throw new ArgumentException($"No handler of type {typeof(T)} was found.", "T");
		}
		InsertHandler(handlerIndex + 1, handler);
	}

	public void AddHandlerBefore<T>(IPipelineHandler<TInput, TOutput> handler) where T : IPipelineHandler<TInput, TOutput>
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		int handlerIndex = GetHandlerIndex<T>();
		if (handlerIndex < 0)
		{
			throw new ArgumentException($"No handler of type {typeof(T)} was found.", "T");
		}
		InsertHandler(handlerIndex, handler);
	}

	public void ClearHandlers()
	{
		_Handlers.Clear();
	}

	public TOutput Execute(TInput input)
	{
		if (!_Handlers.Any())
		{
			throw new NoHandlersException();
		}
		ExecutionContext<TInput, TOutput> executionContext = new ExecutionContext<TInput, TOutput>(input);
		_Handlers.First().Invoke(executionContext);
		return executionContext.Output;
	}

	public async Task<TOutput> ExecuteAsync(TInput input, CancellationToken cancellationToken)
	{
		if (!_Handlers.Any())
		{
			throw new NoHandlersException();
		}
		ExecutionContext<TInput, TOutput> executionContext = new ExecutionContext<TInput, TOutput>(input);
		await _Handlers.First().InvokeAsync(executionContext, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return executionContext.Output;
	}

	private int GetHandlerIndex<T>()
	{
		for (int i = 0; i < _Handlers.Count; i++)
		{
			if (_Handlers[i] is T)
			{
				return i;
			}
		}
		return -1;
	}
}
