using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.CommonUI;

internal class ControlsResources_en_us : TranslationResourcesBase, IControlsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public virtual string ActionAccept => "Accept";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public virtual string ActionAgree => "Agree";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public virtual string ActionAllow => "Allow";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public virtual string ActionBack => "Back";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public virtual string ActionConfirm => "Confirm";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string ActionDelete => "Delete";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public virtual string ActionDiscard => "Discard";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public virtual string ActionNo => "No";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionOK => "OK";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public virtual string ActionSubmit => "Submit";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public virtual string ActionYes => "Yes";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public virtual string BirthdaypickerLabelDate => "Date";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public virtual string LabelApril => "April";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public virtual string LabelAugust => "August";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public virtual string LabelDay => "Day";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public virtual string LabelDecember => "December";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public virtual string LabelFebruary => "February";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public virtual string LabelJanuary => "January";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public virtual string LabelJuly => "July";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public virtual string LabelJune => "June";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public virtual string LabelMarch => "March";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public virtual string LabelMay => "May";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public virtual string LabelMonth => "Month";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public virtual string LabelNext => "Next";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public virtual string LabelNovember => "November";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public virtual string LabelOctober => "October";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public virtual string LabelPrevious => "Previous";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public virtual string LabelSeptember => "September";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public virtual string LabelYear => "Year";

	public ControlsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Accept",
				_GetTemplateForActionAccept()
			},
			{
				"Action.Agree",
				_GetTemplateForActionAgree()
			},
			{
				"Action.Allow",
				_GetTemplateForActionAllow()
			},
			{
				"Action.Back",
				_GetTemplateForActionBack()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Confirm",
				_GetTemplateForActionConfirm()
			},
			{
				"Action.Delete",
				_GetTemplateForActionDelete()
			},
			{
				"Action.Discard",
				_GetTemplateForActionDiscard()
			},
			{
				"Action.No",
				_GetTemplateForActionNo()
			},
			{
				"Action.OK",
				_GetTemplateForActionOK()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"Action.Submit",
				_GetTemplateForActionSubmit()
			},
			{
				"Action.Yes",
				_GetTemplateForActionYes()
			},
			{
				"Birthdaypicker.Label.Date",
				_GetTemplateForBirthdaypickerLabelDate()
			},
			{
				"Label.April",
				_GetTemplateForLabelApril()
			},
			{
				"Label.August",
				_GetTemplateForLabelAugust()
			},
			{
				"Label.CurrentPage",
				_GetTemplateForLabelCurrentPage()
			},
			{
				"Label.Day",
				_GetTemplateForLabelDay()
			},
			{
				"Label.December",
				_GetTemplateForLabelDecember()
			},
			{
				"Label.February",
				_GetTemplateForLabelFebruary()
			},
			{
				"Label.January",
				_GetTemplateForLabelJanuary()
			},
			{
				"Label.July",
				_GetTemplateForLabelJuly()
			},
			{
				"Label.June",
				_GetTemplateForLabelJune()
			},
			{
				"Label.March",
				_GetTemplateForLabelMarch()
			},
			{
				"Label.May",
				_GetTemplateForLabelMay()
			},
			{
				"Label.Month",
				_GetTemplateForLabelMonth()
			},
			{
				"Label.Next",
				_GetTemplateForLabelNext()
			},
			{
				"Label.November",
				_GetTemplateForLabelNovember()
			},
			{
				"Label.October",
				_GetTemplateForLabelOctober()
			},
			{
				"Label.Previous",
				_GetTemplateForLabelPrevious()
			},
			{
				"Label.September",
				_GetTemplateForLabelSeptember()
			},
			{
				"Label.Year",
				_GetTemplateForLabelYear()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "CommonUI.Controls";
	}

	protected virtual string _GetTemplateForActionAccept()
	{
		return "Accept";
	}

	protected virtual string _GetTemplateForActionAgree()
	{
		return "Agree";
	}

	protected virtual string _GetTemplateForActionAllow()
	{
		return "Allow";
	}

	protected virtual string _GetTemplateForActionBack()
	{
		return "Back";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionConfirm()
	{
		return "Confirm";
	}

	protected virtual string _GetTemplateForActionDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForActionDiscard()
	{
		return "Discard";
	}

	protected virtual string _GetTemplateForActionNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForActionOK()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForActionSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForActionYes()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Date";
	}

	protected virtual string _GetTemplateForLabelApril()
	{
		return "April";
	}

	protected virtual string _GetTemplateForLabelAugust()
	{
		return "August";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public virtual string LabelCurrentPage(string currentPage)
	{
		return $"Page {currentPage}";
	}

	protected virtual string _GetTemplateForLabelCurrentPage()
	{
		return "Page {currentPage}";
	}

	protected virtual string _GetTemplateForLabelDay()
	{
		return "Day";
	}

	protected virtual string _GetTemplateForLabelDecember()
	{
		return "December";
	}

	protected virtual string _GetTemplateForLabelFebruary()
	{
		return "February";
	}

	protected virtual string _GetTemplateForLabelJanuary()
	{
		return "January";
	}

	protected virtual string _GetTemplateForLabelJuly()
	{
		return "July";
	}

	protected virtual string _GetTemplateForLabelJune()
	{
		return "June";
	}

	protected virtual string _GetTemplateForLabelMarch()
	{
		return "March";
	}

	protected virtual string _GetTemplateForLabelMay()
	{
		return "May";
	}

	protected virtual string _GetTemplateForLabelMonth()
	{
		return "Month";
	}

	protected virtual string _GetTemplateForLabelNext()
	{
		return "Next";
	}

	protected virtual string _GetTemplateForLabelNovember()
	{
		return "November";
	}

	protected virtual string _GetTemplateForLabelOctober()
	{
		return "October";
	}

	protected virtual string _GetTemplateForLabelPrevious()
	{
		return "Previous";
	}

	protected virtual string _GetTemplateForLabelSeptember()
	{
		return "September";
	}

	protected virtual string _GetTemplateForLabelYear()
	{
		return "Year";
	}
}
