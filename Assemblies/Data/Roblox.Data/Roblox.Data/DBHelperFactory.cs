namespace Roblox.Data;

public class DBHelperFactory
{
	private static bool _TestMode;

	private static IDBHelperFactory _TestFactory;

	public static DbHelper GetDBHelper(string connectionString)
	{
		if (!_TestMode)
		{
			return new DbHelper(connectionString);
		}
		return _TestFactory.GetDBHelper(connectionString);
	}

	public static void SetTestFactory(IDBHelperFactory testFactoryArg)
	{
		_TestMode = true;
		_TestFactory = testFactoryArg;
	}
}
