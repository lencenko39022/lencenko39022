using TMPro;
using UnityEngine;

// The game scene's single generated root: every serialized reference in one place, and
// the assembly order in Start.
//
// The template parents its own strip of placeholder controls under this very panel body,
// and the pipeline switches those placeholders off by name before the build - so the
// whole existing body is switched off here and the furniture is rebuilt as our own
// objects (C.2, rule H second option). Any branch that owns a popup is left alone, and
// the body itself is never touched, only its children.
public sealed class _0x78bd0182 : MonoBehaviour
{
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite[] _symbols;
    private void Start()
    {
        _0xe54e0344 _0xe5cb5cd6 = new _0xe54e0344()._0x5292f2a5();
        _0xc550b933 _0x0370bc78 = this.gameObject.AddComponent<_0xc550b933>();
        _0x0370bc78._0xaab641ee();
        _0x1981ce8b _0x4df6f599 = this.gameObject.AddComponent<_0x1981ce8b>();
        // No emblem in the game scene: its opening screen is a short hand off, so the
        // drawn mark is enough and there is one less reference to keep in step.
        _0x4df6f599._0xaa7d9ae8(this._font, this._plate, this._backdrop, null);
        Transform _0x4abfc352 = this._0x9fd3447f();
        if (_0x4abfc352 == null)
        {
            return;
        }

        this._0xb7f44dc5(_0x4abfc352);
        int _0x357cdfad = _0x5bbf3bb8.For(_0xe5cb5cd6._0x97795416, _0xe5cb5cd6._0x471e6ca6);
        _0x542b1bfd _0xa73e7324 = new _0x542b1bfd()._0x8d4ba13f(_0xe5cb5cd6, _0x357cdfad);
        RectTransform _0xbe4ccbe2 = _0x891ecf84.Stretch(_0x4abfc352, _0x585292a4._0x98e60f21(new byte[8] { 198, 224, 236, 228, 195, 224, 226, 234 }, 129));
        _0xbe4ccbe2.SetAsFirstSibling();
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0xbe4ccbe2, _0x585292a4._0x98e60f21(new byte[9] { 0, 38, 42, 34, 5, 43, 34, 34, 35 }, 71), 600f), _0xc5c3f38d.Ink);
        _0x891ecf84.Backdrop(_0x891ecf84.Bleed(_0xbe4ccbe2, _0x585292a4._0x98e60f21(new byte[7] { 114, 84, 88, 80, 116, 71, 65 }, 53), 160f), this._backdrop);
        // A wash of its own weight, so the table never reads as the lobby or as the
        // opening screen in a row of frames.
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0xbe4ccbe2, _0x585292a4._0x98e60f21(new byte[8] { 115, 85, 89, 81, 99, 85, 71, 92 }, 52), 600f), _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.72f));
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0xbe4ccbe2, _0x585292a4._0x98e60f21(new byte[8] { 189, 155, 151, 159, 174, 147, 148, 142 }, 250), 600f), _0xc5c3f38d.With(_0xc5c3f38d.RubyDeep, 0.14f));
        RectTransform _0x5c05a837 = _0x891ecf84.Node(_0xbe4ccbe2, _0x585292a4._0x98e60f21(new byte[14] { 27, 61, 49, 57, 26, 51, 51, 40, 48, 53, 59, 52, 40, 47 }, 92), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0f, 110f), new Vector2(0f, 220f));
        _0x891ecf84.Plate(_0x5c05a837, this._plate, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.09f), 1.6f);
        RectTransform _0x8d7ff44d = _0x891ecf84.Stretch(_0x4abfc352, _0x585292a4._0x98e60f21(new byte[9] { 10, 44, 32, 40, 11, 63, 34, 35, 57 }, 77));
        _0x8d7ff44d.SetAsLastSibling();
        _0x9799df08 _0xdb51c6cb = this.gameObject.AddComponent<_0x9799df08>();
        _0xfa11b898 _0x11d992f2 = this.gameObject.AddComponent<_0xfa11b898>();
        _0x8ac43d6c _0x1f0b8deb = this.gameObject.AddComponent<_0x8ac43d6c>();
        RectTransform _0xd5f26ef0 = _0x891ecf84.Stretch(_0x8d7ff44d, _0x585292a4._0x98e60f21(new byte[13] { 120, 94, 82, 90, 125, 80, 94, 77, 91, 119, 80, 76, 75 }, 63));
        _0x828e751a _0x3f8bf6f9 = _0xd5f26ef0.gameObject.AddComponent<_0x828e751a>();
        _0x11d992f2._0xc79cc7dd(_0x8d7ff44d, _0xdb51c6cb, _0xe5cb5cd6, _0xa73e7324, this._font, this._plate, this._rectPlate, this._roundPlate, this._iconBack, this._iconPause, this._symbols);
        _0x3f8bf6f9._0x1e94d904(_0xd5f26ef0, _0x11d992f2._0x5255fac2, this._plate, this._symbols, _0x357cdfad);
        _0xd5f26ef0.SetAsFirstSibling();
        _0x1f0b8deb._0x733ed108(_0xdb51c6cb, this._font, this._plate, this._rectPlate, this._roundPlate);
        _0xdb51c6cb._0x7e4cba04(_0x3f8bf6f9, _0x11d992f2, _0x1f0b8deb, _0xe5cb5cd6, _0xa73e7324, _0x357cdfad);
    }

    [SerializeField]
    private Sprite _rectPlate;
    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _backdrop;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _roundPlate;
    private void _0xb7f44dc5(Transform _0x91b39413)
    {
        for (int _0x8a31dfcb = _0x91b39413.childCount - 1; _0x8a31dfcb >= 0; _0x8a31dfcb--)
        {
            Transform _0x98e53920 = _0x91b39413.GetChild(_0x8a31dfcb);
            if (_0x98e53920 == null)
            {
                continue;
            }

            if (_0x98e53920.GetComponentInChildren<_0x5d88494d>(true) != null)
            {
                continue; // a branch that owns a popup stays alive
            }

            _0x98e53920.gameObject.SetActive(false);
        }
    }

    private Transform _0x9fd3447f()
    {
        _0x5bc6383a _0x9d89d209 = _0x5bc6383a.Instance;
        if (_0x9d89d209 == null || _0x9d89d209.Panels == null || _0x9d89d209.Panels.Count <= _0xa93ecf08._0x27eba83c.DEFAULT)
        {
            return null;
        }

        _0xd8539b11 _0x73e003fd = _0x9d89d209.Panels[_0xa93ecf08._0x27eba83c.DEFAULT];
        if (_0x73e003fd == null || _0x73e003fd.Content == null)
        {
            return null;
        }

        return _0x73e003fd.Content.transform;
    }
}

internal static class _0x585292a4
{
    internal static string _0x98e60f21(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}