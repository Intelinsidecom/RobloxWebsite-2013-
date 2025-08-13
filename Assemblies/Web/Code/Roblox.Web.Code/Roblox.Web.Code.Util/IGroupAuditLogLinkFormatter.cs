namespace Roblox.Web.Code.Util;

public interface IGroupAuditLogLinkFormatter
{
	string LinkUser(long userId);

	string LinkGroup(long groupId);

	string LinkAsset(long assetId);

	string LinkUniverse(long universeId, string linkText);

	string LinkGamePass(long gamePassId);

	string LinkBadge(long badgeId);

	string RolesetText(long rolesetId);

	string Hyperlink(string input, string urlBase);
}
