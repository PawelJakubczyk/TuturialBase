namespace Encyclopedia.AsyncExamples;



//private async Task ReadTextAsync(Yandleri obj)
//{
//    ResultLabel.Content = "Reading started:";
//    var stopwatch = Stopwatch.StartNew();
//    await ProcessFilesAsync();
//    stopwatch.Stop();
//    ResultLabel.Content = $"Finished in: {stopwatch.ElapsedMilliseconds} ms";
//}

//private async Task ProcessFilesAsync()
//{
//    var filesPath = "D:/files/";
//    for (int i = 1; i <= 5; i++)
//    {
//        var filePath = filesPath + $"{i}.txt";
//        try
//        {
//            using (var reader = new StreamReader(filePath, Encoding.UTF8))
//            {
//                ResultLabel.Content = $"Reading {filePath}...";
//                string fileContent = await reader.ReadToEndAsync();
//                // processing file content
//            }
//        }
//        catch (Exception ex)
//        {
//            // handle exception
//        }
//    }
//}