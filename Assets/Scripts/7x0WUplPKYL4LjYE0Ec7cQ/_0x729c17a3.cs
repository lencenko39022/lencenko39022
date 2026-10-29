using UnityEngine;
using UnityEngine.UI;

// Keeps a 9-slice plate from collapsing into a sliver.
//
// Unity draws the four border bands of a sliced Image at a FIXED size and stretches only
// the middle, so the moment the two opposite borders meet inside the rect the middle is
// zero or negative and the plate renders as a crooked bar instead of a panel. The border
// in canvas units is borderPixels / pixelsPerUnitMultiplier, so the rounded plate used
// for chrome here (a 127 px border) asks for 106 units a side at a "nicely rounded"
// multiplier of 1.2 - which is wider than a 56 unit chip.
//
// The multiplier is therefore not a literal: it is computed from the rect the plate
// ACTUALLY got, with the caller's value as a FLOOR (lower means rounder). A plate only
// ever comes out sharper than asked for, never broken, and a small chip lands at a
// radius that makes it a disc - which is what a small chip wants anyway.
//
// The two axes are measured separately, because a wide button plate carries a large
// horizontal border and a small vertical one; judging both by the larger number would
// square off a shape that fits perfectly well.
//
// In LateUpdate behind a size check: it costs nothing while nothing moves and it fires
// again when autorotation reshapes the canvas (C.22), which a value computed once at
// build time would not.
public sealed class _0x729c17a3 : MonoBehaviour
{
    private Vector2 _0x15de2089 = new Vector2(-1f, -1f);
    // How much of each side is left to the stretchy middle.
    private const float MiddleShare = 0.18f;
    private float _0x38151ad4 = 1f;
    public _0x729c17a3 _0x06bdcd15(Image _0x337d8d65, float _0xf91594b7)
    {
        this._0x68650145 = _0x337d8d65;
        this._0x2b9564c6 = _0x337d8d65 != null ? _0x337d8d65.rectTransform : null;
        this._0x38151ad4 = _0xf91594b7;
        this._0xb0970dec();
        return this;
    }

    private RectTransform _0x2b9564c6;
    private void _0xb0970dec()
    {
        if (this._0x68650145 == null || this._0x2b9564c6 == null)
        {
            return;
        }

        Vector2 _0x40d0fcb7 = this._0x2b9564c6.rect.size;
        if (_0x40d0fcb7.x < 1f || _0x40d0fcb7.y < 1f)
        {
            return; // not laid out yet, or a bar fill currently at zero width
        }

        if (Mathf.Abs(_0x40d0fcb7.x - this._0x15de2089.x) < 0.5f && Mathf.Abs(_0x40d0fcb7.y - this._0x15de2089.y) < 0.5f)
        {
            return;
        }

        this._0x15de2089 = _0x40d0fcb7;
        Sprite _0xc94310a2 = this._0x68650145.sprite;
        if (_0xc94310a2 == null)
        {
            return;
        }

        Vector4 _0x6e720d46 = _0xc94310a2.border;
        if (_0x6e720d46.x + _0x6e720d46.y + _0x6e720d46.z + _0x6e720d46.w <= 0f)
        {
            return; // not a 9-slice sprite: the multiplier changes nothing
        }

        float _0x5ec6f3df = _0xc94310a2.pixelsPerUnit > 0f ? _0xc94310a2.pixelsPerUnit : 100f;
        float _0x0431af0e = 100f;
        Canvas _0x832a91f4 = this._0x68650145.canvas;
        if (_0x832a91f4 != null && _0x832a91f4.referencePixelsPerUnit > 0f)
        {
            _0x0431af0e = _0x832a91f4.referencePixelsPerUnit;
        }

        float _0xf0be1460 = _0x0431af0e / (_0x5ec6f3df * (1f - MiddleShare));
        float _0x515b9d23 = (_0x6e720d46.x + _0x6e720d46.z) * _0xf0be1460 / _0x40d0fcb7.x;
        float _0x4fc76320 = (_0x6e720d46.y + _0x6e720d46.w) * _0xf0be1460 / _0x40d0fcb7.y;
        this._0x68650145.pixelsPerUnitMultiplier = Mathf.Max(this._0x38151ad4, Mathf.Max(_0x515b9d23, _0x4fc76320));
    }

    private Image _0x68650145;
    private void LateUpdate()
    {
        this._0xb0970dec();
    }
}