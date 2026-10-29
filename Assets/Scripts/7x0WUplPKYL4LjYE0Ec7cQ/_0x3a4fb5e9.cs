using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The notice every guest meets before the lobby: this is entertainment, the credits are
// free, they have no value and there is nothing to buy.
//
// It is shown once per app launch rather than once per install. A guest who walks back
// out of a table and into the lobby is not asked twice in the same visit, and a fresh
// launch always opens on the notice - which is also what makes a walkthrough of the app
// start from the same frame every time.
//
// Two live controls, both of which do something visible: the first puts the notice away
// and reveals the lobby, the second turns the card over to the house rules and back.
// There is no third button to quit - a control with nothing behind it is a defect.
public sealed class _0x3a4fb5e9 : MonoBehaviour
{
    private void _0xd1bebe50()
    {
        _0x61a87ed0 = true;
        if (this._0x0d4fd91e == null)
        {
            return;
        }

        CanvasGroup _0x4c1501c4 = this._0x0d4fd91e.gameObject.GetComponent<CanvasGroup>();
        if (_0x4c1501c4 == null)
        {
            _0x4c1501c4 = this._0x0d4fd91e.gameObject.AddComponent<CanvasGroup>();
        }

        _0x4c1501c4.blocksRaycasts = false;
        _0x4c1501c4.interactable = false;
        DOTween.To(() => _0x4c1501c4.alpha, _0x671b8410 => _0x4c1501c4.alpha = _0x671b8410, 0f, 0.28f).OnComplete(() => this._0xefada1a7()).SetLink(this._0x0d4fd91e.gameObject);
    }

