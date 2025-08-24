using System;
using Roblox.ContentFilterApi.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Moderation.Interfaces;

namespace Roblox.Platform.Moderation.Implementation;

internal class WhitelistEntry : IWhitelistEntry
{
	private ContentFilterClient _Client { get; set; }

	public CategoryType CategoryType { get; private set; }

	public long CategoryTargetId { get; private set; }

	public string Value { get; private set; }

	public WhitelistEntry(ContentFilterClient client, CategoryType categoryType, long categoryTargetId, string value)
	{
		_Client = client;
		CategoryType = categoryType;
		CategoryTargetId = categoryTargetId;
		Value = value;
	}

	public void Delete()
	{
		_Client.DeleteWhitelistExpression(CategoryType.ToString(), CategoryTargetId, Value);
	}

	public void Update(string categoryType, long categoryTargetId, string value)
	{
		if (!Enum.TryParse<CategoryType>(categoryType, out var _))
		{
			throw new PlatformException("Invalid CategoryType");
		}
		_Client.DeleteWhitelistExpression(CategoryType.ToString(), CategoryTargetId, Value);
		_Client.InsertWhitelistExpression(categoryType, categoryTargetId, value);
	}
}
