using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Owner of the menu scene. Builds the lobby, dresses the template Play button in place,
/// creates the ten secondary screens and switches between them by integer index.
/// Everything it touches is reached through a serialized reference or through a child it
/// created itself - nothing is looked up by name.
/// </summary>
public sealed class _0x529d8e09 : MonoBehaviour
{
    public const int RouteLibrary = 2;
    /// <summary>Missions and the gift reset at local midnight; a new day is a day played.</summary>
    private void _0xe9cfe39d()
    {
        int _0xf17bc634 = _0x0331a644.Today();
        if (_0x0331a644._0x509a1731 == _0xf17bc634)
            return;
        _0x0331a644._0x509a1731 = _0xf17bc634;
        _0x0331a644._0xd7110322 = _0x0331a644._0xd7110322 + 1;
        for (int _0x056420d3 = 0; _0x056420d3 < _0x0331a644.MissionCount; _0x056420d3++)
        {
            _0x0331a644.SetMissionProgress(_0x056420d3, 0);
            _0x0331a644.SetMissionClaimed(_0x056420d3, false);
        }

        PlayerPrefs.Save();
    }

    public _0x51685ac3 _0xc6caec45
    {
        get
        {
            return this._theme;
        }
    }

    [SerializeField]
    private RectTransform _playButton;
    private TextMeshProUGUI _0x8c4fb977;
    public const int RouteMissions = 4;
    public const int RouteProgress = 6;
    public void _0x9b79807d(int _0x8007e822)
    {
        if (_0x8007e822 < 0 || _0x8007e822 >= RouteCount)
            _0x8007e822 = RouteHome;
        this._0xa6d15ade();
        for (int _0x8cd16ed0 = 0; _0x8cd16ed0 < RouteCount; _0x8cd16ed0++)
        {
            _0xeb461ae5 _0x0d6c86a1 = this._0x82bd46ad[_0x8cd16ed0];
            if (_0x0d6c86a1 == null || _0x8cd16ed0 == _0x8007e822)
                continue;
            if (_0x0d6c86a1.Root != null)
                _0x0d6c86a1.Root.gameObject.SetActive(false);
        }

        this._0x9e37983b = _0x8007e822;
        _0xeb461ae5 _0x43147f9d = this._0x82bd46ad[_0x8007e822];
        if (_0x43147f9d != null)
            _0x43147f9d.Enter();
        bool _0x6a3aaf9c = _0x8007e822 == RouteHome;
        if (this._0xc51c3543 != null && this._0xc51c3543.Root != null)
            this._0xc51c3543.Root.gameObject.SetActive(_0x6a3aaf9c);
        if (this._playButton != null)
            this._playButton.gameObject.SetActive(_0x6a3aaf9c);
    }

