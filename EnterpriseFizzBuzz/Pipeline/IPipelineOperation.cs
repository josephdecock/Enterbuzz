namespace EnterpriseFizzBuzz.Pipeline
{
    public interface IPipelineOperation
    {
        PipelineData Operate(PipelineData input, string languageCode);
    }
}
