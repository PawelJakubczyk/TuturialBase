namespace Encyclopedia.AsyncExamples;

public class AsyncAwaitExamples
{
    public async Task DoAsyncWork()
    {
        await Task.Delay(2000); // simulate some async work
        Console.WriteLine("Async work completed");
    }

    public void StartAsyncWork()
    {
        DoAsyncWork().Wait(); // call the async method and wait for it to complete
    }
}