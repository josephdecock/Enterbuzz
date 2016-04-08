using EnterpriseFizzBuzz.Translation;
using Shouldly;
using Xunit;

namespace EnterpriseFizzBuzz.Tests.Translation
{
    public class FrenchTranslatorTests
    {
        [Theory, AutoMoqData]
        public void Fizz_should_translate_as_pétiller(FrenchTranslator sut)
        {
            sut.Translate("fizz").ShouldBe("pétiller");
        }
    }
}
