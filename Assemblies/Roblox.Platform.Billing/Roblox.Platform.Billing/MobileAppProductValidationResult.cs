using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Billing;

public class MobileAppProductValidationResult
{
	private static readonly string _MobileFraudReasonPrefix = "MobileAppProductValidationResult_";

	public bool IsSuccess => !ValidationFailureReasons.Any();

	public ICollection<MobileAppProductValidationFailureReason> ValidationFailureReasons { get; private set; }

	internal MobileAppProductValidationResult()
	{
		ValidationFailureReasons = new List<MobileAppProductValidationFailureReason>();
	}

	internal void AddValidationFailureReason(MobileAppProductValidationFailureReason reason)
	{
		ValidationFailureReasons.Add(reason);
	}
}
