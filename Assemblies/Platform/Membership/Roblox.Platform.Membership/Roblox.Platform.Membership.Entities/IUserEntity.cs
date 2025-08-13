using System;

namespace Roblox.Platform.Membership.Entities;

internal interface IUserEntity
{
	long AccountID { get; }

	AgeBracket AgeBracket { get; }

	long? AssociatedEntityID { get; }

	DateTime? BirthDate { get; }

	DateTime Created { get; }

	CreatorType CreatorType { get; }

	byte? GenderTypeId { get; }

	long ID { get; }

	DateTime? Updated { get; }

	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	bool UseSuperSafeConversationMode { get; }

	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	bool UseSuperSafePrivacyMode { get; }

	bool IsBuildersClubMember();

	bool IsTurboBuildersClubMember();

	bool IsOutrageousBuildersClubMember();

	bool IsAnyBuildersClubMember();

	void SetGender(GenderType genderType);

	void SetAgeBracket(AgeBracket ageBracket);

	void SetBirthdate(DateTime? newBirthdate);
}
