using System.Web;
using System.Web.Util;

namespace Roblox.Web.Security;

/// <summary>
/// By default ASP.Net filters out input that looks like it could be HTML tags or other XSS vectors.
/// We want to disable this behavior on test environments so we can more easily test against XSS vulnerabilities.
/// </summary>
public abstract class RequestContentSecurityValidator : System.Web.Util.RequestValidator
{
	public abstract bool IsRequestValidationEnabled();

	protected override bool IsValidRequestString(HttpContext context, string value, RequestValidationSource requestValidationSource, string collectionKey, out int validationFailureIndex)
	{
		if (IsRequestValidationEnabled())
		{
			return base.IsValidRequestString(HttpContext.Current, value, requestValidationSource, collectionKey, out validationFailureIndex);
		}
		validationFailureIndex = -1;
		return true;
	}
}
