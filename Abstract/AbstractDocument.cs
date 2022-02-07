public abstract class AbstractDocument : IDocument
{
    private DocumentType _documentType;
    private IRecipient _recipient;
    
    public AbstractDocument(DocumentType documentType)
    {
        this._documentType = documentType;

        this._recipient = GetRecipientDetails();
    }

    public IRecipient Recipient
    {
        get { return _recipient; }
    }
    protected abstract IRecipient GetRecipientDetails();

    public abstract void Print();

    public abstract void Email();

}