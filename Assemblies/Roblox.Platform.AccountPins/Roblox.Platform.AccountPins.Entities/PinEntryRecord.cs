using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.AccountPins.Entities;

[Serializable]
[ExcludeFromCodeCoverage]
internal class PinEntryRecord
{
	public long PinHashID { get; set; }

	public long AccountID { get; set; }

	public string SessionString { get; set; }

	public DateTime Created { get; set; }
}
