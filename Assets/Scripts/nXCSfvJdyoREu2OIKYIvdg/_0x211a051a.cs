using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Small factory for the club's UGUI widgets. Everything it builds is anchored
/// explicitly, so no layout component is needed and the result is identical on
/// every aspect ratio. Draw order follows creation order: a plate is always made
/// before the content that sits on it.
/// </summary>
public static class _0x211a051a
{
    /// <summary>
    /// A button: plate, then optional icon, then the label LAST so the caption is on top.
    /// The caller subscribes with a lambda - never a method group.
    /// </summary>
    public static Button Action(RectTransform _0x0f612988, string _0xc0c8d465, TMP_FontAsset _0x05e19db4, Sprite _0x921c31f4, string _0xc34315ec, float _0x331aa624, Color _0x02af6c9b, Color _0xdb2a25f4, Color _0xa1659ed5, float _0x1a707a4c, float _0xa66a0a89, float width, float height)
    {
        RectTransform _0xdd75d2de = Box(_0x0f612988, _0xc0c8d465, _0x1a707a4c, _0xa66a0a89, width, height);
        Image _0x10a59fea = Plate(_0xdd75d2de, _0xb0a51841._0xd4586776(new byte[5] { 25, 45, 62, 50, 58 }, 95), _0x921c31f4, _0xdb2a25f4, 2.2f);
        _0x10a59fea.raycastTarget = true;
        RectTransform _0x26a0882d = Node(_0xdd75d2de, _0xb0a51841._0xd4586776(new byte[5] { 38, 1, 1, 10, 29 }, 111), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
        Plate(_0x26a0882d, _0xb0a51841._0xd4586776(new byte[4] { 124, 83, 86, 86 }, 58), _0x921c31f4, _0x02af6c9b, 2.4f);
        if (!string.IsNullOrEmpty(_0xc34315ec))
            Caption(_0xdd75d2de, _0xb0a51841._0xd4586776(new byte[7] { 110, 76, 93, 89, 68, 66, 67 }, 45), _0x05e19db4, _0xc34315ec, _0x331aa624, _0xa1659ed5, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-28f, -16f));
        Button _0x19eaaacc = _0xdd75d2de.gameObject.AddComponent<Button>();
        _0x19eaaacc.targetGraphic = _0x10a59fea;
        _0x19eaaacc.transition = Selectable.Transition.ColorTint;
        ColorBlock _0xc36cce5b = _0x19eaaacc.colors;
        _0xc36cce5b.normalColor = Color.white;
        _0xc36cce5b.highlightedColor = new Color(1f, 1f, 1f, 1f);
        _0xc36cce5b.pressedColor = new Color(0.78f, 0.72f, 0.56f, 1f);
        _0xc36cce5b.selectedColor = Color.white;
        _0xc36cce5b.disabledColor = new Color(0.55f, 0.5f, 0.5f, 0.75f);
        _0xc36cce5b.fadeDuration = 0.08f;
        _0x19eaaacc.colors = _0xc36cce5b;
        return _0x19eaaacc;
    }

    /// <summary>Point-anchored box: x/y are fractions of the parent, size is in reference pixels.</summary>
    public static RectTransform Box(RectTransform _0xf723d525, string _0x5389187d, float _0x98dfc52f, float _0x30f20745, float width, float height)
    {
        Vector2 _0x7cc84133 = new Vector2(_0x98dfc52f, _0x30f20745);
        return Node(_0xf723d525, _0x5389187d, _0x7cc84133, _0x7cc84133, Vector2.zero, new Vector2(width, height));
    }

