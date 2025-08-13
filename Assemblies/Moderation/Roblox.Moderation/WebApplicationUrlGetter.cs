namespace Roblox.Moderation;

/// <summary>
/// Delegate should return the containing web application's URL.
/// </summary>
/// <remarks>Formerly this returned the Roblox.Common.Web.ApplicationURL</remarks>
/// <returns>The application's URL as a string.</returns>
public delegate string WebApplicationUrlGetter();
