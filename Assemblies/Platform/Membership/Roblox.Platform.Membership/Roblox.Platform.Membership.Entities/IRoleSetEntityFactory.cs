namespace Roblox.Platform.Membership.Entities;

internal interface IRoleSetEntityFactory
{
	IRoleSetEntity GetCommunityManager();

	IRoleSetEntity GetContentCreator();

	IRoleSetEntity GetCustomerService();

	IRoleSetEntity GetDeveloper();

	IRoleSetEntity GetEconomyManager();

	IRoleSetEntity GetMarketing();

	IRoleSetEntity GetModerator();

	IRoleSetEntity GetMember();

	IRoleSetEntity GetModeratorManager();

	IRoleSetEntity GetSuperModerator();

	IRoleSetEntity GetSuperAdministrator();

	IRoleSetEntity GetTrustedContributor();

	IRoleSetEntity GetSoothsayer();

	IRoleSetEntity GetCommunityRepresentative();

	IRoleSetEntity GetBursar();

	IRoleSetEntity GetFinance();

	IRoleSetEntity GetBetaTester();

	IRoleSetEntity GetProtectedUser();

	IRoleSetEntity GetReleaseEngineer();

	IRoleSetEntity GetViewer();

	IRoleSetEntity GetCommunityChampion();

	IRoleSetEntity GetDeveloperRelations();

	IRoleSetEntity GetCSAgentAdmin();

	IRoleSetEntity GetFastTrackMember();

	IRoleSetEntity GetFastTrackModerator();

	IRoleSetEntity GetFastTrackAdmin();

	IRoleSetEntity GetThumbnailAdmin();

	IRoleSetEntity GetMatchmakingAdmin();

	IRoleSetEntity GetRccReleaseTester();

	IRoleSetEntity GetRccReleaseTesterManager();

	IRoleSetEntity GetChinaLicenseUser();

	IRoleSetEntity GetChinaBetaUser();

	IRoleSetEntity GetInfluencer();

	IRoleSetEntity GetDataAdministrator();

	IRoleSetEntity GetAdOps();

	IRoleSetEntity GetCLBGameDeveloper();
}
