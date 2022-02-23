public interface IDocument 
{
    IRecipient Recipient {get;}
    DocumentType DocumentType {get;}
    void Print();
    void Email();
}