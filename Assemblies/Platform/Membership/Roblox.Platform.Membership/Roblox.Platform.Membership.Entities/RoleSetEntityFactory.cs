namespace Roblox.Platform.Membership.Entities;

internal class RoleSetEntityFactory : IRoleSetEntityFactory
{
	public IRoleSetEntity GetCommunityManager()
	{
		return new RoleSetEntity(RoleSet.CommunityManager);
	}

	public IRoleSetEntity GetContentCreator()
	{
		return new RoleSetEntity(RoleSet.ContentCreator);
	}

	public IRoleSetEntity GetCustomerService()
	{
		return new RoleSetEntity(RoleSet.CustomerService);
	}

	public IRoleSetEntity GetDeveloper()
	{
		return new RoleSetEntity(RoleSet.Developer);
	}

	public IRoleSetEntity GetEconomyManager()
	{
		return new RoleSetEntity(RoleSet.EconomyManager);
	}

	public IRoleSetEntity GetMarketing()
	{
		return new RoleSetEntity(RoleSet.Marketing);
	}

	public IRoleSetEntity GetModerator()
	{
		return new RoleSetEntity(RoleSet.Moderator);
	}

	public IRoleSetEntity GetMember()
	{
		return new RoleSetEntity(RoleSet.Member);
	}

	public IRoleSetEntity GetModeratorManager()
	{
		return new RoleSetEntity(RoleSet.ModeratorManager);
	}

	public IRoleSetEntity GetSuperModerator()
	{
		return new RoleSetEntity(RoleSet.SuperModerator);
	}

	public IRoleSetEntity GetSuperAdministrator()
	{
		return new RoleSetEntity(RoleSet.SuperAdministrator);
	}

	public IRoleSetEntity GetTrustedContributor()
	{
		return new RoleSetEntity(RoleSet.TrustedContributor);
	}

	public IRoleSetEntity GetSoothsayer()
	{
		return new RoleSetEntity(RoleSet.Soothsayer);
	}

	public IRoleSetEntity GetCommunityRepresentative()
	{
		return new RoleSetEntity(RoleSet.CommunityRepresentative);
	}

	public IRoleSetEntity GetBursar()
	{
		return new RoleSetEntity(RoleSet.Bursar);
	}

	public IRoleSetEntity GetFinance()
	{
		return new RoleSetEntity(RoleSet.Finance);
	}

	public IRoleSetEntity GetBetaTester()
	{
		return new RoleSetEntity(RoleSet.BetaTester);
	}

	public IRoleSetEntity GetProtectedUser()
	{
		return new RoleSetEntity(RoleSet.ProtectedUser);
	}

	public IRoleSetEntity GetReleaseEngineer()
	{
		return new RoleSetEntity(RoleSet.ReleaseEngineer);
	}

	public IRoleSetEntity GetViewer()
	{
		return new RoleSetEntity(RoleSet.Viewer);
	}

	public IRoleSetEntity GetCommunityChampion()
	{
		return new RoleSetEntity(RoleSet.CommunityChampion);
	}

	public IRoleSetEntity GetDeveloperRelations()
	{
		return new RoleSetEntity(RoleSet.DeveloperRelations);
	}

	public IRoleSetEntity GetCSAgentAdmin()
	{
		return new RoleSetEntity(RoleSet.CSAgentAdmin);
	}

	public IRoleSetEntity GetFastTrackMember()
	{
		return new RoleSetEntity(RoleSet.FastTrackMember);
	}

	public IRoleSetEntity GetFastTrackModerator()
	{
		return new RoleSetEntity(RoleSet.FastTrackModerator);
	}

	public IRoleSetEntity GetFastTrackAdmin()
	{
		return new RoleSetEntity(RoleSet.FastTrackAdmin);
	}

	public IRoleSetEntity GetThumbnailAdmin()
	{
		return new RoleSetEntity(RoleSet.ThumbnailAdmin);
	}

	public IRoleSetEntity GetMatchmakingAdmin()
	{
		return new RoleSetEntity(RoleSet.MatchmakingAdmin);
	}

	public IRoleSetEntity GetRccReleaseTester()
	{
		return new RoleSetEntity(RoleSet.RccReleaseTester);
	}

	public IRoleSetEntity GetRccReleaseTesterManager()
	{
		return new RoleSetEntity(RoleSet.RccReleaseTesterManager);
	}

	public IRoleSetEntity GetChinaLicenseUser()
	{
		return new RoleSetEntity(RoleSet.ChinaLicenseUser);
	}

	public IRoleSetEntity GetChinaBetaUser()
	{
		return new RoleSetEntity(RoleSet.ChinaBetaUser);
	}

	public IRoleSetEntity GetInfluencer()
	{
		return new RoleSetEntity(RoleSet.Influencer);
	}

	public IRoleSetEntity GetDataAdministrator()
	{
		return new RoleSetEntity(RoleSet.DataAdministrator);
	}

	public IRoleSetEntity GetAdOps()
	{
		return new RoleSetEntity(RoleSet.AdOps);
	}

	public IRoleSetEntity GetCLBGameDeveloper()
	{
		return new RoleSetEntity(RoleSet.CLBGameDeveloper);
	}
}
