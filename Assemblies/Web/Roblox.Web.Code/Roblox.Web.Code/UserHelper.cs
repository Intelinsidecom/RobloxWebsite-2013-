using System;
using Roblox.Properties;
using Roblox.Users;
using Roblox.Web.Authentication;

namespace Roblox.Web.Code;

public class UserHelper
{
	private static int _GendersCount = 3;

	/// <summary>
	/// Returns the current guestId.  If one didn't exist, or 
	/// there was an error with the current value, then a new cookie &amp; value
	/// will be created and set in the current context.
	/// This function will throw an exception if it is called after a Response.Redirect call with endResponse parameter value set to False or 
	/// if it is called in an HttpModule's OnEndRequest method.
	/// </summary>
	/// <returns>the context user's current guestId, or null if there was an error creating it.</returns>
	/// <exception cref="T:System.Web.HttpException">Server cannot modify cookies after HTTP headers have been sent</exception>
	public static long? GetOrCreateCurrentGuestId()
	{
		return GetCurrentGuestId(createCookie: true);
	}

	public static long? GetOrCreateCurrentGuestIdWithoutSettingCookie()
	{
		return GetCurrentGuestId(createCookie: false);
	}

	private static long? GetCurrentGuestId(bool createCookie)
	{
		RobloxGuestCookie guestCookie;
		try
		{
			guestCookie = RobloxGuestCookie.GetOrCreate();
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return null;
		}
		if (!string.IsNullOrEmpty(guestCookie.GuestId))
		{
			try
			{
				long currentGuestId = Convert.ToInt64(guestCookie.GuestId);
				if (currentGuestId < 0)
				{
					return currentGuestId;
				}
			}
			catch (Exception ex2)
			{
				ExceptionHandler.LogException(ex2);
			}
		}
		try
		{
			long newGuestId = GenerateRandomGuestId();
			if (createCookie)
			{
				SetGuestId(newGuestId);
			}
			return newGuestId;
		}
		catch (Exception ex3)
		{
			ExceptionHandler.LogException(ex3);
			return null;
		}
	}

	/// <summary>
	/// This code encodes gender into a guestId, which is never served to the user.
	/// This is really weird.
	///
	/// So what's the purpose of this "guestId encoding gender"?
	/// It's sent to the game instances service, and returned when the website gets the player list for a server.
	/// From that point it's decrypted mod 3 to find out whether the user clicked male or female on the chooser popup,
	/// and correctly display their gender in the player list by server.
	///
	/// So if you are trying to remove this, watch out.
	/// </summary>
	public static void SetGuestGenderType(byte genderTypeId)
	{
		RobloxGuestCookie orCreate = RobloxGuestCookie.GetOrCreate();
		long guestId = Convert.ToInt64(orCreate.GuestId);
		if (guestId == 0L)
		{
			guestId = GetGenderedGuestId(genderTypeId);
		}
		else if (GetGuestGenderType(guestId).ID != genderTypeId)
		{
			guestId = GetGenderedGuestId(genderTypeId);
		}
		orCreate.GuestId = guestId.ToString();
		orCreate.GuestGender = genderTypeId.ToString();
		orCreate.Save();
	}

	private static GenderType GetGuestGenderType(long guestId)
	{
		if (guestId >= 0)
		{
			return GenderType.Get(GenderType.UnknownID);
		}
		return GenderType.Get((byte)(-guestId % _GendersCount + 1));
	}

	private static long GetGenderedGuestId(byte genderTypeId)
	{
		long randomGuestId = -GenerateRandomGuestId();
		return -(randomGuestId + genderTypeId - (randomGuestId % _GendersCount + 1));
	}

	public static int GetGuestCharacterId(long guestId)
	{
		GenderType genderType = GetGuestGenderType(guestId);
		int characterId = Settings.Default.DefaultGuestCharacterID;
		if (genderType.ID == GenderType.MaleID)
		{
			characterId = Settings.Default.BoyGuestCharacterID;
		}
		else if (genderType.ID == GenderType.FemaleID)
		{
			characterId = Settings.Default.GirlGuestCharacterID;
		}
		return characterId;
	}

	public static GenderType GetGuestGenderType()
	{
		RobloxGuestCookie guestUserCookie = RobloxGuestCookie.GetOrCreate();
		string genderValue = guestUserCookie.GuestGender;
		if (!string.IsNullOrEmpty(genderValue))
		{
			byte cookiedGenderId = Convert.ToByte(genderValue);
			GenderType genderType = GenderType.Get(cookiedGenderId);
			if (genderType != null)
			{
				return genderType;
			}
			guestUserCookie.Delete();
			ExceptionHandler.LogException("Invalid Guest Gender stored in cookie: " + cookiedGenderId);
		}
		return GenderType.Get(GenderType.UnknownID);
	}

	private static long GenerateRandomGuestId()
	{
		return -new System.Random().Next(_GendersCount, int.MaxValue - _GendersCount);
	}

	public static void SetGuestId(long id)
	{
		if (id >= 0)
		{
			throw new InvalidOperationException("Bad GuestUserID");
		}
		RobloxGuestCookie.GetOrCreate(id.ToString());
	}

	public static int GetGuestCharacterId()
	{
		GenderType genderType = GetGuestGenderType();
		int characterId = Settings.Default.DefaultGuestCharacterID;
		if (genderType.ID == GenderType.MaleID)
		{
			characterId = Settings.Default.BoyGuestCharacterID;
		}
		else if (genderType.ID == GenderType.FemaleID)
		{
			characterId = Settings.Default.GirlGuestCharacterID;
		}
		return characterId;
	}
}
