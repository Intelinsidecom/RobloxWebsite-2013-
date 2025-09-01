using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Localization.Core.Implementations;
using Roblox.Localization.Core.Properties;

namespace Roblox.Localization.Core {
    class SupportedLocaleEntityTranslator : ISupportedLocaleEntityTranslator
    {
        private ISupportedLocale _DefaultSupportedLocale;
        private readonly ISupportedLocaleEntityFactory _SupportedLocaleEntityFactory;
        private readonly ILanguageEntityFactory _LanguageEntityFactory;
        private readonly ILocaleParser _LocaleParser;
        private readonly ISettings _Settings;
        private readonly ILogger _Logger;

        public SupportedLocaleEntityTranslator(ISupportedLocaleEntityFactory supportedLocaleEntityFactory, ILanguageEntityFactory languageEntityFactory, ILocaleParser localeParser, ISettings settings, ILogger logger)
        {
            _Logger = logger ?? throw new PlatformArgumentNullException(string.Format("{0}", "logger"));
            _Settings = settings ?? throw new PlatformArgumentNullException(string.Format("{0}", "settings"));
            _SupportedLocaleEntityFactory = supportedLocaleEntityFactory ?? throw new PlatformArgumentNullException(string.Format("{0}", "supportedLocaleEntityFactory"));
            _LanguageEntityFactory = languageEntityFactory ?? throw new PlatformArgumentNullException(string.Format("{0}", "languageEntityFactory"));
            _LocaleParser = localeParser ?? throw new PlatformArgumentNullException("localeParser");
        }

        public ISupportedLocale GetDefaultSupportedLocale()
        {
            SetDefaultSupportedLocale();
            return _DefaultSupportedLocale ?? GetDefaultSupportedLocaleFromSettings();
        }

        public ISupportedLocale GetSupportedLocale(ISupportedLocaleEntity supportedLocaleEntity)
        {
            if (supportedLocaleEntity == null)
            {
                return null;
            }
            ILanguageFamily language = CoreLocalizationAccessor.ToLanguage(_LanguageEntityFactory.Get(supportedLocaleEntity.LanguageId));
            return new SupportedLocale(new SupportedLocaleDAL
            {
                ID = supportedLocaleEntity.Id,
                Locale = supportedLocaleEntity.Locale,
                Name = supportedLocaleEntity.Name,
                NativeName = supportedLocaleEntity.NativeName,
                LanguageID = supportedLocaleEntity.LanguageId
            });
        }

        private void SetDefaultSupportedLocale()
        {
            if (_DefaultSupportedLocale != null && _DefaultSupportedLocale.LocaleCode == _Settings.DefaultSupportedLocale)
            {
                return;
            }
            try
            {
                _DefaultSupportedLocale = GetSupportedLocale(_SupportedLocaleEntityFactory.GetByLocale(_Settings.DefaultSupportedLocale));
            }
            catch (Exception exception)
            {
                _Logger.Error(exception);
            }
        }

        private ISupportedLocale GetDefaultSupportedLocaleFromSettings()
        {
            return new SupportedLocale(new SupportedLocaleDAL
            {
                Locale = _Settings.DefaultSupportedLocale,
                Name = _Settings.DefaultSupportedLocaleName,
                NativeName = _Settings.DefaultSupportedLocaleNativeName,
                LanguageID = _Settings.DefaultSupportedLocaleAssociatedLanguageId
            });
        }
    }
}
