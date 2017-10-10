using System;
using System.Collections.Generic;
using System.Text;
using DIOnDotNetCoreCLI.Services;
using McMaster.Extensions.CommandLineUtils;

namespace DIOnDotNetCoreCLI.Commands
{
    internal class QuoteCommand : CommandLineApplication, ICommand
    {
        private readonly IQuotesService quotesService;

        public QuoteCommand(IQuotesService quotesService)
        {
            this.quotesService = quotesService;
            Name = "quote";
            Description = "gives you a bit of Shakespear";
            HelpOption("-? | -h | --help");
            OnExecute((Func<int>)Execute);
        }

        public int Execute()
        {
            Console.WriteLine(quotesService.Shakespear());
            return 0;
        }
    }
}
