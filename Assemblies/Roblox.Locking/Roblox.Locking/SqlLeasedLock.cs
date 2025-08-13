using System;

namespace Roblox.Locking;

public sealed class SqlLeasedLock : ISqlLeasedLock, ILeasedLock, IDisposable
{
	private readonly LeasedLock _LeasedLock;

	private readonly Guid _LockRequester;

	private readonly Action<Exception> _ExceptionHandler;

	public bool IsLockAcquired { get; }

	public SqlLeasedLock(string lockKey, Guid lockRequester, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null)
	{
		_LockRequester = lockRequester;
		_ExceptionHandler = exceptionHandler;
		_LeasedLock = LeasedLock.GetOrCreate(lockKey);
		IsLockAcquired = _LeasedLock.TryAcquire(_LockRequester, (int)leaseDuration.TotalMilliseconds);
	}

	public bool TryRenew(TimeSpan leaseDuration)
	{
		return _LeasedLock.TryRenew(_LockRequester, (int)leaseDuration.TotalMilliseconds);
	}

	public void Dispose()
	{
		try
		{
			if (IsLockAcquired)
			{
				_LeasedLock.TryRelease(_LockRequester);
			}
		}
		catch (Exception obj)
		{
			try
			{
				_ExceptionHandler?.Invoke(obj);
			}
			catch
			{
			}
		}
	}

	public void ForceDispose()
	{
		try
		{
			_LeasedLock.TryRelease(_LockRequester);
		}
		catch (Exception obj)
		{
			try
			{
				_ExceptionHandler?.Invoke(obj);
			}
			catch
			{
			}
		}
	}
}
