using System;
using Roblox.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

internal interface IUniverseDisplayInformationChangeReporter : IObservable<UniverseDisplayInformationChangeEvent>
{
	void DisplayInformationChanged(long universeId, ILanguageFamily language, UniverseDisplayInformationChangeType changeType, UniverseDisplayInformationActionType actionType);

	void Unsubscribe(IObserver<UniverseDisplayInformationChangeEvent> observer);
}
