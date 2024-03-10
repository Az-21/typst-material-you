using System.Text;
using ThemePair = (string, string);

namespace M3Parser.Io;
internal static class Output
{
  private const string OutputFolder = "Output";
  internal static void WriteThemes(in List<(string, List<ThemePair>)> themes)
  {
    // Ensure output folder exists
    bool outputExists = Path.Exists(OutputFolder);
    if (!outputExists) { Directory.CreateDirectory(OutputFolder); }

    // Write
    foreach (var theme in themes)
    {
      // Location
      string typstFilename = theme.Item1 + ".typ";
      string path = Path.Combine(OutputFolder, typstFilename);

      // Content
      string typstThemeVariable = GenerateTypstThemeVariable(theme);
      File.WriteAllText(path, typstThemeVariable);
    }

  }

  private static string GenerateTypstThemeVariable(in (string, List<ThemePair>) theme)
  {
    // Few measures to ensure typst variable name is good to use
    string varname = theme.Item1;
    varname = varname.ToLowerInvariant();
    varname = varname.Replace(" ", String.Empty);

    // Generate theme file contents
    StringBuilder sb = new();
    sb.AppendLine($"#let {varname} = (");
    foreach (ThemePair themePair in theme.Item2)
    {
      sb.Append($"""  {themePair.Item1}: rgb("{themePair.Item2}"),""");
    }
    sb.AppendLine(")");

    return sb.ToString();
  }
}
