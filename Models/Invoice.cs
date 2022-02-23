public class Invoice : AbstractDocument
{
    public Invoice() : base(DocumentType.Invoice)
    {
        
    }

    protected override IRecipient GetRecipientDetails()
    {
        Console.WriteLine("Getting invoice recipient details (legal address)...");
        return new LegalAddress();
    }

    public override void Email()
    {
        Console.WriteLine($"Sending invoice by email to {Recipient.Email}...");
    }

    public override void Print()
    {
        Console.WriteLine($"Sending invoice by post to {Recipient.AddressLines[0]}...");
    }
}