using System;
using System.Threading.Tasks;

namespace Roblox.Coordination;

public abstract class BackgroundWorker : IBackgroundWorker
{
	private readonly object _Sync = new object();

	public bool IsRunning { get; private set; }

	public event Action<BackgroundWorker, EventArgs> Started;

	public event Action<BackgroundWorker, EventArgs> Stopped;

	public event Action<BackgroundWorker, EventArgs> Working;

	public event Action<BackgroundWorker, EventArgs> Worked;

	protected abstract void DoWork();

	protected virtual void HandleException(Exception exception)
	{
	}

	public virtual void Start()
	{
		if (IsRunning)
		{
			return;
		}
		lock (_Sync)
		{
			if (IsRunning)
			{
				return;
			}
			IsRunning = true;
		}
		Task.Factory.StartNew(Run, TaskCreationOptions.LongRunning);
	}

	public virtual void Stop()
	{
		if (!IsRunning)
		{
			return;
		}
		lock (_Sync)
		{
			if (IsRunning)
			{
				IsRunning = false;
			}
		}
	}

	private void Run()
	{
		this.Started?.Invoke(this, EventArgs.Empty);
		while (IsRunning)
		{
			try
			{
				this.Working?.Invoke(this, EventArgs.Empty);
				DoWork();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
			finally
			{
				this.Worked?.Invoke(this, EventArgs.Empty);
			}
		}
		this.Stopped?.Invoke(this, EventArgs.Empty);
	}
}
