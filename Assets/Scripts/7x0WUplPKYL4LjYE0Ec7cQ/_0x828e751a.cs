using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The window: a gilt surround, three turning columns behind it and a line marker that
// only appears when a line has paid.
//
// Child order is the whole point here (C.13 / C.63). The surround is created BEFORE the
// opening it surrounds, because uGUI draws later children on top and painted frame art
// is a filled rectangle unless proven otherwise - a frame added last would cover every
// face behind it. Only the line markers, which are transparent until they are needed,
// come after the content.
public sealed class _0x828e751a : MonoBehaviour
{
    // Lights exactly the faces the player was paid for and fades in the markers of the
    // lines that paid.
    public void _0x7c12663c(_0xad51c8f1 _0x23cfb5e0)
    {
        this._0x6ad8e361();
        for (int _0xb9abed22 = 0; _0xb9abed22 < _0x23cfb5e0._0xc6caec45; _0xb9abed22++)
        {
            int _0xe8bdb5a5 = _0x23cfb5e0._0x5889a5da(_0xb9abed22);
            Image _0x60bbcd46 = this._0x89dc0598[_0xe8bdb5a5];
            if (_0x60bbcd46 != null)
            {
                _0x60bbcd46.color = _0xc5c3f38d.With(_0xc5c3f38d.GoldLit, 0f);
                _0x60bbcd46.DOFade(0.85f, 0.2f).SetLink(_0x60bbcd46.gameObject);
            }
        }

        for (int _0xf4f42c7d = 0; _0xf4f42c7d < _0xbbd798a9.Reels; _0xf4f42c7d++)
        {
            for (int _0x21f3ac33 = 0; _0x21f3ac33 < _0xbbd798a9.Rows; _0x21f3ac33++)
            {
                if (_0x23cfb5e0._0x54d11a60(_0xf4f42c7d, _0x21f3ac33) && this._0xac14022a[_0xf4f42c7d] != null)
                {
                    this._0xac14022a[_0xf4f42c7d]._0x6ad60577(_0x21f3ac33, _0xc5c3f38d.With(_0xc5c3f38d.GoldLit, 0.55f));
                }
            }
        }
    }

    private _0xfe63879b[] _0xac14022a = new _0xfe63879b[_0xbbd798a9.Reels];
    public void _0x0a549333(_0x75c9e808 _0xb5c50aa6, int[] _0x0fc897b7)
    {
        int[] _0x3ccaa3c8 = new int[_0xbbd798a9.Rows];
        for (int _0x68a164ec = 0; _0x68a164ec < _0xbbd798a9.Reels; _0x68a164ec++)
        {
            for (int _0x07b7bc24 = 0; _0x07b7bc24 < _0xbbd798a9.Rows; _0x07b7bc24++)
            {
                _0x3ccaa3c8[_0x07b7bc24] = _0xb5c50aa6._0x13bc7317(_0x68a164ec, _0x0fc897b7[_0x68a164ec], _0x07b7bc24);
            }

            if (this._0xac14022a[_0x68a164ec] != null)
            {
                this._0xac14022a[_0x68a164ec]._0xa29ae640(_0x3ccaa3c8);
            }
        }

        this._0x6ad8e361();
    }

    public void _0x685a4663(float _0x88b71322)
    {
        this._0x6ad8e361();
        for (int _0x3e82a295 = 0; _0x3e82a295 < _0xbbd798a9.Reels; _0x3e82a295++)
        {
            if (this._0xac14022a[_0x3e82a295] != null)
            {
                this._0xac14022a[_0x3e82a295]._0xfc392793(_0x88b71322);
            }
        }
    }

