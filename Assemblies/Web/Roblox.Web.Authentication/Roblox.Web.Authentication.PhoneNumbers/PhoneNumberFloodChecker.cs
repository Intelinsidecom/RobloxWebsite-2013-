using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Demographics;

namespace Roblox.Web.Authentication.PhoneNumbers;

public class PhoneNumberFloodChecker : IPhoneNumberFloodChecker
{
	private readonly IAccountPhoneNumber _AccountPhoneNumber;

	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ILogger _Logger;

	private readonly string _Operation;

	private readonly int _Limit;

	private readonly TimeSpan _WindowPeriod;

	public PhoneNumberFloodChecker(IAccountPhoneNumber accountPhoneNumber, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, string operation, int? limit, TimeSpan? windowPeriod, ILogger logger)
	{
		_AccountPhoneNumber = accountPhoneNumber ?? throw new ArgumentNullException("accountPhoneNumber");
		_FloodCheckerFactory = floodCheckerFactory ?? throw new ArgumentNullException("floodCheckerFactory");
		_Operation = operation ?? throw new ArgumentNullException("operation");
		_Limit = limit ?? throw new ArgumentNullException("limit");
		_WindowPeriod = windowPeriod ?? throw new ArgumentNullException("windowPeriod");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public bool IsFlooded()
	{
		IFloodChecker accountPhoneNumberFloodChecker = GetAccountPhoneNumberFloodChecker(_AccountPhoneNumber.Id);
		if (accountPhoneNumberFloodChecker.IsFlooded())
		{
			return true;
		}
		accountPhoneNumberFloodChecker.UpdateCount();
		return false;
	}

	internal virtual IFloodChecker GetAccountPhoneNumberFloodChecker(int accountPhoneNumberId)
	{
		return _FloodCheckerFactory.GetFloodChecker(null, $"{_Operation}AccountPhoneNumberFloodChecker:{accountPhoneNumberId}", () => _Limit, () => _WindowPeriod, () => true, () => false, _Logger);
	}
}
