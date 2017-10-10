namespace DIOnDotNetCoreCLI.Services
{
    public interface IFormatterService
    {
        string AddAsciFluff(string originalText);
    }

    internal class FormatterService : IFormatterService
    {
        public string AddAsciFluff(string originalText)
        {
            return $"{originalText} @}}~}}~~~";
        }
    }
}
