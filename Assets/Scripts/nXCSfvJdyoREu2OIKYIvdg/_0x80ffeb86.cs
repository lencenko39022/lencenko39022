using UnityEngine;

/// <summary>
/// The published maths of the Virtual Reels: strip composition, paytable and the
/// five fixed paylines. The composition is a constant and only its ORDER is shuffled
/// per session, so the return is identical in every session while the strips look
/// different. Multipliers are per line, applied to the TOTAL bet.
///
/// Return, verified offline against these exact types over 2,000,000 spins of the real
/// SpinEngine: line 0.6855 + scatter 0.0421 + free spins 0.1761 = 0.9037 analytic, and
/// 0.9139 measured once the dry-streak guard is included. SPADE is the commonest symbol
/// (5 stops of 24) and therefore pays strictly least at four and five of a kind.
/// </summary>
public static class _0x80ffeb86
{
    public const int LineCount = 5;
    public const int Mask = 5;
    public const int Club = 1;
    public const int Heart = 2;
    /// <summary>Reads the three visible cells of a reel from its stop position.</summary>
    public static void ReadWindow(int[] _0x3973525f, int _0x15f8fa79, int[] _0xb8a880ed, int _0xcd164910)
    {
        for (int _0xa81b569d = 0; _0xa81b569d < Rows; _0xa81b569d++)
            _0xb8a880ed[_0xcd164910 + _0xa81b569d] = _0x3973525f[((_0x15f8fa79 + _0xa81b569d) % _0x3973525f.Length + _0x3973525f.Length) % _0x3973525f.Length];
    }

    private static readonly int[] _0xf467f42f =
    {
        12,
        14,
        18,
        18,
        40,
        70,
        120,
        200,
        0
    };
    public const int Reels = 5;
    /// <summary>[symbol][run length - 3] -> multiplier of the TOTAL bet.</summary>
    private static readonly int[] _0xf8eefe90 =
    {
        1,
        1,
        2,
        2,
        3,
        4,
        7,
        10,
        0
    };
    /// <summary>Stops per reel, one entry per symbol id. Always sums to StripLength.</summary>
    private static readonly int[] _0x2c2ce573 =
    {
        5,
        4,
        4,
        4,
        2,
        2,
        1,
        1,
        1
    };
    private static readonly int[] _0x77cb5a93 =
    {
        0,
        0,
        0,
        0,
        0
    };
    /// <summary>
    /// Multiplier won by one payline over the 15-cell grid (index = reel * Rows + row).
    /// A line pays its best outcome only; the wild substitutes everything but the ticket
    /// and a run of wilds pays on the jester row itself.
    /// </summary>
    public static int EvaluateLine(int[] _0x2e265155, int _0x67ed60de, out int _0x5200a842, out int _0xd87026df)
    {
        int[] _0x86f57035 = LineRows(_0x67ed60de);
        int _0x36a65c44 = 0;
        while (_0x36a65c44 < Reels && _0x2e265155[_0x36a65c44 * Rows + _0x86f57035[_0x36a65c44]] == Jester)
            _0x36a65c44++;
        int _0x4dfef3e4 = -1;
        for (int _0x2a273dc9 = 0; _0x2a273dc9 < Reels; _0x2a273dc9++)
        {
            int _0x38f9a2fd = _0x2e265155[_0x2a273dc9 * Rows + _0x86f57035[_0x2a273dc9]];
            if (_0x38f9a2fd != Jester)
            {
                _0x4dfef3e4 = _0x38f9a2fd;
                break;
            }
        }

        int _0x956d886b = 0;
        int _0xec5d0b9f = 0;
        if (_0x4dfef3e4 >= 0 && _0x4dfef3e4 != Ticket)
        {
            while (_0xec5d0b9f < Reels)
            {
                int _0x35c675bd = _0x2e265155[_0xec5d0b9f * Rows + _0x86f57035[_0xec5d0b9f]];
                if (_0x35c675bd != _0x4dfef3e4 && _0x35c675bd != Jester)
                    break;
                _0xec5d0b9f++;
            }

            _0x956d886b = Multiplier(_0x4dfef3e4, _0xec5d0b9f);
        }

        int _0x3ae7643b = Multiplier(Jester, _0x36a65c44);
        if (_0x3ae7643b > _0x956d886b)
        {
            _0x5200a842 = _0x36a65c44;
            _0xd87026df = Jester;
            return _0x3ae7643b;
        }

        _0x5200a842 = _0x956d886b > 0 ? _0xec5d0b9f : 0;
        _0xd87026df = _0x956d886b > 0 ? _0x4dfef3e4 : -1;
        return _0x956d886b;
    }

    /// <summary>Rows touched by each payline, reel by reel. 0 = top, 1 = middle, 2 = bottom.</summary>
    private static readonly int[] _0xf4d8edc4 =
    {
        1,
        1,
        1,
        1,
        1
    };
    public const int Bell = 4;
    public const int Spade = 0;
    public static int StopsOf(int _0x4d8ff16d)
    {
        if (_0x4d8ff16d < 0 || _0x4d8ff16d >= SymbolCount)
            return 0;
        return _0x2c2ce573[_0x4d8ff16d];
    }

    public static int[] LineRows(int _0xb39629de)
    {
        if (_0xb39629de == 1)
            return _0x77cb5a93;
        if (_0xb39629de == 2)
            return _0x6003f59b;
        if (_0xb39629de == 3)
            return _0xa2629ae5;
        if (_0xb39629de == 4)
            return _0x07748ac1;
        return _0xf4d8edc4;
    }

