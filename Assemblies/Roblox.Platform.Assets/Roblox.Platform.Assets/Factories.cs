using System;
using Roblox.Agents;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.TextFilter;

namespace Roblox.Platform.Assets;

/// <summary>
/// This is an anachronism. It really needs to be modified to include correct injection of the BasicTextFilter from the Moderation platform.
/// </summary>
[Obsolete("Deprecated. Use an instance of AssetDomainFactories instead.")]
public static class Factories
{
	/// <summary>
	/// This class exists for the unusual situation where the AssetDomainFactories is instantiated by Factories,
	/// and needs an ILogger to log exceptions.
	/// </summary>
	private class FallbackErrorLogger : LoggerBase
	{
		public FallbackErrorLogger()
		{
			base.MaxLogLevel = () => LogLevel.Verbose;
		}

		protected override void Log(LogLevel logLevel, string format, params object[] args)
		{
			ExceptionHandler.LogException(string.Format(arg1: (args == null || args.Length == 0) ? format : string.Format(format, args), format: "[{0}] {1}", arg0: logLevel));
		}
	}

	private static AssetDomainFactories _Singleton { get; set; }

	public static AssetDomainFactories DomainFactories => GetSingleton();

	public static IAliasFactory AliasFactory => GetSingleton().AliasFactory;

	public static IBadgeTypeFactory BadgeTypeFactory => GetSingleton().BadgeTypeFactory;

	public static AnimationFactory AnimationFactory => GetSingleton().AnimationFactory;

	public static ArmsFactory ArmsFactory => GetSingleton().ArmsFactory;

	public static AudioFactory AudioFactory => GetSingleton().AudioFactory;

	public static BackAccessoryFactory BackAccessoryFactory => GetSingleton().BackAccessoryFactory;

	public static BadgeFactory BadgeFactory => GetSingleton().BadgeFactory;

	public static DecalFactory DecalFactory => GetSingleton().DecalFactory;

	public static FaceAccessoryFactory FaceAccessoryFactory => GetSingleton().FaceAccessoryFactory;

	public static FaceFactory FaceFactory => GetSingleton().FaceFactory;

	public static FrontAccessoryFactory FrontAccessoryFactory => GetSingleton().FrontAccessoryFactory;

	public static GamePassFactory GamePassFactory => GetSingleton().GamePassFactory;

	public static GearFactory GearFactory => GetSingleton().GearFactory;

	public static HairAccessoryFactory HairAccessoryFactory => GetSingleton().HairAccessoryFactory;

	public static HatFactory HatFactory => GetSingleton().HatFactory;

	public static HeadFactory HeadFactory => GetSingleton().HeadFactory;

	public static HtmlFactory HtmlFactory => GetSingleton().HtmlFactory;

	public static ImageFactory ImageFactory => GetSingleton().ImageFactory;

	public static LeftArmFactory LeftArmFactory => GetSingleton().LeftArmFactory;

	public static LeftLegFactory LeftLegFactory => GetSingleton().LeftLegFactory;

	public static LegsFactory LegsFactory => GetSingleton().LegsFactory;

	public static LuaFactory LuaFactory => GetSingleton().LuaFactory;

	public static MeshFactory MeshFactory => GetSingleton().MeshFactory;

	public static MeshPartFactory MeshPartFactory => GetSingleton().MeshPartFactory;

	public static ModelFactory ModelFactory => GetSingleton().ModelFactory;

	public static NeckAccessoryFactory NeckAccessoryFactory => GetSingleton().NeckAccessoryFactory;

	public static PackageFactory PackageFactory => GetSingleton().PackageFactory;

	public static PantsFactory PantsFactory => GetSingleton().PantsFactory;

	public static PlaceFactory PlaceFactory => GetSingleton().PlaceFactory;

	public static PluginFactory PluginFactory => GetSingleton().PluginFactory;

	public static RightArmFactory RightArmFactory => GetSingleton().RightArmFactory;

	public static RightLegFactory RightLegFactory => GetSingleton().RightLegFactory;

	public static ShirtFactory ShirtFactory => GetSingleton().ShirtFactory;

	public static ShoulderAccessoryFactory ShoulderAccessoryFactory => GetSingleton().ShoulderAccessoryFactory;

	public static SolidModelFactory SolidModelFactory => GetSingleton().SolidModelFactory;

	public static TeeShirtFactory TeeShirtFactory => GetSingleton().TeeShirtFactory;

	public static TextFactory TextFactory => GetSingleton().TextFactory;

	public static TorsoFactory TorsoFactory => GetSingleton().TorsoFactory;

	public static WaistAccessoryFactory WaistAccessoryFactory => GetSingleton().WaistAccessoryFactory;

	public static YouTubeVideoFactory YouTubeVideoFactory => GetSingleton().YouTubeVideoFactory;

	public static ClimbAnimationFactory ClimbAnimationFactory => GetSingleton().ClimbAnimationFactory;

	public static DeathAnimationFactory DeathAnimationFactory => GetSingleton().DeathAnimationFactory;

	public static FallAnimationFactory FallAnimationFactory => GetSingleton().FallAnimationFactory;

	public static IdleAnimationFactory IdleAnimationFactory => GetSingleton().IdleAnimationFactory;

	public static JumpAnimationFactory JumpAnimationFactory => GetSingleton().JumpAnimationFactory;

	public static RunAnimationFactory RunAnimationFactory => GetSingleton().RunAnimationFactory;

	public static SwimAnimationFactory SwimAnimationFactory => GetSingleton().SwimAnimationFactory;

	public static WalkAnimationFactory WalkAnimationFactory => GetSingleton().WalkAnimationFactory;

	public static PoseAnimationFactory PoseAnimationFactory => GetSingleton().PoseAnimationFactory;

	public static AssetDomainFactories GetSingleton()
	{
		if (_Singleton != null)
		{
			return _Singleton;
		}
		AgentFactory agentFactory = new AgentFactory();
		ITextFilter textFilter = new TextFilterFactory().GetTextFilter();
		FallbackErrorLogger logger = new FallbackErrorLogger();
		_Singleton = new AssetDomainFactories(agentFactory, textFilter, logger, StaticCounterRegistry.Instance);
		return _Singleton;
	}

	internal static void SetSingleton(AssetDomainFactories factories)
	{
		_Singleton = factories;
	}
}