    /// <summary>
    /// A caption. The colour must always be a light palette tone: one shared dark
    /// outline is used for the whole app, so a dark face would read as a blot.
    /// </summary>
    public static TextMeshProUGUI Caption(RectTransform _0x337d8d65, string _0xf91594b7, TMP_FontAsset _0xb0970dec, string _0x40d0fcb7, float _0xc94310a2, Color _0x6e720d46, TextAlignmentOptions _0x5ec6f3df, Vector2 _0x0431af0e, Vector2 _0x832a91f4, Vector2 _0xf0be1460, Vector2 _0x515b9d23)
    {
        RectTransform _0x4fc76320 = Node(_0x337d8d65, _0xf91594b7, _0x0431af0e, _0x832a91f4, _0xf0be1460, _0x515b9d23);
        TextMeshProUGUI _0x7446547e = _0x4fc76320.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xb0970dec != null)
            _0x7446547e.font = _0xb0970dec;
        if (_0x7446547e.font == null)
            _0x7446547e.font = TMP_Settings.defaultFontAsset;
        if (_0x7446547e.font != null && _0x7446547e.fontSharedMaterial == null)
            _0x7446547e.fontSharedMaterial = _0x7446547e.font.material;
        _0x7446547e.text = _0x40d0fcb7;
        _0x7446547e.color = _0x6e720d46;
        _0x7446547e.alignment = _0x5ec6f3df;
        _0x7446547e.raycastTarget = false;
        _0xf9bbd821.ApplyFlow(_0x7446547e, _0xc94310a2);
        _0xf9bbd821.ApplyOutline(_0x7446547e);
        return _0x7446547e;
    }

    public static RectTransform Stretch(RectTransform _0xcb6016b1, string _0x141b7976)
    {
        return Node(_0xcb6016b1, _0x141b7976, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
    }

    /// <summary>Left edge of the text column - gutter right edge plus a 32 px gap.</summary>
    public const float TextLeft = 168f;
    /// <summary>Caption filling its parent with a padding inset.</summary>
    public static TextMeshProUGUI Fill(RectTransform _0x499ca3d3, string _0x0e83c85d, TMP_FontAsset _0x5a765745, string _0x831f9173, float _0x74f50680, Color _0x462a8ec6, TextAlignmentOptions _0xc2131c56, float _0xdee1b938)
    {
        return Caption(_0x499ca3d3, _0x0e83c85d, _0x5a765745, _0x831f9173, _0x74f50680, _0x462a8ec6, _0xc2131c56, Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-_0xdee1b938 * 2f, -_0xdee1b938 * 2f));
    }

    public static RectTransform Node(RectTransform _0xfa99462e, string _0xe47fb3f6, Vector2 _0xc323a6fd, Vector2 _0x5164de26, Vector2 _0x34b344b7, Vector2 _0xc89018c9)
    {
        GameObject _0xb487e792 = new GameObject(_0xe47fb3f6, typeof(RectTransform));
        RectTransform _0x44eca79a = _0xb487e792.GetComponent<RectTransform>();
        _0x44eca79a.SetParent(_0xfa99462e, false);
        _0x44eca79a.anchorMin = _0xc323a6fd;
        _0x44eca79a.anchorMax = _0x5164de26;
        _0x44eca79a.pivot = new Vector2(0.5f, 0.5f);
        _0x44eca79a.anchoredPosition = _0x34b344b7;
        _0x44eca79a.sizeDelta = _0xc89018c9;
        _0x44eca79a.localScale = Vector3.one;
        return _0x44eca79a;
    }

    /// <summary>A themed sheet: gold hairline frame with a velvet interior.</summary>
    public static RectTransform Sheet(RectTransform _0x6f0b471f, string _0xd1bebe50, float _0x4c1501c4, float _0x671b8410, float width, float height, Sprite _0xc5c3f38d, Color _0xc6f60014, Color _0xa4a5c00e, float _0xb44def58)
    {
        RectTransform _0x729c17a3 = Box(_0x6f0b471f, _0xd1bebe50, _0x4c1501c4, _0x671b8410, width, height);
        Plate(_0x729c17a3, _0xb0a51841._0xd4586776(new byte[5] { 113, 69, 86, 90, 82 }, 55), _0xc5c3f38d, _0xa4a5c00e, 2.2f);
        RectTransform _0x06bdcd15 = Node(_0x729c17a3, _0xb0a51841._0xd4586776(new byte[5] { 197, 226, 226, 233, 254 }, 140), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-_0xb44def58, -_0xb44def58));
        Plate(_0x06bdcd15, _0xb0a51841._0xd4586776(new byte[4] { 22, 57, 60, 60 }, 80), _0xc5c3f38d, _0xc6f60014, 2.4f);
        return _0x06bdcd15;
    }

    /// <summary>A 9-sliced plate. Pass a sliced sprite; a null sprite gives a flat rectangle.</summary>
    public static Image Plate(RectTransform _0xfca7fad7, string _0x8ec9b494, Sprite _0xe77ca311, Color _0x065d56af, float _0x7d7cd7b1)
    {
        RectTransform _0x58949a1e = Stretch(_0xfca7fad7, _0x8ec9b494);
        Image _0xe2574135 = _0x58949a1e.gameObject.AddComponent<Image>();
        _0xe2574135.sprite = _0xe77ca311;
        _0xe2574135.type = _0xe77ca311 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xe2574135.color = _0x065d56af;
        _0xe2574135.raycastTarget = false;
        _0xe2574135.pixelsPerUnitMultiplier = Mathf.Max(0.01f, _0x7d7cd7b1);
        return Slice(_0xe2574135, Mathf.Max(0.01f, _0x7d7cd7b1));
    }

    /// <summary>A content picture: Simple type with preserveAspect, never stretched.</summary>
    public static Image Picture(RectTransform _0xdb76c888, string _0x29ae6ddf, Sprite _0x62ddfec0, float _0xe7302b8f, float _0xb9c6b6c2, float width, float height, Color _0x912dd2f0)
    {
        RectTransform _0xa4c7b1d9 = Box(_0xdb76c888, _0x29ae6ddf, _0xe7302b8f, _0xb9c6b6c2, width, height);
        Image _0x05db5bfd = _0xa4c7b1d9.gameObject.AddComponent<Image>();
        _0x05db5bfd.sprite = _0x62ddfec0;
        _0x05db5bfd.type = Image.Type.Simple;
        _0x05db5bfd.preserveAspect = true;
        _0x05db5bfd.color = _0x912dd2f0;
        _0x05db5bfd.raycastTarget = false;
        if (_0x62ddfec0 == null)
            _0x05db5bfd.enabled = false;
        return _0x05db5bfd;
    }

    /// <summary>Caption in a point-anchored box.</summary>
    public static TextMeshProUGUI Label(RectTransform _0x82082b76, string _0x8e624fe3, TMP_FontAsset _0xb9f3f286, string _0x8506a94b, float _0x32c083b3, Color _0x10827951, TextAlignmentOptions _0x0b56dd7f, float _0x44964b69, float _0x348cc641, float width, float height)
    {
        Vector2 _0x476e4d80 = new Vector2(_0x44964b69, _0x348cc641);
        return Caption(_0x82082b76, _0x8e624fe3, _0xb9f3f286, _0x8506a94b, _0x32c083b3, _0x10827951, _0x0b56dd7f, _0x476e4d80, _0x476e4d80, Vector2.zero, new Vector2(width, height));
    }

    public const float TextWidth = 800f;
    public const float RowBodyWidth = 1050f;
    /// <summary>A horizontal bar whose fill is driven by SetBar.</summary>
    public static Image Bar(RectTransform _0x15ab5d04, string _0xec73e7d1, Sprite _0x8ba06358, float _0xc0eec4d8, float _0xbd721d55, float width, float height, Color _0x9c9fbe12, Color _0x79299594)
    {
        RectTransform _0x0dcf96d1 = Box(_0x15ab5d04, _0xec73e7d1, _0xc0eec4d8, _0xbd721d55, width, height);
        Plate(_0x0dcf96d1, _0xb0a51841._0xd4586776(new byte[5] { 10, 44, 63, 61, 53 }, 94), _0x8ba06358, _0x9c9fbe12, 2.8f);
        RectTransform _0x3560247b = Node(_0x0dcf96d1, _0xb0a51841._0xd4586776(new byte[4] { 57, 22, 19, 19 }, 127), new Vector2(0f, 0f), new Vector2(0f, 1f), Vector2.zero, new Vector2(width, 0f));
        _0x3560247b.pivot = new Vector2(0f, 0.5f);
        _0x3560247b.anchoredPosition = Vector2.zero;
        Image _0x692fdf49 = _0x3560247b.gameObject.AddComponent<Image>();
        _0x692fdf49.sprite = _0x8ba06358;
        _0x692fdf49.type = _0x8ba06358 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x692fdf49.color = _0x79299594;
        _0x692fdf49.raycastTarget = false;
        _0x692fdf49.pixelsPerUnitMultiplier = 2.8f;
        Slice(_0x692fdf49, 2.8f);
        return _0x692fdf49;
    }

    /// <summary>Centre of the icon / indicator gutter of a list row (reference pixels).</summary>
    public const float GutterCentre = 92f;
    /// <summary>A thin divider line.</summary>
    public static Image Rule(RectTransform _0x3cf74407, string _0xca4a1cd3, Sprite _0xaf173d28, float _0xc915322b, float _0xbcb47b3e, float width, Color _0xc497e21f)
    {
        RectTransform _0x4044c4e3 = Box(_0x3cf74407, _0xca4a1cd3, _0xc915322b, _0xbcb47b3e, width, 4f);
        Image _0x228db458 = _0x4044c4e3.gameObject.AddComponent<Image>();
        _0x228db458.sprite = _0xaf173d28;
        _0x228db458.type = _0xaf173d28 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x228db458.color = _0xc497e21f;
        _0x228db458.raycastTarget = false;
        _0x228db458.pixelsPerUnitMultiplier = 6f;
        return Slice(_0x228db458, 6f);
    }

    /// <summary>
    /// Keeps a 9-sliced image out of the sliver case: the border stays a fixed pixel
    /// size, so a small rect needs a higher multiplier than a large one. The literal
    /// the caller passed stays as the floor - how round the plate looks when it is big
    /// enough to have the choice.
    /// </summary>
    public static Image Slice(Image _0x4313fabb, float _0xc7c767ff)
    {
        if (_0x4313fabb == null || _0x4313fabb.type != Image.Type.Sliced)
            return _0x4313fabb;
        _0x4313fabb.gameObject.AddComponent<_0x650516ea>()._0x5cdd8b4d(_0x4313fabb, _0xc7c767ff);
        return _0x4313fabb;
    }

    public const float GutterWidth = 88f;
    public static void SetBar(Image _0x9bc3b625, float _0x61e57c8e, float _0x81501b9c)
    {
        if (_0x9bc3b625 == null)
            return;
        RectTransform _0xb0eac4fa = _0x9bc3b625.rectTransform;
        _0xb0eac4fa.sizeDelta = new Vector2(Mathf.Clamp01(_0x61e57c8e) * _0x81501b9c, 0f);
    }
}

internal static class _0xb0a51841
{
    internal static string _0xd4586776(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}