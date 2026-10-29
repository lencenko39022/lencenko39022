// House ranks. Rank n is reached at ClubConfig.RankStep * n * n experience, so the
// early ones come quickly and the last one is a long acquaintance.
public static class _0x8e9129d3
{
    public static string NameFor(int _0xb2ba3276)
    {
        string[] _0x9ea0bea0 = _0xe07e3fcb;
        int _0xd670dff7 = _0xb2ba3276 - 1;
        if (_0xd670dff7 < 0)
        {
            _0xd670dff7 = 0;
        }

        if (_0xd670dff7 >= _0x9ea0bea0.Length)
        {
            _0xd670dff7 = _0x9ea0bea0.Length - 1;
        }

        return _0x9ea0bea0[_0xd670dff7];
    }

    public static int FloorThreshold(int _0xfa9b86a9)
    {
        return _0xfa9b86a9 <= 1 ? 0 : Threshold(_0xfa9b86a9 - 1);
    }

    // Ranks are one based: 1 is NEWCOMER, ClubConfig.RankCount is the last one.
    public static int RankFor(int _0x1b7b3a74)
    {
        int _0x1b0bf1c6 = 1;
        for (int _0x40c09057 = 1; _0x40c09057 < _0xbbd798a9.RankCount; _0x40c09057++)
        {
            if (_0x1b7b3a74 >= Threshold(_0x40c09057))
            {
                _0x1b0bf1c6 = _0x40c09057 + 1;
            }
        }

        return _0x1b0bf1c6 > _0xbbd798a9.RankCount ? _0xbbd798a9.RankCount : _0x1b0bf1c6;
    }

    public static string[] _0xe07e3fcb
    {
        get
        {
            if (_0x91dda601 == null)
            {
                _0x91dda601 = new string[]
                {
                    _0x8d4415fd._0x8ea0be69(new byte[8] { 147, 152, 138, 158, 146, 144, 152, 143 }, 221),
                    _0x8d4415fd._0x8ea0be69(new byte[5] { 68, 86, 70, 80, 87 }, 3),
                    _0x8d4415fd._0x8ea0be69(new byte[7] { 155, 140, 142, 156, 133, 136, 155 }, 201),
                    _0x8d4415fd._0x8ea0be69(new byte[6] { 125, 108, 121, 127, 98, 99 }, 45),
                    _0x8d4415fd._0x8ea0be69(new byte[10] { 19, 8, 2, 3, 20, 21, 18, 19, 2, 31 }, 70),
                    _0x8d4415fd._0x8ea0be69(new byte[6] { 31, 3, 14, 22, 10, 29 }, 79),
                    _0x8d4415fd._0x8ea0be69(new byte[9] { 104, 101, 97, 100, 108, 105, 110, 101, 114 }, 32),
                    _0x8d4415fd._0x8ea0be69(new byte[9] { 83, 95, 94, 86, 89, 84, 81, 94, 68 }, 16),
                    _0x8d4415fd._0x8ea0be69(new byte[7] { 200, 196, 214, 212, 208, 192, 215 }, 133),
                    _0x8d4415fd._0x8ea0be69(new byte[10] { 191, 164, 163, 170, 160, 172, 190, 185, 168, 191 }, 237),
                    _0x8d4415fd._0x8ea0be69(new byte[12] { 75, 76, 86, 80, 70, 35, 69, 81, 74, 70, 77, 71 }, 3),
                    _0x8d4415fd._0x8ea0be69(new byte[11] { 188, 185, 182, 181, 208, 189, 181, 189, 178, 181, 162 }, 240),
                };
            }

            return _0x91dda601;
        }
    }

    public static float Fraction(int _0xe4cc1651)
    {
        int _0xf6bc3f25 = RankFor(_0xe4cc1651);
        int _0xcd2a325a = FloorThreshold(_0xf6bc3f25);
        int _0xf9bbd821 = NextThreshold(_0xf6bc3f25);
        if (_0xf9bbd821 <= _0xcd2a325a)
        {
            return 1f;
        }

        float _0x68c4ee05 = (float)(_0xe4cc1651 - _0xcd2a325a) / (_0xf9bbd821 - _0xcd2a325a);
        return _0x68c4ee05 < 0f ? 0f : (_0x68c4ee05 > 1f ? 1f : _0x68c4ee05);
    }

    public static int NextThreshold(int _0x139da87a)
    {
        return _0x139da87a >= _0xbbd798a9.RankCount ? Threshold(_0xbbd798a9.RankCount) : Threshold(_0x139da87a);
    }

    public static int Threshold(int _0x0c1f1505)
    {
        int _0xf4034cd6 = _0x0c1f1505 < 1 ? 1 : _0x0c1f1505;
        return _0xbbd798a9.RankStep * _0xf4034cd6 * _0xf4034cd6;
    }

    private static string[] _0x91dda601;
}

internal static class _0x8d4415fd
{
    internal static string _0x8ea0be69(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}