using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

public class EligibilityCheckerRegistry : IEligibilityCheckerRegistry
{
	private static readonly EligibilityCheckerRegistry _Instance = new EligibilityCheckerRegistry();

	private readonly IDictionary<string, IEligibilityCheckerFactory> _Registry = new Dictionary<string, IEligibilityCheckerFactory>();

	/// <summary>
	/// Gets the static instance of an <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCheckerRegistry" />.
	/// </summary>
	public static EligibilityCheckerRegistry Instance => _Instance;

	public void Register(string eligibilityCheckerName, IEligibilityCheckerFactory factory)
	{
		if (eligibilityCheckerName == null)
		{
			throw new PlatformArgumentNullException("eligibilityCheckerName");
		}
		if (factory == null)
		{
			throw new PlatformArgumentNullException("factory");
		}
		if (_Registry.ContainsKey(eligibilityCheckerName))
		{
			throw new PlatformInvalidOperationException();
		}
		_Registry.Add(eligibilityCheckerName, factory);
	}

	public IEligibilityChecker Construct(string eligibilityCheckerName)
	{
		if (eligibilityCheckerName == null)
		{
			throw new PlatformArgumentNullException("eligibilityCheckerName");
		}
		if (_Registry.ContainsKey(eligibilityCheckerName))
		{
			return _Registry[eligibilityCheckerName].ConstructByName(eligibilityCheckerName);
		}
		return null;
	}
}
