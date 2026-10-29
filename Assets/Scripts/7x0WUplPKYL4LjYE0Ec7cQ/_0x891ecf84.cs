using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The UGUI builder kit. The whole game is UGUI - there is not one SpriteRenderer in it -
// so the camera derived sizing of C.0 has nothing to size, and every rect is derived
// from the panel body instead.
//
// Anchor convention, and the trap it exists to avoid: a helper that collapses anchors to
// a point makes anchoredPosition relative to THAT corner, not to the parent's centre. An
// edge anchored box therefore needs its centre at least half its own width inside the
// edge. The named helpers below take a CENTRE and the distance of that centre from the
// named edge, so a caller never has to remember which corner it is working from.
public static class _0x891ecf84
{
    // ---- containers ---------------------------------------------------------
    public static RectTransform Node(Transform _0x9e8fda68, string _0xf8a4cad8, Vector2 _0x1a0bf359, Vector2 _0xda162f2b, Vector2 _0x3efbc20b, Vector2 _0xe0317038)
    {
        GameObject _0x525b96d0 = new GameObject(_0xf8a4cad8, typeof(RectTransform));
        RectTransform _0x28ad2a09 = _0x525b96d0.GetComponent<RectTransform>();
        _0x28ad2a09.SetParent(_0x9e8fda68, false);
        _0x28ad2a09.anchorMin = _0x1a0bf359;
        _0x28ad2a09.anchorMax = _0xda162f2b;
        _0x28ad2a09.pivot = new Vector2(0.5f, 0.5f);
        _0x28ad2a09.anchoredPosition = _0x3efbc20b;
        _0x28ad2a09.sizeDelta = _0xe0317038;
        _0x28ad2a09.localScale = Vector3.one;
        return _0x28ad2a09;
    }

    // A band pinned to both vertical edges and inset by `side` from both horizontal
    // ones, spanning from `fromBottom` up to `fromTop` below the top edge. Expressed
    // against the edges rather than as a fixed width, so it can never overhang a panel
    // that the aspect fitter made narrower than the canvas.
    public static RectTransform Band(Transform _0x6c7991fa, string _0x6d953112, float _0x648fee16, float _0x02b89284, float _0x3d1fd2d3)
    {
        return Node(_0x6c7991fa, _0x6d953112, new Vector2(0f, 0f), new Vector2(1f, 1f), new Vector2(0f, (_0x02b89284 - _0x3d1fd2d3) * 0.5f), new Vector2(-2f * _0x648fee16, -(_0x02b89284 + _0x3d1fd2d3)));
    }

    // A stretched child that deliberately overhangs its parent on every side.
    //
    // WHY: the panel body sits inside the template's aspect fitter, so on a device
    // taller than the 1242x2688 reference the panel is letterboxed - while the
    // template's own background canvas is NOT inside that fitter and covers the whole
    // screen. Anything drawn only to the panel rect would leave two strips of the
    // template's stock picture showing, top and bottom. Backdrop layers bleed past the
    // panel so those strips carry this game's own colour. There is no mask anywhere in
    // the chain, so the overhang really draws.
    public static RectTransform Bleed(Transform _0x03b940c6, string _0x993d1c2e, float _0xa4a8f4c2)
    {
        RectTransform _0x75148ffd = Stretch(_0x03b940c6, _0x993d1c2e);
        _0x75148ffd.offsetMin = new Vector2(-_0xa4a8f4c2, -_0xa4a8f4c2);
        _0x75148ffd.offsetMax = new Vector2(_0xa4a8f4c2, _0xa4a8f4c2);
        return _0x75148ffd;
    }

