using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Club level, experience and the lifetime record. A statistic with no data shows a dash
/// rather than a zero, and when fewer than two of them have data the whole grid is
/// replaced by a line that says what to do about it.
/// </summary>
public sealed class _0xd912281d : MonoBehaviour, _0xeb461ae5
{
    public RectTransform Root
    {
        get
        {
            return this._0x2bd2ad6d == null ? null : this._0x2bd2ad6d._0x10966145;
        }
    }

    private RectTransform _0x01f31cf5;
    private const int CardCount = 4;
    private void _0xa5271ea2(RectTransform _0xd5682da9, int _0x3f2bad5a, float _0x5cd6b212, float _0x9549d081)
    {
        RectTransform _0xb0bf96ce = _0x211a051a.Box(_0xd5682da9, _0x6968edb1._0x0b7ff8ba(new byte[4] { 205, 239, 252, 234 }, 142), _0x5cd6b212, _0x9549d081, CardWidth, CardHeight);
        _0x211a051a.Plate(_0xb0bf96ce, _0x6968edb1._0x0b7ff8ba(new byte[5] { 126, 74, 89, 85, 93 }, 56), this._0x8811199e._0xcef53720, _0xdc7245d7.GoldDark, 2.2f);
        RectTransform _0x82ef4c15 = _0x211a051a.Node(_0xb0bf96ce, _0x6968edb1._0x0b7ff8ba(new byte[5] { 122, 93, 93, 86, 65 }, 51), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
        _0x211a051a.Plate(_0x82ef4c15, _0x6968edb1._0x0b7ff8ba(new byte[4] { 136, 167, 162, 162 }, 206), this._0x8811199e._0xcef53720, _0xdc7245d7.PanelBase, 2.4f);
        RectTransform _0xa1bd9d06 = _0x211a051a.Box(_0xb0bf96ce, _0x6968edb1._0x0b7ff8ba(new byte[6] { 22, 52, 52, 50, 57, 35 }, 87), 46f / CardWidth, 0.5f, 12f, 120f);
        Image _0xed974a4c = _0xa1bd9d06.gameObject.AddComponent<Image>();
        _0xed974a4c.sprite = this._0x8811199e._0x9bc213f0;
        _0xed974a4c.type = this._0x8811199e._0x9bc213f0 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xed974a4c.color = this._0x1ba4cfb8(_0x3f2bad5a);
        _0xed974a4c.raycastTarget = false;
        _0xed974a4c.pixelsPerUnitMultiplier = 8f;
        _0x211a051a.Slice(_0xed974a4c, 8f);
        this._0xc21ef0db[_0x3f2bad5a] = _0x211a051a.Label(_0xb0bf96ce, _0x6968edb1._0x0b7ff8ba(new byte[5] { 121, 78, 67, 90, 74 }, 47), this._0x8811199e._0x50577ddc, _0x6968edb1._0x0b7ff8ba(new byte[1] { 218 }, 247), 60f, this._0x1ba4cfb8(_0x3f2bad5a), TextAlignmentOptions.Left, CardTextX, 0.64f, 374f, 86f);
        _0x211a051a.Label(_0xb0bf96ce, _0x6968edb1._0x0b7ff8ba(new byte[5] { 201, 228, 231, 224, 233 }, 133), this._0x8811199e._0x50577ddc, _0x7e0b3afd[_0x3f2bad5a], 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Left, CardTextX, 0.26f, 374f, 46f);
    }

    private Image _0xc7178e3b;
    private void _0xe996f416()
    {
        int _0x9fb57f37 = _0x0331a644._0xac075e85;
        this._0x91dda601.text = _0x9fb57f37.ToString();
        int _0x7b72c725 = _0x0331a644.XpForLevel(_0x9fb57f37);
        this._0xac14022a.text = _0x0331a644.Money(_0x0331a644._0x73072a1c) + _0x6968edb1._0x0b7ff8ba(new byte[3] { 148, 155, 148 }, 180) + _0x0331a644.Money(_0x7b72c725) + _0x6968edb1._0x0b7ff8ba(new byte[3] { 88, 32, 40 }, 120);
        _0x211a051a.SetBar(this._0xc7178e3b, _0x7b72c725 <= 0 ? 0f : _0x0331a644._0x73072a1c / (float)_0x7b72c725, XpBarWidth);
        int _0xfce9071b = -1;
        for (int _0xfc35b876 = 0; _0xfc35b876 < _0x0331a644.TrinketCount; _0xfc35b876++)
            if (!_0x0331a644.TrinketUnlocked(_0xfc35b876))
            {
                _0xfce9071b = _0xfc35b876;
                break;
            }

        if (_0xfce9071b < 0)
        {
            this._0x89dc0598.sprite = this._0x8811199e._0xc24dddd0;
            this._0xeccc5ad6.text = _0x6968edb1._0x0b7ff8ba(new byte[21] { 105, 122, 105, 126, 117, 12, 111, 121, 126, 101, 99, 12, 101, 127, 12, 124, 101, 98, 98, 105, 104 }, 44);
            this._0x56287b80.text = _0x6968edb1._0x0b7ff8ba(new byte[16] { 208, 204, 193, 164, 211, 197, 200, 200, 164, 205, 215, 164, 194, 209, 200, 200 }, 132);
        }
        else
        {
            this._0x89dc0598.sprite = this._0x8811199e._0xed029fc3(_0xfce9071b);
            this._0xeccc5ad6.text = _0x4b563ca7.TrinketName(_0xfce9071b);
            this._0x56287b80.text = _0xfce9071b == _0x0331a644.TrinketCount - 1 ? _0x6968edb1._0x0b7ff8ba(new byte[23] { 114, 100, 119, 100, 111, 1, 111, 104, 102, 105, 117, 1, 102, 104, 103, 117, 1, 114, 117, 115, 100, 96, 106 }, 33) : _0x6968edb1._0x0b7ff8ba(new byte[17] { 210, 197, 193, 195, 200, 197, 211, 160, 193, 212, 160, 204, 197, 214, 197, 204, 160 }, 128) + _0x0331a644.TrinketRequirement(_0xfce9071b);
        }

        this._0x89dc0598.enabled = this._0x89dc0598.sprite != null;
        _0xf9bbd821.ApplyOutline(this._0xeccc5ad6);
        _0xf9bbd821.ApplyOutline(this._0x56287b80);
        int[] _0x3e47e0b4 =
        {
            _0x0331a644._0xa0cd89da,
            _0x0331a644._0xb6850feb,
            _0x0331a644._0x23512045,
            _0x0331a644._0xd7110322
        };
        int _0x096eff40 = 0;
        for (int _0x0d0c020c = 0; _0x0d0c020c < CardCount; _0x0d0c020c++)
            if (_0x3e47e0b4[_0x0d0c020c] > 0)
                _0x096eff40++;
        bool _0x7af55869 = _0x096eff40 >= 2;
        this._0x01f31cf5.gameObject.SetActive(_0x7af55869);
        this._0x7e0a1dbd.gameObject.SetActive(!_0x7af55869);
        if (!_0x7af55869)
            return;
        for (int _0xdb98c419 = 0; _0xdb98c419 < CardCount; _0xdb98c419++)
        {
            bool _0xb220ad69 = _0x3e47e0b4[_0xdb98c419] > 0;
            this._0xc21ef0db[_0xdb98c419].text = _0xb220ad69 ? _0x0331a644.Money(_0x3e47e0b4[_0xdb98c419]) : _0x6968edb1._0x0b7ff8ba(new byte[1] { 92 }, 113);
            this._0xc21ef0db[_0xdb98c419].color = _0xb220ad69 ? this._0x1ba4cfb8(_0xdb98c419) : _0xdc7245d7.TextMuted;
            _0xf9bbd821.ApplyOutline(this._0xc21ef0db[_0xdb98c419]);
        }
    }

    private TextMeshProUGUI _0xeccc5ad6;
    private const float CardTextX = 289f / CardWidth;
    private static readonly string[] _0x7e0b3afd =
    {
        _0x6968edb1._0x0b7ff8ba(new byte[11] { 106, 113, 106, 127, 114, 30, 109, 110, 119, 112, 109 }, 62),
        _0x6968edb1._0x0b7ff8ba(new byte[8] { 159, 152, 142, 137, 253, 138, 148, 147 }, 221),
        _0x6968edb1._0x0b7ff8ba(new byte[14] { 70, 69, 68, 77, 79, 89, 94, 42, 89, 94, 88, 79, 75, 65 }, 10),
        _0x6968edb1._0x0b7ff8ba(new byte[11] { 221, 216, 192, 202, 185, 201, 213, 216, 192, 220, 221 }, 153)
    };
    public void Enter()
    {
        this._0xe996f416();
        if (this._0x2bd2ad6d != null)
            this._0x2bd2ad6d.Enter();
    }

    public void Tick()
    {
    }

    private const float CardHeight = 180f;
    private readonly TextMeshProUGUI[] _0xc21ef0db = new TextMeshProUGUI[CardCount];
    private TextMeshProUGUI _0x91dda601;
    private _0x51685ac3 _0x8811199e;
    private TextMeshProUGUI _0xac14022a;
    private Image _0x89dc0598;
    private Color _0x1ba4cfb8(int _0xaa73dc86)
    {
        if (_0xaa73dc86 == 1)
            return _0xdc7245d7.Jackpot;
        if (_0xaa73dc86 == 2)
            return _0xdc7245d7.StatusWin;
        if (_0xaa73dc86 == 3)
            return _0xdc7245d7.GoldLight;
        return _0xdc7245d7.Gold;
    }

    private TextMeshProUGUI _0x56287b80;
    private const float CardWidth = 500f;
    public _0xd912281d _0xa8d08ba3(_0x51685ac3 _0x6adff278, _0x529d8e09 _0x3a55dec1)
    {
        this._0x8811199e = _0x6adff278;
        this._0x2bd2ad6d = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0x6adff278, _0x6968edb1._0x0b7ff8ba(new byte[8] { 72, 74, 87, 95, 74, 93, 75, 75 }, 24), true, () => _0x3a55dec1._0xbda30b26());
        RectTransform _0x558a9ae8 = this._0x2bd2ad6d._0x81b31132;
        RectTransform _0x126d30f1 = _0x211a051a.Box(_0x558a9ae8, _0x6968edb1._0x0b7ff8ba(new byte[4] { 55, 12, 11, 2 }, 101), 0.5f, 0.800f, 420f, 420f);
        _0x211a051a.Plate(_0x126d30f1, _0x6968edb1._0x0b7ff8ba(new byte[5] { 112, 74, 75, 90, 77 }, 63), _0x6adff278._0xf4df0193, _0xdc7245d7.Gold, 1.4f);
        RectTransform _0x142fefa6 = _0x211a051a.Node(_0x126d30f1, _0x6968edb1._0x0b7ff8ba(new byte[5] { 169, 142, 142, 133, 146 }, 224), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-26f, -26f));
        _0x211a051a.Plate(_0x142fefa6, _0x6968edb1._0x0b7ff8ba(new byte[4] { 247, 216, 221, 221 }, 177), _0x6adff278._0xf4df0193, _0xdc7245d7.BgTertiary, 1.6f);
        this._0x91dda601 = _0x211a051a.Label(_0x126d30f1, _0x6968edb1._0x0b7ff8ba(new byte[5] { 183, 158, 141, 158, 151 }, 251), _0x6adff278._0x50577ddc, _0x6968edb1._0x0b7ff8ba(new byte[1] { 251 }, 202), 96f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.56f, 320f, 150f);
        _0x211a051a.Label(_0x126d30f1, _0x6968edb1._0x0b7ff8ba(new byte[7] { 5, 39, 54, 50, 47, 41, 40 }, 70), _0x6adff278._0x50577ddc, _0x6968edb1._0x0b7ff8ba(new byte[11] { 74, 77, 87, 81, 71, 34, 78, 71, 84, 71, 78 }, 2), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.26f, 320f, 50f);
        this._0xac14022a = _0x211a051a.Label(_0x558a9ae8, _0x6968edb1._0x0b7ff8ba(new byte[6] { 6, 46, 10, 59, 38, 42 }, 94), _0x6adff278._0x50577ddc, "", 32f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.615f, 940f, 56f);
        this._0xc7178e3b = _0x211a051a.Bar(_0x558a9ae8, _0x6968edb1._0x0b7ff8ba(new byte[5] { 43, 3, 49, 18, 1 }, 115), _0x6adff278._0x9bc213f0, 0.5f, 0.572f, XpBarWidth, 28f, _0xdc7245d7.BgTertiary, _0xdc7245d7.Gold);
        RectTransform _0xb381c696 = _0x211a051a.Sheet(_0x558a9ae8, _0x6968edb1._0x0b7ff8ba(new byte[10] { 202, 225, 252, 240, 209, 234, 232, 235, 231, 239 }, 132), 0.5f, 0.452f, 1050f, 200f, _0x6adff278._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.GoldDark, 10f);
        _0x211a051a.Label(_0xb381c696, _0x6968edb1._0x0b7ff8ba(new byte[6] { 73, 107, 97, 105, 103, 112 }, 2), _0x6adff278._0x50577ddc, _0x6968edb1._0x0b7ff8ba(new byte[11] { 212, 223, 194, 206, 186, 207, 212, 214, 213, 217, 209 }, 154), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Left, 538f / 1050f, 0.80f, 740f, 46f);
        this._0x89dc0598 = _0x211a051a.Picture(_0xb381c696, _0x6968edb1._0x0b7ff8ba(new byte[3] { 106, 89, 95 }, 43), _0x6adff278._0x81e6d18e, 92f / 1050f, 0.5f, 110f, 110f, Color.white);
        this._0xeccc5ad6 = _0x211a051a.Label(_0xb381c696, _0x6968edb1._0x0b7ff8ba(new byte[4] { 64, 111, 99, 107 }, 14), _0x6adff278._0x50577ddc, "", 38f, _0xdc7245d7.Parchment, TextAlignmentOptions.Left, 538f / 1050f, 0.50f, 740f, 58f);
        this._0x56287b80 = _0x211a051a.Label(_0xb381c696, _0x6968edb1._0x0b7ff8ba(new byte[4] { 218, 241, 241, 240 }, 148), _0x6adff278._0x50577ddc, "", 30f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Left, 538f / 1050f, 0.20f, 740f, 48f);
        this._0x01f31cf5 = _0x211a051a.Box(_0x558a9ae8, _0x6968edb1._0x0b7ff8ba(new byte[5] { 16, 50, 33, 55, 32 }, 83), 0.5f, 0.215f, 1050f, 400f);
        for (int _0x665ee946 = 0; _0x665ee946 < CardCount; _0x665ee946++)
        {
            int _0x608663dc = _0x665ee946 / 2;
            int _0x5de457ef = _0x665ee946 % 2;
            float _0x4b8fb555 = (265f + _0x5de457ef * 520f) / 1050f;
            float _0x29165cd2 = (400f - 20f - CardHeight * 0.5f - _0x608663dc * (CardHeight + 30f)) / 400f;
            this._0xa5271ea2(this._0x01f31cf5, _0x665ee946, _0x4b8fb555, _0x29165cd2);
        }

        this._0x7e0a1dbd = _0x211a051a.Box(_0x558a9ae8, _0x6968edb1._0x0b7ff8ba(new byte[9] { 17, 57, 36, 32, 45, 24, 61, 58, 49 }, 84), 0.5f, 0.215f, 1050f, 200f);
        _0x211a051a.Fill(this._0x7e0a1dbd, _0x6968edb1._0x0b7ff8ba(new byte[4] { 83, 127, 96, 105 }, 16), _0x6adff278._0x50577ddc, _0x6968edb1._0x0b7ff8ba(new byte[33] { 207, 211, 222, 198, 191, 222, 191, 205, 208, 202, 209, 219, 191, 203, 208, 191, 204, 203, 222, 205, 203, 191, 198, 208, 202, 205, 191, 205, 218, 220, 208, 205, 219 }, 159), 36f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 20f);
        return this;
    }

    private const float XpBarWidth = 940f;
    private _0x25979831 _0x2bd2ad6d;
    private RectTransform _0x7e0a1dbd;
}

internal static class _0x6968edb1
{
    internal static string _0x0b7ff8ba(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}