    private Button _0xb8c11e65;
    private void _0x63185666()
    {
        this._0x82bd46ad[RouteAgeGate] = this._0xce8154d7<_0x24e0fb79>(_0x0969b611._0xfce8be9e(new byte[7] { 225, 215, 209, 237, 243, 213, 215 }, 178))._0xfff27da3(this._theme, this);
        this._0x82bd46ad[RouteLibrary] = this._0xce8154d7<_0x3cb547e5>(_0x0969b611._0xfce8be9e(new byte[11] { 190, 136, 142, 178, 161, 132, 143, 159, 140, 159, 148 }, 237))._0x863c5bec(this._theme, this);
        this._0x82bd46ad[RouteGift] = this._0xce8154d7<_0x19d22bff>(_0x0969b611._0xfce8be9e(new byte[8] { 9, 63, 57, 5, 29, 51, 60, 46 }, 90))._0x1f4f4fef(this._theme, this);
        this._0x82bd46ad[RouteMissions] = this._0xce8154d7<_0x12812932>(_0x0969b611._0xfce8be9e(new byte[12] { 137, 191, 185, 133, 151, 179, 169, 169, 179, 181, 180, 169 }, 218))._0x9109c60d(this._theme, this);
        this._0x82bd46ad[RouteCollection] = this._0xce8154d7<_0x5e65bb1e>(_0x0969b611._0xfce8be9e(new byte[14] { 20, 34, 36, 24, 4, 40, 43, 43, 34, 36, 51, 46, 40, 41 }, 71))._0xe2293573(this._theme, this);
        this._0x82bd46ad[RouteProgress] = this._0xce8154d7<_0xd912281d>(_0x0969b611._0xfce8be9e(new byte[12] { 94, 104, 110, 82, 93, 127, 98, 106, 127, 104, 126, 126 }, 13))._0xa8d08ba3(this._theme, this);
        this._0x82bd46ad[RouteProfile] = this._0xce8154d7<_0xb5f4e158>(_0x0969b611._0xfce8be9e(new byte[11] { 202, 252, 250, 198, 201, 235, 246, 255, 240, 245, 252 }, 153))._0x7f98dee0(this._theme, this);
        this._0x82bd46ad[RouteRules] = this._0xce8154d7<_0xdb51c6cb>(_0x0969b611._0xfce8be9e(new byte[9] { 55, 1, 7, 59, 54, 17, 8, 1, 23 }, 100))._0x11d992f2(this._theme, this);
        this._0x82bd46ad[RouteSettings] = this._0xce8154d7<_0x17263a46>(_0x0969b611._0xfce8be9e(new byte[12] { 248, 206, 200, 244, 248, 206, 223, 223, 194, 197, 204, 216 }, 171))._0x2385e9ef(this._theme, this);
    }

    public const int RouteRules = 8;
    private void OnDestroy()
    {
        if (this._playButton != null)
            DOTween.Kill(this._playButton);
        if (this._0xaea9010c != null)
            DOTween.Kill(this._0xaea9010c);
    }

    public void _0xbda30b26()
    {
        this._0x9b79807d(RouteHome);
    }

    public const int RouteCount = 10;
    private _0x3fb2b235 _0xc51c3543;
    public const int RouteProfile = 7;
    public const int RouteGift = 3;
    private readonly _0xeb461ae5[] _0x82bd46ad = new _0xeb461ae5[RouteCount];
    private TextMeshProUGUI _0x79501ef9;
    private float _0xefd51ae4;
    private System.Action _0x69e87eb8;
    private T _0xce8154d7<T>(string _0x43d200ee)
        where T : Component
    {
        RectTransform _0xb379543f = _0x211a051a.Stretch(this._overlayRoot, _0x43d200ee);
        return _0xb379543f.gameObject.AddComponent<T>();
    }

