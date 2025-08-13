using System;
using System.Linq;
using System.Text.RegularExpressions;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
/// A class for holding CreditCard validation business rules.
/// TODO: Rules need to be pulled from CreditCard and UpgradesController to this central location
/// </summary>
public class CreditCardValidator
{
	private const int _MinCreditCardLength = 12;

	private const int _MaxCreditCardLength = 19;

	/// <summary>
	/// Tests if CerditCard expiration date is valid.
	/// </summary>
	/// <param name="creditCard">The credit card to be validated</param>
	/// <param name="currentDateTime">DateTime to validate the card against</param>
	/// <returns>false if the CreditCard expiration date is in the past or can't be parsed</returns>
	public bool IsValidExpirationDate(ICreditCard creditCard, DateTime currentDateTime)
	{
		int cardYear = 0;
		int nowYear = currentDateTime.Year % 100;
		if (!int.TryParse(creditCard.ExpirationYear, out cardYear))
		{
			return false;
		}
		if (cardYear < nowYear)
		{
			return false;
		}
		if (cardYear == nowYear)
		{
			int nowMonth = currentDateTime.Month;
			int cardMonth = 0;
			int.TryParse(creditCard.ExpirationMonth, out cardMonth);
			if (cardMonth < nowMonth)
			{
				return false;
			}
		}
		return true;
	}

	/// <summary>
	/// Verify the credit card number and length is valid for the type
	/// </summary>
	/// <param name="creditCard">The credit card to be verified</param>
	/// <returns>false if the CreditCard number does not match it's declared type (if a Visa number doesn't start with 4, for example)</returns>
	public bool IsValidType(ICreditCard creditCard)
	{
		if (creditCard.CardType == CreditCardType.Visa && Regex.IsMatch(creditCard.Number, "^(4)"))
		{
			if (creditCard.Number.Length != 16)
			{
				return creditCard.Number.Length == 13;
			}
			return true;
		}
		if (creditCard.CardType == CreditCardType.MasterCard && Regex.IsMatch(creditCard.Number, "^(51|52|53|54|55)"))
		{
			return creditCard.Number.Length == 16;
		}
		if (creditCard.CardType == CreditCardType.AmericanExpress && Regex.IsMatch(creditCard.Number, "^(34|37)"))
		{
			return creditCard.Number.Length == 15;
		}
		if (creditCard.CardType == CreditCardType.Discover && Regex.IsMatch(creditCard.Number, "^(6011|65)"))
		{
			return creditCard.Number.Length == 16;
		}
		return true;
	}

	/// <summary>
	/// Verifies the credit cards checksum using the Luhn algorithm
	/// http://rosettacode.org/wiki/Luhn_test_of_credit_card_numbers#C.23
	/// </summary>
	/// <param name="creditCard">The credit card to be validated</param>
	/// <returns>false if the CreditCard fails to pass a checksum test</returns>
	public bool IsValidChecksum(ICreditCard creditCard)
	{
		int[] digits = creditCard.Number.Select(delegate(char c)
		{
			int.TryParse(c.ToString(), out var result);
			return result;
		}).ToArray();
		int i = 0;
		int lengthMod = digits.Length % 2;
		int[] results = new int[10] { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
		return digits.Sum((int d) => (i++ % 2 != lengthMod) ? d : results[d]) % 10 == 0;
	}

	/// <summary>
	/// Verifies if the credit card is valid.
	/// </summary>
	/// <param name="creditCard">The given credit card.</param>
	/// <returns><c>true</c> if the credit card is valid, otherwise <c>false.</c></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="creditCard" />
	/// </exception>
	public bool IsValid(ICreditCard creditCard)
	{
		if (creditCard == null)
		{
			throw new PlatformArgumentNullException("creditCard");
		}
		if (!long.TryParse(creditCard.Number, out var _))
		{
			return false;
		}
		if (creditCard.Number.Length < 12 || creditCard.Number.Length > 19)
		{
			return false;
		}
		if (!IsValidType(creditCard))
		{
			return false;
		}
		if (!IsValidChecksum(creditCard))
		{
			return false;
		}
		return true;
	}
}
