public abstract class AbstractDocument : IDocument
{
    protected DocumentType _documentType;
    private IRecipient _recipient;
    
    public AbstractDocument(DocumentType documentType)
    {
        this._documentType = documentType;
        this._recipient = GetRecipientDetails();
    }

    public DocumentType DocumentType
    {
        get { return _documentType; }
    }

    public IRecipient Recipient
    {
        get { return _recipient; }
    }
    protected abstract IRecipient GetRecipientDetails();

    public abstract void Print();

    public abstract void Email();

}