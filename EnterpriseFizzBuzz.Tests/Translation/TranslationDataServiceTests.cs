using EnterpriseFizzBuzz.Translation;
using Moq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace EnterpriseFizzBuzz.Tests.Translation
{
    public class TranslationDataServiceTests
    {
        [Theory, AutoMoqData]
        public void Should_Cache_Translation_Data([Frozen] Mock<ITranslationDataService> dataService, Translator sut, string sourceText, SupportedLanguage lang)
        {
            sut.Translate(sourceText, lang);
            sut.Translate(sourceText, lang);

            dataService.Verify(d => d.GetDictionary(lang), Times.Exactly(1));
        }
    }
}
