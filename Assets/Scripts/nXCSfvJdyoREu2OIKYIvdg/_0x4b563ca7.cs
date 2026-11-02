using UnityEngine;

/// <summary>
/// Static content of the club: the four stages, the eight collection trinkets and the
/// four daily missions. Plain parallel arrays - no instances to build, so nothing here
/// depends on static initialiser order.
/// </summary>
public static class _0x4b563ca7
{
    public static string TrinketNote(int _0xd46af126)
    {
        return _0x27c9bffa[Mathf.Clamp(_0xd46af126, 0, _0x0331a644.TrinketCount - 1)];
    }

    private static readonly int[] _0x74d49d96 =
    {
        1,
        5,
        12,
        25
    };
    private static readonly string[] _0x27c9bffa =
    {
        _0xc61f6c50._0xa3e024ff(new byte[38] { 69, 92, 91, 91, 80, 81, 53, 65, 90, 53, 65, 93, 80, 53, 66, 84, 89, 89, 31, 90, 91, 53, 76, 90, 64, 71, 53, 83, 92, 71, 70, 65, 53, 91, 92, 82, 93, 65 }, 21),
        _0xc61f6c50._0xa3e024ff(new byte[29] { 166, 175, 172, 190, 202, 168, 175, 162, 163, 164, 174, 202, 163, 164, 202, 190, 162, 175, 224, 173, 163, 166, 174, 175, 174, 202, 168, 165, 178 }, 234),
        _0xc61f6c50._0xa3e024ff(new byte[33] { 68, 37, 86, 85, 73, 76, 75, 81, 64, 87, 37, 74, 67, 37, 81, 77, 64, 15, 74, 73, 65, 37, 86, 81, 68, 66, 64, 37, 71, 74, 68, 87, 65 }, 5),
        _0xc61f6c50._0xa3e024ff(new byte[34] { 122, 98, 127, 99, 13, 111, 116, 13, 121, 101, 104, 13, 101, 98, 120, 126, 104, 39, 98, 99, 13, 98, 125, 104, 99, 100, 99, 106, 13, 99, 100, 106, 101, 121 }, 45),
        _0xc61f6c50._0xa3e024ff(new byte[32] { 10, 11, 6, 11, 0, 29, 100, 22, 1, 9, 1, 9, 6, 1, 22, 23, 78, 19, 12, 5, 16, 100, 13, 16, 100, 17, 10, 8, 11, 7, 15, 23 }, 68),
        _0xc61f6c50._0xa3e024ff(new byte[30] { 117, 104, 28, 119, 121, 121, 108, 111, 28, 114, 115, 28, 104, 117, 113, 121, 54, 125, 114, 120, 28, 114, 121, 106, 121, 110, 28, 116, 125, 111 }, 60),
        _0xc61f6c50._0xa3e024ff(new byte[37] { 31, 22, 21, 29, 28, 29, 121, 27, 28, 13, 14, 28, 28, 23, 121, 13, 14, 22, 83, 24, 26, 13, 10, 121, 24, 23, 29, 121, 31, 22, 11, 30, 22, 13, 13, 28, 23 }, 89),
        _0xc61f6c50._0xa3e024ff(new byte[37] { 62, 34, 47, 74, 34, 37, 63, 57, 47, 74, 45, 35, 60, 47, 57, 74, 35, 62, 96, 43, 44, 62, 47, 56, 74, 57, 47, 60, 47, 36, 74, 36, 35, 45, 34, 62, 57 }, 106),
    };
    public static string HowToPlayLine(int _0x88e785bb)
    {
        if (_0x88e785bb == 1)
            return _0xc61f6c50._0xa3e024ff(new byte[59] { 21, 7, 10, 7, 115, 102, 119, 7, 116, 119, 110, 105, 9, 7, 115, 111, 98, 7, 117, 98, 98, 107, 116, 7, 116, 115, 104, 119, 45, 7, 7, 7, 7, 115, 111, 98, 106, 116, 98, 107, 113, 98, 116, 11, 7, 107, 98, 97, 115, 7, 115, 104, 7, 117, 110, 96, 111, 115, 9 }, 39);
        if (_0x88e785bb == 2)
            return _0xc61f6c50._0xa3e024ff(new byte[74] { 185, 170, 167, 170, 204, 195, 220, 207, 170, 198, 195, 196, 207, 217, 170, 218, 203, 211, 170, 198, 207, 204, 222, 170, 222, 197, 170, 216, 195, 205, 194, 222, 164, 128, 170, 170, 170, 170, 222, 194, 207, 170, 194, 203, 216, 198, 207, 219, 223, 195, 196, 170, 217, 222, 203, 196, 206, 217, 170, 195, 196, 170, 204, 197, 216, 170, 203, 196, 211, 170, 218, 195, 218, 164 }, 138);
        if (_0x88e785bb == 3)
            return _0xc61f6c50._0xa3e024ff(new byte[63] { 100, 112, 125, 112, 4, 24, 2, 21, 21, 112, 4, 25, 19, 27, 21, 4, 3, 112, 31, 2, 112, 29, 31, 2, 21, 112, 17, 7, 17, 2, 20, 90, 112, 112, 112, 112, 21, 25, 23, 24, 4, 112, 22, 2, 21, 21, 112, 3, 0, 25, 30, 3, 112, 17, 4, 112, 20, 31, 5, 18, 28, 21, 126 }, 80);
        return _0xc61f6c50._0xa3e024ff(new byte[59] { 60, 45, 32, 45, 78, 69, 66, 66, 94, 72, 45, 76, 45, 79, 72, 89, 45, 90, 68, 89, 69, 45, 32, 45, 76, 67, 73, 45, 38, 35, 7, 45, 45, 45, 45, 78, 95, 72, 73, 68, 89, 94, 45, 76, 95, 72, 45, 76, 65, 90, 76, 84, 94, 45, 75, 95, 72, 72, 35 }, 13);
    }

