using System;

namespace Roblox.BriteVerify;

internal interface IBriteVerifyPerformanceMonitor
{
	void Increment(TimeSpan requestTime);

	void IncrementException(object request, TimeSpan requestTime, Exception ex);

	void IncrementResponseIsValidEmail();

	void IncrementResponseIsInvalidEmail();

	void IncrementResponseIsUnknownEmail();

	void IncrementResponseIsAcceptAllEmail();

	void IncrementResponseCannotValidate();

	void IncrementResponseIsDisposableEmail();

	void IncrementResponseIsRoleAddressEmail();

	void IncrementResponseIsInvalidEmailFormat();

	void IncrementResponseIsInvalidEmailDomain();

	void IncrementResponseIsInvalidEmailAccount();
}
