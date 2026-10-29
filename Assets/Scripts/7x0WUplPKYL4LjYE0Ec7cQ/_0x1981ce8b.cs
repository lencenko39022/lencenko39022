using DG.Tweening;
using TMPro;
using UnityEngine;

// The opening screen: a gilt mark on a deep wash, a single caption and the line the law
// of the hall is built on. No chips, no cards, no call to action - it must not read as
// the lobby, because two neighbouring frames that look the same are a defect in the
// review album.
//
// The panel body holds the template's loading bar and nothing else, so anything added
// here would be drawn over it. The existing children are captured first and pushed back
// to last, which keeps the bar on top of the wash.
//
// No name anywhere: the mark is an abstract emblem and the captions are functional.
public sealed class _0x1981ce8b : MonoBehaviour
{
    public void _0xaa7d9ae8(TMP_FontAsset _0x6fd983a0, Sprite _0xb04a9115, Sprite _0x6daa3ee4, Sprite _0xe1a12d53)
    {
        _0x5bc6383a _0x56f80578 = _0x5bc6383a.Instance;
        if (_0x56f80578 == null || _0x56f80578.Panels == null || _0x56f80578.Panels.Count <= _0xa93ecf08._0x27eba83c.SPLASH)
        {
            return;
        }

        _0xd8539b11 _0x92f627c3 = _0x56f80578.Panels[_0xa93ecf08._0x27eba83c.SPLASH];
        if (_0x92f627c3 == null || _0x92f627c3.Content == null)
        {
            return;
        }

        Transform _0x3b159cd3 = _0x92f627c3.Content.transform;
        int _0xb3602387 = _0x3b159cd3.childCount;
        Transform[] _0x4bfcc2fb = new Transform[_0xb3602387];
        for (int _0x0cbb71cf = 0; _0x0cbb71cf < _0xb3602387; _0x0cbb71cf++)
        {
            _0x4bfcc2fb[_0x0cbb71cf] = _0x3b159cd3.GetChild(_0x0cbb71cf);
        }

        RectTransform _0xd1706a32 = _0x891ecf84.Stretch(_0x3b159cd3, _0xaa55ca5f._0xb64c92ea(new byte[12] { 197, 250, 239, 228, 227, 228, 237, 206, 248, 239, 249, 249 }, 138));
        _0xd1706a32.SetAsFirstSibling();
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[12] { 26, 37, 48, 59, 60, 59, 50, 23, 57, 48, 48, 49 }, 85), 600f), _0xc5c3f38d.Ink);
        _0x891ecf84.Backdrop(_0x891ecf84.Bleed(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[10] { 105, 86, 67, 72, 79, 72, 65, 103, 84, 82 }, 38), 160f), _0x6daa3ee4);
        // A far heavier wash than either of the two live screens: this is what makes
        // the opening frame unmistakably different from the lobby behind it.
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[11] { 9, 54, 35, 40, 47, 40, 33, 17, 39, 53, 46 }, 70), 600f), _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.88f));
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[11] { 110, 81, 68, 79, 72, 79, 70, 117, 72, 79, 85 }, 33), 600f), _0xc5c3f38d.With(_0xc5c3f38d.RubyDeep, 0.16f));
        // A drape across the top, drawn rather than drafted from art, so the opening
        // reads as a stage even before a single picture has loaded.
        RectTransform _0x166691f0 = _0x891ecf84.Node(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[11] { 56, 7, 18, 25, 30, 25, 16, 36, 0, 22, 16 }, 119), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -110f), new Vector2(0f, 220f));
        _0x891ecf84.Plate(_0x166691f0, _0xb04a9115, _0xc5c3f38d.With(_0xc5c3f38d.RubyDeep, 0.92f), 2.6f);
        RectTransform _0x42b0290a = _0x891ecf84.Node(_0x166691f0, _0xaa55ca5f._0xb64c92ea(new byte[15] { 86, 105, 124, 119, 112, 119, 126, 74, 110, 120, 126, 77, 107, 112, 116 }, 25), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0f, 5f), new Vector2(-40f, 10f));
        _0x891ecf84.Plate(_0x42b0290a, _0xb04a9115, _0xc5c3f38d.Gold, 1.3f);
        RectTransform _0x60d7be54 = _0x891ecf84.FracBox(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[11] { 204, 243, 230, 237, 234, 237, 228, 206, 226, 241, 232 }, 131), 0.5f, 0.60f, 420f, 420f);
        if (_0xe1a12d53 != null)
        {
            _0x891ecf84.Picture(_0x60d7be54, _0xe1a12d53, Color.white);
        }
        else
        {
            _0x891ecf84.Plate(_0x60d7be54, _0xb04a9115, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.92f), 1.4f);
            RectTransform _0x10ba51a4 = _0x891ecf84.Stretch(_0x60d7be54, _0xaa55ca5f._0xb64c92ea(new byte[16] { 194, 253, 232, 227, 228, 227, 234, 192, 236, 255, 230, 196, 227, 227, 232, 255 }, 141));
            _0x10ba51a4.offsetMin = new Vector2(18f, 18f);
            _0x10ba51a4.offsetMax = new Vector2(-18f, -18f);
            _0x891ecf84.Plate(_0x10ba51a4, _0xb04a9115, _0xc5c3f38d.VelvetDeep, 1.6f);
        }

        RectTransform _0x265f63b9 = _0x891ecf84.FracBox(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[14] { 205, 242, 231, 236, 235, 236, 229, 193, 227, 242, 246, 235, 237, 236 }, 130), 0.5f, 0.30f, 900f, 76f);
        TextMeshProUGUI _0x651ff56f = _0x891ecf84.Label(_0x265f63b9, _0x6fd983a0, _0xaa55ca5f._0xb64c92ea(new byte[7] { 48, 51, 61, 56, 53, 50, 59 }, 124), 44f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        _0x651ff56f.characterSpacing = 14f;
        RectTransform _0xa740551d = _0x891ecf84.FracBox(_0xd1706a32, _0xaa55ca5f._0xb64c92ea(new byte[12] { 153, 166, 179, 184, 191, 184, 177, 154, 179, 177, 183, 186 }, 214), 0.5f, 0.175f, 1040f, 54f);
        _0x891ecf84.Label(_0xa740551d, _0x6fd983a0, _0xaa55ca5f._0xb64c92ea(new byte[37] { 107, 98, 122, 10, 22, 15, 9, 122, 119, 122, 9, 21, 25, 19, 27, 22, 122, 10, 22, 27, 3, 122, 119, 122, 20, 21, 122, 8, 31, 27, 22, 122, 23, 21, 20, 31, 3 }, 90), 30f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        CanvasGroup _0xbcf3fd4c = _0xd1706a32.gameObject.AddComponent<CanvasGroup>();
        _0xbcf3fd4c.alpha = 0f;
        DOTween.To(() => _0xbcf3fd4c.alpha, _0x671b8410 => _0xbcf3fd4c.alpha = _0x671b8410, 1f, 0.32f).SetLink(_0xd1706a32.gameObject);
        _0x60d7be54.localScale = Vector3.one * 0.88f;
        _0x60d7be54.DOScale(1f, 0.5f).SetEase(Ease.OutBack).SetLink(_0x60d7be54.gameObject);
        for (int _0x2186dbdc = 0; _0x2186dbdc < _0xb3602387; _0x2186dbdc++)
        {
            if (_0x4bfcc2fb[_0x2186dbdc] != null)
            {
                _0x4bfcc2fb[_0x2186dbdc].SetAsLastSibling();
            }
        }
    }
}

internal static class _0xaa55ca5f
{
    internal static string _0xb64c92ea(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}