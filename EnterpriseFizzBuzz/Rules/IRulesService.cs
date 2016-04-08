using System.Collections.Generic;

namespace EnterpriseFizzBuzz.Rules
{
    public interface IRulesService
    {
        IEnumerable<Rule> GetRules();
    }
}