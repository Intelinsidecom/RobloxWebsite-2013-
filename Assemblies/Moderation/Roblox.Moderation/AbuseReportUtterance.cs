namespace Roblox.Moderation;

public class AbuseReportUtterance : IUtterable
{
	private readonly string _ExpressionText;

	private readonly IUtteranceSource _Source;

	private readonly long _UttererID;

	private readonly string _LanguageCode;

	public string ExpressionText => _ExpressionText;

	public IUtteranceSource Source => _Source;

	public long UttererID => _UttererID;

	public string LanguageCode => _LanguageCode;

	public AbuseReportUtterance(long uttererId, IUtteranceSource source, string expressionText, string languageCode = null)
	{
		_ExpressionText = expressionText;
		_Source = source;
		_UttererID = uttererId;
		_LanguageCode = languageCode;
	}
}
