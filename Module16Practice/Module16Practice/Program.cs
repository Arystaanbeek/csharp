using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to File System Changes Logger!");

        try
        {
            Console.WriteLine("Enter directory path to monitor:");
            string directoryPath = Console.ReadLine();

            Console.WriteLine("Enter log file path:");
            string logFilePath = Console.ReadLine();

            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = directoryPath;

            watcher.NotifyFilter = NotifyFilters.LastWrite
                                   | NotifyFilters.FileName
                                   | NotifyFilters.DirectoryName;

            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;

            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = true;

            Console.WriteLine($"Monitoring directory: {directoryPath}");
            Console.WriteLine($"Logging changes to: {logFilePath}");
            Console.WriteLine("Press 'q' to quit.");

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                while (Console.Read() != 'q') ;
                writer.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    private static void OnChanged(object sender, FileSystemEventArgs e)
    {
        LogChange($"File {e.ChangeType}: {e.FullPath}");
    }

    private static void OnRenamed(object sender, RenamedEventArgs e)
    {
        LogChange($"File Renamed: {e.OldFullPath} to {e.FullPath}");
    }

    private static void LogChange(string logMessage)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine($"{DateTime.Now} - {logMessage}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error logging change: " + e.Message);
        }
    }
}
