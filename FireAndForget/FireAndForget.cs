namespace FireAndForget;

public static class FireAndForget
{
    public static async void TestTask()
    {
        try
        {
            Thread.Sleep(3000);
            await Task.Delay(3000);
            throw new InvalidOperationException();
        }
        catch
        {
            Console.WriteLine("TestTask exception at " + DateTime.Now.ToLongTimeString() + ", " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}