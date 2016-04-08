using System;
using System.Linq;
using Autofac.Features.Indexed;
using EnterpriseFizzBuzz.Rules;
using EnterpriseFizzBuzz.Translation;

namespace EnterpriseFizzBuzz.Pipeline
{
    public class Pipeline : IPipeline
    {
        private readonly IRulesService rulesService;
        private readonly IIndex<string, ITranslator> translatorIndex;
 
        public Pipeline(IRulesService rulesService, IIndex<string, ITranslator> translatorIndex)
        {
            this.rulesService = rulesService;
            this.translatorIndex = translatorIndex;
        }

        public string Go(int i, string languageCode)
        {
            var rules = rulesService.GetRules();
            var translator = translatorIndex[languageCode]; //Error handling omitted for brevity

            var result = rules
                .Where(rule => i%rule.Modulo == 0)
                .Aggregate(String.Empty, (current, rule) => current + translator.Translate(rule.Label));
 
            if (result == String.Empty)
            {
                result = i.ToString();
            }

            return result;
        }
    }
}
