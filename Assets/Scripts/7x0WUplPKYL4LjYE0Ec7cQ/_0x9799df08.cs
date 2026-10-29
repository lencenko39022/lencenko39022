using DG.Tweening;
using UnityEngine;

// The table itself: it deals the strips, takes the stake, turns the columns, scores the
// window, pays what is owed and keeps the sitting going.
//
// Three things here exist for the sake of a run that nobody is watching, because a table
// that sits frozen is useless both to a guest who put the phone down and to a
// walkthrough of the app:
//   * an untouched table turns by itself every ClubConfig.IdleSpinSeconds;
//   * a tap that arrives while the columns are moving is QUEUED and replayed, never
//     dropped - otherwise a guest's own tap would be eaten by a turn that started a
//     moment earlier;
//   * running the meter down is not an ending. The house puts the seat back to
//     ClubConfig.RefillCredits for nothing, says so, and the sitting continues.
//
// The first two rounds a guest plays are CONSTRUCTED rather than drawn: a line of three
// is looked up on the strips that are already in play, so a short visit always sees the
// table do what the table is for. Every round after that is an ordinary draw.
public sealed class _0x9799df08 : MonoBehaviour
{
    private int[] _0x07748ac1 = new int[_0xbbd798a9.Reels];
    private bool _0xa5e70fcf;
    private float[] _0x4ea9d894 = new float[_0xbbd798a9.Reels];
    private const int PhaseIdle = 0;
    // The result of a round stays on the board until the next round takes it away: a
    // line that cleared itself after a second or two would leave a guest who looked up
    // from the phone - and anyone photographing the table - with a blank window and no
    // idea what had just been paid. Begin() is what clears it.
    private void _0xefee00e5()
    {
        this._0x4148cf45 = PhaseIdle;
        this._0xf8eefe90._0x53b118fd(true);
        if (!this._0x081a7960 && this._0xf4d8edc4._0x0524b11f())
        {
            this._0x081a7960 = true;
            this._0x5f6a1987();
            return;
        }

        if (this._0xf467f42f._0xb8844111 < this._0xf467f42f._0x45319abc)
        {
            this._0xbe24d83c();
            return;
        }

        if (this._0xa5e70fcf)
        {
            this._0xa5e70fcf = false;
            this._0x56bd0719(true);
        }
    }

    private _0x542b1bfd _0xf4d8edc4;
    public void _0xeaab87db(int _0x4609f4f8)
    {
        this._0xe1769e12 = 0f;
        int _0x609462a4 = this._0x6003f59b._0xc24dddd0;
        int[] _0x0f148161 =
        {
            _0x609462a4,
            _0x609462a4 * 2,
            _0x609462a4 * 4
        };
        int _0xd21b4b17 = this._0xf467f42f._0x45319abc;
        int _0x2d15f0ae = 0;
        for (int _0x84d77364 = 0; _0x84d77364 < _0x0f148161.Length; _0x84d77364++)
        {
            if (_0x0f148161[_0x84d77364] == _0xd21b4b17)
            {
                _0x2d15f0ae = _0x84d77364;
            }
        }

        _0x2d15f0ae = _0x2d15f0ae + _0x4609f4f8;
        if (_0x2d15f0ae < 0)
        {
            _0x2d15f0ae = 0;
        }

        if (_0x2d15f0ae >= _0x0f148161.Length)
        {
            _0x2d15f0ae = _0x0f148161.Length - 1;
        }

        this._0xf467f42f._0x45319abc = _0x0f148161[_0x2d15f0ae];
        this._0xf467f42f._0x55475292();
        this._0xf8eefe90._0x5908a2dd();
        this._0xf8eefe90._0x9210c455(this._0xf467f42f._0xb8844111, this._0xf467f42f._0xb8844111);
    }

    private _0xfa11b898 _0xf8eefe90;
    private int _0x4148cf45 = PhaseIdle;
    private _0x9aaba7e8 _0x6003f59b;
    // --- controls -------------------------------------------------------------
    public void _0x7e3bd6e3()
    {
        this._0xe1769e12 = 0f;
        if (this._0x3d5f7f04)
        {
            return;
        }

        if (this._0x4148cf45 != PhaseIdle)
        {
            this._0xa5e70fcf = true;
            return;
        }

        this._0x56bd0719(true);
    }

