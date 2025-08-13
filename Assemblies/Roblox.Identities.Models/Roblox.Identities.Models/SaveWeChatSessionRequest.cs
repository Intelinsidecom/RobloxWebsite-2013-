using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for saving a wechat session
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct SaveWeChatSessionRequest
{
	/// <summary>
	/// The roblox account identifier
	/// </summary>
	[DataMember(Name = "accountId")]
	public long AccountId;

	/// <summary>
	/// The open identifier
	/// </summary>
	[DataMember(Name = "openId")]
	public string OpenId;

	/// <summary>
	/// The access token
	/// </summary>
	[DataMember(Name = "accessToken")]
	public string AccessToken;

	/// <summary>
	/// The refresh token
	/// </summary>
	[DataMember(Name = "refreshToken")]
	public string RefreshToken;

	/// <summary>
	/// The access expires in seconds
	/// </summary>
	[DataMember(Name = "accessExpiresSec")]
	public int AccessExpiresSecs;

	/// <summary>
	/// The refresh expires
	/// </summary>
	[DataMember(Name = "refreshExpires")]
	public DateTime RefreshExpires;

	/// <summary>
	/// The platform
	/// </summary>
	[DataMember(Name = "identityPlatform")]
	public WeChatIdentityPlatform Platform;
}
