using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One reel of the window: three cells that blur while the strip runs and settle with a
/// small overshoot when the reel stops. Everything is transform and sprite animation.
/// </summary>
public sealed class _0x1ed714fa : MonoBehaviour
{
    private readonly Image[] _0x71d24ef0 = new Image[_0x80ffeb86.Rows];
    private int _0x92a32c76;
    public void Show(int[] _0xc8999ec1, int _0x210beab1)
    {
        for (int _0xeca587f6 = 0; _0xeca587f6 < _0x80ffeb86.Rows; _0xeca587f6++)
            this._0xff1fc8d0(_0xeca587f6, _0xc8999ec1[_0x210beab1 * _0x80ffeb86.Rows + _0xeca587f6], 1f);
    }

    private readonly Image[] _0x5e5d35ba = new Image[_0x80ffeb86.Rows];
    private void _0xff1fc8d0(int _0x8b778f62, int _0xfa11b898, float _0xc79cc7dd)
    {
        Image _0x2c4356f4 = this._0x71d24ef0[_0x8b778f62];
        if (_0x2c4356f4 == null)
            return;
        Sprite _0xcaebee38 = this._0x35cc55e7._0xb6eb4455(_0xfa11b898);
        _0x2c4356f4.sprite = _0xcaebee38;
        _0x2c4356f4.preserveAspect = true;
        _0x2c4356f4.enabled = _0xcaebee38 != null;
        Color _0x01f7f840 = _0x80ffeb86.TintOf(_0xfa11b898);
        _0x2c4356f4.color = new Color(_0x01f7f840.r, _0x01f7f840.g, _0x01f7f840.b, _0xc79cc7dd);
    }

    /// <summary>Stops the reel on its final window and bounces it into place.</summary>
    public void _0x57db5759(int[] _0xdb641084, int _0x2eec395a, bool _0x6ce477ec)
    {
        this._0xb0f7b60f = false;
        this.Show(_0xdb641084, _0x2eec395a);
        if (this._0xa8580f1a == null || _0x6ce477ec)
            return;
        DOTween.Kill(this._0xa8580f1a, true);
        this._0xa8580f1a.DOPunchAnchorPos(new Vector2(0f, -14f), 0.26f, 2, 0.7f).SetLink(this._0xa8580f1a.gameObject);
    }

    public void _0x512a82ae(int[] _0x8dfcdc2c)
    {
        this._0xcea5ac9c = _0x8dfcdc2c;
        this._0x92a32c76 = 0;
    }

    private const float FlickerStep = 0.045f;
    public void _0x03cf8ceb()
    {
        this._0xb0f7b60f = true;
        this._0x050299ef = 0f;
    }

    public void _0x8394e0a9()
    {
        for (int _0x24d0974e = 0; _0x24d0974e < _0x80ffeb86.Rows; _0x24d0974e++)
            if (this._0x5e5d35ba[_0x24d0974e] != null)
                this._0x5e5d35ba[_0x24d0974e].color = _0xdc7245d7.BgTertiary;
    }

    private float _0x656ed5a4;
    private int[] _0xcea5ac9c;
    private RectTransform _0xa8580f1a;
    private void Update()
    {
        if (!this._0xb0f7b60f || this._0xcea5ac9c == null)
            return;
        this._0x050299ef += Time.deltaTime;
        if (this._0x050299ef < FlickerStep)
            return;
        this._0x050299ef = 0f;
        for (int _0x72f55e62 = 0; _0x72f55e62 < _0x80ffeb86.Rows; _0x72f55e62++)
        {
            this._0x92a32c76 = (this._0x92a32c76 + 1) % this._0xcea5ac9c.Length;
            this._0xff1fc8d0(_0x72f55e62, this._0xcea5ac9c[this._0x92a32c76], 0.4f);
        }
    }

    private bool _0xb0f7b60f;
    private float _0x050299ef;
    public _0x1ed714fa _0x71aeb091(RectTransform _0xe69ef5e5, _0x51685ac3 _0x71b7a9b3, float _0xdfe23823, float _0x59b54e84, float _0x3aeed246)
    {
        this._0x35cc55e7 = _0x71b7a9b3;
        float height = _0x80ffeb86.Rows * _0x59b54e84 + (_0x80ffeb86.Rows - 1) * _0x3aeed246;
        this._0x656ed5a4 = _0x59b54e84 * 0.88f;
        this._0xa8580f1a = _0x211a051a.Box(_0xe69ef5e5, _0xade6b3f8._0x431fd94f(new byte[4] { 4, 51, 51, 58 }, 86), _0xdfe23823, 0.5f, _0x59b54e84, height);
        for (int _0xf185c08d = 0; _0xf185c08d < _0x80ffeb86.Rows; _0xf185c08d++)
        {
            float _0xdf2032b3 = (height - _0x59b54e84 * 0.5f - _0xf185c08d * (_0x59b54e84 + _0x3aeed246)) / height;
            RectTransform _0x30d967d6 = _0x211a051a.Box(this._0xa8580f1a, _0xade6b3f8._0x431fd94f(new byte[4] { 194, 228, 237, 237 }, 129), 0.5f, _0xdf2032b3, _0x59b54e84, _0x59b54e84);
            this._0x5e5d35ba[_0xf185c08d] = _0x211a051a.Plate(_0x30d967d6, _0xade6b3f8._0x431fd94f(new byte[5] { 130, 190, 179, 166, 183 }, 210), _0x71b7a9b3._0x9bc213f0, _0xdc7245d7.BgTertiary, 3.2f);
            this._0x71d24ef0[_0xf185c08d] = _0x211a051a.Picture(_0x30d967d6, _0xade6b3f8._0x431fd94f(new byte[3] { 205, 254, 248 }, 140), null, 0.5f, 0.5f, this._0x656ed5a4, this._0x656ed5a4, Color.white);
        }

        return this;
    }

    private _0x51685ac3 _0x35cc55e7;
    /// <summary>Highlights one cell of this reel as part of a paying line.</summary>
    public void _0x57c13242(int _0x7ca70231, bool _0x35e1a485)
    {
        if (_0x7ca70231 < 0 || _0x7ca70231 >= _0x80ffeb86.Rows)
            return;
        if (this._0x5e5d35ba[_0x7ca70231] != null)
            this._0x5e5d35ba[_0x7ca70231].color = _0xdc7245d7.ScarletDeep;
        RectTransform _0xcdd33bb1 = this._0x71d24ef0[_0x7ca70231] == null ? null : this._0x71d24ef0[_0x7ca70231].rectTransform;
        if (_0xcdd33bb1 == null || _0x35e1a485)
            return;
        DOTween.Kill(_0xcdd33bb1, true);
        _0xcdd33bb1.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.25f, 6, 0.7f).SetLink(_0xcdd33bb1.gameObject);
    }

    private void OnDestroy()
    {
        if (this._0xa8580f1a != null)
            DOTween.Kill(this._0xa8580f1a);
        for (int _0x26ac35ca = 0; _0x26ac35ca < _0x80ffeb86.Rows; _0x26ac35ca++)
            if (this._0x71d24ef0[_0x26ac35ca] != null)
                DOTween.Kill(this._0x71d24ef0[_0x26ac35ca].rectTransform);
    }
}

internal static class _0xade6b3f8
{
    internal static string _0x431fd94f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}