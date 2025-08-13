namespace Roblox.Platform.Marketing;

public static class FactoryProvider
{
	private static IBrowserTrackerFactory _browserTrackerFactory = new BrowserTrackerFactory();

	private static RandomNumberFactory _randomNumberFactory = new RandomNumberFactory();

	public static IBrowserTrackerFactory BrowserTrackerFactory
	{
		get
		{
			return _browserTrackerFactory;
		}
		set
		{
			_browserTrackerFactory = value;
		}
	}

	public static RandomNumberFactory RandomNumberFactory => _randomNumberFactory;
}
