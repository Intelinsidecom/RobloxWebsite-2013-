namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_es_es : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Aceptar";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Aceptar";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "Permitir";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Volver";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Confirmar";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Eliminar";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Descartar";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "No";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "Aceptar";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Guardar";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Sí";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Fecha";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "Abril";

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
	public override string LabelDay => "Día";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Diciembre";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Febrero";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Enero";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Julio";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Junio";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "Marzo";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "Mayo";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Mes";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Siguiente";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "Noviembre";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Octubre";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Anterior";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "Septiembre";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Año";

	public ControlsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "Permitir";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Volver";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Confirmar";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Descartar";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "No";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Guardar";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Sí";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Fecha";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "Abril";
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
		return $"Página {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Página {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Día";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Diciembre";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Febrero";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Enero";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Julio";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Junio";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "Marzo";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Mayo";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Mes";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Siguiente";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "Noviembre";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Octubre";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Anterior";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "Septiembre";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Año";
	}
}
