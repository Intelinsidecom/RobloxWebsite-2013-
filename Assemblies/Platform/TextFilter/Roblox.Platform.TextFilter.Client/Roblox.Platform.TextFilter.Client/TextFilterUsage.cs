using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Roblox.TextFilter.Client;

[DataContract(Name = "usageType")]
[JsonConverter(typeof(StringEnumConverter))]
public enum TextFilterUsage
{
	[EnumMember(Value = "asset/audio")]
	Audio,
	[EnumMember(Value = "asset/badge")]
	Badge,
	[EnumMember(Value = "asset/developerproduct")]
	DeveloperProduct,
	[EnumMember(Value = "asset/gamepass")]
	GamePass,
	[EnumMember(Value = "asset/generic")]
	Asset,
	[EnumMember(Value = "asset/group")]
	Group,
	[EnumMember(Value = "asset/outfit")]
	Outfit,
	[EnumMember(Value = "asset/package")]
	Package,
	[EnumMember(Value = "asset/privateserver")]
	PrivateServer,
	[EnumMember(Value = "asset/setpanel")]
	SetPanel,
	[EnumMember(Value = "asset/universe")]
	Universe,
	[EnumMember(Value = "asset/userad")]
	UserAd,
	[EnumMember(Value = "chat/app")]
	AppChat,
	[EnumMember(Value = "chat/game/private")]
	GameChatPrivate,
	[EnumMember(Value = "chat/game/public")]
	GameChatPublic,
	[EnumMember(Value = "chat/privatemessage")]
	PrivateMessage,
	[EnumMember(Value = "post/comment")]
	Comment,
	[EnumMember(Value = "post/sociallink")]
	SocialLink,
	[EnumMember(Value = "post/userdescription")]
	UserDescription,
	[EnumMember(Value = "post/userstatus")]
	UserStatus,
	[EnumMember(Value = "search/studio")]
	StudioSearch,
	[EnumMember(Value = "search/web")]
	WebSearch,
	[EnumMember(Value = "other")]
	Other,
	[EnumMember(Value = "unknown")]
	Unknown
}
