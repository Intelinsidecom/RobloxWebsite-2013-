using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.UniverseDisplayInformation.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class GameNameDescriptionChangeEventStreamer : IGameNameDescriptionChangeEventStreamer
{
	private readonly IGameNameDescriptionChangeEventFactory _GameNameDescriptionChangeEventFactory;

	private readonly IGameNameDescriptionChangeEventStreamerSettings _Settings;

	private readonly ILogger _Logger;

	public GameNameDescriptionChangeEventStreamer(IEventStreamer eventStreamer, ILogger logger)
		: this(new GameNameDescriptionChangeEventFactory(eventStreamer), Settings.Default, logger)
	{
	}

	internal GameNameDescriptionChangeEventStreamer(IGameNameDescriptionChangeEventFactory gameNameDescriptionChangeEventFactory, IGameNameDescriptionChangeEventStreamerSettings settings, ILogger logger)
	{
		_GameNameDescriptionChangeEventFactory = gameNameDescriptionChangeEventFactory.AssignOrThrowIfNull("gameNameDescriptionChangeEventFactory");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_Logger = logger.AssignOrThrowIfNull("logger");
	}

	public void StreamGameNameDescriptionChangeEvent(IUserIdentifier user, IUniverse universe, ILanguageFamily language, bool isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum userType, GameNameDescriptionChangeEventActionTypeEnum actionType, GameNameDescriptionChangeEventFieldEnum field)
	{
		if (!_Settings.IsStreamingGameNameDescriptionChangeEventEnabled)
		{
			return;
		}
		try
		{
			_GameNameDescriptionChangeEventFactory.CreateEvent(user?.Id, universe.Id, language?.LanguageCode, isSourceLanguage, userType, actionType, field).Stream();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
