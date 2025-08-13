using System.Collections.Generic;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.GameLocalization;

public interface IGameLanguagesAccessor
{
	/// <summary>
	/// Gets the list of supported languages for a particular universe.
	/// </summary>
	/// <param name="universeId">The universeId.</param>
	/// <returns>A <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</returns>
	IReadOnlyCollection<ILanguageFamily> GetGameLanguagesForGame(long universeId);
}
