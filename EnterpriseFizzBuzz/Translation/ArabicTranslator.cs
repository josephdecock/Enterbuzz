using System.Collections.Generic;
using System.Globalization;

namespace EnterpriseFizzBuzz.Translation
{
    public class ArabicTranslator : TranslatorBase
    {
        protected override Dictionary<string, string> Dictionary
        {
            get
            {
                return new Dictionary<string, string>
                {
                    {"fizz", "أز"},
                    {"buzz", "طن"}
                };
            }
        }

        public override CultureInfo CultureInfo
        {
            get
            {
                return new CultureInfo("ar");
            }
        }
    }
}