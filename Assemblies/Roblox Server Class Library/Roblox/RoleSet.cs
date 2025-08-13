using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Properties;
using Roblox.Roles.Client;

namespace Roblox;

[Serializable]
public class RoleSet
{
	internal static readonly IRolesClient RolesClient;

	private static readonly LazyWithRetry<IReadOnlyCollection<RoleSet>> _AllRoleSets;

	private static readonly LazyWithRetry<RoleSet> _CommunityManager;

	private static readonly LazyWithRetry<RoleSet> _ContentCreator;

	private static readonly LazyWithRetry<RoleSet> _CustomerService;

	private static readonly LazyWithRetry<RoleSet> _Developer;

	private static readonly LazyWithRetry<RoleSet> _EconomyManager;

	private static readonly LazyWithRetry<RoleSet> _Marketing;

	private static readonly LazyWithRetry<RoleSet> _MarketingManager;

	private static readonly LazyWithRetry<RoleSet> _AdOps;

	private static readonly LazyWithRetry<RoleSet> _AdOpsManager;

	private static readonly LazyWithRetry<RoleSet> _Moderator;

	private static readonly LazyWithRetry<RoleSet> _Member;

	private static readonly LazyWithRetry<RoleSet> _ModeratorManager;

	private static readonly LazyWithRetry<RoleSet> _SuperModerator;

	private static readonly LazyWithRetry<RoleSet> _SuperAdministrator;

	private static readonly LazyWithRetry<RoleSet> _TrustedContributor;

	private static readonly LazyWithRetry<RoleSet> _Soothsayer;

	private static readonly LazyWithRetry<RoleSet> _CommunityRepresentative;

	private static readonly LazyWithRetry<RoleSet> _Bursar;

	private static readonly LazyWithRetry<RoleSet> _Finance;

	private static readonly LazyWithRetry<RoleSet> _BetaTester;

	private static readonly LazyWithRetry<RoleSet> _ProtectedUser;

	private static readonly LazyWithRetry<RoleSet> _ReleaseEngineer;

	private static readonly LazyWithRetry<RoleSet> _Viewer;

	private static readonly LazyWithRetry<RoleSet> _CommunityChampion;

	private static readonly LazyWithRetry<RoleSet> _DeveloperRelations;

	private static readonly LazyWithRetry<RoleSet> _DevRelManager;

	private static readonly LazyWithRetry<RoleSet> _DataAdministrator;

	private static readonly LazyWithRetry<RoleSet> _EventStreamCreator;

	private static readonly LazyWithRetry<RoleSet> _TranslationManager;

	private static readonly LazyWithRetry<RoleSet> _TranslationContributor;

	private static readonly LazyWithRetry<RoleSet> _PIIManager;

	private static readonly LazyWithRetry<RoleSet> _IT;

	private static readonly LazyWithRetry<RoleSet> _CSAgentAdmin;

	private static readonly LazyWithRetry<RoleSet> _FastTrackMember;

	private static readonly LazyWithRetry<RoleSet> _FastTrackModerator;

	private static readonly LazyWithRetry<RoleSet> _FastTrackAdmin;

	private static readonly LazyWithRetry<RoleSet> _ThumbnailAdmin;

	private static readonly LazyWithRetry<RoleSet> _MatchmakingAdmin;

	private static readonly LazyWithRetry<RoleSet> _RccReleaseTester;

	private static readonly LazyWithRetry<RoleSet> _RccReleaseTesterManager;

	private static readonly LazyWithRetry<RoleSet> _ChinaLicenseUser;

	private static readonly LazyWithRetry<RoleSet> _ChinaBetaUser;

	private static readonly LazyWithRetry<RoleSet> _Influencer;

	private static readonly LazyWithRetry<RoleSet> _ItemManager;

	private static readonly LazyWithRetry<RoleSet> _CatalogItemCreator;

	private static readonly LazyWithRetry<RoleSet> _CLBGameDeveloper;

	private static readonly LazyWithRetry<RoleSet> _ModerationImpersonator;

	public int ID { get; }

	public string Name { get; }

	public int Rank { get; }

	public static RoleSet CommunityManager => _CommunityManager.Value;

