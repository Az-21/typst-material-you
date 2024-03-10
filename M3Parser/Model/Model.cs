namespace M3Parser.Model;
internal record class M3ThemePair(string ColorName, string ColorHex);
internal record class M3Theme(string Filename, List<M3ThemePair> M3ThemePairs);

