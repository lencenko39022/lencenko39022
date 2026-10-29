using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// One turning column of the window.
//
// Four cells on a strip that is one cell taller than the window: cell 0 waits just above
// the opening and cells 1 to 3 are the three faces the player can see. The strip slides
// down by exactly one cell, then the faces are shifted along and the strip is put back -
// so the column can turn forever without ever running out of strip.
//
// The turn is driven from Update rather than from a chain of tweens: the motion is a
// constant speed slide that has to stop on an exact cell, and a hand driven offset lands
// on that cell every time, whatever the frame rate did. The one tween here is the little
// knock the column gives when it settles.
public sealed class _0xfe63879b : MonoBehaviour
{
    private Sprite _0x1fc0b272(int _0x5baf5ccf)
    {
        if (this._0xc21ef0db == null || this._0xc21ef0db.Length == 0)
        {
            return null;
        }

        int _0xc089c7d3 = ((_0x5baf5ccf % this._0xc21ef0db.Length) + this._0xc21ef0db.Length) % this._0xc21ef0db.Length;
        return this._0xc21ef0db[_0xc089c7d3];
    }

    private void OnDestroy()
    {
        if (this._0x56287b80 != null)
        {
            DOTween.Kill(this._0x56287b80);
        }
    }

    // The three faces the window shows right now, top row first.
    public void _0xa29ae640(int[] _0x2e17f264)
    {
        this._0xa8580f1a[0] = _0x2e17f264[this._0x656ed5a4.Next(_0xbbd798a9.Rows)];
        for (int _0x26303320 = 0; _0x26303320 < _0xbbd798a9.Rows; _0x26303320++)
        {
            this._0xa8580f1a[_0x26303320 + 1] = _0x2e17f264[_0x26303320];
        }

        for (int _0xaee7418b = 0; _0xaee7418b < CellCount; _0xaee7418b++)
        {
            this._0x0afa8d37(_0xaee7418b);
        }

        this._0x5e5d35ba = this._0x71d24ef0;
        this._0xb3c824bc();
    }

    private Image[] _0x01f31cf5 = new Image[CellCount];
    public void _0xfc392793(float _0xb7c73c7d)
    {
        this._0xcea5ac9c = _0xb7c73c7d;
        this._0x92a32c76 = true;
        this._0xb0f7b60f = false;
        this._0x780e7daf();
    }

    private const int CellCount = 4;
    public void _0xe93eeca1(int[] _0xa399366b)
    {
        for (int _0xff1c86c4 = 0; _0xff1c86c4 < _0xbbd798a9.Rows; _0xff1c86c4++)
        {
            this._0x050299ef[_0xff1c86c4] = _0xa399366b[_0xff1c86c4];
        }

        this._0xb0f7b60f = true;
    }

