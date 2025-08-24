using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for saving a QQ session
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct SaveQQSessionRequest
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
	/// Time to access token expiring in seconds
	/// </summary>
	[DataMember(Name = "accessExpiresSeconds")]
	public int AccessExpiresSecs;

	/// <summary>
	/// The refresh expiration time
	/// </summary>
	[DataMember(Name = "refreshExpires")]
	public DateTime RefreshExpires;

	/// <summary>
	/// The platform type
	/// </summary>
	[DataMember(Name = "platformType")]
	public ExternalIdentityPlatformType PlatformType;
}
