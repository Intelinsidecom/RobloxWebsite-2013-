namespace Roblox.Entities.Mssql;

public static class SqlStringExtensions
{
	/// <summary>
	/// Truncates the given string into a complete string that will fit in NVarChar(x).
	/// This cleans up High Surrogates and ensure that we don't split UTF-16 chars like emoji into invalid characters.
	///
	/// Note the parameters.
	///  - DB =&gt; fieldName NVARCHAR(255)
	///  - Caller =&gt; fieldName.TruncateToNVarChar(255)
	/// </summary>
	/// <param name="x">The string to truncate.</param>
	/// <param name="numberOfCharacters">The value in your NVarChar(x) declaration in the DB.</param>
	/// <returns>The truncated string if there were changes. The original string if there were none.</returns>
	public static string TruncateToNVarChar(this string x, int numberOfCharacters)
	{
		int sqlLength = 0;
		for (int i = 0; i < x.Length; i++)
		{
			if (char.IsHighSurrogate(x[i]))
			{
				i++;
				sqlLength += 4;
			}
			else
			{
				sqlLength += 2;
			}
			if (sqlLength > numberOfCharacters * 2)
			{
				return x.Substring(0, i - 1);
			}
		}
		return x;
	}
}
