using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The three cards the table can raise: the intermission, the cleared card and the free
// top up.
//
// Each one is built fresh inside the popup's own body and every template child of that
// body is switched off first. That makes C.3 and C.17 true by construction: there is no
// leftover label to fill in, no caption from another game, and no close control whose
// picture was never assigned - an unassigned picture draws as a solid white square.
//
// A card is rebuilt per result rather than kept: captions and handlers are captured when
// the card is built, so a kept card would offer the previous result's wording and run the
// previous result's handler.
//
// Every card releases itself after ClubConfig.PopReleaseSeconds. A card with no backstop
// parks the table forever if the tap that should dismiss it misses by a few pixels.
public sealed class _0x8ac43d6c : MonoBehaviour
{
    private const float CardWidth = 1040f;
    private const float CardHeight = 1080f;
    private void _0xdaa6b957(RectTransform _0x4449ed8c)
    {
        _0x4449ed8c.localScale = Vector3.one * 0.94f;
        _0x4449ed8c.DOScale(1f, 0.34f).SetEase(Ease.OutBack).SetLink(_0x4449ed8c.gameObject);
        DOVirtual.DelayedCall(_0xbbd798a9.PopReleaseSeconds, () => this._0x91da8006()).SetLink(_0x4449ed8c.gameObject);
    }

