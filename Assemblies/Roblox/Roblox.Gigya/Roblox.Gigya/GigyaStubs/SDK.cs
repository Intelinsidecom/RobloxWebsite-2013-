using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gigya.Socialize.SDK
{
    // Minimal stub of GSObject with dictionary-style storage
    public class GSObject
    {
        private readonly Dictionary<string, object> _dict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

        public void ParseQuerystring(string query)
        {
            if (string.IsNullOrEmpty(query)) return;
            // If it looks like a full URL, use Uri parsing, else treat as query
            string q = query;
            if (query.Contains("?"))
            {
                int idx = query.IndexOf('?');
                q = idx >= 0 && idx + 1 < query.Length ? query.Substring(idx + 1) : string.Empty;
            }
            var nvc = HttpUtility.ParseQueryString(q);
            foreach (string key in nvc.AllKeys)
            {
                if (key == null) continue;
                _dict[key] = nvc[key] ?? string.Empty;
            }
        }

        public string GetString(string key, string defaultValue)
        {
            return _dict.TryGetValue(key, out var v) ? Convert.ToString(v) ?? defaultValue : defaultValue;
        }

        public int GetInt(string key, int defaultValue)
        {
            if (_dict.TryGetValue(key, out var v))
            {
                if (v is int i) return i;
                if (int.TryParse(Convert.ToString(v), out var parsed)) return parsed;
            }
            return defaultValue;
        }

        public bool ContainsKey(string key) => _dict.ContainsKey(key);

        public IEnumerable<GSObject> GetArray(string key)
        {
            if (_dict.TryGetValue(key, out var v))
            {
                if (v is IEnumerable<GSObject> arr) return arr;
                if (v is GSObject single) return new[] { single };
            }
            return Enumerable.Empty<GSObject>();
        }

        public void Set(string key, object value) => _dict[key] = value;

        public string ToJsonString()
        {
            // Minimal, non-strict JSON-ish string for diagnostics
            var parts = _dict.Select(kvp => $"\"{kvp.Key}\":\"{kvp.Value}\"");
            return "{" + string.Join(",", parts) + "}";
        }

        public string ToJSON() => ToJsonString();
    }

    public class GSRequest
    {
        public string ApiKey { get; }
        public string SecretKey { get; }
        public string Method { get; }
        public bool UseHttps { get; }

        private readonly GSObject _params = new GSObject();

        public GSRequest(string apiKey, string secretKey, string method, bool useHttps)
        {
            ApiKey = apiKey;
            SecretKey = secretKey;
            Method = method;
            UseHttps = useHttps;
        }

        public void SetParam(string key, object value) => _params.Set(key, value);

        public GSObject GetParams() => _params;

        public GSResponse Send(int timeoutMilliseconds)
        {
            // Return a success response with empty data by default
            return new GSResponse(0, string.Empty, new GSObject(), new GSObject());
        }
    }

    public class GSResponse
    {
        private readonly int _errorCode;
        private readonly string _errorMessage;
        private readonly GSObject _data;
        private readonly GSObject _headers;

        public GSResponse(int errorCode, string errorMessage, GSObject data, GSObject headers)
        {
            _errorCode = errorCode;
            _errorMessage = errorMessage ?? string.Empty;
            _data = data ?? new GSObject();
            _headers = headers ?? new GSObject();
        }

        public int GetErrorCode() => _errorCode;
        public string GetErrorMessage() => _errorMessage;
        public GSObject GetData() => _data;
        public GSObject GetHeaders() => _headers;
    }

    public static class SigUtils
    {
        // Minimal stub — always returns true
        public static bool ValidateUserSignature(string uid, string timestamp, string secret, string signature)
        {
            return true;
        }

        // Minimal stub for CalcSignature used by GigyaSignatureTimestamp
        public static string CalcSignature(string baseString, string secret)
        {
            // Return a deterministic placeholder signature to satisfy callers
            if (baseString == null) baseString = string.Empty;
            if (secret == null) secret = string.Empty;
            // Simple hash-like placeholder
            int hash = (baseString + "|" + secret).GetHashCode();
            return hash.ToString("X");
        }
    }
}
