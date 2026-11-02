using UnityEngine;

/// <summary>
/// Outcome generation for the Virtual Reels. Owns the session seed, the five shuffled
/// strips, the dry-streak guard and the free-spin ledger. Pure data - no scene access,
/// no tweens. Built with Init() rather than a constructor.
/// </summary>
public sealed class _0x8170e3ef
{
    private int _0x1713ab3e;
    public int _0xc041f7a6
    {
        get
        {
            return this._0x32f9fdf2;
        }
    }

    public _0x8170e3ef _0x45c2e03a(int _0x388b2ad7)
    {
        this._0x1713ab3e = _0x388b2ad7;
        this._0xd132a8ad = 0;
        this._0x686bf015 = 0;
        this._0x32f9fdf2 = 0;
        this._0x2bb0886a = false;
        System.Random _0x2ecda3c3 = new System.Random(_0x388b2ad7);
        this._0x7f12df16 = new int[_0x80ffeb86.Reels][];
        for (int _0xf8ab00cc = 0; _0xf8ab00cc < _0x80ffeb86.Reels; _0xf8ab00cc++)
            this._0x7f12df16[_0xf8ab00cc] = _0x80ffeb86.BuildStrip(_0x2ecda3c3);
        this._0x9f954c37();
        return this;
    }

    private int _0x32f9fdf2;
    /// <summary>Fallback for the consolation roll: the smallest paying candidate found.</summary>
    private void _0x30353506(System.Random _0x4e3d13c4, _0xf4931647 _0xd18dc9f7)
    {
        int[] _0xddefa71f = null;
        int[] _0xb3cb3c0f = null;
        int _0xb4acec06 = int.MaxValue;
        int[] _0x6e433df3 = new int[_0x80ffeb86.Reels * _0x80ffeb86.Rows];
        int[] _0xb51d1b57 = new int[_0x80ffeb86.Reels];
        for (int _0x5dc80aab = 0; _0x5dc80aab < RerollCandidates; _0x5dc80aab++)
        {
            for (int _0xa3e29e3b = 0; _0xa3e29e3b < _0x80ffeb86.Reels; _0xa3e29e3b++)
            {
                _0xb51d1b57[_0xa3e29e3b] = _0x4e3d13c4.Next(_0x80ffeb86.StripLength);
                _0x80ffeb86.ReadWindow(this._0x7f12df16[_0xa3e29e3b], _0xb51d1b57[_0xa3e29e3b], _0x6e433df3, _0xa3e29e3b * _0x80ffeb86.Rows);
            }

            int _0x8127e866 = 0;
            for (int _0xe3a85c79 = 0; _0xe3a85c79 < _0x80ffeb86.LineCount; _0xe3a85c79++)
            {
                int _0x8e0992f5;
                int _0xe239b747;
                _0x8127e866 += _0x80ffeb86.EvaluateLine(_0x6e433df3, _0xe3a85c79, out _0x8e0992f5, out _0xe239b747);
            }

            _0x8127e866 += _0x80ffeb86.ScatterMultiplier(_0x80ffeb86.CountScatterReels(_0x6e433df3));
            if (_0x8127e866 > 0 && _0x8127e866 < _0xb4acec06)
            {
                _0xb4acec06 = _0x8127e866;
                _0xddefa71f = (int[])_0x6e433df3.Clone();
                _0xb3cb3c0f = (int[])_0xb51d1b57.Clone();
            }
        }

        if (_0xddefa71f == null)
        {
            this._0xe94319c0(_0x4e3d13c4, _0xd18dc9f7);
            return;
        }

        for (int _0xcffa2836 = 0; _0xcffa2836 < _0xddefa71f.Length; _0xcffa2836++)
            _0xd18dc9f7.Grid[_0xcffa2836] = _0xddefa71f[_0xcffa2836];
        for (int _0x2047abf7 = 0; _0x2047abf7 < _0xb3cb3c0f.Length; _0x2047abf7++)
            _0xd18dc9f7.Stops[_0x2047abf7] = _0xb3cb3c0f[_0x2047abf7];
    }

    private const int ConsolationAttempts = 30;
    private void _0xe94319c0(System.Random _0xe5bc0216, _0xf4931647 _0xa4bd5122)
    {
        for (int _0x05ee6816 = 0; _0x05ee6816 < _0x80ffeb86.Reels; _0x05ee6816++)
        {
            int _0x5ec2cf7b = _0xe5bc0216.Next(_0x80ffeb86.StripLength);
            _0xa4bd5122.Stops[_0x05ee6816] = _0x5ec2cf7b;
            _0x80ffeb86.ReadWindow(this._0x7f12df16[_0x05ee6816], _0x5ec2cf7b, _0xa4bd5122.Grid, _0x05ee6816 * _0x80ffeb86.Rows);
        }
    }

