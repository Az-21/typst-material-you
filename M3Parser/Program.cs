using M3Parser.Model;

namespace M3Parser;
internal static class Program
{
  private const string version = "1.0.1";
  static void Main()
  {
    string[] files = Io.Input.GetFiles();
    List<M3Theme> themes = Parse.Theme.FromKotlinFiles(files);
    Io.Output.WriteThemes(themes, version);

    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}
