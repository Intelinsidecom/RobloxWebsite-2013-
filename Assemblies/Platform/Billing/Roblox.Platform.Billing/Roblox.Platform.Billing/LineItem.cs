using System;
using Roblox.Billing;

namespace Roblox.Platform.Billing;

public class LineItem
{
	public ProductPrice ProductPrice { get; set; }

	public decimal FinalPrice { get; set; }

	public int Quantity { get; set; }

	public DateTime? RenewalStartDate { get; set; }
}
