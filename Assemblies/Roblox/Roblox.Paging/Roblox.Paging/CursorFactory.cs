using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Roblox.Hashing;

namespace Roblox.Paging;

/// <inheritdoc cref="T:Roblox.Paging.ICursorFactory" />
public class CursorFactory : ICursorFactory
{
	private const char _CursorSplitter = '\n';

	private readonly Func<string> _CursorSaltGetter;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Paging.CursorFactory" />.
	/// </summary>
	/// <param name="cursorSaltGetter">The salt for the cursors.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="cursorSaltGetter" />
	/// </exception>
	public CursorFactory(Func<string> cursorSaltGetter)
	{
		_CursorSaltGetter = cursorSaltGetter ?? throw new ArgumentNullException("cursorSaltGetter");
	}

	/// <inheritdoc cref="M:Roblox.Paging.ICursorFactory.CreateCursor``1(``0)" />
	public string CreateCursor<TCursorInformation>(TCursorInformation cursorInformation) where TCursorInformation : CursorBase
	{
		if (cursorInformation == null)
		{
			throw new ArgumentNullException("cursorInformation");
		}
		string serializedCursor = JsonConvert.SerializeObject(cursorInformation);
		string cursorHash = SHA256Hasher.BuildSHA256HashString($"{serializedCursor}_{_CursorSaltGetter()}");
		return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{serializedCursor}{'\n'}{cursorHash}"));
	}

	/// <inheritdoc cref="M:Roblox.Paging.ICursorFactory.ParseCursor``1(System.String,System.String)" />
	public TCursorInformation ParseCursor<TCursorInformation>(string cursor, string discriminator = "") where TCursorInformation : CursorBase
	{
		if (string.IsNullOrWhiteSpace(cursor))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "cursor");
		}
		TCursorInformation cursorInformation;
		try
		{
			byte[] rawCursor = Convert.FromBase64String(cursor);
			cursorInformation = JsonConvert.DeserializeObject<TCursorInformation>(Encoding.UTF8.GetString(rawCursor).Split(new char[1] { '\n' }).First());
		}
		catch (Exception e)
		{
			throw new ArgumentException("Failed to deserialize cursor information.", "cursor", e);
		}
		if (CreateCursor(cursorInformation) != cursor)
		{
			throw new ArgumentException("Cursor failed verification (considered spoofed).", "cursor");
		}
		if (cursorInformation.Discriminator != discriminator)
		{
			throw new ArgumentException("Cursor failed verification (cursor discriminator).", "cursor");
		}
		return cursorInformation;
	}

	/// <inheritdoc cref="M:Roblox.Paging.ICursorFactory.TryParseCursor``1(System.String,``0@,System.String)" />
	public bool TryParseCursor<TCursorInformation>(string cursor, out TCursorInformation cursorInformation, string discriminator = "") where TCursorInformation : CursorBase
	{
		try
		{
			cursorInformation = ParseCursor<TCursorInformation>(cursor);
			return true;
		}
		catch (ArgumentException)
		{
			cursorInformation = null;
			return false;
		}
	}
}
