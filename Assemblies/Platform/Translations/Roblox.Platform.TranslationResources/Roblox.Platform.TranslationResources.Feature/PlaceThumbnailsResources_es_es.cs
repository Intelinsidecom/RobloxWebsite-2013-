namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlaceThumbnailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlaceThumbnailsResources_es_es : PlaceThumbnailsResources_en_us, IPlaceThumbnailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueToVideo => "Continuar al vÃ­deo";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "EstÃ¡s a punto de abandonar Roblox para ver un vÃ­deo en YouTube.";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "YouTube no forma parte de Roblox.com y se rige por una polÃ­tica de privacidad separada.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "EstÃ¡s abandonando Roblox";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Siguiente";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Anterior";

	public PlaceThumbnailsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "Continuar al vÃ­deo";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "EstÃ¡s a punto de abandonar Roblox para ver un vÃ­deo en YouTube.";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "YouTube no forma parte de Roblox.com y se rige por una polÃ­tica de privacidad separada.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "EstÃ¡s abandonando Roblox";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Siguiente";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Anterior";
	}
}


}
