using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Four settings that all really change something. There is no sound in this build, so
/// there is no volume slider, no speaker icon and no music toggle to fake.
/// </summary>
public sealed class _0x17263a46 : MonoBehaviour, _0xeb461ae5
{
    private const int RowCount = 4;
    private const float RowWidth = 1050f;
    private void OnDestroy()
    {
        if (this._0x4e58eb3e != null)
            DOTween.Kill(this._0x4e58eb3e);
        for (int _0x7d7fb64f = 0; _0x7d7fb64f < RowCount; _0x7d7fb64f++)
            if (this._0x1ab23759[_0x7d7fb64f] != null)
                DOTween.Kill(this._0x1ab23759[_0x7d7fb64f]);
    }

    public _0x17263a46 _0x2385e9ef(_0x51685ac3 _0xf4ed9fb9, _0x529d8e09 _0xbd595b88)
    {
        this._0x17d30c03 = _0xf4ed9fb9;
        this._0x3b093f8a = _0xbd595b88;
        this._0x52d06057 = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0xf4ed9fb9, _0x38382c80._0x171c6086(new byte[8] { 150, 128, 145, 145, 140, 139, 130, 150 }, 197), true, () => _0xbd595b88._0xbda30b26());
        RectTransform _0xce1bf324 = this._0x52d06057._0x81b31132;
        RectTransform _0x1f16f7fe = _0x211a051a.Box(_0xce1bf324, _0x38382c80._0x171c6086(new byte[4] { 86, 107, 115, 119 }, 4), 0.5f, 0.58f, RowWidth, 800f);
        for (int _0xc194c18c = 0; _0xc194c18c < RowCount; _0xc194c18c++)
        {
            float _0x634fd4b0 = (800f - 20f - 90f - _0xc194c18c * 180f) / 800f;
            this._0x4a3a1ba6(_0x1f16f7fe, _0xc194c18c, _0x634fd4b0);
        }

