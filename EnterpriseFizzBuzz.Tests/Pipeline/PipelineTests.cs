﻿using System.Collections.Generic;
using EnterpriseFizzBuzz.Rules;
using Moq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace EnterpriseFizzBuzz.Tests.Pipeline
{
    public class PipelineTests
    {
        [Theory, AutoMoqData]
        public void Pipeline_should_fetch_rules([Frozen]Mock<IRulesService> rulesService, 
            EnterpriseFizzBuzz.Pipeline.Pipeline sut, 
            int i, string languageCode, IEnumerable<Rule> rules)
        {
            rulesService.Setup(r => r.GetRules()).Returns(rules);

            sut.Go(i, languageCode);

            rulesService.VerifyAll();
        }
    }
}
