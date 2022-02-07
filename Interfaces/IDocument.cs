public interface IDocument 
{
    IRecipient Recipient {get;}
    void Print();
    void Email();
}