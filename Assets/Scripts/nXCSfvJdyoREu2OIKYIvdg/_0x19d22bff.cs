using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Tonight's gift: a seven-night streak, a casket that opens, a confetti burst and a
/// credit roll-up. The gift is free, unlimited in time and cannot be bought.
/// </summary>
public sealed class _0x19d22bff : MonoBehaviour, _0xeb461ae5
{
    public void Enter()
    {
        this._0x33447242();
        if (this._0x6067fd77 != null)
            this._0x6067fd77.Enter();
        if (this._0x394c2816 != null && !_0x0331a644._0x5255fac2)
            this._0x394c2816.DOAnchorPosY(12f, 2.2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x394c2816.gameObject);
    }

    private TextMeshProUGUI _0x980e728c;
    private _0x529d8e09 _0xf04887b1;
    private TextMeshProUGUI _0x2f6b21d9;
    private readonly TextMeshProUGUI[] _0x9ade1df1 = new TextMeshProUGUI[StreakDays];
    private TextMeshProUGUI _0xfd60f159;
    private Button _0xed0a6a60;
    private RectTransform _0x394c2816;
    private void _0xfb101d04()
    {
        if (!this._0xb81fa600())
            return;
        int _0x22b1b5fc = this._0xdfcf001a();
        int _0xd7a86e55 = _0x4b563ca7.GiftValue(_0x22b1b5fc);
        _0x0331a644._0xd543b1bb = _0x22b1b5fc >= StreakDays ? 0 : _0x22b1b5fc;
        _0x0331a644._0x626dd4e4 = _0x0331a644.Today();
        _0x0331a644.AddCredits(_0xd7a86e55);
        _0x0331a644.SetMissionProgress(_0x4b563ca7.MissionGift, 1);
        PlayerPrefs.Save();
        if (this._0x394c2816 != null)
            this._0x394c2816.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.45f, 7, 0.7f).SetLink(this._0x394c2816.gameObject);
        if (this._0xb880c2d7 != null)
            this._0xb880c2d7._0x3bd2bfe7(0.5f, 0.70f);
        if (_0x0331a644._0x2997eb52)
            Handheld.Vibrate();
        this._0x33447242();
        this._0xf04887b1._0x612335fc();
    }

    private readonly Image[] _0x457dca0a = new Image[StreakDays];
    public void Tick()
    {
        this._0x33447242();
    }

    private const int StreakDays = 7;
    private TextMeshProUGUI _0x149228fb;
    private readonly Image[] _0x36766cfc = new Image[StreakDays];
    private _0x92ec325d _0xb880c2d7;
    private void _0x33447242()
    {
        bool _0xd7f11057 = this._0xb81fa600();
        int _0x166249f3 = this._0xdfcf001a();
        this._0x149228fb.text = _0x3ac99487._0xd92c038e(new byte[1] { 149 }, 190) + _0x0331a644.Money(_0x4b563ca7.GiftValue(_0x166249f3)) + _0x3ac99487._0xd92c038e(new byte[3] { 153, 250, 235 }, 185);
        this._0xed0a6a60.gameObject.SetActive(true);
        this._0xed0a6a60.interactable = _0xd7f11057;
        if (this._0x980e728c != null)
        {
            this._0x980e728c.text = _0xd7f11057 ? _0x3ac99487._0xd92c038e(new byte[10] { 145, 158, 147, 155, 159, 242, 149, 155, 148, 134 }, 210) : _0x3ac99487._0xd92c038e(new byte[18] { 156, 144, 146, 154, 255, 157, 158, 156, 148, 255, 139, 144, 146, 144, 141, 141, 144, 136 }, 223);
            this._0x980e728c.color = _0xd7f11057 ? _0xdc7245d7.Parchment : _0xdc7245d7.TextSecondary;
            _0xf9bbd821.ApplyOutline(this._0x980e728c);
        }

        this._0x2f6b21d9.text = _0xd7f11057 ? _0x3ac99487._0xd92c038e(new byte[24] { 17, 10, 11, 12, 2, 13, 17, 98, 22, 101, 6, 4, 22, 14, 0, 17, 101, 12, 22, 101, 10, 21, 0, 11 }, 69) : _0x3ac99487._0xd92c038e(new byte[13] { 70, 77, 80, 92, 40, 79, 65, 78, 92, 40, 65, 70, 40 }, 8) + _0x4b563ca7.TimeToMidnight();
        this._0xfd60f159.text = _0xd7f11057 ? _0x3ac99487._0xd92c038e(new byte[28] { 61, 33, 44, 73, 33, 38, 60, 58, 44, 73, 59, 44, 58, 44, 61, 58, 73, 40, 61, 73, 36, 32, 45, 39, 32, 46, 33, 61 }, 105) : _0x3ac99487._0xd92c038e(new byte[28] { 32, 60, 49, 84, 60, 59, 33, 39, 49, 84, 38, 49, 39, 49, 32, 39, 84, 53, 32, 84, 57, 61, 48, 58, 61, 51, 60, 32 }, 116);
        int _0xaaa3f2ec = _0x0331a644._0xd543b1bb;
        for (int _0x0568357a = 0; _0x0568357a < StreakDays; _0x0568357a++)
        {
            bool _0x82ee0748 = _0x0568357a < _0xaaa3f2ec || (!_0xd7f11057 && _0x0568357a < _0x166249f3);
            bool _0xbe0a0eb4 = _0xd7f11057 && _0x0568357a == _0x166249f3 - 1;
            this._0x36766cfc[_0x0568357a].color = _0x82ee0748 ? _0xdc7245d7.Gold : _0xbe0a0eb4 ? _0xdc7245d7.GoldLight : _0xdc7245d7.GoldDark;
            this._0x457dca0a[_0x0568357a].enabled = _0x82ee0748 && this._0x12caa0ef._0xc24dddd0 != null;
            this._0x9ade1df1[_0x0568357a].gameObject.SetActive(!_0x82ee0748);
            this._0x9ade1df1[_0x0568357a].color = _0xbe0a0eb4 ? _0xdc7245d7.GoldLight : _0xdc7245d7.TextSecondary;
            _0xf9bbd821.ApplyOutline(this._0x9ade1df1[_0x0568357a]);
        }
    }

    public RectTransform Root
    {
        get
        {
            return this._0x6067fd77 == null ? null : this._0x6067fd77._0x10966145;
        }
    }

    private int _0xdfcf001a()
    {
        return Mathf.Clamp(_0x0331a644._0xd543b1bb + 1, 1, StreakDays);
    }

    public _0x19d22bff _0x1f4f4fef(_0x51685ac3 _0x228c328c, _0x529d8e09 _0x3fdb6473)
    {
        this._0x12caa0ef = _0x228c328c;
        this._0xf04887b1 = _0x3fdb6473;
        this._0x6067fd77 = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0x228c328c, _0x3ac99487._0xd92c038e(new byte[10] { 73, 76, 68, 65, 84, 45, 74, 68, 75, 89 }, 13), true, () => _0x3fdb6473._0xbda30b26());
        RectTransform _0xf5de102e = this._0x6067fd77._0x81b31132;
        this._0x394c2816 = _0x211a051a.Box(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[5] { 196, 239, 226, 244, 243 }, 135), 0.5f, 0.775f, 420f, 420f);
        _0x211a051a.Picture(this._0x394c2816, _0x3ac99487._0xd92c038e(new byte[3] { 196, 247, 241 }, 133), _0x228c328c._0xa9537078, 0.5f, 0.5f, 420f, 420f, Color.white);
        _0x211a051a.Label(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[6] { 55, 21, 31, 23, 25, 14 }, 124), _0x228c328c._0x50577ddc, _0x3ac99487._0xd92c038e(new byte[14] { 83, 72, 73, 78, 64, 79, 83, 32, 84, 39, 64, 78, 65, 83 }, 7), 44f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.600f, 900f, 74f);
        this._0x149228fb = _0x211a051a.Label(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[5] { 80, 103, 106, 115, 99 }, 6), _0x228c328c._0x50577ddc, "", 86f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.520f, 900f, 110f);
        RectTransform _0xd88900d0 = _0x211a051a.Box(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[6] { 18, 53, 51, 36, 32, 42 }, 65), 0.5f, 0.395f, 1000f, 140f);
        for (int _0x413be909 = 0; _0x413be909 < StreakDays; _0x413be909++)
        {
            float _0xab9c6e26 = (60f + _0x413be909 * 146.667f) / 1000f;
            RectTransform _0x2a99a98b = _0x211a051a.Box(_0xd88900d0, _0x3ac99487._0xd92c038e(new byte[3] { 19, 54, 46 }, 87), _0xab9c6e26, 0.5f, 120f, 120f);
            this._0x36766cfc[_0x413be909] = _0x211a051a.Plate(_0x2a99a98b, _0x3ac99487._0xd92c038e(new byte[5] { 0, 52, 39, 43, 35 }, 70), _0x228c328c._0xf4df0193, _0xdc7245d7.GoldDark, 2.0f);
            RectTransform _0x9584386c = _0x211a051a.Node(_0x2a99a98b, _0x3ac99487._0xd92c038e(new byte[5] { 59, 28, 28, 23, 0 }, 114), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
            _0x211a051a.Plate(_0x9584386c, _0x3ac99487._0xd92c038e(new byte[4] { 233, 198, 195, 195 }, 175), _0x228c328c._0xf4df0193, _0xdc7245d7.BgTertiary, 2.2f);
            this._0x9ade1df1[_0x413be909] = _0x211a051a.Fill(_0x2a99a98b, _0x3ac99487._0xd92c038e(new byte[3] { 50, 9, 17 }, 124), _0x228c328c._0x50577ddc, (_0x413be909 + 1).ToString(), 36f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 22f);
            this._0x457dca0a[_0x413be909] = _0x211a051a.Picture(_0x2a99a98b, _0x3ac99487._0xd92c038e(new byte[4] { 125, 81, 66, 91 }, 48), _0x228c328c._0xc24dddd0, 0.5f, 0.5f, 64f, 64f, _0xdc7245d7.Gold);
        }

        _0x211a051a.Label(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[13] { 0, 39, 33, 54, 50, 56, 16, 50, 35, 39, 58, 60, 61 }, 83), _0x228c328c._0x50577ddc, _0x3ac99487._0xd92c038e(new byte[31] { 147, 133, 150, 133, 142, 224, 142, 137, 135, 136, 148, 147, 224, 137, 142, 224, 129, 224, 146, 143, 151, 224, 144, 129, 153, 224, 245, 236, 240, 240, 240 }, 192), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.325f, 1000f, 50f);
        this._0xed0a6a60 = _0x211a051a.Action(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[5] { 198, 233, 228, 236, 232 }, 133), _0x228c328c._0x50577ddc, _0x228c328c._0xcef53720, _0x3ac99487._0xd92c038e(new byte[10] { 253, 242, 255, 247, 243, 158, 249, 247, 248, 234 }, 190), 44f, _0xdc7245d7.Scarlet, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.5f, 0.235f, 760f, 168f);
        this._0x980e728c = this._0xed0a6a60.GetComponentInChildren<TextMeshProUGUI>(true);
        this._0xed0a6a60.onClick.AddListener(() => this._0xfb101d04());
        this._0x2f6b21d9 = _0x211a051a.Label(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[9] { 35, 15, 21, 14, 20, 4, 15, 23, 14 }, 96), _0x228c328c._0x50577ddc, "", 34f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.145f, 1000f, 60f);
        this._0xfd60f159 = _0x211a051a.Label(_0xf5de102e, _0x3ac99487._0xd92c038e(new byte[7] { 235, 201, 216, 220, 193, 199, 198 }, 168), _0x228c328c._0x50577ddc, _0x3ac99487._0xd92c038e(new byte[28] { 232, 244, 249, 156, 244, 243, 233, 239, 249, 156, 238, 249, 239, 249, 232, 239, 156, 253, 232, 156, 241, 245, 248, 242, 245, 251, 244, 232 }, 188), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.090f, 1000f, 50f);
        this._0xb880c2d7 = this.gameObject.AddComponent<_0x92ec325d>()._0xb3465c94(_0xf5de102e, _0x228c328c);
        return this;
    }

    private void OnDestroy()
    {
        if (this._0x394c2816 != null)
            DOTween.Kill(this._0x394c2816);
    }

    private bool _0xb81fa600()
    {
        return _0x0331a644._0x626dd4e4 != _0x0331a644.Today();
    }

    private _0x51685ac3 _0x12caa0ef;
    private _0x25979831 _0x6067fd77;
}

internal static class _0x3ac99487
{
    internal static string _0xd92c038e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}