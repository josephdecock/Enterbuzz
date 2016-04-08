namespace EnterpriseFizzBuzz.Translation
{
    public interface ITranslator
    {
        string Translate(string sourceText, SupportedLanguage lang);
    }
}