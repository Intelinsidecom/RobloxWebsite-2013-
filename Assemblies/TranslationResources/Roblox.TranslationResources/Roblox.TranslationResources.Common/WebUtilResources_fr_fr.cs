namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_fr_fr : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day}\u00a0jour";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day}\u00a0jour";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days}\u00a0jours";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days}\u00a0jours";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour}\u00a0heure";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour}\u00a0heure";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours}\u00a0heures";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours}\u00a0heures";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute}\u00a0minute";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute}\u00a0minute";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes}\u00a0minutes";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes}\u00a0minutes";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month}\u00a0mois";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month}\u00a0mois";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months}\u00a0mois";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months}\u00a0mois";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public override string GetLabelMonthsUppercase(string number)
	{
		return $"{number}\u00a0Mois";
	}

	protected override string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number}\u00a0Mois";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public override string GetLabelSecond(string second)
	{
		return $"{second}\u00a0seconde";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second}\u00a0seconde";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds}\u00a0secondes";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds}\u00a0secondes";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week}\u00a0semaine";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week}\u00a0semaine";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks}\u00a0semaines";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks}\u00a0semaines";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year}\u00a0an";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year}\u00a0an";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years}\u00a0ans";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years}\u00a0ans";
	}
}