    private float _0xd8b4ea79;
    public void _0x7e4cba04(_0x828e751a _0x672083cc, _0xfa11b898 _0x3e7411f1, _0x8ac43d6c _0x39631e42, _0xe54e0344 _0x065f713a, _0x542b1bfd _0xe2b4c4e0, int _0x470b2600)
    {
        this._0x2c2ce573 = _0x672083cc;
        this._0xf8eefe90 = _0x3e7411f1;
        this._0x65ff50ca = _0x39631e42;
        this._0xf467f42f = _0x065f713a;
        this._0xf4d8edc4 = _0xe2b4c4e0;
        this._0x6003f59b = _0xdfaf60d5.At(_0x065f713a._0x97795416);
        this._0x5e851456 = _0x5bbf3bb8.Branch(_0x470b2600, 29);
        this._0x77cb5a93 = new _0x75c9e808()._0xa3dec531(this._0x6003f59b, _0x5bbf3bb8.Branch(_0x470b2600, 5));
        this._0xf467f42f._0xae49789f(_0x065f713a._0x97795416);
        this._0xf467f42f._0x55475292();
        this._0x77cb5a93._0x940858d3(_0x5bbf3bb8.Branch(_0x470b2600, 11), this._0x07748ac1);
        this._0x2c2ce573._0x0a549333(this._0x77cb5a93, this._0x07748ac1);
        this._0xf8eefe90._0x53b118fd(true);
        this._0x4148cf45 = PhaseIdle;
    }

    private System.Random _0x5e851456;
    private _0x828e751a _0x2c2ce573;
    public int _0x9bc213f0 => this._0x8c427937;

    public void _0xdd6ee835()
    {
        _0xf12a3ca3.Instance._0xb3f8431f();
        this._0x3d5f7f04 = false;
        this._0xe1769e12 = 0f;
        this._0xf8eefe90._0x53b118fd(true);
    }

    private bool _0x1d65bfb0()
    {
        for (int _0x53c5622e = 0; _0x53c5622e < _0xbbd798a9.Reels; _0x53c5622e++)
        {
            if (!this._0x2518dadf[_0x53c5622e])
            {
                return false;
            }
        }

        return true;
    }

    // The opening rounds are assembled from the strips already in play rather than
    // drawn and hoped for; after that every round is an ordinary draw.
    private void _0x4c0628da(bool _0xdb7398e1)
    {
        bool _0xefe521bc = false;
        if (_0xdb7398e1 && this._0xaca90837 == 0)
        {
            _0xefe521bc = this._0x77cb5a93._0xc245784e(4, this._0x07748ac1);
        }
        else if (_0xdb7398e1 && this._0xaca90837 == 1)
        {
            _0xefe521bc = this._0x77cb5a93._0xc245784e(1, this._0x07748ac1);
        }

        if (_0xefe521bc)
        {
            return;
        }

        for (int _0x04a6c331 = 0; _0x04a6c331 < _0xbbd798a9.Reels; _0x04a6c331++)
        {
            this._0x07748ac1[_0x04a6c331] = this._0x5e851456.Next(this._0x77cb5a93._0xc5d1e44f);
        }
    }

    private const int PhaseScoring = 2;
    // Running out is free and the seat is put back. Nothing is sold here, so there is
    // nothing to offer except the refill itself.
    private void _0xbe24d83c()
    {
        int _0xf50cbc39 = this._0xf467f42f._0xb8844111;
        this._0xf467f42f._0xb8844111 = this._0x6003f59b._0x81e6d18e;
        this._0xf467f42f._0x55475292();
        this._0xf8eefe90._0x9210c455(_0xf50cbc39, this._0xf467f42f._0xb8844111);
        _0x5d88494d _0x71a7c2fa = _0xf12a3ca3.Instance._0x3fd61d15(_0xa93ecf08._0x308a9b74.LOSE);
        _0xf12a3ca3.Instance._0x9e5425e7(_0xa93ecf08._0x308a9b74.LOSE);
        this._0x3d5f7f04 = true;
        this._0x65ff50ca._0xec0558a8(_0x71a7c2fa, this._0xf467f42f, this._0x6003f59b, this._0x8c427937);
        this._0x4148cf45 = PhaseIdle;
        this._0xf8eefe90._0x53b118fd(true);
    }

    private bool _0x3d5f7f04;
    public void _0xa053f3ec()
    {
        _0x7aee932b.Instance._0x62098066(_0xa93ecf08._0x41b99ebc.SCENE_0);
    }

