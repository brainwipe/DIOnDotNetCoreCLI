namespace DIOnDotNetCoreCLI.Services
{
    public interface IQuotesService
    {
        string Shakespear();
    }

    internal class QuotesService : IQuotesService
    {
        private readonly IFormatterService formatterService;

        public QuotesService(IFormatterService formatterService)
        {
            this.formatterService = formatterService;
        }

        public string Shakespear()
        {
            return formatterService.AddAsciFluff("A rose by any other name would smell as sweet");
        }
    }
}
