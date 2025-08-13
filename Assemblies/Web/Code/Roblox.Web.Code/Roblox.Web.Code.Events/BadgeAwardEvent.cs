namespace Roblox.Web.Code.Events;

public class BadgeAwardEvent
{
	public long UserId { get; set; }

	public int BadgeTypeId { get; set; }

	public BadgeAwardEvent(long userId, int badgeTypeId)
	{
		UserId = userId;
		BadgeTypeId = badgeTypeId;
	}
}
