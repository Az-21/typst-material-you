using M3Parser.Model;

namespace M3Parser.Parse;
internal static class Theme
{
  internal static List<M3Theme> FromKotlinFiles(in string[] kotlinFiles)
  {
    List<M3Theme> themes = [];

    foreach (string file in kotlinFiles)
    {
      string filename = Path.GetFileNameWithoutExtension(file);
      List<M3ThemePair> themePairs = Parse.Theme.FromKotlinFile(file);
      themes.Add(new M3Theme(filename, themePairs));
    }

    return themes;
  }

  private const string KotlinThemePairIdentifier = "val md_theme";
  private static List<M3ThemePair> FromKotlinFile(in string kotlinFile)
  {
    List<M3ThemePair> colors = [];

    foreach (string line in File.ReadLines(kotlinFile))
    {
      // Ensure current line represents a theme value/color
      bool isThemeValue = line.StartsWith(KotlinThemePairIdentifier);
      if (!isThemeValue) { continue; }

      // Parse as (color, value)
      colors.Add(ParseKotlinTheme(line));
    }

    return colors;
  }

  private const int KotlinThemeStartIndex = 13; // To trim "val md_theme_"
  private const int KotlinColorValueStartIndex = 10; // To trim "Color(0xFF"
  private static M3ThemePair ParseKotlinTheme(in string value)
  {
    // Input format => "val md_theme_light_primary = Color(0xFF2C5EA7)"

    // Select substring => "light_primary = Color(0xFF2C5EA7)"
    string trimmedValue = value[KotlinThemeStartIndex..];

    // Remove space => "light_primary=Color(0xFF2C5EA7)"
    trimmedValue = trimmedValue.Replace(" ", String.Empty);

    // Split into LHS (color name) and RHS (color value)
    string[] theme = trimmedValue.Split('=');
    string lhs = theme[0]; // light_primary
    string rhs = theme[1]; // Color(0xFF2C5EA7)

    // Cleanup
    lhs = lhs.Replace('_', '-'); // For tailwind-like color names
    rhs = rhs.Substring(KotlinColorValueStartIndex, 6); // HEX color is 6 chars
    rhs = "#" + rhs;

    return new M3ThemePair(lhs, rhs);
  }
}