    public const int FreeSpinMultiplier = 2;
    public const int Crown = 6;
    public const int Jester = 7;
    private static readonly int[] _0x65ff50ca =
    {
        3,
        4,
        6,
        6,
        10,
        18,
        28,
        48,
        0
    };
    public static Color TintOf(int _0x9210c455)
    {
        if (_0x9210c455 == Jester)
            return _0xdc7245d7.GoldLight;
        if (_0x9210c455 == Ticket)
            return _0xdc7245d7.Gold;
        return Color.white;
    }

    public static int Multiplier(int _0x3aa7a97c, int _0x1956b550)
    {
        if (_0x3aa7a97c < 0 || _0x3aa7a97c >= SymbolCount)
            return 0;
        if (_0x1956b550 == 3)
            return _0xf8eefe90[_0x3aa7a97c];
        if (_0x1956b550 == 4)
            return _0x65ff50ca[_0x3aa7a97c];
        if (_0x1956b550 >= 5)
            return _0xf467f42f[_0x3aa7a97c];
        return 0;
    }

    public const int FreeSpinAward = 8;
    public const int SymbolCount = 9;
    public const int StripLength = 24;
    private static readonly int[] _0x07748ac1 =
    {
        2,
        1,
        0,
        1,
        2
    };
    private static readonly int[] _0x6003f59b =
    {
        2,
        2,
        2,
        2,
        2
    };
    public const int Ticket = 8;
    public const int Diamond = 3;
    public const int Rows = 3;
    /// <summary>Number of reels showing at least one ticket.</summary>
    public static int CountScatterReels(int[] _0x8ae46854)
    {
        int _0xd1313731 = 0;
        for (int _0x9a0ff30e = 0; _0x9a0ff30e < Reels; _0x9a0ff30e++)
            for (int _0x314848d3 = 0; _0x314848d3 < Rows; _0x314848d3++)
                if (_0x8ae46854[_0x9a0ff30e * Rows + _0x314848d3] == Ticket)
                {
                    _0xd1313731++;
                    break;
                }

        return _0xd1313731;
    }

    /// <summary>Scatter pay for the given number of reels showing a ticket.</summary>
    public static int ScatterMultiplier(int _0x62ff7752)
    {
        if (_0x62ff7752 >= 5)
            return 50;
        if (_0x62ff7752 == 4)
            return 10;
        if (_0x62ff7752 == 3)
            return 2;
        return 0;
    }

    /// <summary>A 24-stop cyclic strip: fixed composition, order shuffled from the seed.</summary>
    public static int[] BuildStrip(System.Random _0x272f7640)
    {
        int[] _0x4a5eba5b = new int[StripLength];
        int _0x67f3e1b8 = 0;
        for (int _0x2137c115 = 0; _0x2137c115 < SymbolCount; _0x2137c115++)
            for (int _0xf1fe01f4 = 0; _0xf1fe01f4 < _0x2c2ce573[_0x2137c115]; _0xf1fe01f4++)
            {
                _0x4a5eba5b[_0x67f3e1b8] = _0x2137c115;
                _0x67f3e1b8++;
            }

        for (int _0xdfcba2f5 = _0x4a5eba5b.Length - 1; _0xdfcba2f5 > 0; _0xdfcba2f5--)
        {
            int _0x6e2a2bfa = _0x272f7640.Next(_0xdfcba2f5 + 1);
            int _0x547fe7de = _0x4a5eba5b[_0xdfcba2f5];
            _0x4a5eba5b[_0xdfcba2f5] = _0x4a5eba5b[_0x6e2a2bfa];
            _0x4a5eba5b[_0x6e2a2bfa] = _0x547fe7de;
        }

        return _0x4a5eba5b;
    }

    /// <summary>ASCII name of a symbol - used on the paytable and in popup copy.</summary>
    public static string NameOf(int _0x23ff7f24)
    {
        if (_0x23ff7f24 == Spade)
            return _0x89cd9c89._0x178299bb(new byte[5] { 86, 85, 68, 65, 64 }, 5);
        if (_0x23ff7f24 == Club)
            return _0x89cd9c89._0x178299bb(new byte[4] { 92, 83, 74, 93 }, 31);
        if (_0x23ff7f24 == Heart)
            return _0x89cd9c89._0x178299bb(new byte[5] { 211, 222, 218, 201, 207 }, 155);
        if (_0x23ff7f24 == Diamond)
            return _0x89cd9c89._0x178299bb(new byte[7] { 33, 44, 36, 40, 42, 43, 33 }, 101);
        if (_0x23ff7f24 == Bell)
            return _0x89cd9c89._0x178299bb(new byte[4] { 50, 53, 60, 60 }, 112);
        if (_0x23ff7f24 == Mask)
            return _0x89cd9c89._0x178299bb(new byte[4] { 40, 36, 54, 46 }, 101);
        if (_0x23ff7f24 == Crown)
            return _0x89cd9c89._0x178299bb(new byte[5] { 25, 8, 21, 13, 20 }, 90);
        if (_0x23ff7f24 == Jester)
            return _0x89cd9c89._0x178299bb(new byte[9] { 130, 139, 152, 134, 143, 155, 159, 131, 132 }, 202);
        return _0x89cd9c89._0x178299bb(new byte[6] { 167, 186, 176, 184, 182, 167 }, 243);
    }

    private static readonly int[] _0xa2629ae5 =
    {
        0,
        1,
        2,
        1,
        0
    };
}

internal static class _0x89cd9c89
{
    internal static string _0x178299bb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}