    public void _0x780e7daf()
    {
        for (int _0x6b33cbe4 = 0; _0x6b33cbe4 < CellCount; _0x6b33cbe4++)
        {
            if (this._0x7e0a1dbd[_0x6b33cbe4] != null)
            {
                this._0x7e0a1dbd[_0x6b33cbe4].color = _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 0.88f);
            }
        }
    }

    public void _0x6ad60577(int _0x0944747e, Color _0xbc98799f)
    {
        int _0xab1e54f0 = _0x0944747e + 1;
        if (_0xab1e54f0 < 0 || _0xab1e54f0 >= CellCount)
        {
            return;
        }

        if (this._0x7e0a1dbd[_0xab1e54f0] != null)
        {
            this._0x7e0a1dbd[_0xab1e54f0].color = _0xbc98799f;
        }
    }

    private bool _0xb0f7b60f;
    private int[] _0xa8580f1a = new int[CellCount];
    private void _0x0afa8d37(int _0x8864217c)
    {
        Image _0xf6e5aa9c = this._0x01f31cf5[_0x8864217c];
        if (_0xf6e5aa9c == null)
        {
            return;
        }

        Sprite _0x6a3c9724 = this._0x1fc0b272(this._0xa8580f1a[_0x8864217c]);
        // Every painted face comes back on a square canvas, and the cell it is drawn in
        // is square too - preserveAspect keeps the subject inside it at its own
        // proportions instead of being stretched to the cell (F.2a).
        _0xf6e5aa9c.preserveAspect = true;
        _0xf6e5aa9c.sprite = _0x6a3c9724;
        _0xf6e5aa9c.enabled = _0x6a3c9724 != null;
        _0xf6e5aa9c.color = Color.white;
        if (this._0x7e0a1dbd[_0x8864217c] != null)
        {
            this._0x7e0a1dbd[_0x8864217c].color = _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 0.88f);
        }
    }

    private Image[] _0x7e0a1dbd = new Image[CellCount];
    private bool _0x92a32c76;
    private float _0xcea5ac9c;
    private void Update()
    {
        if (!this._0x92a32c76)
        {
            return;
        }

        this._0x5e5d35ba -= this._0xcea5ac9c * Time.deltaTime;
        while (this._0x5e5d35ba <= 0f)
        {
            this._0x5e5d35ba += this._0x71d24ef0;
            this._0x2eb67e76();
            if (!this._0x92a32c76)
            {
                return;
            }
        }

        this._0xb3c824bc();
    }

    private Sprite _0x35cc55e7;
    private float _0x71d24ef0 = 260f;
    public bool _0x50577ddc => this._0x92a32c76;

    private System.Random _0x656ed5a4 = new System.Random(7919);
    private Sprite[] _0xc21ef0db;
    private void _0x2eb67e76()
    {
        if (this._0xb0f7b60f)
        {
            for (int _0xa96fe3c6 = 0; _0xa96fe3c6 < _0xbbd798a9.Rows; _0xa96fe3c6++)
            {
                this._0xa8580f1a[_0xa96fe3c6 + 1] = this._0x050299ef[_0xa96fe3c6];
            }

            this._0xa8580f1a[0] = this._0x656ed5a4.Next(_0xbbd798a9.Symbols);
            for (int _0x4e78d4f7 = 0; _0x4e78d4f7 < CellCount; _0x4e78d4f7++)
            {
                this._0x0afa8d37(_0x4e78d4f7);
            }

            this._0x92a32c76 = false;
            this._0xb0f7b60f = false;
            this._0x5e5d35ba = this._0x71d24ef0;
            this._0xb3c824bc();
            this._0x56287b80.DOPunchAnchorPos(new Vector2(0f, -26f), _0xbbd798a9.ColumnSettleSeconds, 1, 0.6f).SetLink(this.gameObject);
            return;
        }

        for (int _0xc4c600c8 = CellCount - 1; _0xc4c600c8 > 0; _0xc4c600c8--)
        {
            this._0xa8580f1a[_0xc4c600c8] = this._0xa8580f1a[_0xc4c600c8 - 1];
        }

        this._0xa8580f1a[0] = this._0x656ed5a4.Next(_0xbbd798a9.Symbols);
        for (int _0x76523234 = 0; _0x76523234 < CellCount; _0x76523234++)
        {
            this._0x0afa8d37(_0x76523234);
        }
    }

    private int[] _0x050299ef = new int[_0xbbd798a9.Rows];
    private float _0x5e5d35ba;
    private RectTransform _0x56287b80;
    public _0xfe63879b _0xb754f143(RectTransform _0x611e97ca, int _0x22bb3b41, float _0xc2d70a46, float width, float height, float _0xb5a06729, Sprite _0xed16e7e6, Sprite[] _0x75e6bf1c, int _0xaaf4c16b)
    {
        this._0x35cc55e7 = _0xed16e7e6;
        this._0xc21ef0db = _0x75e6bf1c;
        this._0x71d24ef0 = _0xb5a06729;
        this._0x656ed5a4 = new System.Random(_0xaaf4c16b + _0x22bb3b41 * 31);
        RectTransform _0x46649dab = _0x891ecf84.Node(_0x611e97ca, _0x1f53c3b2._0x40ae35be(new byte[4] { 209, 230, 230, 239 }, 131) + _0x22bb3b41.ToString(), new Vector2(0.5f, 0f), new Vector2(0.5f, 1f), new Vector2(_0xc2d70a46, 0f), new Vector2(width, 0f));
        _0x46649dab.gameObject.AddComponent<RectMask2D>();
        this._0x56287b80 = _0x891ecf84.Node(_0x46649dab, _0x1f53c3b2._0x40ae35be(new byte[9] { 133, 178, 178, 187, 132, 163, 165, 190, 167 }, 215) + _0x22bb3b41.ToString(), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, _0xb5a06729), new Vector2(0f, _0xb5a06729 * CellCount));
        this._0x56287b80.pivot = new Vector2(0.5f, 1f);
        this._0x56287b80.anchoredPosition = new Vector2(0f, _0xb5a06729);
        for (int _0x553d9488 = 0; _0x553d9488 < CellCount; _0x553d9488++)
        {
            RectTransform _0x5ef97b05 = _0x891ecf84.Node(this._0x56287b80, _0x1f53c3b2._0x40ae35be(new byte[4] { 208, 246, 255, 255 }, 147) + _0x22bb3b41.ToString() + _0x1f53c3b2._0x40ae35be(new byte[1] { 77 }, 18) + _0x553d9488.ToString(), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -(_0x553d9488 * _0xb5a06729 + _0xb5a06729 * 0.5f)), new Vector2(-12f, _0xb5a06729 - 12f));
            this._0x7e0a1dbd[_0x553d9488] = _0x891ecf84.Plate(_0x5ef97b05, _0xed16e7e6, _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 0.88f), 2.2f);
            RectTransform _0xd8052775 = _0x891ecf84.Stretch(_0x5ef97b05, _0x1f53c3b2._0x40ae35be(new byte[7] { 228, 194, 203, 203, 230, 213, 211 }, 167) + _0x22bb3b41.ToString() + _0x1f53c3b2._0x40ae35be(new byte[1] { 51 }, 108) + _0x553d9488.ToString());
            _0xd8052775.offsetMin = new Vector2(26f, 26f);
            _0xd8052775.offsetMax = new Vector2(-26f, -26f);
            this._0x01f31cf5[_0x553d9488] = _0x891ecf84.Picture(_0xd8052775, null, Color.white);
            this._0xa8580f1a[_0x553d9488] = 0;
        }

        this._0x5e5d35ba = _0xb5a06729;
        return this;
    }

    private void _0xb3c824bc()
    {
        if (this._0x56287b80 != null)
        {
            this._0x56287b80.anchoredPosition = new Vector2(0f, this._0x5e5d35ba);
        }
    }
}

internal static class _0x1f53c3b2
{
    internal static string _0x40ae35be(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}