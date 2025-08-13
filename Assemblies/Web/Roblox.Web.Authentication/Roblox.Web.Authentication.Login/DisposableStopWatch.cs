using System;
using System.Diagnostics;

namespace Roblox.Web.Authentication.Login;

/// <summary>
/// This is here only temporary to mesure user sign in operation time.
/// </summary>
internal class DisposableStopWatch : IDisposable
{
	private readonly Stopwatch _Stopwatch;

	private readonly Action<Stopwatch> _Action;

	private readonly bool _Enabled;

	public Stopwatch Watch => _Stopwatch;

	public DisposableStopWatch(bool enabled = true, Action<Stopwatch> action = null)
	{
		_Enabled = enabled;
		if (_Enabled)
		{
			_Action = action ?? ((Action<Stopwatch>)delegate
			{
			});
			_Stopwatch = new Stopwatch();
			_Stopwatch.Start();
		}
	}

	public void Dispose()
	{
		if (_Enabled)
		{
			_Stopwatch.Stop();
			_Action(_Stopwatch);
		}
	}
}
