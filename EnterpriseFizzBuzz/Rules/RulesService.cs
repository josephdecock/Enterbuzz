using System.Collections.Generic;

namespace EnterpriseFizzBuzz.Rules
{
    public class RulesService : IRulesService
    {
        public IEnumerable<Rule> GetRules()
        {
            // Here's a hard-coded implementation, but to be really "enterprisey", it will become a REST call someday 
            return new List<Rule>
            {
                new Rule {Modulo = 3, Label = "fizz"},
                new Rule {Modulo = 5, Label = "buzz"}
            };
        }
    }
}