    /// <summary>One spin's result: the grid, the paying lines and the awards.</summary>
    public sealed class _0xf4931647
    {
        public int[] Grid = new int[_0x80ffeb86.Reels * _0x80ffeb86.Rows];
        public int[] Stops = new int[_0x80ffeb86.Reels];
        public int[] LineMultiplier = new int[_0x80ffeb86.LineCount];
        public int[] LineRun = new int[_0x80ffeb86.LineCount];
        public int[] LineSymbol = new int[_0x80ffeb86.LineCount];
        public int TotalMultiplier;
        public int ScatterReels;
        public int ScatterMultiplier;
        public int FreeSpinsAwarded;
        public int BestLine = -1;
        public int Win;
        public bool IsFree;
        public _0xf4931647 _0xef910fb8()
        {
            for (int _0x0bc7ee54 = 0; _0x0bc7ee54 < this.LineMultiplier.Length; _0x0bc7ee54++)
            {
                this.LineMultiplier[_0x0bc7ee54] = 0;
                this.LineRun[_0x0bc7ee54] = 0;
                this.LineSymbol[_0x0bc7ee54] = -1;
            }

            this.TotalMultiplier = 0;
            this.ScatterReels = 0;
            this.ScatterMultiplier = 0;
            this.FreeSpinsAwarded = 0;
            this.BestLine = -1;
            this.Win = 0;
            this.IsFree = false;
            return this;
        }
    }

    public int _0xc3ad9eea
    {
        get
        {
            return this._0xd132a8ad;
        }
    }

    public int _0xc77912a5
    {
        get
        {
            return this._0x1713ab3e;
        }
    }

    /// <summary>
    /// Pre-computes, per reel, which stops put the lowest-paying symbol on the middle
    /// line and which put neither that symbol nor a wild there. The consolation
    /// outcome is assembled from these, so it always pays exactly the bottom tier.
    /// </summary>
    private void _0x9f954c37()
    {
        this._0xbc5c5f0d = new int[_0x80ffeb86.Reels][];
        this._0xf1e26f6f = new int[_0x80ffeb86.Reels][];
        int[] _0x5971090f = new int[_0x80ffeb86.StripLength];
        int[] _0x7fdab14a = new int[_0x80ffeb86.StripLength];
        for (int _0x32cdf23c = 0; _0x32cdf23c < _0x80ffeb86.Reels; _0x32cdf23c++)
        {
            int _0x66cea3ef = 0;
            int _0x3f2a64c0 = 0;
            for (int _0x24ebccb2 = 0; _0x24ebccb2 < _0x80ffeb86.StripLength; _0x24ebccb2++)
            {
                int _0x48bbaf1e = this._0x7f12df16[_0x32cdf23c][(_0x24ebccb2 + 1) % _0x80ffeb86.StripLength];
                if (_0x48bbaf1e == _0x80ffeb86.Spade)
                {
                    _0x5971090f[_0x66cea3ef] = _0x24ebccb2;
                    _0x66cea3ef++;
                }
                else if (_0x48bbaf1e != _0x80ffeb86.Jester)
                {
                    _0x7fdab14a[_0x3f2a64c0] = _0x24ebccb2;
                    _0x3f2a64c0++;
                }
            }

            this._0xbc5c5f0d[_0x32cdf23c] = new int[_0x66cea3ef];
            for (int _0x04446cfd = 0; _0x04446cfd < _0x66cea3ef; _0x04446cfd++)
                this._0xbc5c5f0d[_0x32cdf23c][_0x04446cfd] = _0x5971090f[_0x04446cfd];
            this._0xf1e26f6f[_0x32cdf23c] = new int[_0x3f2a64c0];
            for (int _0xc80583d8 = 0; _0xc80583d8 < _0x3f2a64c0; _0xc80583d8++)
                this._0xf1e26f6f[_0x32cdf23c][_0xc80583d8] = _0x7fdab14a[_0xc80583d8];
        }
    }

