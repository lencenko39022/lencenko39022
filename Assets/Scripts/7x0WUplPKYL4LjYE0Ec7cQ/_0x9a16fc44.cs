// The nightly gift: seven rungs of free credits, one a night, the streak returning to
// the first rung after a missed night. The day boundary is the device's own calendar
// day, stored as a plain ISO date string so it reads the same in a log as on screen.
//
// Nothing here can be bought and nothing here can be cashed out; the ladder is the only
// way credits arrive besides the table itself and the automatic top up.
public sealed class _0x9a16fc44
{
    // The rung the guest is standing on, zero based. After a missed night the ladder
    // starts again at the first rung.
    public int _0x8539c4d5()
    {
        string _0xf9dcff5c = this._0xf0e3a5f0._0x3e529e93;
        int _0x9b291c1b = this._0xf0e3a5f0._0x2c9bb801;
        if (_0xf9dcff5c.Length == 0)
        {
            return 0;
        }

        if (_0xf9dcff5c == Today())
        {
            return _0x9b291c1b - 1 < 0 ? 0 : (_0x9b291c1b - 1) % _0xbbd798a9.GiftDays;
        }

        if (_0xf9dcff5c == Yesterday())
        {
            return _0x9b291c1b % _0xbbd798a9.GiftDays;
        }

        return 0;
    }

    private static string Yesterday()
    {
        return System.DateTime.Now.Date.AddDays(-1d).ToString(_0xff027547._0xd4fcf342(new byte[10] { 196, 196, 196, 196, 144, 240, 240, 144, 217, 217 }, 189));
    }

    private static string Today()
    {
        return System.DateTime.Now.ToString(_0xff027547._0xd4fcf342(new byte[10] { 249, 249, 249, 249, 173, 205, 205, 173, 228, 228 }, 128));
    }

    public _0x9a16fc44 _0xcca6069c(_0xe54e0344 _0xc3109895)
    {
        this._0xf0e3a5f0 = _0xc3109895;
        return this;
    }

    public bool _0x5d45a0ca()
    {
        return this._0xf0e3a5f0._0x3e529e93 == Today();
    }

    // Hands over tonight's rung. Returns the credits paid, or zero if tonight's gift is
    // already in the purse.
    public int _0xba46b02e()
    {
        if (this._0x5d45a0ca())
        {
            return 0;
        }

        int _0x0419c377 = this._0x8539c4d5();
        int _0x2b05b38c = this._0xa6aa1935(_0x0419c377);
        bool _0x143a5a82 = this._0xf0e3a5f0._0x3e529e93 == Yesterday();
        this._0xf0e3a5f0._0x2c9bb801 = _0x143a5a82 ? this._0xf0e3a5f0._0x2c9bb801 + 1 : 1;
        this._0xf0e3a5f0._0x3e529e93 = Today();
        this._0xf0e3a5f0._0xb8844111 = this._0xf0e3a5f0._0xb8844111 + _0x2b05b38c;
        this._0xf0e3a5f0._0x6a89ca01 = this._0xf0e3a5f0._0x6a89ca01 + 1;
        this._0xf0e3a5f0._0x55475292();
        return _0x2b05b38c;
    }

    public bool _0x32697c26(int _0xd1803ee0)
    {
        int _0x03bf1a98 = this._0x8539c4d5();
        if (this._0x5d45a0ca())
        {
            return _0xd1803ee0 <= _0x03bf1a98;
        }

        return _0xd1803ee0 < _0x03bf1a98;
    }

    public int[] _0x194d89c6 => this._0x4ebdf566;

    private _0xe54e0344 _0xf0e3a5f0;
    private int[] _0x4ebdf566 = new int[]
    {
        500,
        650,
        800,
        1000,
        1250,
        1500,
        2500
    };
    public int _0x27772547()
    {
        int _0x95a85de6 = this._0xf0e3a5f0._0x2c9bb801;
        return _0x95a85de6 < 0 ? 0 : _0x95a85de6;
    }

    public int _0xa6aa1935(int _0xaa84ea92)
    {
        int _0xf5ba3700 = _0xaa84ea92 < 0 ? 0 : (_0xaa84ea92 >= this._0x4ebdf566.Length ? this._0x4ebdf566.Length - 1 : _0xaa84ea92);
        return this._0x4ebdf566[_0xf5ba3700];
    }
}

internal static class _0xff027547
{
    internal static string _0xd4fcf342(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}