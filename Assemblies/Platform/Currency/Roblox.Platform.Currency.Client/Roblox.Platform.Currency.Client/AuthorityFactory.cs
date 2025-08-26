using System;
namespace Roblox.Platform.Currency.Client {

    // Minimal factory to satisfy callers. Can be expanded to wire real HTTP clients if needed.
    public sealed class CurrencyAuthorityFactory
    {
        private static readonly Lazy<CurrencyAuthorityFactory> _singleton = new(() => new CurrencyAuthorityFactory());
        public static CurrencyAuthorityFactory Singleton => _singleton.Value;

        private readonly InProcessCurrencyAuthority _defaultAuthority = new();

        private CurrencyAuthorityFactory() { }

        // Returns an ICurrencyAuthority instance. apiKeyGetter is ignored in this basic implementation.
        public ICurrencyAuthority GetCurrencyAuthority(Func<string> apiKeyGetter)
        {
            return _defaultAuthority;
        }
    }
}