    // The drawn button plate, used 9-sliced so a wide rect keeps its painted ends.
    public static Image PlateArt(RectTransform _0xf17b8b3b, Sprite _0xa38fb664, Color _0x48c1e54d)
    {
        Image _0x43f46a43 = _0xf17b8b3b.gameObject.AddComponent<Image>();
        _0x43f46a43.type = Image.Type.Sliced;
        _0x43f46a43.sprite = _0xa38fb664;
        _0x43f46a43.color = _0x48c1e54d;
        _0x43f46a43.pixelsPerUnitMultiplier = 1f;
        _0x43f46a43.raycastTarget = false;
        _0xf17b8b3b.gameObject.AddComponent<_0x729c17a3>()._0x06bdcd15(_0x43f46a43, 1f);
        return _0x43f46a43;
    }

    // Box pinned to the parent's LEFT edge; cx is its centre's distance from that edge.
    public static RectTransform LeftBox(Transform _0xbeb65529, string _0xa510c73c, float _0x8cefc8d0, float _0x8b851161, float _0x8142c50f, float _0xe1c9e37a)
    {
        return Node(_0xbeb65529, _0xa510c73c, new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0x8cefc8d0, _0x8b851161), new Vector2(_0x8142c50f, _0xe1c9e37a));
    }

    // A Button over our own face. AddComponent inherits the default tint block, so the
    // normal colour is reset to white here - otherwise a face handed to a button whose
    // block came from the template would be multiplied to transparent black at rest.
    public static Button Touchable(RectTransform _0xca4ee3f4, Graphic _0x053b80d8)
    {
        Button _0xd8a19c54 = _0xca4ee3f4.gameObject.AddComponent<Button>();
        _0xd8a19c54.transition = Selectable.Transition.ColorTint;
        _0xd8a19c54.targetGraphic = _0x053b80d8;
        ColorBlock _0x7c0e042c = _0xd8a19c54.colors;
        _0x7c0e042c.normalColor = Color.white;
        _0x7c0e042c.highlightedColor = Color.white;
        _0x7c0e042c.selectedColor = Color.white;
        _0x7c0e042c.pressedColor = new Color(0.76f, 0.70f, 0.70f, 1f);
        _0x7c0e042c.disabledColor = new Color(0.52f, 0.52f, 0.52f, 1f);
        _0x7c0e042c.colorMultiplier = 1f;
        _0x7c0e042c.fadeDuration = 0.08f;
        _0xd8a19c54.colors = _0x7c0e042c;
        return _0xd8a19c54;
    }

    // Centre of the box sits `cyFromBottom` above the parent's bottom edge.
    public static RectTransform BottomBox(Transform _0xe74e97e7, string _0x974df30b, float _0x448b981d, float _0x94646a46, float _0xc2bc2ae2, float _0xbecd573a)
    {
        return Node(_0xe74e97e7, _0x974df30b, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(_0x448b981d, _0x94646a46), new Vector2(_0xc2bc2ae2, _0xbecd573a));
    }

    // Content art: the picture keeps its own proportions. Every generated sprite comes
    // back square, so a square rect shows the painted subject at the intended width and
    // preserveAspect then guarantees it is never squashed.
    public static Image Picture(RectTransform _0x016a8517, Sprite _0x4a3d0015, Color _0x216a3f5f)
    {
        Image _0x35301b32 = _0x016a8517.gameObject.AddComponent<Image>();
        _0x35301b32.preserveAspect = true;
        _0x35301b32.sprite = _0x4a3d0015;
        _0x35301b32.type = Image.Type.Simple;
        _0x35301b32.color = _0x216a3f5f;
        _0x35301b32.raycastTarget = false;
        if (_0x4a3d0015 == null)
        {
            // An Image with no sprite draws a solid white quad. If the art never
            // arrived, draw nothing at all rather than a white block.
            _0x35301b32.enabled = false;
        }

        return _0x35301b32;
    }

    // A framed call to action: plate (gilt) then body (velvet, inset) then caption LAST,
    // so the label is always drawn on top (C.13 / E.1). Light letters on a dark body,
    // which is what keeps the single shared dark outline readable (C.14).
    public static Button Cta(RectTransform _0x77fe84d1, TMP_FontAsset _0x3c821ea5, Sprite _0x751a1999, Sprite _0xd90becd5, string _0xe0eaaba3, float _0x3386dec3, Color _0xb5f4e158, Color _0x7f98dee0, Color _0x8cfa9946)
    {
        Image _0x5708be5a = _0x751a1999 != null ? PlateArt(_0x77fe84d1, _0x751a1999, Color.white) : Plate(_0x77fe84d1, _0xd90becd5, _0xb5f4e158, 1.9f);
        _0x5708be5a.raycastTarget = true;
        if (_0x751a1999 == null)
        {
            RectTransform _0x66926425 = Stretch(_0x77fe84d1, _0x77fe84d1.gameObject.name + _0xab08760c._0x3c9b79f9(new byte[4] { 92, 113, 122, 103 }, 30));
            _0x66926425.offsetMin = new Vector2(7f, 7f);
            _0x66926425.offsetMax = new Vector2(-7f, -7f);
            Plate(_0x66926425, _0xd90becd5, _0x7f98dee0, 2.2f);
        }

        RectTransform _0x5fe4ccd0 = Stretch(_0x77fe84d1, _0x77fe84d1.gameObject.name + _0xab08760c._0x3c9b79f9(new byte[7] { 178, 144, 129, 133, 152, 158, 159 }, 241));
        _0x5fe4ccd0.offsetMin = new Vector2(30f, 12f);
        _0x5fe4ccd0.offsetMax = new Vector2(-30f, -12f);
        Label(_0x5fe4ccd0, _0x3c821ea5, _0xe0eaaba3, _0x3386dec3, _0x8cfa9946, TextAlignmentOptions.Center);
        return Touchable(_0x77fe84d1, _0x5708be5a);
    }

    // A box placed at a fraction of the parent's height, measured from the BOTTOM.
    public static RectTransform FracBox(Transform _0x93aebe7c, string _0x4a87a404, float _0x1309e4d6, float _0xe43512f9, float _0xf36cd9ca, float _0xafcde860)
    {
        return Node(_0x93aebe7c, _0x4a87a404, new Vector2(_0x1309e4d6, _0xe43512f9), new Vector2(_0x1309e4d6, _0xe43512f9), Vector2.zero, new Vector2(_0xf36cd9ca, _0xafcde860));
    }

    // Box pinned to the parent's RIGHT edge; cx is its centre's distance from that edge.
    public static RectTransform RightBox(Transform _0xe4e45b0e, string _0x94837622, float _0x8914eaac, float _0x67b56ded, float _0xe727db66, float _0xb1217621)
    {
        return Node(_0xe4e45b0e, _0x94837622, new Vector2(1f, 0.5f), new Vector2(1f, 0.5f), new Vector2(-_0x8914eaac, _0x67b56ded), new Vector2(_0xe727db66, _0xb1217621));
    }

    // A horizontal track with its own fill. The fill is anchored to the LEFT edge and
    // grows by width, so it never drifts the way a centred bar does.
    public static RectTransform Meter(RectTransform _0x6adff278, Sprite _0x3a55dec1, Color _0x558a9ae8, Color _0x126d30f1, float width)
    {
        Plate(_0x6adff278, _0x3a55dec1, _0x558a9ae8, 1.6f);
        RectTransform _0xb381c696 = Node(_0x6adff278, _0x6adff278.gameObject.name + _0xab08760c._0x3c9b79f9(new byte[4] { 144, 191, 186, 186 }, 214), new Vector2(0f, 0f), new Vector2(0f, 1f), Vector2.zero, new Vector2(width, 0f));
        _0xb381c696.pivot = new Vector2(0f, 0.5f);
        _0xb381c696.anchoredPosition = Vector2.zero;
        Plate(_0xb381c696, _0x3a55dec1, _0x126d30f1, 1.6f);
        return _0xb381c696;
    }

    // ---- interaction --------------------------------------------------------
    // A fully transparent Image is CULLED by the raycaster, so a hit layer uses alpha
    // 0.004 and switches culling off; otherwise the control silently does nothing.
    public static Image HitLayer(RectTransform _0xa87ddbf8)
    {
        Image _0xbc459119 = _0xa87ddbf8.gameObject.AddComponent<Image>();
        _0xbc459119.color = new Color(1f, 1f, 1f, 0.004f);
        _0xbc459119.raycastTarget = true;
        if (_0xbc459119.canvasRenderer != null)
        {
            _0xbc459119.canvasRenderer.cullTransparentMesh = false;
        }

        return _0xbc459119;
    }

    public static void SetMeter(RectTransform _0x665ee946, float _0x608663dc, float _0x5de457ef)
    {
        if (_0x665ee946 == null)
        {
            return;
        }

        float _0x4b8fb555 = Mathf.Clamp01(_0x5de457ef);
        _0x665ee946.sizeDelta = new Vector2(_0x608663dc * _0x4b8fb555, 0f);
    }

    // A flat tinted quad (washes, veils, bar fills). No sprite, so no asset can go
    // missing; only used where a plain rectangle is what the design wants.
    public static Image Quad(RectTransform _0x601ecaf3, Color _0x1a940aee)
    {
        Image _0x7cc2ce9d = _0x601ecaf3.gameObject.AddComponent<Image>();
        _0x7cc2ce9d.color = _0x1a940aee;
        _0x7cc2ce9d.raycastTarget = false;
        return _0x7cc2ce9d;
    }

    // Centre of the box sits `cyFromTop` below the parent's top edge.
    public static RectTransform TopBox(Transform _0xdabb4180, string _0xe88d0ab3, float _0x4b30f1ad, float _0x0fbdacde, float _0x0facb0c8, float _0x444a34e3)
    {
        return Node(_0xdabb4180, _0xe88d0ab3, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(_0x4b30f1ad, -_0x0fbdacde), new Vector2(_0x0facb0c8, _0x444a34e3));
    }

    public static void SetActive(Component _0x29165cd2, bool _0xa5271ea2)
    {
        if (_0x29165cd2 != null && _0x29165cd2.gameObject.activeSelf != _0xa5271ea2)
        {
            _0x29165cd2.gameObject.SetActive(_0xa5271ea2);
        }
    }

    // A round icon button (back, pause, close). The glyph is drawn over the plate and
    // the plate is the raycast target, so the whole disc is tappable.
    public static Button IconButton(RectTransform _0x3923f3c4, TMP_FontAsset _0xe82c5c39, Sprite _0x23aea6e4, Sprite _0x630d69fa, Sprite _0x9f6bdcda, string _0x61dde132, Color _0xa0bea026, Color _0x6876c77e)
    {
        // The round plate art is square and is drawn in a square rect, so it keeps its
        // own proportions rather than being sliced: two 110 px borders of a 250 px
        // source would overlap inside a 132 unit button.
        Image _0x31eff240 = _0x23aea6e4 != null ? Picture(_0x3923f3c4, _0x23aea6e4, Color.white) : Plate(_0x3923f3c4, _0x630d69fa, _0xa0bea026, 1.25f);
        _0x31eff240.raycastTarget = true;
        if (_0x9f6bdcda != null)
        {
            RectTransform _0xd912281d = Stretch(_0x3923f3c4, _0x3923f3c4.gameObject.name + _0xab08760c._0x3c9b79f9(new byte[5] { 4, 47, 58, 51, 43 }, 67));
            _0xd912281d.offsetMin = new Vector2(26f, 26f);
            _0xd912281d.offsetMax = new Vector2(-26f, -26f);
            Picture(_0xd912281d, _0x9f6bdcda, Color.white);
        }
        else
        {
            RectTransform _0xa8d08ba3 = Stretch(_0x3923f3c4, _0x3923f3c4.gameObject.name + _0xab08760c._0x3c9b79f9(new byte[4] { 168, 132, 151, 142 }, 229));
            Label(_0xa8d08ba3, _0xe82c5c39, _0x61dde132, 44f, _0x6876c77e, TextAlignmentOptions.Center);
        }

        return Touchable(_0x3923f3c4, _0x31eff240);
    }

    public static TextMeshProUGUI Label(RectTransform _0x6b43b1d6, TMP_FontAsset _0x394c7027, string _0x54a00da5, float _0x56ec0482, Color _0x1c0a0619, TextAlignmentOptions _0x6ca1fb01)
    {
        TextMeshProUGUI _0x3d62e282 = _0x6b43b1d6.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x394c7027 != null)
        {
            _0x3d62e282.font = _0x394c7027;
        }

        _0x3d62e282.alignment = _0x6ca1fb01;
        _0x3d62e282.text = _0x54a00da5;
        _0x1bad1984.Apply(_0x3d62e282, _0x56ec0482, _0x1c0a0619);
        return _0x3d62e282;
    }

    // A full stretch child. `new GameObject(name, typeof(RectTransform))` starts at
    // 100x100 anchored at the centre, which would silently resolve every grandchild
    // against 100x100 - so a host is stretched immediately after parenting, never later.
    public static RectTransform Stretch(Transform _0x08b95c59, string _0x4d79aeb7)
    {
        return Node(_0x08b95c59, _0x4d79aeb7, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
    }

    public static RectTransform CentreBox(Transform _0xe3f86c4d, string _0xf0edb3b9, float _0xc8c72d33, float _0x0f965e2b, float _0xb50c45aa, float _0x866b7812)
    {
        return Node(_0xe3f86c4d, _0xf0edb3b9, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0xc8c72d33, _0x0f965e2b), new Vector2(_0xb50c45aa, _0x866b7812));
    }

    // A full screen backdrop. This is the one case where the art does NOT keep its own
    // proportions (F.2a): a backdrop has to cover the device, and preserving the aspect
    // would leave bars down the sides.
    public static Image Backdrop(RectTransform _0xf5902d34, Sprite _0x8be10f81)
    {
        Image _0x58abd2ca = _0xf5902d34.gameObject.AddComponent<Image>();
        _0x58abd2ca.type = Image.Type.Simple;
        _0x58abd2ca.sprite = _0x8be10f81;
        _0x58abd2ca.preserveAspect = false;
        _0x58abd2ca.color = Color.white;
        _0x58abd2ca.raycastTarget = false;
        if (_0x8be10f81 == null)
        {
            _0x58abd2ca.enabled = false;
        }

        return _0x58abd2ca;
    }

    // ---- graphics -----------------------------------------------------------
    // A 9-slice plate. `sliced` is the template's own rounded plate, handed in by the
    // scene root, so there is never a missing sprite white rectangle (B.1) and the
    // multiplier is the corner radius lever (lower means rounder). `radius` is a FLOOR,
    // not the final value - see ClubPlateFit.
    public static Image Plate(RectTransform _0xa89e03ed, Sprite _0xfea13c4b, Color _0x48208df2, float _0x0f98293d)
    {
        Image _0x8e432b36 = _0xa89e03ed.gameObject.AddComponent<Image>();
        _0x8e432b36.type = Image.Type.Sliced;
        _0x8e432b36.sprite = _0xfea13c4b;
        _0x8e432b36.color = _0x48208df2;
        _0x8e432b36.pixelsPerUnitMultiplier = _0x0f98293d;
        _0x8e432b36.raycastTarget = false;
        _0xa89e03ed.gameObject.AddComponent<_0x729c17a3>()._0x06bdcd15(_0x8e432b36, _0x0f98293d);
        return _0x8e432b36;
    }
}

internal static class _0xab08760c
{
    internal static string _0x3c9b79f9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}