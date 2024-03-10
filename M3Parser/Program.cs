namespace M3Parser;

internal static class Program
{
  private const string version = "1.0.0";
  static void Main()
  {
    string[] files = Io.Input.GetFiles();
    var themes = Parse.Theme.FromKotlinFiles(files);
    Io.Output.WriteThemes(themes, version);

    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}
