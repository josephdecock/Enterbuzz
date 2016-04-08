using System.Collections.Generic;
using System.Linq;

namespace EnterpriseFizzBuzz.Pipeline
{
    public interface IPipeline
    {
        string Go(int i, string languageCode);
    }

    public class Pipeline : IPipeline
    {
        private readonly IEnumerable<IPipelineOperation> operations;
        public Pipeline(IEnumerable<IPipelineOperation> operations)
        {
            this.operations = operations;
        }

        public string Go(int i, string languageCode)
        {
            //todo - get rid of pipelinedata, and move the translator up here.  
            var init = new PipelineData {Label = string.Empty, Number = i};
            var result = operations.Aggregate(init, (current, pipelineOperation) => pipelineOperation.Operate(current, languageCode));
            if (result.Label == string.Empty)
            {
                result.Label = i.ToString();
            }
            return result.Label;
        }
    }
}
