using System;

namespace Roblox.Coordination;

/// <summary>
/// An object implementing this interface will perform work in the background.
/// The Start() and Stop() are using to control that work-flow.
/// </summary>
public interface IBackgroundWorker
{
	/// <summary>
	/// Has the Start() method been called without the Stop() method being called?
	/// </summary>
	bool IsRunning { get; }

	/// <summary>
	/// The background thread has started doing work.
	/// </summary>
	event Action<BackgroundWorker, EventArgs> Started;

	/// <summary>
	/// The background thread has completed work.
	/// </summary>
	event Action<BackgroundWorker, EventArgs> Stopped;

	/// <summary>
	/// The worker is running and DoWork has completed.
	/// </summary>
	event Action<BackgroundWorker, EventArgs> Worked;

	/// <summary>
	/// The worker is running and DoWork is about to be called.
	/// </summary>
	event Action<BackgroundWorker, EventArgs> Working;

	/// <summary>
	/// Starts the worker
	/// </summary>
	void Start();

	/// <summary>
	/// Stops the worker
	/// </summary>
	void Stop();
}
