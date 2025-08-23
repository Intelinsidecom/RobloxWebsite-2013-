using System.Web;

namespace Roblox.Web;

/// <summary>
/// A class for request identification
/// </summary>
public interface IRequestIdentifier
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Web.RequesterType" /> from an <see cref="T:System.Web.HttpContextBase" />
	/// </summary>
	/// <param name="context">The <see cref="T:System.Web.HttpContextBase" />.</param>
	/// <returns>The <see cref="T:Roblox.Web.RequesterType" />.</returns>
	RequesterType GetRequester(HttpContextBase context);
}
