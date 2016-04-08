using Autofac;

namespace EnterpriseFizzBuzz.Translation
{
    public class TranslationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrenchTranslator>().Keyed<ITranslator>("fr");
            builder.RegisterType<ArabicTranslator>().Keyed<ITranslator>("ar");
            builder.RegisterType<JapaneseTranslator>().Keyed<ITranslator>("jp");
            builder.RegisterType<EnglishTranslator>().Keyed<ITranslator>("en");
        }
    }
}
