using System;
using Roblox.Platform.Demographics;

namespace Roblox.Web.Authentication.PhoneNumbers;

public interface IPhoneNumberFloodCheckerFactory
{
	IPhoneNumberFloodChecker GetPhoneNumberFloodChecker(IAccountPhoneNumber accountPhoneNumber, string operation, int? limit, TimeSpan windowPeriod);

	IPhoneNumberFloodChecker GetGlobalPhoneNumberFloodChecker(IAccountPhoneNumber accountPhoneNumber, int? limit, TimeSpan windowPeriod);
}
