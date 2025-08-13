namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides PresenceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PresenceResources_es_es : PresenceResources_en_us, IPresenceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public override string LabelCreating => "Creando";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Sin conexión";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Conectado";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "Jugando";

	public PresenceResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "Creando";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"Creando en {placeName}";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "Creando en {placeName}";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Sin conexión";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Conectado";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "Jugando";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"Jugando a {placeName}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "Jugando a {placeName}";
	}
}