	public static RoleSet ContentCreator => _ContentCreator.Value;

	public static RoleSet CustomerService => _CustomerService.Value;

	public static RoleSet Developer => _Developer.Value;

	public static RoleSet EconomyManager => _EconomyManager.Value;

	public static RoleSet Marketing => _Marketing.Value;

	public static RoleSet MarketingManager => _MarketingManager.Value;

	public static RoleSet AdOps => _AdOps.Value;

	public static RoleSet AdOpsManager => _AdOpsManager.Value;

	public static RoleSet Moderator => _Moderator.Value;

	public static RoleSet Member => _Member.Value;

	public static RoleSet ModeratorManager => _ModeratorManager.Value;

	public static RoleSet SuperModerator => _SuperModerator.Value;

	public static RoleSet SuperAdministrator => _SuperAdministrator.Value;

	public static RoleSet TrustedContributor => _TrustedContributor.Value;

	public static RoleSet Soothsayer => _Soothsayer.Value;

	public static RoleSet CommunityRepresentative => _CommunityRepresentative.Value;

	public static RoleSet Bursar => _Bursar.Value;

	public static RoleSet Finance => _Finance.Value;

	public static RoleSet BetaTester => _BetaTester.Value;

	public static RoleSet ProtectedUser => _ProtectedUser.Value;

	public static RoleSet ReleaseEngineer => _ReleaseEngineer.Value;

	public static RoleSet Viewer => _Viewer.Value;

	public static RoleSet CommunityChampion => _CommunityChampion.Value;

	public static RoleSet DeveloperRelations => _DeveloperRelations.Value;

	public static RoleSet DevRelManager => _DevRelManager.Value;

	public static RoleSet DataAdministrator => _DataAdministrator.Value;

	public static RoleSet EventStreamCreator => _EventStreamCreator.Value;

	public static RoleSet TranslationManager => _TranslationManager.Value;

	public static RoleSet TranslationContributor => _TranslationContributor.Value;

	public static RoleSet PIIManager => _PIIManager.Value;

	public static RoleSet IT => _IT.Value;

	public static RoleSet CSAgentAdmin => _CSAgentAdmin.Value;

	public static RoleSet FastTrackMember => _FastTrackMember.Value;

	public static RoleSet FastTrackModerator => _FastTrackModerator.Value;

	public static RoleSet FastTrackAdmin => _FastTrackAdmin.Value;

	public static RoleSet ThumbnailAdmin => _ThumbnailAdmin.Value;

	public static RoleSet MatchmakingAdmin => _MatchmakingAdmin.Value;

	public static RoleSet RccReleaseTester => _RccReleaseTester.Value;

	public static RoleSet RccReleaseTesterManager => _RccReleaseTesterManager.Value;

	public static RoleSet ChinaLicenseUser => _ChinaLicenseUser.Value;

	public static RoleSet ChinaBetaUser => _ChinaBetaUser.Value;

	public static RoleSet Influencer => _Influencer.Value;

	public static RoleSet ItemManager => _ItemManager.Value;

	public static RoleSet CatalogItemCreator => _CatalogItemCreator.Value;

	public static RoleSet CLBGameDeveloper => _CLBGameDeveloper.Value;

	public static RoleSet ModerationImpersonator => _ModerationImpersonator.Value;

	private RoleSet(RoleSetResult roleSetResult)
	{
		if (roleSetResult == null)
		{
			throw new ArgumentNullException("roleSetResult");
		}
		ID = roleSetResult.Id;
		Name = roleSetResult.Name;
		Rank = roleSetResult.Rank;
	}

