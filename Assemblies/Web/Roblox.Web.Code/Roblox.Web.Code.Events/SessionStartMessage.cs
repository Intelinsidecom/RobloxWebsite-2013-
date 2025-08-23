using System;
using Roblox.Amazon.Sns;

namespace Roblox.Web.Code.Events;

public class SessionStartMessage : ISnsMessage
{
	public long UserId { get; set; }

	public byte PlatformTypeId { get; set; }

	public DateTime SessionStartTime { get; set; }

	public bool IsSignupSession { get; set; }
}
