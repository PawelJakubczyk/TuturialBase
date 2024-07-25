namespace Encyclopedia.MemmoryExamples;

public class UsingExamples
{
    public void WriteToFile(string filePath, string content)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(content);
            }
        }
    }

    public string ReadFromFile(string filePath)
    {
        string content = string.Empty;
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            using (StreamReader reader = new StreamReader(fs))
            {
                content = reader.ReadToEnd();
            }
        }
        return content;
    }
}