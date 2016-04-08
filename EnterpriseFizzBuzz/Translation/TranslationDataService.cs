using System.Collections.Generic;

namespace EnterpriseFizzBuzz.Translation
{
    public class TranslationDataService : ITranslationDataService
    {
        // Basic hard-coded implementation should be replaced with REST call to be more "enterprisey" :)
        public Dictionary<string, string> GetDictionary(SupportedLanguage lang)
        {
            switch (lang)
            {
                case SupportedLanguage.Arabic:
                    return MakeDictionary("أز", "طن");
                case SupportedLanguage.French:
                    return MakeDictionary("pétiller", "bourdonner");
                case SupportedLanguage.Japanese:
                    return MakeDictionary("フィズ", "バズ");
                case SupportedLanguage.English:
                default:
                    return MakeDictionary("fizz", "buzz");
            }
        }

        // Convenience method for creating hard-coded dictionary data
        private Dictionary<string, string> MakeDictionary(string fizz, string buzz)
        {
            return new Dictionary<string, string>
            {
                {"fizz", fizz},
                {"buzz", buzz}
            };
        }
    }
}
