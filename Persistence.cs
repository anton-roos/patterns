class Persistence
{
    public void SaveToFile(Journal journal, string filename, bool @override = false)
    {
        if (@override || !File.Exists(filename))
            File.WriteAllText(filename, journal.ToString());
    }
}