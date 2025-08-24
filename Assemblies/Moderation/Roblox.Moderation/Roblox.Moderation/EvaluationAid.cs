using System.Drawing;

namespace Roblox.Moderation;

/// <summary>
/// Holder / renderer for AbuseType + Message + Color.
/// Shared between /Admi &amp; CSWebsite.
/// </summary>
public class EvaluationAid
{
	private readonly AbuseType _AbuseType;

	private readonly Color _VisualCue;

	private readonly string _Message = string.Empty;

	private readonly bool _IsAbuseTypeRecommendation;

	public byte ID => _AbuseType.ID;

	public AbuseType AbuseType => _AbuseType;

	public Color VisualCue => _VisualCue;

	public string Message => _Message;

	public string HtmlText
	{
		get
		{
			if (string.IsNullOrEmpty(Message))
			{
				return _AbuseType.Value;
			}
			return $"<span style=\"background-color:{ColorTranslator.ToHtml(VisualCue)}\">{AbuseType.Value} ({Message})</span>";
		}
	}

	public string AbuseTypeText
	{
		get
		{
			if (string.IsNullOrEmpty(Message))
			{
				return _AbuseType.Value;
			}
			return $"{AbuseType.Value} ({Message})";
		}
	}

	public bool IsAbuseTypeRecommendation => _IsAbuseTypeRecommendation;

	public EvaluationAid(AbuseType abuseType, Color visualCue, string message, bool isAbuseTypeRecommendation)
	{
		_AbuseType = abuseType;
		_VisualCue = visualCue;
		_Message = message;
		_IsAbuseTypeRecommendation = isAbuseTypeRecommendation;
	}
}
