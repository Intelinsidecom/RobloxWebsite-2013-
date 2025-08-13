namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_zh_cjv : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day} 天";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day} 天";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days} 天";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days} 天";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour} 小时";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour} 小时";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours} 小时";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours} 小时";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute} 分";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute} 分";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes} 分";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes} 分";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month} 个月";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month} 个月";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months} 个月";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months} 个月";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public override string GetLabelMonthsUppercase(string number)
	{
		return $"{number} 个月";
	}

	protected override string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number} 个月";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public override string GetLabelSecond(string second)
	{
		return $"{second} 秒";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second} 秒";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds} 秒";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds} 秒";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week} 个星期";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week} 个星期";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks} 个星期";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks} 个星期";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year} 年";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year} 年";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years} 年";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years} 年";
	}
}
