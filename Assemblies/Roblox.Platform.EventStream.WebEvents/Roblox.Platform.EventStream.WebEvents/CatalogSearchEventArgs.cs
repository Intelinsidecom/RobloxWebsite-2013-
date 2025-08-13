using System.Collections.Generic;

namespace Roblox.Platform.EventStream.WebEvents;

public class CatalogSearchEventArgs : WebEventArgs
{
	/// <summary>
	/// Sort of the result
	/// </summary>
	public string Sort { get; set; }

	/// <summary>
	/// Category of result.
	/// </summary>
	public string Category { get; set; }

	/// <summary>The assets returned in CSV format</summary>
	public string AssetsReturned { get; set; }

	/// <summary>
	/// Page on which current results shown.
	/// </summary>
	public string Page { get; set; }

	/// <summary>
	/// Sub Category of result.
	/// </summary>
	public string SubCategory { get; set; }

	/// <summary>
	/// Gears of result.
	/// </summary>
	public string Gears { get; set; }

	/// <summary>
	/// Genre of result.
	/// </summary>
	public string Genre { get; set; }

	/// <summary>
	/// Algorithm Name of result.
	/// </summary>
	public string AlgorithmName { get; set; }

	/// <summary>
	/// Minimum Price of result.
	/// </summary>
	public int PriceMin { get; set; }

	/// <summary>
	/// Maximum Price of result.
	/// </summary>
	public int PriceMax { get; set; }

	/// <summary>
	/// HttpStatusCode of result.
	/// </summary>
	public int HttpStatusCode { get; set; }

	/// <summary>
	/// Include Not For Sale Assets of result.
	/// </summary>
	public bool IncludeNotForSale { get; set; }

	/// <summary>
	/// Tag names in result
	/// </summary>
	public IReadOnlyCollection<string> TagNames { get; set; }

	/// <summary>
	/// User Item model name for catalog sorts.
	/// </summary>
	public string UserItemModelName { get; set; }
}
