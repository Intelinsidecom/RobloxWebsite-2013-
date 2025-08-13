using System;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for QQ session data response
/// </summary>
public struct QQSessionDataResult
{
	/// <summary>
	/// Empty result
	/// </summary>
	public static readonly QQSessionDataResult Empty;

	/// <summary>
	/// The account identifier
	/// </summary>
	[DataMember(Name = "accountId")]
	public readonly long AccountId;

	/// <summary>
	/// The open identifier
	/// </summary>
	[DataMember(Name = "openId")]
	public readonly string OpenId;

	/// <summary>
	/// The access token
	/// </summary>
	[DataMember(Name = "accessToken")]
	public readonly string AccessToken;

	/// <summary>
	/// The refresh token
	/// </summary>
	[DataMember(Name = "refreshToken")]
	public readonly string RefreshToken;

	/// <summary>
	/// The access expires
	/// </summary>
	[DataMember(Name = "accessExpires")]
	public readonly DateTime AccessExpires;

	/// <summary>
	/// The refresh expires
	/// </summary>
	[DataMember(Name = "refreshExpires")]
	public readonly DateTime RefreshExpires;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Identities.Models.QQSessionDataResult" /> struct.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	/// <param name="openId">The open identifier.</param>
	/// <param name="accessToken">The access token.</param>
	/// <param name="refreshToken">The refresh token.</param>
	/// <param name="accessExpires">The access expires.</param>
	/// <param name="refreshExpires">The refresh expires.</param>
	public QQSessionDataResult(long accountId, string openId, string accessToken, string refreshToken, DateTime accessExpires, DateTime refreshExpires)
	{
		AccountId = accountId;
		OpenId = openId;
		AccessToken = accessToken;
		RefreshToken = refreshToken;
		AccessExpires = accessExpires;
		RefreshExpires = refreshExpires;
	}

	/// <summary>
	/// Implements the operator ==.
	/// </summary>
	/// <param name="sessionData1">The session data1.</param>
	/// <param name="sessionData2">The session data2.</param>
	/// <returns>
	/// The result of the operator.
	/// </returns>
	public static bool operator ==(QQSessionDataResult sessionData1, QQSessionDataResult sessionData2)
	{
		if (sessionData1.AccountId == sessionData2.AccountId && sessionData1.OpenId == sessionData2.OpenId && sessionData1.AccessToken == sessionData2.AccessToken && sessionData1.RefreshToken == sessionData2.RefreshToken && sessionData1.AccessExpires == sessionData2.AccessExpires)
		{
			return sessionData1.RefreshExpires == sessionData2.RefreshExpires;
		}
		return false;
	}

	/// <summary>
	/// Implements the operator !=.
	/// </summary>
	/// <param name="sessionData1">The session data1.</param>
	/// <param name="sessionData2">The session data2.</param>
	/// <returns>
	/// The result of the operator.
	/// </returns>
	public static bool operator !=(QQSessionDataResult sessionData1, QQSessionDataResult sessionData2)
	{
		return !sessionData1.Equals(sessionData2);
	}

	/// <summary>
	/// Determines whether the specified <see cref="T:System.Object" />, is equal to this instance.
	/// </summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to compare with this instance.</param>
	/// <returns>
	///   <c>true</c> if the specified <see cref="T:System.Object" /> is equal to this instance; otherwise, <c>false</c>.
	/// </returns>
	public override bool Equals(object obj)
	{
		if (obj is QQSessionDataResult)
		{
			return this == (QQSessionDataResult)obj;
		}
		return false;
	}
}
