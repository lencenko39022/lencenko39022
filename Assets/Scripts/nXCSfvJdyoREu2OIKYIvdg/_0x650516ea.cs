using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A 9-slice keeps its four border edges at a fixed pixel size and stretches only the
/// centre, so a small rect can end up all border and no centre - the plate then draws as
/// a crooked sliver. This raises the image's pixels-per-unit multiplier until the centre
/// keeps at least MiddleShare of the side, per axis, and leaves large plates on the
/// roundness floor the caller asked for.
/// </summary>
[RequireComponent(typeof(Image))]
public sealed class _0x650516ea : MonoBehaviour
{
    /// <summary>
    /// The rect is only final after layout, and it changes again when a bar fills or a
    /// sheet resizes, so the multiplier is re-derived whenever the size actually moved.
    /// </summary>
    private void LateUpdate()
    {
        this._0xe889afdf();
    }

    /// <summary>Share of each side that must survive as stretchable centre.</summary>
    private const float MiddleShare = 0.25f;
    [SerializeField]
    private Image _image;
    private void _0xe889afdf()
    {
        if (this._image == null)
            this._image = this.GetComponent<Image>();
        if (this._image == null || this._image.sprite == null)
            return;
        if (this._image.type != Image.Type.Sliced)
            return;
        Vector2 _0x8bf91f45 = this._image.rectTransform.rect.size;
        if (_0x8bf91f45 == this._0xaa74036b)
            return;
        this._0xaa74036b = _0x8bf91f45;
        // sprite.border is (left, bottom, right, top) in source pixels.
        Vector4 _0x339db8da = this._image.sprite.border;
        float _0xafa22ded = _0x339db8da.x + _0x339db8da.z;
        float _0x78b9c5e9 = _0x339db8da.y + _0x339db8da.w;
        if (_0xafa22ded <= 0f && _0x78b9c5e9 <= 0f)
        {
            this._image.pixelsPerUnitMultiplier = this._floor;
            return;
        }

        float _0x1079053f = Mathf.Max(1f, this._image.sprite.pixelsPerUnit);
        Canvas _0xe1fe1add = this._image.canvas;
        float _0x4895f564 = _0xe1fe1add != null ? _0xe1fe1add.referencePixelsPerUnit : 100f;
        float _0x8bc3d537 = Mathf.Max(0.01f, 1f - MiddleShare);
        float _0x0a75ad3d = _0x4895f564 / (_0x1079053f * _0x8bc3d537);
        float _0x55da9a76 = _0xafa22ded * _0x0a75ad3d / Mathf.Max(1f, _0x8bf91f45.x);
        float _0x37de6245 = _0x78b9c5e9 * _0x0a75ad3d / Mathf.Max(1f, _0x8bf91f45.y);
        float _0x3ebf3aa2 = Mathf.Max(_0x55da9a76, _0x37de6245);
        this._image.pixelsPerUnitMultiplier = Mathf.Max(this._floor, _0x3ebf3aa2);
    }

    [SerializeField]
    private float _floor = 1f;
    private Vector2 _0xaa74036b = new Vector2(-1f, -1f);
    private void Start()
    {
        this._0xe889afdf();
    }

    /// <summary>Set up from the factory; the floor is the caller's authored roundness.</summary>
    public _0x650516ea _0x5cdd8b4d(Image _0xf656b64b, float _0x58e860f0)
    {
        this._image = _0xf656b64b;
        this._floor = Mathf.Max(0.01f, _0x58e860f0);
        this._0xaa74036b = new Vector2(-1f, -1f);
        this._0xe889afdf();
        return this;
    }
}