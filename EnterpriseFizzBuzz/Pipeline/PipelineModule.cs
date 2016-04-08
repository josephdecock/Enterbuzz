using Autofac;

namespace EnterpriseFizzBuzz.Pipeline
{
    public class PipelineModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Namespace == "EnterpriseFizzBuzz.Pipeline")
                .AsImplementedInterfaces();
        }
    }
}
