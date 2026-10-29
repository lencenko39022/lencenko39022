// One line on the mission card: what to do, how far the guest has come and what the
// house pays for it. Built with Init rather than a constructor (C.59).
public sealed class _0xcffa2836
{
    private int _0x7e0b3afd;
    public int _0xd543b1bb => this._0x04dcb8e0;

    private int _0x05b49d81;
    public string _0x7c678146 => this._0xa2ba9c64;

    private int _0x04dcb8e0 = 1;
    public string _0xb22436e9(int _0xbde68545)
    {
        int _0xc473275c = _0xbde68545 > this._0x04dcb8e0 ? this._0x04dcb8e0 : _0xbde68545;
        return _0x1bad1984.Pad2(_0xc473275c) + _0x7751e3cc._0xd7f5a628(new byte[3] { 252, 243, 252 }, 220) + _0x1bad1984.Pad2(this._0x04dcb8e0);
    }

    public int _0x23512045 => this._0x05b49d81;

    public float _0xe985d815(int _0x6e97f9b9)
    {
        if (this._0x04dcb8e0 <= 0)
        {
            return 1f;
        }

        float _0x64cce223 = (float)_0x6e97f9b9 / this._0x04dcb8e0;
        return _0x64cce223 < 0f ? 0f : (_0x64cce223 > 1f ? 1f : _0x64cce223);
    }

    private string _0xfe2f863c = "";
    public string _0xd7110322 => this._0xfe2f863c;

    public _0xcffa2836 _0x2047abf7(int _0x6e3564b0, string _0xb735f640, string _0x8c606719, int _0x3403715b, int _0xc5e8e8b1)
    {
        this._0x05b49d81 = _0x6e3564b0;
        this._0xfe2f863c = _0xb735f640;
        this._0xa2ba9c64 = _0x8c606719;
        this._0x04dcb8e0 = _0x3403715b;
        this._0x7e0b3afd = _0xc5e8e8b1;
        return this;
    }

    public int _0x626dd4e4 => this._0x7e0b3afd;

    private string _0xa2ba9c64 = "";
}

internal static class _0x7751e3cc
{
    internal static string _0xd7f5a628(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}