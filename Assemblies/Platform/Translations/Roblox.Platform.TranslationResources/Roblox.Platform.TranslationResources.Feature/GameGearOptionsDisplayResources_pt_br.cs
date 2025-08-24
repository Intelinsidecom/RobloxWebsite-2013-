namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameGearOptionsDisplayResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearOptionsDisplayResources_pt_br : GameGearOptionsDisplayResources_en_us, IGameGearOptionsDisplayResources, ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public override string LabelAllGenreAllowed => "Todos os gêneros permitidos";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "Nenhum equipamento permitido";

	public GameGearOptionsDisplayResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "Todos os gêneros permitidos";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"Somente equipamento {GearName}";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "Somente equipamento {GearName}";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "Nenhum equipamento permitido";
	}
}
