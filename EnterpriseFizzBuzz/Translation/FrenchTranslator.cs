using System.Collections.Generic;
using System.Globalization;

namespace EnterpriseFizzBuzz.Translation
{
    public class FrenchTranslator : TranslatorBase
    {
        protected override Dictionary<string, string> Dictionary
        {
            get
            {
                return new Dictionary<string, string>
                {
                    {"fizz", "pétiller"},
                    {"buzz", "bourdonner"}
                };
            }
        }

        public override CultureInfo CultureInfo { get { return new CultureInfo("fr");} }
    }
}