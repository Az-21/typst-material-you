namespace M3Parser.Io;
internal static class Input
{
  private const string InputFolder = "Input";
  internal static string[] GetFiles()
  {
    // Ensure input folder exists => Create one if it does not
    bool inputFolderExists = Directory.Exists(InputFolder);
    if (!inputFolderExists) { Directory.CreateDirectory(InputFolder); }

    // Get address of all Kotlin files
    string[] kotlinThemeFiles = GetDartFiles();

    // Check to ensure at least one file exists => Terminate otherwise
    EarlyExit(kotlinThemeFiles);

    // Print status
    PrintDetetedFiles(kotlinThemeFiles);

    return kotlinThemeFiles;
  }

  private const string KotlinType = "*.kt";
  private static string[] GetDartFiles() => Directory.GetFiles(InputFolder, KotlinType);

  private static void EarlyExit(in string[] files)
  {
    if (files.Length > 0) { return; }
    Console.WriteLine("No `.kt` file found in `Input` folder");
    Console.Write("Press any key to exit...");
    Console.ReadKey();
    System.Environment.Exit(0);
  }

  private static void PrintDetetedFiles(in string[] files)
  {
    int length = files.Length;
    Console.WriteLine($"Detected {length} theme file(s):");
    foreach (string file in files) { Console.WriteLine($"  - {file}"); }
  }
}