    private static readonly int[] _0xb7c0a090 =
    {
        250,
        250,
        250,
        250
    };
    public static int StageBetMin(int _0xb9794636)
    {
        return _0x18ef2216[Mathf.Clamp(_0xb9794636, 0, StageCount - 1)];
    }

    public static int MissionTarget(int _0x36830e7d)
    {
        return _0xad6aa7f1[Mathf.Clamp(_0x36830e7d, 0, _0x0331a644.MissionCount - 1)];
    }

    private static readonly string[] _0x0d4fd91e =
    {
        _0xc61f6c50._0xa3e024ff(new byte[14] { 236, 249, 243, 253, 152, 236, 253, 246, 152, 235, 232, 241, 246, 235 }, 184),
        _0xc61f6c50._0xa3e024ff(new byte[16] { 139, 134, 137, 131, 231, 147, 143, 149, 130, 130, 231, 144, 142, 139, 131, 148 }, 199),
        _0xc61f6c50._0xa3e024ff(new byte[19] { 15, 16, 5, 14, 96, 20, 15, 14, 9, 7, 8, 20, 103, 19, 96, 7, 9, 6, 20 }, 64),
        _0xc61f6c50._0xa3e024ff(new byte[22] { 231, 249, 254, 144, 228, 245, 254, 144, 228, 249, 253, 245, 227, 144, 233, 255, 229, 226, 144, 242, 245, 228 }, 176),
    };
    public const int MissionBigWin = 3;
    private static readonly int[] _0x4778c17d =
    {
        200,
        400,
        150,
        600
    };
    public const int MissionGift = 2;
    public static string TrinketName(int _0x32a747d2)
    {
        return _0x6bc19ebf[Mathf.Clamp(_0x32a747d2, 0, _0x0331a644.TrinketCount - 1)];
    }

    public static string MissionTitle(int _0xb07b4b4c)
    {
        return _0x0d4fd91e[Mathf.Clamp(_0xb07b4b4c, 0, _0x0331a644.MissionCount - 1)];
    }

    public const int RuleLineCount = 4;
    public static Color StageDrape(int _0xed432881)
    {
        if (_0xed432881 == 2)
            return _0xdc7245d7.ScarletDeep;
        if (_0xed432881 == 3)
            return _0xdc7245d7.BgPrimary;
        return _0xdc7245d7.Scarlet;
    }

