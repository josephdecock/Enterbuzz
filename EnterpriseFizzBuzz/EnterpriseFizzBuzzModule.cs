using Autofac;

namespace EnterpriseFizzBuzz
{
    public class EnterpriseFizzBuzzModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();
        }
    }
}
