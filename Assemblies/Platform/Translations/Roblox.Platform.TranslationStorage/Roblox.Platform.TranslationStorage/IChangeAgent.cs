namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An interface representing an <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.
/// </summary>
public interface IChangeAgent
{
	/// <summary>
	/// Gets the value of property <see cref="P:Roblox.Platform.TranslationStorage.IChangeAgent.ChangeAgentType" />.
	/// </summary>
	ChangeAgentType ChangeAgentType { get; }

	/// <summary>
	/// Gets the value of property <see cref="P:Roblox.Platform.TranslationStorage.IChangeAgent.ChangeAgentTargetId" />.
	/// </summary>
	long ChangeAgentTargetId { get; }
}
