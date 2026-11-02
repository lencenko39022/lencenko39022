using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game library: four stages of the same house. A stage changes the room - backdrop
/// tint, drape colour and bet range - never the maths, so the published return stays
/// true whichever stage is picked.
/// </summary>
public sealed class _0x3cb547e5 : MonoBehaviour, _0xeb461ae5
{
    private void _0xe56e1900(RectTransform _0x8cb1bb35, int _0xd1524edd, float _0x8d6786b0)
    {
        RectTransform _0xad07c457 = _0x211a051a.Box(_0x8cb1bb35, _0xc17d5e88._0x80a09dc8(new byte[3] { 13, 48, 40 }, 95), 0.5f, _0x8d6786b0, RowWidth, RowHeight);
        this._0x3a82e70a[_0xd1524edd] = _0xad07c457;
        Image _0xca0f8cdf = _0x211a051a.Plate(_0xad07c457, _0xc17d5e88._0x80a09dc8(new byte[5] { 237, 217, 202, 198, 206 }, 171), this._0xf37238ea._0xcef53720, _0xdc7245d7.GoldDark, 2.2f);
        _0xca0f8cdf.raycastTarget = true;
        this._0x10d7e45d[_0xd1524edd] = _0xca0f8cdf;
        RectTransform _0xffe58bca = _0x211a051a.Node(_0xad07c457, _0xc17d5e88._0x80a09dc8(new byte[5] { 49, 22, 22, 29, 10 }, 120), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-10f, -10f));
        _0x211a051a.Plate(_0xffe58bca, _0xc17d5e88._0x80a09dc8(new byte[4] { 116, 91, 94, 94 }, 50), this._0xf37238ea._0xcef53720, _0xdc7245d7.PanelBase, 2.4f);
        _0x211a051a.Picture(_0xad07c457, _0xc17d5e88._0x80a09dc8(new byte[3] { 201, 250, 252 }, 136), this._0xf37238ea._0xf6fcdc90(_0xd1524edd), 92f / RowWidth, 0.5f, 110f, 110f, Color.white);
        this._0x7dde8dda[_0xd1524edd] = _0x211a051a.Label(_0xad07c457, _0xc17d5e88._0x80a09dc8(new byte[4] { 128, 175, 163, 171 }, 206), this._0xf37238ea._0x50577ddc, _0x4b563ca7.StageName(_0xd1524edd), 40f, _0xdc7245d7.Parchment, TextAlignmentOptions.Left, TextX, 0.72f, TextWidth, 62f);
        _0x211a051a.Label(_0xad07c457, _0xc17d5e88._0x80a09dc8(new byte[5] { 213, 251, 226, 229, 245 }, 151), this._0xf37238ea._0x50577ddc, _0x4b563ca7.StageBlurb(_0xd1524edd), 32f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Left, TextX, 0.46f, TextWidth, 54f);
        this._0xbec46d24[_0xd1524edd] = _0x211a051a.Label(_0xad07c457, _0xc17d5e88._0x80a09dc8(new byte[5] { 221, 238, 225, 232, 234 }, 143), this._0xf37238ea._0x50577ddc, "", 28f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Left, TextX, 0.20f, TextWidth, 48f);
        this._0x1fe0a4b4[_0xd1524edd] = _0x211a051a.Picture(_0xad07c457, _0xc17d5e88._0x80a09dc8(new byte[4] { 118, 90, 73, 80 }, 59), this._0xf37238ea._0xc24dddd0, 980f / RowWidth, 0.5f, 64f, 64f, _0xdc7245d7.Gold);
        Button _0x11fee21c = _0xad07c457.gameObject.AddComponent<Button>();
        _0x11fee21c.targetGraphic = _0xca0f8cdf;
        int _0xb5065523 = _0xd1524edd;
        _0x11fee21c.onClick.AddListener(() => this._0x67047806(_0xb5065523));
    }

    public void Enter()
    {
        this._0x739b51c2();
        if (this._0x2fc4aab6 != null)
            this._0x2fc4aab6.Enter();
    }

    private readonly TextMeshProUGUI[] _0xbec46d24 = new TextMeshProUGUI[_0x4b563ca7.StageCount];
    private readonly Image[] _0x10d7e45d = new Image[_0x4b563ca7.StageCount];
    private const float RowHeight = 240f;
    private void OnDestroy()
    {
        for (int _0xc835d813 = 0; _0xc835d813 < this._0x3a82e70a.Length; _0xc835d813++)
            if (this._0x3a82e70a[_0xc835d813] != null)
                DOTween.Kill(this._0x3a82e70a[_0xc835d813]);
    }

    public _0x3cb547e5 _0x863c5bec(_0x51685ac3 _0xfc1cce5c, _0x529d8e09 _0x4c42bb27)
    {
        this._0xf37238ea = _0xfc1cce5c;
        this._0x9dfae2d8 = _0x4c42bb27;
        this._0x2fc4aab6 = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0xfc1cce5c, _0xc17d5e88._0x80a09dc8(new byte[12] { 98, 100, 104, 96, 5, 105, 108, 103, 119, 100, 119, 124 }, 37), true, () => _0x4c42bb27._0xbda30b26());
        RectTransform _0xf14e69dd = this._0x2fc4aab6._0x81b31132;
        RectTransform _0xa5b4398c = _0x211a051a.Box(_0xf14e69dd, _0xc17d5e88._0x80a09dc8(new byte[4] { 129, 188, 164, 160 }, 211), 0.5f, 0.62f, RowWidth, 1080f);
        for (int _0x720d2a30 = 0; _0x720d2a30 < _0x4b563ca7.StageCount; _0x720d2a30++)
        {
            float _0x08b1e447 = (1080f - 120f - _0x720d2a30 * 280f) / 1080f;
            this._0xe56e1900(_0xa5b4398c, _0x720d2a30, _0x08b1e447);
        }

        _0x211a051a.Label(_0xf14e69dd, _0xc17d5e88._0x80a09dc8(new byte[4] { 125, 92, 91, 65 }, 53), _0xfc1cce5c._0x50577ddc, _0xc17d5e88._0x80a09dc8(new byte[32] { 55, 53, 40, 63, 90, 41, 46, 59, 61, 63, 41, 90, 53, 42, 63, 52, 90, 59, 41, 90, 35, 53, 47, 90, 54, 63, 44, 63, 54, 90, 47, 42 }, 122), 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.10f, 1050f, 60f);
        return this;
    }

    private readonly RectTransform[] _0x3a82e70a = new RectTransform[_0x4b563ca7.StageCount];
    private readonly Image[] _0x1fe0a4b4 = new Image[_0x4b563ca7.StageCount];
    private const float TextWidth = 740f;
    private readonly TextMeshProUGUI[] _0x7dde8dda = new TextMeshProUGUI[_0x4b563ca7.StageCount];
    private _0x25979831 _0x2fc4aab6;
    public void Tick()
    {
    }

    private void _0x739b51c2()
    {
        int _0xb3e5b825 = Mathf.Clamp(_0x0331a644._0xb9e14fc1, 0, _0x4b563ca7.StageCount - 1);
        for (int _0xe13fd7de = 0; _0xe13fd7de < _0x4b563ca7.StageCount; _0xe13fd7de++)
        {
            bool _0xe7b34ca1 = _0x4b563ca7.StageUnlocked(_0xe13fd7de);
            bool _0x865a00e4 = _0xe7b34ca1 && _0xe13fd7de == _0xb3e5b825;
            this._0x10d7e45d[_0xe13fd7de].color = _0x865a00e4 ? _0xdc7245d7.GoldLight : _0xdc7245d7.GoldDark;
            this._0x7dde8dda[_0xe13fd7de].color = _0xe7b34ca1 ? _0xdc7245d7.Parchment : _0xdc7245d7.TextSecondary;
            _0xf9bbd821.ApplyOutline(this._0x7dde8dda[_0xe13fd7de]);
            if (_0xe7b34ca1)
            {
                this._0xbec46d24[_0xe13fd7de].text = _0xc17d5e88._0x80a09dc8(new byte[4] { 89, 94, 79, 59 }, 27) + _0x4b563ca7.StageBetMin(_0xe13fd7de) + _0xc17d5e88._0x80a09dc8(new byte[3] { 255, 242, 255 }, 223) + _0x4b563ca7.StageBetMax(_0xe13fd7de);
                this._0xbec46d24[_0xe13fd7de].color = _0xdc7245d7.GoldLight;
            }
            else
            {
                this._0xbec46d24[_0xe13fd7de].text = _0xc17d5e88._0x80a09dc8(new byte[17] { 209, 202, 200, 203, 199, 207, 215, 164, 197, 208, 164, 200, 193, 210, 193, 200, 164 }, 132) + _0x4b563ca7.StageUnlock(_0xe13fd7de);
                this._0xbec46d24[_0xe13fd7de].color = _0xdc7245d7.TextSecondary;
            }

            _0xf9bbd821.ApplyOutline(this._0xbec46d24[_0xe13fd7de]);
            this._0x1fe0a4b4[_0xe13fd7de].sprite = _0xe7b34ca1 ? this._0xf37238ea._0xc24dddd0 : this._0xf37238ea._0x30383bc4;
            this._0x1fe0a4b4[_0xe13fd7de].color = _0x865a00e4 ? _0xdc7245d7.Gold : _0xdc7245d7.TextMuted;
            this._0x1fe0a4b4[_0xe13fd7de].enabled = this._0x1fe0a4b4[_0xe13fd7de].sprite != null && (_0x865a00e4 || !_0xe7b34ca1);
        }
    }

    private _0x51685ac3 _0xf37238ea;
    private const float TextX = 538f / RowWidth;
    private void _0x67047806(int _0x91123f18)
    {
        RectTransform _0xcf05f243 = this._0x3a82e70a[_0x91123f18];
        if (_0xcf05f243 != null)
            _0xcf05f243.DOPunchScale(new Vector3(0.05f, 0.05f, 0f), 0.25f, 6, 0.6f).SetLink(_0xcf05f243.gameObject);
        if (!_0x4b563ca7.StageUnlocked(_0x91123f18))
        {
            this._0x9dfae2d8._0xa58f604b(_0xc17d5e88._0x80a09dc8(new byte[6] { 35, 32, 44, 36, 42, 43 }, 111), _0xc17d5e88._0x80a09dc8(new byte[12] { 27, 12, 8, 10, 1, 105, 5, 12, 31, 12, 5, 105 }, 73) + _0x4b563ca7.StageUnlock(_0x91123f18) + _0xc17d5e88._0x80a09dc8(new byte[9] { 81, 15, 20, 123, 20, 11, 30, 21, 123 }, 91) + _0x4b563ca7.StageName(_0x91123f18), _0xc17d5e88._0x80a09dc8(new byte[24] { 28, 0, 13, 21, 108, 24, 3, 2, 5, 11, 4, 24, 108, 24, 3, 108, 0, 9, 26, 9, 0, 108, 25, 28 }, 76), _0xc17d5e88._0x80a09dc8(new byte[6] { 205, 197, 222, 170, 195, 222 }, 138), null, null);
            return;
        }

        _0x0331a644._0xb9e14fc1 = _0x91123f18;
        int _0x2dde5134 = _0x4b563ca7.StageBetMin(_0x91123f18);
        if (_0x0331a644._0x54d74316 < _0x2dde5134)
            _0x0331a644._0x54d74316 = _0x2dde5134;
        PlayerPrefs.Save();
        this._0x739b51c2();
        this._0x9dfae2d8._0x612335fc();
    }

    private _0x529d8e09 _0x9dfae2d8;
    public RectTransform Root
    {
        get
        {
            return this._0x2fc4aab6 == null ? null : this._0x2fc4aab6._0x10966145;
        }
    }

    private const float RowWidth = 1050f;
}

internal static class _0xc17d5e88
{
    internal static string _0x80a09dc8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}