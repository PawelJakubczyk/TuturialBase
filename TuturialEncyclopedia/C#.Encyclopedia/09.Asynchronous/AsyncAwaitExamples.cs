namespace Encyclopedia.AsyncExamples;

public class AsyncAwaitExamples
{
    public async Task<string> DoAsyncWork()
    {
        await Task.Delay(3000); // simulate some async work
        return "Async work 1 completed";
    }
    public async Task<string> DoAsyncWork2()
    {
        await Task.Delay(1000); // simulate some async work
        return "Async work 2 completed";
    }

    public async Task<string> DoAsyncWork3()
    {
        await Task.Delay(2000); // simulate some async work
        return "Async work 3 completed";
    }

    public async Task StartAsyncWork()
    {
        await Task.Run(DoAsyncWork); // call the async method and wait for it to complete
    }
    
    public async Task StartAsyncWorkWithDelay()
    {   await Task.Delay(500);
        await Task.Run(DoAsyncWork); // call the async method and wait for it to complete
    }


    public async Task DoAsyncWorkAny()
    {
        Task<string>[] taskArray = [DoAsyncWork(), DoAsyncWork2(), DoAsyncWork3()];
        await Task.WhenAny(taskArray);
    }

    public async Task DoAsyncWorkAll()
    {
        Task<string>[] taskArray = [DoAsyncWork(), DoAsyncWork2(), DoAsyncWork3()];
        await Task.WhenAll(taskArray);
    }
}