    /// <summary>
    /// The template Play button ships invisible and stretched over the whole menu. Its
    /// rect is fixed in the scene file; here it gets the velvet plate and the caption as
    /// children that do not take raycasts, so its own driver keeps handling the tap.
    /// </summary>
    private void _0xa5c2bc0e()
    {
        if (this._playButton == null)
            return;
        _0x211a051a.Plate(this._playButton, _0x0969b611._0xfce8be9e(new byte[9] { 35, 31, 18, 10, 53, 1, 18, 30, 22 }, 115), this._theme._0xcef53720, _0xdc7245d7.Gold, 2.2f);
        RectTransform _0xeea8aa65 = _0x211a051a.Node(this._playButton, _0x0969b611._0xfce8be9e(new byte[9] { 128, 188, 177, 169, 153, 190, 190, 181, 162 }, 208), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-12f, -12f));
        _0x211a051a.Plate(_0xeea8aa65, _0x0969b611._0xfce8be9e(new byte[8] { 215, 235, 230, 254, 193, 238, 235, 235 }, 135), this._theme._0xcef53720, _0xdc7245d7.Scarlet, 2.4f);
        _0x211a051a.Plate(_0xeea8aa65, _0x0969b611._0xfce8be9e(new byte[8] { 211, 239, 226, 250, 196, 239, 236, 244 }, 131), this._theme._0xcef53720, _0xdc7245d7.WithAlpha(_0xdc7245d7.GoldShimmer, 0.14f), 2.4f);
        _0x211a051a.Caption(this._playButton, _0x0969b611._0xfce8be9e(new byte[9] { 172, 144, 157, 133, 176, 157, 158, 153, 144 }, 252), this._theme._0x50577ddc, _0x0969b611._0xfce8be9e(new byte[4] { 255, 227, 238, 246 }, 175), 64f, _0xdc7245d7.Parchment, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-40f, -24f));
        this._playButton.localScale = Vector3.one;
        this._playButton.DOScale(1.03f, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._playButton.gameObject);
    }

    public const int RouteAgeGate = 0;
    public void _0xa58f604b(string _0x414bcd5d, string _0x311f06c1, string _0xb1e95508, string _0x64359f76, System.Action _0x04bc4d8a, string _0x85ada6be)
    {
        if (this._0xaea9010c == null)
            return;
        this._0xbef6217f.text = _0x414bcd5d;
        this._0x1e356c0a.text = _0x311f06c1;
        this._0xdaae7b0f.text = _0xb1e95508;
        this._0x69e87eb8 = _0x04bc4d8a;
        if (this._0x8c4fb977 != null)
            this._0x8c4fb977.text = _0x64359f76;
        bool _0x30ddc409 = !string.IsNullOrEmpty(_0x85ada6be);
        this._0xb8c11e65.gameObject.SetActive(_0x30ddc409);
        if (_0x30ddc409 && this._0x79501ef9 != null)
            this._0x79501ef9.text = _0x85ada6be;
        this._0xaea9010c.gameObject.SetActive(true);
        this._0xaea9010c.SetAsLastSibling();
        this._0xaea9010c.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0xaea9010c.DOScale(1f, 0.22f).SetEase(Ease.OutBack, 1.7f).SetLink(this._0xaea9010c.gameObject);
    }

    // ---------------------------------------------------------------- notice sheet
    /// <summary>
    /// The menu scene has no popup pool of its own, so confirmations and information
    /// cards use this sheet. The game scene uses the template popups 7 / 8 / 6.
    /// </summary>
    private void _0xf8e41753()
    {
        this._0xaea9010c = _0x211a051a.Stretch(this._overlayRoot, _0x0969b611._0xfce8be9e(new byte[6] { 191, 158, 133, 152, 146, 148 }, 241));
        Image _0xca554d0a = _0x211a051a.Plate(this._0xaea9010c, _0x0969b611._0xfce8be9e(new byte[3] { 144, 189, 185 }, 212), this._theme._0x9bc213f0, new Color(0f, 0f, 0f, 0.72f), 1f);
        _0xca554d0a.raycastTarget = true;
        RectTransform _0xf3a351b2 = _0x211a051a.Sheet(this._0xaea9010c, _0x0969b611._0xfce8be9e(new byte[4] { 24, 58, 41, 63 }, 91), 0.5f, 0.5f, 1050f, 720f, this._theme._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.Gold, 10f);
        this._0xbef6217f = _0x211a051a.Label(_0xf3a351b2, _0x0969b611._0xfce8be9e(new byte[6] { 180, 153, 157, 152, 153, 142 }, 252), this._theme._0x50577ddc, "", 56f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.84f, 940f, 100f);
        this._0x1e356c0a = _0x211a051a.Label(_0xf3a351b2, _0x0969b611._0xfce8be9e(new byte[4] { 238, 195, 200, 213 }, 172), this._theme._0x50577ddc, "", 38f, _0xdc7245d7.TextPrimary, TextAlignmentOptions.Center, 0.5f, 0.58f, 940f, 220f);
        this._0xdaae7b0f = _0x211a051a.Label(_0xf3a351b2, _0x0969b611._0xfce8be9e(new byte[5] { 246, 203, 199, 193, 210 }, 179), this._theme._0x50577ddc, "", 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.38f, 940f, 110f);
        this._0x3333e3d0 = _0x211a051a.Action(_0xf3a351b2, _0x0969b611._0xfce8be9e(new byte[7] { 103, 69, 94, 90, 86, 69, 78 }, 55), this._theme._0x50577ddc, this._theme._0xcef53720, _0x0969b611._0xfce8be9e(new byte[6] { 48, 56, 35, 87, 62, 35 }, 119), 42f, _0xdc7245d7.Scarlet, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.5f, 0.16f, 620f, 140f);
        this._0x8c4fb977 = this._0x3333e3d0.GetComponentInChildren<TextMeshProUGUI>(true);
        this._0x3333e3d0.onClick.AddListener(() => this._0x34965976());
        this._0xb8c11e65 = _0x211a051a.Action(this._0xaea9010c, _0x0969b611._0xfce8be9e(new byte[9] { 85, 99, 101, 105, 104, 98, 103, 116, 127 }, 6), this._theme._0x50577ddc, this._theme._0xcef53720, _0x0969b611._0xfce8be9e(new byte[4] { 87, 89, 89, 76 }, 28), 38f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.GoldDark, _0xdc7245d7.Parchment, 0.5f, 0.305f, 440f, 118f);
        this._0x79501ef9 = this._0xb8c11e65.GetComponentInChildren<TextMeshProUGUI>(true);
        this._0xb8c11e65.onClick.AddListener(() => this._0xa6d15ade());
        this._0xaea9010c.gameObject.SetActive(false);
    }

    public const int RouteHome = 1;
    private void _0x34965976()
    {
        System.Action _0x3cb95c8a = this._0x69e87eb8;
        this._0x69e87eb8 = null;
        this._0xa6d15ade();
        if (_0x3cb95c8a != null)
            _0x3cb95c8a();
    }

    public const int RouteSettings = 9;
    private Button _0x3333e3d0;
    private void Start()
    {
        if (this._theme == null)
            return;
        this._0xe9cfe39d();
        RectTransform _0xd5770378 = this.transform as RectTransform;
        if (_0xd5770378 != null)
            _0xd5770378.SetAsFirstSibling();
        if (this._overlayRoot != null)
            this._overlayRoot.SetAsLastSibling();
        this._0xc51c3543 = this.gameObject.AddComponent<_0x3fb2b235>();
        this._0xc51c3543._0xdcc791f7(_0xd5770378, this._theme, this);
        this._0x82bd46ad[RouteHome] = this._0xc51c3543;
        this._0xa5c2bc0e();
        this._0x63185666();
        this._0xf8e41753();
        if (!_0x0331a644._0x50f91b80)
            this._0x9b79807d(RouteAgeGate);
        else
            this._0x9b79807d(RouteHome);
    }

    private int _0x9e37983b = RouteHome;
    [SerializeField]
    private RectTransform _overlayRoot;
    public void _0xa6d15ade()
    {
        if (this._0xaea9010c == null)
            return;
        DOTween.Kill(this._0xaea9010c, true);
        this._0xaea9010c.gameObject.SetActive(false);
    }

    private TextMeshProUGUI _0xbef6217f;
    private TextMeshProUGUI _0xdaae7b0f;
    public void _0x612335fc()
    {
        if (this._0xc51c3543 != null)
            this._0xc51c3543._0x8908920a();
    }

    private RectTransform _0xaea9010c;
    private void Update()
    {
        this._0xefd51ae4 += Time.unscaledDeltaTime;
        if (this._0xefd51ae4 < 1f)
            return;
        this._0xefd51ae4 = 0f;
        _0xeb461ae5 _0x257de1f6 = this._0x82bd46ad[this._0x9e37983b];
        if (_0x257de1f6 != null)
            _0x257de1f6.Tick();
    }

    [SerializeField]
    private _0x51685ac3 _theme;
    public const int RouteCollection = 5;
    private TextMeshProUGUI _0x1e356c0a;
}

internal static class _0x0969b611
{
    internal static string _0xfce8be9e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}