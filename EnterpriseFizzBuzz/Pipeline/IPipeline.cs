using EnterpriseFizzBuzz.Translation;

namespace EnterpriseFizzBuzz.Pipeline
{
    public interface IPipeline
    {
        string Go(int i, SupportedLanguage lang);
    }
}