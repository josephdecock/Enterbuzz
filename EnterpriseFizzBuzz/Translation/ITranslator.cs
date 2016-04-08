using System.Globalization;

namespace EnterpriseFizzBuzz.Translation
{
    public interface ITranslator
    {
        string Translate(string untranslated);
        CultureInfo CultureInfo { get; }
    }
}