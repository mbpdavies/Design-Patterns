using Microsoft.Extensions.Configuration;

public class EmailService : IEmailService
{
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
        _config = config;
    }
    public void SendEmail()
    {
        // test config injection
        Console.WriteLine($"The live connection string is {_config.GetValue<string>("ConnectionStrings:LIVE")}");
        Console.WriteLine("Sending email...");
    }
}
