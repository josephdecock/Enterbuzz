using System.Collections.Generic;
using System.Globalization;

namespace EnterpriseFizzBuzz.Translation
{
    public class JapaneseTranslator : TranslatorBase 
    {
        public override CultureInfo CultureInfo
        {
            get { return new CultureInfo("jp"); }
        }

        protected override Dictionary<string, string> Dictionary
        {
            get
            {
                return new Dictionary<string, string>
                {
                    {"Fizz", "フィズ"},
                    {"Buzz", "バズ"}
                };
            }
        }
    }
}