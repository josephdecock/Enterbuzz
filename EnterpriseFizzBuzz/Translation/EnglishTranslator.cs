using System.Globalization;

namespace EnterpriseFizzBuzz.Translation
{
    class EnglishTranslator : ITranslator
    {
        public string Translate(string untranslated)
        {
            return untranslated;
        }

        public CultureInfo CultureInfo
        {
            get { return new CultureInfo("en"); }
        }
    }
}
