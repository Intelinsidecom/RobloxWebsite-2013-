namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlaceThumbnailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlaceThumbnailsResources_pt_br : PlaceThumbnailsResources_en_us, IPlaceThumbnailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueToVideo => "Continuar para o vÃ­deo";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "VocÃª estÃ¡ prestes a sair do Roblox para assistir um vÃ­deo no Youtube.";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "O Youtube nÃ£o faz parte de Roblox.com e tÃªm uma polÃ­tica de privacidade separada.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "VocÃª estÃ¡ saindo do Roblox";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "PrÃ³ximo";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Anterior";

	public PlaceThumbnailsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "Continuar para o vÃ­deo";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "VocÃª estÃ¡ prestes a sair do Roblox para assistir um vÃ­deo no Youtube.";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "O Youtube nÃ£o faz parte de Roblox.com e tÃªm uma polÃ­tica de privacidade separada.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "VocÃª estÃ¡ saindo do Roblox";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "PrÃ³ximo";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Anterior";
	}
}


}
