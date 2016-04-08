using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using EnterpriseFizzBuzz.Pipeline;
using EnterpriseFizzBuzz.Translation;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EnterpriseFizzBuzz.Web.Startup))]

namespace EnterpriseFizzBuzz.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);


            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModule<PipelineModule>();
            builder.RegisterModule<TranslationModule>();
            var container = builder.Build();
            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
