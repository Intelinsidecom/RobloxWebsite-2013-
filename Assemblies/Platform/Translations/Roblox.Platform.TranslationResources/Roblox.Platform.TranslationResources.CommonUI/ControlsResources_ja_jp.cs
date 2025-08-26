namespace Roblox.Platform.TranslationResources.CommonUI {
    /// <summary>

/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_ja_jp : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "åŒæ„ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "åŒæ„ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "è¨±å¯";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "æˆ»ã‚‹";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "å‰Šé™¤";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "ç ´æ£„";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "ã„ã„ãˆ";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "OK";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ä¿å­˜";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "é€ä¿¡ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "ã¯ã„";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "æ—¥ä»˜";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "4æœˆ";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "8æœˆ";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "æ—¥";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "12æœˆ";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "2æœˆ";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "1æœˆ";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "7æœˆ";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "6æœˆ";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "3æœˆ";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "5æœˆ";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "æœˆ";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "æ¬¡ã¸";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "11æœˆ";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "10æœˆ";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "å‰ã¸";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "9æœˆ";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "å¹´";

	public ControlsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "åŒæ„ã™ã‚‹";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "åŒæ„ã™ã‚‹";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "è¨±å¯";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "æˆ»ã‚‹";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "å‰Šé™¤";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "ç ´æ£„";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "ã„ã„ãˆ";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "é€ä¿¡ã™ã‚‹";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "ã¯ã„";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "æ—¥ä»˜";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "4æœˆ";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "8æœˆ";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"{currentPage}ãƒšãƒ¼ã‚¸";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "{currentPage}ãƒšãƒ¼ã‚¸";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "æ—¥";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "12æœˆ";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "2æœˆ";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "1æœˆ";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "7æœˆ";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "6æœˆ";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "3æœˆ";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "5æœˆ";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "æœˆ";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "æ¬¡ã¸";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "11æœˆ";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "10æœˆ";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "å‰ã¸";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "9æœˆ";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "å¹´";
	}
}


}
