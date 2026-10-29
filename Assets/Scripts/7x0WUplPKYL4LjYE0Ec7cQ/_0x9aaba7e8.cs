// One table in the hall: its seat price, the mix of faces on its strips and what each
// face pays for a line of three.
//
// No constructor anywhere (C.59): the object is built with field initialisers and an
// Init that returns itself, so nothing runs before the serializer and the scene are
// ready.
public sealed class _0x9aaba7e8
{
    public _0x9aaba7e8 _0x390a9cbe(string _0xc2ac7302, string _0xedc33005, int _0x1e4b2338, int[] _0x83ceb756, int[] _0x97927baf)
    {
        this._0x57045770 = _0xc2ac7302;
        this._0xf34f5b78 = _0xedc33005;
        this._0x12cb3f88 = _0x1e4b2338;
        this._0xb249ef2b = _0x83ceb756;
        this._0x12954b79 = _0x97927baf;
        return this;
    }

    // The exact return of this table, enumerated rather than sampled: with independent
    // reels the chance of a given face landing on a given row is simply its share of
    // the strip, so the return per line is a closed form and the five lines add up.
    //
    //   all three masks      -> the mask payout
    //   all three X-or-mask  -> the X payout, minus the all-mask case counted above
    //
    // Expressed as a fraction of the seat price, so 0.92 means the table hands back 92
    // of every 100 credits staked over a long run.
    public double _0x35597a8c()
    {
        int _0x25352952 = 0;
        for (int _0x8bed0c10 = 0; _0x8bed0c10 < this._0xb249ef2b.Length; _0x8bed0c10++)
        {
            _0x25352952 += this._0xb249ef2b[_0x8bed0c10];
        }

        if (_0x25352952 <= 0)
        {
            return 0d;
        }

        double _0x3f46188f = (double)this._0xb249ef2b[_0xbbd798a9.WildSymbol] / _0x25352952;
        double _0xef2783a8 = _0x3f46188f * _0x3f46188f * _0x3f46188f;
        double _0x4a5fd9da = _0xef2783a8 * this._0x12954b79[_0xbbd798a9.WildSymbol];
        for (int _0xb0357580 = 0; _0xb0357580 < this._0xb249ef2b.Length; _0xb0357580++)
        {
            if (_0xb0357580 == _0xbbd798a9.WildSymbol)
            {
                continue;
            }

            double _0xef02fc43 = (double)this._0xb249ef2b[_0xb0357580] / _0x25352952 + _0x3f46188f;
            _0x4a5fd9da += (_0xef02fc43 * _0xef02fc43 * _0xef02fc43 - _0xef2783a8) * this._0x12954b79[_0xb0357580];
        }

        return _0x4a5fd9da * _0x4dc369d4.LineCount;
    }

    // The chance that one payline pays anything, used to describe a table honestly in
    // the hall ("fewer small wins" has to be measurable, not a slogan).
    public double _0x7e1c084d()
    {
        int _0xad401cc3 = 0;
        for (int _0xa44adc11 = 0; _0xa44adc11 < this._0xb249ef2b.Length; _0xa44adc11++)
        {
            _0xad401cc3 += this._0xb249ef2b[_0xa44adc11];
        }

        if (_0xad401cc3 <= 0)
        {
            return 0d;
        }

        double _0x1b32e222 = (double)this._0xb249ef2b[_0xbbd798a9.WildSymbol] / _0xad401cc3;
        double _0xfb2a1c3e = _0x1b32e222 * _0x1b32e222 * _0x1b32e222;
        double _0x5d43b19b = _0xfb2a1c3e;
        for (int _0xc61524d4 = 0; _0xc61524d4 < this._0xb249ef2b.Length; _0xc61524d4++)
        {
            if (_0xc61524d4 == _0xbbd798a9.WildSymbol)
            {
                continue;
            }

            double _0x5a5ddbb1 = (double)this._0xb249ef2b[_0xc61524d4] / _0xad401cc3 + _0x1b32e222;
            _0x5d43b19b += _0x5a5ddbb1 * _0x5a5ddbb1 * _0x5a5ddbb1 - _0xfb2a1c3e;
        }

        return _0x5d43b19b;
    }

    public string _0x7f1ca861 => this._0xf34f5b78;
    public int _0xc24dddd0 => this._0x12cb3f88;

    private int[] _0x12954b79 = new int[_0xbbd798a9.Symbols];
    private int[] _0xb249ef2b = new int[_0xbbd798a9.Symbols];
    public int[] _0xa9537078 => this._0x12954b79;

    // What the house puts back when the meter empties at THIS seat. A flat figure would
    // be a handful of rounds at the dearest table and a long evening at the cheapest;
    // this keeps the promise the same everywhere.
    public int _0x81e6d18e
    {
        get
        {
            int _0x89d8d941 = this._0x12cb3f88 * _0xbbd798a9.RefillRounds;
            return _0x89d8d941 > _0xbbd798a9.RefillCredits ? _0x89d8d941 : _0xbbd798a9.RefillCredits;
        }
    }

    private string _0x57045770 = "";
    private int _0x12cb3f88 = _0xbbd798a9.BaseStake;
    public int[] _0x30383bc4 => this._0xb249ef2b;
    public string _0x374268d8 => this._0x57045770;

    private string _0xf34f5b78 = "";
}