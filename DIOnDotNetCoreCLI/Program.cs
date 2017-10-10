using Microsoft.Extensions.DependencyInjection;
using System;
using DIOnDotNetCoreCLI.Commands;
using DIOnDotNetCoreCLI.Services;

namespace DIOnDotNetCoreCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddMyServices()
                .AddSingleton<ICommand, QuoteCommand>()
                .BuildServiceProvider();
                
            var commandLineApp = new CommandLineApplicationWithDI(serviceProvider);
            commandLineApp.Execute(args);
        }
    }
}
