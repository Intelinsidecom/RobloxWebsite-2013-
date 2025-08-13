namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_th_th : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "ยอมร\u0e31บ";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "ยอมร\u0e31บ";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "อน\u0e38ญาต";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "ย\u0e49อนกล\u0e31บ";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ยกเล\u0e34ก";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "ย\u0e37นย\u0e31น";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "ลบ";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "ท\u0e34\u0e49ง";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "ไม\u0e48";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "ตกลง";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "บ\u0e31นท\u0e36ก";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ส\u0e48ง";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "ใช\u0e48";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "ว\u0e31นท\u0e35\u0e48";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "เมษายน";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "ส\u0e34งหาคม";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "ว\u0e31น";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "ธ\u0e31นวาคม";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "ก\u0e38มภาพ\u0e31นธ\u0e4c";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "มกราคม";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "กรกฎาคม";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "ม\u0e34ถ\u0e38นายน";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "ม\u0e35นาคม";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "พฤษภาคม";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "เด\u0e37อน";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "ต\u0e48อไป";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "พฤศจ\u0e34กายน";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "ต\u0e38ลาคม";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "ก\u0e48อนหน\u0e49า";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "ก\u0e31นยายน";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "ป\u0e35";

	public ControlsResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "ยอมร\u0e31บ";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "ยอมร\u0e31บ";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "อน\u0e38ญาต";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "ย\u0e49อนกล\u0e31บ";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ยกเล\u0e34ก";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "ย\u0e37นย\u0e31น";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "ลบ";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "ท\u0e34\u0e49ง";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "ไม\u0e48";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "ตกลง";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "บ\u0e31นท\u0e36ก";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ส\u0e48ง";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "ใช\u0e48";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "ว\u0e31นท\u0e35\u0e48";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "เมษายน";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "ส\u0e34งหาคม";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"หน\u0e49า {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "หน\u0e49า {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "ว\u0e31น";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "ธ\u0e31นวาคม";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "ก\u0e38มภาพ\u0e31นธ\u0e4c";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "มกราคม";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "กรกฎาคม";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "ม\u0e34ถ\u0e38นายน";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "ม\u0e35นาคม";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "พฤษภาคม";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "เด\u0e37อน";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "ต\u0e48อไป";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "พฤศจ\u0e34กายน";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "ต\u0e38ลาคม";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "ก\u0e48อนหน\u0e49า";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "ก\u0e31นยายน";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "ป\u0e35";
	}
}