    // Every action gets its OWN caption and its own handler. The close control is a
    // separate thing and is never captioned (C.17).
    private void _0x1c3b1692(RectTransform _0xfbc68142, float _0x7c8a9faa, string _0xf510a0bc, bool _0xc1ccd84a)
    {
        RectTransform _0x1c33974c = _0x891ecf84.BottomBox(_0xfbc68142, _0x88130323._0x7d9c04d6(new byte[15] { 79, 104, 114, 116, 98, 68, 102, 117, 99, 70, 100, 115, 110, 104, 105 }, 7) + _0x7c8a9faa.ToString(_0x88130323._0x7d9c04d6(new byte[1] { 249 }, 201)), 0f, _0x7c8a9faa, _0xc1ccd84a ? 700f : 520f, _0xc1ccd84a ? 132f : 104f);
        Button _0x3e1691ec = _0x891ecf84.Cta(_0x1c33974c, this._0x23444fd6, _0xc1ccd84a ? this._0x496f45ec : null, this._0x777d57aa, _0xf510a0bc, _0xc1ccd84a ? 44f : 36f, _0xc1ccd84a ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.55f), _0xc1ccd84a ? _0xc5c3f38d.Ruby : _0xc5c3f38d.VelvetDeep, _0xc1ccd84a ? _0xc5c3f38d.Cream : _0xc5c3f38d.Gold);
        if (_0xc1ccd84a)
        {
            _0x3e1691ec.onClick.AddListener(() => this._0x91da8006());
        }
        else
        {
            _0x3e1691ec.onClick.AddListener(() => this._0x0d497494());
        }
    }

    private RectTransform[] _0x253d87b0 = new RectTransform[16];
    public void _0x733ed108(_0x9799df08 _0xee5fbc4e, TMP_FontAsset _0x38bc0ad9, Sprite _0x038e46d1, Sprite _0xf3fa21bf, Sprite _0xe291a1b6)
    {
        this._0xd4e6ebb0 = _0xee5fbc4e;
        this._0x23444fd6 = _0x38bc0ad9;
        this._0x777d57aa = _0x038e46d1;
        this._0x496f45ec = _0xf3fa21bf;
        this._0x6d445b5f = _0xe291a1b6;
    }

    private void _0x91da8006()
    {
        if (this._0xd4e6ebb0 != null)
        {
            this._0xd4e6ebb0._0xdd6ee835();
        }
    }

    private void _0x2da18e91(RectTransform _0xca8c233e, string _0x33b08799)
    {
        // 820 wide, not 940: the close control owns the top right corner of the card
        // and a header that reached under it would share an x band with it (C.25).
        RectTransform _0xf450fe4a = _0x891ecf84.TopBox(_0xca8c233e, _0x88130323._0x7d9c04d6(new byte[13] { 10, 45, 55, 49, 39, 1, 35, 48, 38, 10, 39, 35, 38 }, 66), 0f, 140f, 820f, 110f);
        TextMeshProUGUI _0x76b9a7fc = _0x891ecf84.Label(_0xf450fe4a, this._0x23444fd6, _0x33b08799, 62f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        _0x76b9a7fc.characterSpacing = 6f;
    }

    private void _0x0d497494()
    {
        if (this._0xd4e6ebb0 != null)
        {
            this._0xd4e6ebb0._0xa053f3ec();
        }
    }

    public void _0xf9b5c467(_0x5d88494d _0xf3652cd0, _0xe54e0344 _0x8e92634b, _0x9aaba7e8 _0x7697b799, int _0x2c8553d5)
    {
        RectTransform _0x7259406b = this._0x9869eec2(_0xf3652cd0, _0xa93ecf08._0x308a9b74.PAUSE);
        if (_0x7259406b == null)
        {
            return;
        }

        this._0x2da18e91(_0x7259406b, _0x88130323._0x7d9c04d6(new byte[12] { 175, 168, 178, 163, 180, 171, 175, 181, 181, 175, 169, 168 }, 230));
        this._0xb6ecee4a(_0x7259406b, 270f, _0x88130323._0x7d9c04d6(new byte[30] { 216, 196, 201, 172, 196, 195, 217, 223, 201, 172, 219, 197, 192, 192, 172, 196, 195, 192, 200, 172, 213, 195, 217, 222, 172, 223, 201, 205, 216, 162 }, 140), _0xc5c3f38d.Cream, 36f, 60f);
        this._0xb6ecee4a(_0x7259406b, 370f, _0x1bad1984.Credits(_0x8e92634b._0xb8844111) + _0x88130323._0x7d9c04d6(new byte[8] { 42, 73, 88, 79, 78, 67, 94, 89 }, 10), _0xc5c3f38d.Gold, 58f, 80f);
        this._0xb6ecee4a(_0x7259406b, 450f, _0x7697b799._0x374268d8, _0xc5c3f38d.CreamDim, 32f, 50f);
        this._0xb6ecee4a(_0x7259406b, 510f, _0x88130323._0x7d9c04d6(new byte[20] { 224, 253, 231, 252, 246, 225, 146, 230, 250, 251, 225, 146, 225, 251, 230, 230, 251, 252, 245, 146 }, 178) + _0x1bad1984.Pad2(_0x2c8553d5), _0xc5c3f38d.CreamDim, 32f, 50f);
        this._0x1c3b1692(_0x7259406b, 300f, _0x88130323._0x7d9c04d6(new byte[17] { 239, 236, 238, 230, 141, 249, 226, 141, 249, 229, 232, 141, 235, 225, 226, 226, 255 }, 173), true);
        this._0x1c3b1692(_0x7259406b, 152f, _0x88130323._0x7d9c04d6(new byte[15] { 106, 99, 103, 112, 99, 6, 114, 110, 99, 6, 114, 103, 100, 106, 99 }, 38), false);
        this._0xc265d318(_0x7259406b);
        this._0xdaa6b957(_0x7259406b);
    }

    private _0x9799df08 _0xd4e6ebb0;
    public void _0xd2361296(_0x5d88494d _0xd9804861, _0xe54e0344 _0x47c0e35d, _0x542b1bfd _0x8e5d8510)
    {
        RectTransform _0x9732dc19 = this._0x9869eec2(_0xd9804861, _0xa93ecf08._0x308a9b74.WIN);
        if (_0x9732dc19 == null)
        {
            return;
        }

        this._0x2da18e91(_0x9732dc19, _0x88130323._0x7d9c04d6(new byte[12] { 83, 69, 66, 68, 81, 89, 94, 48, 83, 81, 92, 92 }, 16));
        this._0xb6ecee4a(_0x9732dc19, 270f, _0x88130323._0x7d9c04d6(new byte[20] { 85, 81, 75, 75, 81, 87, 86, 56, 91, 89, 74, 92, 56, 91, 84, 93, 89, 74, 93, 92 }, 24), _0xc5c3f38d.Cream, 38f, 60f);
        this._0xb6ecee4a(_0x9732dc19, 370f, _0x1bad1984.Pad2(_0x8e5d8510._0x305182f4()) + _0x88130323._0x7d9c04d6(new byte[4] { 59, 84, 93, 59 }, 27) + _0x1bad1984.Pad2(_0xbbd798a9.MissionSlots) + _0x88130323._0x7d9c04d6(new byte[10] { 61, 87, 82, 95, 78, 61, 77, 92, 84, 89 }, 29), _0xc5c3f38d.Gold, 54f, 76f);
        this._0xb6ecee4a(_0x9732dc19, 450f, _0x88130323._0x7d9c04d6(new byte[33] { 211, 178, 220, 215, 197, 178, 209, 211, 192, 214, 178, 211, 212, 198, 215, 192, 178, 198, 218, 215, 178, 220, 215, 202, 198, 178, 193, 219, 198, 198, 219, 220, 213 }, 146), _0xc5c3f38d.CreamDim, 32f, 50f);
        this._0xb6ecee4a(_0x9732dc19, 510f, _0x1bad1984.Credits(_0x47c0e35d._0xb8844111) + _0x88130323._0x7d9c04d6(new byte[16] { 53, 86, 71, 80, 81, 92, 65, 70, 53, 92, 91, 53, 93, 84, 91, 81 }, 21), _0xc5c3f38d.CreamDim, 32f, 50f);
        this._0x1c3b1692(_0x9732dc19, 300f, _0x88130323._0x7d9c04d6(new byte[12] { 140, 130, 130, 151, 231, 151, 139, 134, 158, 142, 137, 128 }, 199), true);
        this._0x1c3b1692(_0x9732dc19, 152f, _0x88130323._0x7d9c04d6(new byte[17] { 109, 110, 108, 100, 15, 123, 96, 15, 123, 103, 106, 15, 99, 96, 109, 109, 118 }, 47), false);
        this._0xc265d318(_0x9732dc19);
        this._0xdaa6b957(_0x9732dc19);
    }

    // The height is stated by the caller rather than derived from the size: a line that
    // carries its own break needs room for both rows, and a block of rows that each
    // guessed their own height would overlap the one above it.
    private void _0xb6ecee4a(RectTransform _0x6576a594, float _0xdbce12c9, string _0x07d523e5, Color _0xe9dc466b, float _0xa544f79b, float height)
    {
        RectTransform _0x4d6f982c = _0x891ecf84.TopBox(_0x6576a594, _0x88130323._0x7d9c04d6(new byte[13] { 78, 105, 115, 117, 99, 69, 103, 116, 98, 74, 111, 104, 99 }, 6) + _0xdbce12c9.ToString(_0x88130323._0x7d9c04d6(new byte[1] { 103 }, 87)), 0f, _0xdbce12c9, 920f, height);
        _0x891ecf84.Label(_0x4d6f982c, this._0x23444fd6, _0x07d523e5, _0xa544f79b, _0xe9dc466b, TextAlignmentOptions.Center);
    }

    private Sprite _0x777d57aa;
    // --- card furniture -------------------------------------------------------
    private RectTransform _0x9869eec2(_0x5d88494d _0xd7ed0e32, int _0xa60bc526)
    {
        if (_0xd7ed0e32 == null || _0xd7ed0e32.Content == null)
        {
            return null;
        }

        Transform _0x57abcce7 = _0xd7ed0e32.Content.transform;
        RectTransform _0xf9710cdc = _0xa60bc526 >= 0 && _0xa60bc526 < this._0x253d87b0.Length ? this._0x253d87b0[_0xa60bc526] : null;
        for (int _0xa57f6d4a = 0; _0xa57f6d4a < _0x57abcce7.childCount; _0xa57f6d4a++)
        {
            Transform _0xe943ebfd = _0x57abcce7.GetChild(_0xa57f6d4a);
            if (_0xe943ebfd == null)
            {
                continue;
            }

            if (_0xe943ebfd.GetComponentInChildren<_0x5d88494d>(true) != null)
            {
                continue; // never switch off a branch that owns another card
            }

            if (_0xf9710cdc != null && _0xe943ebfd == _0xf9710cdc.transform)
            {
                continue;
            }

            _0xe943ebfd.gameObject.SetActive(false);
        }

        if (_0xf9710cdc != null)
        {
            _0xf9710cdc.SetParent(null, false);
            Destroy(_0xf9710cdc.gameObject);
            this._0x253d87b0[_0xa60bc526] = null;
        }

        RectTransform _0xfad0eb0c = _0x891ecf84.CentreBox(_0x57abcce7, _0x88130323._0x7d9c04d6(new byte[9] { 70, 97, 123, 125, 107, 77, 111, 124, 106 }, 14), 0f, 0f, CardWidth, CardHeight);
        _0xfad0eb0c.SetAsLastSibling();
        _0x891ecf84.Plate(_0xfad0eb0c, this._0x777d57aa, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.95f), 2.2f);
        RectTransform _0x3091fcc7 = _0x891ecf84.Stretch(_0xfad0eb0c, _0x88130323._0x7d9c04d6(new byte[13] { 51, 20, 14, 8, 30, 56, 26, 9, 31, 57, 20, 31, 2 }, 123));
        _0x3091fcc7.offsetMin = new Vector2(8f, 8f);
        _0x3091fcc7.offsetMax = new Vector2(-8f, -8f);
        _0x891ecf84.Plate(_0x3091fcc7, this._0x777d57aa, _0xc5c3f38d.Velvet, 2.4f);
        this._0x253d87b0[_0xa60bc526] = _0xfad0eb0c;
        return _0xfad0eb0c;
    }

    private void _0xc265d318(RectTransform _0x9a30d1d9)
    {
        RectTransform _0x283650b1 = _0x891ecf84.Node(_0x9a30d1d9, _0x88130323._0x7d9c04d6(new byte[14] { 229, 194, 216, 222, 200, 238, 204, 223, 201, 238, 193, 194, 222, 200 }, 173), new Vector2(1f, 1f), new Vector2(1f, 1f), new Vector2(-66f, -66f), new Vector2(92f, 92f));
        Button _0xad668fe5 = _0x891ecf84.IconButton(_0x283650b1, this._0x23444fd6, this._0x6d445b5f, this._0x777d57aa, null, _0x88130323._0x7d9c04d6(new byte[1] { 3 }, 91), _0xc5c3f38d.Gold, _0xc5c3f38d.Gold);
        _0xad668fe5.onClick.AddListener(() => this._0x91da8006());
    }

    private TMP_FontAsset _0x23444fd6;
    public void _0xec0558a8(_0x5d88494d _0x5ed6d075, _0xe54e0344 _0x6d8e7473, _0x9aaba7e8 _0x2117fec2, int _0x0cebca2a)
    {
        RectTransform _0xe62504c2 = this._0x9869eec2(_0x5ed6d075, _0xa93ecf08._0x308a9b74.LOSE);
        if (_0xe62504c2 == null)
        {
            return;
        }

        this._0x2da18e91(_0xe62504c2, _0x88130323._0x7d9c04d6(new byte[17] { 239, 243, 254, 155, 243, 244, 238, 232, 254, 155, 233, 254, 253, 242, 247, 247, 232 }, 187));
        this._0xb6ecee4a(_0xe62504c2, 290f, _0x88130323._0x7d9c04d6(new byte[57] { 79, 89, 67, 68, 54, 69, 83, 87, 66, 54, 95, 69, 54, 66, 89, 70, 70, 83, 82, 54, 67, 70, 56, 28, 95, 66, 54, 85, 89, 69, 66, 69, 54, 88, 89, 66, 94, 95, 88, 81, 54, 59, 54, 95, 66, 54, 88, 83, 64, 83, 68, 54, 65, 95, 90, 90, 56 }, 22), _0xc5c3f38d.Cream, 34f, 100f);
        this._0xb6ecee4a(_0xe62504c2, 400f, _0x88130323._0x7d9c04d6(new byte[1] { 250 }, 209) + _0x1bad1984.Credits(_0x2117fec2._0x81e6d18e) + _0x88130323._0x7d9c04d6(new byte[13] { 64, 38, 50, 37, 37, 64, 35, 50, 37, 36, 41, 52, 51 }, 96), _0xc5c3f38d.Gold, 54f, 76f);
        this._0xb6ecee4a(_0xe62504c2, 490f, _0x88130323._0x7d9c04d6(new byte[20] { 133, 152, 130, 153, 147, 132, 247, 131, 159, 158, 132, 247, 132, 158, 131, 131, 158, 153, 144, 247 }, 215) + _0x1bad1984.Pad2(_0x0cebca2a), _0xc5c3f38d.CreamDim, 32f, 50f);
        this._0x1c3b1692(_0xe62504c2, 300f, _0x88130323._0x7d9c04d6(new byte[10] { 13, 14, 23, 16, 126, 31, 25, 31, 23, 16 }, 94), true);
        this._0x1c3b1692(_0xe62504c2, 152f, _0x88130323._0x7d9c04d6(new byte[17] { 195, 192, 194, 202, 161, 213, 206, 161, 213, 201, 196, 161, 205, 206, 195, 195, 216 }, 129), false);
        this._0xc265d318(_0xe62504c2);
        this._0xdaa6b957(_0xe62504c2);
    }

    private Sprite _0x496f45ec;
    private Sprite _0x6d445b5f;
}

internal static class _0x88130323
{
    internal static string _0x7d9c04d6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}