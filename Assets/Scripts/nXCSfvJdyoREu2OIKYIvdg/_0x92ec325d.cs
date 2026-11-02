using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A controlled burst of twenty-four tweened quads. Purely transform animation - the
/// game drives nothing by simulation, so no simulated bodies exist anywhere in it.
/// </summary>
public sealed class _0x92ec325d : MonoBehaviour
{
    public _0x92ec325d _0xb3465c94(RectTransform _0x880d68b6, _0x51685ac3 _0x0eb5088d)
    {
        this._0xa9b02f67 = _0x211a051a.Stretch(_0x880d68b6, _0xd5e4e952._0xaff6427f(new byte[8] { 179, 159, 158, 150, 149, 132, 132, 153 }, 240));
        for (int _0x1d1f4027 = 0; _0x1d1f4027 < QuadCount; _0x1d1f4027++)
        {
            RectTransform _0x2ea8d939 = _0x211a051a.Box(this._0xa9b02f67, _0xd5e4e952._0xaff6427f(new byte[4] { 111, 75, 95, 90 }, 62), 0.5f, 0.5f, 26f, 38f);
            Image _0x0772b40a = _0x2ea8d939.gameObject.AddComponent<Image>();
            _0x0772b40a.sprite = _0x0eb5088d._0x9bc213f0;
            _0x0772b40a.type = _0x0eb5088d._0x9bc213f0 == null ? Image.Type.Simple : Image.Type.Sliced;
            _0x0772b40a.color = this._0x11501a8c(_0x1d1f4027);
            _0x0772b40a.raycastTarget = false;
            _0x0772b40a.pixelsPerUnitMultiplier = 8f;
            _0x211a051a.Slice(_0x0772b40a, 8f);
            this._0xad20a59f[_0x1d1f4027] = _0x2ea8d939;
            this._0x264b2cfc[_0x1d1f4027] = _0x0772b40a;
        }

        this._0xa9b02f67.gameObject.SetActive(false);
        return this;
    }

    /// <summary>Fires from a point given in fractions of the parent rect.</summary>
    public void _0x3bd2bfe7(float _0x718c4c01, float _0xd7e84cf7)
    {
        if (this._0xa9b02f67 == null)
            return;
        if (_0x0331a644._0x5255fac2)
            return;
        this._0xa9b02f67.gameObject.SetActive(true);
        this._0xa9b02f67.SetAsLastSibling();
        for (int _0x7fe176cd = 0; _0x7fe176cd < QuadCount; _0x7fe176cd++)
        {
            RectTransform _0x8d6f6fbf = this._0xad20a59f[_0x7fe176cd];
            if (_0x8d6f6fbf == null)
                continue;
            DOTween.Kill(_0x8d6f6fbf, true);
            DOTween.Kill(this._0x264b2cfc[_0x7fe176cd], true);
            _0x8d6f6fbf.anchorMin = new Vector2(_0x718c4c01, _0xd7e84cf7);
            _0x8d6f6fbf.anchorMax = new Vector2(_0x718c4c01, _0xd7e84cf7);
            _0x8d6f6fbf.anchoredPosition = Vector2.zero;
            _0x8d6f6fbf.localScale = Vector3.one;
            _0x8d6f6fbf.localEulerAngles = Vector3.zero;
            this._0x264b2cfc[_0x7fe176cd].color = _0xdc7245d7.WithAlpha(this._0x11501a8c(_0x7fe176cd), 1f);
            float _0xb13e577e = (_0x7fe176cd / (float)QuadCount) * Mathf.PI * 2f;
            float _0xeddb9370 = 260f + (_0x7fe176cd % 5) * 60f;
            Vector2 _0x5156c69a = new Vector2(Mathf.Cos(_0xb13e577e) * _0xeddb9370, Mathf.Sin(_0xb13e577e) * _0xeddb9370 * 1.25f + 120f);
            _0x8d6f6fbf.DOAnchorPos(_0x5156c69a, Duration).SetEase(Ease.OutCubic).SetLink(_0x8d6f6fbf.gameObject);
            _0x8d6f6fbf.DOLocalRotate(new Vector3(0f, 0f, 220f + _0x7fe176cd * 11f), Duration).SetEase(Ease.OutQuad).SetLink(_0x8d6f6fbf.gameObject);
            this._0x264b2cfc[_0x7fe176cd].DOFade(0f, Duration).SetEase(Ease.InQuad).SetLink(_0x8d6f6fbf.gameObject);
        }

        DOVirtual.DelayedCall(Duration + 0.05f, () => this._0xd3dffa58()).SetLink(this._0xa9b02f67.gameObject);
    }

    private Color _0x11501a8c(int _0x5ff143a2)
    {
        int _0xf3638c21 = _0x5ff143a2 % 3;
        if (_0xf3638c21 == 0)
            return _0xdc7245d7.GoldShimmer;
        if (_0xf3638c21 == 1)
            return _0xdc7245d7.Scarlet;
        return _0xdc7245d7.Jackpot;
    }

    private readonly RectTransform[] _0xad20a59f = new RectTransform[QuadCount];
    private RectTransform _0xa9b02f67;
    private const float Duration = 1.1f;
    private const int QuadCount = 24;
    private void OnDestroy()
    {
        for (int _0x676c3bb9 = 0; _0x676c3bb9 < QuadCount; _0x676c3bb9++)
        {
            if (this._0xad20a59f[_0x676c3bb9] != null)
                DOTween.Kill(this._0xad20a59f[_0x676c3bb9]);
            if (this._0x264b2cfc[_0x676c3bb9] != null)
                DOTween.Kill(this._0x264b2cfc[_0x676c3bb9]);
        }

        if (this._0xa9b02f67 != null)
            DOTween.Kill(this._0xa9b02f67);
    }

    private void _0xd3dffa58()
    {
        if (this._0xa9b02f67 != null)
            this._0xa9b02f67.gameObject.SetActive(false);
    }

    private readonly Image[] _0x264b2cfc = new Image[QuadCount];
}

internal static class _0xd5e4e952
{
    internal static string _0xaff6427f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}