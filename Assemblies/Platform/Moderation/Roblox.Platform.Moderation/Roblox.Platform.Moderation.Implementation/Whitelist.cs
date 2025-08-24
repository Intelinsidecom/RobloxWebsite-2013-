using System.Collections.Generic;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.ContentFilterApi.Client;
using Roblox.Platform.Moderation.Interfaces;

namespace Roblox.Platform.Moderation.Implementation;

internal class Whitelist : IWhitelist
{
	private ContentFilterClient _Client { get; set; }

	public CategoryType CategoryType { get; private set; }

	public long CategoryTargetId { get; private set; }

	public Whitelist(ContentFilterClient client, CategoryType categoryType, long categoryTargetId)
	{
		_Client = client;
		CategoryTargetId = categoryTargetId;
		CategoryType = categoryType;
	}

	public IWhitelistEntry Add(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		_Client.InsertWhitelistExpression(CategoryType.ToString(), CategoryTargetId, value);
		return new WhitelistEntry(_Client, CategoryType, CategoryTargetId, value);
	}

	public IWhitelistEntry Get(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		if (Contains(value))
		{
			return new WhitelistEntry(_Client, CategoryType, CategoryTargetId, value);
		}
		return null;
	}

	public bool Contains(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return false;
		}
		return _Client.WhitelistExpressionExists(value);
	}

	public PagedResult<IWhitelistEntry> GetPaged(int page = 1)
	{
		PagedResult<int, WhitelistExpression> whitelistExpressions = _Client.GetWhitelistExpressions(CategoryType.ToString(), CategoryTargetId, page);
		return new PagedResult<IWhitelistEntry>(pageItems: whitelistExpressions.PageItems.Select((WhitelistExpression entry) => new WhitelistEntry(_Client, CategoryType, CategoryTargetId, entry.Value)), totalItems: whitelistExpressions.Count);
	}

	public IEnumerable<string> GetAllTerms()
	{
		List<string> whitelistWords = new List<string>();
		int startPage = 1;
		PagedResult<IWhitelistEntry> currentResult;
		do
		{
			currentResult = GetPaged(startPage);
			whitelistWords.AddRange(currentResult.PageItems.Select((IWhitelistEntry entity) => entity.Value));
			startPage++;
		}
		while (currentResult.PageItems.Count() != 0);
		return whitelistWords;
	}
}
