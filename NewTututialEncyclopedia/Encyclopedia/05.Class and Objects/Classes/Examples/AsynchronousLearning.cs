namespace Encyclopedia.ClassesExamples;

public sealed class AsynchronousLearning
{
    public async Task<string> GetRoglaName()
    {
        //getting rogal name
        await Task.Delay(100);
        return "Michal";
    }

    public async Task Yakuza()
    {
        var rogalName = await GetRoglaName();

        if (rogalName == "Michal")
        {
            Console.WriteLine("fgdsfsdfs");
            return;
        }

        Console.WriteLine("oppppppppppppppppppp");
    }

    public async Task SaveBetterAsyc()
    {
        await PersistInDatabase();
    }

    private async Task PersistInDatabase()
    {
        throw new NotImplementedException();
    }

    public List<Task> SaveAsync()
    {
        var taskList = new List<Task>();

        foreach (var item in Enumerable.Range(1, 100))
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine("Sdfdsfsd'");
            });

            taskList.Add(task);
        }

        return taskList;
    }

    public async Task Execute(List<Task> tasks)
    {
        await Task.WhenAll(tasks);
    }
}