    /// <summary>Backdrop tint of a stage - the same reels, a different room.</summary>
    public static Color StageTint(int _0xb3c2bbe7)
    {
        if (_0xb3c2bbe7 == 1)
            return _0xdc7245d7.Gold;
        if (_0xb3c2bbe7 == 2)
            return _0xdc7245d7.BgAccent;
        if (_0xb3c2bbe7 == 3)
            return _0xdc7245d7.GoldDark;
        return _0xdc7245d7.Scarlet;
    }

    public static int StageUnlock(int _0x3ba83a93)
    {
        return _0x74d49d96[Mathf.Clamp(_0x3ba83a93, 0, StageCount - 1)];
    }

    private static readonly string[] _0xf0bbe1fa =
    {
        _0xc61f6c50._0xa3e024ff(new byte[12] { 108, 127, 118, 108, 127, 110, 26, 105, 110, 123, 125, 127 }, 58),
        _0xc61f6c50._0xa3e024ff(new byte[10] { 124, 114, 119, 127, 126, 127, 27, 121, 116, 99 }, 59),
        _0xc61f6c50._0xa3e024ff(new byte[13] { 47, 43, 38, 44, 43, 37, 42, 54, 66, 53, 43, 44, 37 }, 98),
        _0xc61f6c50._0xa3e024ff(new byte[14] { 124, 123, 97, 103, 113, 20, 123, 114, 20, 119, 117, 102, 112, 103 }, 52),
    };
    public static string StageName(int _0x8e853f72)
    {
        return _0xf0bbe1fa[Mathf.Clamp(_0x8e853f72, 0, StageCount - 1)];
    }

    private static readonly int[] _0xad6aa7f1 =
    {
        10,
        3,
        1,
        1
    };
    public static bool StageUnlocked(int _0xc351ad81)
    {
        return _0x0331a644._0xac075e85 >= StageUnlock(_0xc351ad81);
    }

    /// <summary>Daily gift value: day seven of the streak pays the big one.</summary>
    public static int GiftValue(int _0xd3e0fe15)
    {
        return _0xd3e0fe15 >= 7 ? 5000 : 1000;
    }

    public const int MissionWilds = 1;
    public const int MissionSpins = 0;
    private static readonly string[] _0x6bc19ebf =
    {
        _0xc61f6c50._0xa3e024ff(new byte[12] { 0, 19, 26, 0, 19, 2, 118, 2, 25, 29, 19, 24 }, 86),
        _0xc61f6c50._0xa3e024ff(new byte[10] { 242, 252, 249, 225, 149, 246, 253, 244, 231, 248 }, 181),
        _0xc61f6c50._0xa3e024ff(new byte[11] { 184, 191, 170, 172, 174, 203, 185, 174, 167, 162, 168 }, 235),
        _0xc61f6c50._0xa3e024ff(new byte[12] { 120, 98, 103, 96, 11, 121, 100, 120, 110, 127, 127, 110 }, 43),
        _0xc61f6c50._0xa3e024ff(new byte[12] { 1, 17, 2, 16, 16, 99, 0, 10, 19, 11, 6, 17 }, 67),
        _0xc61f6c50._0xa3e024ff(new byte[12] { 200, 215, 219, 211, 221, 204, 184, 207, 217, 204, 219, 208 }, 152),
        _0xc61f6c50._0xa3e024ff(new byte[8] { 222, 215, 216, 210, 182, 208, 215, 216 }, 150),
        _0xc61f6c50._0xa3e024ff(new byte[11] { 136, 134, 137, 155, 239, 140, 142, 156, 132, 138, 155 }, 207),
    };
    public static int StageBetMax(int _0xd73c7b60)
    {
        return _0xb7c0a090[Mathf.Clamp(_0xd73c7b60, 0, StageCount - 1)];
    }

    public const int StageCount = 4;
    private static readonly int[] _0x18ef2216 =
    {
        10,
        25,
        50,
        100
    };
    /// <summary>Countdown to the next local midnight, as hh:mm:ss.</summary>
    public static string TimeToMidnight()
    {
        System.DateTime _0x61fb4a19 = System.DateTime.Now;
        System.TimeSpan _0x336a7e6f = _0x61fb4a19.Date.AddDays(1) - _0x61fb4a19;
        return _0x336a7e6f.Hours.ToString(_0xc61f6c50._0xa3e024ff(new byte[2] { 112, 112 }, 64)) + _0xc61f6c50._0xa3e024ff(new byte[1] { 15 }, 53) + _0x336a7e6f.Minutes.ToString(_0xc61f6c50._0xa3e024ff(new byte[2] { 86, 86 }, 102)) + _0xc61f6c50._0xa3e024ff(new byte[1] { 16 }, 42) + _0x336a7e6f.Seconds.ToString(_0xc61f6c50._0xa3e024ff(new byte[2] { 178, 178 }, 130));
    }

