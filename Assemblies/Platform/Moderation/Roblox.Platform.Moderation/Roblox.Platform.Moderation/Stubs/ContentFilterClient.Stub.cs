using System;
using Roblox.ApiClientBase;

namespace Roblox.ContentFilterApi.Client
{
    // Minimal stubs to satisfy Moderation build without requiring real ContentFilter client API surface
    public class ContentFilterClient
    {
        public void DeleteWhitelistExpression(string categoryType, long categoryTargetId, string value)
        {
            // no-op stub
            _ = categoryType; _ = categoryTargetId; _ = value;
        }

        public void InsertWhitelistExpression(string categoryType, long categoryTargetId, string value)
        {
            // no-op stub
            _ = categoryType; _ = categoryTargetId; _ = value;
        }

        public bool WhitelistExpressionExists(string value)
        {
            // conservative default
            _ = value;
            return false;
        }

        public PagedResult<int, WhitelistExpression> GetWhitelistExpressions(string categoryType, long categoryTargetId, int page)
        {
            // return null to indicate no data in stub
            _ = categoryType; _ = categoryTargetId; _ = page;
            return null;
        }
    }

    public class WhitelistExpression
    {
        public string Value { get; set; }
    }
}
