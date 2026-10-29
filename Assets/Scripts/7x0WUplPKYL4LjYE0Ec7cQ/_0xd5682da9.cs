// The gallery: nine painted cards, each one earned at a cumulative number of rounds.
// Nothing here can be bought; the only way a slot fills is by playing.
public static class _0xd5682da9
{
    // Keeps the stored figure in step with the lifetime round count and reports how
    // many new slots that filled, so the gallery can be animated when one opens.
    public static int Refresh(_0xe54e0344 _0x9fb57f37)
    {
        int _0x7b72c725 = FoundFor(_0x9fb57f37._0xa6100c56);
        int _0xfce9071b = _0x9fb57f37._0xdcb87af9;
        if (_0x7b72c725 > _0xfce9071b)
        {
            _0x9fb57f37._0xdcb87af9 = _0x7b72c725;
            _0x9fb57f37._0x55475292();
            return _0x7b72c725 - _0xfce9071b;
        }

        return 0;
    }

    public static string[] _0xb9e14fc1
    {
        get
        {
            if (_0x10d7e45d == null)
            {
                _0x10d7e45d = new string[]
                {
                    _0x17410ec1._0x26d98a15(new byte[10] { 48, 44, 33, 68, 41, 37, 35, 52, 45, 33 }, 100),
                    _0x17410ec1._0x26d98a15(new byte[8] { 253, 225, 236, 137, 235, 236, 229, 229 }, 169),
                    _0x17410ec1._0x26d98a15(new byte[9] { 27, 7, 10, 111, 12, 29, 0, 24, 1 }, 79),
                    _0x17410ec1._0x26d98a15(new byte[7] { 240, 236, 225, 132, 229, 231, 225 }, 164),
                    _0x17410ec1._0x26d98a15(new byte[10] { 13, 17, 28, 121, 20, 16, 11, 11, 22, 11 }, 89),
                    _0x17410ec1._0x26d98a15(new byte[11] { 214, 202, 199, 162, 206, 195, 204, 214, 199, 208, 204 }, 130),
                    _0x17410ec1._0x26d98a15(new byte[10] { 200, 212, 217, 188, 206, 213, 222, 222, 211, 210 }, 156),
                    _0x17410ec1._0x26d98a15(new byte[8] { 129, 157, 144, 245, 150, 154, 156, 155 }, 213),
                    _0x17410ec1._0x26d98a15(new byte[10] { 63, 35, 46, 75, 38, 42, 56, 58, 62, 46 }, 107),
                };
            }

            return _0x10d7e45d;
        }
    }

    public static int[] _0xeec1adba
    {
        get
        {
            if (_0x1fe0a4b4 == null)
            {
                _0x1fe0a4b4 = new int[]
                {
                    25,
                    75,
                    150,
                    275,
                    450,
                    700,
                    1000,
                    1400,
                    2000
                };
            }

            return _0x1fe0a4b4;
        }
    }

    public static int FoundFor(int _0xed974a4c)
    {
        int _0x1ba4cfb8 = 0;
        int[] _0xaa73dc86 = _0xeec1adba;
        for (int _0xe996f416 = 0; _0xe996f416 < _0xaa73dc86.Length; _0xe996f416++)
        {
            if (_0xed974a4c >= _0xaa73dc86[_0xe996f416])
            {
                _0x1ba4cfb8 = _0xe996f416 + 1;
            }
        }

        return _0x1ba4cfb8;
    }

    private static int[] _0x1fe0a4b4;
    private static string[] _0x10d7e45d;
    public static string NameAt(int _0x3f2bad5a)
    {
        string[] _0x5cd6b212 = _0xb9e14fc1;
        int _0x9549d081 = _0x3f2bad5a < 0 ? 0 : (_0x3f2bad5a >= _0x5cd6b212.Length ? _0x5cd6b212.Length - 1 : _0x3f2bad5a);
        return _0x5cd6b212[_0x9549d081];
    }

    public static int MilestoneAt(int _0xb0bf96ce)
    {
        int[] _0x82ef4c15 = _0xeec1adba;
        int _0xa1bd9d06 = _0xb0bf96ce < 0 ? 0 : (_0xb0bf96ce >= _0x82ef4c15.Length ? _0x82ef4c15.Length - 1 : _0xb0bf96ce);
        return _0x82ef4c15[_0xa1bd9d06];
    }
}

internal static class _0x17410ec1
{
    internal static string _0x26d98a15(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}