	static RoleSet()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		RolesClient = (IRolesClient)new RolesClient((Func<string>)(() => Settings.Default.RolesClientMasterApiKey));
		_AllRoleSets = new LazyWithRetry<IReadOnlyCollection<RoleSet>>(GetAllRoleSetsFromRolesService);
		_Member = GetRoleSetLazy("Member");
		_TrustedContributor = GetRoleSetLazy("TrustedContributor");
		_Soothsayer = GetRoleSetLazy("Soothsayer");
		_ContentCreator = GetRoleSetLazy("ContentCreator");
		_Moderator = GetRoleSetLazy("Moderator");
		_SuperModerator = GetRoleSetLazy("SuperModerator");
		_CustomerService = GetRoleSetLazy("CustomerService");
		_SuperAdministrator = GetRoleSetLazy("SuperAdministrator");
		_Developer = GetRoleSetLazy("Developer");
		_EconomyManager = GetRoleSetLazy("EconomyManager");
		_Marketing = GetRoleSetLazy("Marketing");
		_MarketingManager = GetRoleSetLazy("MarketingManager");
		_AdOps = GetRoleSetLazy("AdOps");
		_AdOpsManager = GetRoleSetLazy("AdOpsManager");
		_CommunityManager = GetRoleSetLazy("CommunityManager");
		_ModeratorManager = GetRoleSetLazy("ModeratorManager");
		_CommunityRepresentative = GetRoleSetLazy("CommunityRepresentative");
		_Bursar = GetRoleSetLazy("Bursar");
		_Finance = GetRoleSetLazy("Finance");
		_BetaTester = GetRoleSetLazy("BetaTester");
		_ProtectedUser = GetRoleSetLazy("ProtectedUser");
		_ReleaseEngineer = GetRoleSetLazy("ReleaseEngineer");
		_Viewer = GetRoleSetLazy("Viewer");
		_CommunityChampion = GetRoleSetLazy("CommunityChampion");
		_DeveloperRelations = GetRoleSetLazy("DeveloperRelations");
		_DevRelManager = GetRoleSetLazy("DevRelManager");
		_DataAdministrator = GetRoleSetLazy("DataAdministrator");
		_EventStreamCreator = GetRoleSetLazy("EventStreamCreator");
		_TranslationManager = GetRoleSetLazy("TranslationManager");
		_TranslationContributor = GetRoleSetLazy("TranslationContributor");
		_PIIManager = GetRoleSetLazy("PIIManager");
		_IT = GetRoleSetLazy("IT");
		_CSAgentAdmin = GetRoleSetLazy("CSAgentAdmin");
		_FastTrackMember = GetRoleSetLazy("FastTrackMember");
		_FastTrackModerator = GetRoleSetLazy("FastTrackModerator");
		_FastTrackAdmin = GetRoleSetLazy("FastTrackAdmin");
		_ThumbnailAdmin = GetRoleSetLazy("ThumbnailAdmin");
		_MatchmakingAdmin = GetRoleSetLazy("MatchmakingAdmin");
		_RccReleaseTester = GetRoleSetLazy("RccReleaseTester");
		_RccReleaseTesterManager = GetRoleSetLazy("RccReleaseTesterManager");
		_ChinaLicenseUser = GetRoleSetLazy("ChinaLicenseUser");
		_ChinaBetaUser = GetRoleSetLazy("ChinaBetaUser");
		_Influencer = GetRoleSetLazy("Influencer");
		_ItemManager = GetRoleSetLazy("ItemManager");
		_CatalogItemCreator = GetRoleSetLazy("CatalogItemCreator");
		_CLBGameDeveloper = GetRoleSetLazy("CLBGameDeveloper");
		_ModerationImpersonator = GetRoleSetLazy("ModerationImpersonator");
	}

	public static RoleSet Get(int id)
	{
		return _AllRoleSets.Value.FirstOrDefault((RoleSet r) => r.ID == id);
	}

	public static RoleSet GetByName(string name)
	{
		return _AllRoleSets.Value.FirstOrDefault((RoleSet r) => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
	}

	public static ICollection<RoleSet> GetAllRoleSets()
	{
		return _AllRoleSets.Value.ToArray();
	}

	private static LazyWithRetry<RoleSet> GetRoleSetLazy(string roleSetName)
	{
		return new LazyWithRetry<RoleSet>(() => GetByName(roleSetName));
	}

	private static IReadOnlyCollection<RoleSet> GetAllRoleSetsFromRolesService()
	{
		return (IReadOnlyCollection<RoleSet>)(object)(from r in RolesClient.GetRoleSets()
			select new RoleSet(r)).ToArray();
	}
}
