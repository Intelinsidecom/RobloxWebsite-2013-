namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// A class containing a ValueSource that contains information like source string value, targetId etc.
/// </summary>
public class ValueSource<TIdentifier>
{
	/// <summary>
	/// The Identifier of <typeparamref name="TIdentifier" />.
	/// </summary>
	public TIdentifier Identifier { get; }

	/// <summary>
	/// The source string value.
	/// </summary>
	public string Value { get; }

	/// <summary>
	/// The source locale
	/// </summary>
	public string SourceLocale { get; }

	/// <summary>
	/// The Target identifier for querying TranslationStorage.
	/// </summary>
	public string TargetId { get; }

	/// <summary>
	/// Gets the shadow roll-out id for this ValueSource.
	/// </summary>
	public long ShadowRolloutId { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.TranslationStorage.ValueSource`1" /> class.
	/// </summary>
	/// <param name="identifier">The <typeparamref name="TIdentifier" />.</param>
	/// <param name="value">The source string value.</param>
	/// <param name="targetId">The target identifier to query TranslationStorage.</param>
	/// <param name="shadowRolloutId">The shadow roll-out range. This can be be initialized with id of the <typeparamref name="TIdentifier" />.</param>
	public ValueSource(TIdentifier identifier, string value, string sourceLocale, string targetId, long shadowRolloutId)
	{
		Identifier = identifier;
		Value = value;
		SourceLocale = sourceLocale;
		TargetId = targetId;
		ShadowRolloutId = shadowRolloutId;
	}
}
