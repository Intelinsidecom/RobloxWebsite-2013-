namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_it_it : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Accetta";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Accetto";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "Consenti";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Indietro";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annulla";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Conferma";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Elimina";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Elimina";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "No";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "OK";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Salva";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Invia";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Sì";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Data";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "Aprile";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "Agosto";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Giorno";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Dicembre";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Febbraio";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Gennaio";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Luglio";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Giugno";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "Marzo";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "Maggio";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Mese";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Avanti";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "Novembre";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Ottobre";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Precedente";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "Settembre";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Anno";

	public ControlsResources_it_it(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Accetta";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Accetto";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "Consenti";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Indietro";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annulla";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Conferma";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Elimina";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Elimina";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "No";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Salva";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Invia";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Sì";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Data";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "Aprile";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "Agosto";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"Pagina {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Pagina {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Giorno";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Dicembre";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Febbraio";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Gennaio";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Luglio";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Giugno";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "Marzo";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Maggio";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Mese";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Avanti";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "Novembre";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Ottobre";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Precedente";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "Settembre";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Anno";
	}
}
