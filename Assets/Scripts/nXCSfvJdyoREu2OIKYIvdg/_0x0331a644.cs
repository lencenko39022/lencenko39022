using UnityEngine;

/// <summary>
/// All persistent state of the club: virtual credits, bet, level, collection,
/// daily gift streak and lifetime records. PlayerPrefs only - no server, no account.
/// Keys are literal strings that never reach the UI, so renaming cannot break them.
/// </summary>
public static class _0x0331a644
{
    public static bool _0x5255fac2
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[17] { 2, 27, 18, 95, 3, 20, 21, 4, 18, 20, 21, 28, 30, 5, 24, 30, 31 }, 113), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[17] { 185, 160, 169, 228, 184, 175, 174, 191, 169, 175, 174, 167, 165, 190, 163, 165, 164 }, 202), value ? 1 : 0);
        }
    }

    public static int MissionProgress(int _0xcc253717)
    {
        return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[13] { 63, 38, 47, 98, 33, 37, 63, 63, 37, 35, 34, 98, 60 }, 76) + _0xcc253717, 0);
    }

    public static int _0xd7110322
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[8] { 12, 21, 28, 81, 27, 30, 6, 12 }, 127), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[8] { 221, 196, 205, 128, 202, 207, 215, 221 }, 174), value);
        }
    }

    private static readonly int[] _0x68650145 =
    {
        10,
        25,
        50,
        100,
        250
    };
    public static int _0x509a1731
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[15] { 39, 62, 55, 122, 57, 61, 39, 39, 61, 59, 58, 122, 48, 53, 45 }, 84), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[15] { 232, 241, 248, 181, 246, 242, 232, 232, 242, 244, 245, 181, 255, 250, 226 }, 155), value);
        }
    }

    public static bool MissionClaimed(int _0x535065dd)
    {
        return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[13] { 145, 136, 129, 204, 143, 139, 145, 145, 139, 141, 140, 204, 129 }, 226) + _0x535065dd, 0) == 1;
    }

    public const int MissionCount = 4;
    public static int _0xac075e85
    {
        get
        {
            return Mathf.Max(1, PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[9] { 39, 62, 55, 122, 56, 49, 34, 49, 56 }, 84), 1));
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[9] { 6, 31, 22, 91, 25, 16, 3, 16, 25 }, 117), Mathf.Max(1, value));
        }
    }

    public static int _0xb6850feb
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[11] { 196, 221, 212, 153, 213, 210, 196, 195, 192, 222, 217 }, 183), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[11] { 112, 105, 96, 45, 97, 102, 112, 119, 116, 106, 109 }, 3), value);
        }
    }

    public static int _0x54d74316
    {
        get
        {
            if (!PlayerPrefs.HasKey(_0x78442c9c._0xc260c859(new byte[7] { 111, 118, 127, 50, 126, 121, 104 }, 28)))
                PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[7] { 150, 143, 134, 203, 135, 128, 145 }, 229), DefaultBet);
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[7] { 42, 51, 58, 119, 59, 60, 45 }, 89));
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[7] { 135, 158, 151, 218, 150, 145, 128 }, 244), value);
        }
    }

    public const int StartCredits = 5000;
    /// <summary>Wagering grants 1 XP per 10 credits; returns true when a level was gained.</summary>
    public static bool AddWager(int _0x94f8fcdb)
    {
        bool _0xf1152469 = false;
        _0x73072a1c = _0x73072a1c + Mathf.Max(0, _0x94f8fcdb / 10);
        while (_0x73072a1c >= XpForLevel(_0xac075e85))
        {
            _0x73072a1c = _0x73072a1c - XpForLevel(_0xac075e85);
            _0xac075e85 = _0xac075e85 + 1;
            _0xf1152469 = true;
        }

        return _0xf1152469;
    }

    public static string _0xe07e3fcb
    {
        get
        {
            string _0x49507ed2 = PlayerPrefs.GetString(_0x78442c9c._0xc260c859(new byte[9] { 143, 150, 159, 210, 157, 144, 149, 157, 143 }, 252), string.Empty);
            if (!string.IsNullOrEmpty(_0x49507ed2))
                return _0x49507ed2;
            int _0x02aacaaf = (int)(System.DateTime.UtcNow.Ticks % 9000L) + 1000;
            string _0x874c1905 = _0x78442c9c._0xc260c859(new byte[6] { 85, 71, 87, 65, 70, 63 }, 18) + _0x02aacaaf;
            PlayerPrefs.SetString(_0x78442c9c._0xc260c859(new byte[9] { 128, 153, 144, 221, 146, 159, 154, 146, 128 }, 243), _0x874c1905);
            return _0x874c1905;
        }

        set
        {
            PlayerPrefs.SetString(_0x78442c9c._0xc260c859(new byte[9] { 236, 245, 252, 177, 254, 243, 246, 254, 236 }, 159), value);
        }
    }

    public static void AddCredits(int _0x2a17451f)
    {
        _0x1ac99480 = _0x1ac99480 + _0x2a17451f;
        if (_0x2a17451f > 0)
            _0x7c678146 = _0x7c678146 + _0x2a17451f;
    }

    public static int _0xa0cd89da
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[9] { 231, 254, 247, 186, 231, 228, 253, 250, 231 }, 148), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[9] { 56, 33, 40, 101, 56, 59, 34, 37, 56 }, 75), value);
        }
    }

    public static bool _0x50f91b80
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[11] { 173, 180, 189, 240, 191, 185, 187, 240, 191, 189, 181 }, 222), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[11] { 173, 180, 189, 240, 191, 185, 187, 240, 191, 189, 181 }, 222), value ? 1 : 0);
        }
    }

    public static int _0x1ac99480
    {
        get
        {
            if (!PlayerPrefs.HasKey(_0x78442c9c._0xc260c859(new byte[11] { 54, 47, 38, 107, 38, 55, 32, 33, 44, 49, 54 }, 69)))
                PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[11] { 106, 115, 122, 55, 122, 107, 124, 125, 112, 109, 106 }, 25), StartCredits);
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[11] { 195, 218, 211, 158, 211, 194, 213, 212, 217, 196, 195 }, 176));
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[11] { 109, 116, 125, 48, 125, 108, 123, 122, 119, 106, 109 }, 30), Mathf.Max(0, value));
        }
    }

    public static bool _0x194d89c6
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[13] { 159, 134, 143, 194, 128, 141, 158, 139, 137, 152, 137, 148, 152 }, 236), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[13] { 166, 191, 182, 251, 185, 180, 167, 178, 176, 161, 176, 173, 161 }, 213), value ? 1 : 0);
        }
    }

    public static void SetMissionClaimed(int _0x09d7d9ad, bool _0x06440f90)
    {
        PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[13] { 88, 65, 72, 5, 70, 66, 88, 88, 66, 68, 69, 5, 72 }, 43) + _0x09d7d9ad, _0x06440f90 ? 1 : 0);
    }

    public static void ResetEverything()
    {
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[11] { 215, 206, 199, 138, 199, 214, 193, 192, 205, 208, 215 }, 164));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[7] { 242, 235, 226, 175, 227, 228, 245 }, 129));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[6] { 61, 36, 45, 96, 54, 62 }, 78));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[9] { 161, 184, 177, 252, 190, 183, 164, 183, 190 }, 210));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[9] { 45, 52, 61, 112, 45, 42, 63, 57, 59 }, 94));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[10] { 220, 197, 204, 129, 206, 217, 206, 219, 206, 221 }, 175));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[9] { 173, 180, 189, 240, 173, 174, 183, 176, 173 }, 222));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[11] { 35, 58, 51, 126, 50, 53, 35, 36, 39, 57, 62 }, 80));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[10] { 247, 238, 231, 170, 247, 240, 246, 225, 229, 239 }, 132));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[10] { 61, 36, 45, 96, 43, 47, 60, 32, 43, 42 }, 78));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[15] { 181, 172, 165, 232, 161, 175, 160, 178, 232, 181, 178, 180, 163, 167, 173 }, 198));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[12] { 33, 56, 49, 124, 53, 59, 52, 38, 124, 54, 51, 43 }, 82));
        PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[15] { 103, 126, 119, 58, 121, 125, 103, 103, 125, 123, 122, 58, 112, 117, 109 }, 20));
        for (int _0x810092d4 = 0; _0x810092d4 < MissionCount; _0x810092d4++)
        {
            PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[13] { 1, 24, 17, 92, 31, 27, 1, 1, 27, 29, 28, 92, 2 }, 114) + _0x810092d4);
            PlayerPrefs.DeleteKey(_0x78442c9c._0xc260c859(new byte[13] { 157, 132, 141, 192, 131, 135, 157, 157, 135, 129, 128, 192, 141 }, 238) + _0x810092d4);
        }

        PlayerPrefs.Save();
    }

    public static int _0x7c678146
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[10] { 122, 99, 106, 39, 108, 104, 123, 103, 108, 109 }, 9), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[10] { 51, 42, 35, 110, 37, 33, 50, 46, 37, 36 }, 64), value);
        }
    }

    public static int _0xeec1adba
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[10] { 66, 91, 82, 31, 80, 71, 80, 69, 80, 67 }, 49), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[10] { 162, 187, 178, 255, 176, 167, 176, 165, 176, 163 }, 209), Mathf.Max(0, value));
        }
    }

    public static int XpForLevel(int _0x5d524685)
    {
        return 200 + 120 * _0x5d524685;
    }

    public static bool TrinketUnlocked(int _0x7c76fa47)
    {
        if (_0x7c76fa47 == 7)
            return _0xd543b1bb >= 7;
        int[] _0xf9fa0429 =
        {
            1,
            3,
            6,
            10,
            15,
            20,
            30
        };
        if (_0x7c76fa47 < 0 || _0x7c76fa47 >= _0xf9fa0429.Length)
            return false;
        return _0xac075e85 >= _0xf9fa0429[_0x7c76fa47];
    }

    public static int TrinketRequirement(int _0xfb5d4ea2)
    {
        int[] _0x94eedee7 =
        {
            1,
            3,
            6,
            10,
            15,
            20,
            30
        };
        if (_0xfb5d4ea2 < 0 || _0xfb5d4ea2 >= _0x94eedee7.Length)
            return 0;
        return _0x94eedee7[_0xfb5d4ea2];
    }

    public static int _0xb9e14fc1
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[9] { 29, 4, 13, 64, 29, 26, 15, 9, 11 }, 110), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[9] { 108, 117, 124, 49, 108, 107, 126, 120, 122 }, 31), Mathf.Max(0, value));
        }
    }

    public static int _0xd543b1bb
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[15] { 158, 135, 142, 195, 138, 132, 139, 153, 195, 158, 153, 159, 136, 140, 134 }, 237), 0), 0, 7);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[15] { 97, 120, 113, 60, 117, 123, 116, 102, 60, 97, 102, 96, 119, 115, 121 }, 18), Mathf.Clamp(value, 0, 7));
        }
    }

    public static int TrinketsOwned()
    {
        int _0xe29275a9 = 0;
        for (int _0xa23f7e45 = 0; _0xa23f7e45 < TrinketCount; _0xa23f7e45++)
            if (TrinketUnlocked(_0xa23f7e45))
                _0xe29275a9++;
        return _0xe29275a9;
    }

    public static bool _0x2997eb52
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[13] { 20, 13, 4, 73, 17, 14, 5, 21, 6, 19, 14, 8, 9 }, 103), 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[13] { 85, 76, 69, 8, 80, 79, 68, 84, 71, 82, 79, 73, 72 }, 38), value ? 1 : 0);
        }
    }

    public const int DefaultBet = 50;
    public static int _0x23512045
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[10] { 152, 129, 136, 197, 152, 159, 153, 142, 138, 128 }, 235), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[10] { 31, 6, 15, 66, 31, 24, 30, 9, 13, 7 }, 108), value);
        }
    }

    public static int[] Bets()
    {
        int[] _0xc835721b = new int[_0x68650145.Length];
        for (int _0xe13f0bc4 = 0; _0xe13f0bc4 < _0x68650145.Length; _0xe13f0bc4++)
            _0xc835721b[_0xe13f0bc4] = _0x68650145[_0xe13f0bc4];
        return _0xc835721b;
    }

    public const int TrinketCount = 8;
    /// <summary>Day number (local) on which the gift was last claimed; 0 = never.</summary>
    public static int _0x626dd4e4
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[12] { 72, 81, 88, 21, 92, 82, 93, 79, 21, 95, 90, 66 }, 59), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[12] { 229, 252, 245, 184, 241, 255, 240, 226, 184, 242, 247, 239 }, 150), value);
        }
    }

    public static int _0x73072a1c
    {
        get
        {
            return PlayerPrefs.GetInt(_0x78442c9c._0xc260c859(new byte[6] { 208, 201, 192, 141, 219, 211 }, 163), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[6] { 13, 20, 29, 80, 6, 14 }, 126), Mathf.Max(0, value));
        }
    }

    public static void SetMissionProgress(int _0xbccbb664, int _0x49d9f459)
    {
        PlayerPrefs.SetInt(_0x78442c9c._0xc260c859(new byte[13] { 134, 159, 150, 219, 152, 156, 134, 134, 156, 154, 155, 219, 133 }, 245) + _0xbccbb664, Mathf.Max(0, _0x49d9f459));
    }

    public const int TopUpAmount = 500;
    public static int Today()
    {
        System.DateTime _0x46058abf = System.DateTime.Now;
        return _0x46058abf.Year * 1000 + _0x46058abf.DayOfYear;
    }

    /// <summary>12,450 - grouped, no currency symbol, ASCII only.</summary>
    public static string Money(int _0xbd64702b)
    {
        return _0xbd64702b.ToString(_0x78442c9c._0xc260c859(new byte[2] { 48, 78 }, 126), System.Globalization.CultureInfo.InvariantCulture);
    }

    public static string _0x98e65b37
    {
        get
        {
            string _0x9923ab3f = PlayerPrefs.GetString(_0x78442c9c._0xc260c859(new byte[9] { 57, 32, 41, 100, 57, 35, 36, 41, 47 }, 74), string.Empty);
            if (!string.IsNullOrEmpty(_0x9923ab3f))
                return _0x9923ab3f;
            string _0x4d57a71e = System.DateTime.Now.ToString(_0x78442c9c._0xc260c859(new byte[6] { 112, 112, 52, 89, 89, 89 }, 20)).ToUpperInvariant();
            PlayerPrefs.SetString(_0x78442c9c._0xc260c859(new byte[9] { 243, 234, 227, 174, 243, 233, 238, 227, 229 }, 128), _0x4d57a71e);
            return _0x4d57a71e;
        }
    }
}

internal static class _0x78442c9c
{
    internal static string _0xc260c859(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}