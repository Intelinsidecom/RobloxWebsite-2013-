using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for identity data response
/// </summary>
public struct WeChatIdentityDataResult
{
	/// <summary>
	/// Empty result
	/// </summary>
	public static readonly WeChatIdentityDataResult Empty;

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
	/// Initializes a new instance of the <see cref="T:Roblox.Identities.Models.WeChatIdentityDataResult" /> struct.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	/// <param name="openId">The open identifier.</param>
	public WeChatIdentityDataResult(long accountId, string openId)
	{
		AccountId = accountId;
		OpenId = openId;
	}

	/// <summary>
	/// Implements the operator ==.
	/// </summary>
	/// <param name="identityData1">The identity data1.</param>
	/// <param name="identityData2">The identity data2.</param>
	/// <returns>
	/// The result of the operator.
	/// </returns>
	public static bool operator ==(WeChatIdentityDataResult identityData1, WeChatIdentityDataResult identityData2)
	{
		if (identityData1.AccountId == identityData2.AccountId)
		{
			return identityData1.OpenId == identityData2.OpenId;
		}
		return false;
	}

	/// <summary>
	/// Implements the operator !=.
	/// </summary>
	/// <param name="identityData1">The identity data1.</param>
	/// <param name="identityData2">The identity data2.</param>
	/// <returns>
	/// The result of the operator.
	/// </returns>
	public static bool operator !=(WeChatIdentityDataResult identityData1, WeChatIdentityDataResult identityData2)
	{
		return !identityData1.Equals(identityData2);
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
		if (obj is WeChatIdentityDataResult)
		{
			return this == (WeChatIdentityDataResult)obj;
		}
		return false;
	}
}
