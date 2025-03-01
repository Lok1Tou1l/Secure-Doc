using System;
using System.IO;

public static class ExceptionLogger
{
    private static readonly string logFilePath = "logs/exceptions.log";

    public static void LogException(Exception ex)
    {
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {ex.Message}");
                writer.WriteLine(ex.StackTrace);
            }
        }
        catch (Exception logEx)
        {
            Console.WriteLine($"Failed to log exception: {logEx.Message}");
        }
    }
}
