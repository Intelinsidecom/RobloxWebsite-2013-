using System.Collections.Generic;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Ideally we'd use the PageResponse class from Platform.Core, but we're missing a required stored procedure/index for that pattern
/// </summary>
/// <typeparam name="T"></typeparam>
public class PagedResponse<T>
{
	public bool HasMore { get; internal set; }

	public IEnumerable<T> Items { get; internal set; }
}
