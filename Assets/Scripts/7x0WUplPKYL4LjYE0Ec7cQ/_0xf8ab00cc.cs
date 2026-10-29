using TMPro;
using UnityEngine;

// The menu scene's single generated root. It carries every serialized reference the
// front of house needs - font, plate art, backdrop, emblem, the five painted faces and
// the template button's own rect - and assembles the screen in Start.
//
// Start, never Awake (C.59): the template does its own set up in Awake (the controller
// singletons, the settings object, the container that survives a scene change) and a
// generated Awake would run in the same phase in an undefined order. Nothing here keeps
// a static instance either.
public sealed class _0xf8ab00cc : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _symbols;
    [SerializeField]
    private TMP_FontAsset _font;
    private bool _0x97c7754d;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _backdrop;
    [SerializeField]
    private Sprite _rectPlate;
    [SerializeField]
    private Sprite _emblem;
    // Panels are reached by INDEX, never by name: obfuscation renames every object.
    private Transform _0x04446cfd()
    {
        _0x5bc6383a _0xc80583d8 = _0x5bc6383a.Instance;
        if (_0xc80583d8 == null || _0xc80583d8.Panels == null || _0xc80583d8.Panels.Count <= _0xa93ecf08._0x27eba83c.DEFAULT)
        {
            return null;
        }

        _0xd8539b11 _0x0665f1a4 = _0xc80583d8.Panels[_0xa93ecf08._0x27eba83c.DEFAULT];
        if (_0x0665f1a4 == null || _0x0665f1a4.Content == null)
        {
            return null;
        }

        return _0x0665f1a4.Content.transform;
    }

    [SerializeField]
    private RectTransform _playSlotRect;
    // The template's opening animation runs for a long time before the house hands over
    // to the lobby, and a review capture settles well before it ends. Holding for a
    // known number of seconds and then asking for the lobby ourselves makes the lobby
    // provably the first thing on screen, and it mirrors the template's own fallback
    // path - so on a device where the hand off arrives first, this changes nothing.
    private void Update()
    {
        if (this._0x97c7754d)
        {
            return;
        }

        _0x5bc6383a _0x48bbaf1e = _0x5bc6383a.Instance;
        if (_0x48bbaf1e == null || _0x48bbaf1e.Panels == null || _0x48bbaf1e.Panels.Count <= _0xa93ecf08._0x27eba83c.DEFAULT)
        {
            return;
        }

        if (_0x48bbaf1e.CurrentPanelIndex != _0xa93ecf08._0x27eba83c.SPLASH)
        {
            this._0x97c7754d = true;
            return;
        }

        this._0xeadf5c0e += Time.unscaledDeltaTime;
        if (this._0xeadf5c0e < _0xbbd798a9.SplashHoldSeconds)
        {
            return;
        }

        this._0x97c7754d = true;
        _0x48bbaf1e._0xfb4aa4a2(_0xa93ecf08._0x27eba83c.DEFAULT);
    }

    private void Start()
    {
        _0xe54e0344 _0x9f954c37 = new _0xe54e0344()._0x5292f2a5();
        _0x9a16fc44 _0x5971090f = new _0x9a16fc44()._0xcca6069c(_0x9f954c37);
        // A fresh sitting number every time the guest walks back in, so the next visit
        // deals a different mission card and different strips (C.11).
        _0x9f954c37._0x471e6ca6 = _0x9f954c37._0x471e6ca6 + 1;
        _0x9f954c37._0x55475292();
        _0xc550b933 _0x7fdab14a = this.gameObject.AddComponent<_0xc550b933>();
        _0x7fdab14a._0xaab641ee();
        _0x1981ce8b _0x32cdf23c = this.gameObject.AddComponent<_0x1981ce8b>();
        _0x32cdf23c._0xaa7d9ae8(this._font, this._plate, this._backdrop, this._emblem);
        Transform _0x66cea3ef = this._0x04446cfd();
        if (_0x66cea3ef == null)
        {
            return;
        }

        _0x542b1bfd _0x3f2a64c0 = new _0x542b1bfd()._0x8d4ba13f(_0x9f954c37, _0x5bbf3bb8.For(_0x9f954c37._0x97795416, _0x9f954c37._0x471e6ca6));
        _0xd5682da9.Refresh(_0x9f954c37);
        _0x5e7f3d72 _0x24ebccb2 = this.gameObject.AddComponent<_0x5e7f3d72>();
        _0x24ebccb2._0xc1d0722f(_0x66cea3ef, this._playSlotRect, _0x9f954c37, _0x5971090f, _0x3f2a64c0, this._font, this._plate, this._rectPlate, this._roundPlate, this._backdrop, this._emblem, this._symbols);
    }

    private float _0xeadf5c0e;
    [SerializeField]
    private Sprite _roundPlate;
}