    private const int PhaseHeld = 3;
    private _0xe54e0344 _0xf467f42f;
    private int _0xaca90837;
    private _0x75c9e808 _0x77cb5a93;
    private int _0x8c427937;
    private void _0xadf77184()
    {
        this._0x4148cf45 = PhaseScoring;
        int _0x20cc8730 = this._0xf467f42f._0x45319abc;
        for (int _0xc9dd50aa = 0; _0xc9dd50aa < _0xbbd798a9.Reels; _0xc9dd50aa++)
        {
            this._0xa2629ae5._0xeb15bd06(_0xc9dd50aa, this._0x07748ac1[_0xc9dd50aa]);
            for (int _0x34b21747 = 0; _0x34b21747 < _0xbbd798a9.Rows; _0x34b21747++)
            {
                this._0xa2629ae5._0x64be8335(_0xc9dd50aa, _0x34b21747, this._0x77cb5a93._0x13bc7317(_0xc9dd50aa, this._0x07748ac1[_0xc9dd50aa], _0x34b21747));
            }
        }

        _0x4dc369d4.Evaluate(this._0xa2629ae5._0x87d5afad, this._0x6003f59b, _0x20cc8730, this._0xa2629ae5);
        int _0xf7f31ff9 = 0;
        for (int _0xfbe5c827 = 0; _0xfbe5c827 < this._0xa2629ae5._0x87d5afad.Length; _0xfbe5c827++)
        {
            if (this._0xa2629ae5._0x87d5afad[_0xfbe5c827] == _0xbbd798a9.WildSymbol)
            {
                _0xf7f31ff9++;
            }
        }

        int _0xa636de13 = this._0xf467f42f._0xb8844111;
        if (this._0xa2629ae5._0xc3ad9eea)
        {
            this._0xf467f42f._0xb8844111 = _0xa636de13 + this._0xa2629ae5._0x10966145;
            this._0xf467f42f._0xd99795a1 = this._0xf467f42f._0xd99795a1 + 1;
            if (this._0xa2629ae5._0x81b31132 > this._0xf467f42f._0xa9560cca)
            {
                this._0xf467f42f._0xa9560cca = this._0xa2629ae5._0x81b31132;
            }
        }

        this._0xf467f42f._0xa6100c56 = this._0xf467f42f._0xa6100c56 + 1;
        this._0xf467f42f._0x75a6ad47 = this._0xf467f42f._0x75a6ad47 + _0xbbd798a9.XpPerSpin + (this._0xa2629ae5._0xc3ad9eea ? _0xbbd798a9.XpPerWin : 0);
        this._0xf467f42f._0x55475292();
        this._0x8c427937++;
        this._0xf4d8edc4._0x30353506(_0x20cc8730, this._0xa2629ae5._0xc3ad9eea, _0xf7f31ff9, this._0xa2629ae5._0x81b31132);
        _0xd5682da9.Refresh(this._0xf467f42f);
        this._0x2c2ce573._0x7c12663c(this._0xa2629ae5);
        this._0xf8eefe90._0x7a56de0b(this._0xf4d8edc4);
        if (this._0xa2629ae5._0xc3ad9eea)
        {
            this._0xf8eefe90._0x9210c455(_0xa636de13, this._0xf467f42f._0xb8844111);
            this._0xf8eefe90._0x5e77d608(_0x4dc369d4.LineName(this._0xa2629ae5._0x5889a5da(0)) + _0x90f79f4f._0xf6e079eb(new byte[6] { 234, 154, 139, 147, 153, 234 }, 202) + _0x1bad1984.Credits(this._0xa2629ae5._0x10966145));
            this._0x2c2ce573._0x48d74db7();
            if (this._0xa2629ae5._0x81b31132 >= 9 && this._0xf8eefe90._0x2997eb52 != null)
            {
                this._0xf8eefe90._0x2997eb52._0x1ed714fa(this._0xf467f42f._0x54d74316);
            }
        }
        else
        {
            this._0xf8eefe90._0x23ff7f24();
        }

        {
#if B_LOGS
            {
                Debug.Log($"[round] stake={_0x20cc8730} total={this._0xa2629ae5._0x10966145} best={this._0xa2629ae5._0x81b31132} credits={this._0xf467f42f._0xb8844111}");
            }
#endif
        }

        this._0x7e95c098 = _0xbbd798a9.ResolveHoldSeconds;
        this._0x4148cf45 = PhaseHeld;
    }

    private bool _0x081a7960;
    private const int PhaseTurning = 1;
    private float _0xe1769e12;
    // A cleared card is the one moment the house makes a fuss. It can only happen after
    // every job on the card has been paid, which takes many rounds, so it can never land
    // on top of a guest who has just sat down.
    private void _0x5f6a1987()
    {
        _0x5d88494d _0x4d93ed74 = _0xf12a3ca3.Instance._0x3fd61d15(_0xa93ecf08._0x308a9b74.WIN);
        _0xf12a3ca3.Instance._0x9e5425e7(_0xa93ecf08._0x308a9b74.WIN);
        this._0x3d5f7f04 = true;
        this._0x65ff50ca._0xd2361296(_0x4d93ed74, this._0xf467f42f, this._0xf4d8edc4);
        if (this._0xf8eefe90._0x2997eb52 != null)
        {
            this._0xf8eefe90._0x2997eb52._0x1ed714fa(this._0xf467f42f._0x54d74316);
        }
    }

