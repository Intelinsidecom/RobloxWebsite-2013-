// Temporary stubs to unblock build. Replace with real package/reference when available.
using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.ApiClientBase;

namespace Roblox.ContentFilterApi.Client
{
    public enum ContentReviewType
    {
        Default = 0,
        Username = 1
    }

    public class Evaluation
    {
        public byte CategoryId { get; set; }
        public string Text { get; set; }
        public double Probability { get; set; }
    }

    public class WhitelistExpression
    {
        public string Value { get; set; }
    }

    public class ContentFilterClient
    {
        public static readonly byte UsernameFilterCategoryId = 1;

        private readonly Func<string> _apiKeyGetter;

        // very simple in-memory store for stubbed whitelist items keyed by (categoryType, categoryTargetId)
        private static readonly Dictionary<(string, long), List<WhitelistExpression>> _whitelists = new();

        public ContentFilterClient(Func<string> apiKeyGetter)
        {
            _apiKeyGetter = apiKeyGetter ?? throw new ArgumentNullException(nameof(apiKeyGetter));
        }

        public Evaluation[] GetEvaluationSet(string text, byte[] categoryIds = null)
        {
            // Stub: return empty evaluation set
            return Array.Empty<Evaluation>();
        }

        public double GetProbability(byte categoryId, string text)
        {
            // Stub
            return 0.0;
        }

        public double GetGoodProbability(byte categoryId, string text)
        {
            // Stub
            return 1.0 - GetProbability(categoryId, text);
        }

        public void LearnText(byte categoryId, string text, bool isBad)
        {
            // Stub: no-op
        }

        public void InsertWhitelistExpression(string categoryType, long categoryTargetId, string value)
        {
            var key = (categoryType ?? string.Empty, categoryTargetId);
            if (!_whitelists.TryGetValue(key, out var list))
            {
                list = new List<WhitelistExpression>();
                _whitelists[key] = list;
            }
            if (!list.Any(e => string.Equals(e.Value, value, StringComparison.Ordinal)))
            {
                list.Add(new WhitelistExpression { Value = value });
            }
        }

        public void DeleteWhitelistExpression(string categoryType, long categoryTargetId, string value)
        {
            var key = (categoryType ?? string.Empty, categoryTargetId);
            if (_whitelists.TryGetValue(key, out var list))
            {
                list.RemoveAll(e => string.Equals(e.Value, value, StringComparison.Ordinal));
            }
        }

        public bool WhitelistExpressionExists(string value)
        {
            return _whitelists.Values.Any(list => list.Any(e => string.Equals(e.Value, value, StringComparison.Ordinal)));
        }

        public PagedResult<int, WhitelistExpression> GetWhitelistExpressions(string categoryType, long categoryTargetId, int page)
        {
            var key = (categoryType ?? string.Empty, categoryTargetId);
            var list = _whitelists.TryGetValue(key, out var wl) ? wl : new List<WhitelistExpression>();
            // very naive paging of size 50
            const int pageSize = 50;
            var pageItems = list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PagedResult<int, WhitelistExpression>(page, list.Count, pageItems);
        }
    }
}
