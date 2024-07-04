using System;

namespace WeatherMapMVVM.Helpers
{
    public class PlatformCulture
    {
        public string PlatformString { get; private set; }

        public string LanguageCode { get; private set; }

        public string LocaleCode { get; private set; }

        public PlatformCulture(string platformCultureString)
        {
            if (string.IsNullOrEmpty(platformCultureString))
            {
                // in C# 6 use nameof(platformCultureString)
                throw new ArgumentException("Expected culture identifier", "platformCultureString");
            }

            // .NET expects dash, not underscore
            PlatformString = platformCultureString.Replace("_", "-");
            int dashIndex = PlatformString.IndexOf("-", StringComparison.Ordinal);
            if (dashIndex > 0)
            {
                string[] parts = PlatformString.Split('-');
                LanguageCode = parts[0];
                LocaleCode = parts[1];
            }
            else
            {
                LanguageCode = PlatformString;
                LocaleCode = "";
            }
        }

        public override string ToString()
        {
            return PlatformString;
        }
    }
}