        _0x211a051a.Label(_0xce1bf324, _0x38382c80._0x171c6086(new byte[12] { 238, 221, 202, 203, 209, 215, 214, 244, 217, 218, 221, 212 }, 184), _0xf4ed9fb9._0x50577ddc, _0x38382c80._0x171c6086(new byte[7] { 198, 213, 194, 195, 217, 223, 222 }, 144), 28f, _0xdc7245d7.TextMuted, TextAlignmentOptions.Center, 0.5f, 0.17f, 1050f, 48f);
        _0x211a051a.Label(_0xce1bf324, _0x38382c80._0x171c6086(new byte[12] { 1, 50, 37, 36, 62, 56, 57, 1, 54, 59, 34, 50 }, 87), _0xf4ed9fb9._0x50577ddc, Application.version, 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.125f, 1050f, 52f);
        _0x211a051a.Label(_0xce1bf324, _0x38382c80._0x171c6086(new byte[6] { 78, 103, 103, 124, 109, 122 }, 8), _0xf4ed9fb9._0x50577ddc, _0x38382c80._0x171c6086(new byte[73] { 200, 217, 206, 207, 194, 223, 216, 171, 202, 217, 206, 171, 221, 194, 217, 223, 222, 202, 199, 171, 202, 197, 207, 171, 202, 199, 220, 202, 210, 216, 171, 205, 217, 206, 206, 165, 129, 223, 195, 206, 210, 171, 200, 202, 197, 197, 196, 223, 171, 201, 206, 171, 201, 196, 222, 204, 195, 223, 171, 196, 217, 171, 200, 202, 216, 195, 206, 207, 171, 196, 222, 223, 165 }, 139), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.055f, 1050f, 90f);
        return this;
    }

    public RectTransform Root
    {
        get
        {
            return this._0x52d06057 == null ? null : this._0x52d06057._0x10966145;
        }
    }

    private readonly Image[] _0x47c3ed6d = new Image[RowCount];
    private RectTransform _0x4e58eb3e;
    private void _0x381835d7()
    {
        bool[] _0x54335333 =
        {
            _0x0331a644._0x2997eb52,
            _0x0331a644._0x5255fac2,
            _0x0331a644._0x194d89c6
        };
        string[] _0x352db87f =
        {
            _0x0331a644._0x2997eb52 ? _0x38382c80._0x171c6086(new byte[26] { 154, 134, 139, 238, 138, 139, 152, 135, 141, 139, 238, 140, 155, 148, 148, 139, 157, 238, 129, 128, 238, 143, 238, 153, 135, 128 }, 206) : _0x38382c80._0x171c6086(new byte[22] { 183, 171, 166, 195, 167, 166, 181, 170, 160, 166, 195, 176, 183, 162, 186, 176, 195, 176, 183, 170, 175, 175 }, 227),
            _0x0331a644._0x5255fac2 ? _0x38382c80._0x171c6086(new byte[28] { 132, 147, 147, 154, 133, 246, 133, 130, 153, 134, 246, 144, 151, 133, 130, 250, 246, 152, 153, 246, 149, 153, 152, 144, 147, 130, 130, 159 }, 214) : _0x38382c80._0x171c6086(new byte[25] { 103, 116, 109, 109, 1, 114, 117, 96, 102, 102, 100, 115, 1, 96, 111, 101, 1, 98, 110, 111, 103, 100, 117, 117, 104 }, 33),
            _0x0331a644._0x194d89c6 ? _0x38382c80._0x171c6086(new byte[21] { 22, 10, 11, 17, 98, 17, 3, 15, 18, 14, 7, 98, 11, 17, 98, 14, 3, 16, 5, 7, 16 }, 66) : _0x38382c80._0x171c6086(new byte[21] { 89, 69, 68, 94, 45, 94, 76, 64, 93, 65, 72, 45, 68, 94, 45, 67, 66, 95, 64, 76, 65 }, 13),
            _0x38382c80._0x171c6086(new byte[23] { 44, 61, 42, 43, 38, 59, 60, 79, 61, 42, 59, 58, 61, 33, 79, 59, 32, 79, 90, 67, 95, 95, 95 }, 111),
        };
        for (int _0x5132cc7f = 0; _0x5132cc7f < RowCount; _0x5132cc7f++)
        {
            bool _0x50168e86 = _0x5132cc7f < 3 && _0x54335333[_0x5132cc7f];
            this._0x47c3ed6d[_0x5132cc7f].color = _0x50168e86 ? _0xdc7245d7.Gold : _0xdc7245d7.GoldDark;
            this._0x7b31710f[_0x5132cc7f].text = _0x352db87f[_0x5132cc7f];
            this._0x7b31710f[_0x5132cc7f].color = _0x50168e86 ? _0xdc7245d7.GoldLight : _0xdc7245d7.TextSecondary;
            if (_0x5132cc7f == 2)
                _0xf9bbd821.ApplyFlow(this._0x7b31710f[_0x5132cc7f], _0x0331a644._0x194d89c6 ? 40f : 28f);
            _0xf9bbd821.ApplyOutline(this._0x7b31710f[_0x5132cc7f]);
            if (_0x5132cc7f < 3 && this._0x1ab23759[_0x5132cc7f] != null)
            {
                RectTransform _0x7f0bc460 = this._0x1ab23759[_0x5132cc7f];
                DOTween.Kill(_0x7f0bc460, true);
                float _0xe7d541b5 = _0x50168e86 ? 0.72f : 0.28f;
                _0x7f0bc460.anchorMin = new Vector2(_0xe7d541b5, 0.5f);
                _0x7f0bc460.anchorMax = new Vector2(_0xe7d541b5, 0.5f);
                _0x7f0bc460.anchoredPosition = Vector2.zero;
                this._0x656761da[_0x5132cc7f].color = _0x50168e86 ? _0xdc7245d7.Gold : _0xdc7245d7.TextMuted;
            }
        }

        this._0xbbcbc642();
    }

    private readonly RectTransform[] _0x1ab23759 = new RectTransform[RowCount];
    private void _0xc993f3ad(int _0x223b4fc1)
    {
        if (_0x223b4fc1 == 0)
        {
            _0x0331a644._0x2997eb52 = !_0x0331a644._0x2997eb52;
            if (_0x0331a644._0x2997eb52)
                Handheld.Vibrate();
        }
        else if (_0x223b4fc1 == 1)
        {
            _0x0331a644._0x5255fac2 = !_0x0331a644._0x5255fac2;
        }
        else
        {
            _0x0331a644._0x194d89c6 = !_0x0331a644._0x194d89c6;
        }

        PlayerPrefs.Save();
        this._0x381835d7();
    }

    private void _0xbbcbc642()
    {
        if (this._0x4e58eb3e == null)
            return;
        DOTween.Kill(this._0x4e58eb3e, true);
        this._0x4e58eb3e.localScale = Vector3.one;
        if (!_0x0331a644._0x5255fac2)
            this._0x4e58eb3e.DOScale(1.22f, 0.8f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x4e58eb3e.gameObject);
    }

    public void Tick()
    {
    }

    private _0x51685ac3 _0x17d30c03;
    private const float RowHeight = 180f;
    private readonly TextMeshProUGUI[] _0x7b31710f = new TextMeshProUGUI[RowCount];
    private void _0x96170c6c()
    {
        _0x0331a644.ResetEverything();
        this._0x381835d7();
        this._0x3b093f8a._0x612335fc();
        this._0x3b093f8a._0xbda30b26();
    }

    private _0x529d8e09 _0x3b093f8a;
    private _0x25979831 _0x52d06057;
    private static readonly string[] _0xcd4c3e1a =
    {
        _0x38382c80._0x171c6086(new byte[9] { 236, 243, 248, 232, 251, 238, 243, 245, 244 }, 186),
        _0x38382c80._0x171c6086(new byte[14] { 22, 1, 0, 17, 7, 1, 0, 100, 9, 11, 16, 13, 11, 10 }, 68),
        _0x38382c80._0x171c6086(new byte[10] { 229, 232, 251, 238, 236, 137, 253, 236, 241, 253 }, 169),
        _0x38382c80._0x171c6086(new byte[14] { 66, 85, 67, 85, 68, 48, 64, 66, 95, 87, 66, 85, 67, 67 }, 16)
    };
    private void _0x2ccc56d1()
    {
        this._0x3b093f8a._0xa58f604b(_0x38382c80._0x171c6086(new byte[17] { 133, 146, 129, 147, 133, 224, 133, 150, 133, 146, 153, 148, 136, 137, 142, 135, 255 }, 192), _0x38382c80._0x171c6086(new byte[60] { 144, 134, 156, 155, 233, 133, 140, 159, 140, 133, 229, 233, 138, 155, 140, 141, 128, 157, 154, 233, 136, 135, 141, 233, 138, 134, 133, 133, 140, 138, 157, 128, 134, 135, 195, 158, 128, 133, 133, 233, 142, 134, 233, 139, 136, 138, 130, 233, 157, 134, 233, 157, 129, 140, 233, 154, 157, 136, 155, 157 }, 201), _0x38382c80._0x171c6086(new byte[21] { 245, 233, 232, 242, 129, 226, 224, 239, 239, 238, 245, 129, 227, 228, 129, 244, 239, 229, 238, 239, 228 }, 161), _0x38382c80._0x171c6086(new byte[5] { 46, 57, 42, 56, 46 }, 107), () => this._0x96170c6c(), _0x38382c80._0x171c6086(new byte[4] { 172, 162, 162, 183 }, 231));
    }

    public void Enter()
    {
        this._0x381835d7();
        if (this._0x52d06057 != null)
            this._0x52d06057.Enter();
    }

    private void _0x4a3a1ba6(RectTransform _0xb2747d4d, int _0x926ecd54, float _0xdfd59e06)
    {
        RectTransform _0xdbbfdf5a = _0x211a051a.Box(_0xb2747d4d, _0x38382c80._0x171c6086(new byte[3] { 221, 224, 248 }, 143), 0.5f, _0xdfd59e06, RowWidth, RowHeight);
        this._0x47c3ed6d[_0x926ecd54] = _0x211a051a.Plate(_0xdbbfdf5a, _0x38382c80._0x171c6086(new byte[5] { 89, 109, 126, 114, 122 }, 31), this._0x17d30c03._0xcef53720, _0xdc7245d7.GoldDark, 2.2f);
        RectTransform _0x1e234df1 = _0x211a051a.Node(_0xdbbfdf5a, _0x38382c80._0x171c6086(new byte[5] { 183, 144, 144, 155, 140 }, 254), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-10f, -10f));
        _0x211a051a.Plate(_0x1e234df1, _0x38382c80._0x171c6086(new byte[4] { 163, 140, 137, 137 }, 229), this._0x17d30c03._0xcef53720, _0xdc7245d7.PanelBase, 2.4f);
        _0x211a051a.Label(_0xdbbfdf5a, _0x38382c80._0x171c6086(new byte[5] { 180, 137, 148, 140, 133 }, 224), this._0x17d30c03._0x50577ddc, _0xcd4c3e1a[_0x926ecd54], 36f, _0xdc7245d7.Parchment, TextAlignmentOptions.Left, 320f / RowWidth, 0.68f, 460f, 56f);
        this._0x7b31710f[_0x926ecd54] = _0x211a051a.Label(_0xdbbfdf5a, _0x38382c80._0x171c6086(new byte[6] { 32, 18, 30, 3, 31, 22 }, 115), this._0x17d30c03._0x50577ddc, "", 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Left, 320f / RowWidth, 0.28f, 460f, 48f);
        if (_0x926ecd54 == 3)
        {
            Button _0x90f587d0 = _0x211a051a.Action(_0xdbbfdf5a, _0x38382c80._0x171c6086(new byte[5] { 170, 157, 142, 156, 138 }, 239), this._0x17d30c03._0x50577ddc, this._0x17d30c03._0xcef53720, _0x38382c80._0x171c6086(new byte[5] { 58, 45, 62, 44, 58 }, 127), 32f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.StatusLose, _0xdc7245d7.Parchment, 830f / RowWidth, 0.5f, 280f, 96f);
            _0x90f587d0.onClick.AddListener(() => this._0x2ccc56d1());
            return;
        }

        RectTransform _0xd85c7d68 = _0x211a051a.Box(_0xdbbfdf5a, _0x38382c80._0x171c6086(new byte[4] { 31, 38, 35, 35 }, 79), 830f / RowWidth, 0.5f, 170f, 86f);
        Image _0xca06ef94 = _0x211a051a.Plate(_0xd85c7d68, _0x38382c80._0x171c6086(new byte[5] { 18, 38, 53, 57, 49 }, 84), this._0x17d30c03._0xf4df0193, _0xdc7245d7.GoldDark, 1.6f);
        _0xca06ef94.raycastTarget = true;
        RectTransform _0x75595b9a = _0x211a051a.Node(_0xd85c7d68, _0x38382c80._0x171c6086(new byte[5] { 138, 173, 173, 166, 177 }, 195), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
        _0x211a051a.Plate(_0x75595b9a, _0x38382c80._0x171c6086(new byte[4] { 223, 240, 245, 245 }, 153), this._0x17d30c03._0xf4df0193, _0xdc7245d7.BgTertiary, 1.8f);
        RectTransform _0xa6637480 = _0x211a051a.Box(_0xd85c7d68, _0x38382c80._0x171c6086(new byte[4] { 95, 122, 123, 118 }, 20), 0.28f, 0.5f, 66f, 66f);
        this._0x1ab23759[_0x926ecd54] = _0xa6637480;
        Image _0x64af33ee = _0xa6637480.gameObject.AddComponent<Image>();
        _0x64af33ee.sprite = this._0x17d30c03._0xf4df0193;
        _0x64af33ee.type = this._0x17d30c03._0xf4df0193 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x64af33ee.color = _0xdc7245d7.TextMuted;
        _0x64af33ee.raycastTarget = false;
        _0x64af33ee.pixelsPerUnitMultiplier = 1.4f;
        _0x211a051a.Slice(_0x64af33ee, 1.4f);
        this._0x656761da[_0x926ecd54] = _0x64af33ee;
        Button _0x040382d3 = _0xd85c7d68.gameObject.AddComponent<Button>();
        _0x040382d3.targetGraphic = _0xca06ef94;
        int _0x058cbd4e = _0x926ecd54;
        _0x040382d3.onClick.AddListener(() => this._0xc993f3ad(_0x058cbd4e));
        if (_0x926ecd54 == 1)
        {
            this._0x4e58eb3e = _0x211a051a.Box(_0xdbbfdf5a, _0x38382c80._0x171c6086(new byte[10] { 120, 90, 65, 92, 90, 91, 118, 93, 92, 69 }, 53), 690f / RowWidth, 0.5f, 56f, 56f);
            Image _0x85ca1ea2 = this._0x4e58eb3e.gameObject.AddComponent<Image>();
            _0x85ca1ea2.sprite = this._0x17d30c03._0xf4df0193;
            _0x85ca1ea2.type = this._0x17d30c03._0xf4df0193 == null ? Image.Type.Simple : Image.Type.Sliced;
            _0x85ca1ea2.color = _0xdc7245d7.GoldLight;
            _0x85ca1ea2.raycastTarget = false;
            _0x85ca1ea2.pixelsPerUnitMultiplier = 1.4f;
            _0x211a051a.Slice(_0x85ca1ea2, 1.4f);
        }
    }

    private readonly Image[] _0x656761da = new Image[RowCount];
}

internal static class _0x38382c80
{
    internal static string _0x171c6086(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}