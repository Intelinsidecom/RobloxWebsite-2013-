using System;
using System.Globalization;

namespace Amazon.SimpleDB.Util;

/// Provides collection of static functions for conversion of various values into 
/// strings that may be compared lexicographically.
public class AmazonSimpleDBUtil
{
	/// <summary>
	/// Date format String, e.g. 2007-12-06T10:32:43.141-08:00
	/// </summary>
	private static string dateFormat = "yyyy-MM-ddTHH:mm:ss.fffzzzz";

	/// <summary>
	/// Encodes positive integer value into a string by zero-padding it up to the specified number of digits.
	/// </summary>
	/// <remarks>
	/// For example, the integer 123 encoded with a 6 digit maximum would be represented as 000123
	/// </remarks>
	/// <param name="number">positive integer to be encoded</param>
	/// <param name="maxNumDigits">maximum number of digits in the largest value in the data set</param>
	/// <returns>A string representation of the zero-padded integer</returns>
	public static string EncodeZeroPadding(int number, int maxNumDigits)
	{
		return number.ToString().PadLeft(maxNumDigits, '0');
	}

	/// <summary>
	/// Encodes positive single-precision floating point value into a string by zero-padding it to the specified number of digits.
	/// </summary>
	/// <remarks>
	/// This function only zero-pads digits to the left of the decimal point.
	///
	/// For example, the value 123.456 encoded with a 6 digit maximum would be represented as 000123.456
	/// </remarks>
	/// <param name="number">positive floating point value to be encoded</param>
	/// <param name="maxNumDigits">maximum number of digits in the largest value in the data set</param>
	/// <returns>A string representation of the zero-padded floating point value</returns>
	public static string EncodeZeroPadding(float number, int maxNumDigits)
	{
		string fltStr = number.ToString();
		int decPt = fltStr.IndexOf('.');
		if (decPt == -1)
		{
			return fltStr.PadLeft(maxNumDigits, '0');
		}
		return fltStr.PadLeft(maxNumDigits + (fltStr.Length - decPt), '0');
	}

	/// <summary>
	/// Encodes real integer value into a string by offsetting and zero-padding 
	/// number up to the specified number of digits.  Use this encoding method if the data
	/// range set includes both positive and negative values.
	/// </summary>
	/// <remarks>
	/// For example, the integer value -123 offset by 1000 with a maximum of 6 digits would be:
	/// -123 + 1000, padded to 6 digits: 000877
	/// </remarks>
	/// <param name="number">integer to be encoded</param>
	/// <param name="maxNumDigits">maximum number of digits in the largest absolute value in the data set</param>
	/// <param name="offsetValue">offset value, has to be greater than absolute value of any negative number in the data set.</param>
	/// <returns>A string representation of the integer</returns>
	public static string EncodeRealNumberRange(int number, int maxNumDigits, int offsetValue)
	{
		return (number + offsetValue).ToString().PadLeft(maxNumDigits, '0');
	}

	/// <summary>
	/// Encodes real float value into a string by offsetting and zero-padding 
	/// number up to the specified number of digits.  Use this encoding method if the data
	/// range set includes both positive and negative values.
	/// </summary>
	/// <remarks>
	/// For example, the floating point value -123.456 offset by 1000 with
	/// a maximum of 6 digits to the left, and 4 to the right would be:
	/// 0008765440
	/// </remarks>
	/// <param name="number">floating point value to be encoded</param>
	/// <param name="maxDigitsLeft">maximum number of digits left of the decimal point in the largest absolute value in the data set</param>
	/// <param name="maxDigitsRight">maximum number of digits right of the decimal point in the largest absolute value in the data set, i.e. precision</param>
	/// <param name="offsetValue">offset value, has to be greater than absolute value of any negative number in the data set.</param>
	/// <returns>A string representation of the integer</returns>
	public static string EncodeRealNumberRange(float number, int maxDigitsLeft, int maxDigitsRight, int offsetValue)
	{
		long shiftMultiplier = (long)Math.Pow(10.0, maxDigitsRight);
		return ((long)Math.Round((number + (float)offsetValue) * (float)shiftMultiplier)).ToString().PadLeft(maxDigitsLeft + maxDigitsRight, '0');
	}

	/// <summary>
	/// Decodes zero-padded positive float value from the string representation
	/// </summary>
	/// <param name="value">zero-padded string representation of the float value</param>
	/// <returns>original float value</returns>
	public static float DecodeZeroPaddingFloat(string value)
	{
		return float.Parse(value);
	}

	/// <summary>
	/// Decodes zero-padded positive integer value from the string representation
	/// </summary>
	/// <param name="value">zero-padded string representation of the integer</param>
	/// <returns>original integer value</returns>
	public static int DecodeZeroPaddingInt(string value)
	{
		return int.Parse(value);
	}

	/// <summary>
	/// Decodes float value from the string representation that was created by using encodeRealNumberRange(..) function.
	/// </summary>
	/// <param name="value">String representation of the integer value</param>
	/// <param name="offsetValue">offset value that was used in the original encoding</param>
	/// <returns>original integer value</returns>
	public static int DecodeRealNumberRangeInt(string value, int offsetValue)
	{
		return (int)(long.Parse(value) - offsetValue);
	}

	/// <summary>
	/// Decodes float value from the string representation that was created by using encodeRealNumberRange(..) function.
	/// </summary>
	/// <param name="value">string representation of the integer value</param>
	/// <param name="maxDigitsRight">maximum number of digits left of the decimal point in the largest absolute value in the data set (must be the same as the one used for encoding).</param>
	/// <param name="offsetValue">offset value that was used in the original encoding</param>
	/// <returns>original float value</returns>
	public static float DecodeRealNumberRangeFloat(string value, int maxDigitsRight, int offsetValue)
	{
		return (float)((double)long.Parse(value) / Math.Pow(10.0, maxDigitsRight) - (double)offsetValue);
	}

	/// <summary>
	/// Encodes date value into string format that can be compared lexicographically
	/// </summary>
	/// <param name="date">date value to be encoded</param>
	/// <returns>string representation of the date value</returns>
	public static string EncodeDate(DateTime date)
	{
		return date.ToString(dateFormat);
	}

	/// <summary>
	/// Decodes date value from the string representation created using encodeDate(..) function.
	/// </summary>
	/// <param name="value">string representation of the date value</param>
	/// <returns>original date value</returns>
	public static DateTime DecodeDate(string value)
	{
		return DateTime.ParseExact(value, dateFormat, CultureInfo.InvariantCulture);
	}
}
