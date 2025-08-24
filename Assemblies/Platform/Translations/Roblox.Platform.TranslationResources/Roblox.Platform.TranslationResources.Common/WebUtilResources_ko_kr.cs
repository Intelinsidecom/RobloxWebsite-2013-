namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_ko_kr : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day}일";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day}일";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days}일";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days}일";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour}시간";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour}시간";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours}시간";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours}시간";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute}분";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute}분";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes}분";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes}분";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month}개월";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month}개월";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months}개월";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months}개월";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public override string GetLabelMonthsUppercase(string number)
	{
		return $"{number}개월";
	}

	protected override string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number}개월";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public override string GetLabelSecond(string second)
	{
		return $"{second}초";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second}초";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds}초";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds}초";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week}주";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week}주";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks}주";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks}주";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year}년";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year}년";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years}년";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years}년";
	}
}