    private void _0x065d56af()
    {
        this._0x4778c17d = true;
        this._0x44eca79a();
        RectTransform _0x7d7cd7b1 = _0x891ecf84.TopBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[12] { 212, 242, 240, 199, 224, 249, 240, 230, 221, 240, 244, 241 }, 149), 0f, 140f, 880f, 90f);
        TextMeshProUGUI _0x58949a1e = _0x891ecf84.Label(_0x7d7cd7b1, this._0x18ef2216, _0xda6881ff._0x4d73c26b(new byte[11] { 241, 246, 236, 234, 252, 153, 235, 236, 245, 252, 234 }, 185), 60f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        _0x58949a1e.characterSpacing = 6f;
        RectTransform _0xe2574135 = _0x891ecf84.TopBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[12] { 50, 20, 22, 33, 6, 31, 22, 0, 49, 28, 23, 10 }, 115), 0f, 520f, 920f, 560f);
        _0x891ecf84.Label(_0xe2574135, this._0x18ef2216, _0xda6881ff._0x4d73c26b(new byte[302] { 131, 154, 144, 152, 243, 146, 243, 128, 150, 146, 135, 243, 146, 157, 151, 243, 146, 243, 128, 135, 146, 152, 150, 253, 217, 135, 155, 129, 150, 150, 243, 144, 156, 159, 134, 158, 157, 128, 243, 128, 135, 156, 131, 243, 156, 157, 243, 149, 154, 133, 150, 243, 159, 154, 157, 150, 128, 253, 217, 135, 155, 129, 150, 150, 243, 158, 146, 135, 144, 155, 154, 157, 148, 243, 149, 146, 144, 150, 128, 243, 131, 146, 138, 243, 135, 155, 150, 243, 159, 154, 157, 150, 253, 217, 135, 155, 150, 243, 132, 154, 159, 151, 243, 158, 146, 128, 152, 243, 128, 135, 146, 157, 151, 128, 243, 154, 157, 243, 149, 156, 129, 243, 146, 157, 138, 243, 149, 146, 144, 150, 253, 217, 217, 144, 129, 150, 151, 154, 135, 128, 243, 146, 129, 150, 243, 149, 129, 150, 150, 243, 146, 157, 151, 243, 144, 146, 157, 157, 156, 135, 243, 145, 150, 243, 145, 156, 134, 148, 155, 135, 253, 217, 129, 134, 157, 157, 154, 157, 148, 243, 156, 134, 135, 243, 144, 156, 128, 135, 128, 243, 157, 156, 135, 155, 154, 157, 148, 243, 254, 217, 135, 155, 150, 243, 155, 156, 134, 128, 150, 243, 129, 150, 149, 154, 159, 159, 128, 243, 138, 156, 134, 129, 243, 128, 150, 146, 135, 253, 217, 217, 150, 133, 150, 129, 138, 243, 129, 156, 134, 157, 151, 243, 154, 128, 243, 151, 129, 146, 132, 157, 243, 156, 157, 243, 154, 135, 128, 243, 156, 132, 157, 253, 217, 135, 146, 152, 150, 243, 145, 129, 150, 146, 152, 128, 253, 243, 135, 155, 150, 129, 150, 243, 154, 128, 243, 157, 156, 135, 155, 154, 157, 148, 243, 135, 156, 243, 144, 155, 146, 128, 150, 253 }, 211), 32f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        RectTransform _0x4313fabb = _0x891ecf84.BottomBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[12] { 63, 25, 27, 44, 11, 18, 27, 13, 60, 31, 29, 21 }, 126), 0f, 190f, 700f, 150f);
        Button _0xc7c767ff = _0x891ecf84.Cta(_0x4313fabb, this._0x18ef2216, this._0x6bc19ebf, this._0xb7c0a090, _0xda6881ff._0x4d73c26b(new byte[18] { 236, 239, 237, 229, 142, 250, 225, 142, 250, 230, 235, 142, 224, 225, 250, 231, 237, 235 }, 174), 40f, _0xc5c3f38d.Gold, _0xc5c3f38d.Ruby, _0xc5c3f38d.Cream);
        _0xc7c767ff.onClick.AddListener(() => this._0x6f0b471f());
    }

    private Sprite _0x27c9bffa;
    private RectTransform _0x0d4fd91e;
    public void _0x2b503346(RectTransform _0x44cebdde, _0x7446547e _0x211a051a, TMP_FontAsset _0xfa99462e, Sprite _0xe47fb3f6, Sprite _0xc323a6fd, Sprite _0x5164de26)
    {
        this._0x74d49d96 = _0x211a051a;
        this._0x18ef2216 = _0xfa99462e;
        this._0xb7c0a090 = _0xe47fb3f6;
        this._0x6bc19ebf = _0xc323a6fd;
        this._0x27c9bffa = _0x5164de26;
        if (_0x61a87ed0)
        {
            return;
        }

        this._0x0d4fd91e = _0x891ecf84.Stretch(_0x44cebdde, _0xda6881ff._0x4d73c26b(new byte[9] { 245, 211, 209, 250, 219, 192, 221, 215, 209 }, 180));
        this._0x0d4fd91e.SetAsLastSibling();
        Image _0x34b344b7 = _0x891ecf84.Quad(_0x891ecf84.Bleed(this._0x0d4fd91e, _0xda6881ff._0x4d73c26b(new byte[7] { 192, 230, 228, 215, 228, 232, 237 }, 129), 600f), _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.93f));
        _0x34b344b7.raycastTarget = true;
        RectTransform _0xc89018c9 = _0x891ecf84.FracBox(this._0x0d4fd91e, _0xda6881ff._0x4d73c26b(new byte[7] { 34, 4, 6, 32, 2, 17, 7 }, 99), 0.5f, 0.52f, 1042f, 1180f);
        _0x891ecf84.Plate(_0xc89018c9, this._0xb7c0a090, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.95f), 2.2f);
        RectTransform _0xb487e792 = _0x891ecf84.Stretch(_0xc89018c9, _0xda6881ff._0x4d73c26b(new byte[11] { 221, 251, 249, 223, 253, 238, 248, 222, 243, 248, 229 }, 156));
        _0xb487e792.offsetMin = new Vector2(8f, 8f);
        _0xb487e792.offsetMax = new Vector2(-8f, -8f);
        _0x891ecf84.Plate(_0xb487e792, this._0xb7c0a090, _0xc5c3f38d.Velvet, 2.4f);
        this._0xad6aa7f1 = _0x891ecf84.Stretch(_0xc89018c9, _0xda6881ff._0x4d73c26b(new byte[14] { 98, 68, 70, 96, 66, 81, 71, 96, 76, 77, 87, 70, 77, 87 }, 35));
        this._0xf723d525();
        _0xc89018c9.localScale = Vector3.one * 0.94f;
        _0xc89018c9.DOScale(1f, 0.36f).SetEase(Ease.OutBack).SetLink(_0xc89018c9.gameObject);
    }

    private void _0xf723d525()
    {
        this._0x4778c17d = false;
        this._0x44eca79a();
        RectTransform _0x5389187d = _0x891ecf84.TopBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[7] { 124, 90, 88, 112, 92, 79, 86 }, 61), 0f, 150f, 200f, 200f);
        if (this._0x27c9bffa != null)
        {
            _0x891ecf84.Picture(_0x5389187d, this._0x27c9bffa, Color.white);
        }
        else
        {
            _0x891ecf84.Plate(_0x5389187d, this._0xb7c0a090, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.9f), 1.4f);
        }

        RectTransform _0x98dfc52f = _0x891ecf84.TopBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[7] { 226, 196, 198, 235, 198, 194, 199 }, 163), 0f, 318f, 880f, 96f);
        TextMeshProUGUI _0x30f20745 = _0x891ecf84.Label(_0x98dfc52f, this._0x18ef2216, _0xda6881ff._0x4d73c26b(new byte[11] { 74, 79, 94, 71, 95, 88, 43, 68, 69, 71, 82 }, 11), 70f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        _0x30f20745.characterSpacing = 8f;
        RectTransform _0x717eff50 = _0x891ecf84.TopBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[7] { 243, 213, 215, 240, 221, 214, 203 }, 178), 0f, 560f, 920f, 330f);
        _0x891ecf84.Label(_0x717eff50, this._0x18ef2216, _0xda6881ff._0x4d73c26b(new byte[147] { 122, 102, 103, 125, 14, 103, 125, 14, 107, 96, 122, 107, 124, 122, 111, 103, 96, 99, 107, 96, 122, 14, 97, 96, 98, 119, 0, 36, 109, 124, 107, 106, 103, 122, 125, 14, 111, 124, 107, 14, 104, 124, 107, 107, 14, 111, 96, 106, 14, 102, 111, 120, 107, 14, 96, 97, 14, 120, 111, 98, 123, 107, 0, 36, 122, 102, 107, 119, 14, 109, 111, 96, 96, 97, 122, 14, 108, 107, 14, 108, 97, 123, 105, 102, 122, 2, 14, 125, 97, 98, 106, 2, 36, 121, 103, 122, 102, 106, 124, 111, 121, 96, 14, 97, 124, 14, 107, 118, 109, 102, 111, 96, 105, 107, 106, 0, 36, 96, 97, 14, 126, 124, 103, 116, 107, 125, 0, 14, 96, 97, 14, 124, 107, 111, 98, 14, 99, 97, 96, 107, 119, 14, 126, 98, 111, 119, 0 }, 46), 36f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        RectTransform _0x2a587ca2 = _0x891ecf84.BottomBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[10] { 156, 186, 184, 158, 178, 179, 187, 180, 175, 176 }, 221), 0f, 290f, 800f, 160f);
        Button _0x7cc84133 = _0x891ecf84.Cta(_0x2a587ca2, this._0x18ef2216, this._0x6bc19ebf, this._0xb7c0a090, _0xda6881ff._0x4d73c26b(new byte[16] { 231, 142, 239, 227, 142, 159, 150, 142, 225, 252, 142, 225, 226, 234, 235, 252 }, 174), 44f, _0xc5c3f38d.Gold, _0xc5c3f38d.Ruby, _0xc5c3f38d.Cream);
        _0x7cc84133.onClick.AddListener(() => this._0xd1bebe50());
        RectTransform _0xfca7fad7 = _0x891ecf84.BottomBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[8] { 68, 98, 96, 87, 112, 105, 96, 118 }, 5), 0f, 140f, 600f, 116f);
        Button _0x8ec9b494 = _0x891ecf84.Cta(_0xfca7fad7, this._0x18ef2216, null, this._0xb7c0a090, _0xda6881ff._0x4d73c26b(new byte[14] { 213, 194, 198, 195, 167, 211, 207, 194, 167, 213, 210, 203, 194, 212 }, 135), 36f, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.6f), _0xc5c3f38d.VelvetDeep, _0xc5c3f38d.Gold);
        _0x8ec9b494.onClick.AddListener(() => this._0x6f0b471f());
        RectTransform _0xe77ca311 = _0x891ecf84.BottomBox(this._0xad6aa7f1, _0xda6881ff._0x4d73c26b(new byte[8] { 100, 66, 64, 105, 64, 66, 68, 73 }, 37), 0f, 48f, 940f, 52f);
        _0x891ecf84.Label(_0xe77ca311, this._0x18ef2216, _0xda6881ff._0x4d73c26b(new byte[35] { 33, 40, 40, 34, 39, 32, 43, 78, 67, 78, 32, 33, 78, 47, 45, 45, 33, 59, 32, 58, 78, 67, 78, 32, 33, 78, 62, 59, 60, 45, 38, 47, 61, 43, 61 }, 110), 27f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
    }

    private _0x7446547e _0x74d49d96;
    private static bool _0x61a87ed0;
    private Sprite _0xb7c0a090;
    private RectTransform _0xad6aa7f1;
    private void _0x6f0b471f()
    {
        if (this._0x4778c17d)
        {
            this._0xf723d525();
        }
        else
        {
            this._0x065d56af();
        }

        if (this._0xad6aa7f1 != null)
        {
            this._0xad6aa7f1.localScale = new Vector3(0.96f, 1f, 1f);
            this._0xad6aa7f1.DOScaleX(1f, 0.3f).SetEase(Ease.OutBack).SetLink(this._0xad6aa7f1.gameObject);
        }
    }

    private void _0xefada1a7()
    {
        if (this._0x0d4fd91e != null)
        {
            this._0x0d4fd91e.gameObject.SetActive(false);
        }

        if (this._0x74d49d96 != null)
        {
            this._0x74d49d96._0x921c31f4();
        }
    }

    private TMP_FontAsset _0x18ef2216;
    private void _0x44eca79a()
    {
        if (this._0xad6aa7f1 == null)
        {
            return;
        }

        for (int _0xcb6016b1 = this._0xad6aa7f1.childCount - 1; _0xcb6016b1 >= 0; _0xcb6016b1--)
        {
            Transform _0x141b7976 = this._0xad6aa7f1.GetChild(_0xcb6016b1);
            _0x141b7976.SetParent(null, false);
            Destroy(_0x141b7976.gameObject);
        }
    }

    private bool _0x4778c17d;
    private Sprite _0x6bc19ebf;
}

internal static class _0xda6881ff
{
    internal static string _0x4d73c26b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}