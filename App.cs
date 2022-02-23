// See https://aka.ms/new-console-template for more information

using System.Text.Json;

public class App
{
    private readonly IEmailService _emailService;

    public App(IEmailService emailService)
    {
        _emailService = emailService;
    }
    public void Run()
    {
        Console.WriteLine("Application is running...");

        List<IDocument> documents = new List<IDocument>();

        documents.Add(new Invoice());

        documents.Add(new ReminderLetter());

        // using list of documents, create list of queue items (as if this had been retrieved from DB)
        List<QueueItem> queueItems = new List<QueueItem>();
        foreach(IDocument document in documents)
        {
            QueueItem queueItem = new QueueItem()
            {
                DocumentJSON = JsonSerializer.Serialize(document),
                DocumentType = document.DocumentType
            };
            queueItems.Add(queueItem);
        }

        List<IDocument> convertedDocs = new List<IDocument>();

        // loop through the returned queue items and instantiate type based on document type
        foreach(QueueItem item in queueItems)
        {
            Type docType = Type.GetType(item.DocumentType.ToString());
            convertedDocs.Add((IDocument)JsonSerializer.Deserialize(item.DocumentJSON,docType));
        }

        foreach(IDocument document in documents)
        {
            document.Print();
            document.Email();
        }

        _emailService.SendEmail();
    }
}