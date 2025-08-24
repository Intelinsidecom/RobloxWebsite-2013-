using System.Collections.Generic;
using Roblox.Billing.Properties;

namespace Roblox.Billing;

public class AppleAppStoreHelper
{
	public static bool IsAppleAppStoreSandboxValidAccountID(long accountID)
	{
		if (!Settings.Default.AppleAppStoreSandboxFallbackEnabled)
		{
			return false;
		}
		if (new List<string>(Settings.Default.AppleAppStoreSandboxValidAccountIDs.Split(',')).Contains(accountID.ToString()))
		{
			return true;
		}
		return false;
	}
}
