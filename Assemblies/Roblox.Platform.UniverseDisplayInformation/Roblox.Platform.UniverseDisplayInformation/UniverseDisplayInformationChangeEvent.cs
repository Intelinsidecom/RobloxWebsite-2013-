using System.Runtime.Serialization;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
///
/// </summary>
[DataContract]
internal class UniverseDisplayInformationChangeEvent
{
	/// <summary>
	/// The universe's id
	/// </summary>
	[DataMember(Name = "universeId")]
	public long UniverseId { get; }

	/// <summary>
	/// The language code
	/// </summary>
	[DataMember(Name = "languageCode")]
	public string LanguageCode { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayInformationChangeType" /> as a string.
	/// </summary>
	[DataMember(Name = "changeType")]
	public string ChangeType { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayInformationActionType" /> as a string.
	/// </summary>
	[DataMember(Name = "actionType")]
	public string ActionType { get; }

	internal UniverseDisplayInformationChangeEvent(long universeId, ILanguageFamily language, UniverseDisplayInformationChangeType changeType, UniverseDisplayInformationActionType actionType)
	{
		UniverseId = universeId;
		LanguageCode = language?.LanguageCode;
		ChangeType = changeType.ToString();
		ActionType = actionType.ToString();
	}
}