    private bool[] _0x2518dadf = new bool[_0xbbd798a9.Reels];
    private _0xad51c8f1 _0xa2629ae5 = new _0xad51c8f1()._0x4175be81();
    private void Update()
    {
        if (this._0x4148cf45 == PhaseTurning)
        {
            this._0xd8b4ea79 += Time.deltaTime;
            for (int _0x07a077ee = 0; _0x07a077ee < _0xbbd798a9.Reels; _0x07a077ee++)
            {
                if (!this._0x2518dadf[_0x07a077ee] && this._0xd8b4ea79 >= this._0x4ea9d894[_0x07a077ee])
                {
                    this._0x2518dadf[_0x07a077ee] = true;
                    this._0x2c2ce573._0xc92c5d60(_0x07a077ee, this._0x77cb5a93, this._0x07748ac1[_0x07a077ee]);
                }
            }

            if (this._0x1d65bfb0() && !this._0x2c2ce573._0x97139ac5())
            {
                this._0xadf77184();
            }

            return;
        }

        if (this._0x4148cf45 == PhaseHeld)
        {
            this._0x7e95c098 -= Time.deltaTime;
            if (this._0x7e95c098 <= 0f)
            {
                this._0xefee00e5();
            }

            return;
        }

        if (this._0x4148cf45 != PhaseIdle)
        {
            return;
        }

        if (this._0x3d5f7f04)
        {
            return;
        }

        this._0xe1769e12 += Time.deltaTime;
        if (this._0xe1769e12 < _0xbbd798a9.IdleSpinSeconds)
        {
            return;
        }

        this._0xe1769e12 = 0f;
        this._0x56bd0719(false);
    }

    private float _0x7e95c098;
    // --- the round ------------------------------------------------------------
    private void _0x56bd0719(bool _0xbf505ea4)
    {
        int _0x04852d35 = this._0xf467f42f._0x45319abc;
        if (this._0xf467f42f._0xb8844111 < _0x04852d35)
        {
            this._0xbe24d83c();
            return;
        }

        this._0xf467f42f._0xb8844111 = this._0xf467f42f._0xb8844111 - _0x04852d35;
        this._0xf467f42f._0x55475292();
        this._0xf8eefe90._0x23ff7f24();
        this._0xf8eefe90._0x731c456e();
        this._0xf8eefe90._0x53b118fd(false);
        this._0x4c0628da(_0xbf505ea4);
        float _0xb5fa798b = this._0xf467f42f._0x54d74316 ? _0xbbd798a9.SpinSecondsReduced : _0xbbd798a9.SpinSeconds;
        for (int _0xf9b0b9ea = 0; _0xf9b0b9ea < _0xbbd798a9.Reels; _0xf9b0b9ea++)
        {
            this._0x4ea9d894[_0xf9b0b9ea] = _0xb5fa798b * (0.4375f + 0.175f * _0xf9b0b9ea);
            this._0x2518dadf[_0xf9b0b9ea] = false;
        }

        this._0xd8b4ea79 = 0f;
        this._0x4148cf45 = PhaseTurning;
        this._0x2c2ce573._0x685a4663(900f / (this._0xf467f42f._0x54d74316 ? 0.5f : 1f));
        if (_0xbf505ea4)
        {
            this._0xaca90837++;
        }
    }

    private _0x8ac43d6c _0x65ff50ca;
    public void _0x9947eee4()
    {
        this._0xe1769e12 = 0f;
        if (this._0x3d5f7f04)
        {
            return;
        }

        _0x5d88494d _0x8cb2bdd9 = _0xf12a3ca3.Instance._0x3fd61d15(_0xa93ecf08._0x308a9b74.PAUSE);
        _0xf12a3ca3.Instance._0x9e5425e7(_0xa93ecf08._0x308a9b74.PAUSE);
        this._0x3d5f7f04 = true;
        this._0x65ff50ca._0xf9b5c467(_0x8cb2bdd9, this._0xf467f42f, this._0x6003f59b, this._0x8c427937);
    }
}

internal static class _0x90f79f4f
{
    internal static string _0xf6e079eb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}