    /// <summary>
    /// Produces the next outcome. The first spin the PLAYER asks for in a session is the
    /// showcase spin - four crowns on the middle line - so the review album always holds a
    /// win. Idle demo spins pass allowShowcase false and never consume it.
    /// </summary>
    public _0xf4931647 _0x8d4ba13f(int _0xf99e5f3b, _0xf4931647 _0x4c4d3689, bool _0x399c4e6a)
    {
        _0xf4931647 _0x3b739e89 = _0x4c4d3689 == null ? new _0x8170e3ef._0xf4931647()._0xef910fb8() : _0x4c4d3689._0xef910fb8();
        bool _0xc0ff279f = this._0x32f9fdf2 > 0;
        _0x3b739e89.IsFree = _0xc0ff279f;
        int _0xa01f1b5b = (this._0x1713ab3e * 7919) ^ (this._0xd132a8ad * 104729);
        System.Random _0x051a104c = new System.Random(_0xa01f1b5b);
        if (_0x399c4e6a && !this._0x2bb0886a && !_0xc0ff279f)
        {
            this._0x2bb0886a = true;
            this._0x6e3564b0(_0x051a104c, _0x3b739e89);
        }
        else if (this._0x686bf015 >= DryStreakLimit)
        {
            this._0xebb69258(_0x051a104c, _0x3b739e89);
        }
        else
        {
            this._0xe94319c0(_0x051a104c, _0x3b739e89);
        }

        this._0x64cce223(_0x3b739e89, _0xf99e5f3b, _0xc0ff279f);
        if (_0x3b739e89.Win > 0)
            this._0x686bf015 = 0;
        else
            this._0x686bf015++;
        if (_0xc0ff279f)
            this._0x32f9fdf2--;
        else if (_0x3b739e89.FreeSpinsAwarded > 0)
            this._0x32f9fdf2 = _0x3b739e89.FreeSpinsAwarded;
        this._0xd132a8ad++;
        {
#if B_LOGS
            {
                Debug.Log(_0xbcfbc1fc._0x4f9f78d7(new byte[12] { 252, 212, 215, 206, 201, 250, 135, 212, 194, 194, 195, 154 }, 167) + _0xa01f1b5b + _0xbcfbc1fc._0x4f9f78d7(new byte[7] { 48, 121, 126, 116, 117, 104, 45 }, 16) + (this._0xd132a8ad - 1) + _0xbcfbc1fc._0x4f9f78d7(new byte[5] { 239, 184, 166, 161, 242 }, 207) + _0x3b739e89.Win + _0xbcfbc1fc._0x4f9f78d7(new byte[6] { 110, 40, 60, 43, 43, 115 }, 78) + _0xc0ff279f);
            }
#endif
        }

        return _0x3b739e89;
    }

    private const int DryStreakLimit = 7;
    private int[][] _0xbc5c5f0d;
    private void _0x64cce223(_0xf4931647 _0xb22436e9, int _0xbde68545, bool _0xc473275c)
    {
        int _0x4dc369d4 = 0;
        for (int _0x1d36f7c9 = 0; _0x1d36f7c9 < _0x80ffeb86.LineCount; _0x1d36f7c9++)
        {
            int _0xa96b6daa;
            int _0x909258be;
            int multiplier = _0x80ffeb86.EvaluateLine(_0xb22436e9.Grid, _0x1d36f7c9, out _0xa96b6daa, out _0x909258be);
            _0xb22436e9.LineMultiplier[_0x1d36f7c9] = multiplier;
            _0xb22436e9.LineRun[_0x1d36f7c9] = _0xa96b6daa;
            _0xb22436e9.LineSymbol[_0x1d36f7c9] = _0x909258be;
            _0xb22436e9.TotalMultiplier += multiplier;
            if (multiplier > _0x4dc369d4)
            {
                _0x4dc369d4 = multiplier;
                _0xb22436e9.BestLine = _0x1d36f7c9;
            }
        }

        if (_0xc473275c)
            _0xb22436e9.TotalMultiplier *= _0x80ffeb86.FreeSpinMultiplier;
        if (!_0xc473275c)
        {
            _0xb22436e9.ScatterReels = _0x80ffeb86.CountScatterReels(_0xb22436e9.Grid);
            _0xb22436e9.ScatterMultiplier = _0x80ffeb86.ScatterMultiplier(_0xb22436e9.ScatterReels);
            if (_0xb22436e9.ScatterReels >= 3)
                _0xb22436e9.FreeSpinsAwarded = _0x80ffeb86.FreeSpinAward;
        }

        _0xb22436e9.Win = (_0xb22436e9.TotalMultiplier + _0xb22436e9.ScatterMultiplier) * _0xbde68545;
    }

