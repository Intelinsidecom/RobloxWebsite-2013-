using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Demographics;

namespace Roblox.Web.Authentication.PhoneNumbers;

public class PhoneNumberFloodCheckerFactory : IPhoneNumberFloodCheckerFactory
{
	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ILogger _Logger;

	private readonly string _Global = "Global";

	public PhoneNumberFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ILogger logger)
	{
		_FloodCheckerFactory = floodCheckerFactory ?? throw new ArgumentNullException("floodCheckerFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public IPhoneNumberFloodChecker GetPhoneNumberFloodChecker(IAccountPhoneNumber accountPhoneNumber, string operation, int? limit, TimeSpan windowPeriod)
	{
		return new PhoneNumberFloodChecker(accountPhoneNumber, _FloodCheckerFactory, operation, limit, windowPeriod, _Logger);
	}

	public IPhoneNumberFloodChecker GetGlobalPhoneNumberFloodChecker(IAccountPhoneNumber accountPhoneNumber, int? limit, TimeSpan windowPeriod)
	{
		return new PhoneNumberFloodChecker(accountPhoneNumber, _FloodCheckerFactory, _Global, limit, windowPeriod, _Logger);
	}
}
