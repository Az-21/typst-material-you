namespace M3Parser;

internal static class Program
{
  static void Main()
  {
    string[] files = Io.Input.GetFiles();
    var themes = Parse.Theme.FromKotlinFiles(files);
    Io.Output.WriteThemes(themes);

    Console.Write("Press any key to exit...");
    Console.ReadKey();
  }
}
