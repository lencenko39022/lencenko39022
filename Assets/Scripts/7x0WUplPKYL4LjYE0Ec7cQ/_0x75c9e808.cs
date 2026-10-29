using UnityEngine;

// The three strips a sitting plays on, drawn fresh from the session seed and then
// PROVEN before the player ever sees them (C.11).
//
// Drawing: each reel gets its own shuffle of the table's face multiset, so the strip
// length and every face count are exact and the table's stated odds are the odds that
// ship. A reel is then rotated by a random amount so the three reels do not share a
// pattern.
//
// Proving: the draw is run through ProbeSpins rounds with its own stream and is kept
// only when it wins at least ProbeMinWins times, lands the first of those inside the
// first ProbeFirstWinWithin rounds (so a short visit is not a wall of blanks) and never
// pays more than ProbeMaxLineMultiplier on one line. Up to GenerationAttempts draws are
// tried; if none holds, the hand tuned Fallback is used - the fallback is the safety
// net, never the game.
//
// The showcase stops are CONSTRUCTED rather than drawn: a rare picture cannot be found
// by drawing twenty times and hoping, so the opening rounds of a sitting are assembled
// by looking up a stop whose centre row already carries the wanted face.
public sealed class _0x75c9e808
{
    private static int[] BuildMultiset(_0x9aaba7e8 _0x82a8aca5)
    {
        int _0x65adf330 = 0;
        for (int _0x2f79026e = 0; _0x2f79026e < _0x82a8aca5._0x30383bc4.Length; _0x2f79026e++)
        {
            _0x65adf330 += _0x82a8aca5._0x30383bc4[_0x2f79026e];
        }

        int[] _0xb950aabe = new int[_0x65adf330];
        int _0x7e6214b3 = 0;
        for (int _0xb3e4833d = 0; _0xb3e4833d < _0x82a8aca5._0x30383bc4.Length; _0xb3e4833d++)
        {
            for (int _0xe80fbe5f = 0; _0xe80fbe5f < _0x82a8aca5._0x30383bc4[_0xb3e4833d]; _0xe80fbe5f++)
            {
                _0xb950aabe[_0x7e6214b3] = _0xb3e4833d;
                _0x7e6214b3++;
            }
        }

        return _0xb950aabe;
    }

    // A stable number derived from the strips themselves, so the probe is reproducible
    // for a given draw without carrying the generator's stream around.
    private int _0x87400027()
    {
        int _0x2cf6035e = 17;
        for (int _0x05408f35 = 0; _0x05408f35 < _0xbbd798a9.Reels; _0x05408f35++)
        {
            int[] _0xf315d362 = this._0xf1e52b52[_0x05408f35];
            for (int _0x94763d8e = 0; _0x94763d8e < _0xf315d362.Length; _0x94763d8e++)
            {
                _0x2cf6035e = _0x2cf6035e * 31 + _0xf315d362[_0x94763d8e] + _0x05408f35;
            }
        }

        return _0x2cf6035e == 0 ? 1 : _0x2cf6035e;
    }

    private void _0xa62cd5d3(_0x9aaba7e8 _0x7c12b52c, System.Random _0xb984ef96)
    {
        for (int _0xcaf5a13b = 0; _0xcaf5a13b < _0xbbd798a9.Reels; _0xcaf5a13b++)
        {
            int[] _0x5bf90879 = BuildMultiset(_0x7c12b52c);
            Shuffle(_0x5bf90879, _0xb984ef96);
            int _0x86d958cc = _0xb984ef96.Next(_0x5bf90879.Length);
            this._0xf1e52b52[_0xcaf5a13b] = Rotate(_0x5bf90879, _0x86d958cc);
        }
    }

    public int _0x13bc7317(int _0x63453652, int _0x5a55d923, int _0x71726381)
    {
        int[] _0xf142a0bd = this._0xf1e52b52[_0x63453652];
        int _0xacb3741b = ((_0x5a55d923 + _0x71726381) % _0xf142a0bd.Length + _0xf142a0bd.Length) % _0xf142a0bd.Length;
        return _0xf142a0bd[_0xacb3741b];
    }

    public int[][] _0xcef53720 => this._0xf1e52b52;
    public bool _0xf4df0193 => this._0x6dfe89bb;

