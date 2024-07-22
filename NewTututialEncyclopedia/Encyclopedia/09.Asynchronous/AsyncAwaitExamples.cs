using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewTututialEncyclopedia._1.Encyclopedia._08.Asynchronous;

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