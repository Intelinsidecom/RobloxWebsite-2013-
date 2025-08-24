using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class WebUtilResources_en_us : TranslationResourcesBase, IWebUtilResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	public WebUtilResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"GetLabelDay",
				_GetTemplateForGetLabelDay()
			},
			{
				"GetLabelDays",
				_GetTemplateForGetLabelDays()
			},
			{
				"GetLabelHour",
				_GetTemplateForGetLabelHour()
			},
			{
				"GetLabelHours",
				_GetTemplateForGetLabelHours()
			},
			{
				"GetLabelMinute",
				_GetTemplateForGetLabelMinute()
			},
			{
				"GetLabelMinutes",
				_GetTemplateForGetLabelMinutes()
			},
			{
				"GetLabelMonth",
				_GetTemplateForGetLabelMonth()
			},
			{
				"GetLabelMonths",
				_GetTemplateForGetLabelMonths()
			},
			{
				"GetLabelMonthsUppercase",
				_GetTemplateForGetLabelMonthsUppercase()
			},
			{
				"GetLabelSecond",
				_GetTemplateForGetLabelSecond()
			},
			{
				"GetLabelSeconds",
				_GetTemplateForGetLabelSeconds()
			},
			{
				"GetLabelWeek",
				_GetTemplateForGetLabelWeek()
			},
			{
				"GetLabelWeeks",
				_GetTemplateForGetLabelWeeks()
			},
			{
				"GetLabelYear",
				_GetTemplateForGetLabelYear()
			},
			{
				"GetLabelYears",
				_GetTemplateForGetLabelYears()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.WebUtil";
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public virtual string GetLabelDay(string day)
	{
		return $"{day} day";
	}

	protected virtual string _GetTemplateForGetLabelDay()
	{
		return "{day} day";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public virtual string GetLabelDays(string days)
	{
		return $"{days} days";
	}

	protected virtual string _GetTemplateForGetLabelDays()
	{
		return "{days} days";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public virtual string GetLabelHour(string hour)
	{
		return $"{hour} hour";
	}

	protected virtual string _GetTemplateForGetLabelHour()
	{
		return "{hour} hour";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public virtual string GetLabelHours(string hours)
	{
		return $"{hours} hours";
	}

	protected virtual string _GetTemplateForGetLabelHours()
	{
		return "{hours} hours";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public virtual string GetLabelMinute(string minute)
	{
		return $"{minute} minute";
	}

	protected virtual string _GetTemplateForGetLabelMinute()
	{
		return "{minute} minute";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public virtual string GetLabelMinutes(string minutes)
	{
		return $"{minutes} minutes";
	}

	protected virtual string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes} minutes";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public virtual string GetLabelMonth(string month)
	{
		return $"{month} month";
	}

	protected virtual string _GetTemplateForGetLabelMonth()
	{
		return "{month} month";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public virtual string GetLabelMonths(string months)
	{
		return $"{months} months";
	}

	protected virtual string _GetTemplateForGetLabelMonths()
	{
		return "{months} months";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public virtual string GetLabelMonthsUppercase(string number)
	{
		return $"{number} Months";
	}

	protected virtual string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number} Months";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public virtual string GetLabelSecond(string second)
	{
		return $"{second} second";
	}

	protected virtual string _GetTemplateForGetLabelSecond()
	{
		return "{second} second";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public virtual string GetLabelSeconds(string seconds)
	{
		return $"{seconds} seconds";
	}

	protected virtual string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds} seconds";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public virtual string GetLabelWeek(string week)
	{
		return $"{week} week";
	}

	protected virtual string _GetTemplateForGetLabelWeek()
	{
		return "{week} week";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public virtual string GetLabelWeeks(string weeks)
	{
		return $"{weeks} weeks";
	}

	protected virtual string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks} weeks";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public virtual string GetLabelYear(string year)
	{
		return $"{year} year";
	}

	protected virtual string _GetTemplateForGetLabelYear()
	{
		return "{year} year";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public virtual string GetLabelYears(string years)
	{
		return $"{years} years";
	}

	protected virtual string _GetTemplateForGetLabelYears()
	{
		return "{years} years";
	}
}
