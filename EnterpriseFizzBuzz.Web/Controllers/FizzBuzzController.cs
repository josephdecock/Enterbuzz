using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using EnterpriseFizzBuzz.Pipeline;

namespace EnterpriseFizzBuzz.Web.Controllers
{
    public class FizzBuzzController : ApiController
    {
        private readonly IPipeline pipeline;

        public FizzBuzzController(IPipeline pipeline)
        {
            this.pipeline = pipeline;
        }

        public IEnumerable<string> Get(int i, string languageCode = "en")
        {
            return Enumerable.Range(1, i).Select(n => pipeline.Go(n, languageCode));
        }
    }
}