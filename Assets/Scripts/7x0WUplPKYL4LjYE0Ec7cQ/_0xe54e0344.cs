using UnityEngine;

// Everything the house remembers about one guest, kept on the device and nowhere else:
// no account, no backend, no network call anywhere in this game.
//
// Keys are plain literals written inside the methods that use them, never as fields
// another initialiser depends on (C.52). Built with Init rather than a constructor
// (C.59).
public sealed class _0xe54e0344
{
    // --- nightly gift ---------------------------------------------------------
    public string _0x3e529e93 { get => PlayerPrefs.GetString(_0x3df2fe28._0xbcb3638e(new byte[13] { 239, 246, 255, 178, 251, 245, 250, 232, 178, 248, 253, 232, 249 }, 156), ""); set => PlayerPrefs.SetString(_0x3df2fe28._0xbcb3638e(new byte[13] { 86, 79, 70, 11, 66, 76, 67, 81, 11, 65, 68, 81, 64 }, 37), value); }

    // --- credits --------------------------------------------------------------
    public int _0xb8844111
    {
        get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 88, 65, 72, 5, 72, 89, 78, 79, 66, 95, 88 }, 43), _0xbbd798a9.StartCredits);
        set
        {
            int _0x4d571aba = value < 0 ? 0 : value;
            PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 228, 253, 244, 185, 244, 229, 242, 243, 254, 227, 228 }, 151), _0x4d571aba);
            this._0x8908920a();
        }
    }

    public int _0xd99795a1 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[8] { 220, 197, 204, 129, 216, 198, 193, 220 }, 175), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[8] { 138, 147, 154, 215, 142, 144, 151, 138 }, 249), value); }

    public void _0x8e61fb97()
    {
        PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[10] { 189, 164, 173, 224, 166, 175, 160, 170, 162, 171 }, 206), 1000 + Mathf.Abs(System.Environment.TickCount % 8999));
    }

    public int _0xac075e85 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 175, 182, 191, 242, 177, 175, 185, 185, 184 }, 220), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 133, 156, 149, 216, 155, 133, 147, 147, 146 }, 246), value); }

    // Wipes everything this game stored and restores an opening seat. Used by the one
    // destructive control in the settings sheet, behind a confirmation card.
    public void _0xf94f394d()
    {
        string[] _0xf851f584 =
        {
            _0x3df2fe28._0xbcb3638e(new byte[11] { 235, 242, 251, 182, 251, 234, 253, 252, 241, 236, 235 }, 152),
            _0x3df2fe28._0xbcb3638e(new byte[9] { 34, 59, 50, 127, 37, 48, 51, 61, 52 }, 81),
            _0x3df2fe28._0xbcb3638e(new byte[9] { 213, 204, 197, 136, 213, 210, 199, 205, 195 }, 166),
            _0x3df2fe28._0xbcb3638e(new byte[9] { 91, 66, 75, 6, 91, 88, 65, 70, 91 }, 40),
            _0x3df2fe28._0xbcb3638e(new byte[8] { 86, 79, 70, 11, 82, 76, 75, 86 }, 37),
            _0x3df2fe28._0xbcb3638e(new byte[12] { 207, 214, 223, 146, 222, 217, 207, 200, 208, 213, 210, 217 }, 188),
            _0x3df2fe28._0xbcb3638e(new byte[6] { 67, 90, 83, 30, 72, 64 }, 48),
            _0x3df2fe28._0xbcb3638e(new byte[9] { 62, 39, 46, 99, 46, 44, 63, 41, 62 }, 77),
            _0x3df2fe28._0xbcb3638e(new byte[13] { 211, 202, 195, 142, 199, 201, 198, 212, 142, 196, 193, 212, 197 }, 160),
            _0x3df2fe28._0xbcb3638e(new byte[15] { 210, 203, 194, 143, 198, 200, 199, 213, 143, 210, 213, 211, 196, 192, 202 }, 161),
            _0x3df2fe28._0xbcb3638e(new byte[10] { 222, 199, 206, 131, 197, 204, 195, 201, 193, 200 }, 173),
            _0x3df2fe28._0xbcb3638e(new byte[10] { 22, 15, 6, 75, 15, 10, 12, 11, 0, 1 }, 101),
            _0x3df2fe28._0xbcb3638e(new byte[11] { 211, 202, 195, 142, 214, 201, 194, 210, 193, 212, 197 }, 160),
            _0x3df2fe28._0xbcb3638e(new byte[10] { 76, 85, 92, 17, 82, 80, 75, 86, 80, 81 }, 63),
            _0x3df2fe28._0xbcb3638e(new byte[12] { 127, 102, 111, 34, 96, 105, 106, 120, 100, 109, 98, 104 }, 12),
            _0x3df2fe28._0xbcb3638e(new byte[11] { 89, 64, 73, 4, 89, 67, 94, 94, 67, 68, 77 }, 42),
            _0x3df2fe28._0xbcb3638e(new byte[11] { 78, 87, 94, 19, 75, 84, 78, 84, 73, 88, 89 }, 61),
            _0x3df2fe28._0xbcb3638e(new byte[9] { 125, 100, 109, 32, 105, 103, 104, 122, 125 }, 14),
            _0x3df2fe28._0xbcb3638e(new byte[11] { 8, 17, 24, 85, 24, 23, 30, 26, 9, 30, 31 }, 123),
            _0x3df2fe28._0xbcb3638e(new byte[8] { 0, 25, 16, 93, 30, 18, 0, 24 }, 115),
            _0x3df2fe28._0xbcb3638e(new byte[9] { 44, 53, 60, 113, 50, 44, 58, 58, 59 }, 95),
        };
        for (int _0xeaf3a2c0 = 0; _0xeaf3a2c0 < _0xf851f584.Length; _0xeaf3a2c0++)
        {
            PlayerPrefs.DeleteKey(_0xf851f584[_0xeaf3a2c0]);
        }

        for (int _0xddcf3da1 = 0; _0xddcf3da1 < _0xbbd798a9.MissionSlots; _0xddcf3da1++)
        {
            PlayerPrefs.DeleteKey(_0x3df2fe28._0xbcb3638e(new byte[6] { 156, 133, 140, 193, 130, 159 }, 239) + _0xddcf3da1.ToString());
            PlayerPrefs.DeleteKey(_0x3df2fe28._0xbcb3638e(new byte[6] { 162, 187, 178, 255, 188, 178 }, 209) + _0xddcf3da1.ToString());
        }

        this._0x9dfae2d8 = false;
        this._0x5292f2a5();
        this._0x55475292();
    }

    public int _0xa7c9bee8 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 203, 210, 219, 150, 219, 212, 221, 217, 202, 221, 220 }, 184), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 49, 40, 33, 108, 33, 46, 39, 35, 48, 39, 38 }, 66), value); }

    public bool _0x11358aac(int _0x62199612)
    {
        return PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[6] { 135, 158, 151, 218, 153, 151 }, 244) + _0x62199612.ToString(), 0) == 1;
    }

    public int _0xa9560cca { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[12] { 204, 213, 220, 145, 221, 218, 204, 203, 211, 214, 209, 218 }, 191), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[12] { 31, 6, 15, 66, 14, 9, 31, 24, 0, 5, 2, 9 }, 108), value); }
    // A bit per table, so "tables visited" is honest without a second list.
    public int _0x79c60d08 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 232, 241, 248, 181, 237, 242, 232, 242, 239, 254, 255 }, 155), 1); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 215, 206, 199, 138, 210, 205, 215, 205, 208, 193, 192 }, 164), value); }
    // --- preferences ----------------------------------------------------------
    public bool _0x1ac99480 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 209, 200, 193, 140, 212, 203, 192, 208, 195, 214, 199 }, 162), 1) == 1; set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 243, 234, 227, 174, 246, 233, 226, 242, 225, 244, 229 }, 128), value ? 1 : 0); }

    // --- mission card ---------------------------------------------------------
    public int _0x12812932(int _0x9109c60d)
    {
        return PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[6] { 0, 25, 16, 93, 30, 3 }, 115) + _0x9109c60d.ToString(), 0);
    }

    // The template keeps its own purse and redraws its counters from it, so the two are
    // kept in step rather than left to disagree on screen.
    private void _0x8908920a()
    {
        _0xa93ecf08._0xf0cc7cd1._0xc8557463 = PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 228, 253, 244, 185, 244, 229, 242, 243, 254, 227, 228 }, 151), _0xbbd798a9.StartCredits);
    }

    public void _0xae49789f(int _0x5b93ed9c)
    {
        this._0x79c60d08 = this._0x79c60d08 | (1 << _0x5b93ed9c);
    }

    public int _0x2c9bb801 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[15] { 203, 210, 219, 150, 223, 209, 222, 204, 150, 203, 204, 202, 221, 217, 211 }, 184), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[15] { 155, 130, 139, 198, 143, 129, 142, 156, 198, 155, 156, 154, 141, 137, 131 }, 232), value); }
    public string _0xbc48bfb6 => PlayerPrefs.GetString(_0x3df2fe28._0xbcb3638e(new byte[10] { 170, 179, 186, 247, 179, 182, 176, 183, 188, 189 }, 217), System.DateTime.Now.ToString(_0x3df2fe28._0xbcb3638e(new byte[10] { 194, 194, 194, 194, 150, 246, 246, 150, 223, 223 }, 187)));

    private bool _0x9dfae2d8;
    // --- lifetime figures -----------------------------------------------------
    public int _0xa6100c56 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 133, 156, 149, 216, 133, 134, 159, 152, 133 }, 246), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 25, 0, 9, 68, 25, 26, 3, 4, 25 }, 106), value); }

    public int _0x45319abc
    {
        get
        {
            int _0x9408fb8c = _0xdfaf60d5.At(this._0x97795416)._0xc24dddd0;
            int _0xd941b17e = PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 158, 135, 142, 195, 158, 153, 140, 134, 136 }, 237), _0x9408fb8c);
            return _0xd941b17e < _0x9408fb8c ? _0x9408fb8c : _0xd941b17e;
        }

        set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 52, 45, 36, 105, 52, 51, 38, 44, 34 }, 71), value);
    }

    public bool _0x54d74316 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[10] { 91, 66, 75, 6, 69, 71, 92, 65, 71, 70 }, 40), 0) == 1; set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[10] { 143, 150, 159, 210, 145, 147, 136, 149, 147, 146 }, 252), value ? 1 : 0); }

    public int _0x3134c85a
    {
        get
        {
            int _0x43d1c65e = this._0x79c60d08;
            int _0xc857e02c = 0;
            for (int _0x23873c47 = 0; _0x23873c47 < _0xdfaf60d5._0xc0c6bbec; _0x23873c47++)
            {
                if ((_0x43d1c65e & (1 << _0x23873c47)) != 0)
                {
                    _0xc857e02c++;
                }
            }

            return _0xc857e02c < 1 ? 1 : _0xc857e02c;
        }
    }

    // --- seat -----------------------------------------------------------------
    public int _0x97795416
    {
        get
        {
            int _0x62d4e25c = PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 78, 87, 94, 19, 73, 92, 95, 81, 88 }, 61), 0);
            return _0x62d4e25c < 0 ? 0 : (_0x62d4e25c >= _0xdfaf60d5._0xc0c6bbec ? _0xdfaf60d5._0xc0c6bbec - 1 : _0x62d4e25c);
        }

        set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 185, 160, 169, 228, 190, 171, 168, 166, 175 }, 202), value);
    }

    public int _0x6a89ca01 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 137, 144, 153, 212, 157, 147, 156, 142, 137 }, 250), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 151, 142, 135, 202, 131, 141, 130, 144, 151 }, 228), value); }

    public void _0x90bc098d(int _0x3580fe19, int _0xd61d9165)
    {
        PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[6] { 108, 117, 124, 49, 114, 111 }, 31) + _0x3580fe19.ToString(), _0xd61d9165 < 0 ? 0 : _0xd61d9165);
    }

    public _0xe54e0344 _0x5292f2a5()
    {
        if (this._0x9dfae2d8)
        {
            return this;
        }

        this._0x9dfae2d8 = true;
        if (!PlayerPrefs.HasKey(_0x3df2fe28._0xbcb3638e(new byte[11] { 30, 7, 14, 67, 14, 31, 8, 9, 4, 25, 30 }, 109)))
        {
            PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 0, 25, 16, 93, 16, 1, 22, 23, 26, 7, 0 }, 115), _0xbbd798a9.StartCredits);
            PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 159, 134, 143, 194, 159, 133, 152, 152, 133, 130, 139 }, 236), 0);
            PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[10] { 39, 62, 55, 122, 60, 53, 58, 48, 56, 49 }, 84), 1000 + Mathf.Abs(System.Environment.TickCount % 8999));
            PlayerPrefs.SetString(_0x3df2fe28._0xbcb3638e(new byte[10] { 25, 0, 9, 68, 0, 5, 3, 4, 15, 14 }, 106), System.DateTime.Now.ToString(_0x3df2fe28._0xbcb3638e(new byte[10] { 238, 238, 238, 238, 186, 218, 218, 186, 243, 243 }, 151)));
        }

        this._0x8908920a();
        return this;
    }

    public bool _0x73072a1c { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[12] { 212, 205, 196, 137, 203, 194, 193, 211, 207, 198, 201, 195 }, 167), 0) == 1; set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[12] { 12, 21, 28, 81, 19, 26, 25, 11, 23, 30, 17, 27 }, 127), value ? 1 : 0); }

    // --- housekeeping ---------------------------------------------------------
    public void _0x55475292()
    {
        PlayerPrefs.Save();
    }

    public int _0x75a6ad47 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[6] { 158, 135, 142, 195, 149, 157 }, 237), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[6] { 151, 142, 135, 202, 156, 148 }, 228), value); }
    // --- gallery --------------------------------------------------------------
    public int _0xdcb87af9 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 67, 90, 83, 30, 83, 81, 66, 84, 67 }, 48), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[9] { 143, 150, 159, 210, 159, 157, 142, 152, 143 }, 252), value); }
    public int _0x471e6ca6 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 176, 169, 160, 237, 176, 170, 183, 183, 170, 173, 164 }, 195), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[11] { 194, 219, 210, 159, 194, 216, 197, 197, 216, 223, 214 }, 177), value); }

    public void _0x3487bec5(int _0xa04fdcd1, bool _0x3058fef3)
    {
        PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[6] { 137, 144, 153, 212, 151, 153 }, 250) + _0xa04fdcd1.ToString(), _0x3058fef3 ? 1 : 0);
    }

    // --- guest ----------------------------------------------------------------
    public string _0x39f516fc => _0x3df2fe28._0xbcb3638e(new byte[6] { 186, 168, 184, 174, 169, 221 }, 253) + PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[10] { 94, 71, 78, 3, 69, 76, 67, 73, 65, 72 }, 45), 4471).ToString();
    public int _0x4eee2880 { get => PlayerPrefs.GetInt(_0x3df2fe28._0xbcb3638e(new byte[8] { 131, 154, 147, 222, 157, 145, 131, 155 }, 240), 0); set => PlayerPrefs.SetInt(_0x3df2fe28._0xbcb3638e(new byte[8] { 121, 96, 105, 36, 103, 107, 121, 97 }, 10), value); }
}

internal static class _0x3df2fe28
{
    internal static string _0xbcb3638e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}