    public static string StageBlurb(int _0xeedd4e9c)
    {
        return _0x61a87ed0[Mathf.Clamp(_0xeedd4e9c, 0, StageCount - 1)];
    }

    private static readonly string[] _0x61a87ed0 =
    {
        _0xc61f6c50._0xa3e024ff(new byte[27] { 164, 184, 181, 208, 184, 191, 165, 163, 181, 208, 191, 160, 181, 190, 163, 208, 181, 166, 181, 162, 169, 208, 190, 185, 183, 184, 164 }, 240),
        _0xc61f6c50._0xa3e024ff(new byte[29] { 27, 21, 16, 8, 124, 11, 29, 16, 16, 15, 124, 29, 18, 24, 124, 29, 124, 11, 29, 14, 17, 25, 14, 124, 31, 14, 19, 11, 24 }, 92),
        _0xc61f6c50._0xa3e024ff(new byte[31] { 69, 89, 84, 49, 93, 80, 69, 84, 49, 66, 89, 94, 70, 61, 49, 93, 80, 92, 65, 66, 49, 69, 68, 67, 95, 84, 85, 49, 93, 94, 70 }, 17),
        _0xc61f6c50._0xa3e024ff(new byte[27] { 152, 132, 137, 236, 142, 141, 143, 135, 236, 158, 131, 131, 129, 224, 236, 138, 131, 158, 236, 158, 137, 139, 153, 128, 141, 158, 159 }, 204),
    };
    /// <summary>Compliance copy - these four lines must stay in this meaning.</summary>
    public static string ComplianceLine(int _0x582ca762)
    {
        if (_0x582ca762 == 1)
            return _0xc61f6c50._0xa3e024ff(new byte[73] { 202, 219, 204, 205, 192, 221, 218, 169, 200, 219, 204, 169, 223, 192, 219, 221, 220, 200, 197, 167, 169, 221, 193, 204, 208, 169, 202, 200, 199, 199, 198, 221, 169, 203, 204, 131, 203, 198, 220, 206, 193, 221, 165, 169, 218, 198, 197, 205, 165, 169, 222, 192, 221, 193, 205, 219, 200, 222, 199, 169, 198, 219, 169, 204, 209, 202, 193, 200, 199, 206, 204, 205, 167 }, 137);
        if (_0x582ca762 == 2)
            return _0xc61f6c50._0xa3e024ff(new byte[39] { 113, 112, 31, 109, 122, 126, 115, 18, 114, 112, 113, 122, 102, 31, 120, 126, 114, 125, 115, 118, 113, 120, 17, 53, 113, 112, 31, 124, 126, 108, 119, 31, 111, 109, 118, 101, 122, 108, 17 }, 63);
        if (_0x582ca762 == 3)
            return _0xc61f6c50._0xa3e024ff(new byte[51] { 160, 162, 177, 179, 164, 185, 179, 181, 208, 160, 188, 177, 169, 208, 180, 191, 181, 163, 208, 190, 191, 164, 208, 160, 162, 181, 180, 185, 179, 164, 250, 162, 181, 177, 188, 221, 189, 191, 190, 181, 169, 208, 191, 165, 164, 179, 191, 189, 181, 163, 222 }, 240);
        return _0xc61f6c50._0xa3e024ff(new byte[32] { 89, 80, 67, 72, 39, 38, 36, 49, 70, 98, 60, 32, 33, 59, 72, 33, 59, 72, 41, 72, 59, 39, 43, 33, 41, 36, 72, 47, 41, 37, 45, 70 }, 104);
    }

    public static int MissionReward(int _0x4d72db6d)
    {
        return _0x4778c17d[Mathf.Clamp(_0x4d72db6d, 0, _0x0331a644.MissionCount - 1)];
    }
}

internal static class _0xc61f6c50
{
    internal static string _0xa3e024ff(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}