    // A stop for every reel whose CENTRE row already carries `face`, so an opening
    // round can be a guaranteed, honest line of three rather than a hope.
    // Returns false when a reel has no such stop at all, which the caller treats as
    // "let this round be an ordinary draw".
    public bool _0xc245784e(int _0x7e3854b2, int[] _0xb97c6313)
    {
        for (int _0x65ea5058 = 0; _0x65ea5058 < _0xbbd798a9.Reels; _0x65ea5058++)
        {
            int _0x6c2daebf = -1;
            for (int _0xbb095b5c = 0; _0xbb095b5c < this._0xc5d1e44f; _0xbb095b5c++)
            {
                if (this._0x13bc7317(_0x65ea5058, _0xbb095b5c, 1) == _0x7e3854b2)
                {
                    _0x6c2daebf = _0xbb095b5c;
                    break;
                }
            }

            if (_0x6c2daebf < 0)
            {
                return false;
            }

            _0xb97c6313[_0x65ea5058] = _0x6c2daebf;
        }

        return true;
    }

    public int _0x7cfac638 => this._0x876efe94;

    // The acceptance probe. It runs on its own stream so the judgement never depends on
    // how many numbers the draw happened to consume.
    private bool _0xbf88ce09(_0x9aaba7e8 _0x99eb3fd3)
    {
        System.Random _0x0bb2fea0 = new System.Random(this._0x87400027());
        _0xad51c8f1 _0xea0d5b75 = new _0xad51c8f1()._0x4175be81();
        int[] _0x17598b2f = _0xea0d5b75._0x87d5afad;
        int _0x8591dbff = 0;
        int _0x2baec287 = -1;
        for (int _0xd25c6be7 = 0; _0xd25c6be7 < _0xbbd798a9.ProbeSpins; _0xd25c6be7++)
        {
            for (int _0xc2463d4d = 0; _0xc2463d4d < _0xbbd798a9.Reels; _0xc2463d4d++)
            {
                int _0x3633e3cc = _0x0bb2fea0.Next(this._0xc5d1e44f);
                for (int _0x4b64b329 = 0; _0x4b64b329 < _0xbbd798a9.Rows; _0x4b64b329++)
                {
                    _0x17598b2f[_0x4dc369d4.Cell(_0xc2463d4d, _0x4b64b329)] = this._0x13bc7317(_0xc2463d4d, _0x3633e3cc, _0x4b64b329);
                }
            }

            _0x4dc369d4.Evaluate(_0x17598b2f, _0x99eb3fd3, 1, _0xea0d5b75);
            if (_0xea0d5b75._0x81b31132 > _0xbbd798a9.ProbeMaxLineMultiplier)
            {
                return false;
            }

            if (_0xea0d5b75._0xc3ad9eea)
            {
                _0x8591dbff++;
                if (_0x2baec287 < 0)
                {
                    _0x2baec287 = _0xd25c6be7;
                }
            }
        }

        if (_0x8591dbff < _0xbbd798a9.ProbeMinWins)
        {
            return false;
        }

        return _0x2baec287 >= 0 && _0x2baec287 < _0xbbd798a9.ProbeFirstWinWithin;
    }

    private static int[] Rotate(int[] _0x809bc01c, int _0x92b6f7a4)
    {
        int[] _0x2d5911c9 = new int[_0x809bc01c.Length];
        for (int _0x4740fdad = 0; _0x4740fdad < _0x809bc01c.Length; _0x4740fdad++)
        {
            _0x2d5911c9[_0x4740fdad] = _0x809bc01c[(_0x4740fdad + _0x92b6f7a4) % _0x809bc01c.Length];
        }

        return _0x2d5911c9;
    }

    // The first value at or above `want` that shares no factor with `length`.
    private static int Stride(int _0xe9c21996, int _0xc66b5af8)
    {
        int _0xe98b8b64 = _0xc66b5af8 % _0xe9c21996;
        if (_0xe98b8b64 < 1)
        {
            _0xe98b8b64 = 1;
        }

        for (int _0x76cab882 = 0; _0x76cab882 < _0xe9c21996; _0x76cab882++)
        {
            if (GreatestCommonDivisor(_0xe98b8b64, _0xe9c21996) == 1)
            {
                return _0xe98b8b64;
            }

            _0xe98b8b64 = _0xe98b8b64 % _0xe9c21996 + 1;
        }

        return 1;
    }

