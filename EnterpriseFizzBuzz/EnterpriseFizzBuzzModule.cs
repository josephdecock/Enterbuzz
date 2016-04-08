using Autofac;
using EnterpriseFizzBuzz.Translation;

namespace EnterpriseFizzBuzz
{
    public class EnterpriseFizzBuzzModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Namespace == "EnterpriseFizzBuzz.Pipeline" ||
                            t.Namespace == "EnterpriseFizzBuzz.Rules")
                .AsImplementedInterfaces();

            builder.RegisterType<FrenchTranslator>().Keyed<ITranslator>("fr");
            builder.RegisterType<ArabicTranslator>().Keyed<ITranslator>("ar");
            builder.RegisterType<JapaneseTranslator>().Keyed<ITranslator>("jp");
            builder.RegisterType<EnglishTranslator>().Keyed<ITranslator>("en");
        }
    }
}
