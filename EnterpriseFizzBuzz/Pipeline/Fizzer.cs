using Autofac.Features.Indexed;
using EnterpriseFizzBuzz.Translation;

namespace EnterpriseFizzBuzz.Pipeline
{
    public class Fizzer : IPipelineOperation
    {
        private readonly IIndex<string, ITranslator> translatorIndex;

        public Fizzer(IIndex<string, ITranslator> translatorIndex)
        {
            this.translatorIndex = translatorIndex;
        }

        public PipelineData Operate(PipelineData input, string languageCode)
        {
            if (input.Number%3 == 0)
            {
                var translator = translatorIndex[languageCode];
                input.Label += translator.Translate("fizz");
            }
            return input;
        }
    }
}
