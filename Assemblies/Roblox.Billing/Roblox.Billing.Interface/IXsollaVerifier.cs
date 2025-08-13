using System.Web;

namespace Roblox.Billing.Interface;

public interface IXsollaVerifier
{
	bool IsUserValid(string xsollaUserId);

	bool IsPlanIdValid(string planId);

	bool IsProductIdValid(int xsollaProductId);

	bool IsRequestValid(string authorization, HttpContext context);
}