    // The arrangement the board shows before the first round of a sitting: a seeded
    // still frame, so two sittings do not open on the same picture.
    public void _0x940858d3(System.Random _0xab9b4321, int[] _0x24c2b628)
    {
        for (int _0x82a5c174 = 0; _0x82a5c174 < _0xbbd798a9.Reels; _0x82a5c174++)
        {
            _0x24c2b628[_0x82a5c174] = _0xab9b4321.Next(this._0xc5d1e44f);
        }
    }

    public _0x75c9e808 _0xa3dec531(_0x9aaba7e8 _0xa1ff68bc, System.Random _0x4e0bbe1d)
    {
        this._0x6dfe89bb = false;
        this._0x876efe94 = 0;
        for (int _0x814c896e = 0; _0x814c896e < _0xbbd798a9.GenerationAttempts; _0x814c896e++)
        {
            this._0x876efe94 = _0x814c896e + 1;
            this._0xa62cd5d3(_0xa1ff68bc, _0x4e0bbe1d);
            if (this._0xbf88ce09(_0xa1ff68bc))
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[strips] accepted after {this._0x876efe94} draw(s) at {_0xa1ff68bc._0x374268d8}");
                    }
#endif
                }

                return this;
            }
        }

        this._0xe6bbd05a(_0xa1ff68bc);
        this._0x6dfe89bb = true;
        {
#if B_LOGS
            {
                Debug.Log($"[strips] fell back to the fixed set at {_0xa1ff68bc._0x374268d8}");
            }
#endif
        }

        return this;
    }

    private static int GreatestCommonDivisor(int _0x17d47588, int _0xe6fecda1)
    {
        while (_0xe6fecda1 != 0)
        {
            int _0x6bc173ab = _0x17d47588 % _0xe6fecda1;
            _0x17d47588 = _0xe6fecda1;
            _0xe6fecda1 = _0x6bc173ab;
        }

        return _0x17d47588 < 0 ? -_0x17d47588 : _0x17d47588;
    }

    private static void Shuffle(int[] _0x677b0346, System.Random _0x461c6b88)
    {
        for (int _0xdd77fbd2 = _0x677b0346.Length - 1; _0xdd77fbd2 > 0; _0xdd77fbd2--)
        {
            int _0xf1cc35c4 = _0x461c6b88.Next(_0xdd77fbd2 + 1);
            int _0x10547ac2 = _0x677b0346[_0xdd77fbd2];
            _0x677b0346[_0xdd77fbd2] = _0x677b0346[_0xf1cc35c4];
            _0x677b0346[_0xf1cc35c4] = _0x10547ac2;
        }
    }

    public int _0xc5d1e44f => this._0xf1e52b52[0].Length;

    private int _0x876efe94;
    private int[][] _0xf1e52b52 = new int[_0xbbd798a9.Reels][];
    // The hand tuned safety net. It carries every face of the table in exactly the
    // right proportions, laid down with a stride that is coprime with the strip length
    // so the faces end up spread instead of grouped, and a different stride per reel so
    // the three reels never march in step.
    private void _0xe6bbd05a(_0x9aaba7e8 _0xf2df9cb3)
    {
        int[] _0xe9b78729 = BuildMultiset(_0xf2df9cb3);
        int _0xf666694b = _0xe9b78729.Length;
        for (int _0x71cbe119 = 0; _0x71cbe119 < _0xbbd798a9.Reels; _0x71cbe119++)
        {
            int _0x71f6d037 = Stride(_0xf666694b, 7 + _0x71cbe119 * 4);
            int[] _0x3e24cbf0 = new int[_0xf666694b];
            bool[] _0xdc6149ef = new bool[_0xf666694b];
            int _0x8c21a9f5 = _0x71cbe119 * 3 % _0xf666694b;
            for (int _0x1c901548 = 0; _0x1c901548 < _0xf666694b; _0x1c901548++)
            {
                while (_0xdc6149ef[_0x8c21a9f5])
                {
                    _0x8c21a9f5 = (_0x8c21a9f5 + 1) % _0xf666694b;
                }

                _0x3e24cbf0[_0x8c21a9f5] = _0xe9b78729[_0x1c901548];
                _0xdc6149ef[_0x8c21a9f5] = true;
                _0x8c21a9f5 = (_0x8c21a9f5 + _0x71f6d037) % _0xf666694b;
            }

            this._0xf1e52b52[_0x71cbe119] = _0x3e24cbf0;
        }
    }

    private bool _0x6dfe89bb;
}