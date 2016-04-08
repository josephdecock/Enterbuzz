using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using EnterpriseFizzBuzz.Pipeline;
using EnterpriseFizzBuzz.Translation;

namespace EnterpriseFizzBuzz.Web.Controllers
{
    public class FizzBuzzController : ApiController
    {
        private readonly IPipeline pipeline;

        public FizzBuzzController(IPipeline pipeline)
        {
            this.pipeline = pipeline;
        }

        [Route("api/fizzbuzz/{i}")]
        public IEnumerable<string> Get(int i, SupportedLanguage lang = SupportedLanguage.English)
        {
            return Enumerable.Range(1, i).Select(n => pipeline.Go(n, lang));
        }
    }
}