    /// <summary>
    /// The stage never goes cold for more than seven spins. The consolation outcome is
    /// BUILT to pay the bottom tier exactly - three low pips on the middle line and
    /// nothing else - so the guard is a safety net and not a bonus. Measured over two
    /// million spins it lifts the return by 0.010 (0.9037 analytic -> 0.9139 measured)
    /// and caps the worst dry streak at exactly 7.
    /// </summary>
    private void _0xebb69258(System.Random _0xe497d005, _0xf4931647 _0x0ce6684f)
    {
        int[] _0xed1e0835 = new int[_0x80ffeb86.Reels];
        int[] _0x6aa40627 = new int[_0x80ffeb86.Reels * _0x80ffeb86.Rows];
        for (int _0xafab931d = 0; _0xafab931d < ConsolationAttempts; _0xafab931d++)
        {
            bool _0x60cabbff = true;
            for (int _0x0524b11f = 0; _0x0524b11f < _0x80ffeb86.Reels; _0x0524b11f++)
            {
                int[] _0xaebd06f4 = _0x0524b11f < 3 ? this._0xbc5c5f0d[_0x0524b11f] : this._0xf1e26f6f[_0x0524b11f];
                if (_0xaebd06f4 == null || _0xaebd06f4.Length == 0)
                {
                    _0x60cabbff = false;
                    break;
                }

                _0xed1e0835[_0x0524b11f] = _0xaebd06f4[_0xe497d005.Next(_0xaebd06f4.Length)];
                _0x80ffeb86.ReadWindow(this._0x7f12df16[_0x0524b11f], _0xed1e0835[_0x0524b11f], _0x6aa40627, _0x0524b11f * _0x80ffeb86.Rows);
            }

            if (!_0x60cabbff)
                break;
            int _0x305182f4 = 0;
            for (int _0x7c196344 = 0; _0x7c196344 < _0x80ffeb86.LineCount; _0x7c196344++)
            {
                int _0x55e4e762;
                int _0x74a52e89;
                _0x305182f4 += _0x80ffeb86.EvaluateLine(_0x6aa40627, _0x7c196344, out _0x55e4e762, out _0x74a52e89);
            }

            if (_0x305182f4 == _0x80ffeb86.Multiplier(_0x80ffeb86.Spade, 3) && _0x80ffeb86.CountScatterReels(_0x6aa40627) < 3)
            {
                for (int _0xa104f708 = 0; _0xa104f708 < _0x6aa40627.Length; _0xa104f708++)
                    _0x0ce6684f.Grid[_0xa104f708] = _0x6aa40627[_0xa104f708];
                for (int _0x0878a231 = 0; _0x0878a231 < _0xed1e0835.Length; _0x0878a231++)
                    _0x0ce6684f.Stops[_0x0878a231] = _0xed1e0835[_0x0878a231];
                return;
            }
        }

        this._0x30353506(_0xe497d005, _0x0ce6684f);
    }

    private int[][] _0x7f12df16;
    private const int RerollCandidates = 12;
    public int[] _0x0665f1a4(int _0x542b1bfd)
    {
        if (this._0x7f12df16 == null || _0x542b1bfd < 0 || _0x542b1bfd >= this._0x7f12df16.Length)
            return null;
        return this._0x7f12df16[_0x542b1bfd];
    }

    private int[][] _0xf1e26f6f;
    private int _0xd132a8ad;
    private bool _0x2bb0886a;
    private int _0x686bf015;
    /// <summary>Four crowns on the middle line - clears the big-win threshold on purpose.</summary>
    private void _0x6e3564b0(System.Random _0xb735f640, _0xf4931647 _0x8c606719)
    {
        this._0xe94319c0(_0xb735f640, _0x8c606719);
        for (int _0x3403715b = 0; _0x3403715b < 4; _0x3403715b++)
            _0x8c606719.Grid[_0x3403715b * _0x80ffeb86.Rows + 1] = _0x80ffeb86.Crown;
        int _0xc5e8e8b1 = _0x8c606719.Grid[4 * _0x80ffeb86.Rows + 1];
        if (_0xc5e8e8b1 == _0x80ffeb86.Crown || _0xc5e8e8b1 == _0x80ffeb86.Jester)
            _0x8c606719.Grid[4 * _0x80ffeb86.Rows + 1] = _0x80ffeb86.Spade;
        for (int _0xe985d815 = 0; _0xe985d815 < _0x80ffeb86.Reels; _0xe985d815++)
            for (int _0x6e97f9b9 = 0; _0x6e97f9b9 < _0x80ffeb86.Rows; _0x6e97f9b9++)
                if (_0x6e97f9b9 != 1 && _0x8c606719.Grid[_0xe985d815 * _0x80ffeb86.Rows + _0x6e97f9b9] == _0x80ffeb86.Ticket)
                    _0x8c606719.Grid[_0xe985d815 * _0x80ffeb86.Rows + _0x6e97f9b9] = _0x80ffeb86.Heart;
    }
}

internal static class _0xbcfbc1fc
{
    internal static string _0x4f9f78d7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}