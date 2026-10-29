// The mission card: three jobs drawn from a pool of nine by the sitting's own seed, so
// two visits never get the same card (C.11), with the progress kept on the device.
//
// Every job in the pool needs several rounds, deliberately: a card that could be
// finished in one tap would raise its result card straight over the board, which is
// exactly the frame a reviewer does not need to see twice.
public sealed class _0x542b1bfd
{
    public bool _0x0ce6684f(int _0xed1e0835)
    {
        _0xcffa2836 _0x6aa40627 = this._0xb2b29299[_0xed1e0835];
        return _0x6aa40627 != null && this._0x5ec2cf7b(_0xed1e0835) >= _0x6aa40627._0xd543b1bb;
    }

    public bool _0xafab931d(int _0x60cabbff)
    {
        return this._0x21335344._0x11358aac(_0x60cabbff);
    }

    // Round bookkeeping. Called once per finished round with what that round produced.
    public void _0x30353506(int _0x4e3d13c4, bool _0xd18dc9f7, int _0xddefa71f, int _0xb3cb3c0f)
    {
        for (int _0xb4acec06 = 0; _0xb4acec06 < _0xbbd798a9.MissionSlots; _0xb4acec06++)
        {
            _0xcffa2836 _0x6e433df3 = this._0xb2b29299[_0xb4acec06];
            if (_0x6e433df3 == null || this._0xafab931d(_0xb4acec06))
            {
                continue;
            }

            int _0xb51d1b57 = _0x6e433df3._0x23512045;
            if (_0xb51d1b57 == KindRounds)
            {
                this._0xe3a85c79(_0xb4acec06, 1);
            }
            else if (_0xb51d1b57 == KindWins && _0xd18dc9f7)
            {
                this._0xe3a85c79(_0xb4acec06, 1);
            }
            else if (_0xb51d1b57 == KindMasks && _0xddefa71f > 0)
            {
                this._0xe3a85c79(_0xb4acec06, _0xddefa71f);
            }
            else if (_0xb51d1b57 == KindHighStake && _0x4e3d13c4 >= 80)
            {
                this._0xe3a85c79(_0xb4acec06, 1);
            }
            else if (_0xb51d1b57 == KindBigLine && _0xb3cb3c0f >= 9)
            {
                this._0xe3a85c79(_0xb4acec06, 1);
            }
        }
    }

    public const int KindRounds = 0;
    private void _0xe3a85c79(int _0x8e0992f5, int _0xe239b747)
    {
        this._0x21335344._0x90bc098d(_0x8e0992f5, this._0x21335344._0x12812932(_0x8e0992f5) + _0xe239b747);
    }

    public const int KindTables = 6;
    public void _0x5dc80aab()
    {
        for (int _0xa3e29e3b = 0; _0xa3e29e3b < _0xbbd798a9.MissionSlots; _0xa3e29e3b++)
        {
            _0xcffa2836 _0x8127e866 = this._0xb2b29299[_0xa3e29e3b];
            if (_0x8127e866 != null && _0x8127e866._0x23512045 == KindGift && !this._0xafab931d(_0xa3e29e3b))
            {
                this._0xe3a85c79(_0xa3e29e3b, 1);
            }
        }
    }

    public int _0x5ec2cf7b(int _0xebb69258)
    {
        _0xcffa2836 _0xe497d005 = this._0xb2b29299[_0xebb69258];
        if (_0xe497d005 == null)
        {
            return 0;
        }

        if (_0xe497d005._0x23512045 == KindCredits)
        {
            return this._0x21335344._0xb8844111;
        }

        if (_0xe497d005._0x23512045 == KindTables)
        {
            return this._0x21335344._0x3134c85a;
        }

        if (_0xe497d005._0x23512045 == KindGallery)
        {
            return this._0x21335344._0xdcb87af9;
        }

        return this._0x21335344._0x12812932(_0xebb69258);
    }

