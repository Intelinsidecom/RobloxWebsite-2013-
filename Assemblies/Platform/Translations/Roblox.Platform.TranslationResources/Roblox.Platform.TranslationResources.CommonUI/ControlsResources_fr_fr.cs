namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_fr_fr : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Accepter";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Accepter";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "Autoriser";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Retour";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Confirmer";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Supprimer";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Abandonner";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "Non";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "Ok";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Enregistrer";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Soumettre";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Oui";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Date";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "Avril";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "Août";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Jour";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Décembre";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Février";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Janvier";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Juillet";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Juin";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "Mars";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "Mai";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Mois";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Suivant";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "Novembre";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Octobre";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Précédent";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "Septembre";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Année";

	public ControlsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Accepter";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Accepter";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "Autoriser";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Retour";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Confirmer";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Supprimer";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Abandonner";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "Non";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "Ok";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Enregistrer";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Soumettre";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Oui";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Date";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "Avril";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "Août";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"Page {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Page {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Jour";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Décembre";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Février";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Janvier";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Juillet";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Juin";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "Mars";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Mai";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Mois";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Suivant";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "Novembre";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Octobre";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Précédent";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "Septembre";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Année";
	}
}
