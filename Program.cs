// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(args.Length);

List<IDocument> documents = new List<IDocument>();

documents.Add(new Invoice());

documents.Add(new ReminderLetter());

foreach(IDocument document in documents)
{
    document.Print();
    document.Email();
}

// test commit