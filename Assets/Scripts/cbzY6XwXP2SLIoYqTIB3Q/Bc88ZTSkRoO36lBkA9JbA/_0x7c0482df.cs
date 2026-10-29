using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x7c0482df : MonoBehaviour
{
    private static void ApplySafeAreaToAll()
    {
        for (int _0xf010f0e1 = 0; _0xf010f0e1 < _0x7bd549df.Count; _0xf010f0e1++)
            _0x7bd549df[_0xf010f0e1]._0x3607f745();
    }

    private RectTransform _0xbda9e764;
    private void Awake()
    {
        if (!_0x7bd549df.Contains(this))
            _0x7bd549df.Add(this);
        this._0xb5845f31 = this.GetComponent<Canvas>();
        this._0x46b675d1 = this.GetComponent<CanvasScaler>();
        if (this._0x46b675d1 != null)
            this._0x5f1e2e01 = this._0x46b675d1.referenceResolution;
        this._0x9b672c84 = this.GetComponent<RectTransform>();
        this._0xbda9e764 = this.transform.Find(_0x1ec154a5._0xfc3e5b98(new byte[8] { 8, 58, 61, 62, 26, 41, 62, 58 }, 91)) as RectTransform;
        if (!_0x87e38782)
        {
            _0xf13538dd = Screen.orientation;
            _0x37b3917c.x = Screen.width;
            _0x37b3917c.y = Screen.height;
            _0x4f413877 = Screen.safeArea;
            _0x87e38782 = true;
        }

        this._0x3607f745();
    }

    private static Vector2 _0x37b3917c = Vector2.zero;
    private static void ResolutionChanged()
    {
        _0x37b3917c.x = Screen.width;
        _0x37b3917c.y = Screen.height;
        _0x4f413877 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x0359a9b6.Invoke();
    }

    private static void OrientationChanged()
    {
        _0xf13538dd = Screen.orientation;
        _0x37b3917c.x = Screen.width;
        _0x37b3917c.y = Screen.height;
        _0x4f413877 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x0359a9b6.Invoke();
    }

    private Vector2 _0x5f1e2e01;
    private void OnDestroy()
    {
        if (_0x7bd549df != null && _0x7bd549df.Contains(this))
            _0x7bd549df.Remove(this);
    }

    private static readonly List<_0x7c0482df> _0x7bd549df = new();
    private CanvasScaler _0x46b675d1;
    private static void SafeAreaChanged()
    {
        _0x4f413877 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static Rect _0x4f413877 = Rect.zero;
    private void _0x3607f745()
    {
        if (this._0xbda9e764 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xa4952eb5 = Screen.safeArea;
        Vector2 _0xea8c4123 = _0xa4952eb5.position;
        Vector2 _0xe9fa034c = _0xa4952eb5.position + _0xa4952eb5.size;
        _0xea8c4123.x /= screenWidth;
        _0xea8c4123.y /= screenHeight;
        _0xe9fa034c.x /= screenWidth;
        _0xe9fa034c.y /= screenHeight;
        this._0xbda9e764.anchorMin = _0xea8c4123;
        this._0xbda9e764.anchorMax = _0xe9fa034c;
        this._0xbda9e764.offsetMin = Vector2.zero;
        this._0xbda9e764.offsetMax = Vector2.zero;
        if (this._0x46b675d1 == null)
            return;
        Vector2 _0xc26a2498 = _0xe9fa034c - _0xea8c4123;
        float _0xf66589cf = 2f - _0xc26a2498.x;
        float _0x82b777ef = 2f - _0xc26a2498.y;
        this._0x46b675d1.referenceResolution = this._0x5f1e2e01 * new Vector2(_0xf66589cf, _0x82b777ef);
    }

    private void Start()
    {
    }

    private static ScreenOrientation _0xf13538dd = ScreenOrientation.LandscapeLeft;
    private static UnityEvent _0x0359a9b6 = new();
    private RectTransform _0x9b672c84;
    private Canvas _0xb5845f31;
    private static bool _0x87e38782;
    private void Update()
    {
        if (_0x7bd549df.Count == 0 || _0x7bd549df[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xf13538dd)
            OrientationChanged();
        if (Screen.safeArea != _0x4f413877)
            SafeAreaChanged();
        if (Screen.width != _0x37b3917c.x || Screen.height != _0x37b3917c.y)
            ResolutionChanged();
    }
}

internal static class _0x1ec154a5
{
    internal static string _0xfc3e5b98(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}