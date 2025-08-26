namespace Roblox.Platform.TranslationResources.CommonUI {
    /// <summary>

/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_ko_kr : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "ìˆ˜ë½";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "ë™ì˜";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "í—ˆìš©";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "ë’¤ë¡œ";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "í™•ì¸";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "ì‚­ì œ";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "ì•„ë‹ˆìš”";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "í™•ì¸";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ì €ìž¥";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ì œì¶œ";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "ì˜ˆ";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "ë‚ ì§œ";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "4ì›”";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "8ì›”";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "ì¼";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "12ì›”";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "2ì›”";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "1ì›”";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "7ì›”";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "6ì›”";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "3ì›”";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "5ì›”";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "ì›”";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "ë‹¤ìŒ";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "11ì›”";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "10ì›”";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "ì´ì „";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "9ì›”";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "ë…„";

	public ControlsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "ìˆ˜ë½";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "ë™ì˜";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "í—ˆìš©";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "ë’¤ë¡œ";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "ì•„ë‹ˆìš”";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ì œì¶œ";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "ì˜ˆ";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "ë‚ ì§œ";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "4ì›”";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "8ì›”";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"{currentPage}íŽ˜ì´ì§€";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "{currentPage}íŽ˜ì´ì§€";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "ì¼";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "12ì›”";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "2ì›”";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "1ì›”";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "7ì›”";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "6ì›”";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "3ì›”";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "5ì›”";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "ì›”";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "ë‹¤ìŒ";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "11ì›”";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "10ì›”";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "ì´ì „";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "9ì›”";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "ë…„";
	}
}


}
