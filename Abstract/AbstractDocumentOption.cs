public abstract class AbstractDocumentOption : AbstractDocument 
{
    private readonly IDocument _decoratedDocument;

    public AbstractDocumentOption(IDocument decoratedDocument) :base(decoratedDocument.DocumentType)
    {
        _decoratedDocument = decoratedDocument;
    }
}