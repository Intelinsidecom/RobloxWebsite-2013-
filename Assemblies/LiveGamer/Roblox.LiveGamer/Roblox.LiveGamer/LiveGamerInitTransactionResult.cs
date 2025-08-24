using System.Collections.Generic;

namespace Roblox.LiveGamer;

public class LiveGamerInitTransactionResult
{
	public IEnumerable<LiveGamerLineItem> LineItems { get; set; }

	public int UserId { get; set; }

	public long LiveGamerTransactionId { get; set; }

	public string CountryCode { get; set; }

	public string UserEmail { get; set; }
}
