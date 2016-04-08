using System;
using System.Linq;
using EnterpriseFizzBuzz.Rules;
using EnterpriseFizzBuzz.Translation;

namespace EnterpriseFizzBuzz.Pipeline
{
    public class Pipeline : IPipeline
    {
        private readonly IRulesService rulesService;
        private readonly ITranslator translator;

        public Pipeline(IRulesService rulesService, ITranslator translator)
        {
            this.rulesService = rulesService;
            this.translator = translator;
        }

        public string Go(int i, SupportedLanguage lang)
        {
            var rules = rulesService.GetRules();

            var result = rules
                .Where(rule => i % rule.Modulo == 0)
                .Aggregate(String.Empty, (current, rule) => current + translator.Translate(rule.Label, lang));

            if (result == String.Empty)
            {
                result = i.ToString();
            }

            return result;
        }
    }
}
