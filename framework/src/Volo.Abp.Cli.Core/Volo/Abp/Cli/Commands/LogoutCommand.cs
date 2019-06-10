﻿using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Cli.Args;
using Volo.Abp.Cli.Auth;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.Cli.Commands
{
    public class LogoutCommand : IConsoleCommand, ITransientDependency
    {
        public ILogger<LogoutCommand> Logger { get; set; }

        protected AuthService AuthService { get; }

        public LogoutCommand(AuthService authService)
        {
            AuthService = authService;
            Logger = NullLogger<LogoutCommand>.Instance;
        }

        public Task ExecuteAsync(CommandLineArgs commandLineArgs)
        {
            return AuthService.LogoutAsync();
        }

        public Task<string> GetUsageInfo()
        {
            return Task.FromResult("");
        }

        public Task<string> GetShortDescriptionAsync()
        {
            return Task.FromResult("");
        }
    }
}