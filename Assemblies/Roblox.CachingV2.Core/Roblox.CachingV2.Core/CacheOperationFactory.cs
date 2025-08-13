using System;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

public class CacheOperationFactory : ICacheOperationFactory
{
	private readonly IDeleteAroundOperation _DeleteAroundOperation;

	private readonly IReadThroughWithCreationOperation _ReadThroughWithCreationOperation;

	private readonly IReadAroundWithCreationOperation _ReadAroundWithCreationOperation;

	private readonly IReadAroundOperation _ReadAroundOperation;

	private readonly IReadThroughOperation _ReadThroughOperation;

	private readonly IWriteAroundOperation _WriteAroundOperation;

	private readonly IWriteThroughOperation _WriteThroughOperation;

	public CacheOperationFactory(ILogger logger)
	{
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		_DeleteAroundOperation = new DeleteAroundOperation(logger);
		_ReadThroughWithCreationOperation = new ReadThroughWithCreationOperation(logger);
		_ReadAroundWithCreationOperation = new ReadAroundWithCreationOperation(logger);
		_ReadAroundOperation = new ReadAroundOperation(logger);
		_ReadThroughOperation = new ReadThroughOperation(logger);
		_WriteAroundOperation = new WriteAroundOperation(logger);
		_WriteThroughOperation = new WriteThroughOperation(logger);
	}

	public IDeleteAroundOperation GetDeleteAroundOperation()
	{
		return _DeleteAroundOperation;
	}

	public IReadThroughWithCreationOperation GetReadThroughWithCreationOperation()
	{
		return _ReadThroughWithCreationOperation;
	}

	public IReadAroundWithCreationOperation GetReadAroundWithCreationOperation()
	{
		return _ReadAroundWithCreationOperation;
	}

	public IReadAroundOperation GetReadAroundOperation()
	{
		return _ReadAroundOperation;
	}

	public IReadThroughOperation GetReadThroughOperation()
	{
		return _ReadThroughOperation;
	}

	public IWriteAroundOperation GetWriteAroundOperation()
	{
		return _WriteAroundOperation;
	}

	public IWriteThroughOperation GetWriteThroughOperation()
	{
		return _WriteThroughOperation;
	}
}
