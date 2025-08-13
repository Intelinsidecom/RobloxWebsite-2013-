using System;

namespace Roblox.Platform.GameLocalization.Events;

internal interface IGameLocalizationChangeReporter : IObservable<GameLocalizationChangeEvent>
{
	void OnGameLocalizationSettingChanged(long gameId, GameLocalizationChangeType changeType);
}
