// Five lines over a three by three window: the three rows, and the two diagonals.
//
// A line pays when all three faces are the same once the mask has stood in for whatever
// it sits next to; three masks pay the mask's own figure. There is no separate "two
// masks" rule - a mask substitutes, so two masks and a crown already IS a crown line,
// and a second rule would only have paid less for the same picture.
public static class _0x4dc369d4
{
    // The whole window at once. The result object is reused by the caller, so the
    // evaluator allocates nothing per round beyond the result it is handed.
    public static void Evaluate(int[] _0xe4ac5608, _0x9aaba7e8 _0x184baaa5, int _0xbdfc3466, _0xad51c8f1 _0xcdd03712)
    {
        _0xcdd03712._0xe08cd262(_0xbdfc3466);
        for (int _0x443fff95 = 0; _0x443fff95 < LineCount; _0x443fff95++)
        {
            int _0x6993206e = LineFace(_0xe4ac5608, _0x443fff95);
            if (_0x6993206e < 0)
            {
                continue;
            }

            int _0x22e15ac2 = _0x184baaa5._0xa9537078[_0x6993206e];
            if (_0x22e15ac2 <= 0)
            {
                continue;
            }

            _0xcdd03712._0xbe2ceb4d(_0x443fff95, _0x6993206e, _0x22e15ac2, _0xbdfc3466 * _0x22e15ac2);
        }
    }

    // The face a line settles on once masks have substituted, or -1 for no win.
    public static int LineFace(int[] _0x92f3c8ff, int _0x2733b30f)
    {
        int[] _0xeb3f9592 = _0x509a1731[_0x2733b30f];
        int _0xef8967f0 = -1;
        for (int _0x54ce807a = 0; _0x54ce807a < _0xbbd798a9.Reels; _0x54ce807a++)
        {
            int _0xb498f1ce = _0x92f3c8ff[Cell(_0x54ce807a, _0xeb3f9592[_0x54ce807a])];
            if (_0xb498f1ce == _0xbbd798a9.WildSymbol)
            {
                continue;
            }

            if (_0xef8967f0 < 0)
            {
                _0xef8967f0 = _0xb498f1ce;
            }
            else if (_0xef8967f0 != _0xb498f1ce)
            {
                return -1;
            }
        }

        return _0xef8967f0 < 0 ? _0xbbd798a9.WildSymbol : _0xef8967f0;
    }

    public static int[][] _0x509a1731
    {
        get
        {
            if (_0x2bd2ad6d == null)
            {
                _0x2bd2ad6d = new int[][]
                {
                    new int[]
                    {
                        0,
                        0,
                        0
                    },
                    new int[]
                    {
                        1,
                        1,
                        1
                    },
                    new int[]
                    {
                        2,
                        2,
                        2
                    },
                    new int[]
                    {
                        0,
                        1,
                        2
                    },
                    new int[]
                    {
                        2,
                        1,
                        0
                    },
                };
            }

            return _0x2bd2ad6d;
        }
    }

    public const int LineCount = 5;
    private static string[] _0x8811199e;
    public static int Cell(int _0x909258be, int _0x7faf44ec)
    {
        return _0x909258be * _0xbbd798a9.Rows + _0x7faf44ec;
    }

    // Row index taken from each reel, per line. 0 is the top row.
    private static int[][] _0x2bd2ad6d;
    public static string LineName(int _0x1d36f7c9)
    {
        if (_0x8811199e == null)
        {
            _0x8811199e = new string[]
            {
                _0x3ea17a2e._0x81b3f701(new byte[7] { 1, 26, 5, 117, 7, 26, 2 }, 85),
                _0x3ea17a2e._0x81b3f701(new byte[10] { 113, 119, 124, 102, 96, 119, 18, 96, 125, 101 }, 50),
                _0x3ea17a2e._0x81b3f701(new byte[10] { 1, 12, 23, 23, 12, 14, 99, 17, 12, 20 }, 67),
                _0x3ea17a2e._0x81b3f701(new byte[12] { 207, 200, 197, 197, 192, 199, 206, 169, 197, 192, 199, 204 }, 137),
                _0x3ea17a2e._0x81b3f701(new byte[11] { 164, 191, 165, 191, 184, 177, 214, 186, 191, 184, 179 }, 246)
            };
        }

        int _0xa96b6daa = _0x1d36f7c9 < 0 ? 0 : (_0x1d36f7c9 >= _0x8811199e.Length ? _0x8811199e.Length - 1 : _0x1d36f7c9);
        return _0x8811199e[_0xa96b6daa];
    }

    public static int LineMultiplier(int[] _0x94b2a7ce, int _0x3706af25, _0x9aaba7e8 _0x2c711c17)
    {
        int _0xe3df6bc5 = LineFace(_0x94b2a7ce, _0x3706af25);
        if (_0xe3df6bc5 < 0)
        {
            return 0;
        }

        return _0x2c711c17._0xa9537078[_0xe3df6bc5];
    }
}

internal static class _0x3ea17a2e
{
    internal static string _0x81b3f701(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}