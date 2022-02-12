// See https://aka.ms/new-console-template for more information

public class App
{
    public void Run()
    {
        Console.WriteLine("Application is running...");

        Console.WriteLine("Hello, World!");

        //Console.WriteLine(args.Length);

        List<IDocument> documents = new List<IDocument>();

        documents.Add(new Invoice());

        documents.Add(new ReminderLetter());

        foreach(IDocument document in documents)
        {
            document.Print();
            document.Email();
        }
    }
}