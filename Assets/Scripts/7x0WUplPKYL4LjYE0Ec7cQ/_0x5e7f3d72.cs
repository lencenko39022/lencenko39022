using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Front of house. Everything the guest sees before taking a seat lives here: the drape,
// the gilt mark, the credit meter, the chosen table, the way in, and the eight doors
// that open the sheets.
//
// Three layers, in this order, because sibling order IS draw order (C.13 / E.1):
//   MenuBack   first sibling  - backdrop, wash, drape, glow
//   (the template's own button slot sits between them - our face is its CHILD, so a tap
//    on the face bubbles up to the button the template already wired)
//   MenuFront  last sibling   - meter, mark, cards, doors, and every sheet
//
// The eight doors stay visible while a sheet is open and each one swaps the sheet for
// another, so no screen ever has to be closed before the next one can be reached.
public sealed class _0x5e7f3d72 : MonoBehaviour
{
    private TextMeshProUGUI _0xabf5aab0;
    private void _0x2ccc56d1(RectTransform _0x96170c6c)
    {
        string[] _0x381835d7 =
        {
            _0xa175eae4._0xfb4c2031(new byte[7] { 123, 126, 117, 101, 118, 101, 110 }, 55),
            _0xa175eae4._0xfb4c2031(new byte[5] { 211, 214, 222, 219, 206 }, 151),
            _0xa175eae4._0xfb4c2031(new byte[8] { 80, 84, 78, 78, 84, 82, 83, 78 }, 29),
            _0xa175eae4._0xfb4c2031(new byte[7] { 196, 194, 207, 207, 198, 209, 218 }, 131)
        };
        string[] _0x54335333 =
        {
            _0xa175eae4._0xfb4c2031(new byte[8] { 140, 142, 147, 155, 142, 153, 143, 143 }, 220),
            _0xa175eae4._0xfb4c2031(new byte[7] { 108, 110, 115, 122, 117, 112, 121 }, 60),
            _0xa175eae4._0xfb4c2031(new byte[5] { 104, 111, 118, 127, 105 }, 58),
            _0xa175eae4._0xfb4c2031(new byte[8] { 14, 24, 9, 9, 20, 19, 26, 14 }, 93)
        };
        int[] _0x352db87f =
        {
            _0x7446547e.SheetLibrary,
            _0x7446547e.SheetDaily,
            _0x7446547e.SheetMissions,
            _0x7446547e.SheetGallery
        };
        int[] _0x5132cc7f =
        {
            _0x7446547e.SheetProgress,
            _0x7446547e.SheetProfile,
            _0x7446547e.SheetRules,
            _0x7446547e.SheetSettings
        };
        float[] _0x50168e86 =
        {
            0.17f,
            0.39f,
            0.61f,
            0.83f
        };
        for (int _0x7f0bc460 = 0; _0x7f0bc460 < 4; _0x7f0bc460++)
        {
            this._0xe7d541b5(_0x96170c6c, _0x381835d7[_0x7f0bc460], _0x50168e86[_0x7f0bc460], NavRowOne, _0x352db87f[_0x7f0bc460]);
            this._0xe7d541b5(_0x96170c6c, _0x54335333[_0x7f0bc460], _0x50168e86[_0x7f0bc460], NavRowTwo, _0x5132cc7f[_0x7f0bc460]);
        }
    }