    private Image[] _0x89dc0598 = new Image[_0x4dc369d4.LineCount];
    public void _0x1e94d904(RectTransform _0x8b7153c1, float _0xd3f4c729, Sprite _0x77cb32e3, Sprite[] _0x2a3a98e7, int _0x216b09ad)
    {
        RectTransform _0xf19e0674 = _0x891ecf84.FracBox(_0x8b7153c1, _0xd53df858._0x06ffc89d(new byte[12] { 64, 119, 119, 126, 83, 97, 97, 119, 127, 112, 126, 107 }, 18), 0.5f, _0xd3f4c729, BoardWidth, BoardHeight);
        this._0xeccc5ad6 = _0xf19e0674;
        // 1. the recess behind everything
        _0x891ecf84.Plate(_0x891ecf84.Stretch(_0xf19e0674, _0xd53df858._0x06ffc89d(new byte[12] { 124, 75, 75, 66, 108, 79, 77, 69, 74, 92, 65, 94 }, 46)), _0x77cb32e3, _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.94f), 2.4f);
        // 2. the surround, BEFORE the opening it frames
        RectTransform _0x5a617db0 = _0x891ecf84.Stretch(_0xf19e0674, _0xd53df858._0x06ffc89d(new byte[9] { 18, 37, 37, 44, 6, 50, 33, 45, 37 }, 64));
        _0x891ecf84.Plate(_0x5a617db0, _0x77cb32e3, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.95f), 2.2f);
        RectTransform _0x7e94ac1f = _0x891ecf84.Stretch(_0xf19e0674, _0xd53df858._0x06ffc89d(new byte[14] { 240, 199, 199, 206, 228, 208, 195, 207, 199, 235, 204, 204, 199, 208 }, 162));
        _0x7e94ac1f.offsetMin = new Vector2(18f, 18f);
        _0x7e94ac1f.offsetMax = new Vector2(-18f, -18f);
        _0x891ecf84.Plate(_0x7e94ac1f, _0x77cb32e3, _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 1f), 2.6f);
        // 3. the opening and the columns inside it
        RectTransform _0xf2c4b138 = _0x891ecf84.Stretch(_0xf19e0674, _0xd53df858._0x06ffc89d(new byte[10] { 204, 251, 251, 242, 201, 247, 240, 250, 241, 233 }, 158));
        _0xf2c4b138.offsetMin = new Vector2(WindowInset, WindowInset);
        _0xf2c4b138.offsetMax = new Vector2(-WindowInset, -WindowInset);
        float _0x686b2ae5 = BoardWidth - 2f * WindowInset;
        float _0xe9f8b6ae = BoardHeight - 2f * WindowInset;
        float _0x0feca0ec = (_0x686b2ae5 - ColumnGap * (_0xbbd798a9.Reels - 1)) / _0xbbd798a9.Reels;
        float _0x93784e2e = _0xe9f8b6ae / _0xbbd798a9.Rows;
        for (int _0x18482977 = 0; _0x18482977 < _0xbbd798a9.Reels; _0x18482977++)
        {
            float _0x9e1b73d3 = (_0x18482977 - (_0xbbd798a9.Reels - 1) * 0.5f) * (_0x0feca0ec + ColumnGap);
            RectTransform _0x19e5e070 = _0x891ecf84.Stretch(_0xf2c4b138, _0xd53df858._0x06ffc89d(new byte[10] { 42, 29, 29, 20, 48, 23, 20, 28, 29, 10 }, 120) + _0x18482977.ToString());
            this._0xac14022a[_0x18482977] = _0x19e5e070.gameObject.AddComponent<_0xfe63879b>()._0xb754f143(_0xf2c4b138, _0x18482977, _0x9e1b73d3, _0x0feca0ec, _0xe9f8b6ae, _0x93784e2e, _0x77cb32e3, _0x2a3a98e7, _0x216b09ad);
        }

        // 4. the line markers, transparent until a line pays, drawn over the faces
        for (int _0x43c8cfb9 = 0; _0x43c8cfb9 < _0x4dc369d4.LineCount; _0x43c8cfb9++)
        {
            RectTransform _0x0b1cbb41 = _0x891ecf84.Stretch(_0xf19e0674, _0xd53df858._0x06ffc89d(new byte[7] { 39, 22, 14, 59, 30, 25, 18 }, 119) + _0x43c8cfb9.ToString());
            _0x0b1cbb41.offsetMin = new Vector2(WindowInset + 8f, WindowInset + 8f);
            _0x0b1cbb41.offsetMax = new Vector2(-WindowInset - 8f, -WindowInset - 8f);
            this._0xc7178e3b[_0x43c8cfb9] = _0x0b1cbb41;
            RectTransform _0x10c68cd0 = this._0xfd0596aa(_0x0b1cbb41, _0x43c8cfb9, _0x686b2ae5, _0x93784e2e);
            this._0x89dc0598[_0x43c8cfb9] = _0x891ecf84.Plate(_0x10c68cd0, _0x77cb32e3, _0xc5c3f38d.With(_0xc5c3f38d.GoldLit, 0f), 1.2f);
        }

        _0xf19e0674.localScale = Vector3.one * 0.94f;
        _0xf19e0674.DOScale(1f, 0.4f).SetEase(Ease.OutBack).SetLink(_0xf19e0674.gameObject);
    }

    private void OnDestroy()
    {
        if (this._0xeccc5ad6 != null)
        {
            DOTween.Kill(this._0xeccc5ad6);
        }

        for (int _0x21354bd7 = 0; _0x21354bd7 < this._0x89dc0598.Length; _0x21354bd7++)
        {
            if (this._0x89dc0598[_0x21354bd7] != null)
            {
                DOTween.Kill(this._0x89dc0598[_0x21354bd7]);
            }
        }
    }

    // A row line is a bar across its own row; a diagonal is shown as a bar across the
    // centre row with the two corner rows tinted, which reads clearly at this size and
    // needs no rotated art.
    private RectTransform _0xfd0596aa(RectTransform _0xaed96954, int _0xc146bb10, float _0xd6e7eb21, float _0xd53880a4)
    {
        int[] _0xa0c86542 = _0x4dc369d4._0x509a1731[_0xc146bb10];
        int _0x524112fe = _0xa0c86542[1];
        float _0x690e2e79 = -(_0x524112fe * _0xd53880a4 + _0xd53880a4 * 0.5f);
        RectTransform _0x564b0656 = _0x891ecf84.Node(_0xaed96954, _0xd53df858._0x06ffc89d(new byte[10] { 127, 78, 86, 99, 70, 65, 74, 109, 78, 93 }, 47) + _0xc146bb10.ToString(), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, _0x690e2e79), new Vector2(-18f, _0xc146bb10 < 3 ? 10f : 6f));
        return _0x564b0656;
    }

    private const float WindowInset = 60f;
    public void _0xc92c5d60(int _0x31ec8bda, _0x75c9e808 _0xb0283057, int _0xd3e7da4e)
    {
        int[] _0x8974e474 = new int[_0xbbd798a9.Rows];
        for (int _0xb4e9ff31 = 0; _0xb4e9ff31 < _0xbbd798a9.Rows; _0xb4e9ff31++)
        {
            _0x8974e474[_0xb4e9ff31] = _0xb0283057._0x13bc7317(_0x31ec8bda, _0xd3e7da4e, _0xb4e9ff31);
        }

        if (this._0xac14022a[_0x31ec8bda] != null)
        {
            this._0xac14022a[_0x31ec8bda]._0xe93eeca1(_0x8974e474);
        }
    }

    public void _0x6ad8e361()
    {
        for (int _0x3868e518 = 0; _0x3868e518 < this._0x89dc0598.Length; _0x3868e518++)
        {
            if (this._0x89dc0598[_0x3868e518] != null)
            {
                this._0x89dc0598[_0x3868e518].color = _0xc5c3f38d.With(_0xc5c3f38d.GoldLit, 0f);
            }
        }

        for (int _0x96703be7 = 0; _0x96703be7 < _0xbbd798a9.Reels; _0x96703be7++)
        {
            if (this._0xac14022a[_0x96703be7] != null)
            {
                this._0xac14022a[_0x96703be7]._0x780e7daf();
            }
        }
    }

    private const float BoardWidth = 1062f;
    private const float BoardHeight = 900f;
    public _0xfe63879b[] _0x98e65b37 => this._0xac14022a;

    public void _0x48d74db7()
    {
        if (this._0xeccc5ad6 != null)
        {
            this._0xeccc5ad6.DOPunchScale(new Vector3(0.02f, 0.02f, 0f), 0.35f, 1, 0.6f).SetLink(this._0xeccc5ad6.gameObject);
        }
    }

    public bool _0x97139ac5()
    {
        for (int _0xe57ba9c3 = 0; _0xe57ba9c3 < _0xbbd798a9.Reels; _0xe57ba9c3++)
        {
            if (this._0xac14022a[_0xe57ba9c3] != null && this._0xac14022a[_0xe57ba9c3]._0x50577ddc)
            {
                return true;
            }
        }

        return false;
    }

    private RectTransform _0xeccc5ad6;
    private const float ColumnGap = 20f;
    private RectTransform[] _0xc7178e3b = new RectTransform[_0x4dc369d4.LineCount];
}

internal static class _0xd53df858
{
    internal static string _0x06ffc89d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}