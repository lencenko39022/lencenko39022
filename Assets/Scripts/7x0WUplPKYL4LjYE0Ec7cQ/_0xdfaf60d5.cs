// The three tables in the hall.
//
// The list is built lazily behind a property rather than in a static field initialiser:
// obfuscation turns encrypted strings into runtime initialised fields and may reorder
// the declarations, so a table built at type load could be built before the strings it
// holds exist (C.52). A property evaluated on first use cannot be reordered.
//
// Face order on every strip is: 0 mask (substitutes for anything), 1 crown, 2 bell,
// 3 gem, 4 ace, 5 card. Weights sum to the strip length, so a weight IS the number of
// copies of that face on a strip and the stated odds are exact.
//
// The three mixes are different games, not three skins:
//   HARLEQUIN HALL  balanced - one mask on the strip, a long tail of cards
//   VELVET ROYALE   fewer small wins, far richer top end (the mask pays 30x)
//   GILDED MASQUE   mask heavy, wins land about twice as often, top end cut to 12x
// Every one of them is enumerated by ReelTable.AnalyticReturn and lands in the 0.88 to
// 0.94 band; the numbers below were chosen against that calculation, not by feel.
public static class _0xdfaf60d5
{
    private static _0x9aaba7e8[] Build()
    {
        _0x9aaba7e8 _0x21cf5b15 = new _0x9aaba7e8()._0x390a9cbe(_0x3974ee32._0x767e12ce(new byte[14] { 23, 30, 13, 19, 26, 14, 10, 22, 17, 127, 23, 30, 19, 19 }, 95), _0x3974ee32._0x767e12ce(new byte[34] { 24, 31, 10, 0, 14, 107, 121, 123, 107, 102, 107, 126, 107, 7, 2, 5, 14, 24, 107, 102, 107, 4, 5, 14, 107, 28, 2, 7, 15, 107, 6, 10, 24, 0 }, 75), 20, new int[] { 1, 5, 5, 6, 7, 8 }, new int[] { 20, 9, 6, 3, 2, 1 });
        _0x9aaba7e8 _0x8492d6f9 = new _0x9aaba7e8()._0x390a9cbe(_0x3974ee32._0x767e12ce(new byte[13] { 9, 26, 19, 9, 26, 11, 127, 13, 16, 6, 30, 19, 26 }, 95), _0x3974ee32._0x767e12ce(new byte[36] { 154, 157, 136, 130, 140, 233, 253, 249, 233, 228, 233, 155, 136, 155, 140, 155, 233, 158, 128, 135, 154, 233, 228, 233, 250, 249, 145, 233, 157, 134, 153, 233, 133, 128, 135, 140 }, 201), 40, new int[] { 1, 5, 5, 7, 7, 7 }, new int[] { 30, 9, 7, 2, 2, 1 });
        _0x9aaba7e8 _0x2c176485 = new _0x9aaba7e8()._0x390a9cbe(_0x3974ee32._0x767e12ce(new byte[13] { 19, 29, 24, 16, 17, 16, 116, 25, 21, 7, 5, 1, 17 }, 84), _0x3974ee32._0x767e12ce(new byte[43] { 77, 74, 95, 85, 91, 62, 38, 46, 62, 51, 62, 83, 95, 77, 85, 62, 86, 91, 95, 72, 71, 62, 51, 62, 73, 87, 80, 77, 62, 74, 73, 87, 93, 91, 62, 95, 77, 62, 81, 88, 74, 91, 80 }, 30), 80, new int[] { 4, 4, 5, 6, 6, 7 }, new int[] { 12, 2, 2, 1, 1, 1 });
        return new _0x9aaba7e8[]
        {
            _0x21cf5b15,
            _0x8492d6f9,
            _0x2c176485
        };
    }

    private static _0x9aaba7e8[] _0x1e82071b;
    // Face names, in strip order. ASCII words only - the atlas has no pip glyphs.
    private static string[] _0xcd4c3e1a;
    public static int _0xc0c6bbec => _0xc77912a5.Length;

    public static string FaceName(int _0x62f23072)
    {
        if (_0xcd4c3e1a == null)
        {
            _0xcd4c3e1a = new string[]
            {
                _0x3974ee32._0x767e12ce(new byte[9] { 18, 12, 9, 1, 101, 8, 4, 22, 14 }, 69),
                _0x3974ee32._0x767e12ce(new byte[5] { 221, 204, 209, 201, 208 }, 158),
                _0x3974ee32._0x767e12ce(new byte[4] { 124, 123, 114, 114 }, 62),
                _0x3974ee32._0x767e12ce(new byte[3] { 20, 22, 30 }, 83),
                _0x3974ee32._0x767e12ce(new byte[3] { 203, 201, 207 }, 138),
                _0x3974ee32._0x767e12ce(new byte[4] { 172, 174, 189, 171 }, 239)
            };
        }

        int _0x6aff13ae = _0x62f23072 < 0 ? 0 : (_0x62f23072 >= _0xcd4c3e1a.Length ? _0xcd4c3e1a.Length - 1 : _0x62f23072);
        return _0xcd4c3e1a[_0x6aff13ae];
    }

    public static _0x9aaba7e8[] _0xc77912a5 => _0x1e82071b != null ? _0x1e82071b : (_0x1e82071b = Build());

    public static _0x9aaba7e8 At(int _0x36987386)
    {
        _0x9aaba7e8[] _0xf1d3d232 = _0xc77912a5;
        int _0xad687aa9 = _0x36987386 < 0 ? 0 : (_0x36987386 >= _0xf1d3d232.Length ? _0xf1d3d232.Length - 1 : _0x36987386);
        return _0xf1d3d232[_0xad687aa9];
    }
}

internal static class _0x3974ee32
{
    internal static string _0x767e12ce(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}