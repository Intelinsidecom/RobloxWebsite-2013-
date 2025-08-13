using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Membership.Entities;

[ExcludeFromCodeCoverage]
internal class UserEntity : IUserEntity
{
	private readonly Roblox.User _ServerClassLibraryEntity;

	public long AccountID => _ServerClassLibraryEntity.AccountID;

	public AgeBracket AgeBracket => _ServerClassLibraryEntity.AgeBracket.TranslateAgeBracket();

	public long? AssociatedEntityID => _ServerClassLibraryEntity.AssociatedEntityID;

	public DateTime? BirthDate => _ServerClassLibraryEntity.BirthDate;

	public DateTime Created => _ServerClassLibraryEntity.Created;

	public CreatorType CreatorType => _ServerClassLibraryEntity.CreatorType;

	public byte? GenderTypeId => _ServerClassLibraryEntity.GenderTypeId;

	public long ID => _ServerClassLibraryEntity.ID;

	public DateTime? Updated => _ServerClassLibraryEntity.Updated;

	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	public bool UseSuperSafeConversationMode => _ServerClassLibraryEntity.UseSuperSafeConversationMode;

	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	public bool UseSuperSafePrivacyMode => _ServerClassLibraryEntity.UseSuperSafePrivacyMode;

	internal UserEntity(Roblox.User sclEntity)
	{
		_ServerClassLibraryEntity = sclEntity;
	}

	public bool IsBuildersClubMember()
	{
		return _ServerClassLibraryEntity.IsBuildersClubMember();
	}

	public bool IsTurboBuildersClubMember()
	{
		return _ServerClassLibraryEntity.IsTurboBuildersClubMember();
	}

	public bool IsOutrageousBuildersClubMember()
	{
		return _ServerClassLibraryEntity.IsOutrageousBuildersClubMember();
	}

	public bool IsAnyBuildersClubMember()
	{
		return _ServerClassLibraryEntity.IsAnyBuildersClubMember();
	}

	public void SetGender(GenderType genderType)
	{
		_ServerClassLibraryEntity.SetGender((byte)genderType);
	}

	public void SetAgeBracket(AgeBracket ageBracket)
	{
		_ServerClassLibraryEntity.SetAgeBracket(ageBracket.TranslateAgeBracket());
	}

	public void SetBirthdate(DateTime? newBirthdate)
	{
		_ServerClassLibraryEntity.SetBirthdate(newBirthdate);
	}
}
