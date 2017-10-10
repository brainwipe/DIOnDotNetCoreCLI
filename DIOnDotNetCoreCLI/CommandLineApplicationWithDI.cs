using System;
using System.Collections.Generic;
using System.Text;
using DIOnDotNetCoreCLI.Commands;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace DIOnDotNetCoreCLI
{
    public class CommandLineApplicationWithDI : CommandLineApplication
    {
        private readonly IServiceProvider serviceProvider;

        public CommandLineApplicationWithDI(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            RegisterCommands();
        }

        private void RegisterCommands()
        {
            foreach (var command in serviceProvider.GetServices<ICommand>())
            {
                var commandLineApp = command as CommandLineApplication;

                if (commandLineApp == null)
                {
                    throw new InvalidCastException("Commands must inherit from ICommand and CommandLineApplication");
                }

                Commands.Add(commandLineApp);
            }
        }
    }
}