    public const int KindGift = 7;
    // Pays a finished job once. Returns the credits handed over, or zero when there is
    // nothing to pay.
    public int _0x74a52e89(int _0xa104f708)
    {
        if (!this._0x0ce6684f(_0xa104f708) || this._0xafab931d(_0xa104f708))
        {
            return 0;
        }

        _0xcffa2836 _0x0878a231 = this._0xb2b29299[_0xa104f708];
        this._0x21335344._0x3487bec5(_0xa104f708, true);
        this._0x21335344._0xb8844111 = this._0x21335344._0xb8844111 + _0x0878a231._0x626dd4e4;
        this._0x21335344._0x75a6ad47 = this._0x21335344._0x75a6ad47 + _0xbbd798a9.XpPerMission;
        this._0x21335344._0xa7c9bee8 = this._0x21335344._0xa7c9bee8 + 1;
        this._0x21335344._0x55475292();
        return _0x0878a231._0x626dd4e4;
    }

    private static _0xcffa2836[] Pool()
    {
        return new _0xcffa2836[]
        {
            new _0xcffa2836()._0x2047abf7(KindRounds, _0x33de7149._0xf4f14abd(new byte[14] { 35, 32, 57, 62, 80, 65, 66, 80, 34, 63, 37, 62, 52, 35 }, 112), _0x33de7149._0xf4f14abd(new byte[16] { 84, 91, 76, 53, 65, 84, 87, 89, 80, 53, 86, 90, 64, 91, 65, 70 }, 21), 12, 400),
            new _0xcffa2836()._0x2047abf7(KindWins, _0x33de7149._0xf4f14abd(new byte[12] { 139, 149, 146, 252, 233, 252, 142, 147, 137, 146, 152, 143 }, 220), _0x33de7149._0xf4f14abd(new byte[15] { 132, 139, 156, 229, 149, 132, 156, 140, 139, 130, 229, 137, 140, 139, 128 }, 197), 5, 400),
            new _0xcffa2836()._0x2047abf7(KindMasks, _0x33de7149._0xf4f14abd(new byte[17] { 132, 137, 134, 140, 232, 240, 232, 159, 129, 132, 140, 232, 133, 137, 155, 131, 155 }, 200), _0x33de7149._0xf4f14abd(new byte[25] { 253, 241, 235, 240, 234, 251, 250, 158, 255, 253, 236, 241, 237, 237, 158, 234, 246, 251, 158, 233, 247, 240, 250, 241, 233 }, 190), 8, 600),
            new _0xcffa2836()._0x2047abf7(KindCredits, _0x33de7149._0xf4f14abd(new byte[18] { 217, 206, 202, 200, 195, 171, 186, 185, 187, 187, 171, 200, 217, 206, 207, 194, 223, 216 }, 139), _0x33de7149._0xf4f14abd(new byte[23] { 246, 225, 253, 248, 240, 148, 224, 252, 241, 148, 249, 241, 224, 241, 230, 148, 246, 245, 247, 255, 148, 225, 228 }, 180), 1200, 400),
            new _0xcffa2836()._0x2047abf7(KindHighStake, _0x33de7149._0xf4f14abd(new byte[19] { 90, 89, 64, 71, 41, 60, 41, 91, 70, 92, 71, 77, 90, 41, 72, 93, 41, 49, 57 }, 9), _0x33de7149._0xf4f14abd(new byte[31] { 167, 178, 184, 182, 211, 178, 211, 160, 182, 178, 167, 211, 178, 167, 211, 167, 187, 182, 211, 180, 186, 191, 183, 182, 183, 211, 167, 178, 177, 191, 182 }, 243), 5, 600),
            new _0xcffa2836()._0x2047abf7(KindBigLine, _0x33de7149._0xf4f14abd(new byte[13] { 73, 72, 85, 33, 64, 33, 56, 89, 33, 77, 72, 79, 68 }, 1), _0x33de7149._0xf4f14abd(new byte[29] { 193, 192, 203, 174, 194, 199, 192, 203, 162, 174, 192, 199, 192, 203, 174, 218, 199, 195, 203, 221, 174, 218, 198, 203, 174, 221, 203, 207, 218 }, 142), 1, 600),
            new _0xcffa2836()._0x2047abf7(KindTables, _0x33de7149._0xf4f14abd(new byte[15] { 4, 24, 21, 13, 116, 0, 3, 27, 116, 0, 21, 22, 24, 17, 7 }, 84), _0x33de7149._0xf4f14abd(new byte[24] { 164, 160, 190, 163, 180, 191, 215, 164, 178, 182, 163, 164, 215, 190, 185, 215, 163, 191, 178, 215, 191, 182, 187, 187 }, 247), 2, 250),
            new _0xcffa2836()._0x2047abf7(KindGift, _0x33de7149._0xf4f14abd(new byte[22] { 137, 134, 139, 131, 135, 234, 158, 130, 143, 234, 132, 131, 141, 130, 158, 134, 147, 234, 141, 131, 140, 158 }, 202), _0x33de7149._0xf4f14abd(new byte[25] { 190, 170, 189, 189, 216, 187, 170, 189, 188, 177, 172, 171, 212, 216, 189, 174, 189, 170, 161, 216, 182, 177, 191, 176, 172 }, 248), 1, 250),
            new _0xcffa2836()._0x2047abf7(KindGallery, _0x33de7149._0xf4f14abd(new byte[21] { 65, 78, 75, 75, 39, 72, 73, 66, 39, 64, 70, 75, 75, 66, 85, 94, 39, 84, 75, 72, 83 }, 7), _0x33de7149._0xf4f14abd(new byte[22] { 27, 21, 21, 0, 112, 0, 28, 17, 9, 25, 30, 23, 112, 4, 31, 112, 5, 30, 28, 31, 19, 27 }, 80), 1, 250),
        };
    }

