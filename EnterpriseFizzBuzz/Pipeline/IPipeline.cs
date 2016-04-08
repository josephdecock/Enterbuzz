namespace EnterpriseFizzBuzz.Pipeline
{
    public interface IPipeline
    {
        string Go(int i, string languageCode);
    }
}