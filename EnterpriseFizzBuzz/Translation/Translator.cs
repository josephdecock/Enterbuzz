namespace EnterpriseFizzBuzz.Translation
{
    public class Translator : ITranslator
    {
        private readonly ITranslationDataService translationDataService;

        public Translator(ITranslationDataService translationDataService)
        {
            this.translationDataService = translationDataService;
        }

        public string Translate(string sourceText, SupportedLanguage lang)
        {
            var dictionary = translationDataService.GetDictionary(lang);
            return dictionary.ContainsKey(sourceText) ? dictionary[sourceText] : sourceText;
        }
    }
}
