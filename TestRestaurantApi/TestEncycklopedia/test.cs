using Xunit.Abstractions;

namespace NewTututial.Test;

public class Test
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Test(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Rogalizacja()
    {
        string.Join('&', ["fd", "gvfv", "Rogl"]);

        await foreach (var task in GetTasksAsync())
        {
            _testOutputHelper.WriteLine(task);
        }
    }

    public async IAsyncEnumerable<string> GetTasksAsync()
    {
        yield return await Task.Run(async () =>
        {
            _testOutputHelper.WriteLine("I start playing Valheim");
            await Task.Delay(3000);
            _testOutputHelper.WriteLine("I stop playing Valheim");
            return "VALHEIM";
        });

        yield return await Task.Run(async () =>
        {
            _testOutputHelper.WriteLine("I start playing Yakuza");
            await Task.Delay(2000);
            _testOutputHelper.WriteLine("I stop playing Yakuza");
            return "YAKUZA";
        });

        yield return await Task.Run(async () =>
        {
            _testOutputHelper.WriteLine("I start playing Persona");
            await Task.Delay(1000);
            _testOutputHelper.WriteLine("I stop playing Persona");
            return "PERSONA";
        });
    }
}