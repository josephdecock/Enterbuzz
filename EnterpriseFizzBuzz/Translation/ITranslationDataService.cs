using System.Collections.Generic;

namespace EnterpriseFizzBuzz.Translation
{
    public interface ITranslationDataService
    {
        Dictionary<string, string> GetDictionary(SupportedLanguage lang);
    }
}