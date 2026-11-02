using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// How to play, the paylines, the fair-play figures, the full paytable and the
/// responsible-play copy. The canvas holds two stacks of sheets and a toggle swaps
/// between them, so nothing has to scroll.
/// </summary>
public sealed class _0xdb51c6cb : MonoBehaviour, _0xeb461ae5
{
    private _0x51685ac3 _0x812ce7e9;
    private RectTransform _0xe7ad25b3;
    private bool _0x58e67c46;
    private const float SheetWidth = 1050f;
    public _0xdb51c6cb _0x11d992f2(_0x51685ac3 _0x1f0b8deb, _0x529d8e09 _0xd5f26ef0)
    {
        this._0x812ce7e9 = _0x1f0b8deb;
        this._0xb27ebce0 = _0xd5f26ef0;
        this._0x9867a7bf = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0x1f0b8deb, _0xaa4efdef._0xbd03a9f8(new byte[5] { 43, 44, 53, 60, 42 }, 121), true, () => _0xd5f26ef0._0xbda30b26());
        RectTransform _0x3f8bf6f9 = this._0x9867a7bf._0x81b31132;
        this._0x5e54133f = _0x211a051a.Stretch(_0x3f8bf6f9, _0xaa4efdef._0xbd03a9f8(new byte[6] { 115, 80, 66, 88, 82, 66 }, 49));
        this._0x73e003fd(this._0x5e54133f);
        this._0x9a16fc44(this._0x5e54133f);
        this._0x2b05b38c(this._0x5e54133f);
        this._0xe7ad25b3 = _0x211a051a.Stretch(_0x3f8bf6f9, _0xaa4efdef._0xbd03a9f8(new byte[5] { 74, 127, 124, 114, 123 }, 30));
        this._0x95a85de6(this._0xe7ad25b3);
        this._0x26a9f772(this._0xe7ad25b3);
        Button _0x9fd3447f = _0x211a051a.Action(_0x3f8bf6f9, _0xaa4efdef._0xbd03a9f8(new byte[6] { 227, 216, 208, 208, 219, 210 }, 183), _0x1f0b8deb._0x50577ddc, _0x1f0b8deb._0xcef53720, "", 34f, _0xdc7245d7.Scarlet, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.73f, 0.075f, 480f, 120f);
        this._0x136c2452 = _0x9fd3447f.GetComponentInChildren<TextMeshProUGUI>(true);
        _0x9fd3447f.onClick.AddListener(() => this._0x890c6535());
        Button _0x9d89d209 = _0x211a051a.Action(_0x3f8bf6f9, _0xaa4efdef._0xbd03a9f8(new byte[6] { 46, 15, 20, 9, 3, 5 }, 96), _0x1f0b8deb._0x50577ddc, _0x1f0b8deb._0xcef53720, _0xaa4efdef._0xbd03a9f8(new byte[15] { 4, 31, 24, 0, 119, 102, 111, 124, 119, 25, 24, 3, 30, 20, 18 }, 87), 32f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.GoldDark, _0xdc7245d7.Parchment, 0.27f, 0.075f, 520f, 120f);
        _0x9d89d209.onClick.AddListener(() => this._0xb27ebce0._0x9b79807d(_0x529d8e09.RouteAgeGate));
        this._0x0822014e();
        return this;
    }

    private void _0x890c6535()
    {
        this._0x58e67c46 = !this._0x58e67c46;
        this._0x0822014e();
    }

    private void _0x73e003fd(RectTransform _0xb7f44dc5)
    {
        RectTransform _0x91b39413 = _0x211a051a.Sheet(_0xb7f44dc5, _0xaa4efdef._0xbd03a9f8(new byte[5] { 224, 199, 223, 252, 199 }, 168), 0.5f, 0.835f, SheetWidth, 640f, this._0x812ce7e9._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.Gold, 10f);
        _0x211a051a.Label(_0x91b39413, _0xaa4efdef._0xbd03a9f8(new byte[7] { 23, 58, 62, 59, 54, 49, 56 }, 95), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[11] { 193, 198, 222, 169, 221, 198, 169, 217, 197, 200, 208 }, 137), 44f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.885f, 940f, 76f);
        for (int _0x8a31dfcb = 0; _0x8a31dfcb < _0x4b563ca7.RuleLineCount; _0x8a31dfcb++)
        {
            float _0x98e53920 = 0.70f - _0x8a31dfcb * 0.175f;
            _0x211a051a.Label(_0x91b39413, _0xaa4efdef._0xbd03a9f8(new byte[4] { 17, 52, 51, 56 }, 93), this._0x812ce7e9._0x50577ddc, _0x4b563ca7.HowToPlayLine(_0x8a31dfcb), 30f, _0xdc7245d7.TextPrimary, TextAlignmentOptions.Left, 0.5f, _0x98e53920, 940f, 96f);
        }
    }

    private _0x529d8e09 _0xb27ebce0;
    private RectTransform _0x5e54133f;
    private void _0x9f4a1da1(RectTransform _0xc4e668a5, int _0x8a8a319e, float _0xba99eabc)
    {
        RectTransform _0xaef00ddc = _0x211a051a.Box(_0xc4e668a5, _0xaa4efdef._0xbd03a9f8(new byte[6] { 122, 75, 83, 120, 69, 93 }, 42), 0.5f, _0xba99eabc, PayRowWidth, 100f);
        _0x211a051a.Picture(_0xaef00ddc, _0xaa4efdef._0xbd03a9f8(new byte[3] { 41, 26, 28 }, 104), this._0x812ce7e9._0xb6eb4455(_0x8a8a319e), 92f / PayRowWidth, 0.5f, 84f, 84f, Color.white);
        bool _0x3ee86412 = _0x8a8a319e == _0x80ffeb86.Jester;
        bool _0x723e5842 = _0x8a8a319e == _0x80ffeb86.Ticket;
        string _0x0191faec = _0x80ffeb86.NameOf(_0x8a8a319e);
        if (_0x3ee86412)
            _0x0191faec = _0x0191faec + _0xaa4efdef._0xbd03a9f8(new byte[38] { 210, 143, 145, 148, 156, 248, 245, 248, 139, 141, 154, 139, 140, 145, 140, 141, 140, 157, 139, 248, 153, 148, 148, 248, 154, 141, 140, 248, 140, 144, 157, 248, 140, 145, 155, 147, 157, 140 }, 216);
        else if (_0x723e5842)
            _0x0191faec = _0x0191faec + _0xaa4efdef._0xbd03a9f8(new byte[24] { 136, 209, 193, 195, 214, 214, 199, 208, 162, 175, 162, 210, 195, 219, 209, 162, 195, 204, 219, 213, 202, 199, 208, 199 }, 130);
        _0x211a051a.Label(_0xaef00ddc, _0xaa4efdef._0xbd03a9f8(new byte[4] { 60, 19, 31, 23 }, 114), this._0x812ce7e9._0x50577ddc, _0x0191faec, _0x3ee86412 || _0x723e5842 ? 28f : 34f, _0x3ee86412 || _0x723e5842 ? _0xdc7245d7.GoldLight : _0xdc7245d7.Parchment, TextAlignmentOptions.Left, 288f / PayRowWidth, 0.5f, 240f, 90f);
        int[] _0x3a6333f3 = _0x723e5842 ? new int[]
        {
            _0x80ffeb86.ScatterMultiplier(3),
            _0x80ffeb86.ScatterMultiplier(4),
            _0x80ffeb86.ScatterMultiplier(5)
        }

        : new int[]
        {
            _0x80ffeb86.Multiplier(_0x8a8a319e, 3),
            _0x80ffeb86.Multiplier(_0x8a8a319e, 4),
            _0x80ffeb86.Multiplier(_0x8a8a319e, 5)
        };
        float[] _0x551feb11 =
        {
            560f,
            720f,
            880f
        };
        for (int _0x30c5181b = 0; _0x30c5181b < 3; _0x30c5181b++)
            _0x211a051a.Label(_0xaef00ddc, _0xaa4efdef._0xbd03a9f8(new byte[3] { 196, 243, 254 }, 146), this._0x812ce7e9._0x50577ddc, _0x3a6333f3[_0x30c5181b].ToString(), 34f, _0x3ee86412 ? _0xdc7245d7.GoldLight : _0xdc7245d7.Gold, TextAlignmentOptions.Center, _0x551feb11[_0x30c5181b] / PayRowWidth, 0.5f, 140f, 60f);
    }

    private void _0x0822014e()
    {
        this._0x5e54133f.gameObject.SetActive(!this._0x58e67c46);
        this._0xe7ad25b3.gameObject.SetActive(this._0x58e67c46);
        if (this._0x136c2452 != null)
        {
            this._0x136c2452.text = this._0x58e67c46 ? _0xaa4efdef._0xbd03a9f8(new byte[11] { 42, 45, 53, 66, 54, 45, 66, 50, 46, 35, 59 }, 98) : _0xaa4efdef._0xbd03a9f8(new byte[8] { 170, 187, 163, 174, 187, 184, 182, 191 }, 250);
            _0xf9bbd821.ApplyOutline(this._0x136c2452);
        }

        if (this._0x9867a7bf != null)
            this._0x9867a7bf._0xd8c998fc(this._0x58e67c46 ? _0xaa4efdef._0xbd03a9f8(new byte[8] { 128, 145, 137, 132, 145, 146, 156, 149 }, 208) : _0xaa4efdef._0xbd03a9f8(new byte[5] { 175, 168, 177, 184, 174 }, 253));
    }

    public void Tick()
    {
    }

    public void Enter()
    {
        if (this._0x9867a7bf != null)
            this._0x9867a7bf.Enter();
        this._0x0822014e();
    }

    private void _0x9a16fc44(RectTransform _0xcca6069c)
    {
        RectTransform _0xc3109895 = _0x211a051a.Sheet(_0xcca6069c, _0xaa4efdef._0xbd03a9f8(new byte[8] { 98, 83, 75, 94, 91, 92, 87, 65 }, 50), 0.5f, 0.590f, SheetWidth, 300f, this._0x812ce7e9._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.GoldDark, 10f);
        _0x211a051a.Label(_0xc3109895, _0xaa4efdef._0xbd03a9f8(new byte[7] { 14, 35, 39, 34, 47, 40, 33 }, 70), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[19] { 164, 171, 180, 167, 194, 164, 171, 186, 167, 166, 194, 178, 163, 187, 174, 171, 172, 167, 177 }, 226), 36f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.86f, 940f, 60f);
        RectTransform _0x5d45a0ca = _0x211a051a.Box(_0xc3109895, _0xaa4efdef._0xbd03a9f8(new byte[5] { 245, 210, 212, 207, 214 }, 166), 0.5f, 0.42f, 930f, 170f);
        for (int _0x8539c4d5 = 0; _0x8539c4d5 < _0x80ffeb86.LineCount; _0x8539c4d5++)
        {
            float _0xf9dcff5c = (85f + _0x8539c4d5 * 190f) / 930f;
            RectTransform _0x9b291c1b = _0x211a051a.Box(_0x5d45a0ca, _0xaa4efdef._0xbd03a9f8(new byte[4] { 182, 146, 149, 146 }, 251), _0xf9dcff5c, 0.52f, 170f, 100f);
            int[] _0xa6aa1935 = _0x80ffeb86.LineRows(_0x8539c4d5);
            for (int _0xaa84ea92 = 0; _0xaa84ea92 < _0x80ffeb86.Reels; _0xaa84ea92++)
                for (int _0xf5ba3700 = 0; _0xf5ba3700 < _0x80ffeb86.Rows; _0xf5ba3700++)
                {
                    float _0x32697c26 = (15f + _0xaa84ea92 * 35f) / 170f;
                    float _0xd1803ee0 = (100f - 15f - _0xf5ba3700 * 35f) / 100f;
                    bool _0x03bf1a98 = _0xa6aa1935[_0xaa84ea92] == _0xf5ba3700;
                    RectTransform _0xba46b02e = _0x211a051a.Box(_0x9b291c1b, _0xaa4efdef._0xbd03a9f8(new byte[4] { 28, 58, 51, 51 }, 95), _0x32697c26, _0xd1803ee0, 30f, 30f);
                    Image _0x0419c377 = _0xba46b02e.gameObject.AddComponent<Image>();
                    _0x0419c377.sprite = this._0x812ce7e9._0x9bc213f0;
                    _0x0419c377.type = this._0x812ce7e9._0x9bc213f0 == null ? Image.Type.Simple : Image.Type.Sliced;
                    _0x0419c377.color = _0x03bf1a98 ? _0xdc7245d7.Gold : _0xdc7245d7.BgTertiary;
                    _0x0419c377.raycastTarget = false;
                    _0x0419c377.pixelsPerUnitMultiplier = 6f;
                    _0x211a051a.Slice(_0x0419c377, 6f);
                }

            _0x211a051a.Label(_0x9b291c1b, _0xaa4efdef._0xbd03a9f8(new byte[3] { 184, 131, 155 }, 246), this._0x812ce7e9._0x50577ddc, (_0x8539c4d5 + 1).ToString(), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, -0.22f, 170f, 44f);
        }
    }

    private TextMeshProUGUI _0x136c2452;
    private const float PayRowWidth = 1050f;
    private void _0x2b05b38c(RectTransform _0x143a5a82)
    {
        RectTransform _0x27772547 = _0x211a051a.Sheet(_0x143a5a82, _0xaa4efdef._0xbd03a9f8(new byte[8] { 15, 40, 32, 59, 25, 37, 40, 48 }, 73), 0.5f, 0.370f, SheetWidth, 380f, this._0x812ce7e9._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.GoldDark, 10f);
        _0x211a051a.Label(_0x27772547, _0xaa4efdef._0xbd03a9f8(new byte[7] { 239, 194, 198, 195, 206, 201, 192 }, 167), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[9] { 226, 229, 237, 246, 132, 244, 232, 229, 253 }, 164), 40f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.84f, 940f, 66f);
        _0x211a051a.Label(_0x27772547, _0xaa4efdef._0xbd03a9f8(new byte[1] { 1 }, 64), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[22] { 186, 173, 188, 189, 186, 166, 200, 188, 167, 200, 184, 164, 169, 177, 173, 186, 200, 209, 217, 198, 220, 205 }, 232), 34f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.58f, 940f, 60f);
        _0x211a051a.Label(_0x27772547, _0xaa4efdef._0xbd03a9f8(new byte[1] { 250 }, 184), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[25] { 219, 200, 219, 204, 199, 190, 205, 206, 215, 208, 190, 215, 205, 190, 215, 208, 218, 219, 206, 219, 208, 218, 219, 208, 202 }, 158), 32f, _0xdc7245d7.TextPrimary, TextAlignmentOptions.Center, 0.5f, 0.38f, 940f, 56f);
        _0x211a051a.Label(_0x27772547, _0xaa4efdef._0xbd03a9f8(new byte[1] { 180 }, 247), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[27] { 64, 92, 81, 52, 92, 91, 65, 71, 81, 52, 90, 81, 66, 81, 70, 52, 87, 92, 85, 70, 83, 81, 71, 52, 77, 91, 65 }, 20), 32f, _0xdc7245d7.TextPrimary, TextAlignmentOptions.Center, 0.5f, 0.18f, 940f, 56f);
    }

    private void _0x95a85de6(RectTransform _0x5e7f3d72)
    {
        RectTransform _0xc1d0722f = _0x211a051a.Sheet(_0x5e7f3d72, _0xaa4efdef._0xbd03a9f8(new byte[8] { 43, 26, 2, 15, 26, 25, 23, 30 }, 123), 0.5f, 0.690f, SheetWidth, 1240f, this._0x812ce7e9._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.Gold, 10f);
        _0x211a051a.Label(_0xc1d0722f, _0xaa4efdef._0xbd03a9f8(new byte[7] { 60, 17, 21, 16, 29, 26, 19 }, 116), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[8] { 194, 211, 203, 198, 211, 208, 222, 215 }, 146), 44f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.955f, 940f, 70f);
        RectTransform _0x591f6af6 = _0x211a051a.Box(_0xc1d0722f, _0xaa4efdef._0xbd03a9f8(new byte[6] { 255, 210, 214, 211, 210, 197 }, 183), 0.5f, 0.895f, PayRowWidth, 60f);
        _0x211a051a.Label(_0x591f6af6, _0xaa4efdef._0xbd03a9f8(new byte[2] { 47, 84 }, 103), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[1] { 112 }, 67), 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 560f / PayRowWidth, 0.5f, 140f, 50f);
        _0x211a051a.Label(_0x591f6af6, _0xaa4efdef._0xbd03a9f8(new byte[2] { 252, 128 }, 180), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[1] { 53 }, 1), 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 720f / PayRowWidth, 0.5f, 140f, 50f);
        _0x211a051a.Label(_0x591f6af6, _0xaa4efdef._0xbd03a9f8(new byte[2] { 80, 45 }, 24), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[1] { 250 }, 207), 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 880f / PayRowWidth, 0.5f, 140f, 50f);
        _0x211a051a.Label(_0x591f6af6, _0xaa4efdef._0xbd03a9f8(new byte[2] { 51, 53 }, 123), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[16] { 198, 215, 207, 197, 182, 238, 182, 194, 217, 194, 215, 218, 182, 212, 211, 194 }, 150), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Left, 288f / PayRowWidth, 0.5f, 240f, 50f);
        for (int _0x1350390e = 0; _0x1350390e < _0x80ffeb86.SymbolCount; _0x1350390e++)
        {
            float _0x17d1e39e = (1240f - 220f - _0x1350390e * 108f) / 1240f;
            this._0x9f4a1da1(_0xc1d0722f, _0x1350390e, _0x17d1e39e);
        }
    }

    private void _0x26a9f772(RectTransform _0x9bd5779e)
    {
        RectTransform _0xe9191ddd = _0x211a051a.Sheet(_0x9bd5779e, _0xaa4efdef._0xbd03a9f8(new byte[11] { 156, 171, 189, 190, 161, 160, 189, 167, 172, 162, 171 }, 206), 0.5f, 0.255f, SheetWidth, 480f, this._0x812ce7e9._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.GoldDark, 10f);
        _0x211a051a.Label(_0xe9191ddd, _0xaa4efdef._0xbd03a9f8(new byte[7] { 153, 180, 176, 181, 184, 191, 182 }, 209), this._0x812ce7e9._0x50577ddc, _0xaa4efdef._0xbd03a9f8(new byte[16] { 96, 119, 97, 98, 125, 124, 97, 123, 112, 126, 119, 18, 98, 126, 115, 107 }, 50), 38f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.88f, 940f, 62f);
        for (int _0x92798245 = 0; _0x92798245 < 4; _0x92798245++)
        {
            float _0x34a620d8 = 0.665f - _0x92798245 * 0.185f;
            _0x211a051a.Label(_0xe9191ddd, _0xaa4efdef._0xbd03a9f8(new byte[4] { 88, 125, 122, 113 }, 20), this._0x812ce7e9._0x50577ddc, _0x4b563ca7.ComplianceLine(_0x92798245), 28f, _0xdc7245d7.TextPrimary, TextAlignmentOptions.Center, 0.5f, _0x34a620d8, 940f, 80f);
        }
    }

    private _0x25979831 _0x9867a7bf;
    public RectTransform Root
    {
        get
        {
            return this._0x9867a7bf == null ? null : this._0x9867a7bf._0x10966145;
        }
    }
}

internal static class _0xaa4efdef
{
    internal static string _0xbd03a9f8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}