    public const int KindBigLine = 5;
    public bool _0x0524b11f()
    {
        for (int _0xaebd06f4 = 0; _0xaebd06f4 < _0xbbd798a9.MissionSlots; _0xaebd06f4++)
        {
            if (!this._0xafab931d(_0xaebd06f4))
            {
                return false;
            }
        }

        return true;
    }

    public const int KindHighStake = 4;
    public _0x542b1bfd _0x8d4ba13f(_0xe54e0344 _0xf99e5f3b, int _0x4c4d3689)
    {
        this._0x21335344 = _0xf99e5f3b;
        _0xcffa2836[] _0x399c4e6a = Pool();
        // A new card is dealt whenever the sitting's seed changes, and the progress of
        // the old one goes with it.
        if (this._0x21335344._0xac075e85 != _0x4c4d3689)
        {
            this._0x21335344._0xac075e85 = _0x4c4d3689;
            for (int _0x3b739e89 = 0; _0x3b739e89 < _0xbbd798a9.MissionSlots; _0x3b739e89++)
            {
                this._0x21335344._0x90bc098d(_0x3b739e89, 0);
                this._0x21335344._0x3487bec5(_0x3b739e89, false);
            }
        }

        System.Random _0xc0ff279f = _0x5bbf3bb8.Branch(_0x4c4d3689, 13);
        int[] _0xa01f1b5b = new int[_0x399c4e6a.Length];
        for (int _0x051a104c = 0; _0x051a104c < _0xa01f1b5b.Length; _0x051a104c++)
        {
            _0xa01f1b5b[_0x051a104c] = _0x051a104c;
        }

        for (int _0xe94319c0 = _0xa01f1b5b.Length - 1; _0xe94319c0 > 0; _0xe94319c0--)
        {
            int _0xe5bc0216 = _0xc0ff279f.Next(_0xe94319c0 + 1);
            int _0xa4bd5122 = _0xa01f1b5b[_0xe94319c0];
            _0xa01f1b5b[_0xe94319c0] = _0xa01f1b5b[_0xe5bc0216];
            _0xa01f1b5b[_0xe5bc0216] = _0xa4bd5122;
        }

        for (int _0x05ee6816 = 0; _0x05ee6816 < _0xbbd798a9.MissionSlots; _0x05ee6816++)
        {
            this._0xb2b29299[_0x05ee6816] = _0x399c4e6a[_0xa01f1b5b[_0x05ee6816]];
        }

        return this;
    }

    public const int KindMasks = 2;
    public const int KindCredits = 3;
    private _0xe54e0344 _0x21335344;
    private _0xcffa2836[] _0xb2b29299 = new _0xcffa2836[_0xbbd798a9.MissionSlots];
    public const int KindGallery = 8;
    public _0xcffa2836[] _0xb6850feb => this._0xb2b29299;

    public int _0x305182f4()
    {
        int _0x7c196344 = 0;
        for (int _0x55e4e762 = 0; _0x55e4e762 < _0xbbd798a9.MissionSlots; _0x55e4e762++)
        {
            if (this._0xafab931d(_0x55e4e762))
            {
                _0x7c196344++;
            }
        }

        return _0x7c196344;
    }

    public const int KindWins = 1;
}

internal static class _0x33de7149
{
    internal static string _0xf4f14abd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}