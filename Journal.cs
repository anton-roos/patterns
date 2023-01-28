class Journal
{
    private readonly List<string> entries = new List<string>();
    private static int count = 0;

    public int AddEntry(string entry)
    {
        // In C# ++i does not function the same as C and C++
        // See: https://stackoverflow.com/questions/3346450/what-is-the-difference-between-i-and-i
        entries.Add($"{++count}: {entry}");
        return count; // Memento Pattern
    }

    public void RemoveEntry(int index)
    {
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
}
