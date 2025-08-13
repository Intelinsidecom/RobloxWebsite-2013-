namespace Roblox.Moderation;

public interface IUtterable
{
	string ExpressionText { get; }

	IUtteranceSource Source { get; }

	long UttererID { get; }

	string LanguageCode { get; }
}
