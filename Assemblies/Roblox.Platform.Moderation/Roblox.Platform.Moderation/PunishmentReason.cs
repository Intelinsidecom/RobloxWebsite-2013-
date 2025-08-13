using System.ComponentModel;

namespace Roblox.Platform.Moderation;

public enum PunishmentReason
{
	[Description("Account Theft")]
	AccountTheft = 1,
	[Description("Alt Spam Accounts")]
	AltSpamAccounts,
	[Description("Bad Username")]
	BadUsername,
	[Description("Dispute")]
	Dispute,
	[Description("Exploiting")]
	Exploiting,
	[Description("Grooming")]
	Grooming,
	[Description("Hate Speech")]
	HateSpeech,
	[Description("Known Fraud")]
	KnownFraud,
	[Description("Real Life Threats")]
	RealLifeThreats,
	[Description("Refund")]
	Refund,
	[Description("Sex Games")]
	SexGames,
	[Description("Selling Assets for USD")]
	SellingAssetsforUSD,
	[Description("Buying Assets for USD")]
	BuyingAssetsforUSD,
	[Description("General Abuse")]
	GeneralAbuse,
	[Description("Other")]
	Other,
	[Description("Bullying")]
	Bullying,
	[Description("Harassment")]
	Harassment,
	[Description("Inappropriate Talk")]
	InappropriateTalk,
	[Description("Link")]
	Link,
	[Description("Personal Attacks")]
	PersonalAttacks,
	[Description("Personal Info")]
	PersonalInfo,
	[Description("Scam")]
	Scam,
	[Description("Spam")]
	Spam,
	[Description("Swearing")]
	Swearing,
	[Description("Dating")]
	Dating,
	[Description("Bad Image")]
	BadImage,
	[Description("Bot Account")]
	BotAccount,
	[Description("Discriminatory Content")]
	DiscriminatoryContent
}
