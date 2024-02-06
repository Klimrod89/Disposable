namespace DemoLibrary;

public class DemoResource : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Closing Connection via Dispose");
    }

    public void DoWork()
    {
        Console.WriteLine("Opening Connection");
        Console.WriteLine("Doing work...");
        throw new Exception("I broke");
        Console.WriteLine("Closing Connection");
    }  
}
