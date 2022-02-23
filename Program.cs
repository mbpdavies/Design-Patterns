using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
// See https://aka.ms/new-console-template for more information

// setup host for configuration and service injection
IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices((_,services) => 
                    {
                        // setup entry point class
                        services.AddTransient<App>();
                        // setup additional services
                        services.AddTransient<IEmailService,EmailService>();
                    })
                .Build();

// create instance of App from service container
var app = ActivatorUtilities.CreateInstance<App>(host.Services);

// call the run method (main application code)
app.Run();