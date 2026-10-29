// What one round produced: the nine faces that stopped, which lines paid and the total.
//
// One instance lives for the whole session and is refilled every round, so a round
// costs no allocation at all. Built with field initialisers and Init rather than a
// constructor (C.59).
public sealed class _0xad51c8f1
{
    private int[] _0xe7ad25b3 = new int[_0x4dc369d4.LineCount];
    private int[] _0x098df5f6 = new int[_0xbbd798a9.Reels * _0xbbd798a9.Rows];
    public int _0xc041f7a6 => this._0x1e51fb7a;

    public int _0x6f3e132f(int _0xa4dfd4a7) => this._0x5e54133f[_0xa4dfd4a7];
    private int _0x40c7c18d;
    private int _0x136c2452;
    public _0xad51c8f1 _0x4175be81()
    {
        this._0x136c2452 = 0;
        this._0x40c7c18d = 0;
        this._0x8c8f780f = 0;
        this._0x1e51fb7a = -1;
        return this;
    }

    private int _0x58e67c46;
    private int[] _0xb27ebce0 = new int[_0x4dc369d4.LineCount];
    private int _0x8c8f780f;
    public int[] _0x87d5afad => this._0x098df5f6;
    public int[] _0x2d9ff0d6 => this._0x9867a7bf;

    public void _0xe08cd262(int _0xaf0f4080)
    {
        this._0x58e67c46 = _0xaf0f4080;
        this._0x136c2452 = 0;
        this._0x40c7c18d = 0;
        this._0x8c8f780f = 0;
        this._0x1e51fb7a = -1;
    }

    public int _0xc340a95c(int _0xbbad654e) => this._0xb27ebce0[_0xbbad654e];
    public void _0xeb15bd06(int _0x545e691e, int _0x016cb142)
    {
        this._0x9867a7bf[_0x545e691e] = _0x016cb142;
    }

    private int[] _0x5e54133f = new int[_0x4dc369d4.LineCount];
    public int _0x4507b1bc => this._0x58e67c46;
    public bool _0xc3ad9eea => this._0x40c7c18d > 0;
    public int _0xc6caec45 => this._0x136c2452;

    public void _0xbe2ceb4d(int _0x86a5634a, int _0x08c7572d, int _0x792eabb5, int payout)
    {
        if (this._0x136c2452 >= this._0x812ce7e9.Length)
        {
            return;
        }

        this._0x812ce7e9[this._0x136c2452] = _0x86a5634a;
        this._0xb27ebce0[this._0x136c2452] = _0x08c7572d;
        this._0x5e54133f[this._0x136c2452] = _0x792eabb5;
        this._0xe7ad25b3[this._0x136c2452] = payout;
        this._0x136c2452++;
        this._0x40c7c18d += payout;
        if (_0x792eabb5 > this._0x8c8f780f)
        {
            this._0x8c8f780f = _0x792eabb5;
            this._0x1e51fb7a = _0x08c7572d;
        }
    }

    public int _0x10966145 => this._0x40c7c18d;

    private int[] _0x9867a7bf = new int[_0xbbd798a9.Reels];
    private int _0x1e51fb7a = -1;
    public int _0x63222116(int _0xc57949d0) => this._0xe7ad25b3[_0xc57949d0];
    public int _0x5889a5da(int _0xc744175e) => this._0x812ce7e9[_0xc744175e];
    private int[] _0x812ce7e9 = new int[_0x4dc369d4.LineCount];
    public void _0x64be8335(int _0x01a1a240, int _0x7b3b1f25, int _0x384ce455)
    {
        this._0x098df5f6[_0x4dc369d4.Cell(_0x01a1a240, _0x7b3b1f25)] = _0x384ce455;
    }

    public int _0x81b31132 => this._0x8c8f780f;

    // True when a cell takes part in any paying line, so the board can light exactly
    // the faces the player was paid for.
    public bool _0x54d11a60(int _0x5f96da5e, int _0x5efe31e6)
    {
        for (int _0x5d8f5e3f = 0; _0x5d8f5e3f < this._0x136c2452; _0x5d8f5e3f++)
        {
            int[] _0x4acb3a77 = _0x4dc369d4._0x509a1731[this._0x812ce7e9[_0x5d8f5e3f]];
            if (_0x4acb3a77[_0x5f96da5e] == _0x5efe31e6)
            {
                return true;
            }
        }

        return false;
    }
}