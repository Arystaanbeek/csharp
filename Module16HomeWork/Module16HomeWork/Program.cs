using System;
using System.IO;

class Program
{
    static void Main()
    {
        string logFilePath = "log.txt";

        while (true)
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1. View directory contents");
            Console.WriteLine("2. Create file/directory");
            Console.WriteLine("3. Delete file/directory");
            Console.WriteLine("4. Copy file/directory");
            Console.WriteLine("5. Move file/directory");
            Console.WriteLine("6. Read from file");
            Console.WriteLine("7. Write to file");
            Console.WriteLine("0. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewDirectoryContents();
                    break;
                case "2":
                    CreateFileOrDirectory();
                    break;
                case "3":
                    DeleteFileOrDirectory();
                    break;
                case "4":
                    CopyFileOrDirectory();
                    break;
                case "5":
                    MoveFileOrDirectory();
                    break;
                case "6":
                    ReadFromFile();
                    break;
                case "7":
                    WriteToFile();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    static void ViewDirectoryContents()
    {
        Console.WriteLine("Enter directory path:");
        string path = Console.ReadLine();

        try
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            Console.WriteLine("Files:");
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            Console.WriteLine("\nDirectories:");
            foreach (string directory in directories)
            {
                Console.WriteLine(Path.GetFileName(directory));
            }

            LogOperation("Viewed directory contents: " + path);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void CreateFileOrDirectory()
    {
        Console.WriteLine("Choose type (file - F, directory - D):");
        string choice = Console.ReadLine();

        Console.WriteLine("Enter path:");
        string path = Console.ReadLine();

        try
        {
            if (choice.ToUpper() == "F")
            {
                File.Create(path);
                Console.WriteLine("File created.");
                LogOperation("Created file: " + path);
            }
            else if (choice.ToUpper() == "D")
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Directory created.");
                LogOperation("Created directory: " + path);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void DeleteFileOrDirectory()
    {
        Console.WriteLine("Choose type (file - F, directory - D):");
        string choice = Console.ReadLine();

        Console.WriteLine("Enter path:");
        string path = Console.ReadLine();

        try
        {
            if (choice.ToUpper() == "F")
            {
                File.Delete(path);
                Console.WriteLine("File deleted.");
                LogOperation("Deleted file: " + path);
            }
            else if (choice.ToUpper() == "D")
            {
                Directory.Delete(path, true);
                Console.WriteLine("Directory deleted.");
                LogOperation("Deleted directory: " + path);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void CopyFileOrDirectory()
    {
        Console.WriteLine("Choose type (file - F, directory - D):");
        string choice = Console.ReadLine();

        Console.WriteLine("Enter source path:");
        string sourcePath = Console.ReadLine();

        Console.WriteLine("Enter target path:");
        string targetPath = Console.ReadLine();

        try
        {
            if (choice.ToUpper() == "F")
            {
                File.Copy(sourcePath, targetPath);
                Console.WriteLine("File copied.");
                LogOperation("Copied file from: " + sourcePath + " to: " + targetPath);
            }
            else if (choice.ToUpper() == "D")
            {
                Directory.CreateDirectory(targetPath);
                CopyDirectory(sourcePath, targetPath);
                Console.WriteLine("Directory copied.");
                LogOperation("Copied directory from: " + sourcePath + " to: " + targetPath);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void CopyDirectory(string sourceDir, string targetDir)
    {
        foreach (string dirPath in Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories))
        {
            Directory.CreateDirectory(dirPath.Replace(sourceDir, targetDir));
        }

        foreach (string filePath in Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories))
        {
            File.Copy(filePath, filePath.Replace(sourceDir, targetDir), true);
        }
    }

    static void MoveFileOrDirectory()
    {
        Console.WriteLine("Choose type (file - F, directory - D):");
        string choice = Console.ReadLine();

        Console.WriteLine("Enter source path:");
        string sourcePath = Console.ReadLine();

        Console.WriteLine("Enter target path:");
        string targetPath = Console.ReadLine();

        try
        {
            if (choice.ToUpper() == "F")
            {
                File.Move(sourcePath, targetPath);
                Console.WriteLine("File moved.");
                LogOperation("Moved file from: " + sourcePath + " to: " + targetPath);
            }
            else if (choice.ToUpper() == "D")
            {
                Directory.Move(sourcePath, targetPath);
                Console.WriteLine("Directory moved.");
                LogOperation("Moved directory from: " + sourcePath + " to: " + targetPath);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void ReadFromFile()
    {
        Console.WriteLine("Enter file path to read from:");
        string filePath = Console.ReadLine();

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File content:");
            Console.WriteLine(content);
            LogOperation("Read content from file: " + filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void WriteToFile()
    {
        Console.WriteLine("Enter file path to write to:");
        string filePath = Console.ReadLine();

        Console.WriteLine("Enter text to write:");
        string content = Console.ReadLine();

        try
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine("Text written to file.");
            LogOperation("Wrote content to file: " + filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void LogOperation(string log)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine($"{DateTime.Now} - {log}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error logging operation: " + e.Message);
        }
    }
}
