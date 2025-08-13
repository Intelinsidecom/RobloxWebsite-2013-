using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ChatResources_en_us : TranslationResourcesBase, IChatResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public virtual string ActionAdd => "Add";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public virtual string ActionBuyAccess => "Buy Access";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public virtual string ActionCreate => "Create";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public virtual string ActionJoin => "Join";

	/// <summary>
	/// Key: "Action.JoinVoice"
	/// Join voice call
	/// English String: "Join"
	/// </summary>
	public virtual string ActionJoinVoice => "Join";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public virtual string ActionLeave => "Leave";

	/// <summary>
	/// Key: "Action.LeaveVoice"
	/// Leave voice chat
	/// English String: "Leave"
	/// </summary>
	public virtual string ActionLeaveVoice => "Leave";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public virtual string ActionMute => "Mute";

	/// <summary>
	/// Key: "Action.MuteMic"
	/// English String: "Mute Your Microphone"
	/// </summary>
	public virtual string ActionMuteMic => "Mute Your Microphone";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public virtual string ActionRemove => "Remove";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public virtual string ActionReport => "Report";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public virtual string ActionSend => "Send";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public virtual string ActionSet => "Set";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public virtual string ActionStartParty => "Start a Party";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public virtual string ActionStay => "Stay";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public virtual string ActionTurnOn => "Turn On";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public virtual string ActionUnmute => "Unmute";

	/// <summary>
	/// Key: "Action.UnmuteMic"
	/// English String: "Unmute Your Microphone"
	/// </summary>
	public virtual string ActionUnmuteMic => "Unmute Your Microphone";

	/// <summary>
	/// Key: "Description.JoinInVoiceChat"
	/// English String: "Click Join to join the call"
	/// </summary>
	public virtual string DescriptionJoinInVoiceChat => "Click Join to join the call";

	/// <summary>
	/// Key: "Description.LeaveVoiceChat"
	/// English String: "Click Leave to leave the call"
	/// </summary>
	public virtual string DescriptionLeaveVoiceChat => "Click Leave to leave the call";

	/// <summary>
	/// Key: "Description.UserInVoice"
	/// User is actively in voice chat
	/// English String: "You are in the voice chat"
	/// </summary>
	public virtual string DescriptionUserInVoice => "You are in the voice chat";

	/// <summary>
	/// Key: "Description.VoiceNotConnect"
	/// Error handling message when voice chat api return errors
	/// English String: "Could not connect to voice chat"
	/// </summary>
	public virtual string DescriptionVoiceNotConnect => "Could not connect to voice chat";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public virtual string HeadingBuyItem => "Buy Item";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public virtual string HeadingChat => "Chat";

	public virtual string HeadingChatAndParty => "Chat & Party";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public virtual string HeadingConfirmLeaving => "Are you sure to leave this chat group?";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public virtual string HeadingContinueToReport => "Continue to report?";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public virtual string HeadingCreateParty => "Create Party";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public virtual string HeadingLeaveChatGroup => "Leave Chat Group";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public virtual string HeadingLeaveChatGroupQ => "Leave Chat Group?";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public virtual string HeadingNewChatGroup => "New Chat Group";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public virtual string HeadingRemoveUser => "Remove User?";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public virtual string HeadingReport => "Report";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public virtual string LabelAddFriends => "Add Friends";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public virtual string LabelBuyButton => "Buy";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public virtual string LabelChangeChatGroupName => "Change your chat group name";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public virtual string LabelChatDetails => "Chat Details";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public virtual string LabelChatGroupName => "Chat Group Name";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public virtual string LabelClose => "Close";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public virtual string LabelConversationNotifications => "Notifications";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public virtual string LabelConversationNotificationsOn => "On";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public virtual string LabelDetailsPlayTogether => "PlayTogether";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public virtual string LabelFindGame => "Find Game";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public virtual string LabelGameNotAvailableButton => "Not Available";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public virtual string LabelGeneral => "General";

	/// <summary>
	/// Key: "Label.InCall"
	/// In voice call
	/// English String: "In Call"
	/// </summary>
	public virtual string LabelInCall => "In Call";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public virtual string LabelInGame => "In Game";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public virtual string LabelInputPlaceHolderSearchForFriends => "Search for friends";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public virtual string LabelInputPlaceHolderSendMessage => "Send a message";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public virtual string LabelInStudio => "In Studio";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public virtual string LabelJoinButton => "Join";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public virtual string LabelJoinGame => "Join Game";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public virtual string LabelJoinParty => "Join Party";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public virtual string LabelLeaveChatGroup => "Leave Chat Group";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public virtual string LabelLeaveParty => "Leave Party";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public virtual string LabelMember => "Member";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public virtual string LabelMembers => "Members";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public virtual string LabelMute15Minutes => "For 15 minutes";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public virtual string LabelMute1Hour => "For an hour";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public virtual string LabelMute24Hours => "For a day";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public virtual string LabelMute8Hours => "For 8 hours";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public virtual string LabelMuteConversationNotificationsForGroup => "Mute notifications for this chat group";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public virtual string LabelMuteConversationNotificationsForOneToOne => "Mute notifications for this conversation";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public virtual string LabelMuteInfinite => "Until I turn them back on";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public virtual string LabelNameYourChangeGroup => "Name your change group";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public virtual string LabelNameYourChatGroup => "Name your chat group";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public virtual string LabelNotImplementedMessageType => "This message could not be displayed.";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public virtual string LabelNotInCall => "Not in call";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public virtual string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public virtual string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public virtual string LabelPinGameTooltip => "Pin Game";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public virtual string LabelPinnedGame => "Pinned Game";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public virtual string LabelPlayButton => "Play";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public virtual string LabelPlayGames => "Play Games";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public virtual string LabelPlayTogether => "Play Together";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public virtual string LabelRecommendedGames => "Recommended";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public virtual string LabelSeeLess => "See Less";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public virtual string LabelSeeMore => "See More";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public virtual string LabelShowLessGames => "Show Less";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public virtual string LabelSpanTitleCreateGroupNeeds2More => "Add at least 2 people to create chat group";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public virtual string LabelSpanTitleLoading => "loading ...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public virtual string LabelTimestampOffUntilTomorrow => "Off until tomorrow";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public virtual string LabelTimestampOffUntilTurnedBackOn => "Off until turned back on\"";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public virtual string LabelTurnOnConversationNotificationsPrompt => "Do you want to turn on notifications?";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public virtual string LabelUnpinGameTooltip => "Unpin Game";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public virtual string LabelViewDetailsButton => "View Details";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public virtual string LabelViewProfile => "View Profile";

	/// <summary>
	/// Key: "Label.VoiceSetting"
	/// Voice chat setting label
	/// English String: "Voice Settings"
	/// </summary>
	public virtual string LabelVoiceSetting => "Voice Settings";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public virtual string LabelYesterday => "Yesterday";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public virtual string MessageConversationTitleModerated => "Chat group name was moderated.";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public virtual string MessageDefault => "Not everyone in this chat can see your message.";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public virtual string MessageDefaultErrorMsg => "An error occurred";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public virtual string MessageError => "Error";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public virtual string MessageJoinPartyText => "The party leader is finding a game to play.";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public virtual string MessageMakeFriendsToChatNPlay => "Make friends to start chatting and partying!";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public virtual string MessageMessageContentModerated => "Your message was moderated and not sent.";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public virtual string MessageMessageFilterForReceivers => "Not everyone in this chat can see your message.";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public virtual string MessageNoConnectionMsg => "Connecting...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public virtual string MessagePartyInviteMsg => "PARTY INVITE!";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public virtual string MessagePlayGameUpdate => " is playing the pinned game: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public virtual string MessageTextTooLong => "Your message was too long and not sent.";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public virtual string MessageUnknownMessageType => "A message cannot be displayed";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public virtual string PlayButton => "Play";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public virtual string ResponsePartyInvite => "You received a party Invite.";

	public ChatResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Add",
				_GetTemplateForActionAdd()
			},
			{
				"Action.BuyAccess",
				_GetTemplateForActionBuyAccess()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Create",
				_GetTemplateForActionCreate()
			},
			{
				"Action.Join",
				_GetTemplateForActionJoin()
			},
			{
				"Action.JoinVoice",
				_GetTemplateForActionJoinVoice()
			},
			{
				"Action.Leave",
				_GetTemplateForActionLeave()
			},
			{
				"Action.LeaveVoice",
				_GetTemplateForActionLeaveVoice()
			},
			{
				"Action.Mute",
				_GetTemplateForActionMute()
			},
			{
				"Action.MuteMic",
				_GetTemplateForActionMuteMic()
			},
			{
				"Action.Remove",
				_GetTemplateForActionRemove()
			},
			{
				"Action.Report",
				_GetTemplateForActionReport()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"Action.Send",
				_GetTemplateForActionSend()
			},
			{
				"Action.Set",
				_GetTemplateForActionSet()
			},
			{
				"Action.StartParty",
				_GetTemplateForActionStartParty()
			},
			{
				"Action.Stay",
				_GetTemplateForActionStay()
			},
			{
				"Action.TurnOn",
				_GetTemplateForActionTurnOn()
			},
			{
				"Action.Unmute",
				_GetTemplateForActionUnmute()
			},
			{
				"Action.UnmuteMic",
				_GetTemplateForActionUnmuteMic()
			},
			{
				"Description.JoinInVoiceChat",
				_GetTemplateForDescriptionJoinInVoiceChat()
			},
			{
				"Description.LeaveVoiceChat",
				_GetTemplateForDescriptionLeaveVoiceChat()
			},
			{
				"Description.UserInVoice",
				_GetTemplateForDescriptionUserInVoice()
			},
			{
				"Description.VoiceNotConnect",
				_GetTemplateForDescriptionVoiceNotConnect()
			},
			{
				"Heading.BuyItem",
				_GetTemplateForHeadingBuyItem()
			},
			{
				"Heading.Chat",
				_GetTemplateForHeadingChat()
			},
			{
				"Heading.ChatAndParty",
				_GetTemplateForHeadingChatAndParty()
			},
			{
				"Heading.ConfirmLeaving",
				_GetTemplateForHeadingConfirmLeaving()
			},
			{
				"Heading.ContinueToReport",
				_GetTemplateForHeadingContinueToReport()
			},
			{
				"Heading.CreateParty",
				_GetTemplateForHeadingCreateParty()
			},
			{
				"Heading.LeaveChatGroup",
				_GetTemplateForHeadingLeaveChatGroup()
			},
			{
				"Heading.LeaveChatGroupQ",
				_GetTemplateForHeadingLeaveChatGroupQ()
			},
			{
				"Heading.NewChatGroup",
				_GetTemplateForHeadingNewChatGroup()
			},
			{
				"Heading.RemoveUser",
				_GetTemplateForHeadingRemoveUser()
			},
			{
				"Heading.Report",
				_GetTemplateForHeadingReport()
			},
			{
				"Label.AddFriends",
				_GetTemplateForLabelAddFriends()
			},
			{
				"Label.BuyAccessToGameForModal",
				_GetTemplateForLabelBuyAccessToGameForModal()
			},
			{
				"Label.BuyButton",
				_GetTemplateForLabelBuyButton()
			},
			{
				"Label.ChangeChatGroupName",
				_GetTemplateForLabelChangeChatGroupName()
			},
			{
				"Label.ChatDetails",
				_GetTemplateForLabelChatDetails()
			},
			{
				"Label.ChatGroupName",
				_GetTemplateForLabelChatGroupName()
			},
			{
				"Label.Close",
				_GetTemplateForLabelClose()
			},
			{
				"Label.ConversationNotifications",
				_GetTemplateForLabelConversationNotifications()
			},
			{
				"Label.ConversationNotificationsOn",
				_GetTemplateForLabelConversationNotificationsOn()
			},
			{
				"Label.Details.PlayTogether",
				_GetTemplateForLabelDetailsPlayTogether()
			},
			{
				"Label.FindGame",
				_GetTemplateForLabelFindGame()
			},
			{
				"Label.GameNotAvailableButton",
				_GetTemplateForLabelGameNotAvailableButton()
			},
			{
				"Label.General",
				_GetTemplateForLabelGeneral()
			},
			{
				"Label.InCall",
				_GetTemplateForLabelInCall()
			},
			{
				"Label.InGame",
				_GetTemplateForLabelInGame()
			},
			{
				"Label.InputPlaceHolder.SearchForFriends",
				_GetTemplateForLabelInputPlaceHolderSearchForFriends()
			},
			{
				"Label.InputPlaceHolder.SendMessage",
				_GetTemplateForLabelInputPlaceHolderSendMessage()
			},
			{
				"Label.InStudio",
				_GetTemplateForLabelInStudio()
			},
			{
				"Label.JoinButton",
				_GetTemplateForLabelJoinButton()
			},
			{
				"Label.JoinGame",
				_GetTemplateForLabelJoinGame()
			},
			{
				"Label.JoinParty",
				_GetTemplateForLabelJoinParty()
			},
			{
				"Label.LeaveChatGroup",
				_GetTemplateForLabelLeaveChatGroup()
			},
			{
				"Label.LeaveParty",
				_GetTemplateForLabelLeaveParty()
			},
			{
				"Label.Member",
				_GetTemplateForLabelMember()
			},
			{
				"Label.MemberJoinText",
				_GetTemplateForLabelMemberJoinText()
			},
			{
				"Label.Members",
				_GetTemplateForLabelMembers()
			},
			{
				"Label.Mute15Minutes",
				_GetTemplateForLabelMute15Minutes()
			},
			{
				"Label.Mute1Hour",
				_GetTemplateForLabelMute1Hour()
			},
			{
				"Label.Mute24Hours",
				_GetTemplateForLabelMute24Hours()
			},
			{
				"Label.Mute8Hours",
				_GetTemplateForLabelMute8Hours()
			},
			{
				"Label.MuteConversationNotificationsForGroup",
				_GetTemplateForLabelMuteConversationNotificationsForGroup()
			},
			{
				"Label.MuteConversationNotificationsForOneToOne",
				_GetTemplateForLabelMuteConversationNotificationsForOneToOne()
			},
			{
				"Label.MuteInfinite",
				_GetTemplateForLabelMuteInfinite()
			},
			{
				"Label.MuteSomeone",
				_GetTemplateForLabelMuteSomeone()
			},
			{
				"Label.NameYourChangeGroup",
				_GetTemplateForLabelNameYourChangeGroup()
			},
			{
				"Label.NameYourChatGroup",
				_GetTemplateForLabelNameYourChatGroup()
			},
			{
				"Label.NotImplementedMessageType",
				_GetTemplateForLabelNotImplementedMessageType()
			},
			{
				"Label.NotInCall",
				_GetTemplateForLabelNotInCall()
			},
			{
				"Label.Offline",
				_GetTemplateForLabelOffline()
			},
			{
				"Label.Online",
				_GetTemplateForLabelOnline()
			},
			{
				"Label.PartyLeaderTooltip",
				_GetTemplateForLabelPartyLeaderTooltip()
			},
			{
				"Label.PartyMemberTooltip",
				_GetTemplateForLabelPartyMemberTooltip()
			},
			{
				"Label.PartyName",
				_GetTemplateForLabelPartyName()
			},
			{
				"Label.PendingMemberTooltip",
				_GetTemplateForLabelPendingMemberTooltip()
			},
			{
				"Label.PinGameTooltip",
				_GetTemplateForLabelPinGameTooltip()
			},
			{
				"Label.PinnedGame",
				_GetTemplateForLabelPinnedGame()
			},
			{
				"Label.PlayButton",
				_GetTemplateForLabelPlayButton()
			},
			{
				"Label.PlayGames",
				_GetTemplateForLabelPlayGames()
			},
			{
				"Label.PlayingGame",
				_GetTemplateForLabelPlayingGame()
			},
			{
				"Label.PlayTogether",
				_GetTemplateForLabelPlayTogether()
			},
			{
				"Label.RecommendedGames",
				_GetTemplateForLabelRecommendedGames()
			},
			{
				"Label.SeeLess",
				_GetTemplateForLabelSeeLess()
			},
			{
				"Label.SeeMore",
				_GetTemplateForLabelSeeMore()
			},
			{
				"Label.ShowLessGames",
				_GetTemplateForLabelShowLessGames()
			},
			{
				"Label.ShowMoreGames",
				_GetTemplateForLabelShowMoreGames()
			},
			{
				"Label.SpanTitle.CreateGroupNeeds2More",
				_GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
			},
			{
				"Label.SpanTitle.Loading",
				_GetTemplateForLabelSpanTitleLoading()
			},
			{
				"Label.TimestampOffUntilCertainTime",
				_GetTemplateForLabelTimestampOffUntilCertainTime()
			},
			{
				"Label.TimestampOffUntilTomorrow",
				_GetTemplateForLabelTimestampOffUntilTomorrow()
			},
			{
				"Label.TimestampOffUntilTurnedBackOn",
				_GetTemplateForLabelTimestampOffUntilTurnedBackOn()
			},
			{
				"Label.TurnOnConversationNotificationsPrompt",
				_GetTemplateForLabelTurnOnConversationNotificationsPrompt()
			},
			{
				"Label.UnmuteUser",
				_GetTemplateForLabelUnmuteUser()
			},
			{
				"Label.UnpinGameTooltip",
				_GetTemplateForLabelUnpinGameTooltip()
			},
			{
				"Label.ViewDetailsButton",
				_GetTemplateForLabelViewDetailsButton()
			},
			{
				"Label.ViewProfile",
				_GetTemplateForLabelViewProfile()
			},
			{
				"Label.VoiceSetting",
				_GetTemplateForLabelVoiceSetting()
			},
			{
				"Label.Yesterday",
				_GetTemplateForLabelYesterday()
			},
			{
				"Lable.MuteUser",
				_GetTemplateForLableMuteUser()
			},
			{
				"Message.ChatPrivacySetting",
				_GetTemplateForMessageChatPrivacySetting()
			},
			{
				"Message.conversationTitleChangedText",
				_GetTemplateForMessageconversationTitleChangedText()
			},
			{
				"Message.ConversationTitleModerated",
				_GetTemplateForMessageConversationTitleModerated()
			},
			{
				"Message.Default",
				_GetTemplateForMessageDefault()
			},
			{
				"Message.DefaultErrorMsg",
				_GetTemplateForMessageDefaultErrorMsg()
			},
			{
				"Message.DefaultTitleForMsg",
				_GetTemplateForMessageDefaultTitleForMsg()
			},
			{
				"Message.DefaultTitleForPartyInvite",
				_GetTemplateForMessageDefaultTitleForPartyInvite()
			},
			{
				"Message.Error",
				_GetTemplateForMessageError()
			},
			{
				"Message.FindGameToPlay",
				_GetTemplateForMessageFindGameToPlay()
			},
			{
				"Message.JoinPartyText",
				_GetTemplateForMessageJoinPartyText()
			},
			{
				"Message.MakeFriendsToChatNPlay",
				_GetTemplateForMessageMakeFriendsToChatNPlay()
			},
			{
				"Message.MessageContentModerated",
				_GetTemplateForMessageMessageContentModerated()
			},
			{
				"Message.MessageFilterForReceivers",
				_GetTemplateForMessageMessageFilterForReceivers()
			},
			{
				"Message.NoConnectionMsg",
				_GetTemplateForMessageNoConnectionMsg()
			},
			{
				"Message.PartyInviteMsg",
				_GetTemplateForMessagePartyInviteMsg()
			},
			{
				"Message.PinGameUpdate",
				_GetTemplateForMessagePinGameUpdate()
			},
			{
				"Message.PlayGameUpdate",
				_GetTemplateForMessagePlayGameUpdate()
			},
			{
				"Message.TextTooLong",
				_GetTemplateForMessageTextTooLong()
			},
			{
				"Message.ToastText",
				_GetTemplateForMessageToastText()
			},
			{
				"Message.UnknownMessageType",
				_GetTemplateForMessageUnknownMessageType()
			},
			{
				"PlayButton",
				_GetTemplateForPlayButton()
			},
			{
				"Response.PartyInvite",
				_GetTemplateForResponsePartyInvite()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Chat";
	}

	protected virtual string _GetTemplateForActionAdd()
	{
		return "Add";
	}

	protected virtual string _GetTemplateForActionBuyAccess()
	{
		return "Buy Access";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionCreate()
	{
		return "Create";
	}

	protected virtual string _GetTemplateForActionJoin()
	{
		return "Join";
	}

	protected virtual string _GetTemplateForActionJoinVoice()
	{
		return "Join";
	}

	protected virtual string _GetTemplateForActionLeave()
	{
		return "Leave";
	}

	protected virtual string _GetTemplateForActionLeaveVoice()
	{
		return "Leave";
	}

	protected virtual string _GetTemplateForActionMute()
	{
		return "Mute";
	}

	protected virtual string _GetTemplateForActionMuteMic()
	{
		return "Mute Your Microphone";
	}

	protected virtual string _GetTemplateForActionRemove()
	{
		return "Remove";
	}

	protected virtual string _GetTemplateForActionReport()
	{
		return "Report";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForActionSend()
	{
		return "Send";
	}

	protected virtual string _GetTemplateForActionSet()
	{
		return "Set";
	}

	protected virtual string _GetTemplateForActionStartParty()
	{
		return "Start a Party";
	}

	protected virtual string _GetTemplateForActionStay()
	{
		return "Stay";
	}

	protected virtual string _GetTemplateForActionTurnOn()
	{
		return "Turn On";
	}

	protected virtual string _GetTemplateForActionUnmute()
	{
		return "Unmute";
	}

	protected virtual string _GetTemplateForActionUnmuteMic()
	{
		return "Unmute Your Microphone";
	}

	protected virtual string _GetTemplateForDescriptionJoinInVoiceChat()
	{
		return "Click Join to join the call";
	}

	protected virtual string _GetTemplateForDescriptionLeaveVoiceChat()
	{
		return "Click Leave to leave the call";
	}

	protected virtual string _GetTemplateForDescriptionUserInVoice()
	{
		return "You are in the voice chat";
	}

	protected virtual string _GetTemplateForDescriptionVoiceNotConnect()
	{
		return "Could not connect to voice chat";
	}

	protected virtual string _GetTemplateForHeadingBuyItem()
	{
		return "Buy Item";
	}

	protected virtual string _GetTemplateForHeadingChat()
	{
		return "Chat";
	}

	protected virtual string _GetTemplateForHeadingChatAndParty()
	{
		return "Chat & Party";
	}

	protected virtual string _GetTemplateForHeadingConfirmLeaving()
	{
		return "Are you sure to leave this chat group?";
	}

	protected virtual string _GetTemplateForHeadingContinueToReport()
	{
		return "Continue to report?";
	}

	protected virtual string _GetTemplateForHeadingCreateParty()
	{
		return "Create Party";
	}

	protected virtual string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "Leave Chat Group";
	}

	protected virtual string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "Leave Chat Group?";
	}

	protected virtual string _GetTemplateForHeadingNewChatGroup()
	{
		return "New Chat Group";
	}

	protected virtual string _GetTemplateForHeadingRemoveUser()
	{
		return "Remove User?";
	}

	protected virtual string _GetTemplateForHeadingReport()
	{
		return "Report";
	}

	protected virtual string _GetTemplateForLabelAddFriends()
	{
		return "Add Friends";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public virtual string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?";
	}

	protected virtual string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?";
	}

	protected virtual string _GetTemplateForLabelBuyButton()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForLabelChangeChatGroupName()
	{
		return "Change your chat group name";
	}

	protected virtual string _GetTemplateForLabelChatDetails()
	{
		return "Chat Details";
	}

	protected virtual string _GetTemplateForLabelChatGroupName()
	{
		return "Chat Group Name";
	}

	protected virtual string _GetTemplateForLabelClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForLabelConversationNotifications()
	{
		return "Notifications";
	}

	protected virtual string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "On";
	}

	protected virtual string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "PlayTogether";
	}

	protected virtual string _GetTemplateForLabelFindGame()
	{
		return "Find Game";
	}

	protected virtual string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "Not Available";
	}

	protected virtual string _GetTemplateForLabelGeneral()
	{
		return "General";
	}

	protected virtual string _GetTemplateForLabelInCall()
	{
		return "In Call";
	}

	protected virtual string _GetTemplateForLabelInGame()
	{
		return "In Game";
	}

	protected virtual string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "Search for friends";
	}

	protected virtual string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "Send a message";
	}

	protected virtual string _GetTemplateForLabelInStudio()
	{
		return "In Studio";
	}

	protected virtual string _GetTemplateForLabelJoinButton()
	{
		return "Join";
	}

	protected virtual string _GetTemplateForLabelJoinGame()
	{
		return "Join Game";
	}

	protected virtual string _GetTemplateForLabelJoinParty()
	{
		return "Join Party";
	}

	protected virtual string _GetTemplateForLabelLeaveChatGroup()
	{
		return "Leave Chat Group";
	}

	protected virtual string _GetTemplateForLabelLeaveParty()
	{
		return "Leave Party";
	}

	protected virtual string _GetTemplateForLabelMember()
	{
		return "Member";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public virtual string LabelMemberJoinText(string userName)
	{
		return $"{userName} joined the party";
	}

	protected virtual string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} joined the party";
	}

	protected virtual string _GetTemplateForLabelMembers()
	{
		return "Members";
	}

	protected virtual string _GetTemplateForLabelMute15Minutes()
	{
		return "For 15 minutes";
	}

	protected virtual string _GetTemplateForLabelMute1Hour()
	{
		return "For an hour";
	}

	protected virtual string _GetTemplateForLabelMute24Hours()
	{
		return "For a day";
	}

	protected virtual string _GetTemplateForLabelMute8Hours()
	{
		return "For 8 hours";
	}

	protected virtual string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "Mute notifications for this chat group";
	}

	protected virtual string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "Mute notifications for this conversation";
	}

	protected virtual string _GetTemplateForLabelMuteInfinite()
	{
		return "Until I turn them back on";
	}

	/// <summary>
	/// Key: "Label.MuteSomeone"
	/// this is a mistake should not url , please skip this
	/// English String: "Mute {username}"
	/// </summary>
	public virtual string LabelMuteSomeone(string username)
	{
		return $"Mute {username}";
	}

	protected virtual string _GetTemplateForLabelMuteSomeone()
	{
		return "Mute {username}";
	}

	protected virtual string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "Name your change group";
	}

	protected virtual string _GetTemplateForLabelNameYourChatGroup()
	{
		return "Name your chat group";
	}

	protected virtual string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "This message could not be displayed.";
	}

	protected virtual string _GetTemplateForLabelNotInCall()
	{
		return "Not in call";
	}

	protected virtual string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected virtual string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public virtual string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} is the party leader";
	}

	protected virtual string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} is the party leader";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public virtual string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} is in the party";
	}

	protected virtual string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} is in the party";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public virtual string LabelPartyName(string title)
	{
		return $"Party : {title}";
	}

	protected virtual string _GetTemplateForLabelPartyName()
	{
		return "Party : {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public virtual string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} is not in the party";
	}

	protected virtual string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} is not in the party";
	}

	protected virtual string _GetTemplateForLabelPinGameTooltip()
	{
		return "Pin Game";
	}

	protected virtual string _GetTemplateForLabelPinnedGame()
	{
		return "Pinned Game";
	}

	protected virtual string _GetTemplateForLabelPlayButton()
	{
		return "Play";
	}

	protected virtual string _GetTemplateForLabelPlayGames()
	{
		return "Play Games";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public virtual string LabelPlayingGame(string game)
	{
		return $"Playing {game}";
	}

	protected virtual string _GetTemplateForLabelPlayingGame()
	{
		return "Playing {game}";
	}

	protected virtual string _GetTemplateForLabelPlayTogether()
	{
		return "Play Together";
	}

	protected virtual string _GetTemplateForLabelRecommendedGames()
	{
		return "Recommended";
	}

	protected virtual string _GetTemplateForLabelSeeLess()
	{
		return "See Less";
	}

	protected virtual string _GetTemplateForLabelSeeMore()
	{
		return "See More";
	}

	protected virtual string _GetTemplateForLabelShowLessGames()
	{
		return "Show Less";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public virtual string LabelShowMoreGames(string count)
	{
		return $"Show More (+{count})";
	}

	protected virtual string _GetTemplateForLabelShowMoreGames()
	{
		return "Show More (+{count})";
	}

	protected virtual string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "Add at least 2 people to create chat group";
	}

	protected virtual string _GetTemplateForLabelSpanTitleLoading()
	{
		return "loading ...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public virtual string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"Off until {timestamp}";
	}

	protected virtual string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "Off until {timestamp}";
	}

	protected virtual string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "Off until tomorrow";
	}

	protected virtual string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "Off until turned back on\"";
	}

	protected virtual string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "Do you want to turn on notifications?";
	}

	/// <summary>
	/// Key: "Label.UnmuteUser"
	/// English String: "Unmute {username}"
	/// </summary>
	public virtual string LabelUnmuteUser(string username)
	{
		return $"Unmute {username}";
	}

	protected virtual string _GetTemplateForLabelUnmuteUser()
	{
		return "Unmute {username}";
	}

	protected virtual string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "Unpin Game";
	}

	protected virtual string _GetTemplateForLabelViewDetailsButton()
	{
		return "View Details";
	}

	protected virtual string _GetTemplateForLabelViewProfile()
	{
		return "View Profile";
	}

	protected virtual string _GetTemplateForLabelVoiceSetting()
	{
		return "Voice Settings";
	}

	protected virtual string _GetTemplateForLabelYesterday()
	{
		return "Yesterday";
	}

	/// <summary>
	/// Key: "Lable.MuteUser"
	/// must user's voice chat
	/// English String: "Mute {username}"
	/// </summary>
	public virtual string LableMuteUser(string username)
	{
		return $"Mute {username}";
	}

	protected virtual string _GetTemplateForLableMuteUser()
	{
		return "Mute {username}";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public virtual string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}";
	}

	protected virtual string _GetTemplateForMessageChatPrivacySetting()
	{
		return "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public virtual string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName} named the chat group: {groupName}";
	}

	protected virtual string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName} named the chat group: {groupName}";
	}

	protected virtual string _GetTemplateForMessageConversationTitleModerated()
	{
		return "Chat group name was moderated.";
	}

	protected virtual string _GetTemplateForMessageDefault()
	{
		return "Not everyone in this chat can see your message.";
	}

	protected virtual string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "An error occurred";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public virtual string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName} says ...";
	}

	protected virtual string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName} says ...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public virtual string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"Party invite from {userName}";
	}

	protected virtual string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "Party invite from {userName}";
	}

	protected virtual string _GetTemplateForMessageError()
	{
		return "Error";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public virtual string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}Find Games{endLink} to play with your friends!";
	}

	protected virtual string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}Find Games{endLink} to play with your friends!";
	}

	protected virtual string _GetTemplateForMessageJoinPartyText()
	{
		return "The party leader is finding a game to play.";
	}

	protected virtual string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "Make friends to start chatting and partying!";
	}

	protected virtual string _GetTemplateForMessageMessageContentModerated()
	{
		return "Your message was moderated and not sent.";
	}

	protected virtual string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "Not everyone in this chat can see your message.";
	}

	protected virtual string _GetTemplateForMessageNoConnectionMsg()
	{
		return "Connecting...";
	}

	protected virtual string _GetTemplateForMessagePartyInviteMsg()
	{
		return "PARTY INVITE!";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public virtual string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} chose a game to play together: {gameName}";
	}

	protected virtual string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} chose a game to play together: {gameName}";
	}

	protected virtual string _GetTemplateForMessagePlayGameUpdate()
	{
		return " is playing the pinned game: ";
	}

	protected virtual string _GetTemplateForMessageTextTooLong()
	{
		return "Your message was too long and not sent.";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public virtual string MessageToastText(string friendNum)
	{
		return $"You can have up to {friendNum} friends in chat group.";
	}

	protected virtual string _GetTemplateForMessageToastText()
	{
		return "You can have up to {friendNum} friends in chat group.";
	}

	protected virtual string _GetTemplateForMessageUnknownMessageType()
	{
		return "A message cannot be displayed";
	}

	protected virtual string _GetTemplateForPlayButton()
	{
		return "Play";
	}

	protected virtual string _GetTemplateForResponsePartyInvite()
	{
		return "You received a party Invite.";
	}
}
