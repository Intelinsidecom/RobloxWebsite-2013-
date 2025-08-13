using System.Collections.Generic;

namespace Roblox.Platform.Billing;

public interface IMidasCallbackValidator
{
	bool VerifyCallbackRequest(IDictionary<string, string> query, string url, string appKey);
}
