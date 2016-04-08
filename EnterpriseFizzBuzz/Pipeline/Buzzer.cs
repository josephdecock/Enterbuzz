using Autofac.Features.Indexed;
using EnterpriseFizzBuzz.Translation;

namespace EnterpriseFizzBuzz.Pipeline
{
    public class Buzzer : IPipelineOperation
    {
        private readonly IIndex<string, ITranslator> translatorIndex;

        public Buzzer(IIndex<string, ITranslator> translatorIndex)
        {
            this.translatorIndex = translatorIndex;
        }


        public PipelineData Operate(PipelineData input, string languageCode)
        {
            if (input.Number%5 == 0)
            {
                var translator = translatorIndex[languageCode];
                input.Label += translator.Translate("buzz");
            }
            return input;
        }
    }
}
