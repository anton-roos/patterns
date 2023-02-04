using System.Diagnostics;
using ChainOfResponsibility;

var journal = new Journal();
var persistence = new Persistence();
var filename = @"c:\temp\journal.txt";

journal.AddEntry("My name is Tom Riddle");
journal.AddEntry("Today was an awesome day!");
journal.AddEntry("I love adding entries into my journal");
journal.AddEntry("I am not evil... I think :(");

persistence.SaveToFile(journal, filename, true);
Process.Start(new ProcessStartInfo { FileName = filename, UseShellExecute = true });
FireAndForget.FireAndForget.TestTask();
// Chain of Responsibility
Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();
Handler h3 = new ConcreteHandler3();
h1.SetSuccessor(h2);
h2.SetSuccessor(h3);

int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

foreach (int request in requests)
{
    h1.HandleRequest(request);
}

try
{
    Console.WriteLine("Main starts at " + DateTime.Now.ToLongTimeString());
    FireAndForget.FireAndForget.TestTask();
    Console.WriteLine("Main ends at " + DateTime.Now.ToLongTimeString() + ", " + Thread.CurrentThread.ManagedThreadId);
}
catch (Exception ex)
{
    Console.WriteLine("ex: " + ex.Message);
}

Console.Read();