public class LegalAddress : IRecipient
{
    string[] IRecipient.AddressLines => new string[]{"Address Line 1","Address Line 2"};

    string IRecipient.Email => "legalemail@test.com";
}