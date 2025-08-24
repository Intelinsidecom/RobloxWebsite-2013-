namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_ru_ru : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Принять";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Согласен";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "Разрешить";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Назад";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Отмена";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Подтверждаю";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Удалить";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Сброс";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "Нет";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "OK";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Сохранить";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Отправить";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Да";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Дата";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "Апрель";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "Август";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "День";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Декабрь";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Февраль";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Январь";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Июль";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Июнь";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "Март";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "Май";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Месяц";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Далее";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "Ноябрь";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Октябрь";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Назад";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "Сентябрь";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Год";

	public ControlsResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Принять";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Согласен";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "Разрешить";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Назад";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Отмена";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Подтверждаю";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Удалить";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Сброс";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "Нет";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Сохранить";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Отправить";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Да";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Дата";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "Апрель";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "Август";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"Страница {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Страница {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "День";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Декабрь";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Февраль";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Январь";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Июль";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Июнь";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "Март";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Май";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Месяц";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Далее";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "Ноябрь";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Октябрь";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Назад";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "Сентябрь";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Год";
	}
}
