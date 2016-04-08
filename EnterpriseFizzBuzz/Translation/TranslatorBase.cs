using System.Collections.Generic;
using System.Globalization;

namespace EnterpriseFizzBuzz.Translation
{
    public abstract class TranslatorBase : ITranslator
    {
        protected abstract Dictionary<string, string> Dictionary { get; }

        public string Translate(string untranslated)
        {
            if (Dictionary.ContainsKey(untranslated))
            {
                return Dictionary[untranslated];
            }
            else
            {
                return untranslated;
            }
        }

        public abstract CultureInfo CultureInfo { get; }
    }
}
