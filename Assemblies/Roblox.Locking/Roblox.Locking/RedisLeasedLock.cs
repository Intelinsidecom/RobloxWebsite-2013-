using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.LeasedLocks.Client;
using Roblox.Locking.Properties;

namespace Roblox.Locking;

public class RedisLeasedLock : IRedisLeasedLock, ILeasedLock, IDisposable
{
	private static readonly ILeasedLocksClient _LeasedLocksClient = new LeasedLocksClient(() => Settings.Default.LeasedLocksServiceApiKeyShim);

	private readonly Action<Exception> _ExceptionHandler;

	private readonly string _LockKey;

	private readonly TimeSpan _LeaseDuration;

	private readonly Guid _LockGuid;

	public bool IsLockAcquired { get; private set; }

	public RedisLeasedLock(string lockKey, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null)
	{
		_LockKey = lockKey;
		_LeaseDuration = leaseDuration;
		_ExceptionHandler = exceptionHandler;
		_LockGuid = Guid.NewGuid();
	}

	public bool TryAcquire()
	{
		try
		{
			bool flag = _LeasedLocksClient.TryAcquire(LeasedLockType.Redis, _LockKey, _LockGuid, _LeaseDuration);
			IsLockAcquired = flag || IsLockAcquired;
			return flag;
		}
		catch (Exception obj)
		{
			_ExceptionHandler?.Invoke(obj);
			return false;
		}
	}

	public async Task<bool> TryAcquireAsync(CancellationToken token)
	{
		try
		{
			bool flag = await _LeasedLocksClient.TryAcquireAsync(LeasedLockType.Redis, _LockKey, _LockGuid, _LeaseDuration, token).ConfigureAwait(continueOnCapturedContext: false);
			IsLockAcquired = flag || IsLockAcquired;
			return flag;
		}
		catch (Exception obj)
		{
			_ExceptionHandler?.Invoke(obj);
			return false;
		}
	}

	public void Dispose()
	{
		try
		{
			_LeasedLocksClient.TryRelease(LeasedLockType.Redis, _LockKey, _LockGuid);
		}
		catch (Exception obj)
		{
			_ExceptionHandler?.Invoke(obj);
		}
	}
}