    private TextMeshProUGUI _0x3cbefeb7;
    private TextMeshProUGUI _0x2eef5d44;
    // The meter is never updated silently: it rolls to its new figure and the pill
    // gives a short pulse, so a claim is visible in a still frame (C.7).
    public void _0xef910fb8(int _0x0bc7ee54, int _0x45c2e03a)
    {
        this._0x3ebf3aa2();
        if (this._0xabf5aab0 == null)
        {
            return;
        }

        int _0x388b2ad7 = _0x0bc7ee54;
        DOTween.To(() => _0x388b2ad7, _0x16f7baa9 =>
        {
            _0x388b2ad7 = _0x16f7baa9;
            _0x1bad1984.SetText(this._0xabf5aab0, _0x1bad1984.Credits(_0x16f7baa9));
        }, _0x45c2e03a, _0xbbd798a9.NumberRollSeconds).SetEase(Ease.OutQuad).SetLink(this._0xabf5aab0.gameObject);
        if (this._0x4512cb41 != null)
        {
            this._0x4512cb41.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.4f, 1, 0.5f).SetLink(this._0x4512cb41.gameObject);
        }
    }

    private const float SheetBottom = 0.44f;
    // --- state ----------------------------------------------------------------
    private void _0x0a75ad3d()
    {
        this._0x55da9a76(_0x7446547e.SheetLibrary);
    }

    private void _0xd578f20e(RectTransform _0xd8c998fc)
    {
        RectTransform _0x4bc9fd33 = _0x891ecf84.TopBox(_0xd8c998fc, _0xa175eae4._0xfb4c2031(new byte[11] { 62, 29, 16, 16, 11, 38, 29, 2, 48, 19, 0 }, 114), 0f, 175f, PanelWidth - 120f, 96f);
        RectTransform _0xc07ff068 = _0x891ecf84.LeftBox(_0x4bc9fd33, _0xa175eae4._0xfb4c2031(new byte[8] { 154, 169, 166, 163, 139, 160, 161, 184 }, 200), 150f, 0f, 300f, 92f);
        _0x891ecf84.Plate(_0xc07ff068, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.VelvetLit, 0.94f), 1.5f);
        RectTransform _0x17263a46 = _0x891ecf84.Stretch(_0xc07ff068, _0xa175eae4._0xfb4c2031(new byte[12] { 83, 96, 111, 106, 66, 105, 104, 113, 68, 101, 102, 100 }, 1));
        _0x17263a46.offsetMin = new Vector2(4f, 4f);
        _0x17263a46.offsetMax = new Vector2(-4f, -4f);
        _0x891ecf84.Plate(_0x17263a46, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Velvet, 1f), 1.7f);
        RectTransform _0x2385e9ef = _0x891ecf84.Stretch(_0xc07ff068, _0xa175eae4._0xfb4c2031(new byte[12] { 14, 61, 50, 55, 31, 52, 53, 44, 8, 57, 36, 40 }, 92));
        _0x2385e9ef.offsetMin = new Vector2(18f, 8f);
        _0x2385e9ef.offsetMax = new Vector2(-18f, -8f);
        this._0x3cbefeb7 = _0x891ecf84.Label(_0x2385e9ef, this._0x8780a545, _0xa175eae4._0xfb4c2031(new byte[7] { 74, 89, 86, 83, 56, 40, 41 }, 24), 36f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        RectTransform _0xf4ed9fb9 = _0x891ecf84.RightBox(_0x4bc9fd33, _0xa175eae4._0xfb4c2031(new byte[10] { 175, 158, 137, 136, 133, 152, 188, 133, 128, 128 }, 236), 210f, 0f, 420f, 96f);
        this._0x4512cb41 = _0xf4ed9fb9;
        _0x891ecf84.Plate(_0xf4ed9fb9, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.92f), 1.4f);
        RectTransform _0xbd595b88 = _0x891ecf84.Stretch(_0xf4ed9fb9, _0xa175eae4._0xfb4c2031(new byte[14] { 231, 214, 193, 192, 205, 208, 244, 205, 200, 200, 230, 203, 192, 221 }, 164));
        _0xbd595b88.offsetMin = new Vector2(5f, 5f);
        _0xbd595b88.offsetMax = new Vector2(-5f, -5f);
        _0x891ecf84.Plate(_0xbd595b88, this._0xf1119fe8, _0xc5c3f38d.Velvet, 1.6f);
        RectTransform _0xce1bf324 = _0x891ecf84.Stretch(_0xf4ed9fb9, _0xa175eae4._0xfb4c2031(new byte[14] { 232, 217, 206, 207, 194, 223, 251, 194, 199, 199, 255, 206, 211, 223 }, 171));
        _0xce1bf324.offsetMin = new Vector2(24f, 10f);
        _0xce1bf324.offsetMax = new Vector2(-24f, -10f);
        // The box is sized for seven figures so the number never reflows as it grows.
        this._0xabf5aab0 = _0x891ecf84.Label(_0xce1bf324, this._0x8780a545, _0xa175eae4._0xfb4c2031(new byte[7] { 69, 69, 69, 69, 69, 69, 69 }, 117), 46f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0x5699e7c2;
    // Panel geometry. The body is the template's own panel rect, 1242 x 2688 at the
    // canvas reference, and every number below is in those units.
    public const float PanelWidth = 1242f;
    private const float ScrimBottom = 0.43f;
    private void _0x55da9a76(int _0x37de6245)
    {
        if (this._0x9ea29096 != null)
        {
            this._0x9ea29096._0xc2131c56(_0x37de6245);
        }
    }

    private void _0x1e234df1(RectTransform _0x90f587d0)
    {
        RectTransform _0xd85c7d68 = _0x891ecf84.FracBox(_0x90f587d0, _0xa175eae4._0xfb4c2031(new byte[14] { 55, 20, 25, 25, 2, 47, 26, 25, 23, 30, 56, 26, 9, 31 }, 123), 0.5f, 0.525f, 1042f, 220f);
        Image _0xca06ef94 = _0x891ecf84.Plate(_0xd85c7d68, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.9f), 2.2f);
        _0xca06ef94.raycastTarget = true;
        RectTransform _0x75595b9a = _0x891ecf84.Stretch(_0xd85c7d68, _0xa175eae4._0xfb4c2031(new byte[14] { 1, 34, 47, 47, 52, 25, 44, 47, 33, 40, 15, 34, 41, 52 }, 77));
        _0x75595b9a.offsetMin = new Vector2(7f, 7f);
        _0x75595b9a.offsetMax = new Vector2(-7f, -7f);
        _0x891ecf84.Plate(_0x75595b9a, this._0xf1119fe8, _0xc5c3f38d.Velvet, 2.4f);
        // Two columns that never share x space (C.25): the crest keeps the left gutter
        // to itself and the text column starts a clear gap to its right.
        RectTransform _0xa6637480 = _0x891ecf84.LeftBox(_0xd85c7d68, _0xa175eae4._0xfb4c2031(new byte[15] { 149, 182, 187, 187, 160, 141, 184, 187, 181, 188, 154, 171, 188, 170, 173 }, 217), 96f, 0f, 132f, 176f);
        _0x891ecf84.Plate(_0xa6637480, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.RubyDeep, 0.95f), 1.6f);
        RectTransform _0x64af33ee = _0x891ecf84.Stretch(_0xa6637480, _0xa175eae4._0xfb4c2031(new byte[19] { 38, 5, 8, 8, 19, 62, 11, 8, 6, 15, 41, 24, 15, 25, 30, 47, 14, 13, 15 }, 106));
        _0x64af33ee.offsetMin = new Vector2(5f, 5f);
        _0x64af33ee.offsetMax = new Vector2(-5f, -5f);
        _0x891ecf84.Plate(_0x64af33ee, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.75f), 1.8f);
        const float _0x040382d3 = 196f; // gutter right edge 162 plus a 34 gap
        const float _0x058cbd4e = 806f; // 196 + 806 = 1002 <= 1042 - 40
        RectTransform _0x85ca1ea2 = _0x891ecf84.Node(_0xd85c7d68, _0xa175eae4._0xfb4c2031(new byte[15] { 213, 246, 251, 251, 224, 205, 248, 251, 245, 252, 205, 240, 237, 245, 252 }, 153), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0x040382d3 + _0x058cbd4e * 0.5f, 34f), new Vector2(_0x058cbd4e, 62f));
        this._0x5699e7c2 = _0x891ecf84.Label(_0x85ca1ea2, this._0x8780a545, _0xa175eae4._0xfb4c2031(new byte[14] { 82, 91, 72, 86, 95, 75, 79, 83, 84, 58, 82, 91, 86, 86 }, 26), 46f, _0xc5c3f38d.Gold, TextAlignmentOptions.Left);
        RectTransform _0xc993f3ad = _0x891ecf84.Node(_0xd85c7d68, _0xa175eae4._0xfb4c2031(new byte[14] { 43, 8, 5, 5, 30, 51, 6, 5, 11, 2, 43, 14, 9, 2 }, 103), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0x040382d3 + _0x058cbd4e * 0.5f, -34f), new Vector2(_0x058cbd4e, 48f));
        this._0x2eef5d44 = _0x891ecf84.Label(_0xc993f3ad, this._0x8780a545, "", 30f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Left);
        Button _0x223b4fc1 = _0x891ecf84.Touchable(_0xd85c7d68, _0xca06ef94);
        _0x223b4fc1.onClick.AddListener(() => this._0x0a75ad3d());
    }

    private const float PlayFraction = 0.385f;
    private const float NavRowOne = 0.255f;
    private Sprite _0xcdf952d6;
    private RectTransform _0x85732262;
    private void _0x1079053f(RectTransform _0xe1fe1add)
    {
        RectTransform _0x4895f564 = _0x891ecf84.FracBox(_0xe1fe1add, _0xa175eae4._0xfb4c2031(new byte[10] { 30, 61, 48, 48, 43, 30, 55, 53, 51, 62 }, 82), 0.5f, 0.045f, 1100f, 50f);
        TextMeshProUGUI _0x8bc3d537 = _0x891ecf84.Label(_0x4895f564, this._0x8780a545, _0xa175eae4._0xfb4c2031(new byte[49] { 1, 8, 16, 96, 124, 101, 99, 16, 29, 16, 99, 127, 115, 121, 113, 124, 16, 96, 124, 113, 105, 16, 29, 16, 126, 127, 16, 98, 117, 113, 124, 16, 125, 127, 126, 117, 105, 16, 29, 16, 126, 127, 16, 96, 98, 121, 106, 117, 99 }, 48), 27f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        _0x8bc3d537.characterSpacing = 2f;
    }

    private RectTransform _0x5f7ac4c4;
    private const float NavRowTwo = 0.145f;
    private Sprite _0xf6013265;
    public void _0x3ebf3aa2()
    {
        _0x1bad1984.SetText(this._0xabf5aab0, _0x1bad1984.Credits(this._0x017f53a6._0xb8844111));
        int _0x8170e3ef = _0x8e9129d3.RankFor(this._0x017f53a6._0x75a6ad47);
        _0x1bad1984.SetText(this._0x3cbefeb7, _0xa175eae4._0xfb4c2031(new byte[5] { 59, 40, 39, 34, 73 }, 105) + _0x1bad1984.Pad2(_0x8170e3ef));
        _0x9aaba7e8 _0xf4931647 = _0xdfaf60d5.At(this._0x017f53a6._0x97795416);
        _0x1bad1984.SetText(this._0x5699e7c2, _0xf4931647._0x374268d8);
        _0x1bad1984.SetText(this._0x2eef5d44, _0xf4931647._0x7f1ca861);
    }

    private _0xe54e0344 _0x017f53a6;
    private void _0x1f16f7fe(RectTransform _0xc194c18c)
    {
        RectTransform _0x634fd4b0 = _0x891ecf84.FracBox(_0xc194c18c, _0xa175eae4._0xfb4c2031(new byte[9] { 220, 255, 242, 242, 233, 221, 241, 226, 251 }, 144), 0.5f, 0.745f, 460f, 460f);
        this._0x85732262 = _0x634fd4b0;
        if (this._0x29b0646c != null)
        {
            _0x891ecf84.Picture(_0x634fd4b0, this._0x29b0646c, Color.white);
        }
        else
        {
            _0x891ecf84.Plate(_0x634fd4b0, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.9f), 1.4f);
            RectTransform _0x4a3a1ba6 = _0x891ecf84.Stretch(_0x634fd4b0, _0xa175eae4._0xfb4c2031(new byte[14] { 116, 87, 90, 90, 65, 117, 89, 74, 83, 113, 86, 86, 93, 74 }, 56));
            _0x4a3a1ba6.offsetMin = new Vector2(22f, 22f);
            _0x4a3a1ba6.offsetMax = new Vector2(-22f, -22f);
            _0x891ecf84.Plate(_0x4a3a1ba6, this._0xf1119fe8, _0xc5c3f38d.VelvetDeep, 1.6f);
        }

        _0x634fd4b0.DOScale(1.04f, 3.2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x634fd4b0.gameObject);
    }

    private void _0xe7d541b5(RectTransform _0xbbcbc642, string _0x7d7fb64f, float _0x650516ea, float _0x5cdd8b4d, int _0xf656b64b)
    {
        RectTransform _0x58e860f0 = _0x891ecf84.FracBox(_0xbbcbc642, _0xa175eae4._0xfb4c2031(new byte[4] { 98, 73, 73, 84 }, 38) + _0x7d7fb64f, _0x650516ea, _0x5cdd8b4d, 252f, 150f);
        Image _0xe889afdf = _0x891ecf84.Plate(_0x58e860f0, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.72f), 1.8f);
        _0xe889afdf.raycastTarget = true;
        RectTransform _0x8bf91f45 = _0x891ecf84.Stretch(_0x58e860f0, _0xa175eae4._0xfb4c2031(new byte[4] { 100, 79, 79, 82 }, 32) + _0x7d7fb64f + _0xa175eae4._0xfb4c2031(new byte[4] { 178, 159, 148, 137 }, 240));
        _0x8bf91f45.offsetMin = new Vector2(5f, 5f);
        _0x8bf91f45.offsetMax = new Vector2(-5f, -5f);
        _0x891ecf84.Plate(_0x8bf91f45, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.VelvetLit, 0.97f), 2f);
        RectTransform _0x339db8da = _0x891ecf84.Node(_0x58e860f0, _0xa175eae4._0xfb4c2031(new byte[4] { 207, 228, 228, 249 }, 139) + _0x7d7fb64f + _0xa175eae4._0xfb4c2031(new byte[3] { 158, 189, 174 }, 220), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0f, 14f), new Vector2(-40f, 8f));
        _0x891ecf84.Plate(_0x339db8da, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.85f), 1.3f);
        RectTransform _0xafa22ded = _0x891ecf84.Stretch(_0x58e860f0, _0xa175eae4._0xfb4c2031(new byte[4] { 25, 50, 50, 47 }, 93) + _0x7d7fb64f + _0xa175eae4._0xfb4c2031(new byte[7] { 73, 107, 122, 126, 99, 101, 100 }, 10));
        _0xafa22ded.offsetMin = new Vector2(14f, 26f);
        _0xafa22ded.offsetMax = new Vector2(-14f, -14f);
        _0x891ecf84.Label(_0xafa22ded, this._0x8780a545, _0x7d7fb64f, 32f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        Button _0x78b9c5e9 = _0x891ecf84.Touchable(_0x58e860f0, _0xe889afdf);
        _0x78b9c5e9.onClick.AddListener(() => this._0x55da9a76(_0xf656b64b));
    }

    public const float PanelHeight = 2688f;
    private const float SheetTop = 0.97f;
    private _0x542b1bfd _0x80ae13cb;
    public void _0xc1d0722f(Transform _0x591f6af6, RectTransform _0x1350390e, _0xe54e0344 _0x17d1e39e, _0x9a16fc44 _0x9f4a1da1, _0x542b1bfd _0xc4e668a5, TMP_FontAsset _0x8a8a319e, Sprite _0xba99eabc, Sprite _0xaef00ddc, Sprite _0x3ee86412, Sprite _0x723e5842, Sprite _0x0191faec, Sprite[] _0x3a6333f3)
    {
        this._0x017f53a6 = _0x17d1e39e;
        this._0xc26ae5b6 = _0x9f4a1da1;
        this._0x80ae13cb = _0xc4e668a5;
        this._0x8780a545 = _0x8a8a319e;
        this._0xf1119fe8 = _0xba99eabc;
        this._0xcdf952d6 = _0xaef00ddc;
        this._0xf6013265 = _0x3ee86412;
        this._0x29b0646c = _0x0191faec;
        RectTransform _0x551feb11 = _0x891ecf84.Stretch(_0x591f6af6, _0xa175eae4._0xfb4c2031(new byte[8] { 38, 14, 5, 30, 41, 10, 8, 0 }, 107));
        _0x551feb11.SetAsFirstSibling();
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0x551feb11, _0xa175eae4._0xfb4c2031(new byte[9] { 119, 95, 84, 79, 120, 86, 95, 95, 94 }, 58), 600f), _0xc5c3f38d.Ink);
        _0x891ecf84.Backdrop(_0x891ecf84.Bleed(_0x551feb11, _0xa175eae4._0xfb4c2031(new byte[7] { 239, 199, 204, 215, 227, 208, 214 }, 162), 160f), _0x723e5842);
        // A lighter wash than the opening screen's, so the two never read as one frame.
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0x551feb11, _0xa175eae4._0xfb4c2031(new byte[8] { 159, 183, 188, 167, 133, 179, 161, 186 }, 210), 600f), _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.58f));
        _0x891ecf84.Quad(_0x891ecf84.Bleed(_0x551feb11, _0xa175eae4._0xfb4c2031(new byte[8] { 117, 93, 86, 77, 108, 81, 86, 76 }, 56), 600f), _0xc5c3f38d.With(_0xc5c3f38d.Velvet, 0.42f));
        this._0x9bd5779e(_0x551feb11);
        this._0x25979831(_0x1350390e);
        RectTransform _0x30c5181b = _0x891ecf84.Stretch(_0x591f6af6, _0xa175eae4._0xfb4c2031(new byte[9] { 53, 29, 22, 13, 62, 10, 23, 22, 12 }, 120));
        _0x30c5181b.SetAsLastSibling();
        this._0x5f7ac4c4 = _0x30c5181b;
        this._0xd578f20e(_0x30c5181b);
        this._0x1f16f7fe(_0x30c5181b);
        this._0xb2747d4d(_0x30c5181b);
        this._0x1e234df1(_0x30c5181b);
        this._0x2ccc56d1(_0x30c5181b);
        this._0x1079053f(_0x30c5181b);
        this._0x9ea29096 = this.gameObject.AddComponent<_0x7446547e>();
        this._0x9ea29096._0x82082b76(this, _0x30c5181b, _0x17d1e39e, _0x9f4a1da1, _0xc4e668a5, _0x8a8a319e, _0xba99eabc, _0xaef00ddc, _0x3ee86412, _0x0191faec, _0x3a6333f3, SheetBottom, SheetTop, ScrimBottom);
        _0x3a4fb5e9 _0x26a9f772 = this.gameObject.AddComponent<_0x3a4fb5e9>();
        _0x26a9f772._0x2b503346(_0x30c5181b, this._0x9ea29096, _0x8a8a319e, _0xba99eabc, _0xaef00ddc, _0x0191faec);
        this._0x3ebf3aa2();
    }

    private _0x9a16fc44 _0xc26ae5b6;
    private Sprite _0xf1119fe8;
    private RectTransform _0x4512cb41;
    // --- layers ---------------------------------------------------------------
    private void _0x9bd5779e(RectTransform _0xe9191ddd)
    {
        RectTransform _0x92798245 = _0x891ecf84.Node(_0xe9191ddd, _0xa175eae4._0xfb4c2031(new byte[8] { 11, 35, 40, 51, 21, 49, 39, 33 }, 70), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -120f), new Vector2(0f, 240f));
        _0x891ecf84.Plate(_0x92798245, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.RubyDeep, 0.95f), 2.6f);
        RectTransform _0x34a620d8 = _0x891ecf84.Node(_0x92798245, _0xa175eae4._0xfb4c2031(new byte[12] { 56, 16, 27, 0, 38, 2, 20, 18, 33, 7, 28, 24 }, 117), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0f, 6f), new Vector2(-40f, 12f));
        _0x891ecf84.Plate(_0x34a620d8, this._0xf1119fe8, _0xc5c3f38d.Gold, 1.3f);
        // Footlights: a warm band rising from the bottom edge, drawn as two stacked
        // plates fading out, never as a shape with an edge.
        RectTransform _0x890c6535 = _0x891ecf84.Node(_0xe9191ddd, _0xa175eae4._0xfb4c2031(new byte[11] { 69, 109, 102, 125, 79, 100, 103, 127, 68, 103, 127 }, 8), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0f, 90f), new Vector2(0f, 180f));
        _0x891ecf84.Plate(_0x890c6535, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.10f), 1.6f);
        RectTransform _0x0822014e = _0x891ecf84.Node(_0xe9191ddd, _0xa175eae4._0xfb4c2031(new byte[12] { 154, 178, 185, 162, 144, 187, 184, 160, 159, 190, 176, 191 }, 215), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0f, 230f), new Vector2(0f, 280f));
        _0x891ecf84.Plate(_0x0822014e, this._0xf1119fe8, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.05f), 1.6f);
    }

    private void OnDestroy()
    {
        // The drifting mark runs for as long as the menu does, so it is killed with it
        // rather than left to animate an object that no longer exists (C.56).
        if (this._0x85732262 != null)
        {
            DOTween.Kill(this._0x85732262);
        }

        if (this._0x4512cb41 != null)
        {
            DOTween.Kill(this._0x4512cb41);
        }
    }

    private void _0xb2747d4d(RectTransform _0x926ecd54)
    {
        RectTransform _0xdfd59e06 = _0x891ecf84.FracBox(_0x926ecd54, _0xa175eae4._0xfb4c2031(new byte[14] { 198, 229, 232, 232, 243, 197, 232, 224, 239, 233, 254, 227, 252, 239 }, 138), 0.5f, 0.625f, 1060f, 58f);
        TextMeshProUGUI _0xdbbfdf5a = _0x891ecf84.Label(_0xdfd59e06, this._0x8780a545, _0xa175eae4._0xfb4c2031(new byte[42] { 34, 54, 33, 33, 68, 39, 44, 45, 52, 55, 68, 73, 68, 42, 45, 35, 44, 48, 40, 61, 68, 35, 45, 34, 48, 55, 68, 73, 68, 42, 43, 68, 54, 33, 37, 40, 68, 41, 43, 42, 33, 61 }, 100), 34f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        _0xdbbfdf5a.characterSpacing = 4f;
    }

    public RectTransform _0xa0cd89da => this._0x5f7ac4c4;

    private TMP_FontAsset _0x8780a545;
    private _0x7446547e _0x9ea29096;
    private Sprite _0x29b0646c;
    public void _0x2ecda3c3()
    {
        if (this._0x85732262 != null)
        {
            this._0x85732262.DOPunchScale(new Vector3(0.06f, 0.06f, 0f), 0.4f, 1, 0.5f).SetLink(this._0x85732262.gameObject);
        }
    }

    // The template's button is already wired to open the table; it just has no face.
    // Ours is added as its CHILD with a raycast target, so the tap bubbles up to the
    // button above it and nothing has to be rewired.
    private void _0x25979831(RectTransform _0x03be6e46)
    {
        if (_0x03be6e46 == null)
        {
            return;
        }

        RectTransform _0x42b28b1e = _0x891ecf84.Stretch(_0x03be6e46, _0xa175eae4._0xfb4c2031(new byte[8] { 36, 24, 21, 13, 50, 21, 23, 17 }, 116));
        Image _0x9b2aacdc = this._0xcdf952d6 != null ? _0x891ecf84.PlateArt(_0x42b28b1e, this._0xcdf952d6, Color.white) : _0x891ecf84.Plate(_0x42b28b1e, this._0xf1119fe8, _0xc5c3f38d.Gold, 1.6f);
        _0x9b2aacdc.raycastTarget = true;
        if (this._0xcdf952d6 == null)
        {
            RectTransform _0xa6d61189 = _0x891ecf84.Stretch(_0x42b28b1e, _0xa175eae4._0xfb4c2031(new byte[8] { 166, 154, 151, 143, 180, 153, 146, 143 }, 246));
            _0xa6d61189.offsetMin = new Vector2(8f, 8f);
            _0xa6d61189.offsetMax = new Vector2(-8f, -8f);
            _0x891ecf84.Plate(_0xa6d61189, this._0xf1119fe8, _0xc5c3f38d.Ruby, 2.1f);
        }

        RectTransform _0xf86e409c = _0x891ecf84.Stretch(_0x42b28b1e, _0xa175eae4._0xfb4c2031(new byte[11] { 228, 216, 213, 205, 247, 213, 196, 192, 221, 219, 218 }, 180));
        _0xf86e409c.offsetMin = new Vector2(40f, 16f);
        _0xf86e409c.offsetMax = new Vector2(-40f, -16f);
        TextMeshProUGUI _0xe5780cf0 = _0x891ecf84.Label(_0xf86e409c, this._0x8780a545, _0xa175eae4._0xfb4c2031(new byte[4] { 91, 71, 74, 82 }, 11), 64f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        _0xe5780cf0.characterSpacing = 10f;
        _0x42b28b1e.localScale = Vector3.one * 0.9f;
        _0x42b28b1e.DOScale(1f, 0.38f).SetEase(Ease.OutBack).SetLink(_0x42b28b1e.gameObject);
    }
}

internal static class _0xa175eae4
{
    internal static string _0xfb4c2031(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}