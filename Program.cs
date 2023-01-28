using System.Diagnostics;

var journal = new Journal();
var persistence = new Persistence();
var filename = @"c:\temp\journal.txt";

journal.AddEntry("My name is Tom Riddle");
journal.AddEntry("Today was an awesome day!");
journal.AddEntry("I love adding entries into my journal");
journal.AddEntry("I am not evil... I think :(");

persistence.SaveToFile(journal, filename, true);
Process.Start(new ProcessStartInfo { FileName = filename, UseShellExecute = true });