using System;
using System.Collections.Generic;
using System.Threading;

namespace Roblox;

/// <summary>
/// Used by background threads to know when to terminate.
/// This class listens for the ProcessExit event to help
/// background threads exit gracefully (rather than being
/// interrupted by ThreadAbortExceptions)
/// </summary>
public class BackgroundThreadHelper
{
	/// <summary>
	/// A disposable object used in conjunction with AddEvent
	/// </summary>
	public class Handle : IDisposable
	{
		private EventWaitHandle eventWaitHandle;

		internal Handle(EventWaitHandle eventWaitHandle)
		{
			this.eventWaitHandle = eventWaitHandle;
			lock (waitHandles)
			{
				waitHandles.Add(eventWaitHandle);
			}
		}

		public void Dispose()
		{
			lock (waitHandles)
			{
				waitHandles.Remove(eventWaitHandle);
			}
		}

		public void Set()
		{
			eventWaitHandle.Set();
		}
	}

	public delegate void F();

	private static bool done;

	private static readonly EventWaitHandle doneHandle;

	private static readonly List<EventWaitHandle> waitHandles;

	/// <summary>
	/// Returns true if the thread should exit
	/// </summary>
	public static bool IsDone => done;

	static BackgroundThreadHelper()
	{
		done = false;
		doneHandle = new EventWaitHandle(initialState: false, EventResetMode.ManualReset);
		waitHandles = new List<EventWaitHandle>();
		AppDomain.CurrentDomain.DomainUnload += CurrentDomain_DomainUnload;
	}

	private static void CurrentDomain_DomainUnload(object sender, EventArgs e)
	{
		EventWaitHandle[] temp;
		lock (waitHandles)
		{
			temp = new EventWaitHandle[waitHandles.Count];
			waitHandles.CopyTo(temp);
		}
		done = true;
		doneHandle.Set();
		EventWaitHandle[] array = temp;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Set();
		}
	}

	/// <summary>
	/// Returns true if the thread should exit
	/// </summary>
	public static bool Wait(TimeSpan span)
	{
		return doneHandle.WaitOne(span, exitContext: false);
	}

	/// <summary>
	/// Returns true if the thread should exit
	/// </summary>
	public static bool Wait(TimeSpan span, bool exitContext)
	{
		return doneHandle.WaitOne(span, exitContext);
	}

	/// <summary>
	/// Convenience function that runs "f" every 
	/// </summary>
	/// <param name="sleepTime"></param>
	/// <param name="f">The function to run</param>
	/// <returns>A handle you can set to end this background thread</returns>
	public static Thread RunInBackground(TimeSpan sleepTime, F f)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			while (true)
			{
				try
				{
					Thread.Sleep(sleepTime);
					f();
				}
				catch (ThreadInterruptedException)
				{
					break;
				}
				catch (ThreadAbortException)
				{
					break;
				}
				catch (Exception ex3)
				{
					ExceptionHandler.LogException(ex3);
				}
			}
		});
		thread.IsBackground = true;
		thread.Start();
		return thread;
	}

	/// <summary>
	/// Add an event that should be Set when the process exits.
	/// Be sure to Dispose the returned object in order to remove the EventWaitHandle
	/// when you are done.
	/// </summary>
	public static Handle SetOnProcessExit(EventWaitHandle eventWaitHandle)
	{
		return new Handle(eventWaitHandle);
	}
}
