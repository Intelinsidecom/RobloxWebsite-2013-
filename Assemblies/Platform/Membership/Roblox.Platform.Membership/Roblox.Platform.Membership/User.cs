using System;
using Roblox.Platform.Membership.Entities;
using Roblox.Platform.MembershipCore;
using Roblox.Users.Client;

namespace Roblox.Platform.Membership;

internal class User : Visitor, IUser, IVisitor, IVisitorIdentifier, IUserIdentifier
{
	public string Name { get; }

	public string Description { get; }

	public long AccountId { get; }

	public DateTime Created { get; }

	public AccountStatus AccountStatus { get; }

	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	public bool UseSuperSafePrivacyMode => AgeBracket == AgeBracket.AgeUnder13;

	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	public bool UseSuperSafeConversationMode => AgeBracket == AgeBracket.AgeUnder13;

	public AgeBracket AgeBracket { get; }

	public DateTime? Birthdate { get; }

	public GenderType GenderType { get; }

	internal User(IUserEntity uEntity, IAccountEntity aEntity)
		: base(uEntity.ID)
	{
		Name = aEntity.Name;
		Description = aEntity.Description;
		AccountId = uEntity.AccountID;
		Created = uEntity.Created;
		AccountStatus = aEntity.AccountStatus;
		AgeBracket = uEntity.AgeBracket;
		Birthdate = uEntity.BirthDate;
		GenderType = (GenderType)((!uEntity.GenderTypeId.HasValue) ? 1 : uEntity.GenderTypeId.Value);
	}

	internal User(UserData userData)
		: base(userData.Id)
	{
		Name = userData.Name;
		Description = userData.Description;
		AccountId = userData.AccountId;
		Created = userData.Created.ToLocalTime();
		AccountStatus = TranslateAccountStatus(userData.ModerationStatus);
		AgeBracket = TranslateAgeBracket(userData.AgeBracket);
		Birthdate = userData.Birthdate;
		GenderType = TranslateGenderType(userData.Gender);
		if (userData.Birthdate.HasValue)
		{
			Birthdate = userData.Birthdate.Value.ToLocalTime();
		}
		else
		{
			Birthdate = null;
		}
	}

	public bool IsBuildersClubMember()
	{
		return PremiumFeatureHelper.IsBuildersClubMember(AccountId);
	}

	public bool IsTurboBuildersClubMember()
	{
		return PremiumFeatureHelper.IsTurboBuildersClubMember(AccountId);
	}

	public bool IsOutrageousBuildersClubMember()
	{
		return PremiumFeatureHelper.IsOutrageousBuildersClubMember(AccountId);
	}

	public bool IsAnyBuildersClubMember()
	{
		return PremiumFeatureHelper.IsAnyBuildersClubMember(AccountId);
	}

	public bool IsBCMember(MembershipLevels.BCMembershipLevel? bcMembershipLevel = null)
	{
		if (bcMembershipLevel.HasValue)
		{
			return bcMembershipLevel.Value switch
			{
				MembershipLevels.BCMembershipLevel.BC => IsBuildersClubMember(), 
				MembershipLevels.BCMembershipLevel.TBC => IsTurboBuildersClubMember(), 
				MembershipLevels.BCMembershipLevel.OBC => IsOutrageousBuildersClubMember(), 
				_ => false, 
			};
		}
		return PremiumFeatureHelper.IsAnyBuildersClubMember(AccountId);
	}

	internal AgeBracket TranslateAgeBracket(UserAgeBracket ageBracket)
	{
		if (ageBracket == UserAgeBracket.Age13OrOver)
		{
			return AgeBracket.Age13OrOver;
		}
		return AgeBracket.AgeUnder13;
	}

	internal GenderType TranslateGenderType(UserGender userGender)
	{
		return userGender switch
		{
			UserGender.Male => GenderType.Male, 
			UserGender.Female => GenderType.Female, 
			_ => GenderType.Unknown, 
		};
	}

	internal AccountStatus TranslateAccountStatus(UserModerationStatus userModerationStatus)
	{
		return userModerationStatus switch
		{
			UserModerationStatus.Suppressed => AccountStatus.Suppressed, 
			UserModerationStatus.Deleted => AccountStatus.Deleted, 
			UserModerationStatus.Poisoned => AccountStatus.Poisoned, 
			UserModerationStatus.MustValidateEmail => AccountStatus.MustValidateEmail, 
			UserModerationStatus.Forgotten => AccountStatus.Forgotten, 
			_ => AccountStatus.Ok, 
		};
	}
}
