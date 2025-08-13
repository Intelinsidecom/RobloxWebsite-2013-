namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_de_de : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Annehmen";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Akzeptieren";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "Erlauben";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Zurück";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Bestätigen";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Löschen";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Verwerfen";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "Nein";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "Okay";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Speichern";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Senden";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Ja";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Datum";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "April";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "August";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Tag";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Dezember";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Februar";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Januar";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Juli";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Juni";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "März";

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
	public override string LabelMonth => "Monat";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Weiter";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "November";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Oktober";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Zurück";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "September";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Jahr";

	public ControlsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Annehmen";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Akzeptieren";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "Erlauben";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Zurück";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Bestätigen";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Verwerfen";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "Nein";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "Okay";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Speichern";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Senden";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Ja";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Datum";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "April";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "August";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"Seite {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Seite {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Tag";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Dezember";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Februar";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Januar";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Juli";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Juni";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "März";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Mai";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Monat";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Weiter";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "November";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Oktober";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Zurück";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "September";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Jahr";
	}
}
