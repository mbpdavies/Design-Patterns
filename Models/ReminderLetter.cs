public class ReminderLetter : AbstractDocument 
{
    public ReminderLetter() : base(DocumentType.ReminderLetter)
    {

    }

    protected override IRecipient GetRecipientDetails()
    {
        Console.WriteLine("Getting reminder letter recipient details (legal address)...");
        return new LegalAddress();
    }

    public override void Email()
    {
        Console.WriteLine($"Sending reminder letter by email to {Recipient.Email}...");
    }

    public override void Print()
    {
        Console.WriteLine($"Sending reminder letter by post to {Recipient.AddressLines[0]}...");
    }
}