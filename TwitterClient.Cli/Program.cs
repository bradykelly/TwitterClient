using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwitterClient.Cli;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.Configure<ApiSecrets>(context.Configuration.GetSection(nameof(ApiSecrets)));
        services.AddSingleton<TwitterHelper>();
    })
    .Build();
    
var twitterHelper = host.Services.GetService<TwitterHelper>();